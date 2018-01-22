using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1.Classes
{
    class POS
    {
        public static int storeid;
        public static string storename;
        public static string comment;
        public static string selectedorderid;


        public static void InsertOrderStat(int statid, int orderid)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("Insert into orderstat(orderid,statid,username) values("+orderid+","+statid+",'"+loginmodule.username+"')",detail.con);
                detail.con.Open();
                cmd.ExecuteNonQuery();
                detail.con.Close();
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                return;
            }
        }
        public static void ChangeOrderstat(int orderid, int statid)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("update order_detail set status="+statid+" where id="+orderid+"", detail.con);
                detail.con.Open();
                cmd.ExecuteNonQuery();
                detail.con.Close();
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                return;
            }
            
        }

    }
}
