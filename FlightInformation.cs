using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Perimeter_Threshold
{
    public partial class FlightInformation : Form
    {
        public FlightInformation()
        {
            InitializeComponent();
        }

        public string NameOfBoard { get; set; }
        public DateTime Date { get; set; }
        public string FlightNumber { get; set; }

        public FlightInformation(string nameOfBoard, DateTime date, string flightNumber)
        {
            NameOfBoard = nameOfBoard;
            Date = date;
            FlightNumber = flightNumber;
        }

        /// <summary>
        /// Check which board is loaded and call the appropariate methods. 
        /// </summary>
        private void FlightInformationLoader()
        {
            if (NameOfBoard == "Cargo")
            {
                LoadRampInformation();
                lblCargo_Ramp.Text = "Ramp Lead";
            }
            else if (NameOfBoard == "Ramp")
            {
                LoadCargoInformation();
                lblCargo_Ramp.Text = "Cargo Preload";
            }

            LoadALCInformation();
        }

        /// <summary>
        /// Load ALC Information. 
        /// </summary>
        private void LoadALCInformation()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                conn.Open();
                SqlCommand loadInformation = new SqlCommand("SELECT Passenger_Number, Bag_Weight FROM Load_Planner WHERE Date_ID =@Date_ID AND Flight_Number =@Flight_Number AND Leg_Number =@Leg_Number", conn);
                loadInformation.Parameters.AddWithValue("@Date_ID", Date);
                loadInformation.Parameters.AddWithValue("@Flight_Number", cbFlightNo.Text);
                loadInformation.Parameters.AddWithValue("@Leg_Number", 1);
                SqlDataReader readInformation = loadInformation.ExecuteReader();
                if (readInformation.Read())
                {
                    tbPaxNum.Text = (readInformation["Passenger_Number"].ToString());
                    tbBags.Text = (readInformation["Bag_Weight"].ToString());
                }
                else
                {
                    tbPaxNum.Text = "No Info Yet";
                    tbBags.Text = "No Info Yet";
                }
            }
        }

        /// <summary>
        /// Check if flight exist first. 
        /// </summary>
        /// <returns></returns>
        public bool CheckFlightExistence()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                conn.Open();
                SqlCommand checkFlightExist = new SqlCommand("SELECT Flight_Number FROM Load_Planner WHERE Date_ID =@Date_ID AND Flight_Number =@Flight_Number", conn);
                checkFlightExist.Parameters.AddWithValue("@Flight_Number", FlightNumber);
                checkFlightExist.Parameters.AddWithValue("@Date_ID", Date);
                SqlDataReader readFlight = checkFlightExist.ExecuteReader();
                if (!readFlight.Read())
                {
                    MessageBox.Show("Unable to find flight information", "No Flight Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return true;
            }
        }

        /// <summary>
        /// Load Ramp Board information. 
        /// </summary>
        private void LoadRampInformation()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                conn.Open();
                SqlCommand loadInformation = new SqlCommand("SELECT Flight_Lead FROM Ramp_Board WHERE Date_ID =@Date_ID AND Flight_Number =@Flight_Number", conn);
                loadInformation.Parameters.AddWithValue("@Date_ID", Date);
                loadInformation.Parameters.AddWithValue("@Flight_Number", cbFlightNo.Text);
                SqlDataReader readInformation = loadInformation.ExecuteReader();
                if (readInformation.Read())
                {
                    var rampLead = (readInformation["Flight_Lead"].ToString());

                    if (string.IsNullOrEmpty(rampLead))
                    {
                        tbCargo_Lead.Text = "No Info Yet";
                    }
                    else
                    {
                        tbCargo_Lead.Text = rampLead;
                    }
                }
                else
                {
                    tbCargo_Lead.Text = "No Info Yet";
                }
            }
        }

        /// <summary>
        /// Load Cargo Board Information. 
        /// </summary>
        private void LoadCargoInformation()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                conn.Open();
                SqlCommand loadInformation = new SqlCommand("SELECT Weight_Given FROM Cargo_Board WHERE Date_ID =@Date_ID AND Flight_Number =@Flight_Number", conn);
                loadInformation.Parameters.AddWithValue("@Date_ID", Date);
                loadInformation.Parameters.AddWithValue("@Flight_Number", cbFlightNo.Text);
                SqlDataReader readInformation = loadInformation.ExecuteReader();
                if (readInformation.Read())
                {
                    tbCargo_Lead.Text = (readInformation["Weight_Given"].ToString());
                }
                else
                {
                    tbCargo_Lead.Text = "No Info Yet";
                }
            }
        }


        private void FlightInformation_Load(object sender, EventArgs e)
        {
            LoadDataALC loadFlightNumber = new LoadDataALC();
            loadFlightNumber.Date = Date;
            loadFlightNumber.LoadFlightNumber(cbFlightNo);
            cbFlightNo.Text = FlightNumber;
        }

        private void cbFlightNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            FlightInformationLoader();
        }
    }
}
