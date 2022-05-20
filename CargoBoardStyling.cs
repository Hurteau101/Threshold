using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perimeter_Threshold
{
    class CargoBoardStyling : BoardStyling
    {
        public static void ReArrangeColumns(DataGridView gridview)
        {
            gridview.Columns["Aircraft"].DisplayIndex = 2;
        }
    }
}
