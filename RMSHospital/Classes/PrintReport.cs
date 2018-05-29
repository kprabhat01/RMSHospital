using System;
using System.Data;
using System.Diagnostics;
using System.IO;

namespace WindowsFormsApplication1.Classes
{
    class PrintReport
    {

        public static string tempPath = System.IO.Path.GetTempPath();
        public static string billname = "bill.txt";
        public static string filedetail = tempPath + billname;
        public static DataTable getStore(int? orderid)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = SqlHelper.ReturnRows("SELECT stores.printname,stores.phone1,stores.phone2,stores.address,order_detail.id,order_detail.orderdatetime,order_detail.username,order_detail.overall_amu,order_detail.discount,order_detail.paidamu,order_detail.Add_comment,order_detail.AmountGiven,order_detail.AmountRefund,order_detail.tableid,order_detail.AttenName FROM order_detail,stores WHERE order_detail.storeid = stores.id  AND order_detail.id=" + orderid + "");
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
            }
            return dt;
        }
        public static DataTable getOrderItems(int? orderid)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = SqlHelper.ReturnRows("SELECT menu_items.printname AS PrintName,SUM(order_items.qty) AS Qty, SUM(order_items.oamu) AS Amount FROM order_items,menu_items WHERE menu_items.id = order_items.menuid AND order_items.orderid=" + orderid + " GROUP BY menu_items.id");

            }
            catch (Exception e)
            {
                Classes.writeme.errorname(e);
            }
            return dt;
        }

        public static bool CreateFile()
        {
            try
            {

                FileStream fs = null;
                if (File.Exists(filedetail))
                {
                    File.Delete(filedetail);
                }
                if (!File.Exists(filedetail))
                {
                    using (fs = File.Create(filedetail))
                    {
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                Classes.writeme.errorname(e);
                return false;
            }
        }
        public static DataTable getTaxInfo(int? orderid)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = SqlHelper.ReturnRows("select * from order_tax where orderid=" + orderid + "");
            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
            }
            return dt;

        }
        /*public static void printbill(int orderid)
        {
            try
            {
                if (CreateFile())
                {
                    DataTable dtdetail = getStore(orderid);
                    DataTable menuitem = getOrderItems(orderid);
                    DataTable taxses = getTaxInfo(orderid);
                    using (StreamWriter sw = File.CreateText(filedetail))
                    {
                        sw.WriteLine("             " + dtdetail.Rows[0]["printname"].ToString() + "                     ");
                        sw.WriteLine("  Phone No#: " + dtdetail.Rows[0]["phone1"].ToString() + "," + dtdetail.Rows[0]["phone2"].ToString());
                        sw.WriteLine("  Order No#: " + dtdetail.Rows[0]["id"].ToString());
                        sw.WriteLine(" Order Time: " + DateTime.Parse(dtdetail.Rows[0]["orderdatetime"].ToString()).ToString("ddMMMyyyy HH:mm"));
                        sw.WriteLine("   Place By: " + dtdetail.Rows[0]["username"].ToString());
                        sw.WriteLine("   Customer: ");
                        sw.WriteLine("-----------------------------------------------------");
                        sw.WriteLine(dtdetail.Rows[0]["Add_Comment"].ToString());
                        sw.WriteLine("=====================================================");
                        sw.WriteLine("         ItemNam              Qty              Price");
                        sw.WriteLine("=====================================================");
                        foreach (DataRow r in menuitem.Rows)
                        {
                            sw.WriteLine(String.Format("{0,-28}  {1,-10}  {2,5}", r[0].ToString(), r[1].ToString().PadLeft(3), r[3].ToString().PadLeft(10)));
                            if (r[2].ToString() != "")
                            {
                                sw.WriteLine("- " + String.Format("{0,-28}", "(" + r[2].ToString() + ")"));
                            }
                        }
                        sw.WriteLine("\n\n");
                        sw.WriteLine("=====================================================");
                        foreach (DataRow taxRow in taxses.Rows)
                        {
                            sw.WriteLine(String.Format("{0,-15}  {1,-23}  {2,10}", "", taxRow["taxname"].ToString(), taxRow["Amount"].ToString().PadLeft(10)));
                        }
                        sw.WriteLine("=====================================================");
                        sw.WriteLine(String.Format("{0,-15}  {1,-23}  {2,10}", "", "Total Amount", dtdetail.Rows[0]["overall_amu"].ToString().PadLeft(10)));
                        sw.WriteLine(String.Format("{0,-15}  {1,-23}  {2,10}", "", "Discount", dtdetail.Rows[0]["discount"].ToString().PadLeft(10)));
                        sw.WriteLine("=====================================================");
                        sw.WriteLine(String.Format("{0,-15}  {1,-23}  {2,10}", "", "Paid Amount", dtdetail.Rows[0]["PaidAmu"].ToString().PadLeft(10)));
                        sw.WriteLine("=====================================================");
                        sw.WriteLine(String.Format("{0,-15}  {1,-23}  {2,10}", "", "Recived Amount", dtdetail.Rows[0]["AmountGiven"].ToString().PadLeft(10)));
                        sw.WriteLine(String.Format("{0,-15}  {1,-23}  {2,10}", "", "Refund Amount", dtdetail.Rows[0]["AmountRefund"].ToString().PadLeft(10)));
                        sw.WriteLine("=====================================================");
                        sw.WriteLine("******************Thank You!!************************");
                        sw.Close();
                    }

                }
            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
                messagemode.messageget(false, ex.Message);
            }
        }*/

        // For Small Papers
        public static void printbill(int orderid)
        {
            try
            {
                if (CreateFile())
                {
                    DataTable dtdetail = getStore(orderid);
                    DataTable menuitem = getOrderItems(orderid);
                    DataTable taxses = getTaxInfo(orderid);
                    using (StreamWriter sw = File.CreateText(filedetail))
                    {
                        sw.WriteLine("      " + dtdetail.Rows[0]["printname"].ToString());
                        //sw.WriteLine("  Phone No#: " + dtdetail.Rows[0]["phone1"].ToString() + "," + dtdetail.Rows[0]["phone2"].ToString());
                        //sw.WriteLine("  Order No#: " + dtdetail.Rows[0]["id"].ToString());
                        sw.WriteLine(DateTime.Parse(dtdetail.Rows[0]["orderdatetime"].ToString()).ToString("dd MMM yyyy HH:mm"));
                        //sw.WriteLine("   Place By: " + dtdetail.Rows[0]["username"].ToString());
                        sw.WriteLine("Table No:" + dtdetail.Rows[0]["tableid"].ToString());
                        sw.WriteLine("Attendent:" + dtdetail.Rows[0]["AttenName"].ToString());
                        sw.WriteLine("Customer:");
                        if (dtdetail.Rows[0]["Add_Comment"].ToString().Length >= 1)
                        {
                            sw.WriteLine(dtdetail.Rows[0]["Add_Comment"].ToString());
                        }
                        sw.WriteLine("-------------------------");
                        sw.WriteLine("Qty ItemName       Amount");
                        sw.WriteLine("-------------------------");
                        foreach (DataRow r in menuitem.Rows)
                        {
                            sw.WriteLine(String.Format("{0,0}  {1,1}", r[1].ToString(), r[0].ToString().PadLeft(2)));
                            sw.WriteLine(String.Format("{0,0}", r[2].ToString().PadLeft(25)));
                            if (r[2].ToString() != "")
                            {
                                //sw.WriteLine("- " + String.Format("{0,0}", "(" + r[2].ToString().PadRight(0) + ")"));
                            }
                        }
                        //sw.WriteLine("-------------------------");
                        foreach (DataRow taxRow in taxses.Rows)
                        {
                            sw.WriteLine(String.Format("{0,0}", taxRow["taxname"].ToString()));
                            sw.WriteLine(String.Format("{0,0}", taxRow["Amount"].ToString().PadLeft(25)));
                        }
                        sw.WriteLine("-------------------------");
                        // sw.WriteLine(String.Format("{0,0}", "Total Amount"));
                        // sw.WriteLine(String.Format("{0,0}", dtdetail.Rows[0]["overall_amu"].ToString().PadLeft(25)));
                        // sw.WriteLine(String.Format("{0,0}", "Discount"));
                        //sw.WriteLine(String.Format("{0,0}", dtdetail.Rows[0]["discount"].ToString().PadLeft(25)));
                        //sw.WriteLine("===========================");
                        sw.WriteLine(String.Format("{0,0}", "Total Amount"));
                        sw.WriteLine(String.Format("{0,0}", dtdetail.Rows[0]["PaidAmu"].ToString().PadLeft(25)));
                        //sw.WriteLine("===========================");
                        //sw.WriteLine(String.Format("{0,0}", "Recived Amount"));
                        //sw.WriteLine(String.Format("{0,0}", dtdetail.Rows[0]["AmountGiven"].ToString().PadLeft(25)));
                        //sw.WriteLine(String.Format("{0,0}", "Refund Amount"));
                        //sw.WriteLine(String.Format("{0,0}", dtdetail.Rows[0]["AmountRefund"].ToString().PadLeft(25)));
                        //sw.WriteLine("============================");
                        sw.WriteLine(String.Format("{0,0}", "*******Thank You !!*******"));
                        sw.Close();
                    }
                }


            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
                //messagemode.messageget(false, ex.Message);
            }
        }


        public static bool printfile(string filename)
        {
            try
            {
                ProcessStartInfo info = new ProcessStartInfo(filename);
                info.Verb = "Print";
                info.CreateNoWindow = true;
                info.WindowStyle = ProcessWindowStyle.Hidden;
                Process.Start(info);


                //  Document doc = new Document();



                return true;
            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
                messagemode.messageget(false, ex.Message);
                return false;
            }
        }
        public static void killprocess(string processname)
        {
            try
            {

            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
            }
        }
    }
}
