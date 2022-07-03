using System;
using System.Windows.Forms;

namespace Perimeter_Threshold
{
    public partial class AddFlight_ALC : Form
    {
        public AddFlight_ALC()
        {
            InitializeComponent();
        }

        private void AddFlight_ALC_Load(object sender, EventArgs e)
        {
            DateTimeFormater.DateTimeDisplay(datePicker);
            DateTimeFormater.AutoSetDate(datePicker);
        }

        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            if (AddFlight.ValidFlight(tbFlightNumber.Text) && AddFlight.isValidTime(tbDeparture.Text))             
            {
                AddFlight insertFlight = new AddFlight(datePicker.Value.Date, tbFlightNumber.Text)
                {
                    Main_Routing = tbRouting.Text,
                    Departure = tbDeparture.Text,
                    NumberOfLegs = HelperMethods.GetTextAsInteger(cbFlightNumber)                   
                };
                insertFlight.ScheduleAdd_ALC();

                // Clear textboxes, after flight has been added. 
                foreach (Control control in Controls)
                    if (control is TextBox)
                    {
                        control.ResetText();
                    }
                cbFlightNumber.SelectedIndex = -1;

                // Refresh Gridview from other form. 
                SchedulerALC refresh = (SchedulerALC)Application.OpenForms["SchedulerALC"];
                refresh.ALCScheduleLoader();
            }
        }
    }
}
