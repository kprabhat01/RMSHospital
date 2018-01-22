using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;


namespace WindowsFormsApplication1.Classes
{
    class SnapShot
    {
        public static DataTable getDetail;
        public static DataTable orderdetail;
        public static DataTable sumExpence;
        public static DataTable CrditData;
        public static void getOrderDetail(string frmDate, string toDate)
        {
            try
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter("SELECT CASE WHEN PayMode =1 THEN SUM(PaidAmu) END AS CashPayment,CASE WHEN PayMode =2 THEN SUM(PaidAmu) END AS CardPayment, SUM(paidamu) AS Total,sum(credit_amount) as Credit FROM order_detail WHERE orderlive=0 AND DATE(openday) BETWEEN '" + frmDate + "' AND '" + toDate + "'", detail.con))
                {
                    orderdetail = new DataTable();
                    detail.con.Open();
                    da.Fill(orderdetail);
                    detail.con.Close();
                }
                using (MySqlDataAdapter da = new MySqlDataAdapter("select sum(amount) from expenses where date(DayDate) between '" + frmDate + "' and '" + toDate + "'", detail.con))
                {
                    sumExpence = new DataTable();
                    detail.con.Open();
                    da.Fill(sumExpence);
                    detail.con.Close();
                }
                using (MySqlDataAdapter da = new MySqlDataAdapter("select sum(paidamu) from customers_credit where date(EventDate) between '" + frmDate + "' and '" + toDate + "'", detail.con))
                {
                    CrditData = new DataTable();
                    detail.con.Open();
                    da.Fill(CrditData);
                    detail.con.Close();
                }
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
            }
        }
        public static void getDataTable()
        {
            try
            {

                getDetail = new DataTable();
                getDetail.Columns.Add("CashPayment");
                getDetail.Columns.Add("CardPayment");
                getDetail.Columns.Add("TotalSale");
                getDetail.Columns.Add("Expences");
                getDetail.Columns.Add("Credit");
                getDetail.Columns.Add("Deposit");
                getDetail.Columns.Add("Total Cash", typeof(string));

                decimal expence, total, balance, credit, diposit;
                diposit = decimal.Parse((CrditData.Rows[0][0].ToString().Length == 0) ? "0" : CrditData.Rows[0][0].ToString());
                credit = decimal.Parse((orderdetail.Rows[0][3].ToString().Length == 0) ? "0" : orderdetail.Rows[0][3].ToString());
                if (sumExpence.Rows[0][0].ToString().Length <= 0)
                    expence = 0;
                else
                    expence = decimal.Parse(sumExpence.Rows[0][0].ToString());
                if (orderdetail.Rows[0][2].ToString().Length <= 0)
                    total = 0;
                else
                    total = decimal.Parse(orderdetail.Rows[0][2].ToString());

                balance = (total - (expence + credit)) + diposit;
                balance = Math.Round(balance);

                getDetail.Rows.Add(orderdetail.Rows[0][0].ToString(), orderdetail.Rows[0][1].ToString(), orderdetail.Rows[0][2].ToString(), sumExpence.Rows[0][0].ToString(), credit.ToString(),diposit.ToString(),balance.ToString());

            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
            }
        }


    }
}
