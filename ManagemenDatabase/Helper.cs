using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelperMethods
{
    internal class Helper
    {
        private static String[] arrOfRecs = null;
        

        public static String[] readFileFromArr (String filename)
        {
            try
            {
                arrOfRecs = File.ReadAllLines(filename);
            }
            catch(Exception e)
            {
                MessageBox.Show("Issue with file" + e.Message);
            }
            return arrOfRecs;
        }

        public static void insertDataToDGV(string[] data, DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();

            foreach (string line in data)
            {
                string[] rowData = line.Split(';');
                dataGridView.Rows.Add(rowData);
            }

        }

        public static void SearchFromFile(DataGridView dataGridView, string[] data, string searchTerm)
        {
            dataGridView.Rows.Clear(); // Clear existing rows if any

            foreach (string line in data)
            {
                if (line.Contains(searchTerm))
                {
                    string[] rowData = line.Split(';');
                    dataGridView.Rows.Add(rowData);
                }
            }
        }

        public static List<string> SearchFromFileByDeptNumber(string[] data, string searchTerm, string selectedOperator)
        {
            List<string> searchResults = new List<string>();

            foreach (string line in data)
            {
                string[] rowData = line.Split(';');

                if (rowData.Length >= 4)
                {
                    string deptNumber = rowData[3].Trim(); // Assuming department number is in the fourth column
                    int deptNum;
                    // Проверяем оператор и выполняем сравнение в зависимости от выбора
                    if (selectedOperator == "=" && deptNumber == searchTerm)
                    {
                        searchResults.Add(line);
                    }
                    else if (selectedOperator == "<" && int.TryParse(deptNumber, out  deptNum) && deptNum < int.Parse(searchTerm))
                    {
                        searchResults.Add(line);
                    }
                    else if (selectedOperator == ">" && int.TryParse(deptNumber, out  deptNum) && deptNum > int.Parse(searchTerm))
                    {
                        searchResults.Add(line);
                    }
                    else if (selectedOperator == "<=" && int.TryParse(deptNumber, out  deptNum) && deptNum <= int.Parse(searchTerm))
                    {
                        searchResults.Add(line);
                    }
                    else if (selectedOperator == ">=" && int.TryParse(deptNumber, out deptNum) && deptNum >= int.Parse(searchTerm))
                    {
                        searchResults.Add(line);
                    }
                }
            }

            return searchResults;
        }


    }


}
