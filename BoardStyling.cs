using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
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

        public bool Grid { get; set; }

        public static void GridViewColumnSizeWidth (DataGridView gridviewWidth)
        {
            gridviewWidth.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            gridviewWidth.Columns[1].Width = 110;

            // Loop through the columns, and set a minimum width.
            foreach (DataGridViewColumn column in gridviewWidth.Columns)
            {
                column.MinimumWidth = 150;
                
            }
        }

        public static void GridviewColumnSize(DataGridView gridviewSize)
        {
            gridviewSize.RowTemplate.MinimumHeight = 45;
        }

        public virtual void HeaderRename(DataGridView gridViewBorad)
        {
            gridViewBorad.Columns["Flight_Number"].HeaderText = "Flight No.";
        }

        public static void UnsortableColumns(DataGridView gridViewBoard)
        {
            foreach (DataGridViewColumn column in gridViewBoard.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        public virtual void HideHeader(DataGridView hideHeader)
        {
             hideHeader.RowHeadersVisible = false;
             hideHeader.Columns["Date_ID"].Visible = false;
        }

        public static void ColumnSortDirection(DataGridView sortDirection)
        {
            sortDirection.Sort(sortDirection.Columns["Departure"], ListSortDirection.Ascending);
        }

        public static void RowSize(DataGridView rowSize)
        {
            rowSize.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
        }

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
