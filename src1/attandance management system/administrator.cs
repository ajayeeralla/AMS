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
        MySqlDataAdapter   m_totrecAdp=null;
        DataTable m_totrecTbl=new DataTable ();
        private void administrator_Load(object sender, EventArgs e)
        {
            //string strprovider = " Data Source = Localhost ;Database= project; User ID=root; Password= mysql ;";
            //MySqlConnection mysqlCon = new MySqlConnection(strprovider);
            if (mysqlCon.State == ConnectionState.Closed)
                mysqlCon.Open();
            //MySqlCommand command = mysqlCon.CreateCommand();

            string query;


            //Students Page
            query = "select u.*, count(r.userid) TotalAttandance from user u left join userattendance r on u.userid= r.userid group by u.userid";
            //query = "select * from user";
            m_StduentAdp = new MySqlDataAdapter(query, mysqlCon);//strprovider);
            m_StduentAdp.Fill(m_StudentTbl);
            Stddgv.DataSource = m_StudentTbl;
          
       

            //Holidays Page
            query = "select * from holidays";
            m_HolidayAdp = new MySqlDataAdapter(query, mysqlCon);//, strprovider);
            m_HolidayAdp.Fill(m_HolidayTbl);
            dgvHp.DataSource = m_HolidayTbl;
            EdtHbtn.Enabled = DelHbtn.Enabled = false;

            //mysqlCon.Close();
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
            SavSbtn.Enabled = CanSbtn.Enabled = true;

            EdtSbtn.Enabled = DelSbtn.Enabled = false;

            int i = Stddgv.CurrentRow.Index;
        }

        private void DelSbtn_Click(object sender, EventArgs e)
        {
            if (Stddgv.SelectedRows.Count == 0)
                return;

            int nRowIndex = Stddgv.SelectedRows[0].Index;
            if (nRowIndex < Stddgv.Rows.Count - 1)
            {
                MySqlCommandBuilder cmdBuild = new MySqlCommandBuilder(m_StduentAdp);
                m_StudentTbl.Rows[nRowIndex].Delete();
                m_StduentAdp.Update(m_StudentTbl);
                Stddgv.Rows[Stddgv.RowCount - 1].Selected = true;
                MessageBox.Show("deleted");
            }
        }

        private void SavSbtn_Click(object sender, EventArgs e)
        {
            if (Stddgv.SelectedRows.Count == 0)
                return;

            //**** PERFORM FOR SAVING NEW ROW
            int nRowIndex = Stddgv.SelectedRows[0].Index;


            if ((nRowIndex == Stddgv.RowCount - 1) && (DialogResult.Yes == MessageBox.Show("DO U WANT SAVE", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)))
            
            
            
            {

              // lastrow i.e. add_new_record row
                MySqlCommandBuilder cmdBuild = new MySqlCommandBuilder(m_StduentAdp);

                DataRow dsNewRow = m_StudentTbl.NewRow();
                m_StudentTbl.Rows.Add(dsNewRow);
            }

            m_StudentTbl.Rows[nRowIndex]["userid"] = UidStxt.Text;
            m_StudentTbl.Rows[nRowIndex]["username"] = UnmStxt.Text;
            m_StudentTbl.Rows[nRowIndex]["class"] = ClsScmb.Text;
            m_StudentTbl.Rows[nRowIndex]["password"] = UidStxt.Text;
            m_StudentTbl.Rows[nRowIndex]["usertype"] = cmbUType.Text;

            m_StduentAdp.Update(m_StudentTbl);

            Stddgv.Rows[nRowIndex].Selected = true;



            UidStxt.Enabled = UnmStxt.Enabled = ClsScmb.Enabled = cmbUType.Enabled =
            SavSbtn.Enabled = CanSbtn.Enabled = false;

            EdtSbtn.Enabled = DelSbtn.Enabled = true;
        }

        private void CanSbtn_Click(object sender, EventArgs e)
        {
            if (Stddgv.Rows.Count == 0)
                return;

            int iSelIndex = Stddgv.SelectedRows[0].Index;
            if (iSelIndex == Stddgv.RowCount - 1)
                Stddgv.Rows[0].Selected = true;
            else
            {
                
          SavSbtn .Enabled = false;

          EdtHbtn.Enabled = DelHbtn.Enabled = CanSbtn.Enabled=true;

            }


        }

            private void Stddgv_SelectionChanged(object sender, EventArgs e)
            {
            }
              //  if (Stddgv.SelectedRows.Count == 0)
            //        return;

            //    if (Stddgv.SelectedRows[0].Index < Stddgv.RowCount - 1)
            //    {
            //        //Existing User
            //        UidStxt.Text = Stddgv.SelectedRows[0].Cells[0].Value.ToString();
            //        UnmStxt.Text = Stddgv.SelectedRows[0].Cells[1].Value.ToString();
            //        ClsScmb.Text = Stddgv.SelectedRows[0].Cells[2].Value.ToString();
            //        cmbUType.Text = Stddgv.SelectedRows[0].Cells[4].Value.ToString();


            //        UidStxt.Enabled = UnmStxt.Enabled = ClsScmb.Enabled = cmbUType.Enabled =
            //        SavSbtn.Enabled = CanSbtn.Enabled = false;

            //        EdtSbtn.Enabled = DelSbtn.Enabled = true;
            //    }
            //    else
            //    {
            //        //New User
            //        UidStxt.Text = "";
            //        UnmStxt.Text = "";
            //        ClsScmb.SelectedIndex = 0;
            //        cmbUType.SelectedIndex = 0;


            //        UidStxt.Enabled = UnmStxt.Enabled = ClsScmb.Enabled = cmbUType.Enabled =
            //        SavSbtn.Enabled = CanSbtn.Enabled = true;

            //        EdtSbtn.Enabled = DelSbtn.Enabled = false;
            //    }
            
            
            //}


        #endregion

        #region Holiday Page







            private void SavHbtn_Click(object sender, EventArgs e)
            {


                if (dgvHp.SelectedRows.Count == 0)
                    return;

                int nRowIndex = dgvHp.SelectedRows[0].Index;


                if (nRowIndex == dgvHp.RowCount - 1)
                {
                    //if last row i.e. add_new_record row

                    MySqlCommandBuilder cmdBuild = new MySqlCommandBuilder(m_HolidayAdp);
                    DataRow dsNewRow = m_HolidayTbl.NewRow();
                    m_HolidayTbl.Rows.Add(dsNewRow);


                }
                string str = dtpHoliday.Value.ToString("yyyy-MM-dd");
                // string hdate = str.ToString("yyyy-MM-dd");

                m_HolidayTbl.Rows[nRowIndex]["hdate"] = str;
                m_HolidayTbl.Rows[nRowIndex]["Description"] = Hdesctxt.Text;

                m_HolidayAdp.Update(m_HolidayTbl);

                MessageBox.Show("holiday added");


                SavSbtn.Enabled = CanSbtn.Enabled = true;

                EdtSbtn.Enabled = DelSbtn.Enabled = false;

                if( mysqlCon.State == ConnectionState.Open )
                    mysqlCon.Close();
            }

       
        private void CanHbtn_Click(object sender, EventArgs e)
        {
            if (dgvHp.SelectedRows.Count == 0)
                return;

            int iSelIndex = dgvHp.SelectedRows[0].Index;
            if (iSelIndex == dgvHp.RowCount - 1)
                Stddgv.Rows[0].Selected = true;
            else
            {
               
               SavHbtn.Enabled = CanHbtn.Enabled = false;

                EdtHbtn.Enabled = DelHbtn.Enabled = true;
            }
        }


     
        private void Holidpg_Click(object sender, EventArgs e)
        {
             EdtHbtn.Enabled = DelHbtn.Enabled = false;
        }

        private void EdtHbtn_Click(object sender, EventArgs e)
        {
            int i = dgvHp.CurrentRow.Index;
            string select = dgvHp[i, 1].ToString();
            string query1 = "select hdate from holidays where description='" + select + "'";
            MySqlConnection mysqlCon = new MySqlConnection(strprovider);
           MySqlCommand cmdMySql = new MySqlCommand(query1, mysqlCon );
           mysqlCon.Open();
            MySqlDataReader reader6 = cmdMySql.ExecuteReader();
            
            
            
            
     dtpHoliday.Enabled = Hdesctxt.Enabled = true;
            EdtHbtn.Enabled = DelHbtn.Enabled = false;
         
           
        }
        //TAB3(TOTAL PAGE)
        private void totgetbtn_Click(object sender, EventArgs e)
        {
            string strtdt = totdtpst.Value.ToString("yyyy-MM-dd");
            string enddt = todtpto.Value.ToString("yyyy-MM-dd");
            string query2, strCondition = "";

            if (totcmbstu.SelectedText == "All")    //ALL STUDENTS
            {
                if (totcmbcrse.SelectedText != "All")   //PARTICULAR CLASS
                    strCondition = " r.userid='" + totcmbcrse +"'";
                //else       //ALL CLASSES  <---- HERE CONDITION IS NOT REQUIRED
            }
            else    //PARTICULAR STUDENT
            {
                if (totcmbcrse.SelectedText != "All")      //PARTICULAR CLASS
                    strCondition = "u.class='" + totcmbstu.Text+"' and r.userid='"+totcmbcrse .Text +"'";
                else       //ALL CLASSES
                    strCondition = "";
            }

            query2 = "select u.*,r.attdate,count(r.userid) from user u left join userattendance r on u.userid=r.userid  where " + strCondition + " and attdate not in('" + strtdt + "','" + enddt + "' ) group by u.userid;";



            m_totrecAdp = new MySqlDataAdapter(query2, strprovider);
            m_totrecAdp.Fill(m_totrecTbl);
            dgvtot.DataSource = m_totrecTbl;


            m_totrecAdp = new MySqlDataAdapter(query2, strprovider);
            m_totrecAdp.Fill(m_totrecTbl);
            dgvtot.DataSource = m_totrecTbl;
        }
        
        
       


        private void dgvtot_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void Total_Click(object sender, EventArgs e)
        {

        }

        private void Stdtpg_Click(object sender, EventArgs e)
        {

        }

        private void Stddgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void totcmbstu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toCancbtn_Click(object sender, EventArgs e)
        {
           dgvtot.DataSource =null;
        }

        
       

        //    string str;
        //    str = dtpHoliday.Value.ToString("yyyy-MM-dd");


        //     MySqlCommand command = mysqlCon.CreateCommand();
        //    command.CommandText = "insert into holidays values('" + str + "','" + Hdesctxt.Text + "')";

        //    Console.WriteLine(command.CommandText);

        //    MySqlDataReader result = command.ExecuteReader();

        //    mysqlCon.Close();

        //    MessageBox.Show("holiday added");            


        //    mysqlCon.Close();
        //}

        //private void EdtHbtn_Click(object sender, EventArgs e)
        //{
        //    int i = dgvHp.CurrentRow.Index;

        //    DateTime dt;
        //    dt = Convert.ToDateTime(dgvHp[0, i].Value.ToString());


        //    Hdesctxt.Text = dgvHp[1, i].Value.ToString();

        //}

        //private void Holidpg_Click(object sender, EventArgs e)
        //{
        //   /* mysqlCon.Open();
        //    {
        //        DateTime obj = new DateTime();
        //        string str;
        //        obj = monthCalendar1.SelectionStart;
        //        str = obj.ToString("yyyy-MM-dd");

        //        Hdttxt.Text = str;



        //        MySqlCommand command = mysqlCon.CreateCommand();
        //        command.CommandText = "insert into holidays values('" + str + "','"+Hdesctxt .Text +"')";

        //        Console.WriteLine(command.CommandText);

        //        MySqlDataReader result = command.ExecuteReader();

        //        mysqlCon.Close();

        //        MessageBox.Show("holiday added");




        #endregion

       
        }

    }
