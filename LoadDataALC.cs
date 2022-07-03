using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using Dapper;

namespace Perimeter_Threshold
{
    public class LoadDataALC
    {
        public DateTime Date { get; set; }
        public int NumberOfLegs { get; set; }

        public LoadDataALC(DateTime date)
        {
            Date = date;
        }

        public LoadDataALC()
        {

        }

        /// <summary>
        /// Load Flight Numbers from ALC Flight Schedule and populate Combobox. 
        /// </summary>
        /// <param name="flightNumbers"></param>
        public void LoadFlightNumber(ComboBox flightNumbers)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                conn.Open();
                SqlCommand loadFlightNumbers = new SqlCommand("Load_Flight_Numbers", conn);
                loadFlightNumbers.CommandType = CommandType.StoredProcedure;
                loadFlightNumbers.Parameters.AddWithValue("@DateID", Date);
                SqlDataAdapter adapter = new SqlDataAdapter(loadFlightNumbers);
                DataSet ds = new DataSet();
                 adapter.Fill(ds);
                loadFlightNumbers.ExecuteNonQuery();

                flightNumbers.DataSource = ds.Tables[0];
                flightNumbers.DisplayMember = "Flight_Number";
                flightNumbers.ValueMember = "Date_ID";
            }
        }

        /// <summary>
        /// Load Aircraft type from database and populate Combobox
        /// </summary>
        /// <param name="aircraftType"></param>
        public void LoadAircraftType(ComboBox aircraftType)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                conn.Open();
                SqlCommand loadAircraftTYPE = new SqlCommand("Load_Aircraft_Type", conn);
                loadAircraftTYPE.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(loadAircraftTYPE);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                loadAircraftTYPE.ExecuteNonQuery();

                aircraftType.DataSource = ds.Tables[0];
                aircraftType.DisplayMember = "Aircraft_Type";
                aircraftType.ValueMember = "Aircraft_Type";
            }
        }

        /// <summary>
        /// Load Aircraft from database and populate Combobox
        /// </summary>
        /// <param name="aircaft"></param>
        /// <param name="aircraftType"></param>
        public void LoadAircraft(ComboBox aircaft, ComboBox aircraftType)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                conn.Open();
                SqlCommand loadAircraft = new SqlCommand("Load_Aicraft", conn);
                loadAircraft.CommandType = CommandType.StoredProcedure;
                loadAircraft.Parameters.AddWithValue("@Aircraft_Type", aircraftType.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(loadAircraft);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                loadAircraft.ExecuteNonQuery();

                aircaft.DataSource = ds.Tables[0];
                aircaft.DisplayMember = "Aircraft";
                aircaft.ValueMember = "Aircraft";
            }
        }

        /// <summary>
        /// Load Crew from database and populate Combobox
        /// </summary>
        /// <param name="crew"></param>
        /// <param name="aircraftType"></param>
        public void LoadCrew(ComboBox crew, ComboBox aircraftType)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                conn.Open();
                SqlCommand loadAircraft = new SqlCommand("Load_Crew", conn);
                loadAircraft.CommandType = CommandType.StoredProcedure;
                loadAircraft.Parameters.AddWithValue("@Aircraft_Type", aircraftType.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(loadAircraft);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                loadAircraft.ExecuteNonQuery();

                crew.DataSource = ds.Tables[0];
                crew.DisplayMember = "Crew";
                crew.ValueMember = "Crew";
            }
        }

        /// <summary>
        /// Load Aircraft weight from database and populate Textbox
        /// </summary>
        /// <param name="crew"></param>
        /// <param name="aircraftType"></param>
        /// <param name="aircraftWeight"></param>
        public void LoadAircraftWeight(ComboBox crew, ComboBox aircraftType, TextBox aircraftWeight, ComboBox aircraft)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                conn.Open();
                SqlCommand loadWeight = new SqlCommand("Load_Aircraft_Weight", conn);
                loadWeight.CommandType = CommandType.StoredProcedure;
                loadWeight.Parameters.AddWithValue("@Aircraft_Type", aircraftType.Text);
                loadWeight.Parameters.AddWithValue("@Crew", crew.Text);
                loadWeight.Parameters.AddWithValue("@Aircraft", aircraft.Text);
                SqlDataReader readWeight = loadWeight.ExecuteReader();
                if (readWeight.Read())
                {
                    aircraftWeight.Text = (readWeight["Aircraft_Weight"].ToString());
                }
            }
        }

        /// <summary>
        /// Load Routing for each Leg, when you click each leg tab. 
        /// </summary>
        /// <param name="flightNumber"></param>
        /// <param name="routing"></param>
        /// <param name="tabs"></param>
        /// <param name="pages"></param>
        public void LoadLegRoutings(ComboBox flightNumber, TextBox routing, TabControl tabs, List<TabPage> pages)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                conn.Open();
                SqlCommand loadRoutings = new SqlCommand("Load_Leg_Routings", conn);
                loadRoutings.CommandType = CommandType.StoredProcedure;
                loadRoutings.Parameters.AddWithValue("@FlightNumber", flightNumber.Text);
                loadRoutings.Parameters.AddWithValue("@DateID", Date);
                SqlDataReader readRouting = loadRoutings.ExecuteReader();
                if (readRouting.Read())
                {
                    if (tabs.SelectedTab == pages[0])
                    {
                        routing.Text = (readRouting["Leg1_Routing"].ToString());
                    }
                    else if (tabs.SelectedTab == pages[1])
                    {
                        routing.Text = (readRouting["Leg2_Routing"].ToString());
                    }
                    else if (tabs.SelectedTab == pages[2])
                    {
                        routing.Text = (readRouting["Leg3_Routing"].ToString());
                    }
                    else if (tabs.SelectedTab == pages[3])
                    {
                        routing.Text = (readRouting["Leg4_Routing"].ToString());
                    }
                    else if (tabs.SelectedTab == pages[4])
                    {
                        routing.Text = (readRouting["Leg5_Routing"].ToString());
                    }
                    else if (tabs.SelectedTab == pages[5])
                    {
                        routing.Text = (readRouting["Leg6_Routing"].ToString());
                    }
                }
            }
        }

        /// <summary>
        /// Load number of legs to display. 
        /// </summary>
        /// <param name="flightNumber"></param>
        public void LoadLegNumber(ComboBox flightNumber)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                conn.Open();
                SqlCommand loadLegNumber = new SqlCommand("Load_Number_Of_Legs", conn);
                loadLegNumber.CommandType = CommandType.StoredProcedure;
                loadLegNumber.Parameters.AddWithValue("@FlightNumber", flightNumber.Text);
                loadLegNumber.Parameters.AddWithValue("@DateID", Date);
                SqlDataReader readNumberLegs = loadLegNumber.ExecuteReader();
                if (readNumberLegs.Read())
                {
                    NumberOfLegs = Convert.ToInt32((readNumberLegs["Number_Of_Legs"]));
                    LoadPlanner.NumberOfLegs = NumberOfLegs; // Store number of legs, to be used when saving data. 

                }
            }
        }

        /// <summary>
        /// Show only the appropriate amount of legs. 
        /// </summary>
        /// <param name="tabs"></param>
        /// <param name="pages"></param>
        public void ShowNumberOfTabs(TabControl tabs, List<TabPage> pages)
        {
            if (NumberOfLegs == 1)
            {
                tabs.TabPages.Clear();
                tabs.TabPages.Add(pages[0]);
            }
            else if (NumberOfLegs == 2)
            {
                tabs.TabPages.Clear();
                tabs.TabPages.Add(pages[0]);
                tabs.TabPages.Add(pages[1]);
            }
            else if (NumberOfLegs == 3)
            {
                tabs.TabPages.Clear();
                tabs.TabPages.Add(pages[0]);
                tabs.TabPages.Add(pages[1]);
                tabs.TabPages.Add(pages[2]);
            }
            else if (NumberOfLegs == 4)
            {
                tabs.TabPages.Clear();
                tabs.TabPages.Add(pages[0]);
                tabs.TabPages.Add(pages[1]);
                tabs.TabPages.Add(pages[2]);
                tabs.TabPages.Add(pages[3]);
            }
            else if (NumberOfLegs == 5)
            {
                tabs.TabPages.Clear();
                tabs.TabPages.Add(pages[0]);
                tabs.TabPages.Add(pages[1]);
                tabs.TabPages.Add(pages[2]);
                tabs.TabPages.Add(pages[3]);
                tabs.TabPages.Add(pages[4]);
            }
            else if (NumberOfLegs == 6)
            {
                tabs.TabPages.Clear();
                tabs.TabPages.Add(pages[0]);
                tabs.TabPages.Add(pages[1]);
                tabs.TabPages.Add(pages[2]);
                tabs.TabPages.Add(pages[3]);
                tabs.TabPages.Add(pages[4]);
                tabs.TabPages.Add(pages[5]);
            }
        }

        /// <summary>
        /// Load Zero Fuel Weight for Aircraft from database. 
        /// </summary>
        /// <param name="aircraft"></param>
        /// <param name="zeroFuelWeight"></param>
        public void LoadZeroFuelWeight(ComboBox aircraft, List<TextBox> zeroFuelWeight)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                conn.Open();
                SqlCommand loadZFW = new SqlCommand("Load_Zero_Fuel_Weight", conn);
                loadZFW.CommandType = CommandType.StoredProcedure;
                loadZFW.Parameters.AddWithValue("@Aircraft", aircraft.Text);
                SqlDataReader readerZFW = loadZFW.ExecuteReader();
                if (readerZFW.Read())
                {
                    foreach (var aircraftZFW in zeroFuelWeight)
                    {
                        aircraftZFW.Text = (readerZFW["Zero_Fuel_Weight"].ToString());
                    }
                }
            }
        }

        /// <summary>
        /// Load Taxi Burn for Aircraft from database.
        /// </summary>
        /// <param name="aircraft"></param>
        /// <param name="taxiBurn"></param>
        public void LoadTaxiBurn(ComboBox aircraft, List<TextBox> taxiBurn)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                conn.Open();
                SqlCommand loadTaxiBurn = new SqlCommand("Load_Taxi_Burn", conn);
                loadTaxiBurn.CommandType = CommandType.StoredProcedure;
                loadTaxiBurn.Parameters.AddWithValue("@Aircraft", aircraft.Text);
                SqlDataReader readTaxiBurn = loadTaxiBurn.ExecuteReader();
                if (readTaxiBurn.Read())
                {
                    foreach (var aircraftTaxiBurn in taxiBurn)
                    {
                        aircraftTaxiBurn.Text = (readTaxiBurn["Taxi_Burn"].ToString());
                    }
                }
            }
        }

        /// <summary>
        /// Load Equipment for Aircraft from database.
        /// </summary>
        /// <param name="aircraft"></param>
        /// <param name="equipment"></param>
        public void LoadEquipment(ComboBox aircraft, List<TextBox> equipment)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                conn.Open();
                SqlCommand loadEquipment = new SqlCommand("Load_Equipment", conn);
                loadEquipment.CommandType = CommandType.StoredProcedure;
                loadEquipment.Parameters.AddWithValue("@Aircraft", aircraft.Text);
                SqlDataReader readEquipment = loadEquipment.ExecuteReader();
                if (readEquipment.Read())
                {
                    foreach (var aircraftEquipment in equipment)
                    {
                        aircraftEquipment.Text = (readEquipment["Equipment"].ToString());
                    }
                }
                else
                {
                    foreach (var aircraftEquipment in equipment)
                    {
                        aircraftEquipment.Text = "0";
                    }
                }
            }
        }

        /// <summary>
        /// Load aircraft configuration from database. 
        /// </summary>
        /// <param name="aircraft"></param>
        /// <param name="configuration"></param>
        public void LoadAircraftConfiguration(ComboBox aircraft, List<TextBox> configuration)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                conn.Open();
                SqlCommand loadAircraftConfig = new SqlCommand("Load_Aircraft_Configuration", conn);
                loadAircraftConfig.CommandType = CommandType.StoredProcedure;
                loadAircraftConfig.Parameters.AddWithValue("@Aircraft", aircraft.Text);
                SqlDataReader readAircraftConfig = loadAircraftConfig.ExecuteReader();
                if (readAircraftConfig.Read())
                {
                    foreach (var aircraftConfiguration in configuration)
                    {
                        aircraftConfiguration.Text = (readAircraftConfig["Aircraft_Configuration"].ToString());
                    }
                }
            }
        }

        /// <summary>
        /// Load Previous Aircraft from Database
        /// </summary>
        /// <param name="flightNumber"></param>
        /// <param name="legNumber"></param>
        /// <param name="aircraft"></param>
        public void LoadPreviousAircraft(ComboBox flightNumber, int legNumber, ComboBox aircraft)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                conn.Open();
                SqlCommand loadPreviousAircraft = new SqlCommand("Load_Previous_Aircraft", conn);
                loadPreviousAircraft.CommandType = CommandType.StoredProcedure;
                loadPreviousAircraft.Parameters.AddWithValue("@FlightNumber", flightNumber.Text);
                loadPreviousAircraft.Parameters.AddWithValue("@DateID", Date);
                loadPreviousAircraft.Parameters.AddWithValue("@LegNumber", legNumber);
                SqlDataReader readPreviousAircraft = loadPreviousAircraft.ExecuteReader();
                if (readPreviousAircraft.Read())
                {
                    aircraft.Text = (readPreviousAircraft["Aircraft"].ToString());

                }
                else
                {
                    aircraft.SelectedIndex = -1;
                }
            }
        }

        /// <summary>
        /// Load Previous Aircraft Type from Database. 
        /// </summary>
        /// <param name="flightNumber"></param>
        /// <param name="legNumber"></param>
        /// <param name="aircraftType"></param>
        public void LoadPreviousAircraftType(ComboBox flightNumber, int legNumber, ComboBox aircraftType)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                conn.Open();
                SqlCommand loadPreviousAircraftType = new SqlCommand("Load_Previous_AircraftType", conn);
                loadPreviousAircraftType.CommandType = CommandType.StoredProcedure;
                loadPreviousAircraftType.Parameters.AddWithValue("@FlightNumber", flightNumber.Text);
                loadPreviousAircraftType.Parameters.AddWithValue("@DateID", Date);
                loadPreviousAircraftType.Parameters.AddWithValue("@LegNumber", legNumber);
                SqlDataReader readPreviousAircraftType = loadPreviousAircraftType.ExecuteReader();
                if (readPreviousAircraftType.Read())
                {
                    aircraftType.Text = (readPreviousAircraftType["Aircraft_Type"].ToString());

                }
                else
                {
                    aircraftType.SelectedIndex = -1;
                }
            }
        }

        /// <summary>
        /// Load Previous Crew from Database. 
        /// </summary>
        /// <param name="flightNumber"></param>
        /// <param name="legNumber"></param>
        /// <param name="crew"></param>
        public void LoadPreviousCrew(ComboBox flightNumber, int legNumber, ComboBox crew)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                conn.Open();
                SqlCommand loadPreviousCrew = new SqlCommand("Load_Previous_Crew", conn);
                loadPreviousCrew.CommandType = CommandType.StoredProcedure;
                loadPreviousCrew.Parameters.AddWithValue("@FlightNumber", flightNumber.Text);
                loadPreviousCrew.Parameters.AddWithValue("@DateID", Date);
                loadPreviousCrew.Parameters.AddWithValue("@LegNumber", legNumber);
                SqlDataReader readPreviousCrew = loadPreviousCrew.ExecuteReader();
                if (readPreviousCrew.Read())
                {
                    crew.Text = (readPreviousCrew["Crew"].ToString());

                }
                else
                {
                    crew.SelectedIndex = -1;
                }
            }
        }

        /// <summary>
        /// Load previous Aircraft Weight from Database. 
        /// </summary>
        /// <param name="flightNumber"></param>
        /// <param name="legNumber"></param>
        /// <param name="aircraftWeight"></param>
        public void LoadPreviousOEW(ComboBox flightNumber, int legNumber, TextBox aircraftWeight)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                conn.Open();
                SqlCommand loadPreviousAircraftWeight = new SqlCommand("Load_Previous_Aircraft_Weight", conn);
                loadPreviousAircraftWeight.CommandType = CommandType.StoredProcedure;
                loadPreviousAircraftWeight.Parameters.AddWithValue("@FlightNumber", flightNumber.Text);
                loadPreviousAircraftWeight.Parameters.AddWithValue("@DateID", Date);
                loadPreviousAircraftWeight.Parameters.AddWithValue("@LegNumber", legNumber);
                SqlDataReader readPreviousAircraftWeight = loadPreviousAircraftWeight.ExecuteReader();
                if (readPreviousAircraftWeight.Read())
                {
                    aircraftWeight.Text = (readPreviousAircraftWeight["Aircraft_Weight"].ToString());

                }
                else
                {
                    aircraftWeight.Text = "0";
                }
            }
        }

        /// <summary>
        /// Load previous aircraft location from database. 
        /// </summary>
        /// <param name="flightNumber"></param>
        /// <param name="location"></param>
        public void LoadPreviousAircraftLocation(ComboBox flightNumber, ComboBox location)
        {
            // Clear Combox field, so it doesn't display previous value. 
            location.SelectedIndex = -1;

            using (SqlConnection conn = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                conn.Open();
                SqlCommand loadPreviousAircraftLocation = new SqlCommand("Load_Previous_Location", conn);
                loadPreviousAircraftLocation.CommandType = CommandType.StoredProcedure;
                loadPreviousAircraftLocation.Parameters.AddWithValue("@FlightNumber", flightNumber.Text);
                loadPreviousAircraftLocation.Parameters.AddWithValue("@DateID", Date);
                SqlDataReader readPreviousLocation = loadPreviousAircraftLocation.ExecuteReader();
                if (readPreviousLocation.Read())
                {
                    location.Text = (readPreviousLocation["Aircraft_Location"].ToString());

                }
                else
                {
                    location.SelectedIndex = -1;
                }
            }
        }


        /// <summary>
        /// Load Leg information, if it doesn't find the flight in the database, auto set everything to 0.
        /// </summary>
        /// <param name="flightNumber"></param>
        /// <param name="date"></param>
        /// <param name="legNumber"></param>
        /// <returns></returns>
        public List<FlightDetail> LoadLegInformation(ComboBox flightNumber, DateTime date, int legNumber)
        {
            List<FlightDetail> flightDetailInformation = new List<FlightDetail>();
            using (IDbConnection conn = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                // Check if flight exist in database first. 
                const string sql = "SELECT CAST(CASE WHEN EXISTS (SELECT 1 FROM Load_Planner WHERE Date_ID =@Date_ID AND Flight_Number =@Flight_Number AND Leg_Number =@Leg_Number) THEN 1 ELSE 0 END as BIT)";
                bool exists = conn.ExecuteScalar<bool>(sql, new FlightDetail { Flight_Number = flightNumber.Text, Date_ID = date, Leg_Number = legNumber });

                if (exists)
                {
                    string sql2 = $"SELECT * FROM Load_Planner WHERE Date_ID =@Date_ID AND Flight_Number =@Flight_Number AND Leg_Number =@Leg_Number";

                    flightDetailInformation = conn.Query<FlightDetail>(sql2, new { Flight_Number = flightNumber.Text, Date_ID = date, Leg_Number = legNumber }).ToList();

                    return flightDetailInformation;
                }
                // Condition here, due to when you switch flights from a flight in the database to a flight that isn't, the same weights don't show up in the textboxes. 
                else
                {
                    FlightDetail emptyFlightDetails = new FlightDetail
                    {
                        Passenger_Weight = 0,
                        Bag_Weight = 0,
                        Cargo_Weight = 0,
                        Equipment = 0,
                        AWI = 0,
                        Fuel = 0,
                        Fuel_Burn = 0,
                        Contigency = 0,
                        Taxi_Burn = 0,
                        TakeOff_Weight = 0,
                        Landing_Weight = 0,
                        Passenger_Number = 0,
                        Seatpacks = 0,
                        Aircraft_Configuration = "0",
                    };

                    flightDetailInformation.Add(emptyFlightDetails);

                    return flightDetailInformation;
                }
            }
        }

        /// <summary>
        /// Store Routing and Departure Times. 
        /// </summary>
        /// <param name="flightNumber"></param>
        /// <param name="date"></param>
        public void LoadRoutingAndDeparture(ComboBox flightNumber, DateTime date)
        {
            using (IDbConnection conn = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                string sql = "SELECT Flight_Number, Date_ID, Main_Routing, Departure FROM Flight_Schedule_ALC WHERE Flight_Number =@Flight_Number AND" +
                    " Date_ID =@Date_ID";
                var loadData = conn.Query<AddFlight>(sql, new AddFlight { Flight_Number = flightNumber.Text, Date_ID = date}).ToList();


                foreach (var item in loadData)
                {
                    LoadPlanner.Departure = item.Departure;
                    LoadPlanner.Main_Routing = item.Main_Routing;
                }
            }
        }

        /// <summary>
        /// Load ramp notes into loadplanner notes. Unless its empty, then return empty field. This is to prevent from switching from a flgiht with a value to one with none. 
        /// </summary>
        /// <param name="flightNumber"></param>
        /// <param name="date"></param>
        /// <param name="note"></param>
        /// <returns></returns>
        public static void LoadRampNotes(ComboBox flightNumber, DateTime date, TextBox note, RadioButton departmentCheck)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                connection.Open();
                SqlCommand loadRampNotes = new SqlCommand("SELECT Load_Coordinator_Remarks FROM Ramp_Board WHERE Date_ID =@Date_ID AND Flight_Number =@Flight_Number", connection);
                loadRampNotes.Parameters.AddWithValue("@Date_ID", date);
                loadRampNotes.Parameters.AddWithValue("@Flight_Number", flightNumber.Text);
                SqlDataReader readNotes = loadRampNotes.ExecuteReader();
                if (readNotes.Read())
                {
                    note.Text = (readNotes["Load_Coordinator_Remarks"].ToString());
                }
                else
                {
                    note.Clear();
                }
            }
        }

        /// <summary>
        /// Load cargo notes into loadplanner notes. Unless its empty, then return empty field. This is to prevent from switching from a flgiht with a value to one with none. 
        /// </summary>
        /// <param name="flightNumber"></param>
        /// <param name="date"></param>
        /// <param name="note"></param>
        /// <returns></returns>
        public static void LoadCargoNotes(ComboBox flightNumber, DateTime date, TextBox note, RadioButton departmentCheck)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                connection.Open();
                SqlCommand loadRampNotes = new SqlCommand("SELECT Cargo_Notes FROM Cargo_Board WHERE Date_ID =@Date_ID AND Flight_Number =@Flight_Number", connection);
                loadRampNotes.Parameters.AddWithValue("@Date_ID", date);
                loadRampNotes.Parameters.AddWithValue("@Flight_Number", flightNumber.Text);
                SqlDataReader readNotes = loadRampNotes.ExecuteReader();
                if (readNotes.Read())
                {
                    note.Text = (readNotes["Cargo_Notes"].ToString());
                }
                else
                {
                    note.Clear();
                }
            }
        }

        /// <summary>
        /// Load alc notes into loadplanner notes. Unless its empty, then return empty field. This is to prevent from switching from a flgiht with a value to one with none. 
        /// </summary>
        /// <param name="flightNumber"></param>
        /// <param name="date"></param>
        /// <param name="note"></param>
        /// <param name="legNumber"></param>
        /// <returns></returns>
        public static void LoadALCNotes(ComboBox flightNumber, DateTime date, TextBox note, int legNumber)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                connection.Open();
                SqlCommand loadRampNotes = new SqlCommand("SELECT Notes FROM Load_Planner WHERE Date_ID =@Date_ID AND Flight_Number =@Flight_Number AND Leg_Number =@Leg_Number", connection);
                loadRampNotes.Parameters.AddWithValue("@Date_ID", date);
                loadRampNotes.Parameters.AddWithValue("@Flight_Number", flightNumber.Text);
                loadRampNotes.Parameters.AddWithValue("@Leg_Number", legNumber);
                SqlDataReader readNotes = loadRampNotes.ExecuteReader();
                if (readNotes.Read())
                {
                    note.Text = (readNotes["Notes"].ToString());
                }
                else
                {
                    note.Clear();
                }
            }
        }
    }
}

