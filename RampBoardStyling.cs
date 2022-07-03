using System;
using System.Drawing;
using System.Windows.Forms;

namespace Perimeter_Threshold
{
    class RampBoardStyling : BoardStyling
    {
        /// <summary>
        /// Rename Ramp Board column names. 
        /// </summary>
        /// <param name="gridViewBorad"></param>
        public override void HeaderRename(DataGridView gridViewBorad)
        {
            gridViewBorad.Columns["Flight_Number"].HeaderText = "Flight No.";
            gridViewBorad.Columns["Actual_Departure"].HeaderText = "Departed";
            gridViewBorad.Columns["Flight_Lead"].HeaderText = "Flight Lead";
            gridViewBorad.Columns["Delay_Reason"].HeaderText = "Delay Reason";
            gridViewBorad.Columns["Load_Coordinator_Remarks"].HeaderText = "ALC Remarks";
            gridViewBorad.Columns["Ramp_Remarks"].HeaderText = "Ramp Remarks";
            gridViewBorad.Columns["Aircraft_Location"].HeaderText = "A/C Location";
        }

        /// <summary>
        /// Hide Ramp Board columns. 
        /// </summary>
        /// <param name="gridviewColumnName"></param>
        public override void HideHeader(DataGridView gridviewColumnName)
        {
            gridviewColumnName.Columns["Aircraft_Status"].Visible = false;
            gridviewColumnName.RowHeadersVisible = false;
            gridviewColumnName.Columns["Date_ID"].Visible = false;
        }

        /// <summary>
        /// Set column colors for Departed. Whether its early, on-time or late. Depending on which, will decide the color. 
        /// </summary>
        /// <param name="gridviewColors"></param>
        /// <param name="date"></param>
        public void GridviewDelayColors(DataGridView gridviewColors)
        {
            DateTime scheduleDeparture;
            DateTime actualDeparture;

            foreach (DataGridViewRow row in gridviewColors.Rows)
            {
                /// Cell[4] - Departed Column | Cell[5] - Departure Column | Cell[6] - Arrival

                // Check if the Departure Column is empty. If it is, keep the column set as white background. 
                if (row.Cells[5].Value == null || string.IsNullOrEmpty(row.Cells[5].Value.ToString()) || string.IsNullOrWhiteSpace(row.Cells[5].Value.ToString()))
                {
                    row.Cells[5].Style.BackColor = Color.White;
                    row.Cells[5].Style.ForeColor = Color.Black;
                }
                else
                {
                    DateTime.TryParse((row.Cells[4].Value).ToString(), out scheduleDeparture);
                    DateTime.TryParse((row.Cells[5].Value).ToString(), out actualDeparture);

                    // Colors are being loaded from Database, depending on user preference color set. 
                    if (scheduleDeparture < actualDeparture)
                    {
                        row.Cells[5].Style.BackColor = Color.FromArgb(LateColor);
                        row.Cells[5].Style.ForeColor = Color.White;
                    }
                    else if (scheduleDeparture == actualDeparture)
                    {
                        row.Cells[5].Style.BackColor = Color.FromArgb(OnTimeColor);
                        row.Cells[5].Style.ForeColor = Color.White;
                    }
                    else if (scheduleDeparture > actualDeparture)
                    {
                        row.Cells[5].Style.BackColor = Color.FromArgb(EarlyColor);
                        row.Cells[5].Style.ForeColor = Color.White;
                    }
                    else
                    {
                        row.Cells[5].Style.BackColor = Color.White;
                        row.Cells[5].Style.ForeColor = Color.Black;
                    }
                }
            }
        }

