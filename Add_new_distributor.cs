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
    public partial class Add_new_distributor : Form
    {
        private int selectedId = -1;

        public Add_new_distributor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string distributorName = textBox1.Text;
            string distributorCompanyName = textBox2.Text;
            string contact = textBox3.Text;
            string address = textBox4.Text;
            string city= textBox5.Text;

            string query = "INSERT INTO Distributor (distributor_name, distributor_company_name, contact, address, city) VALUES (@distributor_name,@distributor_company_name,@contact,@address,@city)";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter ("@distributor_name",distributorName),
                new SqlParameter ("@distributor_company_name",distributorCompanyName),
                new SqlParameter ("@contact",contact),
                new SqlParameter ("@address",address),
                new SqlParameter ("@city",city),
            };

            DataBaseUtility.ExecuteNonQuery(query, parameters);

            string query2 = "SELECT * FROM Distributor";

            DataBaseUtility.FillDataGridView(dataGridView1, query2);

            MessageBox.Show("Distributor added");
            
        }


        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Add_new_distributor_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Distributor";

            DataBaseUtility.FillDataGridView(dataGridView1, query);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
  
            DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
            selectedId = Convert.ToInt32(selectedRow.Cells["id"].Value);
            string query = "SELECT * FROM Distributor WHERE id=@ID";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter ("@ID", selectedId)
            };

            DataTable dataTable = DataBaseUtility.GetDataTable(query, parameters);

            foreach (DataRow datarow in dataTable.Rows)
            {
                textBox10.Text = datarow["distributor_name"].ToString();
                textBox9.Text = datarow["distributor_company_name"].ToString();
                textBox8.Text = datarow["contact"].ToString();
                textBox7.Text = datarow["address"].ToString();
                textBox6.Text = datarow["city"].ToString();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string updateDataGrid = "SELECT * FROM Distributor";

            string newDistributorName = textBox10.Text;
            string newDistCompanyName = textBox9.Text;
            string contact = textBox8.Text;
            string address = textBox7.Text;
            string city = textBox6.Text;

            string updateQuery = "UPDATE Distributor SET distributor_name = @distributor_name, distributor_company_name = @distributor_company_name, contact = @contact, address = @address, city=@city WHERE Id = @id";

            List<SqlParameter> sqlParameters = new List<SqlParameter>
            {
                new SqlParameter("@distributor_name", newDistributorName),
                new SqlParameter("@distributor_company_name", newDistCompanyName),
                new SqlParameter("@contact", contact),
                new SqlParameter("@address", address),
                new SqlParameter("@city", city),
                new SqlParameter("@id", selectedId),
                
            };
            DataBaseUtility.ExecuteNonQuery(updateQuery,sqlParameters);
            DataBaseUtility.FillDataGridView(dataGridView1, updateDataGrid);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM Distributor WHERE Id=@id";
            string updateDataGrid = "SELECT * FROM Distributor";
            List<SqlParameter> sqlParameters = new List<SqlParameter>
            {
                new SqlParameter("@id", selectedId)
            };

            DataBaseUtility.ExecuteNonQuery(deleteQuery, sqlParameters);
            DataBaseUtility.FillDataGridView(dataGridView1, updateDataGrid);
        }
    }
}
