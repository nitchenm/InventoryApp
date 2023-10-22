using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace InventoryApp
{
    public partial class Add_new_user : Form
    {
        public Add_new_user()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstname = textBox1.Text;
            string lastname = textBox2.Text;
            string username = textBox3.Text;
            string password = textBox4.Text;
            string email = textBox5.Text;
            string contact = textBox6.Text;

            string selectquery = "SELECT COUNT(*) FROM registration WHERE username = @username";

            List<SqlParameter> parameter = new List<SqlParameter>
            {
                new SqlParameter("@username", username),
            };


            int usercount = DataBaseUtility.ExecuteCountQuery(selectquery, parameter);

            if (usercount == 0) {


                string insertQuery = "INSERT INTO registration (firstname, lastname, username, password, email, contact) VALUES(@firstname, @lastname, @username, @password, @email, @contact)";

                List<SqlParameter> insertParameters = new List<SqlParameter>
                {
                new SqlParameter("@firstname", firstname),
                new SqlParameter("@lastname", lastname),
                new SqlParameter("@username", username),
                new SqlParameter("@password", password),
                new SqlParameter("@email", email),
                new SqlParameter("@contact", contact)
                };

                DataBaseUtility.ExecuteNonQuery(insertQuery, insertParameters);
                Display();
                MessageBox.Show("User registered");

            } 
            else
            {
                MessageBox.Show("This username is already registered.");
            }
        }

        private void Add_new_user_Load(object sender, EventArgs e)
        {
          //  DataBaseUtility.OpenConnection();
            Display();
        }


        //Show the data from the registered users in the datagrid
        public void Display()
        {
            
            string query = "select * from registration";
            DataBaseUtility.FillDataGridView(dataGridView1, query);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
                string deleteQuery = "DELETE FROM registration WHERE id = @id";
                List<SqlParameter> deleteParameters = new List<SqlParameter>
                {
                    new SqlParameter("@id", id)
                };
                DataBaseUtility.ExecuteNonQuery(deleteQuery, deleteParameters);
                MessageBox.Show("User deleted");
                Display();
            }
        }
    }
}


