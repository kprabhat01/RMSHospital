using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
namespace WindowsFormsApplication1.Classes
{
    class Tables
    {

        public static DataTable tabledetail;

        public static string STableName;
        public static int STableId;


        public static bool InsertTable(string tablename)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("Insert into tabledetail(tablename) values(?tablename)", detail.con);
                cmd.Parameters.Add("?tablename", MySqlDbType.VarChar).Value = tablename;
                detail.con.Open();
                cmd.ExecuteNonQuery();
                detail.con.Close();
                return true;
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                return false;

            }
        }

        public static void gettablelist()
        {
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("select * from tabledetail where deleteflag=0",detail.con);
                tabledetail = new DataTable();
                detail.con.Open();
                da.Fill(tabledetail);
                detail.con.Close();
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
            }
        }
        public static bool DeleteTable(int tableid)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("update tabledetail set deleteflag=1 where id="+tableid+"",detail.con);
                detail.con.Open();
                cmd.ExecuteNonQuery();
                detail.con.Close();
                return true;
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex); 
                return false; 
            }
        }
    }
}
