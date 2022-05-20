using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perimeter_Threshold
{
    class RampBoardStyling : BoardStyling
    {

        public override void HeaderRename(DataGridView gridViewBorad)
        {
            gridViewBorad.Columns["Flight_Number"].HeaderText = "Flight No.";
            gridViewBorad.Columns["Actual_Departure"].HeaderText = "Departed";
            gridViewBorad.Columns["Flight_Lead"].HeaderText = "Flight Lead";
            gridViewBorad.Columns["Delay_Reason"].HeaderText = "Delay Reason";
            gridViewBorad.Columns["Load_Coordinator_Remarks"].HeaderText = "ALC Remarks";
            gridViewBorad.Columns["Ramp_Remarks"].HeaderText = "Ramp Remarks";
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

                        for (int i = 0; i < gridviewArrivalColor.ColumnCount; i++)
                        {
                            row.Cells[i].Style.BackColor = Color.White;
                            row.Cells[i].Style.ForeColor = Color.Black;
                        }
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
    }
}
