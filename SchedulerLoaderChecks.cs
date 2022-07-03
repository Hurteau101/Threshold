using System.Data.SqlClient;
using System.Windows.Forms;

namespace Perimeter_Threshold
{
    internal class SchedulerLoaderChecks
    {
        /// <summary>
        /// Check number of rows in master, in which you will compare to see if master should load into Ramp Board. 
        /// </summary>
        /// <returns></returns>
        private static int CheckNumberOfLoadedFlights(DateTimePicker date)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                connection.Open();
                SqlCommand checkRows = new SqlCommand("SELECT COUNT(*) FROM Master_Schedule WHERE Day_Of_Week =@Day_Of_Week", connection);
                checkRows.Parameters.AddWithValue("@Day_Of_Week", date.Value.DayOfWeek.ToString());
                int verifyRows = (int)checkRows.ExecuteScalar();
                return verifyRows;
            }
        }


        /// <summary>
        /// Check the number of rows that method found and copmpare it to the number of rows that are currently on Ramp Board.
        /// If its less then that, load master into Ramp Board. 
        /// </summary>
        /// <returns></returns>
        public static void SchedulerLoaderCheckRamp(DateTimePicker date)
        {
            // FIX THIS ASAP!!!!!

            using (SqlConnection connection = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                connection.Open();
                SqlCommand checkRows = new SqlCommand("SELECT COUNT(*) FROM Ramp_Board WHERE Date_ID =@Date_ID", connection);
                checkRows.Parameters.AddWithValue("@Date_ID", date.Value.Date);
                int verifyRows = (int)checkRows.ExecuteScalar();
                if (verifyRows < CheckNumberOfLoadedFlights(date))
                {
                    ScheduleLoader loadSchedule = new ScheduleLoader(date.Value.DayOfWeek, date.Value.Date);
                    loadSchedule.LoadMasterScheduleRamp();
                }
            }
        }

        /// <summary>
        /// Check the number of rows that method found and copmpare it to the number of rows that are currently on ALC Scheduler.
        /// If its less then that, load master into ALC Scheduler Board. 
        /// </summary>
        /// <returns></returns>
        public static void SchedulerLoaderCheckALC(DateTimePicker date)
        {
            // FIX THIS ASAP!!!!!


            using (SqlConnection connection = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                connection.Open();
                SqlCommand checkRows = new SqlCommand("SELECT COUNT(*) FROM Flight_Schedule_ALC WHERE Date_ID =@Date_ID", connection);
                checkRows.Parameters.AddWithValue("@Date_ID", date.Value.Date);
                int verifyRows = (int)checkRows.ExecuteScalar();
                if (verifyRows < CheckNumberOfLoadedFlights(date))
                {
                    ScheduleLoader loadSchedule = new ScheduleLoader(date.Value.DayOfWeek, date.Value.Date);
                    loadSchedule.LoadMasterScheduleALC();
                }
            }
        }
    }
}
