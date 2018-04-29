using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;

namespace WindowsFormsApplication1
{
    public partial class Home : MetroFramework.Forms.MetroForm
    {


        ToolStripMenuItem MnuStripItem;
        DataTable forsubmenu;
        DataTable submenu;
        string name;
        int i = 0;
        bool checkConf = false;
        public Home()
        {
            InitializeComponent();

        }
        protected void getMymenu()
        {
            try
            {
                DataTable drmenu = Classes.getMenu.getMenudetail();
                if (drmenu.Rows.Count >= 1)
                {
                    foreach (DataRow dr in drmenu.Rows)
                    {

                        menuStrip1.Items.Add(dr[1].ToString());
                        menuStrip1.ForeColor = Color.White;

                        int a = submenu.Rows.Count;
                        DataRow[] drlocal = submenu.Select("liesin=" + dr[0].ToString());

                        foreach (DataRow drlocalmenu in drlocal)
                        {
                            ToolStripMenuItem item = (ToolStripMenuItem)((ToolStripMenuItem)menuStrip1.Items[i]).DropDownItems.Add(drlocalmenu[0].ToString());
                            item.Click += new EventHandler(butclick);
                        }
                        i++;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Classes.writeme.errorname(ex);
            }
        }
        /* var itemText = (sender as ToolStripMenuItem).Text;
                MessageBox.Show(itemText);*/

        protected void getMenuOpne(string formname, int openid)
        {
            try
            {
                if (openid == 0 || openid == 1)
                {
                    Form frm = (Form)Assembly.GetExecutingAssembly().CreateInstance("WindowsFormsApplication1." + formname);
                    if (openid == 0)
                    {
                        frm.ShowDialog();
                    }
                    else if (openid == 1)
                    {
                        //SubForm frm = SubForm.InstanceForm();
                        frm.TopLevel = false;
                        MainPanel.Controls.Add(frm);
                        //frm.MdiParent = this;
                        frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                        //frm.Dock = DockStyle.Fill;                   

                        frm.BringToFront();
                        frm.Show();
                    }
                }
                else if (openid == 2)
                {
                    UserControl Control = (UserControl)Assembly.GetExecutingAssembly().CreateInstance("WindowsFormsApplication1." + formname);
                    MainPanel.Controls.Add(Control);                  
                    Control.BringToFront();
                    Control.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        protected void butclick(object sender, EventArgs e)
        {
            var itemText = (sender as ToolStripMenuItem).Text;
            DataRow[] des = submenu.Select("menuname='" + itemText + "'");
            foreach (DataRow dr in des)
            {
                if (dr[0].ToString() == itemText)
                {
                    getMenuOpne(dr[1].ToString(), int.Parse(dr[2].ToString()));
                }
            }


        }
        void Form_KeyDown(object sender, KeyEventArgs e)
        {
            keyCase(e.KeyCode.ToString());
        }
        void keyCase(string s)
        {
            switch (s)
            {
                case "F1":
                    P.OrderBox O = new P.OrderBox();
                    O.ShowDialog();
                    break;
            }

        }
        private void Home_Load(object sender, EventArgs e)
        {
            submenu = Classes.getMenu.sublist(Classes.loginmodule.utype);
            getMymenu();
            this.Text = "LightInfotech (" + Classes.loginmodule.username + ")";
            this.WindowState = FormWindowState.Maximized;
            Classes.FrmHelper.Frmheight = this.MainPanel.Height;
            Classes.FrmHelper.FrmWidth = this.MainPanel.Width;

        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (checkConf == false)
            {
                if (Classes.messagemode.confirm("Are you sure to Close the application ?"))
                {
                    Application.Exit();
                    checkConf = true;
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void Home_KeyPress(object sender, KeyEventArgs e)
        {
            keyCase(e.KeyCode.ToString());
        }
    }
}
