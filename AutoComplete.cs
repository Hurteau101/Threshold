using System.Data.SqlClient;
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
        public TextBox Notes { get; set; }
        public TextBox ProjectWeight { get; set; }

        public AutoComplete(TextBox flightNumber, TextBox aircraft, TextBox routing, TextBox departure, TextBox flightLead, TextBox alcRemark, TextBox rampRemark)
        {
            FlightNumber = flightNumber;
            Aircraft = aircraft;
            Routing = routing;
            Departure = departure;
            FlightLead = flightLead;
            ALCRemark = alcRemark;
            RampRemark = rampRemark;
        }

        public AutoComplete(TextBox flightNumber, TextBox aircraft, TextBox routing, TextBox departure, TextBox projectWeight, TextBox notes)
        {
            FlightNumber = flightNumber;
            Aircraft = aircraft;
            Routing = routing;
            Departure = departure;
            Notes = notes;
            ProjectWeight = projectWeight;
        }

        /// <summary>
        /// Pull flight information from database, and autofill flight number into textbox.
        /// </summary>
        /// <param name="flight"></param>
        /// <returns></returns>
        public AutoCompleteStringCollection AutoCompleteFlight(TextBox flight)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                AutoCompleteStringCollection flightCollection = new AutoCompleteStringCollection();

                connection.Open();
                SqlCommand flights = new SqlCommand("SELECT DISTINCT Flight_Number FROM Ramp_Board", connection);
                SqlDataReader readFlights = flights.ExecuteReader();
                while (readFlights.Read())
                {
                    flightCollection.Add(readFlights["Flight_Number"].ToString());
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
            using (SqlConnection connection = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                AutoCompleteStringCollection aircraftCollection = new AutoCompleteStringCollection();

                connection.Open();
                SqlCommand aircrafts = new SqlCommand("SELECT DISTINCT Aircraft FROM Aircrafts", connection);
                SqlDataReader readAircraft = aircrafts.ExecuteReader();
                while (readAircraft.Read())
                {
                    aircraftCollection.Add(readAircraft["Aircraft"].ToString());
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
            using (SqlConnection connection = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                AutoCompleteStringCollection routingCollection = new AutoCompleteStringCollection();

                connection.Open();
                SqlCommand routings = new SqlCommand("SELECT DISTINCT Routing FROM Ramp_Board", connection);
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
            using (SqlConnection connection = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                AutoCompleteStringCollection departureCollection = new AutoCompleteStringCollection();

                connection.Open();
                SqlCommand departures = new SqlCommand("SELECT DISTINCT Departure FROM Ramp_Board", connection);
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
            using (SqlConnection connection = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                AutoCompleteStringCollection flightLeadCollection = new AutoCompleteStringCollection();

                connection.Open();
                SqlCommand flightLeads = new SqlCommand("SELECT DISTINCT Flight_Lead FROM Ramp_Board", connection);
                SqlDataReader readFlightLeads = flightLeads.ExecuteReader();
                while (readFlightLeads.Read())
                {
                    flightLeadCollection.Add(readFlightLeads["Flight_Lead"].ToString());
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
            using (SqlConnection connection = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                AutoCompleteStringCollection alcRemarkCollection = new AutoCompleteStringCollection();

                connection.Open();
                SqlCommand alcRemarks = new SqlCommand("SELECT DISTINCT Load_Coordinator_Remarks FROM Ramp_Board", connection);
                SqlDataReader readALCRemarks = alcRemarks.ExecuteReader();
                while (readALCRemarks.Read())
                {
                    alcRemarkCollection.Add(readALCRemarks["Load_Coordinator_Remarks"].ToString());
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
            using (SqlConnection connection = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                AutoCompleteStringCollection rampCollection = new AutoCompleteStringCollection();

                connection.Open();
                SqlCommand ramp = new SqlCommand("SELECT DISTINCT Ramp_Remarks FROM Ramp_Board", connection);
                SqlDataReader readRamp = ramp.ExecuteReader();
                while (readRamp.Read())
                {
                    rampCollection.Add(readRamp["Ramp_Remarks"].ToString());
                }

                return rampRemarks.AutoCompleteCustomSource = rampCollection;
            }
        }

        /// <summary>
        /// Pull Cargo note information from database, and autofill Cargo Notes textbox.
        /// </summary>
        /// <param name="cargoRemarks"></param>
        /// <returns></returns>
        public AutoCompleteStringCollection AutoCompleteCargoNotes(TextBox cargoRemarks)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                AutoCompleteStringCollection noteCollection = new AutoCompleteStringCollection();

                connection.Open();
                SqlCommand cargoNotes = new SqlCommand("SELECT DISTINCT Cargo_Notes FROM Cargo_Board", connection);
                SqlDataReader readNotes = cargoNotes.ExecuteReader();
                while (readNotes.Read())
                {
                    noteCollection.Add(readNotes["Cargo_Notes"].ToString());
                }

                return cargoRemarks.AutoCompleteCustomSource = noteCollection;
            }
        }

        /// <summary>
        /// Pull Cargo Project Weight information from database, and autofill Cargo Project Weight textbox.
        /// </summary>
        /// <param name="projectWeight"></param>
        /// <returns></returns>
        public AutoCompleteStringCollection AutoCompleteProjectWeight(TextBox projectWeight)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                AutoCompleteStringCollection weightCollection = new AutoCompleteStringCollection();

                connection.Open();
                SqlCommand cargoWeight = new SqlCommand("SELECT DISTINCT Weight_Given FROM Cargo_Board", connection);
                SqlDataReader readWeight = cargoWeight.ExecuteReader();
                while (readWeight.Read())
                {
                    weightCollection.Add(readWeight["Weight_Given"].ToString());
                }

                return projectWeight.AutoCompleteCustomSource = weightCollection;
            }
        }
    }
}
