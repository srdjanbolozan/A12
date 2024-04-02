using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace A12_2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string stringkonekcije = "Data Source=dell-pc;Initial Catalog=A12-2023;User ID=sa;Password=Tesla1980";
        private void Form1_Load(object sender, EventArgs e)
        {
            Ispis();
            dodajGradoveUcmbGrad();
        }
        //ispis tabele Stadion u ListView
        private void Ispis()
        {
            string upit = "select StadionID, Naziv,Adresa, Kapacitet, BrojUlaza, Grad from Stadion join Grad on Stadion.GradID=Grad.GradID;";
            SqlConnection konekcija = new SqlConnection(stringkonekcije);
            SqlCommand komanda = new SqlCommand(upit, konekcija);
            SqlDataReader mojReader;
            string[] niz = new string[6];
            ListViewItem red;
            try
            {
                konekcija.Open();
                mojReader = komanda.ExecuteReader();
                listView1.Items.Clear();
                while (mojReader.Read())
                {
                    niz[0] = mojReader["StadionID"].ToString();
                    niz[1] = mojReader["Naziv"].ToString();
                    niz[2] = mojReader["Adresa"].ToString();
                    niz[3] = mojReader["Kapacitet"].ToString();
                    niz[4] = mojReader["BrojUlaza"].ToString();
                    niz[5] = mojReader["Grad"].ToString();

                    red = new ListViewItem(niz);
                    listView1.Items.Add(red);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                konekcija.Close();
            }
        }
        //prikazivanje selektovanog reda
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count>0)
            {
                txtSifra.Text = listView1.SelectedItems[0].SubItems[0].Text;
                txtNaziv.Text = listView1.SelectedItems[0].SubItems[1].Text;
                txtAdresa.Text= listView1.SelectedItems[0].SubItems[2].Text;
                numericUpDownKapacitet.Value = Convert.ToDecimal(listView1.SelectedItems[0].SubItems[3].Text);
                numericUpDownBrojUlaza.Value = Convert.ToDecimal(listView1.SelectedItems[0].SubItems[4].Text);
                cmbGrad.Text= listView1.SelectedItems[0].SubItems[5].Text;
            }
        }
        //pretraga stadiona po drzavi
        private void button1_Click(object sender, EventArgs e)
        {
            Pretraga pretraga = new Pretraga();
            pretraga.ShowDialog();
            string drzava = pretraga.drzava;
            string upit = "select StadionID, Naziv,Adresa, Kapacitet, BrojUlaza, Grad from Stadion join Grad on Stadion.GradID=Grad.GradID;";
            
            if (drzava!="")
            {
                upit = "select StadionID, Stadion.Naziv,Adresa, Kapacitet, BrojUlaza, Grad from Stadion join Grad on Stadion.GradID=Grad.GradID join Drzava on Grad.DrzavaID=Drzava.DrzavaID where Drzava.Naziv='"+drzava+"';";
            }
            
            SqlConnection konekcija = new SqlConnection(stringkonekcije);
            SqlCommand komanda = new SqlCommand(upit, konekcija);
            SqlDataReader mojReader;
            string[] niz = new string[6];
            ListViewItem red;
            try
            {
                konekcija.Open();
                mojReader = komanda.ExecuteReader();
                listView1.Items.Clear();
                while (mojReader.Read())
                {
                    niz[0] = mojReader["StadionID"].ToString();
                    niz[1] = mojReader["Naziv"].ToString();
                    niz[2] = mojReader["Adresa"].ToString();
                    niz[3] = mojReader["Kapacitet"].ToString();
                    niz[4] = mojReader["BrojUlaza"].ToString();
                    niz[5] = mojReader["Grad"].ToString();

                    red = new ListViewItem(niz);
                    listView1.Items.Add(red);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                konekcija.Close();
            }
        }
        //dodavanje gradova u cmbGrad
        private void dodajGradoveUcmbGrad()
        {
            string upit = "select Grad from Grad order by GradID;";
            SqlConnection konekcija = new SqlConnection(stringkonekcije);
            SqlCommand komanda = new SqlCommand(upit, konekcija);
            SqlDataReader mojReader;
            
            try
            {
                konekcija.Open();
                mojReader = komanda.ExecuteReader();
                cmbGrad.Items.Clear();
                while (mojReader.Read())
                {
                    cmbGrad.Items.Add(mojReader["Grad"]);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                konekcija.Close();
            }
        }
        //izmena
        private void button2_Click(object sender, EventArgs e)
        {
            int gradID = cmbGrad.SelectedIndex + 1;
            int kapacitet = Convert.ToInt32(numericUpDownKapacitet.Value);
            int brojUlaza = Convert.ToInt32(numericUpDownBrojUlaza.Value);
            string upit = "update Stadion set Naziv='"+txtNaziv.Text+"', Adresa='"+txtAdresa.Text+"', Kapacitet='"+kapacitet+"', BrojUlaza='"+brojUlaza+"', GradID='"+gradID+"' where StadionID='"+txtSifra.Text+"';";
            SqlConnection konekcija = new SqlConnection(stringkonekcije);
            SqlCommand komanda = new SqlCommand(upit, konekcija);           

            try
            {
                konekcija.Open();
                komanda.ExecuteNonQuery();
                Ispis();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                konekcija.Close();
            }
        }
        //otvaranje forme statistika
        private void button4_Click(object sender, EventArgs e)
        {
            Statistika statistika = new Statistika();
            statistika.Show();
        }
        //zatvaranje forme
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
