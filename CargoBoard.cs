using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        /// <summary>
        /// Load Cargo Board. 
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
            dgvCargoBoard.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            CargoBoardStyling.GridviewColumnSize(dgvCargoBoard); // Insertion done here, as you need to do it before binding. 
            dgvCargoBoard.DataSource = dset.Tables[0];

            CargoBoardStyling style = new CargoBoardStyling();
            style.HeaderRename(dgvCargoBoard);
            style.HideHeader(dgvCargoBoard);
            BoardStyling.UnsortableColumns(dgvCargoBoard);
            BoardStyling.GridViewColumnSizeWidth(dgvCargoBoard);
            BoardStyling.ColumnSortDirection(dgvCargoBoard);
            BoardStyling.RowSize(dgvCargoBoard);
            BoardStyling.GridviewStyling(dgvCargoBoard);
            CargoBoardStyling.ReArrangeColumns(dgvCargoBoard);
        }
       

        private void CargoBoard_Load(object sender, EventArgs e)
        {
            // Load Name of User.
            lblUser.Text = Name;

            // Format Date Display.
            DateTimeFormater.DateTimeDisplay(dateTimeCargo);

            CargoBoardLoader();
        }

        private void subMenuModifyFlight_Click(object sender, EventArgs e)
        {
            AddFlight_Cargo addFlight = new AddFlight_Cargo();
            DateTimeFormater.DateDisplay = dateTimeCargo.Value.Date;
            addFlight.ShowDialog();
        }

        private void subMenuStripShowDate_Click(object sender, EventArgs e)
        {
            DateTimeFormater.ShowDate(dateTimeCargo, subMenuStripShowDate, subMenuStripHideDate);
        }

        private void subMenuStripHideDate_Click(object sender, EventArgs e)
        {
            DateTimeFormater.HideDate(dateTimeCargo, subMenuStripShowDate, subMenuStripHideDate);
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
            }
        }

        private void dateTimeCargo_ValueChanged(object sender, EventArgs e)
        {
            CargoBoardLoader();
        }

        private void subMenuDeleteFlight_Click(object sender, EventArgs e)
        {
            CargoDeleteFlight deleteFlight = new CargoDeleteFlight();
            deleteFlight.FlightNumber = FlightNumber;
            deleteFlight.Date = dateTimeCargo.Value.Date;
            deleteFlight.DeletingFight(deleteFlight.FlightNumber, deleteFlight.Date);
        }

        private void dgvCargoBoard_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            /// WILL HAVE TO ADD A NEW METHOD TO HOLD ALL RIGHT CLICK SELECTIONS

            // Open right click menu on Datagridview. 
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    this.dgvCargoBoard.Rows[e.RowIndex].Selected = true;
                    this.rowIndex = e.RowIndex;
                    this.dgvCargoBoard.CurrentCell = this.dgvCargoBoard.Rows[e.RowIndex].Cells[1];
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

        private void menuStripSeatblock_Click(object sender, EventArgs e)
        {
            Seatblock openSeatblock = new Seatblock();
            DateTimeFormater.DateDisplay = dateTimeCargo.Value.Date;
            openSeatblock.ShowDialog();
        }

        private void addAWBSeatblockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Seatblock openSeatblock = new Seatblock();
            DateTimeFormater.DateDisplay = dateTimeCargo.Value.Date;
            openSeatblock.FlightNumber = FlightNumber;
            openSeatblock.ShowDialog();
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            if (UpdateBoardsAutomation.CheckCargoBoardStatus())
            {
                CargoBoardLoader();
                UpdateBoardsAutomation.FinishCargoUpdate();
            }
        }
    }
}
