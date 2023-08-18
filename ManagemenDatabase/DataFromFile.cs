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
            dgvData.Columns[0].Name = "Id";
            dgvData.Columns[1].Name = "Forename";
            dgvData.Columns[2].Name = "Surname";
            dgvData.Columns[3].Name = "Dept. Number";

            Helper.insertDataToDGV(dataFromFile, dgvData);
            
        }
    }
}
