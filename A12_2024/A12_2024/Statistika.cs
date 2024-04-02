using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace A12_2024
{
    public partial class Statistika : Form
    {
        public Statistika()
        {
            InitializeComponent();
        }
        string stringkonekcije = "Data Source=dell-pc;Initial Catalog=A12-2023;User ID=sa;Password=Tesla1980";
        private void Statistika_Load(object sender, EventArgs e)
        {
            nacrtajgrafik();
        }
        private void nacrtajgrafik()
        {
            string upit = "select Stadion.Naziv as 'Stadion', count(*) as 'Broj' from Stadion";
            upit += " join Klub on Stadion.StadionID=Klub.StadionID";
            upit += " join Utakmica on Klub.KlubID=Utakmica.DomacinID";
            upit += " group by Stadion.Naziv;";
            SqlConnection konekcija = new SqlConnection(stringkonekcije);
            SqlCommand komanda = new SqlCommand(upit, konekcija);
            SqlDataReader mojReader;
            
            try
            {
                konekcija.Open();
                mojReader = komanda.ExecuteReader();
                chart1.Series["Broj"].Points.Clear();
                while (mojReader.Read())
                {
                    string stadion = mojReader["Stadion"].ToString();
                    int brojUtakmica = Convert.ToInt32(mojReader["Broj"]);

                    chart1.Series["Broj"].Points.AddXY(stadion,brojUtakmica);
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
    }
}
