using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace WindowsFormsApplication1.Classes
{
    class ItemKeys
    {
        public static DataTable ItemValue;

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
