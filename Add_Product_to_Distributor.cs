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
    public partial class Add_Product_to_Distributor : Form
    {
        


        public Add_Product_to_Distributor()
        {
            InitializeComponent();
        }

        private void Purchase_product_Load(object sender, EventArgs e)
        {
            string distributorComboBox = "SELECT distributor_name FROM Distributor";
            string productNameComboBox = "SELECT product_name FROM product_name";
            string showDatagrid = "SELECT * FROM purchase_product";

            DataBaseUtility.FillComboBox(comboBox2, distributorComboBox);

            DataBaseUtility.FillComboBox(comboBox1, productNameComboBox);

            DataBaseUtility.FillDataGridView(dataGridView1, showDatagrid);


        }
        private void button1_Click(object sender, EventArgs e)
        {
            string productName = comboBox1.Text;
            string productQty = textBox1.Text;
            string distributorName = comboBox2.Text;
            string productPrice = textBox2.Text;
            string addingDate = dateTimePicker1.Text;

            string addQuery = "INSERT INTO purchase_product (product_name, product_qty, product_price, purchase_date, distributor_name) VALUES (@product_name, @product_qty,@product_price,@purchase_date,@distributor_name)";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter ("@product_name",productName),
                new SqlParameter ("@product_qty",productQty),
                new SqlParameter ("@product_price",productPrice),
                new SqlParameter ("@purchase_date",addingDate),
                new SqlParameter ("@distributor_name",distributorName),
            };

            DataBaseUtility.ExecuteNonQuery(addQuery, parameters);

            string updatequery = "SELECT * FROM purchase_product";

            DataBaseUtility.FillDataGridView(dataGridView1, updatequery);

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
