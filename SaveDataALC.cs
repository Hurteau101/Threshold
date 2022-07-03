using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Dapper;

namespace Perimeter_Threshold
{
    public class SaveDataALC
    {
        /// <summary>
        /// Save ALC Flight. 
        /// </summary>
        /// <param name="details"></param>
        public static void SaveFlight(FlightDetail details)
        {
            using (IDbConnection con = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                con.Execute("Save_Leg_Loadplanner", details, commandType: CommandType.StoredProcedure);
            }           
        }

        /// <summary>
        /// Save Aircraft OEW. 
        /// </summary>
        /// <param name="aircraft"></param>
        /// <param name="crew"></param>
        /// <param name="aircraftWeight"></param>
        public static void SaveAircraftWeight(ComboBox aircraft, ComboBox crew, TextBox aircraftWeight)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                conn.Open();
                SqlCommand saveAircraftWeight = new SqlCommand("Save_Aircraft_Weight", conn);
                saveAircraftWeight.CommandType = CommandType.StoredProcedure;
                saveAircraftWeight.Parameters.AddWithValue("@Aircraft", aircraft.Text);
                saveAircraftWeight.Parameters.AddWithValue("@AircraftWeight", aircraftWeight.Text);
                saveAircraftWeight.Parameters.AddWithValue("@Crew", crew.Text);
                saveAircraftWeight.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Save aircraft configuration. 
        /// </summary>
        /// <param name="aircraft"></param>
        /// <param name="aircraftConfiguration"></param>
        public static void SaveAircraftConfiguration(ComboBox aircraft, TextBox aircraftConfiguration)
        {
            // Update only happens on first leg. May need to fix, if want to update on other legs for seats. 
            using (SqlConnection conn = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                conn.Open();
                SqlCommand saveAircraftWeight = new SqlCommand("Save_Aircraft_Configure", conn);
                saveAircraftWeight.CommandType = CommandType.StoredProcedure;
                saveAircraftWeight.Parameters.AddWithValue("@Aircraft", aircraft.Text);
                saveAircraftWeight.Parameters.AddWithValue("@AircraftConfiguration", aircraftConfiguration.Text);
                saveAircraftWeight.ExecuteNonQuery();
            }
        }
    }
}
