using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Classes;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1.U
{
    public partial class SecSettings : MetroFramework.Controls.MetroUserControl
    {
        private int Utype { get; set; }

        public SecSettings(int IUtype, string IutypeName)
        {
            Utype = IUtype;
            InitializeComponent();

            lblType.Text = IutypeName;
        }
        void getGridDetail(int Utype)
        {
            try
            {
                string Query = @"SELECT menude.id, menude.menuname AS 'Menu Name',
                                 CASE  WHEN sec_userprofile.id IS NULL THEN 'False' ELSE 'True' END AS Access 
                                 FROM menude LEFT OUTER JOIN sec_userprofile ON sec_userprofile.mid = menude.id AND  sec_userprofile.utype=" + Utype + " WHERE menude.deleteflag=0  AND  menude.liesin!=0";

                metroGrid1.DataSource = Classes.SqlHelper.ReturnRows(Query);
                metroGrid1.Columns[0].Visible = false;
                metroGrid1.Columns[2].Visible = false;
                metroGrid1.Columns[1].Width = 450;
                metroGrid1.Columns[1].ReadOnly = true;
                DataGridViewCheckBoxColumn Check = new DataGridViewCheckBoxColumn();
                Check.ValueType = typeof(bool);
                metroGrid1.Columns.Add(Check);
                Check.HeaderText = string.Empty;
                Check.Width = 20;
                metroGrid1.AllowUserToAddRows = false;
                foreach (DataGridViewRow dr in metroGrid1.Rows)
                {
                    if (dr.Cells[2].Value.ToString().ToLower().Equals("true"))
                    {
                        dr.Cells[3].Value = true;
                        //dr.DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                }
                metroGrid1.Width = 500;
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
            }
        }
        private void SecSettings_Load(object sender, EventArgs e)
        {
            getGridDetail(Utype);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                List<sec_userprofile> lst = new List<sec_userprofile>();
                lst.Add(new sec_userprofile
                {
                    utype = Utype
                });
                if (lst.DeleteChanges())
                {
                    lst.Clear();
                    foreach (DataGridViewRow Dr in metroGrid1.Rows)
                    {
                        bool value;
                        try { value = (bool)Dr.Cells[3].Value; } catch (Exception) { value = false; }
                        //Dr.Cells[3].Value.ToString() != null ? "true" : "false";
                        if (value)
                        {
                            lst.Add(new sec_userprofile
                            {
                                utype = Utype,
                                mid = int.Parse(Dr.Cells[0].Value.ToString())
                            });
                        }
                    }
                    if (lst.SaveChanges())
                    {
                        Classes.messagemode.messageget(true, "Security settings has been saved properly");
                        // getGridDetail(Utype);
                    }
                }
            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
            }

        }
    }
}
