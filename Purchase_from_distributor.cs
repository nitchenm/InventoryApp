using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApp
{
    public partial class Purchase_from_distributor : Form
    {
        public Purchase_from_distributor()
        {
            InitializeComponent();
        }

        private void Purchase_from_distributor_Load(object sender, EventArgs e)
        {
            string distributorComboBox = "SELECT distributor_name FROM purchase_product";

            DataBaseUtility.FillComboBox(comboBox1, distributorComboBox);

            DataBaseUtility.RemoveDuplicateItemsFromComboBox(comboBox1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
            string selectedProduct = Convert.ToString(selectedRow.Cells["product_name"].Value);

            textBox1.Text = selectedProduct;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedBoxItem = comboBox1.SelectedItem as string;
            string query = "SELECT * FROM purchase_product WHERE distributor_name = '"+ selectedBoxItem + "'";
           
            
            DataBaseUtility.FillDataGridView(dataGridView1, query);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

      
    }
}
