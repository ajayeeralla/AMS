using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace attandance_management_system
{
    static class Program
    {
        public static MySqlConnection dbConn;
        public static String ApplName = "Attendence Management System";
        public static String ConnString = "Database=project;Data Source=localhost;User Id=root;Password={0};";
        //string gConnStr = "host=localhost;database=project;UID=root;Password=mysql;";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login());
            using (dbConn = new MySqlConnection())
            {
                dbConn.ConnectionString = String.Format(ConnString, attandance_management_system.Properties.Settings.Default.MySqlPassword);
                dbConn.Open();

                Application.Run(new Login());

                dbConn.Close();
            }
        }
    }
}
