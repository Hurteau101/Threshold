using System.Windows.Forms;

namespace Perimeter_Threshold
{
    class CargoBoardStyling : BoardStyling
    {
        /// <summary>
        /// Rename Cargo column header. 
        /// </summary>
        /// <param name="gridViewBorad"></param>
        public override void HeaderRename(DataGridView gridViewBorad)
        {
            gridViewBorad.Columns["Flight_Number"].HeaderText = "Flight No.";
            gridViewBorad.Columns["Weight_Given"].HeaderText = "Allowable Weight";
            gridViewBorad.Columns["Cargo_Notes"].HeaderText = "Notes";
        }

        /// <summary>
        /// If Cargo Board is full screen, display columns this way. 
        /// </summary>
        /// <param name="columnWidth"></param>
        public static void ColumnWidthFull(DataGridView columnWidth)
        {
            columnWidth.Columns["Flight_Number"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            columnWidth.Columns["Flight_Number"].MinimumWidth = 110;

            columnWidth.Columns["Departure"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            columnWidth.Columns["Departure"].MinimumWidth = 110;

            columnWidth.Columns["Routing"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            columnWidth.Columns["Routing"].Width = 130;
            columnWidth.Columns["Routing"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            columnWidth.Columns["Weight_Given"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            columnWidth.Columns["Weight_Given"].MinimumWidth = 110;

            columnWidth.Columns["Seatpacks"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            columnWidth.Columns["Seatpacks"].MinimumWidth = 110;

            columnWidth.Columns["Aircraft"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            columnWidth.Columns["Aircraft"].MinimumWidth = 110;

            columnWidth.Columns["Completion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            columnWidth.Columns["Completion"].MinimumWidth = 110;

            columnWidth.Columns["Cargo_Notes"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnWidth.Columns["Seatblock"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        /// <summary>
        /// If Cargo Board is NOT full screen, display columns this way. 
        /// </summary>
        /// <param name="columnWidth"></param>
        public static void ColumnWidthNotFull(DataGridView columnWidth)
        {
            columnWidth.Columns["Seatblock"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            columnWidth.Columns["Seatblock"].Width = 110;

            columnWidth.Columns["Cargo_Notes"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            columnWidth.Columns["Cargo_Notes"].Width = 110;

            columnWidth.Columns["Flight_Number"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            columnWidth.Columns["Departure"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            columnWidth.Columns["Routing"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            columnWidth.Columns["Weight_Given"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            columnWidth.Columns["Seatpacks"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            columnWidth.Columns["Aircraft"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            columnWidth.Columns["Completion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        }
    }
}
