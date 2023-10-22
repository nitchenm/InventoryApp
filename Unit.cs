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
    public partial class Unit : Form
    {

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nitch\source\repos\InventoryApp\Inventory.mdf;Integrated Security=True");

        public Unit()
        {
            InitializeComponent();
        }

        private void Unit_Load(object sender, EventArgs e)
        {
            
          //  DataBaseUtility.OpenConnection();
            Display();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string unitName = textBox1.Text;

            if (!IsUnitExists(unitName))
            {
                InsertUnit(unitName);
                Display();
            }
            else
            {
                MessageBox.Show("This unit is already added.");
            }
        }

        private bool IsUnitExists(string unitName)
        {
            string query = "SELECT COUNT(*) FROM unit WHERE unit = @unit";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@unit", unitName)
            };

            int unitCount = DataBaseUtility.ExecuteCountQuery(query, parameters);
            return unitCount > 0;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void InsertUnit(string unitName)
        {
            string query = "INSERT INTO unit (unit) VALUES (@unit)";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@unit", unitName)
            };

            DataBaseUtility.ExecuteNonQuery(query, parameters);
        }

        public void Display()
        {
            string query = "SELECT * FROM unit";
            DataBaseUtility.FillDataGridView(dataGridView1, query);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            string query = "DELETE FROM unit WHERE Id = @id";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@id", id)
            };

            DataBaseUtility.ExecuteNonQuery(query, parameters);
            MessageBox.Show("Unit deleted");
            Display();
        }
    }
}
