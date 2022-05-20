using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Dapper;

namespace Perimeter_Threshold
{
    public class SaveDataALC
    {
        /// <summary>
        /// Save Flight to Database. 
        /// </summary>
        /// <param name="details"></param>
        public static void SaveFlight(FlightDetail details)
        {
            using (IDbConnection con = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                con.Execute("Save_Leg_Loadplanner", details, commandType: CommandType.StoredProcedure);
  
            }           
        }

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
