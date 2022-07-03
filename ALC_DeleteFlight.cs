using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Perimeter_Threshold
{
    class ALC_DeleteFlight : IDeleteFlight
    {
        public DateTime Date { get; set; }
        public string FlightNumber { get; set; }

        /// <summary>
        /// Delete flight from ALC Scheduler Board. 
        /// </summary>
        /// <param name="flightNumber"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public bool DeletingFight(string flightNumber, DateTime date)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                if (FlightNumber != null)
                {
                    if (MessageBox.Show($"Are you sure you want to delete {flightNumber}?", "Delete Flight?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        connection.Open();
                        SqlCommand deleteFlight = new SqlCommand("DELETE FROM Flight_Schedule_ALC WHERE Date_ID = @Date_ID AND Flight_Number =@Flight_Number", connection);
                        deleteFlight.Parameters.AddWithValue("@Flight_Number", flightNumber);
                        deleteFlight.Parameters.AddWithValue("@Date_ID", date);
                        deleteFlight.ExecuteNonQuery();
                        MessageBox.Show("Flight suecessfully deleted", "Flight Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                }
                else
                {
                    MessageBox.Show("No Flight Found. Please first click on the flight you want to delete, then right click \"Delete Flight\"");
                    return false;
                }
                return false;
            }
        }
    }
}
