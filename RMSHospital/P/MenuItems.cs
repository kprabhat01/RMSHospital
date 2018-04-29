using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using WindowsFormsApplication1.Classes;
using System.Collections.Generic;

namespace WindowsFormsApplication1.P
{
    public partial class MenuItems : MetroFramework.Forms.MetroForm
    {
        public MenuItems()
        {
            InitializeComponent();
            SelectStore st = new SelectStore();
            st.ShowDialog();
            if (Stores.SelectedStoreid >= 1)
            {
                this.MaximizeBox = false;
                this.MinimizeBox = false;
                this.Text = Stores.Selectedstorename;
                colorcode.Text = "ff408080";
                // getMenugroup();

                //loading menulist for the store.
                MenuFilter();
                //gettting menu from filter
                getPatantmenu();
                // Finished product markation
                GetProductCat();
                radioButton4.Checked = true;
                chkSale.Checked = true;
                this.New.Checked = true;
            }
            else
            {
                messagemode.messageget(false, "Store is not selected.");
                this.Close();
            }
        }
        public MenuItems(int IStoreID, string IStoreName)
        {
            InitializeComponent();

            if (IStoreID >= 1)
            {
                this.MaximizeBox = false;
                this.MinimizeBox = false;
                this.Text = IStoreName;
                colorcode.Text = "ff408080";
                // getMenugroup();

                //loading menulist for the store.
                MenuFilter();
                //gettting menu from filter
                getPatantmenu();
                // Finished product markation
                GetProductCat();
                radioButton4.Checked = true;
                chkSale.Checked = true;
                this.New.Checked = true;
            }
            else
            {
                messagemode.messageget(false, "Store is not selected.");
                this.Close();
            }

        }