        /// <summary>
        /// Set Arrival column color, if arrival time is past current time. 
        /// </summary>
        /// <param name="gridviewArrivalColor"></param>
        /// <param name="date"></param>
        public static void ArrivalTimeColor(DataGridView gridviewArrivalColor, DateTime date)
        {
            DateTime currentDate = DateTime.Now;
            DateTime arrivalTime;

            // Make sure nothing is arrived in the future. 
            if (currentDate > date)
            {
                foreach (DataGridViewRow row in gridviewArrivalColor.Rows)
                {
                    if (row.Cells[6].Value == null || string.IsNullOrEmpty(row.Cells[6].Value.ToString()) || string.IsNullOrWhiteSpace(row.Cells[6].Value.ToString()))
                    {
                        row.Cells[6].Style.BackColor = Color.White;
                        row.Cells[6].Style.ForeColor = Color.Black;
                        row.Cells[6].Value = null;

                        //for (int i = 0; i < gridviewArrivalColor.ColumnCount; i++)
                        //{
                        //    row.Cells[i].Style.BackColor = Color.White;
                        //    row.Cells[i].Style.ForeColor = Color.Black;
                        //}
                    }
                    else
                    {
                        DateTime.TryParse(row.Cells[6].Value.ToString(), out arrivalTime);

                        // Check if arrival time is less than current date time as well if its a previous day, if it has an arrival time, set it to arrived, 
                        // since its in the past. 
                        // Colors are being loaded from Database, depending on user preference color set. 
                        if (arrivalTime < currentDate || date < DateTime.Today)
                        {
                            row.Cells[6].Value = "Arrived";
                            for (int i = 0; i < gridviewArrivalColor.ColumnCount; i++)
                            {
                                row.Cells[i].Style.BackColor = Color.FromArgb(ArrivalColor);
                                row.Cells[i].Style.ForeColor = Color.White;
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Load Status of the Aicraft. 
        /// </summary>
        /// <param name="gridviewUnserviceable"></param>
        public static void LoadAircraftStatus(DataGridView gridviewUnserviceable)
        {
            foreach (DataGridViewRow row in gridviewUnserviceable.Rows)
            {
                if (row.Cells[12].Value.ToString() == "1")
                {
                    for (int i = 0; i < gridviewUnserviceable.ColumnCount; i++)
                    {
                        row.Cells[i].Style.BackColor = Color.FromArgb(UnserviceableColor);
                        row.Cells[i].Style.ForeColor = Color.Black;
                    }

                }
                else
                {
                    for (int i = 0; i < gridviewUnserviceable.ColumnCount; i++)
                    {
                        row.Cells[i].Style.BackColor = Color.White;
                        row.Cells[i].Style.ForeColor = Color.Black;
                    }
                }
            }
        }

        /// <summary>
        /// Adjust column widths if form is maximized. 
        /// </summary>
        /// <param name="columnWidth"></param>
        public static void ColumnWidthFull(DataGridView columnWidth)
        {
            columnWidth.Columns["Flight_Number"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            columnWidth.Columns["Flight_Number"].MinimumWidth = 110;

            columnWidth.Columns["Aircraft"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            columnWidth.Columns["Aircraft"].MinimumWidth = 110;

            columnWidth.Columns["Routing"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            columnWidth.Columns["Routing"].Width = 130;
            columnWidth.Columns["Routing"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            columnWidth.Columns["Departure"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            columnWidth.Columns["Departure"].MinimumWidth = 110;

            columnWidth.Columns["Actual_Departure"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            columnWidth.Columns["Actual_Departure"].MinimumWidth = 130;

            columnWidth.Columns["Arrival"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            columnWidth.Columns["Arrival"].MinimumWidth = 150;

            columnWidth.Columns["Flight_Lead"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            columnWidth.Columns["Flight_Lead"].MinimumWidth = 130;

            columnWidth.Columns["Seatpacks"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            columnWidth.Columns["Seatpacks"].MinimumWidth = 100;

            columnWidth.Columns["Delay_Reason"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnWidth.Columns["Load_Coordinator_Remarks"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnWidth.Columns["Ramp_Remarks"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;           
        }

        /// <summary>
        /// Adjust column widths if form is not maximized. 
        /// </summary>
        /// <param name="columnWidth"></param>
        public static void ColumnWidthNotFull(DataGridView columnWidth)
        {
            columnWidth.Columns["Flight_Number"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            columnWidth.Columns["Aircraft"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            columnWidth.Columns["Routing"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            columnWidth.Columns["Departure"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            columnWidth.Columns["Actual_Departure"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            columnWidth.Columns["Arrival"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            columnWidth.Columns["Flight_Lead"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            columnWidth.Columns["Seatpacks"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            columnWidth.Columns["Delay_Reason"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            columnWidth.Columns["Delay_Reason"].Width = 200;

            columnWidth.Columns["Load_Coordinator_Remarks"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            columnWidth.Columns["Load_Coordinator_Remarks"].Width = 200;

            columnWidth.Columns["Ramp_Remarks"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            columnWidth.Columns["Ramp_Remarks"].Width = 200;
        }
    }
}
