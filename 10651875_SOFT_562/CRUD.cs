//
// The C# Code to perform CRUD operations on the database
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
    public partial class CRUD : Form
    {
        public CRUD()
        {
            InitializeComponent();
        }

        // Code section to perform the insert query
        private void button1_Click(object sender, EventArgs e)
        {
            // Check if Userid is not empty
            if (string.IsNullOrWhiteSpace(txtuserid.Text))
            {
                MessageBox.Show("Provide Userid Please");
            }
            else
            {


                string connectionString = "SERVER=" + DBConnect.SERVER + ";" +
                        "DATABASE=" + DBConnect.DATABASE_NAME + ";" + "UID=" +
                        DBConnect.USER_NAME + ";" + "PASSWORD=" +
                        DBConnect.PASSWORD + ";" + "SslMode=" +
                        DBConnect.SslMode + ";";


                using (MySqlConnection connection =
                    new MySqlConnection(connectionString))
                {


                    // SQL query to perform the insert operation
                    string query = "INSERT INTO soft562_olugbenga.user (userid, firstname, lastname, hometown, currenttown, gender, relationshipstatus) VALUES ('" + txtuserid.Text + "', '" + txtfirstname.Text + "', '" + txtlastname.Text + "', '" + txthometown.Text + "', '" + txtcurrenttown.Text + "', '" + comboBoxgender.Text + "', '" + comboBoxrelationshipstatus.Text + "');";


                    connection.Open();


                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable customerDataTable = new DataTable();
                    sqlDA.Fill(customerDataTable);

                    MessageBox.Show("Insert Successful");

                    connection.Close();
                    // End of insert operation
                }
            }
        }

        // Code section to perform the Update operation
        private void button3_Click(object sender, EventArgs e)
        {
            // Check if Userid is not empty
            if (string.IsNullOrWhiteSpace(txtuserid.Text))
            {
                MessageBox.Show("Provide Userid Please");
            }
            else
            {
                string connectionString = "SERVER=" + DBConnect.SERVER + ";" +
                        "DATABASE=" + DBConnect.DATABASE_NAME + ";" + "UID=" +
                        DBConnect.USER_NAME + ";" + "PASSWORD=" +
                        DBConnect.PASSWORD + ";" + "SslMode=" +
                        DBConnect.SslMode + ";";


                using (MySqlConnection connection =
                    new MySqlConnection(connectionString))
                {

                    // SQL query to perform the update section
                    string query = "UPDATE soft562_olugbenga.user SET firstname = '" + txtfirstname.Text + "', lastname = '" + txtlastname.Text + "', hometown = '" + txthometown.Text + "', currenttown = '" + txtcurrenttown.Text + "', gender = '" + comboBoxgender.Text + "', relationshipstatus = '" + comboBoxrelationshipstatus.Text + "' WHERE userid = '" + txtuserid.Text + "';";


                    connection.Open();


                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable customerDataTable = new DataTable();
                    sqlDA.Fill(customerDataTable);

                    MessageBox.Show("Update Successful");

                    connection.Close();
                    // End of Update query
                }
            }
        }

        // Code for window to perform the Delete operation
        private void button2_Click(object sender, EventArgs e)
        {
            delete obj = new delete();
            if (obj == null)
            {
                obj.Parent = this;
            }
            obj.Show();
            this.Hide();
            // End of Delete operation
        }
        

        // Code section to clear textbox
        private void button4_Click(object sender, EventArgs e)
        {
            txtcurrenttown.Clear();
            txtfirstname.Clear();
            txthometown.Clear();
            txtlastname.Clear();
            txtuserid.Clear();

            // End of code to clear textbox
        }

        // Code section to take you to the facebook database
        private void button5_Click(object sender, EventArgs e)
        {
            facebookUsers obj = new facebookUsers();
            if (obj == null)
            {
                obj.Parent = this;
            }
            obj.Show();
            this.Hide();

            // End of code to the facebook database
        }

        // Validate the input for the userid
        private void txtuserid_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if(!Char.IsDigit(chr) && chr != 8) 
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid userid");
            }
        }

        // Data validation for the firstname
        private void txtfirstname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        // Data validation for the lastname
        private void txtlastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        
    }
}