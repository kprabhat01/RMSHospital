using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace WindowsFormsApplication1.Classes
{
    class ProductMapping
    {
        public static int selectedproid;
        public static string selectedproductname;


        public static void insertmenu(int menuid, int storeid, int itemid, float qty, string username)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("Insert into pos_item_mappeing(menuid,storeid,itemid,qty,username) values (" + menuid + "," + storeid + "," + itemid + "," + qty + ",'" + username + "')", detail.con))
                {
                    detail.con.Open();
                    cmd.ExecuteNonQuery();
                    detail.con.Close();
                }
            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
                return;
            }

        }
        public static DataTable getInsertedValue(int storeid, int menuid)
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter("SELECT pos_item_mappeing.id,Inventory_items.productname as 'Product Name',pos_item_mappeing.qty as Qty FROM pos_item_mappeing,Inventory_items WHERE Inventory_items.id = pos_item_mappeing.itemid AND pos_item_mappeing.menuid=" + menuid + " and pos_item_mappeing.storeid=" + storeid + " order by Inventory_items.productname", detail.con))
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
        public static bool checkproinsert(int itemid, int menuid, int storeid)
        {
            try
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter("select id from pos_item_mappeing where menuid=" + menuid + " and storeid=" + storeid + " and itemid=" + itemid + "", detail.con))
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
        public static bool DeleteItems(int id)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("Delete from pos_item_mappeing where id=" + id + "", detail.con))
                {
                    detail.con.Open();
                    cmd.ExecuteNonQuery();
                    detail.con.Close();
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
