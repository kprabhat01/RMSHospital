using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;



namespace WindowsFormsApplication1
{
    class detail
    {

        //public static string conname = Classes.enc.Decrypt(System.Configuration.ConfigurationSettings.AppSettings.Get("Con"));
        public static MySqlConnection con = new MySqlConnection(Classes.enc.Decrypt(System.Configuration.ConfigurationSettings.AppSettings.Get("Con")));
        public static string logspath = System.Configuration.ConfigurationSettings.AppSettings.Get("logspath");
        

    }
}
