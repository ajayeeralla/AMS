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
    public partial class administrator : Form
    {
        public static string strprovider = " Data Source = Localhost ;Database= project; User ID=root; Password= mysql ;";
        public static MySqlConnection mysqlCon = new MySqlConnection(strprovider);
        public static DataTable dTable = new DataTable();


        public administrator()
        {
            InitializeComponent();
        }

        MySqlDataAdapter m_StduentAdp = null;
        DataTable m_StudentTbl = new DataTable();
        MySqlDataAdapter m_HolidayAdp = null;
        DataTable m_HolidayTbl = new DataTable();

        private void administrator_Load(object sender, EventArgs e)
        {
            string strprovider = " Data Source = Localhost ;Database= project; User ID=root; Password= mysql ;";
            MySqlConnection mysqlCon = new MySqlConnection(strprovider);
            mysqlCon.Open();
            MySqlCommand command = mysqlCon.CreateCommand();

            string query;

            //Students Page
            query = "  select u.*, count(r.userid) TotalAttandance from user u left join userattendance r on u.userid= r.userid group by u.userid ";
            m_StduentAdp = new MySqlDataAdapter(query, strprovider);
            m_StduentAdp.Fill(m_StudentTbl);
            Stddgv.DataSource = m_StudentTbl;




            //Holidays Page
            query = "select * from holidays";
            m_HolidayAdp = new MySqlDataAdapter(query, strprovider);
            m_HolidayAdp.Fill(m_HolidayTbl);
            dataGridView2.DataSource = m_HolidayTbl;


            mysqlCon.Close();
        }

        private void administrator_FormClosing(object sender, FormClosingEventArgs e)
        {
        }


        /*{

        mysqlCon.Open();
        {
            DateTime obj = new DateTime();
            string str;
            obj = monthCalendar1.SelectionStart;
            str = obj.ToString("yyyy-MM-dd");

            textBox1.Text = str;



            MySqlCommand command = mysqlCon.CreateCommand();
            command.CommandText = "insert into holidays values('" + textBox1.Text + "')";

            Console.WriteLine(command.CommandText);

            MySqlDataReader result = command.ExecuteReader();

            mysqlCon.Close();*/



        /*private void detbutton_Click(object sender, EventArgs e)
       {



           DateTime obj = new DateTime();
           string str;
           obj = monthCalendar1.SelectionStart;
           str = obj.ToString("yyyy-MM-dd");

           textBox1.Text = str;


           mysqlCon.Open();




           {



            

               MySqlCommand command = mysqlCon.CreateCommand();
               

                   string query = "select * from holidays where hdate='" +str + "'";
                   MySqlCommand cmdMySql = new MySqlCommand(query, mysqlCon);
                   MySqlDataReader reader2 = cmdMySql.ExecuteReader();
                   reader2.Close();
               if (reader2.HasRows)
                   {
                       command.CommandText = "delete from holidays where hdate='" + str+ "'";

                       Console.WriteLine(command.CommandText);

                       MySqlDataReader result = command.ExecuteReader();
                      
                       mysqlCon.Close();
                       MessageBox.Show("deleted");

                     


                   }
                   else
                   {
                       MessageBox.Show("doesnot exist this holiday");

                   }


                   mysqlCon.Close();


           }


       }

        private void button2_Click(object sender, EventArgs e)
        {
            mysqlCon.Open();
            {
                DateTime obj = new DateTime();
                string str;
                obj = monthCalendar1.SelectionStart;
                str = obj.ToString("yyyy-MM-dd");

                textBox1.Text = str;



                MySqlCommand command = mysqlCon.CreateCommand();
                command.CommandText = "insert into holidays values('" + str + "')";

                Console.WriteLine(command.CommandText);

                MySqlDataReader result = command.ExecuteReader();

                mysqlCon.Close();

                MessageBox.Show("holiday added");
            }*/


        #region Student Page

        private void EdtSbtn_Click(object sender, EventArgs e)
        {
            UidStxt.Enabled = UnmStxt.Enabled = ClsScmb.Enabled = cmbUType.Enabled =
            SavSbtn.Enabled = butCancel.Enabled = true;

            EdtSbtn.Enabled = DelSbtn.Enabled = false;

            int i = Stddgv.CurrentRow.Index;
        }

        private void DelSbtn_Click(object sender, EventArgs e)
        {
            if (Stddgv.SelectedRows.Count == 0)
                return;
            if (Stddgv.SelectedRows[0].Index < Stddgv.Rows.Count - 1 &&
                DialogResult.Yes == MessageBox.Show("Are you sure want to delete record of " + Stddgv.SelectedRows[0].Cells[0].Value + " ?", "Student Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                //mysqlCon.Open();
                //MySqlCommand command = mysqlCon.CreateCommand();
                //command.CommandText = "delete from user where userid='" + Stddgv.SelectedRows[0].Cells[0].Value + "'";
                //Console.WriteLine(command.CommandText);
                //MySqlDataReader result = command.ExecuteReader();
                //mysqlCon.Close();


                //m_StudentTbl.Rows.RemoveAt(Stddgv.SelectedRows[0].Index);
            }


            MessageBox.Show("deleted");

        }

        private void SavSbtn_Click(object sender, EventArgs e)
        {
            if (Stddgv.SelectedRows.Count == 0)
                return;
            if (Stddgv.SelectedRows[0].Index < Stddgv.Rows.Count - 1 &&
                DialogResult.Yes == MessageBox.Show("Are you sure want to save new record ?", "Student Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                //**** PERFORM FOR SAVING NEW ROW

                int iSelIndex = Stddgv.SelectedRows[0].Index;
                if (iSelIndex == Stddgv.RowCount - 1)
                    Stddgv.Rows[0].Selected = true;
                else
                {
                    UidStxt.Enabled = UnmStxt.Enabled = ClsScmb.Enabled = cmbUType.Enabled =
                    SavSbtn.Enabled = butCancel.Enabled = false;

                    EdtSbtn.Enabled = DelSbtn.Enabled = true;
                }

                //int i = Stddgv.CurrentRow.Index;
                //mysqlCon.Open();
                //MySqlCommand command = mysqlCon.CreateCommand();
                //command.CommandText = "update user set username='" + UnmStxt.Text + "',class='" + ClsScmb.Text + "' where userid='" + UidStxt.Text + "'";
                //Console.WriteLine(command.CommandText);


                //MySqlDataReader reader = command.ExecuteReader();

                //mysqlCon.Close();
            }

        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            if ( Stddgv.Rows.Count == 0 )
                return;

            int iSelIndex = Stddgv.SelectedRows[0].Index;
            if (iSelIndex == Stddgv.RowCount - 1)
                Stddgv.Rows[0].Selected = true;
            else
            {
                UidStxt.Enabled = UnmStxt.Enabled = ClsScmb.Enabled = cmbUType.Enabled =
                SavSbtn.Enabled = butCancel.Enabled = false;

                EdtSbtn.Enabled = DelSbtn.Enabled = true;
            }
        }

        private void Stddgv_SelectionChanged(object sender, EventArgs e)
        {
            if (Stddgv.SelectedRows.Count == 0)
                return;

            if (Stddgv.SelectedRows[0].Index < Stddgv.RowCount - 1)
            {
                //Existing User
                UidStxt.Text = Stddgv.SelectedRows[0].Cells[0].Value.ToString();
                UnmStxt.Text = Stddgv.SelectedRows[0].Cells[1].Value.ToString();
                ClsScmb.Text = Stddgv.SelectedRows[0].Cells[2].Value.ToString();
                cmbUType.Text = Stddgv.SelectedRows[0].Cells[4].Value.ToString();


                UidStxt.Enabled = UnmStxt.Enabled = ClsScmb.Enabled = cmbUType.Enabled =
                SavSbtn.Enabled = butCancel.Enabled =  false;

                EdtSbtn.Enabled = DelSbtn.Enabled = true;
            }
            else
            {
                //New User
                UidStxt.Text = "";
                UnmStxt.Text = "";
                ClsScmb.SelectedIndex = 0;
                cmbUType.SelectedIndex = 0;


                UidStxt.Enabled = UnmStxt.Enabled = ClsScmb.Enabled = cmbUType.Enabled =
                SavSbtn.Enabled = butCancel.Enabled = true;

                EdtSbtn.Enabled = DelSbtn.Enabled = false;
            }
        }

        #endregion

        #region Holiday Page
        private void SavHbtn_Click(object sender, EventArgs e)
        {
            mysqlCon.Open();

           
            string str;
            str  = dtpHoliday.Value;
            str = Str.ToString("yyyy-MM-dd");

            



            MySqlCommand command = mysqlCon.CreateCommand();
            command.CommandText = "insert into holidays values('" + str + "','" + Hdesctxt.Text + "')";

            Console.WriteLine(command.CommandText);

            MySqlDataReader result = command.ExecuteReader();

            mysqlCon.Close();

            MessageBox.Show("holiday added");            
            
            
            mysqlCon.Close();
        }

        private void EdtHbtn_Click(object sender, EventArgs e)
        {
            int i = dataGridView2.CurrentRow.Index;

            DateTime dt;
            dt = Convert.ToDateTime(dataGridView2[0, i].Value.ToString());

           
            Hdesctxt.Text = dataGridView2[1, i].Value.ToString();

        }

        private void Holidpg_Click(object sender, EventArgs e)
        {
           /* mysqlCon.Open();
            {
                DateTime obj = new DateTime();
                string str;
                obj = monthCalendar1.SelectionStart;
                str = obj.ToString("yyyy-MM-dd");

                Hdttxt.Text = str;



                MySqlCommand command = mysqlCon.CreateCommand();
                command.CommandText = "insert into holidays values('" + str + "','"+Hdesctxt .Text +"')";

                Console.WriteLine(command.CommandText);

                MySqlDataReader result = command.ExecuteReader();

                mysqlCon.Close();

                MessageBox.Show("holiday added");
            }
*/
        }

        #endregion
    }
}