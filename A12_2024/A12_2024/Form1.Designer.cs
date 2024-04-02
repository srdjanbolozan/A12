
namespace A12_2024
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.numericUpDownKapacitet = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBrojUlaza = new System.Windows.Forms.NumericUpDown();
            this.cmbGrad = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKapacitet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBrojUlaza)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(357, 101);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(568, 300);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sifra";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Naziv";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Adresa";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Kapacitet";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Broj ulaza";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Grad";
            this.columnHeader6.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sifra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Naziv";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Adresa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kapacitet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Broj ulaza";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Grad";
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(100, 117);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(100, 26);
            this.txtSifra.TabIndex = 12;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(100, 162);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(241, 26);
            this.txtNaziv.TabIndex = 13;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(100, 210);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(241, 26);
            this.txtAdresa.TabIndex = 14;
            // 
            // numericUpDownKapacitet
            // 
            this.numericUpDownKapacitet.Location = new System.Drawing.Point(100, 259);
            this.numericUpDownKapacitet.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownKapacitet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownKapacitet.Name = "numericUpDownKapacitet";
            this.numericUpDownKapacitet.Size = new System.Drawing.Size(115, 26);
            this.numericUpDownKapacitet.TabIndex = 15;
            this.numericUpDownKapacitet.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numericUpDownBrojUlaza
            // 
            this.numericUpDownBrojUlaza.Location = new System.Drawing.Point(100, 310);
            this.numericUpDownBrojUlaza.Name = "numericUpDownBrojUlaza";
            this.numericUpDownBrojUlaza.Size = new System.Drawing.Size(86, 26);
            this.numericUpDownBrojUlaza.TabIndex = 16;
            // 
            // cmbGrad
            // 
            this.cmbGrad.FormattingEnabled = true;
            this.cmbGrad.Location = new System.Drawing.Point(100, 360);
            this.cmbGrad.Name = "cmbGrad";
            this.cmbGrad.Size = new System.Drawing.Size(189, 28);
            this.cmbGrad.TabIndex = 17;
            // 
            // button5
            // 
            this.button5.Image = global::A12_2024.Properties.Resources._38999_exit_icon;
            this.button5.Location = new System.Drawing.Point(851, 16);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(74, 64);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Image = global::A12_2024.Properties.Resources._206464_analytics_keynote_chart_icon;
            this.button4.Location = new System.Drawing.Point(771, 16);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(74, 64);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Image = global::A12_2024.Properties.Resources._32406_info_icon;
            this.button3.Location = new System.Drawing.Point(691, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 64);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = global::A12_2024.Properties.Resources._3213303_arrow_document_exchange_file_icon;
            this.button2.Location = new System.Drawing.Point(434, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 64);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = global::A12_2024.Properties.Resources._3069190_search_research_icon;
            this.button1.Location = new System.Drawing.Point(358, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 64);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 422);
            this.Controls.Add(this.cmbGrad);
            this.Controls.Add(this.numericUpDownBrojUlaza);
            this.Controls.Add(this.numericUpDownKapacitet);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKapacitet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBrojUlaza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.NumericUpDown numericUpDownKapacitet;
        private System.Windows.Forms.NumericUpDown numericUpDownBrojUlaza;
        private System.Windows.Forms.ComboBox cmbGrad;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}

