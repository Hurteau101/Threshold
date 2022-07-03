using Dapper;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Perimeter_Threshold
{
    public class LoadPlannerBoardUpdates : AddFlight
    { 
        /// <summary>
        /// Check if flight exists in database, if it does update ramp board from load planner. 
        /// </summary>
        /// <param name="updaterDetails"></param>
        /// <param name="flightNumber"></param>
        /// <param name="date"></param>
        public static void RampBoardPusher(LoadPlannerBoardUpdates updaterDetails, string flightNumber, DateTime date)
        {
            using (IDbConnection conn = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                // Check if flight exist in database first. 
                const string sql = "SELECT CAST(CASE WHEN EXISTS (SELECT 1 FROM Ramp_Board WHERE Date_ID =@Date_ID AND Flight_Number =@Flight_Number) THEN 1 ELSE 0 END as BIT)";
                bool flightExists = conn.ExecuteScalar<bool>(sql, new LoadPlannerBoardUpdates { Flight_Number = flightNumber, Date_ID = date });

                if (flightExists)
                {
                    string sql2 = $"UPDATE Ramp_Board SET Aircraft =@Aircraft, Routing =@Main_Routing, Departure =@Departure, " +
                        $"Seatpacks = @Seatpacks, Load_Coordinator_Remarks = @ALCRemark, Aircraft_Location =@Aircraft_Location " +
                        $"WHERE Flight_Number = @Flight_Number AND Date_ID = @Date_ID";

                    conn.Query<LoadPlannerBoardUpdates>(sql2, updaterDetails);

                    UpdateBoardsAutomation.UpdateRampBoardStatus();
                }
                else
                {
                    string sql2 = $"INSERT INTO Ramp_Board (Date_ID, Flight_Number, Aircraft, Routing, Departure, Seatpacks, Load_Coordinator_Remarks, Aircraft_Location) " +
                        $"VALUES(@Date_ID, @Flight_Number, @Aircraft, @Main_Routing, @Departure, @Seatpacks, @ALCRemark, @Aircraft_Location)";

                    conn.Query<LoadPlannerBoardUpdates>(sql2, updaterDetails);

                    UpdateBoardsAutomation.UpdateRampBoardStatus();
                }
            }
        }

        /// <summary>
        ///  Check if flight exists in database, if it does update cargo board from load planner. 
        /// </summary>
        /// <param name="updaterDetails"></param>
        /// <param name="flightNumber"></param>
        /// <param name="date"></param>
        public static void CargoBoardPusher(LoadPlannerBoardUpdates updaterDetails, string flightNumber, DateTime date)
        {
            using (IDbConnection conn = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                // Check if flight exist in database first. 
                const string sql = "SELECT CAST(CASE WHEN EXISTS (SELECT 1 FROM Cargo_Board WHERE Date_ID =@Date_ID AND Flight_Number =@Flight_Number) THEN 1 ELSE 0 END as BIT)";
                bool flightExists = conn.ExecuteScalar<bool>(sql, new LoadPlannerBoardUpdates { Flight_Number = flightNumber, Date_ID = date });

                if (flightExists)
                {
                    string sql2 = $"UPDATE Cargo_Board SET Routing =@Main_Routing, Weight_Given =@Weight_Given, Departure =@Departure, Seatpacks =@Seatpacks, Aircraft =@Aircraft, Cargo_Notes =@Cargo_Notes " +
                        $"WHERE Flight_Number = @Flight_Number AND Date_ID = @Date_ID";

                    conn.Query<LoadPlannerBoardUpdates>(sql2, updaterDetails);

                    UpdateBoardsAutomation.UpdateCargoBoardStatus();
                }
                else
                {
                    string sql2 = $"INSERT INTO Cargo_Board (Date_ID, Flight_Number, Routing, Weight_Given, Departure, Seatpacks, Aircraft, Cargo_Notes) " +
                        $"VALUES(@Date_ID, @Flight_Number, @Main_Routing, @Weight_Given, @Departure, @Seatpacks, @Aircraft, @Cargo_Notes)";


                    conn.Query<LoadPlannerBoardUpdates>(sql2, updaterDetails);

                    UpdateBoardsAutomation.UpdateCargoBoardStatus();
                }
            }
        }

        public static void SeatblockFinder(string flightNumber, DateTimePicker date)
        {
            using(SqlConnection connection = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                connection.Open();
                SqlCommand findSeatblock = new SqlCommand("SELECT 1 FROM Seatblocks WHERE Date_ID =@Date_ID AND Flight_Number =@Flight_Number", connection);
                findSeatblock.Parameters.AddWithValue("@Date_ID", date.Value.Date);
                findSeatblock.Parameters.AddWithValue("@Flight_Number", flightNumber);
                int seatblock = (int)findSeatblock.ExecuteScalar();
                if (seatblock > 0)
                {

                }

            }
        }
    }
}
