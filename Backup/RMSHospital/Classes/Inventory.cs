using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace WindowsFormsApplication1.Classes
{
    class Inventory
    {
        //StoreSideDataTable


        public Inventory()
        {
            stockInwards = new DataTable();
            stockInwards.Columns.Add("Product ID", typeof(int));
            stockInwards.Columns.Add("Product Name", typeof(string));
            stockInwards.Columns.Add("Qty", typeof(decimal));
            stockInwards.Columns.Add("Rate", typeof(decimal));
            stockInwards.Columns.Add("Total", typeof(decimal));
            stockInwards.Columns.Add("Vendor ID", typeof(int));
        }

        public DataTable stockInwards;

        public static DataTable listdata;
        public static DataTable listcat;
        // After adding list to the gridview 
        public static DataTable stocklist;
        // Store Side stock for the Datadetails.

        public DataTable getStoreDataMember;
        public static void getUnits()
        {
            try
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter("select id,name from unit where deleteflag=0 order by name", detail.con))
                {
                    listdata = new DataTable();
                    detail.con.Open();
                    da.Fill(listdata);
                    detail.con.Close();
                }

            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
            }
        }
        public static void getCat()
        {
            try
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter("select id,catname from inventory_cat where deleteflag=0 order by catname", detail.con))
                {
                    listcat = new DataTable();
                    detail.con.Open();
                    da.Fill(listcat);
                    detail.con.Close();
                }

            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
            }

        }

        public static bool CorrectMenu(int storeid, int proid)
        {
            try
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter("select id from storestock where storeid=" + storeid + " and itemid=" + proid + "", detail.con))
                {
                    DataTable dt = new DataTable();
                    detail.con.Open();
                    da.Fill(dt);
                    detail.con.Close();
                    if (dt.Rows.Count >= 1)
                    { }
                    else
                    {
                        using (MySqlCommand cmd = new MySqlCommand("Insert into storestock(itemid,storeid) values(" + proid + "," + storeid + ")", detail.con))
                        {
                            detail.con.Open();
                            cmd.ExecuteNonQuery();
                            detail.con.Close();
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
                return false;
            }
        }

        public static bool prostockInsert(int storeid, int proid, float qty, float rate)
        {
            try
            {
                string query = "Update storestock set cur_stock=cur_stock+" + qty + ",lastupdate='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' where itemid=" + proid + " and storeid=" + storeid + "";
                using (MySqlCommand cmd = new MySqlCommand(query, detail.con))
                {
                    detail.con.Open();
                    cmd.ExecuteNonQuery();
                    detail.con.Close();
                    using (MySqlCommand cmd1 = new MySqlCommand("Insert into storestock_logs(itemid,storeid,qty,rate,total,transtype,DateDetail,username,day) values (" + proid + "," + storeid + "," + qty + "," + rate + "," + (qty * rate) + ",'0','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + loginmodule.username + "','" + OpenDay.day + "')", detail.con))
                    {
                        detail.con.Open();
                        cmd1.ExecuteNonQuery();
                        detail.con.Close();
                        return true;
                    }
                }
            }
            catch (Exception x)
            {
                Classes.writeme.errorname(x);
                return false;
            }
        }

        public static DataTable getInsertedData(int storeid, string day)
        {
            DataTable dt = new DataTable();
            try
            {

                using (MySqlDataAdapter da = new MySqlDataAdapter("SELECT storestock_logs.id,storestock_logs.itemid,storestock_logs.storeid,inventory_items.productname AS ItemName,pro_catagories.name AS Catagories,storestock_logs.qty AS Qty,storestock_logs.rate AS Rate FROM storestock_logs,inventory_items,pro_catagories WHERE pro_catagories.id = inventory_items.procat AND storestock_logs.itemid =inventory_items.id  AND storestock_logs.storeid=" + storeid + " AND storestock_logs.DAY ='" + day + "' and storestock_logs.lockmenu=0 order by storestock_logs.id desc", detail.con))
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
        public static bool saveInventory(string proid)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("update storestock_logs set lockmenu=1 where id in(" + proid + ")", detail.con))
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
        public static bool DeleteProduct(int proid, int storeid, float qty, int id)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("update storestock set cur_stock= cur_stock-" + qty + ",lastupdate='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' where itemid=" + proid + " and storeid=" + storeid + "", detail.con))
                {
                    detail.con.Open();
                    cmd.ExecuteNonQuery();
                    detail.con.Close();
                    using (MySqlCommand cmd1 = new MySqlCommand("delete from storestock_logs where id='" + id + "'", detail.con))
                    {
                        detail.con.Open();
                        cmd1.ExecuteNonQuery();
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

        public static void GetStockInfo(int storeid)
        {
            try
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter("SELECT storestock.itemid,storestock.cur_stock,storestock.lastupdate,unit.name,Inventory_items.productname,storestock.id FROM storestock,Inventory_items,unit WHERE storestock.itemid = Inventory_items.id AND Inventory_items.units = unit.id and storestock.storeid=" + storeid + "", detail.con))
                {
                    stocklist = new DataTable();
                    detail.con.Open();
                    da.Fill(stocklist);
                    detail.con.Close();
                }
            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
                return;
            }
        }
        public static bool InsertDependent(int menuMapId, int menuid, float qty)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("delete from menu_items_dependency where menuid=" + menuid + "", detail.con))
                {
                    detail.con.Open();
                    cmd.ExecuteNonQuery();
                    detail.con.Close();
                    using (MySqlCommand cmd1 = new MySqlCommand("Insert into menu_items_dependency(menuMapId,menuid,qty) values(" + menuMapId + "," + menuid + "," + qty + ")", detail.con))
                    {

                        detail.con.Open();
                        cmd1.ExecuteNonQuery();
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
        public static DataTable IndividualStoreStock(int storeid)
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter("SELECT storestock.id,inventory_items.id as Itemid,inventory_items.productname AS ItemName,unit.name,storestock.cur_stock AS Stock FROM storestock,inventory_items,unit WHERE inventory_items.id = storestock.itemid AND unit.id = inventory_items.units AND storestock.storeid=" + storeid + "", detail.con))
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

        public static bool outwardstock(int itemid, float qty, int storeid)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("Insert into stock_outwards (itemid,qty,day,saveflag,storeid,outwardtype) values(" + itemid + "," + qty + ",'" + OpenDay.day + "',0," + storeid + ",0)", detail.con))
                {
                    detail.con.Open();
                    cmd.ExecuteNonQuery();
                    detail.con.Close();
                    using (MySqlCommand cmd1 = new MySqlCommand("update storestock set cur_stock=cur_stock-" + qty + " where itemid=" + itemid + " and storeid=" + storeid + " limit 1", detail.con))
                    {
                        detail.con.Open();
                        cmd1.ExecuteNonQuery();
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
        public static DataTable getOutwardsStock(int storeid)
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter("SELECT stock_outwards.id,stock_outwards.itemid,inventory_items.productname AS ItemName,stock_outwards.qty AS Qty,unit.name AS Unit,stock_outwards.storeid AS storeid FROM stock_outwards,unit,inventory_items WHERE inventory_items.id = stock_outwards.itemid AND unit.id = inventory_items.units AND stock_outwards.storeid=" + storeid + " AND stock_outwards.saveflag=0", detail.con))
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
        public static bool RemoveOutWardStock(int id, int itemid, int storeid, float qty)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("Delete from stock_outwards where id=" + id + " limit 1", detail.con))
                {
                    detail.con.Open();
                    cmd.ExecuteNonQuery();
                    detail.con.Close();
                    using (MySqlCommand cmd1 = new MySqlCommand("Update storestock set cur_stock=cur_stock+" + qty + " where itemid=" + itemid + " and storeid=" + storeid + "", detail.con))
                    {
                        detail.con.Open();
                        cmd1.ExecuteNonQuery();
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
        public static void SaveTempInformation()
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("update stock_outwards set saveflag=1 where saveflag=0", detail.con))
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
        public static int getVendorID(int storeid, int vendorid, string CreditAmount, string comment, string paidAmount, bool paymentCat)
        {
            int id = 0;
            try
            {
                string query = "";
                string datetime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                if (paymentCat)
                    query = "Insert into vendorAccount(vendorid,CreatedDate,Comment,creditAmu,username) values (" + vendorid + ",'" + datetime + "',?comment,'" + CreditAmount + "','" + loginmodule.username + "')";
                else
                    query = "Insert into vendorAccount(vendorid,CreatedDate,Comment,paidAmu,username) values (" + vendorid + ",'" + datetime + "',?comment,'" + paidAmount + "','" + loginmodule.username + "')";
                //MySqlCommand cmd = new MySqlCommand("Insert into vendorAccount(vendorid,CreatedDate,Comment,creditAmu,paidAmu,username) values (" + vendorid + ",'" + datetime + "',?comment,'" + CreditAmount + "','" + paidAmount + "','" + loginmodule.username + "')", detail.con)

                using (MySqlCommand cmd = new MySqlCommand(query, detail.con))
                {
                    cmd.Parameters.Add("?comment", MySqlDbType.Text).Value = comment;
                    detail.con.Open();
                    cmd.ExecuteNonQuery();
                    detail.con.Close();
                }
                using (MySqlCommand cmd1 = new MySqlCommand("select id from vendorAccount where CreatedDate='" + datetime + "' and username='" + loginmodule.username + "'  limit 1", detail.con))
                {
                    detail.con.Open();
                    MySqlDataReader rd = cmd1.ExecuteReader();
                    while (rd.Read())
                    {
                        id = rd.GetInt32(0);
                    }
                    detail.con.Close();
                }
            }
            catch (Exception ex)
            {
                writeme.errorname(ex);

            }
            return id;
        }
        // get Store Side Inventory Items 

        public void getListofStoreInventory(int storeid)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM storestock where storeid=" + storeid + "", detail.con))
                {
                    detail.con.Open();
                    MySqlDataReader rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                    {
                        getStoreDataMember = new DataTable();
                        getStoreDataMember.Load(rd);
                    }
                    detail.con.Close();
                }
            }
            catch (Exception e)
            {
                Classes.writeme.errorname(e);
                return;
            }
        }
        // End of the method

        // Inserting difference 
        public void insertDifference()
        {
            try
            {
                StringBuilder query = new StringBuilder();

                DataTable UpdatedStock = stockInwards.DefaultView.ToTable("Product ID", true);


                // String getting value to the service.
                //string value = 
                for (int i = 0; i < UpdatedStock.Rows.Count; i++)
                {
                    DataTable OldInsertedStock = getStoreDataMember.DefaultView.ToTable("itemid", true);
                    OldInsertedStock.DefaultView.RowFilter = "itemid=" + UpdatedStock.Rows[i]["product id"].ToString() + "";
                    OldInsertedStock = OldInsertedStock.DefaultView.ToTable();
                    if (OldInsertedStock.Rows.Count <= 0)
                    {
                        query.Append("Insert into storestock (itemid,storeid) values (" + int.Parse(UpdatedStock.Rows[i]["product id"].ToString()) + "," + Stores.SelectedStoreid + ");");
                    }

                }
                SqlHelper.InsertInfo(query.ToString());

                /*DataTable result = new DataTable();
                result = UpdatedStock.AsEnumerable().Except(OldInsertedStock.AsEnumerable(), DataRowComparer.Default).CopyToDataTable();                
                if (result.Rows.Count >= 1)
                {
                    
                    foreach (DataRow dr in result.Rows)
                    {
                        query.Append("(" + int.Parse(dr[0].ToString()) + "," + Stores.SelectedStoreid + "), ");
                    }

                }
                string RanQuery = query.ToString().TrimEnd(',');

                */
            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
                return;
            }
        }
        // End of the method
    }
}
