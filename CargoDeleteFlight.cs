using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Perimeter_Threshold
{
    class CargoDeleteFlight : IDeleteFlight
    {
        public DateTime Date { get; set; }
        public string FlightNumber { get; set; }

        /// <summary>
        /// Delete Cargo Board Flight with confirmation message. If selection is null, throw message to user. 
        /// </summary>
        /// <param name="flightNumber"></param>
        /// <param name="date"></param>
        public bool DeletingFight(string flightNumber, DateTime date)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                if (FlightNumber != null)
                {
                    if (MessageBox.Show($"Are you sure you want to delete {flightNumber}?", "Delete Flight?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        connection.Open();
                        SqlCommand deleteFlight = new SqlCommand("DELETE FROM Cargo_Board WHERE Date_ID = @Date_ID AND Flight_Number =@Flight_Number", connection);
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
