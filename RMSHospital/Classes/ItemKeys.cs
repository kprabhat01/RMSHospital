using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;

namespace WindowsFormsApplication1.Classes
{
    class ItemKeys
    {
        public static DataTable ItemValue;
        public static int? ManageVendor;

        static ItemKeys() {
            AttendentUtil();
        }
        private static void AttendentUtil()
        {
            if (ConfigurationSettings.AppSettings["ManageAttendent"] == null)
                ManageVendor = 1;
            else if(ConfigurationSettings.AppSettings["ManageAttendent"].ToLower()=="yes")
                ManageVendor = 0;
            else
                ManageVendor = 1;
        }
        public static void getItemKeys()
        {
            try
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter("select * from itemkeys", detail.con))
                {
                    ItemValue = new DataTable();
                    detail.con.Open();
                    da.Fill(ItemValue);
                    detail.con.Close();
                
                }
            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
                return;
            }
        }
    }
}
