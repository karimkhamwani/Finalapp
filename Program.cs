using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FlamingoWF
{
    static class Program
    {
        private static string ConnectionString;
        public static string  CONSTR
        {
            get { return ConnectionString; }
            set { value = ConnectionString; }
        }

        private static string FlamingoDbstring;
        public static string FCONSTR
        {
            get { return FlamingoDbstring; }
            set { value = FlamingoDbstring; }
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

      
        /*public static void CONNECTIONOPEN()
        {
             SqlConnection con = new SqlConnection(Program.CONSTR);
            con.Open();
        }*/
        static void Main()
        {
            FlamingoDbstring="Data Source=KARIM-PC\\SQLEXPRESS;Initial Catalog=flamingoWindowsapplicationDb;Integrated Security=True";
            ConnectionString = "Data Source=KARIM-PC\\SQLEXPRESS;Initial Catalog=WebsiteProjectFlamingo;Integrated Security=True";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
