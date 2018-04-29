using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace WindowsFormsApplication1.Classes
{

    class inven_DayEnd_Stock
    {
        public int? Id { get; set; }
        public int? MenuId { get; set; }
        public decimal? Qty { get; set; }
        public int? StoreId { get; set; }
        public string DayDate { get; set; }
    }
    class day_open_logs
    {
        public int? Id { get; set; }
        public int? StoreId { get; set; }
        public string DateDetail { get; set; }
        public string Username { get; set; }
        public string CloseDate { get; set; }
        public int Openflag { get; set; }
        public string Closedusername { get; set; }

    }
    class DayEndStatement
    {
        public static DataTable Inventory;
        public static void getDayEndInventory(int storeid, string dayopen)
        {
            try
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter("SELECT pos_item_mappeing.itemid,SUM(order_items.qty*pos_item_mappeing.qty) AS Qty  FROM order_items,pos_item_mappeing,order_detail WHERE order_items.menuid = pos_item_mappeing.menuid  AND order_items.orderid = order_detail.id AND  order_detail.openday='" + dayopen + "' and order_detail.storeid=" + storeid + " GROUP BY order_items.menuid ", detail.con))
                {
                    Inventory = new DataTable();
                    detail.con.Open();
                    da.Fill(Inventory);
                    detail.con.Close();
                }

            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
                return;
            }
        }

        public static bool closeDay(int LogId, int StoreId, string openDay)
        {
            if (detail.con.State == ConnectionState.Open)
                detail.con.Close();
            MySqlConnection SqlCon = detail.con;
            MySqlTransaction Trns = null;
            try
            {
                SqlCon.Open();
                Trns = SqlCon.BeginTransaction();

                /*   getDayEndInventory(storeid, openDay);
                   if (Inventory.Rows.Count >= 1)
                   // Insert into menu
                   {
                       StringBuilder query = new StringBuilder();
                       StringBuilder queryInsert = new StringBuilder();
                       queryInsert.Append("Insert into stock_outwards (itemid,qty,day,saveflag,storeid,OutWardType) values ");
                       foreach (DataRow dr in Inventory.Rows)
                       {
                           query.Append("update storestock set cur_stock = cur_stock-" + dr["Qty"].ToString() + " where itemid=" + dr["itemid"].ToString() + " and storeid=" + storeid + "; ");
                           queryInsert.Append(" (" + dr["itemid"].ToString() + "," + dr["Qty"].ToString() + ",'" + openDay + "',1," + storeid + ",1),");
                       }

                       using (MySqlCommand cmd = new MySqlCommand(query.ToString(), detail.con))
                       {
                           detail.con.Open();
                           cmd.ExecuteNonQuery();
                           detail.con.Close();
                       }

                       // Inserting logs
                       string rumquery = queryInsert.ToString().TrimEnd(',');
                       using (MySqlCommand cmd1 = new MySqlCommand(rumquery.ToString(), detail.con))
                       {
                           detail.con.Open();
                           cmd1.ExecuteNonQuery();
                           detail.con.Close();
                       }
                   }
                   // insert Day end logs
                   using (MySqlCommand cmd2 = new MySqlCommand("insert into store_end_stock (storeid,itemid,qty,daydate) select storeid,itemid,cur_stock,'" + openDay + "' from storestock where storeid=" + storeid + "", detail.con))
                   {
                       detail.con.Open();
                       cmd2.ExecuteNonQuery();
                       detail.con.Close();
                   }
                   //Closing Day
                   using (MySqlCommand cmd = new MySqlCommand("update day_open_logs set closedate='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',openflag=1,closedusername='" + loginmodule.username + "' where storeid='" + storeid + "' and date(datedetail)='" + openDay + "'", detail.con))
                   {
                       detail.con.Open();
                       cmd.ExecuteNonQuery();
                       detail.con.Close();
                   }*/



                MySqlCommand cmd = new MySqlCommand("SP_DayEndStock", SqlCon, Trns);
                cmd.Parameters.Add("InStoreId", MySqlDbType.Int32).Value = StoreId;
                cmd.Parameters.Add("InDate", MySqlDbType.VarChar).Value = openDay;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();

                List<day_open_logs> DbLogs = new List<day_open_logs>();
                DbLogs.Add(new day_open_logs
                {
                    Id = LogId,
                    Closedusername = loginmodule.username,
                    CloseDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    Openflag = 1
                });
                if (DbLogs.UpdateChanges(SqlCon, Trns))
                {
                    Trns.Commit();
                    return true;
                }
                else
                {
                    Trns.Rollback();
                    return false;
                }
            }
            catch (Exception ex)
            {
                Trns.Rollback();
                writeme.errorname(ex);
                return false;
            }
            finally
            {
                if (detail.con.State == ConnectionState.Open)
                    detail.con.Close();
            }
        }
    }
}
