using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventoryApp
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AunthenticateUser(textBox1.Text, textBox2.Text))
            {
                this.Hide();
                MDIParent1 mdi = new MDIParent1();
                mdi.Show();
            }
        }

        private bool AunthenticateUser(string username, string password)
        {
            string query = "SELECT * FROM registration WHERE username = @username AND password = @password";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter ("@username", username),
                new SqlParameter ("password", password)
            };

            int userCount = DataBaseUtility.ExecuteCountQuery(query, parameters);

            return userCount > 0;

        }


        private void Login_Load(object sender, EventArgs e)
        {
          //  DataBaseUtility.OpenConnection();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
