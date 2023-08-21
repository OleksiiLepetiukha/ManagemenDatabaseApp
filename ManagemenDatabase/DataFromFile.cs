using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HelperMethods;

namespace ManagemenDatabase
{
    public partial class DataFromFile : Form
    {
        public DataFromFile()
        {
            InitializeComponent();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataFromFile_Load(object sender, EventArgs e)
        {
            String[] dataFromFile = null;
            String derictory = @"D:\Front\SoftwearDevelopment\3. Programing C#/";
            String fileName = @"managment.txt";
            String records = derictory + fileName;
            dataFromFile = Helper.readFileFromArr(records);
           

            dgvData.ColumnCount = 4;
            dgvData.Columns[0].Name = "Manager_Number";
            dgvData.Columns[1].Name = "Manager_Forename";
            dgvData.Columns[2].Name = "Manager_Surname";
            dgvData.Columns[3].Name = "Dept_Number";

            Helper.insertDataToDGV(dataFromFile, dgvData);
            
        }

        private void btnSearcFile_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frmSearch searchForm = new frmSearch())
            {
                searchForm.ShowDialog();
                this.Show();
            }
        }
    }
}
