using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;

namespace WindowsFormsApplication1
{
    class detail
    {
        static detail()
        {
            if (detail.con.State == ConnectionState.Open || detail.con.State == ConnectionState.Broken)
                detail.con.Close();
        }
        //public static string conname = Classes.enc.Decrypt(System.Configuration.ConfigurationSettings.AppSettings.Get("Con"));
        public static MySqlConnection con = new MySqlConnection(Classes.enc.Decrypt(ConfigurationSettings.AppSettings.Get("Con")));
        public static MySqlConnection NewMysql
        {
            get
            {
                return new MySqlConnection(Classes.enc.Decrypt(ConfigurationSettings.AppSettings.Get("Con")));
            }
        }

        public static string logspath = ConfigurationSettings.AppSettings.Get("logspath");


    }
}
