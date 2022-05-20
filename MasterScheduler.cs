using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perimeter_Threshold
{
    public partial class MasterScheduler : Form
    {
        // Setting global variables for DataGridView.
        SqlDataAdapter dataAdapter;
        DataTable dt;
        DataSet dset;
        SqlCommandBuilder scb;

        public MasterScheduler()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load Master Schedule to gridview. 
        /// </summary>
        private void MasterScheduleLoader()
        {
            SqlConnection connection = new SqlConnection(ConnectionLoader.ConnectionString("Threshold"));
            connection.Open();
            SqlCommand selectMaster = new SqlCommand("SELECT * FROM Master_Schedule WHERE Day_Of_Week = @Day_Of_Week", connection);
            selectMaster.Parameters.AddWithValue("@Day_Of_Week", cbDayOfWeek.SelectedItem);
            dt = new DataTable();
            dataAdapter = new SqlDataAdapter(selectMaster);
            dset = new DataSet();
            dataAdapter.Fill(dset, "Master_Schedule");
            dgvMasterSchedule.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            BoardStyling.GridviewColumnSize(dgvMasterSchedule); // Insertion done here, as you need to do it before binding. 
            dgvMasterSchedule.DataSource = dset.Tables[0];
            connection.Close();

            MasterBoardStyling style = new MasterBoardStyling();
            style.HideHeader(dgvMasterSchedule);
            BoardStyling.UnsortableColumns(dgvMasterSchedule);
            BoardStyling.GridViewColumnSizeWidth(dgvMasterSchedule);         
            BoardStyling.ColumnSortDirection(dgvMasterSchedule);
            BoardStyling.RowSize(dgvMasterSchedule);
            BoardStyling.GridviewStyling(dgvMasterSchedule);

        }

        private void subMenuAddFlight_Click(object sender, EventArgs e)
        {
            AddFlightScheduler openScheduler = new AddFlightScheduler();
            openScheduler.ShowDialog();
        }

        private void MasterScheduler_Load(object sender, EventArgs e)
        {
            cbDayOfWeek.SelectedItem = "Monday";
            MasterScheduleLoader();
        }

        private void cbDayOfWeek_SelectedIndexChanged(object sender, EventArgs e)
        {
            MasterScheduleLoader();
        }

        private void dgvMasterSchedule_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                scb = new SqlCommandBuilder(dataAdapter);
                dgvMasterSchedule.EndEdit();
                this.dataAdapter.Update(dset, "Master_Schedule");
            }
        }
    }
}
