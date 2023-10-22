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
    public partial class Add_product_name : Form
    {
        private int selectedId = -1;
        public Add_product_name()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        private void Add_product_name_Load(object sender, EventArgs e)
        {
          
            DataBaseUtility.FillComboBox(comboBox1, "SELECT unit FROM unit");
            DataBaseUtility.FillDataGridView(dataGridView1, "SELECT * FROM product_name");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Gets the data from the textbox and combobox and then insert it in the datatable

            string productName = textBox1.Text;
            string unitOfMeasure = comboBox1.SelectedItem.ToString();

            string query = "INSERT INTO product_name (product_name, units) VALUES (@product_name, @unit)";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@product_name", productName),
                new SqlParameter("@unit", unitOfMeasure)
            };

            DataBaseUtility.ExecuteNonQuery(query, parameters);

            DataBaseUtility.FillDataGridView(dataGridView1, "SELECT * FROM product_name");

            MessageBox.Show("Product created succesfully");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Activates the panel and then from the selected row from the cellclick 
            // gets the data and show it in the panel.
            panel2.Visible = true;
            DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
            selectedId = Convert.ToInt32(selectedRow.Cells["id"].Value);
            string query1 = "SELECT unit FROM unit";
            string query2 = "SELECT * FROM product_name WHERE id=@ID";
          
            comboBox2.Items.Clear();

            //Shows the data from unit
            DataBaseUtility.FillComboBox(comboBox2, query1);

            //shows the selected row text data in the textbox and combobox
            List<SqlParameter> sqlParameters = new List<SqlParameter>
            {
                new SqlParameter("@ID", selectedId)
            };

            DataTable dataTable = DataBaseUtility.GetDataTable(query2, sqlParameters);
            foreach (DataRow dataRow in dataTable.Rows)
            {
                textBox2.Text = dataRow["product_name"].ToString();
                comboBox2.SelectedItem = dataRow["units"].ToString();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //This button works in the invisible panel to modify the data already existing in the datatable
            string updateDataGrid = "SELECT * FROM product_name";
            
            string newProductName = textBox2.Text;
            string newUnit = comboBox2.SelectedItem.ToString();

            string updateQuery = "UPDATE product_name SET product_name = @product_name, units = @unit WHERE id = @ID";

            List<SqlParameter> sqlParameters = new List<SqlParameter>
            {
                new SqlParameter ("@product_name", newProductName),
                new SqlParameter ("@unit", newUnit),  
                new SqlParameter("@ID", selectedId),
            };

            DataBaseUtility.ExecuteNonQuery(updateQuery, sqlParameters);

            panel2.Visible = false;

            DataBaseUtility.FillDataGridView(dataGridView1, updateDataGrid);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