        int activestatus;
        string foodstat;
        float sum;
        DataTable storemenu;
        TreeNode parentNode = null;
        int selectmenuid;
        ContextMenuStrip contextMenuStrip1 = new ContextMenuStrip();
        private void getMenugroup(int CatID)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = Classes.MenuMaster.menugroup;
                dt.DefaultView.RowFilter = "pro_inventory_cat_id=" + CatID + "";
                dt = dt.DefaultView.ToTable();
                groupname.DataSource = dt;
                groupname.ValueMember = "id";
                groupname.DisplayMember = "Name";

            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                Classes.messagemode.messageget(false, "Menu Group is blank.");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            mnubut.Text = menuname.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int argb = Int32.Parse(colorcode.Text, NumberStyles.HexNumber);
                Color clr = Color.FromArgb(argb);
                mnubut.BackColor = clr;
            }
            catch (Exception ex)
            {
                Classes.messagemode.messageget(false, "Cannot select the color code.");
                colorcode.Text = "";
                return;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void getPatantmenu()
        {
            try
            {
                menulist.Nodes.Clear();
                menulist.ImageList = imageList1;

                foreach (DataRow dr in MenuMaster.MenuGropTitle.Rows)
                {
                    parentNode = menulist.Nodes.Add(dr["Catname"].ToString());
                    parentNode.ImageIndex = 0;
                    parentNode.SelectedImageIndex = 0;
                    PreChild(int.Parse(dr["id"].ToString()));
                }
                // menulist.ExpandAll();
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                Classes.messagemode.messageget(false, "Error while loading menu.");

            }
        }
        private void PreChild(int PreID)
        {
            try
            {
                DataTable dt = Classes.MenuMaster.menugroup;
                TreeNode chidnode;
                DataRow[] DrMenuSelected = dt.Select("pro_inventory_cat_id=" + PreID + "");
                foreach (DataRow dr in DrMenuSelected)
                {
                    chidnode = parentNode.Nodes.Add(dr["name"].ToString());
                    chidnode.ImageIndex = 1;
                    chidnode.SelectedImageIndex = 1;
                    chidmenu(Convert.ToInt32(dr["id"].ToString()), chidnode);

                }
            }
            catch (Exception ex) { }
        }
        private void chidmenu(int parentid, TreeNode parentNode)
        {

            string menuname;
            DataRow[] drrow = storemenu.Select("menugroup=" + parentid + " and storeid=" + Stores.SelectedStoreid + "");
            //storemenu.DefaultView.RowFilter = "menugroup=" + parentid + "";
            TreeNode chidnode;
            foreach (DataRow dr in drrow)
            {
                if (parentNode == null)
                {
                    menuname = dr["menuname"].ToString() + "(" + dr["SumAmu"].ToString() + ")";
                    chidnode = menulist.Nodes.Add(menuname);

                }
                else
                {
                    menuname = dr["menuname"].ToString() + "(" + dr["SumAmu"].ToString() + ")";
                    chidnode = parentNode.Nodes.Add(menuname);
                    chidnode.Tag = dr["id"].ToString();
                }
                chidnode.ImageIndex = 2;
                chidnode.SelectedImageIndex = 2;
            }

        }

        private void MenuFilter()
        {
            try
            {
                storemenu = MenuMaster.menulist;
                storemenu.DefaultView.RowFilter = "storeid=" + Classes.Stores.SelectedStoreid + "";
                storemenu = storemenu.DefaultView.ToTable();
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
            }
        }
        void GetProductCat()
        {
            try
            {
                //CmbProductType.Items.Add("");
                CmbProductType.DataSource = MenuMaster.MenuGropTitle;
                CmbProductType.DisplayMember = "Catname";
                CmbProductType.ValueMember = "Id";
                CmbProductType.SelectedIndex = -1;
                // Unit Adding 
                CmbUnit.DataSource = Inventory.listdata;
                CmbUnit.ValueMember = "Id";
                CmbUnit.DisplayMember = "name";
                CmbUnit.SelectedValue = "0";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void MenuItems_Load(object sender, EventArgs e)
        {


        }

        private void MenuItems_FormClosing(object sender, FormClosingEventArgs e)
        {
            Stores.SelectedStoreid = 0;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            foodstat = "V";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            foodstat = "N";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            activestatus = 0;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            activestatus = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog dg = new ColorDialog();
            dg.AllowFullOpen = false;
            dg.AnyColor = true;
            dg.SolidColorOnly = false;
            DialogResult rs = dg.ShowDialog();
            if (rs == DialogResult.OK)
            {
                colorcode.Text = dg.Color.Name;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (menuname.Text.Length == 0 || Code.Text.Length == 0)
            {
                Classes.messagemode.messageget(false, "Please enter Menu Name and Print Name.");
                return;
            }
            else if (groupname.Text.Length == 0 || colorcode.Text.Length == 0)
            {
                Classes.messagemode.messageget(false, "Group Name and Color code is blank.");
                return;
            }
            else if (activestatus < 0 || foodstat.Length == 0)
            {
                Classes.messagemode.messageget(false, "Please select the  Status and Food type.");
                return;
            }
            else
            {

                try
                {
                    sum = float.Parse(Bcost.Text) + float.Parse(Tcost.Text);
                }
                catch (Exception ex)
                {
                    messagemode.messageget(false, "Please enter amount in proper format.");
                    return;
                }
                try
                {
                    string CurrentDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    List<menu_items> Menu = new List<menu_items>();
                    List<Menu_Item_Detail> MenuIt = new List<Menu_Item_Detail>();


                    DataRow[] DrSelect = Classes.MenuMaster.menulist.Select("MenuName='" + menuname.Text + "'");
                    if (DrSelect.Length >= 1 && !Update.Checked)
                    {
                        messagemode.MetroMessageBox("Product with same name is already available in " + DrSelect[0]["storename"].ToString() + ", Kindly use copy option to import the menu to avoild inventory mismatch.", this, false);
                        return;
                    }

                    if (New.Checked == true)
                    {
                        Menu.Add(new menu_items
                        {
                            Cdate = CurrentDate,
                            code = foodstat,
                            deleteflag = 0,
                            menugroup = int.Parse(groupname.SelectedValue.ToString()),
                            unit = int.Parse(CmbUnit.SelectedValue.ToString()),
                            Username = loginmodule.username,
                            MenuName = menuname.Text,
                            PrintName = Code.Text,
                            ForSale = chkSale.Checked ? 0 : 1
                        });

                        if (Menu.SaveChanges())
                        {
                            Menu = new List<menu_items>();
                            Menu.Add(new menu_items
                            {
                                Username = loginmodule.username,
                                Cdate = CurrentDate
                            });
                            DataTable dt = Menu.ReturnRow();
                            if (dt.Rows.Count >= 1)
                            {
                                MenuIt.Add(new Menu_Item_Detail
                                {
                                    Menu_Item_Id = int.Parse(dt.Rows[0]["id"].ToString()),
                                    StoreId = Stores.SelectedStoreid,
                                    status = activestatus,
                                    ColorCode = colorcode.Text,
                                    IndexCount = int.Parse(orderby.Value.ToString()),
                                    stock = 0,
                                    SumAmu = decimal.Parse(sum.ToString()),
                                    amount = decimal.Parse(Bcost.Text),
                                    tax = decimal.Parse(Tcost.Text)
                                });
                                MenuIt.SaveChanges();
                                menuname.Text = "";
                                Code.Text = "";
                                //colorcode.Text = "";
                            }
                        }
                        messagemode.messageget(true, "Saved Successfull");
                    }
                    else if (Update.Checked)
                    {
                        if (!messagemode.confirm("Menu Name will be update across the store. Please confirm the status"))
                            return;

                        Menu.Add(new menu_items
                        {
                            Cdate = CurrentDate,
                            code = foodstat,
                            deleteflag = 0,
                            menugroup = int.Parse(groupname.SelectedValue.ToString()),
                            unit = int.Parse(CmbUnit.SelectedValue.ToString()),
                            Username = loginmodule.username,
                            Id = selectmenuid,
                            MenuName = menuname.Text,
                            PrintName = Code.Text
                        });
                        if (Menu.UpdateChanges())
                        {
                            MenuIt.Clear();
                            MenuIt.Add(new Menu_Item_Detail
                            {
                                Menu_Item_Id = selectmenuid,
                                StoreId = Stores.SelectedStoreid
                            });
                            DataTable dt = MenuIt.ReturnRow();
                            if (dt.Rows.Count >= 1)
                            {
                                MenuIt.Clear();
                                MenuIt.Add(new Menu_Item_Detail
                                {
                                    StoreId = Stores.SelectedStoreid,
                                    status = activestatus,
                                    ColorCode = colorcode.Text,
                                    IndexCount = int.Parse(orderby.Value.ToString()),
                                    SumAmu = decimal.Parse(sum.ToString()),
                                    amount = decimal.Parse(Bcost.Text),
                                    tax = decimal.Parse(Tcost.Text),
                                    Id = int.Parse(dt.Rows[0]["Id"].ToString())
                                });
                                MenuIt.UpdateChanges();
                            }
                        }



                        /* MySqlCommand cmd = new MySqlCommand("Update menu_items set menuname=?menuname,printname=?printname,menugroup='" + groupname.SelectedValue.ToString() + "',status='" + activestatus + "',code='" + foodstat + "',orderitem=" + orderby.Value + ",amount='" + Bcost.Text + "',tax='" + Tcost.Text + "',colorcode='" + colorcode.Text + "',sumAmu='" + sum + "',unit=" + CmbUnit.SelectedValue.ToString() + " where id='" + selectmenuid + "'", detail.con);
                        cmd.Parameters.Add("?menuname", MySqlDbType.VarChar).Value = menuname.Text;
                        cmd.Parameters.Add("?printname", MySqlDbType.VarChar).Value = Code.Text;
                        detail.con.Open();
                        cmd.ExecuteNonQuery();
                        detail.con.Close();*/

                        messagemode.messageget(true, "Updated Successfull");

                    }

                    MenuMaster.getItemMenu();
                    MenuFilter();
                    getPatantmenu();
                }
                catch (Exception ex)
                {
                    writeme.errorname(ex);
                    messagemode.messageget(false, "Error while saving Information.");
                }

            }
        }
        private void getMenuUpdated(int id)
        {
            try
            {
                DataTable dt = MenuMaster.menulist;
                dt.DefaultView.RowFilter = "id=" + id + "";
                dt = dt.DefaultView.ToTable();
                menuname.Text = dt.Rows[0]["menuName"].ToString();
                Code.Text = dt.Rows[0]["printname"].ToString();
                CmbProductType.SelectedValue = dt.Rows[0]["pro_inventory_cat_id"].ToString();
                groupname.SelectedValue = dt.Rows[0]["menugroup"].ToString();
                colorcode.Text = dt.Rows[0]["colorcode"].ToString();
                orderby.Value = int.Parse(dt.Rows[0]["indexcount"].ToString());
                Tcost.Text = dt.Rows[0]["tax"].ToString();
                Bcost.Text = dt.Rows[0]["amount"].ToString();
                CmbUnit.SelectedValue = dt.Rows[0]["unit"].ToString();
                chkSale.Checked = dt.Rows[0]["ForSale"].ToString().Equals("0") ? true : false;
                if (dt.Rows[0]["code"].ToString() == "V")
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton2.Checked = true;
                }
                if (int.Parse(dt.Rows[0]["status"].ToString()) == 0)
                {
                    radioButton4.Checked = true;
                }
                else
                {
                    radioButton3.Checked = true;

                }


            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                Classes.messagemode.messageget(false, "Error mention updated");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // MessageBox.Show(menulist.SelectedNode.Tag.ToString());
                Update.Checked = true;
                selectmenuid = int.Parse(menulist.SelectedNode.Tag.ToString());
                getMenuUpdated(selectmenuid);

            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                Classes.messagemode.messageget(false, "Error while getting information");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(menulist.SelectedNode.Tag.ToString());
                if (Classes.messagemode.confirm("Are you confirm to delete the menu"))
                {
                    MySqlCommand cmd = new MySqlCommand("update menu_items set deleteflag=1 where id=" + id + "", detail.con);
                    detail.con.Open();
                    cmd.ExecuteNonQuery();
                    detail.con.Close();
                    Classes.MenuMaster.getItemMenu();
                    MenuFilter();
                    getPatantmenu();
                }

            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                Classes.messagemode.messageget(false, "Selected Menu not found");
            }
        }

        private void New_CheckedChanged(object sender, EventArgs e)
        {
            selectmenuid = 0;
            menuname.Text = "";
            Code.Text = "";
            Bcost.Text = "0.00";
            Tcost.Text = "0.00";
        }

        private void Update_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(menulist.SelectedNode.Tag.ToString());
                Classes.ProductMapping.selectedproid = id;
                Classes.ProductMapping.selectedproductname = menulist.SelectedNode.Text;
                I.ProductMapping pro = new I.ProductMapping();
                pro.ShowDialog();
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(menulist.SelectedNode.Tag.ToString());
                Classes.ProductMapping.selectedproid = id;
                Classes.ProductMapping.selectedproductname = menulist.SelectedNode.Text;
                I.DependentStock stk = new I.DependentStock();
                stk.ShowDialog();
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MenuGroup gp = new MenuGroup();
            gp.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CmbProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CmbProductType.SelectedValue.ToString() != string.Empty)
                {
                    //MessageBox.Show(CmbProductType.SelectedValue.ToString());

                    //groupname
                    getMenugroup(int.Parse(CmbProductType.SelectedValue.ToString()));

                }
            }
            catch (Exception ex)
            {
                // do nothing
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //I.StoreStock Stk = new I.StoreStock(Classes.Stores.SelectedStoreid, Classes.Stores.Selectedstorename);
            //Stk.ShowDialog();
            contextMenuStrip1.Items.Clear();
            contextMenuStrip1.Items.Add("Open");
            contextMenuStrip1.Items.Add("Copy Menu");
            contextMenuStrip1.Items.Add("Transfer Stock");
            contextMenuStrip1.Show(button8, new Point(0, button1.Height));
            contextMenuStrip1.ItemClicked += new ToolStripItemClickedEventHandler(contextMenuStrip1_ItemClicked);
        }
        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "Open":
                    I.StoreStock Stk = new I.StoreStock(Stores.SelectedStoreid, Stores.Selectedstorename);
                    Stk.ShowDialog();
                    break;
                case "Copy Menu":
                    I.StoreMenu Menu = new I.StoreMenu(Stores.SelectedStoreid, Stores.Selectedstorename);
                    Menu.ShowDialog();
                    break;

                case "Transfer Stock":
                    if (OpenDay.getstoreOpenlog(Stores.SelectedStoreid))
                    {
                        I.SendRequisition Req = new I.SendRequisition(Stores.SelectedStoreid, Stores.Selectedstorename);
                        Req.ShowDialog();
                    }
                    else
                        messagemode.messageget(false, "Day is not open for the selected store");
                    break;
            }
        }

        private void CmbProductType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (CmbProductType.SelectedValue.ToString() != string.Empty)
                    getMenugroup(int.Parse(CmbProductType.SelectedValue.ToString()));
            }
            catch (Exception)
            {
                // do nothing
            }
        }

        private void chkSale_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkSale.Checked)
                messagemode.MetroMessageBox("Avalible menu will not available in item list for sale.", this, false);
        }
    }
}
