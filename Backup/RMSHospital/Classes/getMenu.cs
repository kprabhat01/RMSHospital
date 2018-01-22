using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
namespace WindowsFormsApplication1.Classes
{
    class getMenu
    {
        public static DataTable getMenudetail()
        {
            DataTable dt = new DataTable();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("select * from menude where deleteflag=0 and liesin=0 order by menuname", detail.con);
                detail.con.Open();
                da.Fill(dt);
                detail.con.Close();
            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
            }
            return dt;
        }
        public static DataTable sublist(int utype)
        {
            DataTable dt = new DataTable();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT menude.menuname,menude.detail,menude.opentype,menude.liesin FROM menude,sec_userprofile WHERE menude.id = sec_userprofile.mid AND sec_userprofile.utype='" + utype + "' and menude.deleteflag=0", detail.con);
                detail.con.Open();
                da.Fill(dt);
                detail.con.Close();
            }
            catch(Exception ex)
            {
                messagemode.messageget(false, ex.Message);
                writeme.errorname(ex);
            }
            return dt;
        }

       
    }
}
