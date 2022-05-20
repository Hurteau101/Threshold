using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Perimeter_Threshold
{
    public partial class AddFlight_Ramp : Form
    {
        public AddFlight_Ramp()
        {
            InitializeComponent();
        }

        private void AddFlight_Ramp_Load(object sender, EventArgs e)
        {          
            // Format the DateTime. Also automatically set date to whatever date was on Ramp Board. 
            DateTimeFormater.DateTimeDisplay(datePicker);
            DateTimeFormater.AutoSetDate(datePicker);

       
            // Create autocomplete object, and process auto complete for boxes. 
            AutoComplete completeFlight = new AutoComplete(tbFlightNumber, tbAircraft, tbRouting, tbDeparture, tbLead, tbALC_Remarks, tbRamp_Remarks)
            {
                FlightNumber = tbFlightNumber,
                Aircraft = tbAircraft,
                Routing = tbRouting,
                Departure = tbDeparture,
                FlightLead = tbLead,
                ALCRemark = tbALC_Remarks,
                RampRemark = tbRamp_Remarks
            };

            completeFlight.AutoCompleteFlight(completeFlight.FlightNumber);
            completeFlight.AutoCompleteAircraft(completeFlight.Aircraft);
            completeFlight.AutoCompleteRouting(completeFlight.Routing);
            completeFlight.AutoCompleteDeparture(completeFlight.Departure);
            completeFlight.AutoCompleteFlightLead(completeFlight.FlightLead);
            completeFlight.AutoCompleteALCRemark(completeFlight.ALCRemark);
            completeFlight.AutoCompleteRampRemarks(completeFlight.RampRemark);
        }
   

        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            // Check if fields are valid before adding flight to Ramp board. Send error if not valid. 
            if (AddFlight.ValidFlight(tbFlightNumber.Text) && AddFlight.isValidTime(tbDeparture.Text)
                && AddFlight.isValidSeatpack(tbSeatpacks.Text))
            {
                AddFlight insertFlight = new AddFlight(datePicker.Value.Date, tbFlightNumber.Text,
                tbAircraft.Text, tbRouting.Text, tbDeparture.Text, Convert.ToInt32(tbSeatpacks.Text), tbLead.Text,
                tbALC_Remarks.Text, tbRamp_Remarks.Text);
                insertFlight.RampFlightAdd();
                UpdateBoardsAutomation.UpdateRampBoardStatus();

                // Clear textboxes, after flight has been added. 
                foreach(Control control in Controls)
                    if(control is TextBox)
                    {
                        control.ResetText();
                    }
            }
        }
    }
}
