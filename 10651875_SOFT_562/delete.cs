//
// Code section to perform the delete operation
//
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

namespace soft562coursework
{
    public partial class delete : Form
    {
        public delete()
        {
            InitializeComponent();
        }
        // Delete the user from the database
        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "SERVER=" + DBConnect.SERVER + ";" +
                    "DATABASE=" + DBConnect.DATABASE_NAME + ";" + "UID=" +
                    DBConnect.USER_NAME + ";" + "PASSWORD=" +
                    DBConnect.PASSWORD + ";" + "SslMode=" +
                    DBConnect.SslMode + ";";


            using (MySqlConnection connection =
                new MySqlConnection(connectionString))
            {

                // SQL query to perform Delete operation
                string query = "DELETE FROM soft562_olugbenga.user WHERE userid = '" + textboxdel.Text + "';";


                connection.Open();


                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                DataTable customerDataTable = new DataTable();
                sqlDA.Fill(customerDataTable);

                MessageBox.Show("Delete Successful");

                connection.Close();
            }
        }

        // Back to the CRUD window
        private void button2_Click(object sender, EventArgs e)
        {
            CRUD obj = new CRUD();
            if (obj == null)
            {
                obj.Parent = this;
            }
            obj.Show();
            this.Hide();
        }
    }
}
