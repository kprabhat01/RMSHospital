using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.P
{
    public partial class Tables : Form
    {
        public Tables()
        {
            InitializeComponent();
        }

        private void getList()
        {
            try
            {

                tablelist.DataSource = Classes.Tables.tabledetail;
                tablelist.DisplayMember = "tablename";
                tablelist.ValueMember = "id";
                //if(Classes.UserManagement.)

            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                Classes.messagemode.messageget(false, "Error while getting tables");
            }
        }
        private void Tables_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            getList();
            if (Classes.loginmodule.utype != 3)
            {
                addpanel.Visible = false;
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (addnew.Text.Length >= 1)
            {
                if (Classes.Tables.InsertTable(addnew.Text))
                {

                    Classes.Tables.gettablelist();
                    getList();
                }
                else
                {
                    Classes.messagemode.messageget(false, "Error while Saving tables");
                }

            }
            else
            {
                Classes.messagemode.messageget(false, "Please enter the table name");
                return;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Classes.Tables.DeleteTable(int.Parse(tablelist.SelectedValue.ToString())))
                {
                    Classes.Tables.gettablelist();
                    getList();
                }
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                Classes.messagemode.messageget(false, "Please select the table and then process");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Classes.Tables.STableId = int.Parse(tablelist.SelectedValue.ToString());
                Classes.Tables.STableName = tablelist.Text;
                this.Close();
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                Classes.messagemode.messageget(false, "Please select the table and then process");
            }
        }
    }
}
