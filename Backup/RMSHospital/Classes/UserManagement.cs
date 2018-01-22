using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace WindowsFormsApplication1.Classes
{
    class UserManagement
    {

        public static string username;
        public static int userid;

        // Userinformation and details 
        public static int changeid;
        public static DataTable datata;
        public static int Sutypeid;
        public static string SutypeName;
        //

        public static void getutype()
        {
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM utype WHERE deleteflag=0 ORDER BY TYPE",detail.con);
                datata = new DataTable();
                detail.con.Open();
                da.Fill(datata);
                detail.con.Close();
            }
            catch (Exception ex)
            {
                writeme.errorname(ex);            
            }
        }


        public static bool changepassword(int userid, string pwd)
        {
            bool returnvalue = false;
            string passcode = enc.Encrypt(pwd);
            try
            {
                MySqlCommand cmd = new MySqlCommand("Update users set pwd =?pwd where id=" + userid + "", detail.con);
                cmd.Parameters.Add("?pwd", MySqlDbType.VarChar).Value = passcode;
                detail.con.Open();
                cmd.ExecuteNonQuery();
                detail.con.Close();
                returnvalue = true;
            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
            }
            return returnvalue;


        }

        public static bool deleteuser(int userid)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("update users set deleteflag=1 where id="+userid+"",detail.con);
                detail.con.Open();
                cmd.ExecuteNonQuery();
                detail.con.Close();
                return true;
            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
                return false;
            }
        }
    }
 
}
