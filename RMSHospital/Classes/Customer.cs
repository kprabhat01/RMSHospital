using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace WindowsFormsApplication1.Classes
{
    class Customer
    {
        public static int customerid;
        public static DataTable CustomerData;
        public static int selectid;
        public static int selectedcustid;
        public static string selectedCustomerName;

        public static void customerinfo(string fname, string lname, string phone1, string phone2, string add1, string add2, string add3, string comment)
        {
            try
            {
                string query;
                if (customerid == 0)
                {
                    query = "Insert into customers(fname,lname,phone1,phone2,addressline1,addressline2,addressline3,comment) values(?fname,?lname,'" + phone1 + "','" + phone2 + "',?add1,?add2,?add3,?comment)";
                }
                else
                {
                    query = "update customers set fname=?fname,lname=?lname,phone1='" + phone1 + "',phone2='" + phone2 + "',addressline1=?add1, addressline2=?add2, addressline3=?add3,comment=?comment where id=" + customerid + "";
                }
                MySqlCommand cmd = new MySqlCommand(query, detail.con);
                cmd.Parameters.Add("fname", MySqlDbType.VarChar).Value = fname;
                cmd.Parameters.Add("lname", MySqlDbType.VarChar).Value = lname;
                cmd.Parameters.Add("add1", MySqlDbType.VarChar).Value = add1;
                cmd.Parameters.Add("add2", MySqlDbType.VarChar).Value = add2;
                cmd.Parameters.Add("add3", MySqlDbType.VarChar).Value = add3;
                cmd.Parameters.Add("comment", MySqlDbType.VarChar).Value = comment;
                detail.con.Open();
                cmd.ExecuteNonQuery();
                detail.con.Close();
            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
                return;
            }
        }

        public static void getCustomerdetail()
        {
            try
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter("select id, concat(fname,' ',lname) as Name,phone1 as 'Phone',phone2 as 'Phone2',concat(addressline1,',',addressline2,',',addressline3) as Address from customers where deleteflag=0 order by name", detail.con))
                {
                    CustomerData = new DataTable();
                    detail.con.Open();
                    da.Fill(CustomerData);
                    detail.con.Close();
                }
            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
            }

        }
        public static DataTable customerprofile(int customerid)
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter("select * from customers where id=" + customerid + "", detail.con))
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
        public static bool AccountClear(int customerid)
        {
            try
            {

                using (MySqlDataAdapter da = new MySqlDataAdapter("SELECT SUM(creditAmu)-SUM(paidAmu) AS CustomerSum FROM customers_credit where custid=" + customerid + "", detail.con))
                {
                    DataTable dt = new DataTable();
                    detail.con.Open();
                    da.Fill(dt);
                    detail.con.Close();
                    string amount = dt.Rows[0][0].ToString();
                    if (amount.Equals("0.00") || amount.Equals("") || amount.Equals("0"))
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
        public static void DelCustomer(int custoerid)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("update customers set deleteflag=1 where id=" + custoerid + "", detail.con))
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

    }
}
