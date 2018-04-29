using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace WindowsFormsApplication1.Classes
{
    class OrderMode
    {

        public static DataTable Payments;
        public static DataTable Orders;
        public static decimal amount, refundAmount, placedOrderAmount, discountAmount, PaidAmount, creditAmu;
        public static bool placeflag;
        public static int customerid, ordermode;
        public static string customerinfo;
        public static string billcomment;
        public static int creditCustomeId;
        public static bool CreditMode;
        public static int SelectedOrderId;


        public static void getOrderMode()
        {
            try
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter("select * from oredermode where deleteflag=0", detail.con))
                {
                    Orders = new DataTable();
                    detail.con.Open();
                    da.Fill(Orders);
                    detail.con.Close();
                }
            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
                return;
            }
        }

        public static void getPayments()
        {
            try
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter("select * from payment_mode where deleteflag=0", detail.con))
                {
                    Payments = new DataTable();
                    detail.con.Open();
                    da.Fill(Payments);
                    detail.con.Close();
                }
            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
            }
        }

        public static void InsertCustomerCredit(bool credit, int customerid, decimal amount)
        {
            try
            {
                string query = "";
                if (credit)
                    query = "Insert into customers_credit(custid,comment,EventDate,creditAmu,username) values (" + customerid + ",?comment,'" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + amount + "','" + loginmodule.username + "')";
                else
                    query = "Insert into customers_credit(custid,comment,EventDate,PaidAmu,username) values (" + customerid + ",?comment,'" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + amount + "','" + loginmodule.username + "')";

                using (MySqlCommand cmd = new MySqlCommand(query, detail.con))
                {
                    cmd.Parameters.Add("?comment", MySqlDbType.Text).Value = Classes.OrderMode.billcomment;
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

        public static int orderPlace(int storeid, decimal amount, decimal tax, decimal tamu, int stat, decimal ovamount, string tabid, int paymode, int credit, int custid, decimal amountgiven, decimal amountRefund, string addcomment, decimal discount, decimal paidAmu, decimal creditValue, string Attname)
        {
            int orderid = 0;
            string datedetail = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("Insert into order_detail(storeid,orderdatetime,username,uid,amount,tax,tamu,status,overall_amu,tableid,payMode,credit,openday,cutomerid,AmountGiven,AmountRefund,Add_Comment,discount,PaidAmu,discountComment,credit_amount,AttenName) values(" + storeid + ",'" + datedetail + "','" + loginmodule.username + "','" + loginmodule.uid + "','" + amount + "','" + tax + "','" + tamu + "','" + stat + "','" + ovamount + "','" + tabid + "','" + paymode + "','" + credit + "','" + OpenDay.day + "'," + custid + "," + amountgiven + "," + amountRefund + ",?Add_Comment,'" + discount + "','" + paidAmu + "',?discountCommnet,'" + creditValue + "',?AttenName) ", detail.con))
                {

                    cmd.Parameters.Add("?Add_Comment", MySqlDbType.Text).Value = addcomment;
                    cmd.Parameters.Add("?discountCommnet", MySqlDbType.Text).Value = billcomment;
                    cmd.Parameters.Add("?AttenName", MySqlDbType.VarChar).Value = Attname;
                    detail.con.Open();
                    cmd.ExecuteNonQuery();
                    detail.con.Close();
                    using (MySqlDataAdapter da = new MySqlDataAdapter("select * from order_detail where orderdatetime='" + datedetail + "' and uid=" + loginmodule.uid + " limit 1", detail.con))
                    {
                        DataTable dt = new DataTable();
                        detail.con.Open();
                        da.Fill(dt);
                        detail.con.Close();
                        if (dt.Rows.Count >= 1)
                        {
                            orderid = int.Parse(dt.Rows[0][0].ToString());
                            if (creditCustomeId >= 1)
                                InsertCustomerCredit(true, creditCustomeId, creditValue);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
            }
            return orderid;
        }
        public static bool insertOderItems(int orderid, string tableid, DataTable dt)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO order_items(orderid,menuid,amount,tax,tamu,oamu,COMMENT,qty) SELECT " + orderid + ", itemid,rate,'0.00',rate,amount,COMMENT,qty FROM order_temp WHERE userid='" + loginmodule.uid + "' AND tableid='" + tableid + "'", detail.con))
                {
                    detail.con.Open();
                    cmd.ExecuteNonQuery();
                    detail.con.Close();
                    InsertTax(dt, orderid);
                    if (detail.con.State == ConnectionState.Open)
                        detail.con.Close();
                    MySqlTransaction Trsn = null;
                    SetInventorySummary(orderid, Stores.SelectedStoreid, detail.con, Trsn);
                    return true;
                }
            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
                return false;
            }
        }


        public static void InsertTax(DataTable dt, int orderid)
        {
            try
            {
                StringBuilder query = new StringBuilder();
                query.Append("Insert into order_tax (orderid,taxname,Percent,Amount) values ");
                foreach (DataRow dr in dt.Rows)
                {
                    query.Append("(" + orderid + ",'" + dr[0].ToString() + "','" + dr[1].ToString() + "','" + dr[2].ToString() + "'),");
                }
                string mainquery = query.ToString().Trim(',');
                using (MySqlCommand cmd = new MySqlCommand(mainquery, detail.con))
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

        public static DataTable getOrderSummary(string day)
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter("SELECT   o.id as OrderNo, CONCAT(c.fname,',',c.lname) AS Customer,o.orderdatetime AS DATE,o.username AS UserName,o.paidAmu AS Amount FROM order_detail o LEFT JOIN Customers c ON c.id=o.cutomerid WHERE o.orderlive=0 AND o.status=2 AND o.openday='" + day + "' AND o.storeid=" + Classes.Stores.SelectedStoreid + " ;", detail.con))
                {//SELECT order_detail.id AS OrderID, CONCAT(customers.fname,',',customers.lname) AS Customer,customers.phone1 AS Phone,order_detail.orderdatetime AS DATE,order_detail.username AS UserName,order_detail.overall_amu AS Amount FROM order_detail,customers WHERE order_detail.status=2 AND order_detail.orderlive=0 AND order_detail.cutomerid = customers.id and order_detail.openday='" + day + "' and order_detail.storeid=" + Classes.Stores.SelectedStoreid + " order by order_detail.id desc
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
        public static bool cancelorder(int orderid)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("Update order_Detail set orderlive=1 where id=" + orderid + " limit 1 ", detail.con))
                {
                    detail.con.Open();
                    cmd.ExecuteNonQuery();
                    detail.con.Close();
                    using (MySqlCommand cmd1 = new MySqlCommand("Insert into orderstat(orderid,statid,username) values (" + orderid + ",4,'" + loginmodule.username + "')", detail.con))
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
                Classes.writeme.errorname(ex);
                return false;
            }
        }

        public static void GetLastOrderID(int currentID, bool next)
        {
            try
            {
                string query = "";
                if (next)
                    query = "SELECT id FROM order_detail where id>" + currentID + " order by id  limit 1 ";
                else
                    query = "SELECT id FROM order_detail where id<" + currentID + " order by id desc limit 1";

                using (MySqlCommand cmd = new MySqlCommand(query, detail.con))
                {
                    detail.con.Open();
                    MySqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        SelectedOrderId = int.Parse(rd.GetValue(0).ToString());
                    }
                    detail.con.Close();
                }
            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
                return;
            }

        }
        private static DataTable OrderItemMappedValue(int IStoreid, int IOrderID, int IDependencyType, DataTable Dt = null)
        {
            try
            {
                Dt = new DataTable();
                MySqlCommand cmd = new MySqlCommand("SP_StoreInventoryMapped", detail.con);
                cmd.Parameters.Add("IstoreID", MySqlDbType.Int64).Value = IStoreid;
                cmd.Parameters.Add("IOrderId", MySqlDbType.Int64).Value = IOrderID;
                cmd.Parameters.Add("DependencyType", MySqlDbType.Int64).Value = IDependencyType;
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                detail.con.Open();
                da.Fill(Dt);
                detail.con.Close();

            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
            }
            return Dt;

        }
        public static void SetInventorySummary(int OrderID, int IstoreID, MySqlConnection SqlCon, MySqlTransaction Trsn)
        {
            try
            {
                DataTable StoreStock = SqlHelper.ReturnRows(@"SELECT Menu_Item_Detail.id, menu_items.id as MID,menu_items.menuname AS Item,pro_catagories.name AS 'Sub-Categories',pro_inventory_cat.catname AS Categories,Menu_Item_Detail.stock AS Qty,unit.name AS Unit 
                        FROM unit, pro_inventory_cat, menu_items, pro_catagories, Menu_Item_Detail WHERE menu_items.id = Menu_Item_Detail.menu_item_id AND menu_items.unit = unit.id AND menu_items.deleteflag= 0
                        AND menu_items.menugroup = pro_catagories.id AND pro_catagories.pro_inventory_cat_id = pro_inventory_cat.id AND Menu_Item_Detail.storeid = " + IstoreID + "");
                DataTable StoreSideSellStore = OrderItemMappedValue(IstoreID, OrderID, 0);
                List<Inven_Logs> Logs = new List<Inven_Logs>();
                List<Menu_Item_Detail> Item = new List<Menu_Item_Detail>();
                SqlCon.Open();
                Trsn = SqlCon.BeginTransaction();
                foreach (DataRow Dr in StoreSideSellStore.Rows)
                {
                    Logs.Add(new Inven_Logs
                    {
                        menu_items_Id = int.Parse(Dr["MenuID"].ToString()),
                        menu_item_name = Dr["MenuName"].ToString(),
                        Credit = Decimal.Parse(Dr["Qty"].ToString().Replace("-", "")),
                        DebitType = 0,
                        LogMode = "Sell (Order ID=" + OrderID + ")",
                        StoreID = IstoreID,
                        Username = loginmodule.username,
                        LastQty = decimal.Parse(StoreStock.Select("MID=" + Dr["MenuID"].ToString() + "")[0]["Qty"].ToString()),
                        CurrentQty = decimal.Parse(StoreStock.Select("MID=" + Dr["MenuID"].ToString() + "")[0]["Qty"].ToString()) + (Decimal.Parse(Dr["Qty"].ToString())),
                    });
                    Item.Clear();
                    Item.Add(new Menu_Item_Detail
                    {
                        stock = decimal.Parse(StoreStock.Select("MID=" + Dr["MenuID"].ToString() + "")[0]["Qty"].ToString()) + (Decimal.Parse(Dr["Qty"].ToString())),
                        Id = int.Parse(StoreStock.Select("MID=" + Dr["MenuID"].ToString() + "")[0]["Id"].ToString())
                    });
                    if (!Item.UpdateChanges(SqlCon, Trsn))
                    {
                        Trsn.Rollback();
                        break;
                    }
                }
                if (Logs.SaveChanges(SqlCon, Trsn))
                    Trsn.Commit();
                else
                    Trsn.Rollback();
            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
                Trsn.Rollback();
            }
        }

    }

}
