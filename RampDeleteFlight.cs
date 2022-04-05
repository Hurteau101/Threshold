using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perimeter_Threshold
{
    public class RampDeleteFlight : DeleteFlight
    {
        public DateTime Date { get; set; }
        public string FlightNumber { get; set; }

        /// <summary>
        /// Delete Ramp Board Flight. 
        /// </summary>
        /// <param name="flightNumber"></param>
        /// <param name="date"></param>
        public override void DeletingFight(string flightNumber, DateTime date)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionLoader.ConnectionString("LoadPlanner")))
            {
                if (FlightNumber != null)
                {
                    if (MessageBox.Show($"Are you sure you want to delete {flightNumber}?", "Delete Flight?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        connection.Open();
                        SqlCommand deleteFlight = new SqlCommand("DELETE FROM RampBoard WHERE DateID = @DateID AND FlightNumber =@FlightNumber");
                        deleteFlight.Parameters.AddWithValue("@FlightNumber", flightNumber);
                        deleteFlight.Parameters.AddWithValue("@DateID", date);
                        deleteFlight.ExecuteNonQuery();
                        MessageBox.Show("Flight suecessfully deleted", "Flight Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    MessageBox.Show("No Flight Found. Please first click on the flight you want to delete, then right click \"Delete Flight\"");
                }
            }
        }
    }
}
