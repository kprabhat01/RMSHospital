using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;


namespace WindowsFormsApplication1.Classes
{

    class AttendanceMode
    {

        public static DataTable AttandenceData;

        public static void getAttandanceMode()
        {
            try
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM attanceMode WHERE deleteflag =0 ORDER BY MODE", detail.con))
                {
                    AttandenceData = new DataTable();
                    detail.con.Open();
                    da.Fill(AttandenceData);
                    detail.con.Close();
                }
            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
                return;
            }
        }

        public static DataTable getUsers()
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter("select id,concat(ufname,',',ulname) as 'Employee Name' from users where deleteflag=0 order by 'Employee Name'", detail.con))
                {
                    detail.con.Open();
                    da.Fill(dt);
                    detail.con.Close();
                }
            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
            }
            return dt;
        }

        public static DataTable getUsersChecked()
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter("select userid,AttendenceMode from users_atten where date(timedata)='" + DateTime.Now.ToString("yyyy-MM-dd") + "'", detail.con))
                {
                    detail.con.Open();
                    da.Fill(dt);
                    detail.con.Close();
                }
            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
            }
            return dt;
        }

        public static bool InsertVaue(string userid)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("Delete from users_atten where date(timedata)='" + DateTime.Now.ToString("yyyy-MM-dd") + "'", detail.con))
                {
                    detail.con.Open();
                    cmd.ExecuteNonQuery();
                    detail.con.Close();
                    using (MySqlCommand cmd2 = new MySqlCommand("Insert into users_atten (userid,attendenceMode,username) values " + userid + "", detail.con))
                    {
                        detail.con.Open();
                        cmd2.ExecuteNonQuery();
                        detail.con.Close();
                        return true;
                    }
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
