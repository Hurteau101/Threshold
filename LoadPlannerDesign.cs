using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perimeter_Threshold
{
    public class LoadPlannerDesign
    {
        public static void OverweightColor(TextBox overWeightDifference, Panel backgroundPanel)
        {
            if (HelperMethods.GetTextAsInteger(overWeightDifference) < 0)
            {
                overWeightDifference.BackColor = Color.Red;
                overWeightDifference.ForeColor = Color.White;
                backgroundPanel.BackColor = Color.Red;
            }
            else
            {
                overWeightDifference.BackColor = SystemColors.Control;
                overWeightDifference.ForeColor = Color.Black;
                backgroundPanel.BackColor = SystemColors.Control;
            }
        }
    }
}
