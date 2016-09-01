using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;using MySql.Data.MySqlClient;
namespace attandance_management_system
{
    public partial class user : Form
    { 
        public static string strprovider = " Data Source = Localhost ;Database= project; User ID=root; Password= mysql ;";
        public MySqlConnection mysqlCon = new MySqlConnection(strprovider);
        public static string query;

        public user()
        {
            InitializeComponent();
        }

        private void uattandance_Click(object sender, EventArgs e)
        
        { 
          
            DateTime thedate;
            thedate = DateTime.Now;
            
            mysqlCon.Open();
            {  
               
                string query = "select * from holidays where hdate='" + DateTime.Today.ToString("yyyy-MM-dd") + "'";

                MySqlCommand cmdMySql = new MySqlCommand(query, mysqlCon);
                MySqlDataReader reader2 = cmdMySql.ExecuteReader();
                if (reader2.HasRows)
                {
                     MessageBox .Show ("Today is Holiday", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     reader2.Close();
                }
                else if (thedate.DayOfWeek.ToString().ToLower() == "sunday")
                {
                    MessageBox.Show("Today is Sunday", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mysqlCon.Close();
                }
                else if (thedate.DayOfWeek.ToString().ToLower ()== "saturday")
                {
                    MessageBox.Show("Today is Saturday", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    mysqlCon.Close();
                }


                else
                    {
                    reader2.Close();


                    TimeSpan tm9AM = new TimeSpan(9, 0, 0);
                    TimeSpan tm12AM = new TimeSpan(12, 0, 0);
                    TimeSpan tm2PM = new TimeSpan(14, 0, 0);
                    TimeSpan tm5PM = new TimeSpan(17, 0, 0);
                    TimeSpan tmNow = DateTime.Now.TimeOfDay;

                    string query1 = "select * from userattendance where userid='" + Login.sUid + "' and (attdate='" + DateTime.Now.ToString("yyyy-MM-dd") + "' and time between '" + tm9AM + "' and '" + tm12AM + "' or attdate ='" + DateTime.Now.ToString("yyyy-MM-dd") + "'  and time between '" + tm2PM + "' and '" + tm5PM + "')";

                    MySqlCommand cmdMySql1 = new MySqlCommand(query1, mysqlCon);
                    MySqlDataReader reader3 = cmdMySql1.ExecuteReader();

                    if (reader3.HasRows)
                    {

                        MessageBox.Show("you already given attandance", " Message ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        mysqlCon.Close();

                    }
                    else if ((tmNow >= tm9AM) && (tmNow <= tm12AM))
                    {
                        reader3.Close();
                        MySqlCommand command = mysqlCon.CreateCommand();



                        command.CommandText = " insert into userattendance (userid,attdate,time) values('" + Login.sUid + "','" + thedate.ToString("yyyy-MM-dd") + "','" + thedate.ToString("HH:MM:SS AM/PM") + "' ) ";

                        Console.WriteLine(command.CommandText);

                        MySqlDataReader reader1 = command.ExecuteReader();

                        MessageBox.Show("NOW you given attandance today", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        mysqlCon.Close();

                    }
                    else if ((tmNow >= tm2PM) && (tmNow <= tm5PM))
                    {
                        reader3.Close();
                        MySqlCommand command = mysqlCon.CreateCommand();



                        command.CommandText = " insert into userattendance(userid,attdate,time) values('" + Login.sUid + "','" + thedate.ToString("yyyy-MM-dd") + "','" + thedate.ToString("HH:mm:ss") + "' ) ";

                        Console.WriteLine(command.CommandText);

                        MySqlDataReader reader5 = command.ExecuteReader();

                        MessageBox.Show(" Now you given attandance", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        mysqlCon.Close();
                    }
                    else
                    {
                        MessageBox.Show("Its not the correct time", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        mysqlCon.Close();
                    }

                }
            
          
            
            }
        }


        

       

        private void user_Load(object sender, EventArgs e)
        {
            string strprovider = " Data Source = Localhost ;Database= project; User ID=root; Password= mysql ;";
            MySqlConnection mysqlCon = new MySqlConnection(strprovider);
            mysqlCon.Open();
            MySqlCommand command = mysqlCon.CreateCommand();

            string query = "select u.*, count(r.userid) TotalAttandance from user u natural join userattendance r where userid='" + Login.sUid + "'";


            MySqlDataAdapter dAdapter = new MySqlDataAdapter(query, strprovider);
            MySqlCommandBuilder cBuilder = new MySqlCommandBuilder(dAdapter);
            DataTable dTable = new DataTable();

            dAdapter.Fill(dTable);
            ajay.DataSource = dTable;
            dAdapter.Update(dTable);
        }


        /*private void button1_Click(object sender, EventArgs e)
        {
            view vform = new view();
            vform.Show();
        

        }*/

        private void ajay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void userattandbtn_(object sender, EventArgs e)
        {

        }

        private void stcnlbt_Click_1(object sender, EventArgs e)
        {
          

            this.Close();
        
        
        }


      
       
    }
}

    

