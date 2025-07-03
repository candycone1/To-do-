using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_List
{
    public class Database
    {
        public string con;
       
        public void Connection()
        {
            string SqlCon = "server=127.0.0.1 ; user=root ; database=todo; password=";
        }
        public static void TestConnectipn()
        {
            string SqlCon = "server=127.0.0.1 ; user=root ; database=todo; password=";
            MySqlConnection Sqlconnection = new MySqlConnection(SqlCon);
           
            try
            {
                Sqlconnection.Open();
                MessageBox.Show("SQL Connected successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

        }
    }
}
