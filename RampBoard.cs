using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Perimeter_Threshold
{
    public partial class RampBoard : Form
    {

        public RampBoard()
        {
            InitializeComponent();
        }

        public string FullName { get; set; }

        /// <summary>
        /// Load Ramp Board
        /// </summary>
        private void LoadRampBoard()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionLoader.ConnectionString("LoadPlanner")))
            {
                SqlCommand loadRampData = new SqlCommand("SELECT FlightNumber, Aircraft, Routing, Departure, " +
                    "ActualDep, Arrival, FlightLead, DelayReason, ALCRemarks, RampRemarks FROM RampBoard " +
                    " WHERE DateID = @DateID", connection);
                loadRampData.Parameters.AddWithValue("@DateID", DateTime.Today.AddDays(-1).ToString("d"));
                SqlDataAdapter dataAdapter = new SqlDataAdapter(loadRampData);
                DataSet dset = new DataSet();
                connection.Open();
                dataAdapter.Fill(dset, "RampBoard");
                dgvRampBoard.DataSource = dset;
                dgvRampBoard.DataMember = "RampBoard";
            }
        }

        private void RampBoard_Load(object sender, EventArgs e)
        {
            // Load Name of User.
            lblUser.Text = Name;

            LoadRampBoard();
        }

        private void subMenuAddFlight_Click(object sender, EventArgs e)
        {
            AddFlight_Ramp addFlight = new AddFlight_Ramp();
            DateTimeFormater.DateDisplay = dateTimeRamp.Value.Date;
            addFlight.Show();
            
        }
    }
}
