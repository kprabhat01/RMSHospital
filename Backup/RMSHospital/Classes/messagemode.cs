using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Classes
{
    class messagemode
    {
        public static void messageget(Boolean type, string message)
        {
            if (type == true)
            {
                MessageBox.Show(message, "LightInfotech", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (type == false)
            {
                MessageBox.Show(message, "LightInfotech", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static bool confirm(string message)
        {
            DialogResult result = MessageBox.Show(message, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }  
        }
    } 

}
