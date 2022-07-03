using System;
using System.Windows.Forms;

namespace Perimeter_Threshold
{
    public partial class AddFlight_Cargo : Form
    {
        public AddFlight_Cargo()
        {
            InitializeComponent();
        }

        private void AddFlight_Cargo_Load(object sender, EventArgs e)
        {
            DateTimeFormater.DateTimeDisplay(dateTimeAddFlight);
            DateTimeFormater.AutoSetDate(dateTimeAddFlight);

            // Create autocomplete object, and process auto complete for boxes. 
            AutoComplete completeFlight = new AutoComplete(tbFlightNumber, tbAircraft, tbRouting, tbDeparture, tbProjectWT, tbNotes)
            {
                FlightNumber = tbFlightNumber,
                Aircraft = tbAircraft,
                Routing = tbRouting,
                Departure = tbDeparture,
                ProjectWeight = tbProjectWT,
                Notes = tbNotes,
            };

            completeFlight.AutoCompleteFlight(completeFlight.FlightNumber);
            completeFlight.AutoCompleteAircraft(completeFlight.Aircraft);
            completeFlight.AutoCompleteRouting(completeFlight.Routing);
            completeFlight.AutoCompleteDeparture(completeFlight.Departure);
            completeFlight.AutoCompleteProjectWeight(completeFlight.ProjectWeight);
            completeFlight.AutoCompleteCargoNotes(completeFlight.Notes);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (AddFlight.ValidFlight(tbFlightNumber.Text) && AddFlight.isValidTime(tbDeparture.Text)
                && AddFlight.isValidSeatpack(tbSeatpacks.Text))
            {
                AddFlight insertFlight = new AddFlight(dateTimeAddFlight.Value.Date, tbFlightNumber.Text,
                tbAircraft.Text, tbRouting.Text, tbDeparture.Text, Convert.ToInt32(tbSeatpacks.Text), tbProjectWT.Text,
                tbNotes.Text);

                insertFlight.CargoFlightAdd();
                UpdateBoardsAutomation.UpdateCargoBoardStatus();

                // Clear textboxes, after flight has been added. 
                foreach (Control control in Controls)
                    if (control is TextBox)
                    {
                        control.ResetText();
                    }
            }
        }
    }
}
