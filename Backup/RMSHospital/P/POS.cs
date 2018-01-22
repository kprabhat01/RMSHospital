using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1.P
{
    public partial class POS : Form
    {
        public POS()
        {
            InitializeComponent();
        }

        string unitqty;
        DataTable menuitems;
        // datatable select menu
        int menuid;
        string menuname;
        string qty;
        string amuprice;
        StringBuilder query;

        //sum of value inside
        decimal amusum, taxsum, tsum, osum;


        //

        private decimal gettotalamu(decimal amu, decimal qty)
        {
            decimal tamu = 0;
            decimal value = 0;
            try
            {

                tamu = amu * qty;
                value = decimal.Parse(tamu.ToString());

            }
            catch (Exception ex)
            {
                Classes.messagemode.messageget(false, "Error while calculating");

            }
            return value;


        }
        private void getTable()
        {
            try
            {
                menuitems = new DataTable(); // New data table.
                menuitems.Columns.Add("Menuid", typeof(int)); // Add five columns.
                menuitems.Columns.Add("Menuname", typeof(string));
                menuitems.Columns.Add("Menucode", typeof(string));
                menuitems.Columns.Add("Qty", typeof(int));
                menuitems.Columns.Add("amu", typeof(decimal));
                menuitems.Columns.Add("tax", typeof(decimal));
                menuitems.Columns.Add("SmuAmu", typeof(decimal));
                menuitems.Columns.Add("T-Amu", typeof(decimal));
                menuitems.Columns.Add("Comment", typeof(string));
                menuitems.Columns.Add("tableno", typeof(string));
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
            }
        }

        private void getQty(string num)
        {
            if (num != string.Empty)
                unitqty += num;
            // MessageBox.Show(unitqty);
        }
        private void clearqty()
        {
            unitqty = "";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            getQty("4");
        }


        private void getCategory()
        {
            try
            {

                DataTable dt = Classes.MenuMaster.menugroup;
                int horizotal = 0;
                int vertical = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    Button menugroup = new Button();
                    menugroup.Text = dr["name"].ToString();
                    menugroup.Tag = dr[0].ToString();
                    menugroup.Location = new Point(horizotal, vertical);
                    menugroup.Size = new Size(100, 75);
                    menugroup.BackColor = ColorTranslator.FromHtml("#003366");
                    menugroup.ForeColor = ColorTranslator.FromHtml("#ffffff");
                    menugroup.Click += new EventHandler(menugroup_Click);
                    vertical = vertical + 72;
                    horizotal = 0;
                    panel5.Controls.Add(menugroup);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Classes.writeme.errorname(ex);
                return;

            }

        }
        private void getSubCatagories(int mainid)
        {
            try
            {
                if (Classes.POS.storeid >= 1)
                {
                    MenuItem.Controls.Clear();
                    int horizotal = 0;
                    int vertical = 0;
                    int terminate = 0;
                    DataTable dt = Classes.MenuMaster.menulist;
                    DataRow[] dr = dt.Select("menugroup=" + mainid + " and storeid=" + Classes.POS.storeid + "");
                    foreach (DataRow menu in dr)
                    {
                        Button bt = new Button();
                        //bt = new Button();
                        bt.Size = new Size(144, 110);
                        bt.Location = new Point(horizotal, vertical);
                        int argb = Int32.Parse(menu["colorcode"].ToString(), NumberStyles.HexNumber);
                        Color clr = Color.FromArgb(argb);
                        bt.BackColor = clr;
                        bt.Font = new Font(bt.Font, FontStyle.Bold);
                        bt.Text = menu[1].ToString();
                        bt.Tag = menu[0].ToString();


                        terminate++;
                        if (terminate == 5)
                        {
                            vertical = vertical + 110;
                            horizotal = 0;
                            terminate = 0;
                        }
                        else
                        {
                            horizotal = horizotal + 144;
                        }

                        bt.Click += new EventHandler(bt_subclick);
                        MenuItem.Controls.Add(bt);

                    }
                }
                else
                {
                    Classes.messagemode.messageget(false, "Please select store and then proceed.");
                }
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                Classes.messagemode.messageget(false, "Error while loading Menu");
                return;
            }

        }
        private void getSumOrder()
        {
            try
            {
                decimal total = 0;
                if (tempmenu.Rows.Count >= 1)
                {
                    foreach (DataGridViewRow row in tempmenu.Rows)
                    {
                        if (!row.IsNewRow && row.Cells["T-Amu"].Value != null)
                        {
                            decimal val = decimal.Parse(row.Cells["T-Amu"].Value.ToString());
                            total += val;
                        }
                    }
                    amu.Text = total.ToString("N2");
                }
                else
                {
                    amu.Text = "0.00";
                }
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                Classes.messagemode.messageget(false, "Error while calculating amout.");
            }
        }
        protected void GridStyle()
        {
            try
            {
                tempmenu.DataSource = menuitems;
                DataGridViewColumn column0 = tempmenu.Columns[0];
                column0.Visible = false;
                DataGridViewColumn column1 = tempmenu.Columns[1];
                column1.Visible = false;
                DataGridViewColumn column2 = tempmenu.Columns[2];
                column2.Width = 120;
                DataGridViewColumn column3 = tempmenu.Columns[3];
                column3.Width = 40;
                DataGridViewColumn column4 = tempmenu.Columns[4];
                column4.Visible = false;
                DataGridViewColumn column5 = tempmenu.Columns[5];
                column5.Visible = false;
                DataGridViewColumn column6 = tempmenu.Columns[6];
                column6.Visible = false;
                DataGridViewColumn column7 = tempmenu.Columns[7];
                column7.Width = 80;
                DataGridViewColumn column8 = tempmenu.Columns[8];
                column8.Visible = false;



                column7.DefaultCellStyle.BackColor = Color.Green;
                column7.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                column7.DefaultCellStyle.ForeColor = Color.White;

                tempmenu.AllowUserToAddRows = false;
                tempmenu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                tempmenu.CellBorderStyle = DataGridViewCellBorderStyle.None;
                tempmenu.AllowUserToAddRows = false;
                foreach (DataGridViewColumn column in tempmenu.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                // Setting  for row indication
                foreach (DataGridViewRow drol in tempmenu.Rows)
                {
                    if (drol.Cells[8].Value.ToString().Length >= 1)
                    {
                        drol.Cells[2].Style.BackColor = Color.Wheat;
                    }
                }

                //


                getSumOrder();
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                return;
            }
        }
        protected void bt_subclick(object sender, EventArgs e)
        {
            try
            {
                if (Classes.Tables.STableId >= 1)
                {
                    Button bt = (Button)sender;
                    //MessageBox.Show(bt.Tag.ToString());
                    DataTable dt = Classes.MenuMaster.menulist;
                    DataRow[] dr = dt.Select("id=" + int.Parse(bt.Tag.ToString()) + "");
                    if (unitqty != string.Empty)
                    {
                        foreach (DataRow drmenu in dr)
                        {
                            menuitems.Rows.Add(int.Parse(drmenu[0].ToString()), drmenu[1].ToString(), drmenu[2].ToString(), int.Parse(unitqty), decimal.Parse(drmenu[9].ToString()), decimal.Parse(drmenu[10].ToString()), decimal.Parse(drmenu[12].ToString()), gettotalamu(decimal.Parse(drmenu[12].ToString()), decimal.Parse(unitqty)), "",Classes.Tables.STableId);
                        }
                        GridStyle();
                        unitqty = "";
                    }
                    else
                    {
                        Classes.messagemode.messageget(false, "Please select quantity.");
                        return;

                    }
                }
                else
                {
                    Classes.messagemode.messageget(false, "Please select the table detail.");
                    return;
                }
                //table.Rows.Add(15, "Abilify", "Jacob", DateTime.Now); 

            }
            catch (Exception ex)
            {
                Classes.messagemode.messageget(false, "Catagories is not in proper format" + ex.Message);
                return;
            }
        }
        protected void menugroup_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            getSubCatagories(int.Parse(bt.Tag.ToString()));
        }
        private void POS_Load(object sender, EventArgs e)
        {
            getCategory();
            getTable();
            Classes.POS.storeid = 0;
            Classes.POS.storename = "";
            tables.Text = Classes.Tables.STableName;
        }

        private void but1_Click(object sender, EventArgs e)
        {
            getQty("1");
        }

        private void but2_Click(object sender, EventArgs e)
        {
            getQty("2");
        }

        private void but3_Click(object sender, EventArgs e)
        {
            getQty("3");
        }

        private void but5_Click(object sender, EventArgs e)
        {
            getQty("5");
        }

        private void but6_Click(object sender, EventArgs e)
        {
            getQty("6");
        }

        private void but7_Click(object sender, EventArgs e)
        {
            getQty("7");
        }

        private void but8_Click(object sender, EventArgs e)
        {
            getQty("8");
        }

        private void but9_Click(object sender, EventArgs e)
        {
            getQty("9");
        }

        private void but0_Click(object sender, EventArgs e)
        {
            getQty("0");
        }

        private void Clr_Click(object sender, EventArgs e)
        {
            clearqty();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StoreName store;
            if (tempmenu.RowCount >= 1)
            {

                if (Classes.messagemode.confirm("Do you confirm to change store ? It can cause you loss of order that you have pumched"))
                {
                    store = new StoreName();
                    store.ShowDialog();
                    storename.Text = Classes.POS.storename;
                    menuitems.Rows.Clear();
                    
                }

            }
            else
            {
                store = new StoreName();
                store.ShowDialog();
                storename.Text = Classes.POS.storename;
            }
            getOrderSummry();
            button2.Enabled = false;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                menuid = int.Parse(tempmenu.Rows[tempmenu.CurrentRow.Index].Cells["Menuid"].Value.ToString());
                menuname = tempmenu.Rows[tempmenu.CurrentRow.Index].Cells["Menuname"].Value.ToString();
                qty = tempmenu.Rows[tempmenu.CurrentRow.Index].Cells["Qty"].Value.ToString();
                amuprice = tempmenu.Rows[tempmenu.CurrentRow.Index].Cells["T-Amu"].Value.ToString();
                foreach (DataRow dr in menuitems.Rows)
                {
                    if (dr["Menuid"].ToString() == menuid.ToString() && dr["Menuname"].ToString() == menuname && dr["Qty"].ToString() == qty && dr["T-Amu"].ToString() == amuprice)
                    {
                        dr.Delete();
                        break;
                    }
                }
                GridStyle();

            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                Classes.messagemode.messageget(false, "Please select the row and then proceed.");
                return;
            }
        }

        private void Comment_Click(object sender, EventArgs e)
        {
            try
            {
                menuid = int.Parse(tempmenu.Rows[tempmenu.CurrentRow.Index].Cells["Menuid"].Value.ToString());
                menuname = tempmenu.Rows[tempmenu.CurrentRow.Index].Cells["Menuname"].Value.ToString();
                qty = tempmenu.Rows[tempmenu.CurrentRow.Index].Cells["Qty"].Value.ToString();
                amuprice = tempmenu.Rows[tempmenu.CurrentRow.Index].Cells["T-Amu"].Value.ToString();
                Classes.POS.comment = tempmenu.Rows[tempmenu.CurrentRow.Index].Cells["Comment"].Value.ToString();

                Comment cmt = new Comment();
                cmt.ShowDialog();
                foreach (DataRow dr in menuitems.Rows)
                {
                    if (dr["Menuid"].ToString() == menuid.ToString() && dr["Menuname"].ToString() == menuname && dr["Qty"].ToString() == qty && dr["T-Amu"].ToString() == amuprice)
                    {
                        dr["Comment"] = Classes.POS.comment;
                        break;
                    }
                }
                GridStyle();

            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                Classes.messagemode.messageget(false, "Please select the row and then proceed.");
                return;
            }
        }

        private void sumamu()
        {


        }

        private int insertinformation()
        {
            int orderid = 0;
            try
            {
                if (tempmenu.Rows.Count >= 1)
                {
                    try
                    {
                        osum = 0;
                        amusum = 0;
                        taxsum = 0;
                        tsum = 0;

                        foreach (DataGridViewRow row in tempmenu.Rows)
                        {
                            if (!row.IsNewRow && row.Cells["T-Amu"].Value != null)
                            {
                                osum += decimal.Parse(row.Cells["T-Amu"].Value.ToString());
                                amusum += decimal.Parse(row.Cells["amu"].Value.ToString());
                                taxsum += decimal.Parse(row.Cells["tax"].Value.ToString());
                                tsum += decimal.Parse(row.Cells["SmuAmu"].Value.ToString());
                            }
                        }

                        string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        MySqlCommand cmd = new MySqlCommand("Insert into order_detail(storeid,orderdatetime,username,uid,amount,tax,tamu,status,overall_amu,tableid) values(" + Classes.POS.storeid + ",'" + date + "','" + Classes.loginmodule.username + "','" + Classes.loginmodule.uid + "','" + amusum + "','" + taxsum + "','" + tsum + "',2,'" + osum + "',"+Classes.Tables.STableId+")", detail.con);
                        detail.con.Open();
                        cmd.ExecuteNonQuery();
                        detail.con.Close();
                        // serching order number
                        MySqlDataAdapter da = new MySqlDataAdapter("select id from order_detail where orderdatetime='" + date + "' and uid=" + Classes.loginmodule.uid + "", detail.con);
                        DataTable ckdt = new DataTable();
                        detail.con.Open();
                        da.Fill(ckdt);
                        detail.con.Close();
                        if (ckdt.Rows.Count >= 1)
                        {
                            orderid = int.Parse(ckdt.Rows[0][0].ToString());
                        }
                        //

                    }
                    catch (Exception ex)
                    {
                        Classes.writeme.errorname(ex);
                        Classes.messagemode.messageget(false, "Error while calculating amout.");
                    }

                }


            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                Classes.messagemode.messageget(false, "Error while placing order");

            }

            return orderid;

        }
        private bool insertmenu(int orderid)
        {
            try
            {
                query = new StringBuilder();
                query.Append("Insert into order_items (orderid,menuid,amount,tax,tamu,oamu,comment,qty) values");
                foreach (DataGridViewRow row in tempmenu.Rows)
                {
                    if (!row.IsNewRow && row.Cells["T-Amu"].Value != null)
                    {
                        //osum += decimal.Parse(row.Cells["T-Amu"].Value.ToString());
                        query.Append("('" + orderid + "','" + row.Cells["Menuid"].Value.ToString() + "','" + row.Cells["amu"].Value.ToString() + "','" + row.Cells["tax"].Value.ToString() + "','" + row.Cells["SmuAmu"].Value.ToString() + "','" + row.Cells["T-Amu"].Value.ToString() + "','" + row.Cells["Comment"].Value.ToString() + "','" + row.Cells["Qty"].Value.ToString() + "'),");
                    }
                }
                string updatedone = query.ToString().Remove(query.ToString().Length - 1);
                MySqlCommand cmd = new MySqlCommand(updatedone, detail.con);
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
        private void getOrderSummry()
        {
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT id as 'OrderId',orderdatetime as 'DateTime',username as UserName,overall_amu  as 'T-Amu' FROM order_detail WHERE storeid="+Classes.POS.storeid+" AND STATUS=2 order by id desc",detail.con);
                DataTable dt = new DataTable();
                detail.con.Open();
                da.Fill(dt);
                detail.con.Close();
                LiveOrder.DataSource = dt;
                DataGridViewColumn column0 = LiveOrder.Columns[0];
                column0.Width = 30;
                DataGridViewColumn column1 = LiveOrder.Columns[1];
                column1.Width = 85;
                DataGridViewColumn column2 = LiveOrder.Columns[2];
                column2.Width = 55;
                DataGridViewColumn column3 = LiveOrder.Columns[3];
                column3.Width = 70;
                column3.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                column3.DefaultCellStyle.ForeColor = Color.White;
                column3.DefaultCellStyle.BackColor = Color.Green;
                LiveOrder.AllowUserToAddRows = false;
                LiveOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                LiveOrder.CellBorderStyle = DataGridViewCellBorderStyle.None;
                LiveOrder.AllowUserToAddRows = false;
                foreach (DataGridViewColumn column in LiveOrder.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                Classes.messagemode.messageget(false,"Error while getting order summary OR Store not selected.");
            }
        }

        private void deleterowCondtional(int tableid)
        { 
            DataTable dt= menuitems;
            DataRow[] checkedrow = dt.Select("tableno=" + tableid + "");
            foreach (DataRow dr in checkedrow)
            { 
               // if(int.Parse(dr["tableno"].ToString())==tableid)
               // {
                    dr.Delete();
               // }
            }
        }

        private void placeorder_Click(object sender, EventArgs e)
        {
            try
            {
                int orderid;
                if (Classes.messagemode.confirm("Are you sure to place the order?"))
                {
                    if (tempmenu.Rows.Count >= 1 && Classes.POS.storeid >= 1)
                    {
                        orderid = insertinformation();
                        if (insertmenu(orderid))
                        {
                            Classes.messagemode.messageget(true, "Order Inserted.");
                            deleterowCondtional(Classes.Tables.STableId);                            
                            getOrderSummry();
                            
                            Classes.PrintReport.printbill(orderid);
                            if (Classes.PrintReport.printfile(Classes.PrintReport.filedetail))
                            {
                                // do nothing
                                
                            }
                            else {
                                Classes.messagemode.messageget(false, "Error While printing bill.");
                            }                       

                        }
                        else
                        {
                            Classes.messagemode.messageget(false, "Error while placing order.");
                        }
                    }
                    else
                    {
                        Classes.messagemode.messageget(false, "Store OR order not selected.");

                    }
                }
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                return;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (Classes.POS.storeid >= 1)
            {
                getOrderSummry();
            }
        }
        private void close_Click(object sender, EventArgs e)
        {
            int orderid;
            try
            {
                if (Classes.messagemode.confirm("Are you sure to close the order ?"))
                {
                    orderid = int.Parse(LiveOrder.Rows[LiveOrder.CurrentRow.Index].Cells[0].Value.ToString());
                    Classes.POS.ChangeOrderstat(orderid, 3);
                    Classes.POS.InsertOrderStat(3, orderid);
                    getOrderSummry();
                }
            }
            catch (Exception ex)
            {
                Classes.messagemode.messageget(false, ex.Message);
                Classes.writeme.errorname(ex);
                return;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //printbill(int orderid)
            int orid;
            try
            {
                orid = int.Parse(LiveOrder.Rows[LiveOrder.CurrentRow.Index].Cells[0].Value.ToString());
                Classes.PrintReport.printbill(orid);
                if (Classes.PrintReport.printfile(Classes.PrintReport.filedetail))
                { 
                    
                }
            }
            catch (Exception ex)
            {
                Classes.messagemode.messageget(false, "Please select the order");
                Classes.writeme.errorname(ex);
                return;
            }
        }
        private void cancel_Click(object sender, EventArgs e)
        {
            int orderid;
            try
            {
                if (Classes.messagemode.confirm("Are you sure to cancel the selected order?"))
                {
                    orderid = int.Parse(LiveOrder.Rows[LiveOrder.CurrentRow.Index].Cells[0].Value.ToString());
                    Classes.POS.ChangeOrderstat(orderid, 4);
                    Classes.POS.InsertOrderStat(4, orderid);
                    getOrderSummry();
                }
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                Classes.messagemode.messageget(false, "Please select the order.");
            }
        }
        private void tables_Click(object sender, EventArgs e)
        {
            Tables t = new Tables();
            t.ShowDialog();
            tables.Text = Classes.Tables.STableName;
            DataTable dt = menuitems;
            menuitems.DefaultView.RowFilter = "tableno=" + Classes.Tables.STableId + "";
            dt = menuitems.DefaultView.Table;
            GridStyle();
        }
    }
}
