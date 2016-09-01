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
    public partial class Login : Form
    {
        #region Queries
        String strCheckLogin = "select usertype from user where userid='{0}' and password='{1}'";
        #endregion

        public static string sUid;

       
        public Login()
        {
            InitializeComponent();       
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            sUid = txtUid.Text;

            Form frmChild = null;
            try
            {
                using (MySqlDataAdapter dtApt = new MySqlDataAdapter(String.Format(strCheckLogin, txtUid.Text, txtPwd.Text)
                    , Program.dbConn))
                {
                    DataSet ds = new DataSet();
                    dtApt.Fill(ds, "LOGIN_CHECK");

                    if( 0 < ds.Tables["LOGIN_CHECK"].Rows.Count )
                    {
                        switch (ds.Tables["LOGIN_CHECK"].Rows[0].ItemArray[0].ToString().Trim().ToLower())
                        {
                            case "admin":
                                frmChild = new administrator();
                                break;
                            case "user":
                                frmChild = new user();
                                break;
                            default:
                                break;
                        }

                    }
                    else
                        MessageBox.Show("Invalid User", Program.ApplName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Hide();
            if (frmChild != null)
                frmChild.ShowDialog();
            this.Show();
        }

        private void Login_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
                txtUid.Text = txtPwd.Text = "";
        }
    }
}