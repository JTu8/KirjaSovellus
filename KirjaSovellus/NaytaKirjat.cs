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
    public partial class NaytaKirjat : Form
    {

        Form1 parent = null;

        public NaytaKirjat(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnNayta_Click(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Database=kirjat;UID=root;password=''";

            try { 

                string query = "SELECT * FROM data";
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dgShowKirjat.DataSource = ds.Tables[0];
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Virhe");
            }

        }

        private void dgShowKirjat_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            string connString = "Server=localhost;Database=kirjat;UID=root;password=''";

            string query = "SELECT * FROM data";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataTable muutos = ((DataTable)dgShowKirjat.DataSource).GetChanges();

                    if (muutos != null)
                    {
                        MySqlCommandBuilder myBuilder = new MySqlCommandBuilder(adapter);
                        adapter.UpdateCommand = myBuilder.GetUpdateCommand();
                        adapter.Update(muutos);
                        ((DataTable)dgShowKirjat.DataSource).AcceptChanges();
                    }
                }
            }
        }
    }
}
