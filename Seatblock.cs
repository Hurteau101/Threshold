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
    public partial class Seatblock : Form
    {
        public Seatblock()
        {
            InitializeComponent();
        }

        public string FlightNumber { get; set; }

        /// <summary>
        /// Load seatblock info from database. 
        /// </summary>
        public void LoadSeatblockInformation()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                conn.Open();
                SqlCommand loadSeatblock = new SqlCommand("Find_Seatblock", conn);
                loadSeatblock.CommandType = CommandType.StoredProcedure;
                loadSeatblock.Parameters.AddWithValue("@DateID", dateSeatblock.Value.Date);
                loadSeatblock.Parameters.AddWithValue("@FlightNumber", tbFlightNumber.Text);
                SqlDataReader readSeatblock = loadSeatblock.ExecuteReader();
                if(readSeatblock.Read())
                {
                    rchSeatblock.Text = (readSeatblock["Seatblock"].ToString());
                }
                else
                {
                    rchSeatblock.Clear();
                }
            }
        }

        /// <summary>
        /// Save seatblock info to database. 
        /// </summary>
        public void SaveSeatblock()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                conn.Open();
                SqlCommand saveSeatblock = new SqlCommand("Save_Seatblock", conn);
                saveSeatblock.CommandType = CommandType.StoredProcedure;
                saveSeatblock.Parameters.AddWithValue("DateID", dateSeatblock.Value.Date);
                saveSeatblock.Parameters.AddWithValue("@FlightNumber", tbFlightNumber.Text);
                saveSeatblock.Parameters.AddWithValue("@Seatblock", rchSeatblock.Text);
                saveSeatblock.ExecuteNonQuery();
                MessageBox.Show("Seatblock Save Sucessful", "Save Sucessful", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveSeatblock();
        }

        private void tbFlightNumber_TextChanged(object sender, EventArgs e)
        {
            LoadSeatblockInformation();
        }

        private void dateSeatblock_ValueChanged(object sender, EventArgs e)
        {
            LoadSeatblockInformation();
        }

        private void Seatblock_Load(object sender, EventArgs e)
        {
            DateTimeFormater.DateTimeDisplay(dateSeatblock);
            DateTimeFormater.AutoSetDate(dateSeatblock);

            // Check if null, if its not null then set property of Flight Number to text box.
            // This is used when you right click on Cargo Board and add an AWB that way. 
            if (FlightNumber != null)
            {
                tbFlightNumber.Text = FlightNumber;            
            }

            LoadSeatblockInformation();

        }
    }
}
