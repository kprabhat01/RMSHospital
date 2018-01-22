using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace WindowsFormsApplication1.Classes
{
    class Items
    {

        public static DataTable Itemslist;
        public static bool InsertItems(string itemname, int procat, int units, string comment)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("Insert into inventory_items (productname,procat,units,comment,username) values (?productname," + procat + "," + units + ",?comment,'" + loginmodule.username + "')", detail.con);
                cmd.Parameters.Add("?productname", MySqlDbType.VarChar).Value = itemname;
                cmd.Parameters.Add("?comment", MySqlDbType.VarChar).Value = comment;
                detail.con.Open();
                cmd.ExecuteNonQuery();
                detail.con.Close();
                getItems();
                return true;
            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
                return false;
            }
        }
        public static void getItems()
        {
            try
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter("SELECT inventory_items.id,inventory_items.procat,inventory_items.productname, CONCAT(LEFT(inventory_items.productname,3),'-',inventory_items.id) AS procode,unit.name FROM inventory_items,unit WHERE inventory_items.deleteflag=0 AND unit.id = inventory_items.units  ORDER BY inventory_items.productname", detail.con))
                {
                    Itemslist = new DataTable();
                    detail.con.Open();
                    da.Fill(Itemslist);
                    detail.con.Close();

                }
            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
            }
        }

        public static bool DelItems(int id)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("Update inventory_items set deleteflag=1 where id=" + id + "", detail.con))
                {
                    detail.con.Open();
                    cmd.ExecuteNonQuery();
                    detail.con.Close();
                    getItems();
                    return true;
                }
            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
                return false;
            }

        }

        public static bool InsertItemCat(string catName)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("Insert into inventory_cat (catname) value (?catname)", detail.con))
                {
                    cmd.Parameters.Add("?catname", MySqlDbType.VarChar).Value = catName;
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

        public static bool CheckEntry(int catid)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("select id from inventory_items where procat=" + catid + "", detail.con))
                {
                    detail.con.Open();
                    MySqlDataReader rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                    {
                        detail.con.Close();
                        return true;
                    }
                    else
                    {
                        detail.con.Close();
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
        public static bool DelCatid(int catid)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("update inventory_cat set deleteflag=1 where id=" + catid + "", detail.con))
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
        public static DataTable getDataTable()
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("select id,catname from inventory_cat where deleteflag=0 order by catname", detail.con))
                {
                    detail.con.Open();
                    MySqlDataReader rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                        dt.Load(rd);

                    detail.con.Close();
                }

            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
            }

            return dt;
        }
    }
}
