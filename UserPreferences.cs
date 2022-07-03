using System;
using System.Data.SqlClient;

namespace Perimeter_Threshold
{
    class UserPreferences
    {
        public int EarlyColor { get; set; }
        public int OnTimeColor { get; set; }
        public int LateColor { get; set; }
        public int ArrivalColor { get; set; }
        public int UnserviceableColor { get; set; }
        public int CompletionColor { get; set; }
        public int UserID { get; set; }
        public int RGBColor { get; set; }
        public string UserSaveSelection { get; set; }

        public UserPreferences(int userID, int rgbColor)
        {
            UserID = userID;
            RGBColor = rgbColor;
        }

        public UserPreferences()
        {

        }

        /// <summary>
        /// Save Color to database. This will save to user preference and be loaded all the time, for their color preference. 
        /// </summary>
        public void SaveColors()
        {
            using(SqlConnection conn = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                conn.Open();
                using (SqlCommand selectData = new SqlCommand($"SELECT {UserSaveSelection} FROM User_Preferences WHERE User_IDs =@User_IDs", conn))
                {
                    selectData.Parameters.AddWithValue("@User_Ids", UserID);
                    SqlDataReader readData = selectData.ExecuteReader();
                    if (readData.Read())
                    {
                        using (SqlCommand updateDate = new SqlCommand($"UPDATE User_Preferences SET {UserSaveSelection} =@{UserSaveSelection} " +
                            "WHERE User_Ids =@User_Ids", conn))
                        {
                            updateDate.Parameters.AddWithValue($"@{UserSaveSelection}", RGBColor);
                            updateDate.Parameters.AddWithValue("@User_Ids", UserID);
                            updateDate.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        using (SqlCommand insertData = new SqlCommand($"INSERT INTO User_Preferences ({UserSaveSelection}, User_IDs) VALUES (@{UserSaveSelection}, " +
                            "@User_Ids)", conn))
                        {
                            insertData.Parameters.AddWithValue($"@{UserSaveSelection}", RGBColor);
                            insertData.Parameters.AddWithValue("@User_Ids", UserID);
                            insertData.ExecuteNonQuery();

                        }
                    }
                }
            }
        }

        /// <summary>
        /// Load User Preference Color(s) from Database.
        /// </summary>
        public void LoadPreferenecs()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                conn.Open();
                SqlCommand loadColors = new SqlCommand("SELECT * FROM User_Preferences WHERE User_IDs =@User_Ids", conn);
                loadColors.Parameters.AddWithValue("@User_Ids", UserID);
                SqlDataReader readColors = loadColors.ExecuteReader();
                if (readColors.Read())
                {                   
                    EarlyColor = Int32.Parse((readColors["Ramp_Early_Color"].ToString()));
                    OnTimeColor = Int32.Parse((readColors["Ramp_OnTime_Color"].ToString()));
                    LateColor = Int32.Parse((readColors["Ramp_Late_Color"].ToString()));
                    ArrivalColor = Int32.Parse((readColors["Ramp_Arrival_Color"].ToString()));
                    UnserviceableColor = Int32.Parse((readColors["Ramp_AC_Unserviceable_Color"].ToString()));
                    CompletionColor = Int32.Parse((readColors["Cargo_Completion_Color"].ToString()));
                }
            }
        }
    }
}
