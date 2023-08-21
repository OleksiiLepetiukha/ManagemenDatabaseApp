using BindingDataControls;
using SQLConstants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ValidateControls;
using HelperMethods;

namespace ManagemenDatabase
{
    public partial class frmSearch : Form
    {
        string connectionString = SQLQueries.CONNSTRING;
        String searchCriteria = "";
        String[] dataFromFile = null;
        String derictory = @"D:\Front\SoftwearDevelopment\3. Programing C#/";

        

        public frmSearch()
        {
            InitializeComponent();
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            DataBinding dataBindingObj = new DataBinding();
            dataBindingObj.LoadData(connectionString, SQLQueries.SELECTALL, dgvSearch);
                        
            String fileName = @"managment.txt";
            String records = derictory + fileName;
            dataFromFile = Helper.readFileFromArr(records);
           
            dgvDataSearch.ColumnCount = 4;
            dgvDataSearch.Columns[0].Name = "Manager_Nymber";
            dgvDataSearch.Columns[1].Name = "Manager_Forename";
            dgvDataSearch.Columns[2].Name = "Manager_Surname";
            dgvDataSearch.Columns[3].Name = "Dept_Number";

            Helper.insertDataToDGV(dataFromFile, dgvDataSearch);
        }

        private void buildQuery()
        {
            
            String selected = (string)cboField.SelectedItem;
            String fieldName = "";
            if (selected == "Forename")
            {
                fieldName = "manager_forename";
            }
            else if (selected == "Surname")
            {
                fieldName = "manager_surname";
            }
            else if (selected == "Dept. Number")
            {
                fieldName = "Dept_number";
            }
            String operatorQuery = (string)cboOperator.SelectedItem;
            String value = txtValue.Text;
            searchCriteria = fieldName + " " + operatorQuery + " " + "'" +  value + "'";
            String mainQuery = "Select * from management where " + searchCriteria;
            DataBinding dataBindingObj = new DataBinding();
            dataBindingObj.LoadData(connectionString, mainQuery, dgvSearch);
        }


        private void btnRun_Click(object sender, EventArgs e)
        {
           
            if (Validation.ValidateControl(cboField, "Field") &&
                 Validation.ValidateControl(cboOperator, "Operator") &&
                 Validation.ValidateControl(txtValue, "Value") && Validation.ValidateControl(cboTables, "Table"))
            {
                if ((string)cboTables.SelectedItem == "From DataBase")
                {

                buildQuery();
                }
                else if ((string)cboTables.SelectedItem == "From File")
                {
                    if((string)cboField.SelectedItem == "Dept. Number")
                    {
                        
                        List<string> searchResults = Helper.SearchFromFileByDeptNumber(dataFromFile, txtValue.Text, (string)cboOperator.SelectedItem);
                        String[] searchResult = searchResults.ToArray();
                        Helper.insertDataToDGV(searchResult, dgvDataSearch);
                    }
                    else
                    {
                    Helper.SearchFromFile(dgvDataSearch, dataFromFile, txtValue.Text);
                    }
                }

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboField_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedField = cboField.SelectedItem as string;

            if (selectedField == "Forename" || selectedField == "Surname")
            {
                
                cboOperator.Enabled = false;

              
                cboOperator.SelectedItem = "=";
            }
            else
            {
               
                cboOperator.Enabled = true;
                cboOperator.SelectedItem = null;
            }
        }
    }
}
