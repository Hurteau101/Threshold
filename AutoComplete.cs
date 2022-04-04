using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perimeter_Threshold
{
    public class AutoComplete
    {
        public TextBox FlightNumber { get; set; }
        public TextBox Aircraft { get; set; }
        public TextBox Routing { get; set; }
        public TextBox Departure { get; set; }
        public TextBox FlightLead { get; set; }
        public TextBox ALCRemark { get; set; }
        public TextBox RampRemark { get; set; }

        public AutoComplete(TextBox flightNumber, TextBox aircaft, TextBox routing, TextBox departure, TextBox flightLead, TextBox alcRemark, TextBox rampRemark)
        {
            FlightNumber = flightNumber;
            Aircraft = aircaft;
            Routing = routing;
            Departure = departure; 
            FlightLead = flightLead;
            ALCRemark = alcRemark;
            RampRemark = rampRemark;
        }

        /// <summary>
        /// Pull flight information from database, and autofill flight number into textbox.
        /// </summary>
        /// <param name="flight"></param>
        /// <returns></returns>
        public AutoCompleteStringCollection AutoCompleteFlight(TextBox flight)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionLoader.ConnectionString("Loadplanner")))
            {
                AutoCompleteStringCollection flightCollection = new AutoCompleteStringCollection();

                connection.Open();
                SqlCommand flights = new SqlCommand("SELECT DISTINCT FlightNumber FROM RampBoard", connection);
                SqlDataReader readFlights = flights.ExecuteReader();
                while (readFlights.Read())
                {
                    flightCollection.Add(readFlights["FlightNumber"].ToString());
                }

                return flight.AutoCompleteCustomSource = flightCollection;
            }
        }

        /// <summary>
        /// Pull aircraft information from database, and autofill aircraft textbox.
        /// </summary>
        /// <param name="aircraft"></param>
        /// <returns></returns>
        public AutoCompleteStringCollection AutoCompleteAircraft(TextBox aircraft)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionLoader.ConnectionString("Loadplanner")))
            {
                AutoCompleteStringCollection aircraftCollection = new AutoCompleteStringCollection();

                connection.Open();
                SqlCommand aircrafts = new SqlCommand("SELECT DISTINCT AC FROM AircraftInformation", connection);
                SqlDataReader readAircraft = aircrafts.ExecuteReader();
                while (readAircraft.Read())
                {
                    aircraftCollection.Add(readAircraft["AC"].ToString());
                }

                return aircraft.AutoCompleteCustomSource = aircraftCollection;
            }
        }

        /// <summary>
        /// Pull routing information from database, and autofill routing textbox.
        /// </summary>
        /// <param name="routing"></param>
        /// <returns></returns>
        public AutoCompleteStringCollection AutoCompleteRouting(TextBox routing)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionLoader.ConnectionString("Loadplanner")))
            {
                AutoCompleteStringCollection routingCollection = new AutoCompleteStringCollection();

                connection.Open();
                SqlCommand routings = new SqlCommand("SELECT DISTINCT Routing FROM RampBoard", connection);
                SqlDataReader readRouting = routings.ExecuteReader();
                while (readRouting.Read())
                {
                    routingCollection.Add(readRouting["Routing"].ToString());
                }

                return routing.AutoCompleteCustomSource = routingCollection;
            }
        }

        /// <summary>
        /// Pull departure information from database, and autofill departure textbox.
        /// </summary>
        /// <param name="depature"></param>
        /// <returns></returns>
        public AutoCompleteStringCollection AutoCompleteDeparture(TextBox depature)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionLoader.ConnectionString("Loadplanner")))
            {
                AutoCompleteStringCollection departureCollection = new AutoCompleteStringCollection();

                connection.Open();
                SqlCommand departures = new SqlCommand("SELECT DISTINCT Departure FROM RampBoard", connection);
                SqlDataReader readDepartures = departures.ExecuteReader();
                while (readDepartures.Read())
                {
                    departureCollection.Add(readDepartures["Departure"].ToString());
                }

                return depature.AutoCompleteCustomSource = departureCollection;
            }
        }

        /// <summary>
        /// Pull flight lead information from database, and autofill flight lead textbox.
        /// </summary>
        /// <param name="flightLead"></param>
        /// <returns></returns>
        public AutoCompleteStringCollection AutoCompleteFlightLead(TextBox flightLead)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionLoader.ConnectionString("Loadplanner")))
            {
                AutoCompleteStringCollection flightLeadCollection = new AutoCompleteStringCollection();

                connection.Open();
                SqlCommand flightLeads = new SqlCommand("SELECT DISTINCT FlightLead FROM RampBoard", connection);
                SqlDataReader readFlightLeads = flightLeads.ExecuteReader();
                while (readFlightLeads.Read())
                {
                    flightLeadCollection.Add(readFlightLeads["FlightLead"].ToString());
                }

                return flightLead.AutoCompleteCustomSource = flightLeadCollection;
            }
        }

        /// <summary>
        /// Pull ALC Remark information from database, and autofill ALC remark textbox.
        /// </summary>
        /// <param name="alcRemark"></param>
        /// <returns></returns>
        public AutoCompleteStringCollection AutoCompleteALCRemark(TextBox alcRemark)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionLoader.ConnectionString("Loadplanner")))
            {
                AutoCompleteStringCollection alcRemarkCollection = new AutoCompleteStringCollection();

                connection.Open();
                SqlCommand alcRemarks = new SqlCommand("SELECT DISTINCT ALCRemarks FROM RampBoard", connection);
                SqlDataReader readALCRemarks = alcRemarks.ExecuteReader();
                while (readALCRemarks.Read())
                {
                    alcRemarkCollection.Add(readALCRemarks["ALCRemarks"].ToString());
                }

                return alcRemark.AutoCompleteCustomSource = alcRemarkCollection;
            }
        }

        /// <summary>
        /// Pull ramp remark information from database, and autofill Ramp Remark textbox.
        /// </summary>
        /// <param name="rampRemarks"></param>
        /// <returns></returns>
        public AutoCompleteStringCollection AutoCompleteRampRemarks(TextBox rampRemarks)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionLoader.ConnectionString("Loadplanner")))
            {
                AutoCompleteStringCollection rampCollection = new AutoCompleteStringCollection();

                connection.Open();
                SqlCommand ramp = new SqlCommand("SELECT DISTINCT RampRemarks FROM RampBoard", connection);
                SqlDataReader readRamp = ramp.ExecuteReader();
                while (readRamp.Read())
                {
                    rampCollection.Add(readRamp["RampRemarks"].ToString());
                }

                return rampRemarks.AutoCompleteCustomSource = rampCollection;
            }
        }
    }
}
