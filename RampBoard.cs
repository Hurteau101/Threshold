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

        private int rowIndex = 0;
        public string FullName { get; set; }
        public string FlightNumber { get; set; }

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

        private void dgvRampBoard_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Open right click menu on Datagridview. 
            if(e.Button == MouseButtons.Right)
            {
                this.dgvRampBoard.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.dgvRampBoard.CurrentCell = this.dgvRampBoard.Rows[e.RowIndex].Cells[1];
                this.dgvMenuStripFlights.Show(this.dgvRampBoard, e.Location);
                dgvMenuStripFlights.Show(Cursor.Position);

                // Store flight number, depending on what flight number you click on Datagridview. 
                FlightNumber = dgvRampBoard.Rows[e.RowIndex].Cells["FlightNumber"].Value.ToString(); 
            }
        }

        private void subMenuDeleteFlight_Click(object sender, EventArgs e)
        {
            RampDeleteFlight deleteFlight = new RampDeleteFlight();
            deleteFlight.FlightNumber = FlightNumber; 
            deleteFlight.Date = dateTimeRamp.Value.Date;
            deleteFlight.DeletingFight(deleteFlight.FlightNumber, deleteFlight.Date);
        }
    }
}
