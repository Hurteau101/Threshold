using System.Windows.Forms;

namespace Perimeter_Threshold
{
    class MasterBoardStyling : BoardStyling
    {
        /// <summary>
        /// Hide Specific Columns in Master Scheduler
        /// </summary>
        /// <param name="hideHeader"></param>
        public override void HideHeader(DataGridView hideHeader)
        {
            hideHeader.RowHeadersVisible = false;
            hideHeader.Columns["Day_Of_Week"].Visible = false;
        }

        /// <summary>
        /// Rename Columns in Master Scheduler
        /// </summary>
        /// <param name="renameColumns"></param>
        public override void HeaderRename(DataGridView renameColumns)
        {
            renameColumns.Columns["Flight_Number"].HeaderText = "Flight No.";
            renameColumns.Columns["Number_Of_Legs"].HeaderText = "No. Of Legs";
            renameColumns.Columns["ALC_Routing_Leg1"].HeaderText = "ALC Leg 1";
            renameColumns.Columns["ALC_Routing_Leg2"].HeaderText = "ALC Leg 2";
            renameColumns.Columns["ALC_Routing_Leg3"].HeaderText = "ALC Leg 3";
            renameColumns.Columns["ALC_Routing_Leg4"].HeaderText = "ALC Leg 4";
            renameColumns.Columns["ALC_Routing_Leg5"].HeaderText = "ALC Leg 5";
            renameColumns.Columns["ALC_Routing_Leg6"].HeaderText = "ALC Leg 6";
        }

        /// <summary>
        /// Hide ALC Routing columns on Master Scheduler. 
        /// </summary>
        /// <param name="hideColumns"></param>
        public static void HideALC_Routing(DataGridView gridview, ToolStripMenuItem showALC, ToolStripMenuItem hideALC)
        {
            gridview.Columns["ALC_Routing_Leg1"].Visible = false;
            gridview.Columns["ALC_Routing_Leg2"].Visible = false;
            gridview.Columns["ALC_Routing_Leg3"].Visible = false;
            gridview.Columns["ALC_Routing_Leg4"].Visible = false;
            gridview.Columns["ALC_Routing_Leg5"].Visible = false;
            gridview.Columns["ALC_Routing_Leg6"].Visible = false;

            hideALC.Checked = true;
            showALC.Checked = false;
            hideALC.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            showALC.DisplayStyle = ToolStripItemDisplayStyle.Text;
        }

        /// <summary>
        /// Show ALC Routing columns on Master Scheduler
        /// </summary>
        /// <param name="gridview"></param>
        /// <param name="showALC"></param>
        /// <param name="hideALC"></param>
        public static void ShowALC_Routing(DataGridView gridview, ToolStripMenuItem showALC, ToolStripMenuItem hideALC)
        {
            gridview.Columns["ALC_Routing_Leg1"].Visible = true;
            gridview.Columns["ALC_Routing_Leg2"].Visible = true;
            gridview.Columns["ALC_Routing_Leg3"].Visible = true;
            gridview.Columns["ALC_Routing_Leg4"].Visible = true;
            gridview.Columns["ALC_Routing_Leg5"].Visible = true;
            gridview.Columns["ALC_Routing_Leg6"].Visible = true;

            showALC.Checked = true;
            hideALC.Checked = false;
            hideALC.DisplayStyle = ToolStripItemDisplayStyle.Text;
            showALC.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
        }
    }
}
