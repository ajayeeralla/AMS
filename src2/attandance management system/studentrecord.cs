using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace attandance_management_system
{
    public partial class studentrecord : Form
    {
        public studentrecord()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            //Application.Exit();
            (new administrator()).Show();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strprovider = " Data Source = Localhost ;Database= project; User ID=root; Password= mysql ;";
            MySqlConnection mysqlCon = new MySqlConnection(strprovider);
            mysqlCon.Open();
            MySqlCommand command = mysqlCon.CreateCommand();

            command.CommandText = " insert into user values ('" + textBox2.Text + "','" + textBox1.Text + "','" + comboBox1.Text + "');";

            Console.WriteLine(command.CommandText);

            MySqlDataReader result = command.ExecuteReader();

           MessageBox.Show("New Record added to Database");

            this.Close();
            (new administrator()).Show();
        
        
        }


    }
}