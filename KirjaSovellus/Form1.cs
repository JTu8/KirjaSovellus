using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KirjaSovellus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLisaa_Click(object sender, EventArgs e)
        {
            string conn = "Server=localhost;Database=kirjat;UID=root;password=''";
            string vDate = DateTime.Parse(dateLainaus.Text).ToString("yyyy-MM-dd");
            string oDate = DateTime.Parse(dateOsto.Text).ToString("yyyy-MM-dd");
            

            try
            {
                string query = "INSERT INTO data(kirja_nimi, kirjailija_nimi, lainauspvm, ostopvm)" + 
                    "VALUES('"+ this.tbKirja.Text + "','" + this.tbKirjailija.Text + "','" + vDate + "','" + oDate +  "')";

                MySqlConnection con = new MySqlConnection(conn);
                MySqlCommand comm = new MySqlCommand(query, con);
                MySqlDataReader myReader;
                con.Open();
                myReader = comm.ExecuteReader();
                MessageBox.Show("Tiedot tallennettu");
                while (myReader.Read())
                {

                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            tbKirja.Text = String.Empty;
            tbKirjailija.Text = String.Empty;
        }

        private void btnNaytaKirjat_Click(object sender, EventArgs e)
        {
            NaytaKirjat n = new NaytaKirjat(this);
            n.Show();
        }
    }
}
