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
        // Setting global variables for DataGridView.
        SqlDataAdapter dataAdapter;
        DataTable dt;
        DataSet dset;
        SqlCommandBuilder scb;

        public RampBoard()
        {
            InitializeComponent();
        }
        public static int EarlyColor { get; set; }
        public static int OnTimeColor { get; set; }
        public static int LateColor { get; set; }
        public static int ArrivalColor { get; set; }
        public static int UnserviceableColor { get; set; }

        private int rowIndex = 0; // Set row index, for right clicking on flights. 
        public string FullName { get; set; }
        public string FlightNumber { get; set; }
        public int UserID { get; set; }
        public int Grid { get; set; }


        /// <summary>
        /// Load Ramp Board data into gridview
        /// </summary>
        private void RampBoardLoader()
        {
            SqlConnection connection = new SqlConnection(ConnectionLoader.ConnectionString("Threshold"));
            connection.Open();
            SqlCommand selectRampBoard = new SqlCommand("Select_Ramp_Data", connection);
            selectRampBoard.CommandType = CommandType.StoredProcedure;
            selectRampBoard.Parameters.AddWithValue("@DateID", dateTimeRamp.Value.Date);
            dt = new DataTable();
            dataAdapter = new SqlDataAdapter(selectRampBoard);
            dset = new DataSet();
            dataAdapter.Fill(dset, "Ramp_Board");
            dgvRampBoard.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            BoardStyling.GridviewColumnSize(dgvRampBoard); // Insertion done here, as you need to do it before binding. 
            dgvRampBoard.DataSource = dset.Tables[0];
            connection.Close();

            RampBoardStyling style = new RampBoardStyling();
            style.HeaderRename(dgvRampBoard);
            style.HideHeader(dgvRampBoard);
            BoardStyling.UnsortableColumns(dgvRampBoard);
            BoardStyling.GridViewColumnSizeWidth(dgvRampBoard);
            BoardStyling.ColumnSortDirection(dgvRampBoard);
            BoardStyling.RowSize(dgvRampBoard);
            BoardStyling.GridviewStyling(dgvRampBoard);

            LoadUserPreferenceColors();

        }
        /// <summary>
        ///  Load User Preference and set Colors they have set on the Board. 
        /// </summary>
        private void LoadUserPreferenceColors()
        {
            UserPreferences loadColor = new UserPreferences();
            loadColor.UserID = UserID;
            loadColor.LoadPreferenecs();
            EarlyColor = loadColor.EarlyColor;
            OnTimeColor = loadColor.OnTimeColor;
            LateColor = loadColor.LateColor;
            ArrivalColor = loadColor.ArrivalColor;
            UnserviceableColor = loadColor.UnserviceableColor;

            BoardStyling.EarlyColor = EarlyColor;
            BoardStyling.OnTimeColor = OnTimeColor;
            BoardStyling.LateColor = LateColor;
            BoardStyling.ArrivalColor = ArrivalColor;
            BoardStyling.UnserviceableColor = UnserviceableColor;

            smallPanelEarly.BackColor = Color.FromArgb(EarlyColor);
            smallPanelLate.BackColor = Color.FromArgb(LateColor);
            smallPanelOnTime.BackColor = Color.FromArgb(OnTimeColor);
            smallPanelArrived.BackColor = Color.FromArgb(ArrivalColor);
            smallPanelUnserviceable.BackColor = Color.FromArgb(UnserviceableColor);           
        }

        /// <summary>
        /// Method to save the user preferences. You will notice that we have hard coded column names, so nothing has to be re-written more than once.  
        /// </summary>
        /// <param name="userSelection"></param>
        /// <param name="userPanelSelectionName"></param>
        private void UserColorSelection(string userSelection, string userPanelSelectionName)
        {
            ColorDialog saveDialogColor = new ColorDialog();
            if (saveDialogColor.ShowDialog() == DialogResult.OK)
            {
                int saveColor = saveDialogColor.Color.ToArgb();
                UserPreferences save = new UserPreferences(UserID, saveColor);
                save.UserSaveSelection = $"{userSelection}";
                save.SaveRampColors();

                MessageBox.Show($"{userPanelSelectionName} Color has been saved to User Preferences", "Save Sucessful", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void RampBoard_Load(object sender, EventArgs e)
        {
            // Load Name of User.
            lblUser.Text = Name;

            // Format Date Display.
            DateTimeFormater.DateTimeDisplay(dateTimeRamp);

            // Load Master Schedule
            ScheduleLoader loadSchedule = new ScheduleLoader(dateTimeRamp.Value.DayOfWeek, dateTimeRamp.Value.Date);
            loadSchedule.LoadMasterScheduleRamp();

            // Load Ramp Board.
            RampBoardLoader();

        }

        private void subMenuAddFlight_Click(object sender, EventArgs e)
        {
            AddFlight_Ramp addFlight = new AddFlight_Ramp();
            DateTimeFormater.DateDisplay = dateTimeRamp.Value.Date;
            addFlight.Show();          
        }

        private void dgvRampBoard_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            /// WILL HAVE TO ADD A NEW METHOD TO HOLD ALL RIGHT CLICK SELECTIONS

            // Open right click menu on Datagridview. 
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    this.dgvRampBoard.Rows[e.RowIndex].Selected = true;
                    this.rowIndex = e.RowIndex;
                    this.dgvRampBoard.CurrentCell = this.dgvRampBoard.Rows[e.RowIndex].Cells[1];
                    this.dgvMenuStripFlights.Show(this.dgvRampBoard, e.Location);
                    dgvMenuStripFlights.Show(Cursor.Position);

                    // Store flight number, depending on what flight number you click on Datagridview. 
                    FlightNumber = dgvRampBoard.Rows[e.RowIndex].Cells["Flight_Number"].Value.ToString();
                }
                // If user clicks outside of datagridview, it will throw exception. 
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Invalid right click. Please right click on flights only", "Invalid Right Click", MessageBoxButtons.OK);
                }
            }
        }

        private void subMenuDeleteFlight_Click(object sender, EventArgs e)
        {
            RampDeleteFlight deleteFlight = new RampDeleteFlight();
            deleteFlight.FlightNumber = FlightNumber; 
            deleteFlight.Date = dateTimeRamp.Value.Date;
            deleteFlight.DeletingFight(deleteFlight.FlightNumber, deleteFlight.Date);
        }

        private void showDateCalanderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTimeFormater.ShowDate(dateTimeRamp, subMenuStripShowDate, subMenuStripHideDate);
        }

        private void hideDateCalenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTimeFormater.HideDate(dateTimeRamp, subMenuStripShowDate, subMenuStripHideDate);
        }

        private void subMenuNightChecklist_Click(object sender, EventArgs e)
        {
            NightChecklist nightList = new NightChecklist();
            DateTimeFormater.DateDisplay = dateTimeRamp.Value.Date;
            nightList.Show();
        }

        private void dateTimeRamp_ValueChanged(object sender, EventArgs e)
        {
            ScheduleLoader loadSchedule = new ScheduleLoader(dateTimeRamp.Value.DayOfWeek, dateTimeRamp.Value.Date);
            loadSchedule.LoadMasterScheduleRamp();
            RampBoardLoader();
        }

        /// <summary>
        /// Update Rampboard with the enter key. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvRampBoard_KeyUp(object sender, KeyEventArgs e)
        {
            // If 2 people update the board at once, it may throw an error. 
            //try
            //{
                if (e.KeyCode == Keys.Enter)
                {
                    e.Handled = true;
                    scb = new SqlCommandBuilder(dataAdapter);
                    scb.ConflictOption = ConflictOption.OverwriteChanges; // Test if this causes excpetion. If does implement the try catch that is commented out. 
                    dgvRampBoard.EndEdit();
                    this.dataAdapter.Update(dset, "Ramp_Board");

                    UpdateBoardsAutomation.UpdateRampBoardStatus();
                }
            //}
            //catch(System.Data.DBConcurrencyException)
            //{
            //    /// Will log error. 
            //}
            //finally
            //{
            //    MessageBox.Show("Please try updating again. More than 1 person tried to update the board.", "Update Fail");
            //}

        }

        /// <summary>
        /// Create Timer to automatically update board. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateTimer_Tick(object sender, EventArgs e)
        {
            if (UpdateBoardsAutomation.CheckRampBoardStatus())
            {
                RampBoardLoader();
                UpdateBoardsAutomation.FinishRampUpdate();
            }
        }

        private void dgvRampBoard_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
            RampBoardStyling styleColors = new RampBoardStyling();
            styleColors.GridviewDelayColors(dgvRampBoard);
        }

        private void arrivalTimer_Tick(object sender, EventArgs e)
        {
            RampBoardStyling.ArrivalTimeColor(dgvRampBoard, dateTimeRamp.Value.Date);           
        }

        private void smallPanelEarly_DoubleClick(object sender, EventArgs e)
        {
            string userPanelSelection = "Ramp_Early_Color";
            string userPanelSelectionName = "Early";

            UserColorSelection(userPanelSelection, userPanelSelectionName);

            LoadUserPreferenceColors();
        }

        /// <summary>
        /// Store Color in Database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void smallPanelLate_DoubleClick(object sender, EventArgs e)
        {
            string userPanelSelection = "Ramp_Late_Color";
            string userPanelSelectionName = "Late";

            UserColorSelection(userPanelSelection, userPanelSelectionName);

            LoadUserPreferenceColors();
        }

        /// <summary>
        /// Store Color in Database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void smallPanelUnserviceable_DoubleClick(object sender, EventArgs e)
        {
            string userPanelSelection = "Ramp_AC_Unserviceable_Color";
            string userPanelSelectionName = "Aircraft Unserviceable";

            UserColorSelection(userPanelSelection, userPanelSelectionName);

            LoadUserPreferenceColors();
        }

        /// <summary>
        /// Store Color in Database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void smallPanelOnTime_DoubleClick(object sender, EventArgs e)
        {
            string userPanelSelection = "Ramp_OnTime_Color";
            string userPanelSelectionName = "On Time";

            UserColorSelection(userPanelSelection, userPanelSelectionName);

            LoadUserPreferenceColors();
            RampBoardLoader();
        }

        /// <summary>
        /// Store Color in Database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void smallPanelArrived_DoubleClick(object sender, EventArgs e)
        {
            string userPanelSelection = "Ramp_Arrival_Color";
            string userPanelSelectionName = "Arrival";

            UserColorSelection(userPanelSelection, userPanelSelectionName);

            LoadUserPreferenceColors();
        }
    }
}
