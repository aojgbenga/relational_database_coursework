//
// C# Code to display all the users with the corresponding combobox queries
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
    public partial class facebookUsers : Form
    {
        public facebookUsers()
        {
            InitializeComponent();
        }


        private void comboBoxFacebook_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 1 List the users with the largest number of friends (sorted by number of friends)
            if (comboBoxFacebook.SelectedIndex == 0)
            {


                string connectionString = "SERVER=" + DBConnect.SERVER + ";" +
                    "DATABASE=" + DBConnect.DATABASE_NAME + ";" + "UID=" +
                    DBConnect.USER_NAME + ";" + "PASSWORD=" +
                    DBConnect.PASSWORD + ";" + "SslMode=" +
                    DBConnect.SslMode + ";";


                using (MySqlConnection connection =
                    new MySqlConnection(connectionString))
                {

                    // SQL query to display the largest number of friends
                    string query = "SELECT COUNT(friendship.friendid) AS TotalFriend, user.userid, user.firstname, user.lastname, user.gender, user.currenttown, user.hometown, user.relationshipstatus from user INNER JOIN friendship ON user.userid = friendship.userid GROUP BY userid ORDER BY TotalFriend DESC limit 1000;";


                    connection.Open();


                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable customerDataTable = new DataTable();
                    sqlDA.Fill(customerDataTable);


                    dataGridView.DataSource = customerDataTable;

                } // End of largest number of friends code
            }

            // 2 List the users whose user ID is a multiple of 985 (sorted by user ID)
            else if (comboBoxFacebook.SelectedIndex == 1)
            {


                string connectionString = "SERVER=" + DBConnect.SERVER + ";" +
                    "DATABASE=" + DBConnect.DATABASE_NAME + ";" + "UID=" +
                    DBConnect.USER_NAME + ";" + "PASSWORD=" +
                    DBConnect.PASSWORD + ";" + "SslMode=" +
                    DBConnect.SslMode + ";";


                using (MySqlConnection connection =
                    new MySqlConnection(connectionString))
                {
                    // SQL query for users with ID of 985
                    string query = "SELECT * FROM user WHERE userid IN (985, 1970, 2955, 3940, 4925, 5910, 6895, 7880, 8865, 9850, 10835, 11820, 12805, 13790, 14775, 15760, 16745, 17730, 18715, 19700, 20685, 21670, 22655, 23640, 24625, 25610, 26595, 27580, 28565, 29550, 30535, 31520, 32505, 33490, 34475, 35460, 36445, 37430, 38415, 39400, 40385, 41370, 42355, 43340, 44325, 45310, 46295, 47280, 48265, 49250, 50235, 51220, 52205, 53190, 54175, 55160, 56145, 57130, 58115, 59100, 60085, 61070, 62055, 63040) ORDER BY userid ASC;";


                    connection.Open();


                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable customerDataTable = new DataTable();
                    sqlDA.Fill(customerDataTable);


                    dataGridView.DataSource = customerDataTable;

                } // End of users with ID of 985 code
            }
            // 3. List the male users (sorted alphabetically by first name)
            else if (comboBoxFacebook.SelectedIndex == 2)
            {


                string connectionString = "SERVER=" + DBConnect.SERVER + ";" +
                    "DATABASE=" + DBConnect.DATABASE_NAME + ";" + "UID=" +
                    DBConnect.USER_NAME + ";" + "PASSWORD=" +
                    DBConnect.PASSWORD + ";" + "SslMode=" +
                    DBConnect.SslMode + ";";


                using (MySqlConnection connection =
                    new MySqlConnection(connectionString))
                {
                    // SQL code for male users
                    string query = "SELECT * FROM user WHERE gender =\"Male\" ORDER BY firstname ASC limit 1000;";


                    connection.Open();


                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable customerDataTable = new DataTable();
                    sqlDA.Fill(customerDataTable);


                    dataGridView.DataSource = customerDataTable;

                } // End of code for the male users
            }
            // # 4. List the female users whose user ID is a multiple of 985 (sorted by ID).
            else if (comboBoxFacebook.SelectedIndex == 3)
            {


                string connectionString = "SERVER=" + DBConnect.SERVER + ";" +
                    "DATABASE=" + DBConnect.DATABASE_NAME + ";" + "UID=" +
                    DBConnect.USER_NAME + ";" + "PASSWORD=" +
                    DBConnect.PASSWORD + ";" + "SslMode=" +
                    DBConnect.SslMode + ";";


                using (MySqlConnection connection =
                    new MySqlConnection(connectionString))
                {
                    // SQL query for felame users with ID of 985
                    string query = "SELECT * FROM user WHERE gender = \"Female\" AND userid IN (985, 1970, 2955, 3940, 4925, 5910, 6895, 7880, 8865, 9850, 10835, 11820, 12805, 13790, 14775, 15760, 16745, 17730, 18715, 19700, 20685, 21670, 22655, 23640, 24625, 25610, 26595, 27580, 28565, 29550, 30535, 31520, 32505, 33490, 34475, 35460, 36445, 37430, 38415, 39400, 40385, 41370, 42355, 43340, 44325, 45310, 46295, 47280, 48265, 49250, 50235, 51220, 52205, 53190, 54175, 55160, 56145, 57130, 58115, 59100, 60085, 61070, 62055, 63040) ORDER BY userid ASC limit 1000;";


                    connection.Open();


                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable customerDataTable = new DataTable();
                    sqlDA.Fill(customerDataTable);


                    dataGridView.DataSource = customerDataTable;

                } // End code of female users with ID 985
            }

            // 5. List the male users whose user ID is a multiple of 985 (sorted alphabetically by last name).
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
                    // SQL query for male users with ID multiple 985
                    string query = "SELECT * FROM user WHERE gender = \"Male\" AND userid IN (985, 1970, 2955, 3940, 4925, 5910, 6895, 7880, 8865, 9850, 10835, 11820, 12805, 13790, 14775, 15760, 16745, 17730, 18715, 19700, 20685, 21670, 22655, 23640, 24625, 25610, 26595, 27580, 28565, 29550, 30535, 31520, 32505, 33490, 34475, 35460, 36445, 37430, 38415, 39400, 40385, 41370, 42355, 43340, 44325, 45310, 46295, 47280, 48265, 49250, 50235, 51220, 52205, 53190, 54175, 55160, 56145, 57130, 58115, 59100, 60085, 61070, 62055, 63040) ORDER BY lastname ASC limit 500;";


                    connection.Open();

                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable productDataTable = new DataTable();
                    sqlDA.Fill(productDataTable);

                    dataGridView.DataSource = productDataTable;
                }// End of male users with ID multiple 985
            } // End of if else condition
        } // End of private void comboBoxQuery

        // Button to the CRUD windowns form
        private void crud_Click(object sender, EventArgs e)
        {
            CRUD obj = new CRUD();
            if (obj == null)
            {
                obj.Parent = this;
            }
            obj.Show();
            this.Hide();
        }

        // Button to show all the users in the database
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
                // SQL query to show all the users
                string query = "SELECT * FROM soft562_olugbenga.user limit 1000;";


                connection.Open();


                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                DataTable customerDataTable = new DataTable();
                sqlDA.Fill(customerDataTable);


                dataGridView.DataSource = customerDataTable;

                connection.Close();
                // End of users button
            }
        }
    }
}
