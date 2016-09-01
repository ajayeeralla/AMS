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
        #region
        string strStudents = "SELECT * FROM user";//"select u.*, count(r.userid) TotalAttandance from user u left join userattendance r on u.userid= r.userid group by u.userid";
        string strHolidays = "SELECT * FROM holidays";
        string strAttendance = "SELECT U.userid AS 'ID', U.username AS 'NAME', U.class AS 'Class', U.usertype AS 'Type', COUNT(A.userid)/2 AS 'Days Attended',(Select count(H.hdate) from Holidays H where H.hdate between '{1}' AND '{2}') as 'Holidays',GetWorkingDays('{1}','{2}') as 'WorkingDays', GetWorkingDays('{1}','{2}') -(Select count(H.hdate) from Holidays H where H.hdate between '{1}' AND '{2}') -COUNT(A.userid)/2 as 'Days Absent' FROM user U LEFT JOIN (select * from userattendance where attdate between {1} and {2})A ON U.userid=A.userid   GROUP BY U.userid;";
        //string strLeaves = "SELECT U.userid,  GetWorkingDays('{0}','{1}')-(Select count(H.hdate) from Holidays H where H.hdate between '{0}' AND '{1}')-COUNT(U.userid)/2 as 'Leaves' FROM holidays H, userattendance U WHERE H.hdate between '{0}' AND '{1}' AND U.attdate BETWEEN '{0}' and '{1}' GROUP BY U.userid;";
        string strClasses = "SELECT class_name FROM Classes";
        #endregion


        MySqlDataAdapter m_StduentAdp = null;
        MySqlCommandBuilder m_StudentBld = null;
        DataTable m_StudentTbl = new DataTable("STUDENTS");
        MySqlDataAdapter m_HolidayAdp = null;
        MySqlCommandBuilder m_HolidayBld = null;
        DataTable m_HolidayTbl = new DataTable("HOLIDAYS");

        public administrator()
        {
            InitializeComponent();
        }


        private void administrator_Load(object sender, EventArgs e)
        {
            //Students Page
            m_StduentAdp = new MySqlDataAdapter(strStudents, Program.dbConn);
            m_StudentBld = new MySqlCommandBuilder(m_StduentAdp);
            m_StduentAdp.Fill(m_StudentTbl);
            Stddgv.DataSource = m_StudentTbl;

            Stddgv.Columns["userid"].HeaderText = "ID";
            Stddgv.Columns["username"].HeaderText = "Name";
            Stddgv.Columns["class"].HeaderText = "Class";
            Stddgv.Columns["password"].HeaderText = "Password";
            Stddgv.Columns["password"].Visible = false;
            Stddgv.Columns["usertype"].HeaderText = "Type";


            //Holidays Page
            m_HolidayAdp = new MySqlDataAdapter(strHolidays, Program.dbConn);
            m_HolidayBld = new MySqlCommandBuilder(m_HolidayAdp);
            m_HolidayAdp.Fill(m_HolidayTbl);
            dgvHp.DataSource = m_HolidayTbl;


            //Classes in Student Page & Attendance Page
            MySqlDataAdapter ClassesAdp = new MySqlDataAdapter(strClasses, Program.dbConn);
            DataTable ClassesTbl = new DataTable();
            ClassesAdp.Fill(ClassesTbl);
            
            ClsScmb.DataSource = ClassesTbl;
            ClsScmb.DisplayMember = "class_name";
            ClsScmb.ValueMember = "class_name";
            
            for( int r = 0 ; r < ClassesTbl.Rows.Count ; r++ )
                totcmbcrse.Items.Add(ClassesTbl.Rows[r].ItemArray[0].ToString());
            totcmbcrse.Items.Add("All");
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
        }

        private void DelSbtn_Click(object sender, EventArgs e)
        {
            if (Stddgv.SelectedRows.Count == 0)
                return;

            int nRowIndex = Stddgv.SelectedRows[0].Index;
            if ((nRowIndex < Stddgv.Rows.Count - 1) && (DialogResult.Yes == MessageBox.Show("Are you sure want to Delete this Record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)))
            {
                m_StudentTbl.Rows[nRowIndex].Delete();
                m_StduentAdp.Update(m_StudentTbl);
                Stddgv.Rows[Stddgv.RowCount - 1].Selected = true;

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

                SavSbtn.Enabled = false;

                DelHbtn.Enabled = CanSbtn.Enabled = true;
            }


        }

        private void Stddgv_SelectionChanged(object sender, EventArgs e)
        {
            if (Stddgv.SelectedRows.Count == 0)
                return;

            if (Stddgv.SelectedRows[0].Index < Stddgv.RowCount - 1)
            {
                //Existing User
                UidStxt.Text = Stddgv.SelectedRows[0].Cells["userid"].Value.ToString();
                UnmStxt.Text = Stddgv.SelectedRows[0].Cells["username"].Value.ToString();
                ClsScmb.Text = Stddgv.SelectedRows[0].Cells["class"].Value.ToString();
                cmbUType.Text = Stddgv.SelectedRows[0].Cells["usertype"].Value.ToString();


                UidStxt.Enabled = UnmStxt.Enabled = ClsScmb.Enabled = cmbUType.Enabled =
                SavSbtn.Enabled = CanSbtn.Enabled = false;

                EdtSbtn.Enabled = DelSbtn.Enabled = true;
            }
            else
            {
                //New User
                UidStxt.Text = "";
                UnmStxt.Text = "";
                ClsScmb.SelectedIndex =0;
                cmbUType.SelectedIndex =0;


                UidStxt.Enabled = UnmStxt.Enabled = ClsScmb.Enabled = cmbUType.Enabled =
                SavSbtn.Enabled = CanSbtn.Enabled = true;

                EdtSbtn.Enabled = DelSbtn.Enabled = false;
            }
        }


        #endregion

        #region Holiday Page
        private void SavHbtn_Click(object sender, EventArgs e)
        {
            if (dgvHp.SelectedRows.Count == 0)
                return;

         
            DateTime dt = new DateTime();
            dt = DateTime.Now;
            if((dtpHoliday.Value >= dt)&&(dtpHoliday.Value.DayOfWeek.ToString().ToLower()!="sunday")&&(dtpHoliday .Value.DayOfWeek.ToString().ToLower()!="saturday"))
            {
                int nRowIndex = dgvHp.SelectedRows[0].Index;

                if ((nRowIndex == dgvHp.RowCount - 1) && (DialogResult.Yes == MessageBox.Show("Are you sure want to save this record", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)))
                {
                   
                    //if last row i.e. add_new_record row
                    {
                        DataRow dsNewRow = m_HolidayTbl.NewRow();
                        m_HolidayTbl.Rows.Add(dsNewRow);
                    }

                    string str = dtpHoliday.Value.ToString("yyyy-MM-dd");
                    // string hdate = str.ToString("yyyy-MM-dd");

                    m_HolidayTbl.Rows[nRowIndex]["hdate"] = str;
                    m_HolidayTbl.Rows[nRowIndex]["Description"] = Hdesctxt.Text;

                    m_HolidayAdp.Update(m_HolidayTbl);
                }
            }
            else
            {
                MessageBox.Show("Invalid Holiday Date", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


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

                DelHbtn.Enabled = true;
            }


        }




        private void dgvHp_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHp.SelectedRows.Count == 0)
                return;

            if (dgvHp.SelectedRows[0].Index < Stddgv.RowCount - 1)
            {
                //Existing record
                dtpHoliday.Text = Stddgv.SelectedRows[0].Cells[0].Value.ToString();
                Hdesctxt.Text = Stddgv.SelectedRows[0].Cells[1].Value.ToString();



                dtpHoliday.Enabled = Hdesctxt.Enabled = false;
                SavSbtn.Enabled = CanSbtn.Enabled = false;

                EdtSbtn.Enabled = DelSbtn.Enabled = true;
            }
            else
            {
                //New record
                dtpHoliday.Text = "";
                Hdesctxt.Text = "";



                Hdesctxt.Enabled = dtpHoliday.Enabled =
                  SavSbtn.Enabled = CanSbtn.Enabled = true;

                EdtSbtn.Enabled = DelSbtn.Enabled = false;
            }
        }

        private void DelHbtn_Click_1(object sender, EventArgs e)
        {
            if (Stddgv.SelectedRows.Count == 0)
                return;

            int nRowIndex = dgvHp.SelectedRows[0].Index;
            if ((nRowIndex < dgvHp.Rows.Count - 1) && (DialogResult.Yes == MessageBox.Show("Are you sure want to Delete this Record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)))
            {

                m_HolidayTbl.Rows[nRowIndex].Delete();

                m_HolidayAdp.Update(m_HolidayTbl);

                dgvHp.Rows[dgvHp.RowCount - 1].Selected = true;


            }


        }




        private void EdtHbtn_Click(object sender, EventArgs e)
        {
            Hdesctxt.Enabled = true;

        }


        //TAB3(TOTAL ATTANDANCE PAGE)

        private void clrHbtn_Click(object sender, EventArgs e)
        {
            dgvtot.DataSource = new DataTable();
        }

        private void totgetbtn_Click(object sender, EventArgs e)
        {
            clrHbtn_Click(sender, e);

            if (totcmbstu.Text == "" || totcmbcrse.Text == "")
            {
                MessageBox.Show("Please select proper values","Message" ,MessageBoxButtons.OK ,MessageBoxIcon.Error);
                return;
            }

            string strtdt = totdtpst.Value.ToString("yyyy-MM-dd");
            string enddt = todtpto.Value.ToString("yyyy-MM-dd");
            string strCondition = "";
            if (totdtpst.Value <= todtpto.Value)
            {

                if (totcmbstu.Text == "All")    //ALL STUDENTS
                {
                    if (totcmbcrse.Text != "All")   //PARTICULAR CLASS
                    {
                        strCondition = " u.class='" + totcmbcrse.Text + "' and";
                    }
                    //else  //ALL CLASSES  <---- HERE CONDITION IS NOT REQUIRED


                }
                else    //PARTICULAR STUDENT
                {
                    if (totcmbcrse.Text != "All")      //PARTICULAR CLASS
                        strCondition = "u.class='" + totcmbcrse.Text + "' and u.userid='" + totcmbstu.Text + "' and";

                    else       //ALL CLASSES
                        strCondition = "";
                }

                MySqlDataAdapter m_totrecAdp = new MySqlDataAdapter(String.Format(strAttendance, strCondition, strtdt, enddt), Program.dbConn);
                DataTable m_totrecTbl = new DataTable();
                m_totrecAdp.Fill(m_totrecTbl);
                dgvtot.DataSource = m_totrecTbl;
            }
            else
            {
                MessageBox.Show("Start date should be before  to enddate", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void Stddgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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








        private void Holidpg_Click(object sender, EventArgs e)
        {

        }

    /*    private void button1_Click(object sender, EventArgs e)
        {
            string strtdt = totdtpst.Value.ToString("yyyy-MM-dd");
            string enddt = todtpto.Value.ToString("yyyy-MM-dd");
            MySqlDataAdapter m_totrecAdp = new MySqlDataAdapter(String.Format(strLeaves, strtdt, enddt), Program.dbConn);
            DataTable m_totrecTbl = new DataTable();
            m_totrecAdp.Fill(m_totrecTbl);
            dgvtot.DataSource = m_totrecTbl;
        }*/

        private void ClsScmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void totcmbstu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void totcmbcrse_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strUsers = null;
            if (totcmbcrse.Text != "All")
                strUsers = "select userid from user where class='" + totcmbcrse.Text + "' ";
            else
                strUsers = "select userid from user where class in (select class_name from Classes)";

            MySqlDataAdapter UsersAdp = new MySqlDataAdapter(strUsers, Program.dbConn);
            DataTable UsersTbl = new DataTable();
            UsersAdp.Fill(UsersTbl);

            totcmbstu.Items.Clear();
            for (int r = 0; r < UsersTbl.Rows.Count; r++)
                totcmbstu.Items.Add(UsersTbl.Rows[r].ItemArray[0].ToString());
            if( 0 < UsersTbl.Rows.Count )
                totcmbstu.Items.Add("All");
        }
    }
}

