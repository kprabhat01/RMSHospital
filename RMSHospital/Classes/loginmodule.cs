using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace WindowsFormsApplication1.Classes
{
    class users
    {
        public int? Id { get; set; }
        public string ufname { get; set; }
        public string ulname { get; set; }
        public string pwd { get; set; }
        public string uname { get; set; }
        public int? utype { get; set; }
        public int? status { get; set; }
        public int? ublk { get; set; }
        public int? deleteflag { get; set; }
    }
    class sec_userprofile
    {
        private int? Id { get; set; }
        public int? mid { get; set; }
        public int? utype { get; set; }

    }
    class loginmodule
    {

        public static DataTable logininfo;
        public static DataTable UserList;
        public static string username;
        public static int uid;
        public static int utype;

        public static void GetUser()
        {
            UserList = new DataTable();
            List<users> UsrLst = new List<users>();
            UsrLst.Add(new users
            {
                deleteflag = 0
            });
            UserList = UsrLst.ReturnRow();
        }
        public static Boolean validatelogin(string uname, string pcode)
        {
            Boolean test = false;
            try
            {
                MySqlCommand cmd = new MySqlCommand("select * from users where uname=?uname and pwd=?pcode limit 1", detail.con);
                cmd.Parameters.Add("?uname", MySqlDbType.VarChar).Value = uname;
                cmd.Parameters.Add("?pcode", MySqlDbType.VarChar).Value = pcode;
                cmd.CommandType = CommandType.Text;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                logininfo = new DataTable();
                detail.con.Open();
                da.Fill(logininfo);
                detail.con.Close();
                if (logininfo.Rows.Count >= 1)
                {
                    username = logininfo.Rows[0][1].ToString() + "," + logininfo.Rows[0][2].ToString();
                    uid = int.Parse(logininfo.Rows[0][0].ToString());
                    utype = int.Parse(logininfo.Rows[0][5].ToString());
                    test = true;
                }

            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
                test = false;
            }

            return test;
        }

    }
}
