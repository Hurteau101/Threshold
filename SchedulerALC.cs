using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Perimeter_Threshold
{
    public partial class SchedulerALC : Form
    {
        // Setting global variables for DataGridView.
        SqlDataAdapter dataAdapter;
        DataTable dt;
        DataSet dset;
        SqlCommandBuilder scb;

        public string FlightNumber { get; set; }
        private int rowIndex = 0; // Set row index, for right clicking on flights.
        public bool FormLoadded = false;

        public SchedulerALC()
        {
            InitializeComponent();
        }
        public void ALCScheduleLoader()
        {
            SqlConnection connection = new SqlConnection(ConnectionLoader.ConnectionString("Threshold"));
            connection.Open();
            SqlCommand selectCargoBoard = new SqlCommand("Load_ALC_Schedule", connection);
            selectCargoBoard.CommandType = CommandType.StoredProcedure;
            selectCargoBoard.Parameters.AddWithValue("@DateID", dateTimeALC.Value.Date);
            dt = new DataTable();
            dataAdapter = new SqlDataAdapter(selectCargoBoard);
            dset = new DataSet();
            dataAdapter.Fill(dset, "Flight_Schedule_ALC");
            BoardStyling.RowSizeMode(dgvSchedulerALC);
            BoardStyling.GridviewMinimumRowSize(dgvSchedulerALC); // Insertion done here, as you need to do it before binding. 
            dgvSchedulerALC.DataSource = dset.Tables[0];

            ALCBoardStyling style = new ALCBoardStyling();
            style.HeaderRename(dgvSchedulerALC);
            style.HideHeader(dgvSchedulerALC);            
            BoardStyling.UnsortableColumns(dgvSchedulerALC);
            BoardStyling.GridViewColumnMode(dgvSchedulerALC);
            BoardStyling.ColumnSortDirection(dgvSchedulerALC);
            BoardStyling.GridviewStyling(dgvSchedulerALC);        
        }

        private void SchedulerALC_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            // Format Date Display.
            DateTimeFormater.DateTimeDisplay(dateTimeALC);
            DateTimeFormater.AutoSetDate(dateTimeALC);

            SchedulerLoaderChecks.SchedulerLoaderCheckALC(dateTimeALC);
            ALCScheduleLoader();

            // Set this to true only when form loads. This is to ensure re-size form event doesn't crash. 
            FormLoadded = true;
        }

        private void dateTimeALC_ValueChanged(object sender, EventArgs e)
        {
            SchedulerLoaderChecks.SchedulerLoaderCheckALC(dateTimeALC);
            ALCScheduleLoader();
        }

        private void subMenuAddFlight_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<AddFlight_ALC>().FirstOrDefault();
            if (!FormOpener.CheckFormOpen(form))
            {
                DateTimeFormater.DateDisplay = dateTimeALC.Value.Date;
                new AddFlight_ALC().Show();
            }
        }

        private void subMenuDeleteFlight_Click(object sender, EventArgs e)
        {
            ALC_DeleteFlight deleteFlight = new ALC_DeleteFlight();
            deleteFlight.FlightNumber = FlightNumber;
            deleteFlight.Date = dateTimeALC.Value.Date;
            if (deleteFlight.DeletingFight(deleteFlight.FlightNumber, deleteFlight.Date))
            {
                ALCScheduleLoader();
            }
        }

        private void dgvSchedulerALC_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Open right click menu on Datagridview. 
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    this.dgvSchedulerALC.Rows[e.RowIndex].Selected = true;
                    this.rowIndex = e.RowIndex;
                    this.dgvSchedulerALC.CurrentCell = this.dgvSchedulerALC.Rows[e.RowIndex].Cells[2];
                    this.dgvMenuStripFlights.Show(this.dgvSchedulerALC, e.Location);
                    dgvMenuStripFlights.Show(Cursor.Position);

                    // Store flight number, depending on what flight number you click on Datagridview. 
                    FlightNumber = dgvSchedulerALC.Rows[e.RowIndex].Cells["Flight_Number"].Value.ToString();
                }
                // If user clicks outside of datagridview, it will throw exception. 
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Invalid right click. Please right click on flights only", "Invalid Right Click", MessageBoxButtons.OK);
                }
            }
        }

        private void SchedulerALC_FormClosing(object sender, FormClosingEventArgs e)
        {
            /// TO DO: FIND BETTER WAY TO REFRESH FORM 
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;

            // Refresh Loadplanner
            LoadPlanner refreshView = (LoadPlanner)Application.OpenForms["LoadPlanner"];
            refreshView.LoadPlanner_Load(sender, e);
        }

        private void dgvSchedulerALC_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                scb = new SqlCommandBuilder(dataAdapter);
                dgvSchedulerALC.EndEdit();
                this.dataAdapter.Update(dset, "Flight_Schedule_ALC");
            }
        }

        private void SchedulerALC_Resize(object sender, EventArgs e)
        {
            this.ResizeBegin += (s, g) => { this.SuspendLayout(); };
            this.ResizeEnd += (s, g) => { this.ResumeLayout(true); };
        }
    }
}
