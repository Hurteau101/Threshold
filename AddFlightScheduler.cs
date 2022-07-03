using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Perimeter_Threshold
{
    public partial class AddFlightScheduler : Form
    {
        public AddFlightScheduler()
        {
            InitializeComponent();
        }

        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            // Create List. Store any checked boxes in the list. Then pass that list over to Add Flight Class.
            // This will allow it to loop through all the different days checked, to add them all to the database for each day of the week. 
            List<string> dayOfWeek = new List<string>();
            foreach (string day in chkListBoxDayOfWeek.CheckedItems)
            {
                dayOfWeek.Add(day);

            }

            // Make sure atleast 1 checkbox is checked. 
            if (dayOfWeek.Count != 0)
            {
                // Check if fields are valid before adding flight to Ramp board. Send error if not valid. 
                if (AddFlight.ValidFlight(tbFlightNumber.Text) && AddFlight.isValidTime(tbDeparture.Text))
                {
                    AddFlight addFlight = new AddFlight();
                    addFlight.DayOfWeek = dayOfWeek;
                    addFlight.Flight_Number = tbFlightNumber.Text;
                    addFlight.Departure = tbDeparture.Text;
                    addFlight.Main_Routing = tbRouting.Text;
                    addFlight.MasterScheduleAdd();

                    // Clear textboxes, after flight has been added. 
                    foreach (Control control in Controls)
                        if (control is TextBox)
                        {
                            control.ResetText();
                        }

                    for (int i = 0; i < chkListBoxDayOfWeek.Items.Count; i++)
                    {
                        chkListBoxDayOfWeek.SetItemChecked(i, false);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please make sure you have atleast 1 day selected.", "Failed to save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
