using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace WindowsFormsApplication1.Classes
{
    class vendors
    {
        public static int vendorflag;
        public static int selectflag;
        public static DataTable vendordt;
        public static int selectedVendorid;
        public static string selectvedorname;

        // Grid Selected  SubMenu
        public static string VnName;
        public static string Vnphone;
        public static string VnAddress;
        public static string Vnemail;
        public static string VnIsActive;

        //


        public static bool VendorManage(int venflag, string vendorname, string email, string contact, string comment, int stat)
        {
            MySqlCommand cmd;
            string query = null;
            try
            {

                if (venflag == 0)
                {
                    query = "Insert into vendors(vendorname,contact_detail,phoneno,email,status) values (?vendorname,?contact_detail,?phoneno,?email,?stat)";

                }
                else if (venflag >= 1)
                {
                    query = "update vendors set vendorname=?vendorname,contact_detail=?contact_detail,phoneno=?phoneno,email=?email,status=?stat where id=" + venflag + "";
                }
                cmd = new MySqlCommand(query, detail.con);
                cmd.Parameters.Add("?vendorname", MySqlDbType.VarChar).Value = vendorname;
                cmd.Parameters.Add("?contact_detail", MySqlDbType.VarChar).Value = comment;
                cmd.Parameters.Add("?phoneno", MySqlDbType.VarChar).Value = contact;
                cmd.Parameters.Add("?email", MySqlDbType.VarChar).Value = email;
                cmd.Parameters.Add("?stat", MySqlDbType.VarChar).Value = stat;
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
        public static void vendorslist()
        {
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("Select * from vendors where deleteflag=0 order by vendorname", detail.con);
                vendordt = new DataTable();
                detail.con.Open();
                da.Fill(vendordt);
                detail.con.Close();

            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
            }

        }
        public static bool deletevendor(int vid)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("update vendors set deleteflag=1 where id=" + vid + "", detail.con))
                {
                    detail.con.Open();
                    cmd.ExecuteNonQuery();
                    detail.con.Close();
                    vendorslist();
                    return true;
                }
            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
                return false;
            }
        }

    }
}
