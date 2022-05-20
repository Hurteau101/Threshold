using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public SchedulerALC()
        {
            InitializeComponent();
        }
        private void ALCScheduleLoader()
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
            dgvSchedulerALC.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            BoardStyling.GridviewColumnSize(dgvSchedulerALC); // Insertion done here, as you need to do it before binding. 
            dgvSchedulerALC.DataSource = dset.Tables[0];

            ALCBoardStyling style = new ALCBoardStyling();
            style.HeaderRename(dgvSchedulerALC);
            style.HideHeader(dgvSchedulerALC);            
            BoardStyling.UnsortableColumns(dgvSchedulerALC);
            BoardStyling.GridViewColumnSizeWidth(dgvSchedulerALC);
            BoardStyling.ColumnSortDirection(dgvSchedulerALC);
            BoardStyling.RowSize(dgvSchedulerALC);
            BoardStyling.GridviewStyling(dgvSchedulerALC);
         
        }

        private void SchedulerALC_Load(object sender, EventArgs e)
        {
            // Format Date Display.
            DateTimeFormater.DateTimeDisplay(dateTimeALC);
            DateTimeFormater.AutoSetDate(dateTimeALC);

            // Load Master Schedule
            ScheduleLoader loadSchedule = new ScheduleLoader(dateTimeALC.Value.DayOfWeek, dateTimeALC.Value.Date);
            loadSchedule.LoadMasterScheduleALC();

            ALCScheduleLoader();

        }

        private void dateTimeALC_ValueChanged(object sender, EventArgs e)
        {
            // Load Master Schedule
            ScheduleLoader loadSchedule = new ScheduleLoader(dateTimeALC.Value.DayOfWeek, dateTimeALC.Value.Date);
            loadSchedule.LoadMasterScheduleALC();
            
            ALCScheduleLoader();
        }
    }
}
