using BindingDataControls;
using MySql.Data.MySqlClient;
using SQLConstants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidateControls;

namespace ManagemenDatabase
{
    public partial class frmManagement : Form
    {
        private MySqlConnection cnn;
        private string connectionString;
        private DataTable DTable;
        private int currentRecordIndex = 0;
        private DataView dv;
        private BindingSource managerBindingSource;
        public string SelectedID { get; private set; }
        public string SelectedNo { get; private set; }

        public frmManagement()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            LoadData();
            InitializeBindingNavigator();
        }

        private void InitializeDatabaseConnection()
        {
            connectionString = SQLQueries.CONNSTRING;
            cnn = new MySqlConnection(connectionString);
            try
            {
                cnn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to the database: " + ex.Message);
            }
        }
        private void LoadData()
        {
            string query = SQLQueries.SELECTALL;
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DTable = new DataTable();
            adapter.Fill(DTable);
            dv = new DataView(DTable);
            dv.Sort = "Manager_Number";

            if (dv.Count > 0)
            {
                ShowRecord(0);
            }

        }
        private void InitializeBindingNavigator()
        {
            managerBindingSource = new BindingSource();
            managerBindingSource.DataSource = DTable;
            bindingNavigator.BindingSource = managerBindingSource;
        }
        private void ShowRecord(int index)
        {
            if (index >= 0 && index < DTable.Rows.Count)
            {
                DataRow row = DTable.Rows[index];
                txtNumber.Text = row["Manager_Number"].ToString();
                txtForename.Text = row["Manager_Forename"].ToString();
                txtSurname.Text = row["Manager_Surname"].ToString();
                txtDepartment.Text = row["Dept_Number"].ToString();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frmSearch searchForm = new frmSearch())
            {                
                searchForm.ShowDialog();
                this.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            currentRecordIndex = 0;
            ShowRecord(currentRecordIndex);
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            if (currentRecordIndex > 0)
            {
                currentRecordIndex--;
                ShowRecord(currentRecordIndex);
            }
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            if (currentRecordIndex < DTable.Rows.Count - 1)
            {
                currentRecordIndex++;
                ShowRecord(currentRecordIndex);
            }
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            currentRecordIndex = DTable.Rows.Count - 1;
            ShowRecord(currentRecordIndex);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                
                string deleteQuery = SQLQueries.DELETE;
                MySqlCommand command = new MySqlCommand(deleteQuery, cnn);
                command.Parameters.AddWithValue("@id", txtNumber.Text);
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Row deleted successfully");
                    LoadData();
                    InitializeBindingNavigator();
                    ShowRecord(currentRecordIndex);
                }
                else
                {
                    MessageBox.Show("Row has not been deleted");
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    

        private void btnAdd_Click(object sender, EventArgs e)
        {           

            try
            {
                string forename = txtForename.Text;
                string surname = txtSurname.Text;
                string department = txtDepartment.Text;

                // Insert the new employee into the database

                string insertQuery = SQLQueries.INSERT;

                MySqlCommand cmd = new MySqlCommand(insertQuery, cnn);
                cmd.Parameters.AddWithValue("@forename", forename);
                cmd.Parameters.AddWithValue("@surname", surname);
                cmd.Parameters.AddWithValue("@dept", department);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("New employee added successfully!");
                    LoadData();
                    InitializeBindingNavigator();
                    ShowRecord(currentRecordIndex);
                }
                else
                {
                    MessageBox.Show("Error adding the new employee.");
                }

                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open connection!" + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                
                string updateQuery = SQLQueries.UPDATE;

                MySqlCommand command = new MySqlCommand(updateQuery, cnn);
                command.Parameters.AddWithValue("@id", txtNumber.Text);
                command.Parameters.AddWithValue("@forename", txtForename.Text);
                command.Parameters.AddWithValue("@surname", txtSurname.Text);
                command.Parameters.AddWithValue("@dept", txtDepartment.Text);
                command.ExecuteNonQuery();

                if (Validation.ValidateControl(txtForename, "Manager Forename") 
                    && Validation.ValidateControl(txtSurname, "Manager Surname") 
                    && Validation.ValidateControl(txtDepartment, "Department Number"))
                {
                    MessageBox.Show("Updated successfully");
                    LoadData();
                    InitializeBindingNavigator();
                    ShowRecord(currentRecordIndex);
                    
                }
                else
                {
                    MessageBox.Show("Employee name is empty. Pleas type employee name");
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (DataFromFile dataForm = new DataFromFile())
            {
                dataForm.ShowDialog();
                this.Show();
            }
        }
    }
}
