using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace WindowsFormsApplication1.Classes
{
    class OpenDay
    {
        public static string day;
        public static bool getOldList(int storeid)
        {
            try
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter("select id from day_open_logs where storeid=" + storeid + " and openflag=0 limit 1", detail.con))
                {
                    DataTable dt = new DataTable();
                    detail.con.Open();
                    da.Fill(dt);
                    detail.con.Close();
                    if (dt.Rows.Count >= 1)
                    {
                        return false;
                    }
                    else
                    {
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
        public static bool CheckOpenStat(int storeid)
        {
            try
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter("select id from day_open_logs where storeid=" + storeid + " and date(datedetail)='" + day + "'", detail.con))
                {
                    DataTable dt = new DataTable();
                    detail.con.Open();
                    da.Fill(dt);
                    detail.con.Close();
                    if (dt.Rows.Count >= 1)
                        return true;
                    else
                        return false;
                }
            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
                return false;
            }

        }
        public static bool OpenStoreDay(int storeid)
        {
            try
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter("select * from day_open_logs where storeid=" + storeid + " and date(datedetail)='" + DateTime.Now.ToString("yyyy-MM-dd") + "'", detail.con))
                {
                    DataTable dt = new DataTable();
                    detail.con.Open();
                    da.Fill(dt);
                    detail.con.Close();
                    if (dt.Rows.Count >= 1)
                    {
                        Classes.messagemode.messageget(false, "Store has already open for the day");
                        return false;

                    }
                    else
                    {
                        using (MySqlCommand cmd = new MySqlCommand("Insert into day_open_logs(storeid,username) values(" + storeid + ",'" + loginmodule.username + "')", detail.con))
                        {
                            detail.con.Open();
                            cmd.ExecuteNonQuery();
                            detail.con.Close();
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
                return false;
            }
        }

        public static DataTable getOpenStores()
        {
            DataTable dt = new DataTable();
            try
            {

                using (MySqlDataAdapter da = new MySqlDataAdapter("SELECT day_open_logs.id,stores.id AS storeid,stores.storename AS StoreName,day_open_logs.dateDetail AS 'Date',day_open_logs.username AS username FROM day_open_logs,stores WHERE stores.id = day_open_logs.storeid AND day_open_logs.openflag=0", detail.con))
                {

                    detail.con.Open();
                    da.Fill(dt);
                    detail.con.Close();
                    return dt;

                }
            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
            }
            return dt;
        }

        public static bool getstoreOpenlog(int storeid)
        {
            day = "";
            try
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter("SELECT id,DateDetail FROM day_open_logs where storeid=" + storeid + " and Openflag=0 order by id desc ", detail.con))
                {
                    DataTable dt = new DataTable();
                    detail.con.Open();
                    da.Fill(dt);
                    detail.con.Close();
                    if (dt.Rows.Count >= 1)
                    {
                        DateTime dt1 = DateTime.Parse(dt.Rows[0][1].ToString());
                        //day = dt1.ToString("dd-MMM-yyyy");
                        TimeSpan tff = DateTime.Now - DateTime.Parse(dt.Rows[0][1].ToString());
                        if (tff.TotalHours > 24)
                        {
                            return false;
                        }
                        else
                        {
                            day = dt1.ToString("yyyy-MM-dd");
                            return true;
                        }
                    }
                    else
                    {
                        return false;
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
