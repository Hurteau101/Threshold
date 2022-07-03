using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace Perimeter_Threshold
{
    public class BoardStyling
    {
        public static int EarlyColor { get; set; }
        public static int OnTimeColor { get; set; }
        public static int LateColor { get; set; }
        public static int ArrivalColor { get; set; }
        public static int UnserviceableColor { get; set; }

        /// <summary>
        /// Auto size column mode to fill. 
        /// </summary>
        /// <param name="gridviewWidth"></param>
        public static void GridViewColumnMode(DataGridView gridviewWidth)
        {
            gridviewWidth.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        /// <summary>
        /// Set minimum row size. 
        /// </summary>
        /// <param name="gridviewSize"></param>
        public static void GridviewMinimumRowSize(DataGridView gridviewSize)
        {
            gridviewSize.RowTemplate.MinimumHeight = 45;
        }

        /// <summary>
        /// Rename column header. 
        /// </summary>
        /// <param name="gridViewBorad"></param>
        public virtual void HeaderRename(DataGridView gridViewBorad)
        {
            gridViewBorad.Columns["Flight_Number"].HeaderText = "Flight No.";
        }

        /// <summary>
        /// Set unsortable columns. 
        /// </summary>
        /// <param name="gridViewBoard"></param>
        public static void UnsortableColumns(DataGridView gridViewBoard)
        {
            foreach (DataGridViewColumn column in gridViewBoard.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        /// <summary>
        /// Hide columns.
        /// </summary>
        /// <param name="hideHeader"></param>
        public virtual void HideHeader(DataGridView hideHeader)
        {
            hideHeader.RowHeadersVisible = false;
            hideHeader.Columns["Date_ID"].Visible = false;
        }

        /// <summary>
        /// Sort Columns. 
        /// </summary>
        /// <param name="sortDirection"></param>
        public static void ColumnSortDirection(DataGridView sortDirection)
        {
            sortDirection.Sort(sortDirection.Columns["Departure"], ListSortDirection.Ascending);
        }

        /// <summary>
        /// Auto size row mode to all cells expcept headers. 
        /// </summary>
        /// <param name="rowSize"></param>
        public static void RowSizeMode(DataGridView rowSize)
        {
            rowSize.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
        }

        /// <summary>
        /// Misc styling. 
        /// </summary>
        /// <param name="gridStyling"></param>
        public static void GridviewStyling(DataGridView gridStyling)
        {
            gridStyling.BackgroundColor = Color.WhiteSmoke;
            gridStyling.BorderStyle = BorderStyle.Fixed3D;
            gridStyling.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            gridStyling.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            gridStyling.GridColor = Color.White;
            gridStyling.RowHeadersWidth = 51;
            gridStyling.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            gridStyling.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
            gridStyling.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            // Column Header Default Styling & Cell Default Styling - set in properties of actual Gridview.
        }
    }
}
