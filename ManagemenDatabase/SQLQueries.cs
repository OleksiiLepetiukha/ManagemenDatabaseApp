using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLConstants
{
    internal class SQLQueries
    {
        public static string CONNSTRING = "server=localhost; port=3306; database=staff; uid=root; pwd=040814-Alexey;";
        public static string SELECTALL = "select * from management";
        public static string INSERT = "INSERT INTO management (manager_forename, manager_surname, dept_number) VALUES (@forename, @surname, @dept)";
        public static string DELETE = "delete from management where manager_number = @id";
        public static string UPDATE = "update management set manager_forename = @forename, manager_surname = @surname, dept_number = @dept where manager_number = @id";
    }
}
