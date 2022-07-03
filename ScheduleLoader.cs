using System;
using System.Data;
using System.Data.SqlClient;

namespace Perimeter_Threshold
{
    class ScheduleLoader
    {
        public DayOfWeek DayOfWeek { get; set; }
        public DateTime Date { get; set; }

        public ScheduleLoader(DayOfWeek dayOfWeek, DateTime date)
        {
            DayOfWeek = dayOfWeek;
            Date = date;
        }

        public ScheduleLoader(DateTime date)
        {
            Date = date;
        }

        /// <summary>
        /// Push Master Schedule of Flights to Ramp Board. 
        /// </summary>
        public void LoadMasterScheduleRamp()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {

                conn.Open();
                SqlCommand loadSchedule = new SqlCommand("Master_Scheduler_Loader_Ramp", conn);
                loadSchedule.CommandType = CommandType.StoredProcedure;
                loadSchedule.Parameters.AddWithValue("@DateID", Date);
                loadSchedule.Parameters.AddWithValue("@Day_Of_Week", DayOfWeek.ToString());
                loadSchedule.ExecuteNonQuery();              
            }
        }

        /// <summary>
        /// Push Master Schedule of Flights to ALC Scheduler Board. 
        /// </summary>
        public void LoadMasterScheduleALC()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                conn.Open();
                SqlCommand loadSchedule = new SqlCommand("Master_Scheduler_Loader_ALC", conn);
                loadSchedule.CommandType = CommandType.StoredProcedure;
                loadSchedule.Parameters.AddWithValue("@DateID", Date);
                loadSchedule.Parameters.AddWithValue("@Day_Of_Week", DayOfWeek.ToString());
                loadSchedule.ExecuteNonQuery();
            }
        }
    }
}
