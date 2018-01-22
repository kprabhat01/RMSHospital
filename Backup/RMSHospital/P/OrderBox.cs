using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1.P
{
    public partial class OrderBox : Form
    {
        public OrderBox()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
            this.KeyPreview = true;
        }
        DataTable StoreMenuItems;
        string SelectedMenuName, SelectedMenuId, printname, SelectedTable;
        float price;
        decimal textTotal, texttaxamu, textoverallAmu;
        DataTable TaskInfo = new DataTable();

        // functions Instruction this will make function live and working condition
        //after placing order then close the informtion which is slected

        void RemoveSelected()
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("Delete from order_temp where tableid='" + SelectedTable + "'", detail.con))
                {
                    detail.con.Open();
                    cmd.ExecuteNonQuery();
                    detail.con.Close();
                    TblNo.Items.Remove(SelectedTable);
                    getInsertedTableInfo(SelectedTable);
                    TblNo.Text = "";
                    TblNo.Focus();

                }

            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                return;
            }

        }
        //get order mode from DB
        void getOrderMode()
        {
            try
            {
                OrderMode.DataSource = Classes.OrderMode.Orders;
                OrderMode.DisplayMember = "modename";
                OrderMode.ValueMember = "id";

            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
            }
        }



        // getting table inserted already 
        void getTables()
        {
            try
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter("SELECT DISTINCT(tableid) FROM order_temp ORDER BY tableid", detail.con))
                {
                    DataTable dt = new DataTable();
                    detail.con.Open();
                    da.Fill(dt);
                    detail.con.Close();
                    foreach (DataRow dr in dt.Rows)
                    {
                        TblNo.Items.Add(dr[0].ToString());
                    }

                }
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                return;
            }
        }
        // getting Totalsubjected amount

        void getTotalAmutexted(decimal amu)
        {
            try
            {
                foreach (DataRow dr in Classes.Taxes.TaxInfo.Rows)
                {
                    decimal percentamount = decimal.Parse(dr["TaxPer"].ToString()) * amu / 100;
                    TaskInfo.Rows.Add(dr["taxname"].ToString(), dr["Taxper"].ToString(), percentamount);
                    texttaxamu = texttaxamu + percentamount;
                }
                textoverallAmu = textTotal + texttaxamu;
                taxamu.Text = texttaxamu.ToString("F2");
                totalamu.Text = textTotal.ToString("F2");
                TotalSumDisplay.Text = textoverallAmu.ToString("F2");

            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                return;
            }
        }

        // getting list of inserted data from table
        void getInsertedTableInfo(string tblno)
        {
            try
            {
                textTotal = 0;
                texttaxamu = 0;
                textoverallAmu = 0;
                using (MySqlDataAdapter da = new MySqlDataAdapter("SELECT id,itemid,itemname AS ItemName,qty AS Qty,amount as Amount,Comment,tableid AS Amount FROM order_temp WHERE tableid='" + tblno + "'", detail.con))
                {
                    DataTable dt = new DataTable();
                    detail.con.Open();
                    da.Fill(dt);
                    detail.con.Close();
                    OrderTemp.DataSource = dt;
                    OrderTemp.Columns[0].Visible = false;
                    OrderTemp.Columns[1].Visible = false;
                    OrderTemp.Columns[5].Visible = false;
                    OrderTemp.Columns[6].Visible = false;
                    OrderTemp.Columns[2].Width = 250;
                    OrderTemp.Columns[3].Width = 50;
                    OrderTemp.Columns[4].Width = 100;
                    OrderTemp.AllowUserToAddRows = false;
                    OrderTemp.Columns[4].DefaultCellStyle.BackColor = Color.Green;
                    OrderTemp.Columns[4].DefaultCellStyle.ForeColor = Color.White;
                    OrderTemp.CellBorderStyle = DataGridViewCellBorderStyle.None;
                    OrderTemp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    OrderTemp.AllowUserToResizeColumns = false;
                    OrderTemp.AllowUserToAddRows = false;
                    // getting calculation
                    foreach (DataRow dr in dt.Rows)
                    {
                        textTotal = textTotal + decimal.Parse(dr["Amount"].ToString());
                    }
                    TaskInfo.Clear();
                    getTotalAmutexted(textTotal);
                }
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                return;
            }
        }
        //Deleting order from row delete;
        void DeleteTempRow(int insertedid)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("Delete from order_temp where id=" + insertedid + " limit 1", detail.con))
                {
                    detail.con.Open();
                    cmd.ExecuteNonQuery();
                    detail.con.Close();
                    getInsertedTableInfo(SelectedTable);
                }
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                return;
            }

        }
        //Adding table to the list
        void Insert_Tabl(string tablno)
        {
            try
            {
                if (TblNo.Items.Contains(tablno) == false)
                {
                    TblNo.Items.Add(tablno);
                }
                else
                {
                    TblNo.SelectedItem = tablno;
                }
                getInsertedTableInfo(tablno);
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                Classes.messagemode.messageget(false, "Error while saving Table");

            }
        }
        void getOrdermode()
        {
            if (OrderMode.SelectedValue.ToString().Equals("2"))
                OrderMode.SelectedValue = "1";
            else if (OrderMode.SelectedValue.ToString().Equals("1"))
                OrderMode.SelectedValue = "2";
        }

        void keyCase(string value)
        {
            string data = value;
            switch (data)
            {
                case "F2":
                    TblNo.Focus();
                    break;
                case "F3":
                    ItemName.Focus();
                    break;
                case "F1":
                    OrderTemp.Focus();
                    break;
                case "F4":
                    getOrdermode();
                    TblNo.Focus();
                    break;
                case "F9":
                    button6.PerformClick();
                    break;
                case "F10":
                    disamu.Focus();
                    break;
                case "F12":
                    disamu.Focus();
                    break;
                case "*":
                    disamu.Focus();
                    break;
                default:
                    break


                        ;
            }
        }

        //=========================================================================

        // Get Menu of stores
        void getStoreMenu(int storeid)
        {
            try
            {
                StoreMenuItems = Classes.MenuMaster.menulist;
                StoreMenuItems.DefaultView.RowFilter = "storeid='" + storeid + "'";
                StoreMenuItems = StoreMenuItems.DefaultView.ToTable();
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                return;
            }
        }
        // Fetch Menu from data table.
        void getMenu(string menuname)
        {
            try
            {
                DataTable dt = StoreMenuItems;
                dt.DefaultView.RowFilter = "menuname like '%" + menuname + "%'";
                dt = StoreMenuItems.DefaultView.ToTable();
                MenuGridview.DataSource = dt;
                MenuGridview.Columns[0].Visible = false;
                MenuGridview.Columns[2].Visible = false;
                MenuGridview.Columns[3].Visible = false;
                MenuGridview.Columns[4].Visible = false;
                MenuGridview.Columns[5].Visible = false;
                MenuGridview.Columns[6].Visible = false;
                MenuGridview.Columns[7].Visible = false;
                MenuGridview.Columns[8].Visible = false;
                MenuGridview.Columns[9].Visible = false;
                MenuGridview.Columns[10].Visible = false;
                MenuGridview.Columns[11].Visible = false;
                MenuGridview.Columns[1].Width = 200;
                MenuGridview.Columns[12].Width = 60;
                MenuGridview.Columns[12].DefaultCellStyle.BackColor = Color.Green;
                MenuGridview.Columns[12].DefaultCellStyle.ForeColor = Color.White;

                MenuGridview.CellBorderStyle = DataGridViewCellBorderStyle.None;
                MenuGridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                MenuGridview.AllowUserToResizeColumns = false;
                MenuGridview.AllowUserToAddRows = false;



            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
            }
        }


        void Form_KeyDown(object sender, KeyEventArgs e)
        {
            keyCase(e.KeyCode.ToString());


        }

        private void OrderBox_Load(object sender, EventArgs e)
        {
            StoreName store = new StoreName();
            store.ShowDialog();

            if (Classes.Stores.SelectedStoreid >= 1)
            {
                getStoreMenu(Classes.Stores.SelectedStoreid);
                this.KeyDown += new KeyEventHandler(Form_KeyDown);
            }
            else
            {
                Classes.messagemode.messageget(false, "Store is not selected");
                this.Close();
            }
            getTables();
            getOrderMode();
            TblNo.Focus();
            //Taxinformtion get the total Name ,,
            TaskInfo.Columns.Add("TaxName", typeof(string));
            TaskInfo.Columns.Add("percetage", typeof(string));
            TaskInfo.Columns.Add("Amount", typeof(decimal));

        }

        private void TblNo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TblNo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TblNo_KeyDown(object sender, KeyEventArgs e)
        {
            // keyCase(e.KeyCode.ToString());
            if (e.KeyCode == Keys.Enter)
            {
                if (TblNo.Text.Length >= 1)
                {
                    SelectedTable = TblNo.Text;
                    Insert_Tabl(SelectedTable);
                    ItemName.Text = "";
                    ItemName.Focus();
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                TblNo.DroppedDown = true;
            }

        }

        private void OrderBox_KeyDown(object sender, KeyEventArgs e)
        {
            // keyCase(e.KeyCode.ToString());
            if (e.KeyCode == Keys.F2)
            {
                TblNo.Focus();
            }
        }

        private void ItemName_KeyDown(object sender, KeyEventArgs e)
        {
            // keyCase(e.KeyCode.ToString());
            if (e.KeyCode == Keys.Down)
            {
                MenuGridview.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    SelectedMenuName = MenuGridview.SelectedRows[0].Cells[1].Value.ToString();
                    SelectedMenuId = MenuGridview.SelectedRows[0].Cells[0].Value.ToString();
                    printname = MenuGridview.SelectedRows[0].Cells[2].Value.ToString();
                    price = float.Parse(MenuGridview.SelectedRows[0].Cells[12].Value.ToString());
                    ItemName.Text = SelectedMenuName;
                    Qtn.Clear();
                    Qtn.Focus();
                }
                catch (Exception ex)
                {
                    //do nothing .. 
                }
            }
        }

        private void Qtn_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Qtn_KeyDown(object sender, KeyEventArgs e)
        {
            //keyCase(e.KeyCode.ToString());
            if (e.KeyCode == Keys.Enter)
            {
                InsertItem();
            }
        }

        private void OrderTemp_KeyDown(object sender, KeyEventArgs e)
        {
            //keyCase(e.KeyCode.ToString());
            if (e.KeyCode == Keys.Escape)
            {
                try
                {
                    DeleteTempRow(int.Parse(OrderTemp.SelectedRows[0].Cells[0].Value.ToString()));
                }
                catch (Exception ex)
                {
                    Classes.messagemode.messageget(false, "Row is not selected to delete");
                    getInsertedTableInfo(SelectedTable);
                }
            }
        }
        private void ItemName_TextChanged(object sender, EventArgs e)
        {
            if (TblNo.Text.Length >= 1)
            {
                getMenu(ItemName.Text);
            }
        }

        private void MenuGridview_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectedMenuName = MenuGridview.SelectedRows[0].Cells[1].Value.ToString();
                SelectedMenuId = MenuGridview.SelectedRows[0].Cells[0].Value.ToString();
                price = float.Parse(MenuGridview.SelectedRows[0].Cells[12].Value.ToString());
                printname = MenuGridview.SelectedRows[0].Cells[2].Value.ToString();
                ItemName.Text = SelectedMenuName;
                Qtn.Clear();
                Qtn.Focus();
            }
        }
        void gettempMenu()
        {
            try
            {
                //if()
                //using (MySqlDataAdapter da = new MySqlDataAdapter("select * from order_temp where "))
                //{ 
                //}
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                return;
            }
        }
        void InsertItem()
        {

            try
            {
                float.Parse(Qtn.Text);
            }
            catch (Exception ex)
            {
                Classes.messagemode.messageget(false, "Please enter Qtn in proper format.");
                return;
            }
            try
            {
                if (SelectedMenuId.Length >= 1 && SelectedTable.Length >= 1)
                {
                    float trate = float.Parse(Qtn.Text) * price;

                    using (MySqlCommand cmd = new MySqlCommand("Insert into order_temp(itemid,ItemName,qty,userid,rate,amount,comment,tableid,PrintName) values ('" + SelectedMenuId + "',?menuname,'" + Qtn.Text + "','" + Classes.loginmodule.uid + "','" + price + "','" + trate + "','','" + SelectedTable + "',?printname)", detail.con))
                    {
                        //MessageBox.Show(cmd.te)
                        cmd.Parameters.Add("?menuname", MySqlDbType.VarChar).Value = SelectedMenuName;
                        cmd.Parameters.Add("?printname", MySqlDbType.VarChar).Value = printname; detail.con.Open();
                        cmd.ExecuteNonQuery();
                        detail.con.Close();
                        getInsertedTableInfo(SelectedTable);
                        Qtn.Text = "";
                        ItemName.Text = "";
                        ItemName.Focus();
                    }

                }
                else
                {
                    ItemName.Focus();
                    Classes.messagemode.messageget(false, "Please Select the menu Item.");
                    return;
                }
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                return;
            }
        }

        private void OrderTemp_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

        }

        private void OrderMode_KeyDown(object sender, KeyEventArgs e)
        {
            //  keyCase(e.KeyCode.ToString());
            if (e.KeyCode == Keys.Down)
            {
                OrderMode.DroppedDown = true;
            }
        }
        void discoutCheck()
        {
            try
            {
                float.Parse(disamu.Text);
            }
            catch (Exception ex)
            {
                disamu.Text = "0.00";
            }
        }
        bool getCustomerAddressValue()
        {

            try
            {
                DataTable dt = Classes.ItemKeys.ItemValue;
                dt.DefaultView.RowFilter = "KeyName='EnableAddress' and value=0";
                dt = dt.DefaultView.ToTable();
                if (dt.Rows.Count >= 1)
                    return true;
                else
                    return false;

            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                return false;
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {

            discoutCheck();
            try
            {
                if (OrderTemp.Rows.Count >= 1)
                {
                    if (Classes.OpenDay.CheckOpenStat(Classes.Stores.SelectedStoreid))
                    {
                        if (Classes.messagemode.confirm("Are you sure to place the order ?"))
                        {
                            if (int.Parse(OrderMode.SelectedValue.ToString()) == 2 && richTextBox1.Text.Length == 0 && getCustomerAddressValue())
                            {
                                Classes.messagemode.messageget(false, "Please select the customer and then process");
                                return;
                            }
                            Classes.OrderMode.placedOrderAmount = decimal.Parse(TotalSumDisplay.Text);
                            Classes.OrderMode.discountAmount = decimal.Parse(disamu.Text);

                            Transaction ts = new Transaction();
                            ts.ShowDialog();
                            if (Classes.OrderMode.placeflag)
                            {
                                int orderid = Classes.OrderMode.orderPlace(Classes.Stores.SelectedStoreid, decimal.Parse(totalamu.Text), decimal.Parse(taxamu.Text), decimal.Parse(totalamu.Text), int.Parse(OrderMode.SelectedValue.ToString()), decimal.Parse(TotalSumDisplay.Text), SelectedTable, 1, 0, Classes.OrderMode.customerid, Classes.OrderMode.amount, Classes.OrderMode.refundAmount, richTextBox1.Text, Classes.OrderMode.discountAmount, Math.Round(Classes.OrderMode.PaidAmount), Math.Round(Classes.OrderMode.creditAmu));
                                if (orderid >= 1)
                                {
                                    //int orderid, string tableid, DataTable dt
                                    if (Classes.OrderMode.insertOderItems(orderid, SelectedTable, TaskInfo))
                                    {
                                        Classes.messagemode.messageget(true, "Order has been placed Successfully");
                                        Classes.PrintReport.printbill(orderid);
                                        if (printbill.Checked)
                                            Classes.PrintReport.printfile(Classes.PrintReport.filedetail);

                                        RemoveSelected();
                                        Classes.OrderMode.placeflag = false;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {

                        Classes.messagemode.messageget(false, "Day is not open");
                        return;
                    }
                }
                else
                {
                    Classes.messagemode.messageget(false, "No order found");
                    return;
                }

            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                Classes.messagemode.messageget(false, "Error while placing the order");
            }
        }

        private void OrderMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(OrderMode.SelectedValue.ToString()) == 1)
                {
                    richTextBox1.Text = "";
                    Classes.OrderMode.customerid = 0;
                    Classes.OrderMode.customerinfo = "";
                }
            }
            catch (Exception ex)
            {
                // do nothing
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (int.Parse(OrderMode.SelectedValue.ToString()) == 2)
            {
                Classes.Customer.selectid = 1;
                Cus.CustomerManagement cus = new Cus.CustomerManagement();
                cus.ShowDialog();
                richTextBox1.Text = Classes.OrderMode.customerinfo;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            A.Expenses expen = new A.Expenses();
            expen.ShowDialog();

            /*try
            {
                if (OrderTemp.Rows.Count >= 1)
                {
                    if (Classes.OpenDay.CheckOpenStat(Classes.Stores.SelectedStoreid))
                    {
                        if (Classes.messagemode.confirm("Are you sure to place the order ?"))
                        {
                            if (int.Parse(OrderMode.SelectedValue.ToString()) == 2 && richTextBox1.Text.Length == 0)
                            {
                                Classes.messagemode.messageget(false, "Please select the customer and then process");
                                return;
                            }
                            Classes.OrderMode.placedOrderAmount = decimal.Parse(TotalSumDisplay.Text);
                            //Transaction ts = new Transaction();
                            //ts.ShowDialog();
                            Classes.OrderMode.amount = 0;
                            Classes.OrderMode.refundAmount = 0;
                            Classes.Customer.selectid = 1;
                            Cus.CustomerManagement manage = new Cus.CustomerManagement();
                            manage.ShowDialog();
                            if (Classes.Customer.selectedcustid >= 1)
                            {
                                Classes.OrderMode.placeflag = true;
                            }
                            if (Classes.OrderMode.placeflag)
                            {
                                int orderid = Classes.OrderMode.orderPlace(Classes.Stores.SelectedStoreid, decimal.Parse(totalamu.Text), decimal.Parse(taxamu.Text), decimal.Parse(totalamu.Text), int.Parse(OrderMode.SelectedValue.ToString()), decimal.Parse(TotalSumDisplay.Text), SelectedTable, 4, 1, Classes.OrderMode.customerid, Classes.OrderMode.amount, Classes.OrderMode.refundAmount, richTextBox1.Text);
                                if (orderid >= 1)
                                {
                                    //int orderid, string tableid, DataTable dt
                                    if (Classes.OrderMode.insertOderItems(orderid, SelectedTable, TaskInfo))
                                    {
                                        Classes.messagemode.messageget(true, "Order has been placed Successfully");
                                        Classes.PrintReport.printbill(orderid);
                                        Classes.PrintReport.printfile(Classes.PrintReport.filedetail);
                                        RemoveSelected();
                                        Classes.OrderMode.placeflag = false;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        Classes.messagemode.messageget(false, "Day is not open");
                        return;
                    }
                }
                else
                {
                    Classes.messagemode.messageget(false, "No order found");
                    return;
                }

            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                Classes.messagemode.messageget(false, "Error while placing the order");
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*  try
              {
                  if (OrderTemp.Rows.Count >= 1)
                  {
                      if (Classes.OpenDay.CheckOpenStat(Classes.Stores.SelectedStoreid))
                      {
                          if (Classes.messagemode.confirm("Are you sure to place the order ?"))
                          {
                              if (int.Parse(OrderMode.SelectedValue.ToString()) == 2 && richTextBox1.Text.Length == 0)
                              {
                                  Classes.messagemode.messageget(false, "Please select the customer and then process");
                                  return;
                              }
                              Classes.OrderMode.placedOrderAmount = decimal.Parse(TotalSumDisplay.Text);
                              //Transaction ts = new Transaction();
                              //ts.ShowDialog();
                              Classes.OrderMode.amount = 0;
                              Classes.OrderMode.refundAmount = 0;
                              Classes.OrderMode.placeflag = true;
                              if (Classes.OrderMode.placeflag)
                              {
                                  int orderid = Classes.OrderMode.orderPlace(Classes.Stores.SelectedStoreid, decimal.Parse(totalamu.Text), decimal.Parse(taxamu.Text), decimal.Parse(totalamu.Text), int.Parse(OrderMode.SelectedValue.ToString()), decimal.Parse(TotalSumDisplay.Text), SelectedTable, 2, 0, Classes.OrderMode.customerid, Classes.OrderMode.amount, Classes.OrderMode.refundAmount, richTextBox1.Text);
                                  if (orderid >= 1)
                                  {
                                      //int orderid, string tableid, DataTable dt
                                      if (Classes.OrderMode.insertOderItems(orderid, SelectedTable, TaskInfo))
                                      {
                                          Classes.messagemode.messageget(true, "Order has been placed Successfully");
                                          Classes.PrintReport.printbill(orderid);
                                          Classes.PrintReport.printfile(Classes.PrintReport.filedetail);
                                          RemoveSelected();
                                          Classes.OrderMode.placeflag = false;
                                      }
                                  }
                              }
                          }
                      }
                      else
                      {
                          Classes.messagemode.messageget(false, "Day is not open");
                          return;
                      }
                  }
                  else
                  {
                      Classes.messagemode.messageget(false, "No order found");
                      return;
                  }

              }
              catch (Exception ex)
              {
                  Classes.writeme.errorname(ex);
                  Classes.messagemode.messageget(false, "Error while placing the order");
              }*/
        }

        private void manageOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderManagement manage = new OrderManagement();
            manage.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InsertItem();
        }
    }
}
