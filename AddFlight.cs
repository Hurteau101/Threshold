using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data;

namespace Perimeter_Threshold
{
    public class AddFlight
    {
        public string FlightNumber { get; set; }
        public DateTime Date { get; set; }
        public string Aircraft { get; set; }
        public string Routing { get; set; }
        public string Departure { get; set; }
        public string Seatpacks { get; set; }
        public string FlightLead { get; set; }
        public string ALCRemark { get; set; }
        public string RampRemark { get; set; }

        /// <summary>
        /// Constructor with optional parameters,
        /// </summary>
        /// <param name="date"></param>
        /// <param name="flightNumber"></param>
        /// <param name="aircraft"></param>
        /// <param name="routing"></param>
        /// <param name="departure"></param>
        /// <param name="seatpacks"></param>
        /// <param name="flightLead"></param>
        /// <param name="ALC_Remarks"></param>
        /// <param name="ramp_remarks"></param>
        public AddFlight(DateTime date, string flightNumber = "", string aircraft = "", string routing = "",
            string departure = "", string seatpacks = "", string flightLead = "", string ALC_Remarks = "", string ramp_remarks ="")
        {
            FlightNumber = flightNumber;
            Date = date;
            Aircraft = aircraft;
            Routing = routing;
            Departure = departure;
            Seatpacks = seatpacks;
            FlightLead = flightLead;
            ALCRemark = ALC_Remarks;
            RampRemark = ramp_remarks;

            // Seatpacks is set to string, need to figure out optional parameter for textbox for int. 
            // Use Regex to make sure time is inputted correct format (20:00)
        }

        // Add flight to Ramp Board. If flight exist, provide error. 
        public void FlightAdd()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionLoader.ConnectionString("LoadPlanner")))
            {
                connection.Open();
                SqlCommand loadFlightData = new SqlCommand("Select * from RampBoard WHERE DateID = @DateID " +
                    "AND FlightNumber =@FlightNumber", connection);
                loadFlightData.Parameters.AddWithValue("@DateID", Date);
                loadFlightData.Parameters.AddWithValue("@FlightNumber", FlightNumber);
                SqlDataReader checkFlight = loadFlightData.ExecuteReader();
                if (checkFlight.Read())
                {
                    MessageBox.Show("Flight already exist", "Flight Error", MessageBoxButtons.OK);
                }
                else
                {
                    SqlCommand addFlight = new SqlCommand("RampBoardInsertion", connection);
                    addFlight.CommandType = CommandType.StoredProcedure;
                    addFlight.Parameters.AddWithValue("@FlightNumber", FlightNumber);
                    addFlight.Parameters.AddWithValue("@Aircraft", Aircraft);
                    addFlight.Parameters.AddWithValue("@Routing", Routing);
                    addFlight.Parameters.AddWithValue("@Departure", Departure);
                    addFlight.Parameters.AddWithValue("@Seatpacks", Seatpacks);
                    addFlight.Parameters.AddWithValue("@FlightLead", FlightLead);
                    addFlight.Parameters.AddWithValue("@ALCRemarks", ALCRemark);
                    addFlight.Parameters.AddWithValue("@RampRemarks", RampRemark);
                    addFlight.Parameters.AddWithValue("@DateID", Date);
                    addFlight.Parameters.AddWithValue("@DayOfWeek", DateTime.Today.DayOfWeek.ToString());
                    addFlight.ExecuteNonQuery();
                   
                    MessageBox.Show("Flight Sucessfully Added.", "Flight Added", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Checks if user inputs valid flight indicator. All flights must start with "JV".
        /// </summary>
        /// <param name="flightNumber"></param>
        /// <returns></returns>
        public static bool ValidFlight(string flightNumber)
        {
            // Store mandatory flight beginning flight indicator. 
            var flightIndicator = new Regex("^JV");

            if (!flightIndicator.IsMatch(flightNumber))
            {
                MessageBox.Show("Invalid flight. Please add a valid flight \n" +
                    "Reminder all flights need to start with \"JV\"", "Error - Adding Flight", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Check if user inputs valid time. 
        /// </summary>
        /// <param name="timeInput"></param>
        /// <returns></returns>
        public static bool isValidTime(string timeInput)
        {
            var checkTime = new Regex("^(?:0?[0-9]|1[0-9]|2[0-3]):[0-5][0-9]$");

            if(!checkTime.IsMatch(timeInput))
            {
                MessageBox.Show("Invalid time. All times need to be in 24 hour format. \n" +
                     "Ex. 08:00 or 22:00", "Error - Adding Flight", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Check if user inputs valid seatpack values (between 0-16)
        /// </summary>
        /// <param name="inputSeatpack"></param>
        /// <returns></returns>
        public static bool isValidSeatpack(string inputSeatpack)
        {
            if (!Int32.TryParse(inputSeatpack, out int seatpacks) && (seatpacks < 17 && seatpacks >= 0))
            {
                MessageBox.Show("Invalid seatpacks. Please enter a value between 0-16", "Error - Adding Flight", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            return true; 

        }
    }
}
