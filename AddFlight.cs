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
    public class AddFlight : FlightDetail
    {
       // public string Flight_Number { get; set; }
        //public DateTime Date_ID { get; set; }
       // public string Aircraft { get; set; }
        public string Main_Routing { get; set; }
        public string Departure { get; set; }
      //  public int Seatpacks { get; set; }
        public string FlightLead { get; set; }
        public string ALCRemark { get; set; }
        public string Ramp_Remarks { get; set; }
        public int Weight_Given { get; set; }
        public string Cargo_Notes { get; set; }
        public List<string> DayOfWeek { get; set; }
     //   public string Notes { get; set; }


        /// <summary>
        /// Constructor with optional parameters.
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
        public AddFlight(DateTime date, string flightNumber, string aircraft = "", string routing = "",
            string departure = "", int seatpacks = 0, string flightLead = "", string ALC_Remarks = "", string ramp_remarks ="", int projectWeight = 0, string notes = "")
        {
            Flight_Number = flightNumber;
            Date_ID = date;
            Aircraft = aircraft;
            Main_Routing = routing;
            Departure = departure;
            Seatpacks = seatpacks;
            FlightLead = flightLead;
            ALCRemark = ALC_Remarks;
            Ramp_Remarks = ramp_remarks;
            Weight_Given = projectWeight;
            Cargo_Notes = notes;
        }

        public AddFlight()
        {

        }


        /// <summary>
        /// Add flight into Ramp Board. If flight already exists, then let user know. 
        /// </summary>
        /// <param name="FlightNumber"></param>
        /// <param name="Date"></param>
        /// <returns></returns>
        public void RampFlightAdd()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                connection.Open();
                SqlCommand addFlight = new SqlCommand("Ramp_Board_Insertion", connection);
                addFlight.CommandType = CommandType.StoredProcedure;
                addFlight.Parameters.AddWithValue("@FlightNumber", Flight_Number);
                addFlight.Parameters.AddWithValue("@Aircraft", Aircraft);
                addFlight.Parameters.AddWithValue("@Routing", Main_Routing);
                addFlight.Parameters.AddWithValue("@Departure", Departure);
                addFlight.Parameters.AddWithValue("@Seatpacks", Seatpacks);
                addFlight.Parameters.AddWithValue("@FlightLead", FlightLead);
                addFlight.Parameters.AddWithValue("@ALCRemarks", ALCRemark);
                addFlight.Parameters.AddWithValue("@RampRemarks", Ramp_Remarks);
                addFlight.Parameters.AddWithValue("@DateID", Date_ID);
                var rowCount = (int?)addFlight.ExecuteNonQuery();
                if (rowCount > 0)
                {
                    MessageBox.Show("Flight Sucessfully Added.", "Flight Added", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Flight already exist", "Flight Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Add Flight to Cargo DB. 
        /// </summary>
        public void CargoFlightAdd()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                connection.Open();
                SqlCommand addFlight = new SqlCommand("Cargo_Board_Insertion", connection);
                addFlight.CommandType = CommandType.StoredProcedure;
                addFlight.Parameters.AddWithValue("@FlightNumber", Flight_Number);
                addFlight.Parameters.AddWithValue("@Aircraft", Aircraft);
                addFlight.Parameters.AddWithValue("@Routing", Main_Routing);
                addFlight.Parameters.AddWithValue("@Departure", Departure);
                addFlight.Parameters.AddWithValue("@Seatpacks", Seatpacks);
                addFlight.Parameters.AddWithValue("@Weight_Given", Weight_Given);
                addFlight.Parameters.AddWithValue("@Notes", Cargo_Notes);
                addFlight.Parameters.AddWithValue("@DateID", Date_ID);
                var rowCount = (int?)addFlight.ExecuteNonQuery();
                if (rowCount > 0)
                {
                    MessageBox.Show("Flight Sucessfully Added.", "Flight Added", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Flight already exist", "Flight Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Add Flights to Master
        /// </summary>
        public void MasterScheduleAdd()
        {

            foreach (var day in DayOfWeek)
            {
                using (SqlConnection conn = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
                {
                    conn.Open();
                    SqlCommand executeFlightAdder = new SqlCommand("Add_Flight_To_Master_Schedule", conn);
                    executeFlightAdder.CommandType = CommandType.StoredProcedure;
                    executeFlightAdder.Parameters.AddWithValue("@Day_Of_Week", day);
                    executeFlightAdder.Parameters.AddWithValue("@FlightNumber", Flight_Number);
                    executeFlightAdder.Parameters.AddWithValue("@Departure", Departure);
                    executeFlightAdder.Parameters.AddWithValue("@Routing", Main_Routing);
                    executeFlightAdder.ExecuteNonQuery();
                }               
            }
            MessageBox.Show("Flight Sucessfully Added | Edited", "Save Sucessful", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        /// Check if user inputs valid time. 24-Hour format
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
