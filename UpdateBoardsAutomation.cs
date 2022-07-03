using System.Data.SqlClient;

namespace Perimeter_Threshold
{
    class UpdateBoardsAutomation
    {
        /// <summary>
        /// Sets column to 1 in DB. Which means there is a change in database. Timer on RampBoard will check if its 1 and refresh Datagridview. 
        /// </summary>
        public static void UpdateRampBoardStatus()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {

                // CHECK TO SEE IF RAMP BOARD UPDATES ARE WORKING PROPERLY , IF IT IS MAY NEED TO SEPERATE TABLES FOR RAMP AND CARGO

                //conn.Open();
                //SqlCommand updateStatus = new SqlCommand("UPDATE Check_Boards SET Update_Ramp_Board =@Update_Ramp_Board", conn);
                //updateStatus.Parameters.AddWithValue("@Update_Ramp_Board", 1);
                //updateStatus.ExecuteNonQuery();

                conn.Open();
                SqlCommand updateStatus = new SqlCommand("UPDATE CheckBoard SET RampBoard =@RampBoard", conn);
                updateStatus.Parameters.AddWithValue("@RampBoard", 1);
                updateStatus.ExecuteNonQuery();

            }
        }

        /// <summary>
        /// Sets column to 1 in DB. Which means there is a change in database. Timer on cargoboard will check if its 1 and refresh Datagridview. 
        /// </summary>
        public static void UpdateCargoBoardStatus()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                conn.Open();
                SqlCommand updateStatus = new SqlCommand("UPDATE Check_Boards SET Update_Cargo_Board =@Update_Cargo_Board", conn);
                updateStatus.Parameters.AddWithValue("@Update_Cargo_Board", 1);
                updateStatus.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Check DB to see if its 1 or 0. If it's 1, then return true, which will allow Ramp Board to refresh, if returns false, do nothing.
        /// </summary>
        /// <returns></returns>
        public static bool CheckRampBoardStatus()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                // CHECK TO SEE IF RAMP BOARD UPDATES ARE WORKING PROPERLY , IF IT IS MAY NEED TO SEPERATE TABLES FOR RAMP AND CARGO

                //string holdValue;

                //conn.Open();
                //SqlCommand checkStatus = new SqlCommand("SELECT Update_Ramp_Board FROM Check_Boards", conn);
                //SqlDataReader readStatus = checkStatus.ExecuteReader();
                //if(readStatus.Read())
                //{
                //    holdValue = (readStatus["Update_Ramp_Board"].ToString());

                //    if(holdValue == "1")
                //    {
                //        return true;
                //    }
                //}

                //return false;

                string holdValue;

                conn.Open();
                SqlCommand checkStatus = new SqlCommand("SELECT RampBoard FROM CheckBoard", conn);
                SqlDataReader readStatus = checkStatus.ExecuteReader();
                if (readStatus.Read())
                {
                    holdValue = (readStatus["RampBoard"].ToString());

                    if (holdValue == "1")
                    {
                        return true;
                    }
                }

                return false;
            }
        }

        /// <summary>
        /// Check DB to see if its 1 or 0. If it's 1, then return true, which will allow cargo Board to refresh, if returns false, do nothing.
        /// </summary>
        /// <returns></returns>
        public static bool CheckCargoBoardStatus()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                string holdValue;

                conn.Open();
                SqlCommand checkStatus = new SqlCommand("SELECT Update_Cargo_Board FROM Check_Boards", conn);
                SqlDataReader readStatus = checkStatus.ExecuteReader();
                if (readStatus.Read())
                {
                    holdValue = (readStatus["Update_Cargo_Board"].ToString());

                    if (holdValue == "1")
                    {
                        return true;
                    }
                }

                return false;
            }
        }

        /// <summary>
        /// After board has been refreshed, reset DB column to 0, so it doesn't keep refreshing board. 
        /// </summary>
        public static void FinishRampUpdate()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                // CHECK TO SEE IF RAMP BOARD UPDATES ARE WORKING PROPERLY , IF IT IS MAY NEED TO SEPERATE TABLES FOR RAMP AND CARGO

                //conn.Open();
                //SqlCommand updateStatus = new SqlCommand("UPDATE Check_Boards SET Update_Ramp_Board =@Update_Ramp_Board", conn);
                //updateStatus.Parameters.AddWithValue("@Update_Ramp_Board", 0);
                //updateStatus.ExecuteNonQuery();

                conn.Open();
                SqlCommand updateStatus = new SqlCommand("UPDATE CheckBoard SET RampBoard =@RampBoard", conn);
                updateStatus.Parameters.AddWithValue("@RampBoard", 0);
                updateStatus.ExecuteNonQuery();

            }
        }

        /// <summary>
        /// After board has been refreshed, reset DB column to 0, so it doesn't keep refreshing board. 
        /// </summary>
        public static void FinishCargoUpdate()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                conn.Open();
                SqlCommand updateStatus = new SqlCommand("UPDATE Check_Boards SET Update_Cargo_Board =@Update_Cargo_Board", conn);
                updateStatus.Parameters.AddWithValue("@Update_Cargo_Board", 0);
                updateStatus.ExecuteNonQuery();
            }
        }
    }
}
