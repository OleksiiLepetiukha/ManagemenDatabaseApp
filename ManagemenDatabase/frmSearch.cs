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

namespace ManagemenDatabase
{
    public partial class frmSearch : Form
    {
        string connectionString = SQLQueries.CONNSTRING;

        public frmSearch()
        {
            InitializeComponent();
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            DataBinding dataBindingObj = new DataBinding();
            dataBindingObj.LoadData(connectionString, SQLQueries.SELECTALL, dgvSearch);
        }

        private void buildQuery()
        {
            String searchCriteria = "";
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
                 Validation.ValidateControl(txtValue, "Value"))
            {

                buildQuery();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
