using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perimeter_Threshold
{
    class MasterBoardStyling : BoardStyling
    {
        public override void HideHeader(DataGridView hideHeader)
        {
            hideHeader.RowHeadersVisible = false;
        }
    }
}
