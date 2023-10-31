using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace InventoryApp
{
    public static class DataBaseUtility
    {
        private static SqlConnection connection; //= new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nitch\source\repos\InventoryApp\Inventory.mdf;Integrated Security=True");

        
        public static SqlConnection GetConnection() 
        {
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nitch\source\repos\InventoryApp\Inventory.mdf;Integrated Security=True");
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            connection.Open();
            return connection;
        }

        public static void OpenConnection()
        {
            if(connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            connection.Open();
        }

        public static void FillComboBox(ComboBox comboBox, string query)
        {
            using (SqlConnection connection = GetConnection())
            {

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                DataTable dataTable = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                sqlDataAdapter.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    comboBox.Items.Add(row[0].ToString());
                }
            }
        }

        public static void FillDataGridView(DataGridView dataGridView, string query)
        {
            using (SqlConnection connection = GetConnection())
            {
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                DataTable dataTable = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dataTable);
                dataGridView.DataSource = dataTable;
            }
        }

        public static void ExecuteNonQuery(string query, List<SqlParameter> parameters = null)
        {
            using(SqlConnection connection = GetConnection())
            {
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;

                if(parameters !=null)
                {
                    cmd.Parameters.AddRange(parameters.ToArray());
                }
                cmd.ExecuteNonQuery();
                
            }
        }
        public static int ExecuteCountQuery(string query, List<SqlParameter> parameters = null)
        {
            using (SqlConnection connection = GetConnection())
            {
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;

                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters.ToArray());
                }
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public static DataTable GetDataTable(string query, List<SqlParameter> parameters) 
        {
            DataTable dataTable = new DataTable();

            using(SqlConnection conn  = GetConnection())
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters.ToArray());
                }
                cmd.ExecuteNonQuery();

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dataTable);
            }
            return dataTable;
        }

        public static void RemoveDuplicateItemsFromComboBox(ComboBox comboBox)
        {
            //HashSet to save unique elements
            HashSet<string> uniqueItems = new HashSet<string>();

            foreach (object item in comboBox.Items)
            {
                //checks if the element already exist in uniqueItems
                if (!uniqueItems.Contains(item.ToString()))
                {
                    //If it doesnt, adds the element to the HashSet
                    uniqueItems.Add(item.ToString());
                }
            }

            comboBox.Items.Clear();
            comboBox.Items.AddRange(uniqueItems.ToArray());
        }

    }
}
