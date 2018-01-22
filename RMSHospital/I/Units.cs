using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.I
{
    public partial class Units : Form
    {
        public Units()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
        }
        void getList()
        {
            try
            {
                unitlist.DataSource = Classes.UnitHelper.getUnits();
                unitlist.DisplayMember = "name";
                unitlist.ValueMember = "id";
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                return;
            }
        }
        private void Units_Load(object sender, EventArgs e)
        {
            getList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 1)
            {
                if (Classes.UnitHelper.InsertUnit(textBox1.Text))
                {
                    getList();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int unit = int.Parse(unitlist.SelectedValue.ToString());
                if (unitlist.SelectedValue.ToString().Length >= 1)
                {
                    if (Classes.UnitHelper.CheckUnitMark(unit) == false)
                    {
                        if (Classes.UnitHelper.DelUnit(unit))
                            getList();
                    }
                    else
                    {
                        Classes.messagemode.messageget(false, "Unit is already mapped and cannot be deleted.");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                Classes.messagemode.messageget(false, "Please select the unit and proceed.");
                return;
            }
        }
    }
}
