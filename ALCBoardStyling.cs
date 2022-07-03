using System.Windows.Forms;

namespace Perimeter_Threshold
{
    internal class ALCBoardStyling : BoardStyling
    {
        /// <summary>
        /// Rename ALC Scheduler column headers. 
        /// </summary>
        /// <param name="gridViewBorad"></param>
        public override void HeaderRename(DataGridView gridViewBorad)
        {
            gridViewBorad.Columns["Flight_Number"].HeaderText = "Flight Number";
            gridViewBorad.Columns["Number_Of_Legs"].HeaderText = "No. of Legs";
            gridViewBorad.Columns["Main_Routing"].HeaderText = "Routing";
            gridViewBorad.Columns["Leg1_Routing"].HeaderText = "Leg 1 Routing";
            gridViewBorad.Columns["Leg2_Routing"].HeaderText = "Leg 2 Routing";
            gridViewBorad.Columns["Leg3_Routing"].HeaderText = "Leg 3 Routing";
            gridViewBorad.Columns["Leg4_Routing"].HeaderText = "Leg 4 Routing";
            gridViewBorad.Columns["Leg5_Routing"].HeaderText = "Leg 5 Routing";
            gridViewBorad.Columns["Leg6_Routing"].HeaderText = "Leg 6 Routing";
        }

        /// <summary>
        /// Hide ALC Scheduler columns. 
        /// </summary>
        /// <param name="hideHeader"></param>
        public override void HideHeader(DataGridView hideHeader)
        {
            hideHeader.Columns["Date_ID"].Visible = false;
            hideHeader.Columns["Day_Of_Week"].Visible = false;
            hideHeader.RowHeadersVisible = false;
        }
    }
}
