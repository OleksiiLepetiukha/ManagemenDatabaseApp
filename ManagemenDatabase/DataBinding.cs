using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BindingDataControls
{
    internal class DataBinding
    {
        public void LoadData(String connectionString, String sqlQuery, DataGridView dataGridView)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string passedQuery = sqlQuery;
                DataSet ds = new DataSet();
                MySqlDataAdapter adapter = new MySqlDataAdapter(passedQuery, connection);
                adapter.Fill(ds);
                dataGridView.DataSource = ds.Tables[0];
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection unsuccessful" + ex.Message);
            }
        }
    }
}
