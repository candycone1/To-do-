using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_List
{
    public class Todo
    {
        private string task;
        private string taskinfo;


        public string Task { get => this.task; set => this.task = value; }
        public string Taskinfo { get => taskinfo; set => taskinfo = value; }

        string SqlCon = "server=127.0.0.1 ; user=root ; database=todo; password=";

        public void Add()
            {
        
              
                MySqlConnection Sqlconnection = new MySqlConnection(SqlCon);
                MySqlCommand add = new MySqlCommand("insert into todotable values (@Task,@Task_info)", Sqlconnection);
            if (task != "" && taskinfo != "")
            {
                Sqlconnection.Open();

                add.Parameters.AddWithValue("@Task", task);
                add.Parameters.AddWithValue("@Task_info", taskinfo);
                try
                {
                    add.ExecuteNonQuery();
                    MessageBox.Show("Task Added");
                    Sqlconnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Task already found", "ERROR");
                }
            }
            else { MessageBox.Show("Cant leave the feilds empty", "Feilds Empty"); } 
           
        }

        public void Update()
        {
            MySqlConnection con = new MySqlConnection(SqlCon);

            MySqlCommand cmd = new MySqlCommand("Update todotable SET  Task_info=@Taskinfo WHERE Task=@Task", con);

           
            if (task != "" && taskinfo != "")
            {
                con.Open();

                cmd.Parameters.AddWithValue("@Task", task);
                cmd.Parameters.AddWithValue("@Taskinfo", taskinfo);
                int row = cmd.ExecuteNonQuery();
                con.Close();
                
                if (row == 0)
                {
                    MessageBox.Show("No feilds were updated");
                }
                else
                {
                    MessageBox.Show("updated.");
                }
            }
            else { MessageBox.Show("Cant leave the feilds empty", "Feilds Empty"); }
        }





         public void Delete()
        {
            MySqlConnection con = new MySqlConnection(SqlCon);
            MySqlCommand cmd = new MySqlCommand("DELETE FROM todotable WHERE Task=@Task",con);

            if (task != "")
            {
                cmd.Parameters.AddWithValue("@Task", task);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            else { MessageBox.Show("Cant leave the feilds empty", "Feilds Empty"); }



        }


    }


}
