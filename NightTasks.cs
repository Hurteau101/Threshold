using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Perimeter_Threshold
{
    public class NightTasks
    {
        public DateTime Date { get; set; }
        public string Seatpacks { get; set; }
        public string NightTask { get; set; }
        public Button Save { get; set; }
        public string Time { get; set; }


        public NightTasks(DateTime date, string seatpacks, string nightTask)
        {
            Date = date;
            Seatpacks = seatpacks;
            NightTask = nightTask;
        }

        /// <summary>
        /// Load Night Seatpacks depending on Date. 
        /// </summary>
        /// <param name="date"></param>
        /// <param name="seatpack"></param>
        public bool LoadNightSeatpacks()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                conn.Open();
                SqlCommand loadData = new SqlCommand("Load_Night_Seatpacks", conn);
                loadData.CommandType = CommandType.StoredProcedure;
                loadData.Parameters.AddWithValue("@DateID", Date);
                SqlDataReader readData = loadData.ExecuteReader();
                if (readData.Read())
                {
                    Seatpacks = (readData["Seatpack_List"].ToString());
                    // Boolean, to check if there is any data. If it can't find data, it will return false, which will allow textbox to be set to empty. 
                    return true;
                }
                return false;
            }
        }

        /// <summary>
        /// Load Night tasks depending on Date. 
        /// </summary>
        /// <param name="date"></param>
        /// <param name="nightTask"></param>
        public bool LoadNightTask()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                conn.Open();
                SqlCommand loadData = new SqlCommand("Load_Night_Task", conn);
                loadData.CommandType = CommandType.StoredProcedure;
                loadData.Parameters.AddWithValue("@DateID", Date);
                SqlDataReader readData = loadData.ExecuteReader();
                if (readData.Read())
                {
                    NightTask = (readData["Night_Task"].ToString());
                    // Boolean, to check if there is any data. If it can't find data, it will return false, which will allow textbox to be set to empty. 
                    return true;
                }

                return false;
            }
        }

        /// <summary>
        /// Load last updated time. 
        /// </summary>
        /// <param name="date"></param>
        /// <param name="Time"></param>
        public bool LoadUpdateTime()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                conn.Open();
                SqlCommand loadUpdateTime = new SqlCommand("Load_Update_Time", conn);
                loadUpdateTime.CommandType = CommandType.StoredProcedure;
                loadUpdateTime.Parameters.AddWithValue("@DateID", Date);
                SqlDataReader readTime = loadUpdateTime.ExecuteReader();
                if (readTime.Read())
                {
                    Time = (readTime["Time_Updated"].ToString());
                    return true;
                }
                return false;
            }
        }

        /// <summary>
        /// Prevent editing on previous dates. 
        /// </summary>
        /// <param name="date"></param>
        /// <param name="nightSeatpacks"></param>
        /// <param name="nightTask"></param>
        /// <returns></returns>
        public static bool DateCheckValid(DateTime date, RichTextBox nightSeatpacks, RichTextBox nightTask, Button save)
        {
            if (date < DateTime.Now.Date)
            {
                nightSeatpacks.ReadOnly = true;
                nightTask.ReadOnly = true;
                nightSeatpacks.BackColor = System.Drawing.Color.LightGray;
                nightTask.BackColor = System.Drawing.Color.LightGray;
                save.Enabled = false;
                save.BackColor = System.Drawing.Color.LightGray;
                return true;
            }
            else
            {
                nightSeatpacks.ReadOnly = false;
                nightTask.ReadOnly = false;
                nightSeatpacks.BackColor = System.Drawing.SystemColors.Window;
                nightTask.BackColor = System.Drawing.SystemColors.Window;
                save.Enabled = true;
                save.BackColor = System.Drawing.Color.FromArgb(243, 112, 34);
                return false;
            }
        }

        /// <summary>
        /// Save Night Checklist in database. 
        /// </summary>
        /// <param name="date"></param>
        /// <param name="nightSeatpacks"></param>
        /// <param name="nightTask"></param>
        public void SaveChanges()
        {
            var currentTime = DateTime.Now.ToString("f");

            using (SqlConnection conn = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                conn.Open();
                SqlCommand saveChanged = new SqlCommand("Save_Changes_NightChecklist", conn);
                saveChanged.CommandType = CommandType.StoredProcedure;
                saveChanged.Parameters.AddWithValue("@NightSeatpack", Seatpacks);
                saveChanged.Parameters.AddWithValue("@NightTask", NightTask);
                saveChanged.Parameters.AddWithValue("@TimeUpdated", currentTime);
                saveChanged.Parameters.AddWithValue("@DateID", Date);
                saveChanged.ExecuteNonQuery();

                MessageBox.Show("Night Checklist Saved", "Save Sucessful", MessageBoxButtons.OK);
            }
        }
    }
}



