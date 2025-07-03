using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System.Data;
using System.Drawing;


namespace To_Do_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Database.TestConnectipn();

        }
        public void Form1_Load(object sender, EventArgs e)
        {
            Loadtables();

        }


        public void Loadtables()
        {
            string Con = "server=127.0.0.1 ; user=root ; database=todo; password=";
            MySqlConnection con = new MySqlConnection(Con);
            MySqlDataAdapter cmd = new MySqlDataAdapter("SELECT*FROM todotable", con);
            DataSet table = new DataSet();
            cmd.Fill(table);
            dataGridView1.DataSource = table.Tables[0];
        }

        



        private void button1_Click(object sender, EventArgs e)
        {
            Todo addnew = new Todo();
            addnew.Task = txt1.Text;
            addnew.Taskinfo = txt2.Text;
            addnew.Add();
            Loadtables();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Todo update = new Todo();
            update.Task = txt1.Text;
            update.Taskinfo = txt2.Text;
            update.Update();
            Loadtables();
        }

       
        private void btn3_Click(object sender, EventArgs e)
        {
            Todo dlt = new Todo();
            dlt.Task = txt1.Text;
            dlt.Delete();
            Loadtables();
        }
    }
}
