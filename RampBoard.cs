using System;
using System.Data;
using System.Drawing;
using System.Linq;
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

        public bool FormLoadded = false;
        public int RoleID { get; set; }

        /// <summary>
        /// Load Ramp Board data into gridview
        /// </summary>
        private void RampBoardLoader()
        {
            SqlConnection connection = new SqlConnection(ConnectionLoader.ConnectionString("Threshold"));
            connection.Open();
            SqlCommand selectRampBoard = new SqlCommand("Test_Ramp_Board", connection);
            // UNCOMMENT ONCE LIVE
            //SqlCommand selectRampBoard = new SqlCommand("Select_Ramp_Data", connection);
            selectRampBoard.CommandType = CommandType.StoredProcedure;
            selectRampBoard.Parameters.AddWithValue("@DateID", dateTimeRamp.Value.Date);
            dt = new DataTable();
            dataAdapter = new SqlDataAdapter(selectRampBoard);
            dset = new DataSet();
            dataAdapter.Fill(dset, "Ramp_Board");
            BoardStyling.RowSizeMode(dgvRampBoard);
            BoardStyling.GridviewMinimumRowSize(dgvRampBoard); // Insertion done here, as you need to do it before binding.
            dgvRampBoard.DataSource = dset.Tables[0];
            connection.Close();

            RampBoardStyling style = new RampBoardStyling();
            style.HeaderRename(dgvRampBoard);
            style.HideHeader(dgvRampBoard);
            BoardStyling.UnsortableColumns(dgvRampBoard);
            BoardStyling.ColumnSortDirection(dgvRampBoard);
            BoardStyling.GridviewStyling(dgvRampBoard);

            LoadUserPreferenceColors();
            RampBoardStyling.LoadAircraftStatus(dgvRampBoard);

            RampBoardStyling.ArrivalTimeColor(dgvRampBoard, dateTimeRamp.Value.Date);         
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
                save.SaveColors();

                MessageBox.Show($"{userPanelSelectionName} Color has been saved to User Preferences", "Save Sucessful", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Set aircraft unserviceablility. 
        /// </summary>
        private void AircraftUnserviceable()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                conn.Open();
                SqlCommand CheckboxTrue = new SqlCommand("UPDATE Ramp_Board SET Aircraft_Status =@Aircraft_Status " +
                    "WHERE Date_ID =@Date_ID AND Flight_Number =@Flight_Number", conn);
                CheckboxTrue.Parameters.AddWithValue("@Date_ID", dateTimeRamp.Value.Date);
                CheckboxTrue.Parameters.AddWithValue("@Flight_Number", FlightNumber);
                CheckboxTrue.Parameters.AddWithValue("@Aircraft_Status", 1);
                CheckboxTrue.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Set aircraft serviceability. 
        /// </summary>
        private void AircraftServiceable()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                conn.Open();
                SqlCommand CheckboxTrue = new SqlCommand("UPDATE Ramp_Board SET Aircraft_Status =@Aircraft_Status " +
                    "WHERE Date_ID =@Date_ID AND Flight_Number =@Flight_Number", conn);
                CheckboxTrue.Parameters.AddWithValue("@Date_ID", dateTimeRamp.Value.Date);
                CheckboxTrue.Parameters.AddWithValue("@Flight_Number", FlightNumber);
                CheckboxTrue.Parameters.AddWithValue("@Aircraft_Status", 0);
                CheckboxTrue.ExecuteNonQuery();
            }
        }

        private void RampBoard_Load(object sender, EventArgs e)
        {
            // Load Name of User.
            lblUser.Text = FullName;

            // Format Date Display.
            DateTimeFormater.DateTimeDisplay(dateTimeRamp);

            SchedulerLoaderChecks.SchedulerLoaderCheckRamp(dateTimeRamp);

            // Load Ramp Board.
             RampBoardLoader();

            // Set this to true only when form loads. This is to ensure re-size form event doesn't crash. 
            FormLoadded = true;
        }

        private void subMenuAddFlight_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<AddFlight_Ramp>().FirstOrDefault();
            if (!FormOpener.CheckFormOpen(form))
            {
                AddFlight_Ramp openFlightAdder = new AddFlight_Ramp();
                var screen = Screen.FromPoint(Cursor.Position);
                openFlightAdder.StartPosition = FormStartPosition.Manual;
                openFlightAdder.Left = screen.Bounds.Left + screen.Bounds.Width / 2 - openFlightAdder.Width / 2;
                openFlightAdder.Top = screen.Bounds.Top + screen.Bounds.Height / 2 - openFlightAdder.Height / 2;

                DateTimeFormater.DateDisplay = dateTimeRamp.Value.Date;

                openFlightAdder.Show();
            }
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
                    this.dgvRampBoard.CurrentCell = this.dgvRampBoard.Rows[e.RowIndex].Cells[2];
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
            if(deleteFlight.DeletingFight(deleteFlight.FlightNumber, deleteFlight.Date))
            {
                UpdateBoardsAutomation.UpdateRampBoardStatus();
                RampBoardLoader();
            }            
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
            var form = Application.OpenForms.OfType<NightChecklist>().FirstOrDefault();
            if (!FormOpener.CheckFormOpen(form))
            {
                NightChecklist checklist = new NightChecklist();
                var screen = Screen.FromPoint(Cursor.Position);
                checklist.StartPosition = FormStartPosition.Manual;
                checklist.Left = screen.Bounds.Left + screen.Bounds.Width / 2 - checklist.Width / 2;
                checklist.Top = screen.Bounds.Top + screen.Bounds.Height / 2 - checklist.Height / 2;

                DateTimeFormater.DateDisplay = dateTimeRamp.Value.Date;
                checklist.Show();
            }
        }

        private void dateTimeRamp_ValueChanged(object sender, EventArgs e)
        {
            SchedulerLoaderChecks.SchedulerLoaderCheckRamp(dateTimeRamp);
            RampBoardLoader();
        }

        /// <summary>
        /// Update Rampboard with the enter key. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvRampBoard_KeyUp(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.Enter)
                {
                    e.Handled = true;
                    scb = new SqlCommandBuilder(dataAdapter);
                    scb.ConflictOption = ConflictOption.OverwriteChanges; // Test if this causes excpetion. If does implement the try catch that is commented out. 
                    dgvRampBoard.EndEdit();
                    this.dataAdapter.Update(dset, "Ramp_Board");

                    UpdateBoardsAutomation.UpdateRampBoardStatus();
                }
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
            RampBoardLoader();
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
            RampBoardLoader();
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
            RampBoardLoader();
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
            RampBoardLoader();
        }

        private void subMenuMasterSchedule_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<MasterScheduler>().FirstOrDefault();
            if (!FormOpener.CheckFormOpen(form))
            {
                MasterScheduler masterSchedule = new MasterScheduler();

                var screen = Screen.FromPoint(Cursor.Position);
                masterSchedule.StartPosition = FormStartPosition.Manual;
                masterSchedule.Left = screen.Bounds.Left + screen.Bounds.Width / 2 - masterSchedule.Width / 2;
                masterSchedule.Top = screen.Bounds.Top + screen.Bounds.Height / 2 - masterSchedule.Height / 2;

                masterSchedule.Show();
            }
        }

        private void RampBoard_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized && FormLoadded)
            {
                RampBoardStyling.ColumnWidthFull(dgvRampBoard);
            }
            else if (this.WindowState != FormWindowState.Maximized && FormLoadded)
            {
                RampBoardStyling.ColumnWidthNotFull(dgvRampBoard);
            }

            //this.ResizeBegin += (s, g) => { this.SuspendLayout(); };
            //this.ResizeEnd += (s, g) => { this.ResumeLayout(true); };
        }

        private void menuRefresh_Click(object sender, EventArgs e)
        {
            RampBoardLoader();
        }

        private void RampBoard_KeyDown(object sender, KeyEventArgs e)
        {
            if (KeyboardShortcuts.Refresh(e))
            {
                RampBoardLoader();
            }

            KeyboardShortcuts.NextDay(e, dateTimeRamp);
            KeyboardShortcuts.PreviousDay(e, dateTimeRamp);
            KeyboardShortcuts.GoToCurrentDate(e, dateTimeRamp);
        }

        private void serviceableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AircraftServiceable();
            RampBoardLoader();
        }

        private void unserviceableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AircraftUnserviceable();
            RampBoardLoader();
        }


        private void flightInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<MasterScheduler>().FirstOrDefault();
            if (!FormOpener.CheckFormOpen(form))
            {
                FlightInformation flightInfo = new FlightInformation();

                var screen = Screen.FromPoint(Cursor.Position);
                flightInfo.StartPosition = FormStartPosition.Manual;
                flightInfo.Left = screen.Bounds.Left + screen.Bounds.Width / 2 - flightInfo.Width / 2;
                flightInfo.Top = screen.Bounds.Top + screen.Bounds.Height / 2 - flightInfo.Height / 2;

                flightInfo.NameOfBoard = "Ramp";
                flightInfo.Date = dateTimeRamp.Value.Date;
                flightInfo.FlightNumber = FlightNumber;
                if (flightInfo.CheckFlightExistence())
                {
                    flightInfo.Show();
                }
            }
        }

        private void RefreshBoard_Tick(object sender, EventArgs e)
        {
            RampBoardLoader();
        }

        private void RampBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (RoleID != 3)
            {
                Application.Exit();
            }
        }

        private void RampBoard_ResizeEnd(object sender, EventArgs e)
        {
            // TESTING THIS FOR LAG!
            RampBoardLoader();
        }

        private void changeLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<Changelog>().FirstOrDefault();
            if (!FormOpener.CheckFormOpen(form))
            {
                Changelog changeLog = new Changelog();

                var screen = Screen.FromPoint(Cursor.Position);
                changeLog.StartPosition = FormStartPosition.Manual;
                changeLog.Left = screen.Bounds.Left + screen.Bounds.Width / 2 - changeLog.Width / 2;
                changeLog.Top = screen.Bounds.Top + screen.Bounds.Height / 2 - changeLog.Height / 2;
                changeLog.Show();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<About>().FirstOrDefault();
            if (!FormOpener.CheckFormOpen(form))
            {
                About about = new About();

                var screen = Screen.FromPoint(Cursor.Position);
                about.StartPosition = FormStartPosition.Manual;
                about.Left = screen.Bounds.Left + screen.Bounds.Width / 2 - about.Width / 2;
                about.Top = screen.Bounds.Top + screen.Bounds.Height / 2 - about.Height / 2;
                about.Show();
            }
        }
    }
}
