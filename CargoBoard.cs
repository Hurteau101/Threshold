using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Perimeter_Threshold
{
    public partial class CargoBoard : Form
    {
        // Setting global variables for DataGridView.
        SqlDataAdapter dataAdapter;
        DataTable dt;
        DataSet dset;
        SqlCommandBuilder scb;

        public CargoBoard()
        {
            InitializeComponent();
        }

        private int rowIndex = 0; // Set row index, for right clicking on flights. 
        public string FlightNumber { get; set; }
        public string FullName { get; set; }
        public int UserID { get; set; }
        public static int Completion { get; set; }
        public bool FormLoaded = false;
        public int RoleID { get; set; }

        /// <summary>
        /// Load Cargo Board and preferences. 
        /// </summary>
        private void CargoBoardLoader()
        {
            SqlConnection connection = new SqlConnection(ConnectionLoader.ConnectionString("Threshold"));
            connection.Open();
            SqlCommand selectCargoBoard = new SqlCommand("Select_Cargo_Data", connection);
            selectCargoBoard.CommandType = CommandType.StoredProcedure;
            selectCargoBoard.Parameters.AddWithValue("@DateID", dateTimeCargo.Value.Date);
            dt = new DataTable();
            dataAdapter = new SqlDataAdapter(selectCargoBoard);
            dset = new DataSet();
            dataAdapter.Fill(dset, "Cargo_Board");
            BoardStyling.RowSizeMode(dgvCargoBoard);
            BoardStyling.GridviewMinimumRowSize(dgvCargoBoard); // Insertion done here, as you need to do it before binding. 
            dgvCargoBoard.DataSource = dset.Tables[0];
            LoadChecKbox();
            LoadUserPreferenceColors();

            CargoBoardStyling style = new CargoBoardStyling();
            style.HeaderRename(dgvCargoBoard);
            style.HideHeader(dgvCargoBoard);
            BoardStyling.UnsortableColumns(dgvCargoBoard);
            BoardStyling.ColumnSortDirection(dgvCargoBoard);
            BoardStyling.GridviewStyling(dgvCargoBoard);
            LoadCheckBoxState();
        }

        /// <summary>
        /// Load Checkbox Column on Cargo Board.
        /// </summary>
        private void LoadChecKbox()
        {
            // Add Completion column if it doesn't exist. 
            if (!dgvCargoBoard.Columns.Contains("Completion"))
            {
                var col = new DataGridViewCheckBoxColumn();
                col.TrueValue = true;
                col.FalseValue = false;
                //col.Text = "View";
                col.Name = "Completion";
                col.DataPropertyName = "SB"; //<-- this is very important
                dgvCargoBoard.Columns.Add(col);
                col.DefaultCellStyle.Font = new Font("Tahoma", 12, FontStyle.Bold);
            }
        }

        /// <summary>
        /// Update Flight Completion to 1 in Database, meaning it is completed. 
        /// </summary>
        private void FlightCompletionCheckbox()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                conn.Open();
                SqlCommand CheckboxTrue = new SqlCommand("UPDATE Cargo_Board SET Flight_Completion =@Flight_Completion, Flight_Number =@Flight_Number, " +
                    "Date_ID =@Date_ID WHERE Date_ID =@Date_ID AND Flight_Number =@Flight_Number", conn);
                CheckboxTrue.Parameters.AddWithValue("@Date_ID", dateTimeCargo.Value.Date);
                CheckboxTrue.Parameters.AddWithValue("@Flight_Number", FlightNumber);
                CheckboxTrue.Parameters.AddWithValue("@Flight_Completion", 1);
                CheckboxTrue.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Update Flight Completion to 0 in Database, meaning it is un-complete. 
        /// </summary>
        private void UnFlightCompletionCheckbox()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                conn.Open();
                SqlCommand CheckboxTrue = new SqlCommand("UPDATE Cargo_Board SET Flight_Completion =@Flight_Completion, Flight_Number =@Flight_Number, " +
                    "Date_ID =@Date_ID WHERE Date_ID =@Date_ID AND Flight_Number =@Flight_Number", conn);
                CheckboxTrue.Parameters.AddWithValue("@Date_ID", dateTimeCargo.Value.Date);
                CheckboxTrue.Parameters.AddWithValue("@Flight_Number", FlightNumber);
                CheckboxTrue.Parameters.AddWithValue("@Flight_Completion", 0);
                CheckboxTrue.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Load CheckBox State, if its checked or not. 
        /// </summary>
        private void LoadCheckBoxState()
        {
            foreach (DataGridViewRow row in dgvCargoBoard.Rows)
            {
                using (SqlConnection conn = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
                {
                    conn.Open();
                    SqlCommand checkCheckBoxState = new SqlCommand("SELECT Flight_Completion FROM Cargo_Board WHERE Flight_Number =@Flight_Number AND Date_ID =@Date_ID", conn);
                    checkCheckBoxState.Parameters.AddWithValue("@Flight_Number", row.Cells["Flight_Number"].Value.ToString());
                    checkCheckBoxState.Parameters.AddWithValue("@Date_ID", dateTimeCargo.Value.Date);
                    SqlDataReader readCheckStae = checkCheckBoxState.ExecuteReader();
                    if (readCheckStae.Read())
                    {
                        var check = (readCheckStae["Flight_Completion"].ToString());
                        if (!string.IsNullOrEmpty(check))
                        {
                            if (Int32.Parse(check) == 1)
                            {
                                row.Cells["Completion"].Value = "true";
                                row.DefaultCellStyle.BackColor = Color.FromArgb(Completion);
                            }
                            else
                            {
                                row.Cells["Completion"].Value = "false";
                                row.DefaultCellStyle.BackColor = Color.White;
                            }
                        }
                        else
                        {
                            row.Cells["Completion"].Value = "false";
                            row.DefaultCellStyle.BackColor = Color.White;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Save User Color Selection. 
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
        /// Load user color preferences. 
        /// </summary>
        private void LoadUserPreferenceColors()
        {
            UserPreferences loadColor = new UserPreferences();
            loadColor.UserID = UserID;
            loadColor.LoadPreferenecs();
            Completion = loadColor.CompletionColor;
            smallPanelCompletion.BackColor = Color.FromArgb(Completion);
        }

        private void CargoBoard_Load(object sender, EventArgs e)
        {
            // Load Name of User.
            lblUser.Text = FullName;

            // Format Date Display.
            DateTimeFormater.DateTimeDisplay(dateTimeCargo);

            CargoBoardLoader();

            // Set this to true only when form loads. This is to ensure re-size form event doesn't crash. 
          //  FormLoaded = true;
        }

        private void subMenuDeleteFlight_Click(object sender, EventArgs e)
        {
            CargoDeleteFlight deleteFlight = new CargoDeleteFlight();
            deleteFlight.FlightNumber = FlightNumber;
            deleteFlight.Date = dateTimeCargo.Value.Date;
            if (deleteFlight.DeletingFight(deleteFlight.FlightNumber, deleteFlight.Date))
            {
                UpdateBoardsAutomation.UpdateCargoBoardStatus();
                CargoBoardLoader();
            }
        }

        private void addAWBSeatblockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<Seatblock>().FirstOrDefault();
            if (!FormOpener.CheckFormOpen(form))
            {
                Seatblock seatblock = new Seatblock();
                var screen = Screen.FromPoint(Cursor.Position);
                seatblock.StartPosition = FormStartPosition.Manual;
                seatblock.Left = screen.Bounds.Left + screen.Bounds.Width / 2 - seatblock.Width / 2;
                seatblock.Top = screen.Bounds.Top + screen.Bounds.Height / 2 - seatblock.Height / 2;

                Seatblock.FlightNumber = FlightNumber;
                DateTimeFormater.DateDisplay = dateTimeCargo.Value.Date;
                seatblock.Show();
            }
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            if (UpdateBoardsAutomation.CheckCargoBoardStatus())
            {
                CargoBoardLoader();
                UpdateBoardsAutomation.FinishCargoUpdate();
            }
        }

        private void CargoBoard_Resize(object sender, EventArgs e)
        {
            // Check Form Width and adjust columns based on if the form is maximized. 
            if (this.WindowState == FormWindowState.Maximized)
            {
                CargoBoardStyling.ColumnWidthFull(dgvCargoBoard);
            }
            else if (this.WindowState != FormWindowState.Maximized)
            {
                CargoBoardStyling.ColumnWidthNotFull(dgvCargoBoard);
            }

            this.ResizeBegin += (s, g) => { this.SuspendLayout(); };
            this.ResizeEnd += (s, g) => { this.ResumeLayout(true); };
        }

        private void CargoBoard_KeyDown(object sender, KeyEventArgs e)
        {
            if (KeyboardShortcuts.Refresh(e))
            {
                CargoBoardLoader();
            }

            KeyboardShortcuts.NextDay(e, dateTimeCargo);
            KeyboardShortcuts.PreviousDay(e, dateTimeCargo);
            KeyboardShortcuts.GoToCurrentDate(e, dateTimeCargo);
        }

        private void flightInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FlightInformation>().FirstOrDefault();
            if (!FormOpener.CheckFormOpen(form))
            {
                FlightInformation flightInfo = new FlightInformation();
                var screen = Screen.FromPoint(Cursor.Position);
                flightInfo.StartPosition = FormStartPosition.Manual;
                flightInfo.Left = screen.Bounds.Left + screen.Bounds.Width / 2 - flightInfo.Width / 2;
                flightInfo.Top = screen.Bounds.Top + screen.Bounds.Height / 2 - flightInfo.Height / 2;

                flightInfo.NameOfBoard = "Cargo";
                flightInfo.Date = dateTimeCargo.Value.Date;
                flightInfo.FlightNumber = FlightNumber;
                if (flightInfo.CheckFlightExistence())
                {
                    flightInfo.Show();
                }
            }
        }

        private void dateTimeCargo_ValueChanged_1(object sender, EventArgs e)
        {
            CargoBoardLoader();
        }

        private void dgvCargoBoard_CellMouseUp_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            /// WILL HAVE TO ADD A NEW METHOD TO HOLD ALL RIGHT CLICK SELECTIONS

            // Open right click menu on Datagridview. 
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    this.dgvCargoBoard.Rows[e.RowIndex].Selected = true;
                    this.rowIndex = e.RowIndex;
                    this.dgvCargoBoard.CurrentCell = this.dgvCargoBoard.Rows[e.RowIndex].Cells[2];
                    this.dgvMenuStripFlights.Show(this.dgvCargoBoard, e.Location);
                    dgvMenuStripFlights.Show(Cursor.Position);

                    // Store flight number, depending on what flight number you click on Datagridview. 
                    FlightNumber = dgvCargoBoard.Rows[e.RowIndex].Cells["Flight_Number"].Value.ToString();
                }
                // If user clicks outside of datagridview, it will throw exception. 
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Invalid right click. Please right click on flights only", "Invalid Right Click", MessageBoxButtons.OK);
                }
            }
        }

        private void dgvCargoBoard_KeyUp(object sender, KeyEventArgs e)
        {
            // Update Cargo board with the enter key. 
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                scb = new SqlCommandBuilder(dataAdapter);
                dgvCargoBoard.EndEdit();
                this.dataAdapter.Update(dset, "Cargo_Board");
                UpdateBoardsAutomation.UpdateCargoBoardStatus();
            }
        }

        private void menuRefresh_Click_1(object sender, EventArgs e)
        {
            CargoBoardLoader();
        }

        private void dgvCargoBoard_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Allow clickable checkbox in gridview. Depending on checkbox state, call appropriate method. 
            var senderGrid2 = (DataGridView)sender;
            senderGrid2.EndEdit();

            if (senderGrid2.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn &&
                e.RowIndex >= 0)
            {
                var cbxCell = (DataGridViewCheckBoxCell)senderGrid2.Rows[e.RowIndex].Cells["Completion"];
                if ((bool)cbxCell.Value == true)
                {
                    FlightCompletionCheckbox();
                    LoadCheckBoxState();
                }
                else
                {
                    UnFlightCompletionCheckbox();
                    LoadCheckBoxState();
                }
            }
        }

        private void dgvCargoBoard_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Store flight number of row clicked. 
            if (e.RowIndex >= 0)
            {
                FlightNumber = dgvCargoBoard.Rows[e.RowIndex].Cells["Flight_Number"].Value.ToString();
            }
        }

        private void smallPanelCompletion_Click(object sender, EventArgs e)
        {
            // Store User color for this panel selection. 
            string userPanelSelection = "Cargo_Completion_Color";
            string userPanelSelectionName = "Flight Completion";

            UserColorSelection(userPanelSelection, userPanelSelectionName);

            LoadUserPreferenceColors();
            CargoBoardLoader();
        }

        private void subMenuStripShowDate_Click(object sender, EventArgs e)
        {
            DateTimeFormater.ShowDate(dateTimeCargo, subMenuStripShowDate, subMenuStripHideDate);
        }

        private void subMenuStripHideDate_Click(object sender, EventArgs e)
        {
            DateTimeFormater.HideDate(dateTimeCargo, subMenuStripShowDate, subMenuStripHideDate);
        }

        private void menuStripSeatblock_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<Seatblock>().FirstOrDefault();
            if (!FormOpener.CheckFormOpen(form))
            {
                Seatblock seatblock = new Seatblock();
                var screen = Screen.FromPoint(Cursor.Position);
                seatblock.StartPosition = FormStartPosition.Manual;
                seatblock.Left = screen.Bounds.Left + screen.Bounds.Width / 2 - seatblock.Width / 2;
                seatblock.Top = screen.Bounds.Top + screen.Bounds.Height / 2 - seatblock.Height / 2;

                DateTimeFormater.DateDisplay = dateTimeCargo.Value.Date;
                seatblock.Show();
            }
        }

        private void subMenuModifyFlight_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<AddFlight_Cargo>().FirstOrDefault();
            if (!FormOpener.CheckFormOpen(form))
            {
                AddFlight_Cargo flightAdderCargo = new AddFlight_Cargo();
                var screen = Screen.FromPoint(Cursor.Position);
                flightAdderCargo.StartPosition = FormStartPosition.Manual;
                flightAdderCargo.Left = screen.Bounds.Left + screen.Bounds.Width / 2 - flightAdderCargo.Width / 2;
                flightAdderCargo.Top = screen.Bounds.Top + screen.Bounds.Height / 2 - flightAdderCargo.Height / 2;

                DateTimeFormater.DateDisplay = dateTimeCargo.Value.Date;
                flightAdderCargo.Show();
            }
        }

        private void RefreshBoard_Tick(object sender, EventArgs e)
        {
            CargoBoardLoader();
        }

        private void CargoBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (RoleID != 3)
            {
                Application.Exit();
            }
        }

        private void CargoBoard_ResizeEnd(object sender, EventArgs e)
        {
            // TESTING THIS FOR LAG!
            CargoBoardLoader();

        }

        private void changelogToolStripMenuItem_Click(object sender, EventArgs e)
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
