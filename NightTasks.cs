using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Perimeter_Threshold
{
    public class NightTasks
    {
        /// <summary>
        /// Load Night Seatpacks depending on Date. 
        /// </summary>
        /// <param name="date"></param>
        /// <param name="seatpack"></param>
        public void LoadNightSeatpacks(DateTime date, RichTextBox seatpack)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionLoader.ConnectionString("LoadPlanner")))
            {
                conn.Open();
                SqlCommand loadData = new SqlCommand("SELECT SeatpackNumber FROM NightChecklist WHERE DateID = @DateID", conn);
                loadData.Parameters.AddWithValue("@DateID", date);
                SqlDataReader readData = loadData.ExecuteReader();
                if(readData.Read())
                {
                    seatpack.Text = (readData["SeatpackNumber"].ToString());
                }
            }
        }

        /// <summary>
        /// Load Night tasks depending on Date. 
        /// </summary>
        /// <param name="date"></param>
        /// <param name="nightTask"></param>
        public void LoadNightTask(DateTime date, RichTextBox nightTask)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionLoader.ConnectionString("LoadPlanner")))
            {
                conn.Open();
                SqlCommand loadData = new SqlCommand("SELECT NightTask FROM NightChecklist WHERE DateID = @DateID", conn);
                loadData.Parameters.AddWithValue("@DateID", date);
                SqlDataReader readData = loadData.ExecuteReader();
                if (readData.Read())
                {
                    nightTask.Text = (readData["NightTask"].ToString());
                }
            }
        }

        /// <summary>
        /// Prevent editing on previous dates. 
        /// </summary>
        /// <param name="date"></param>
        /// <param name="nightSeatpacks"></param>
        /// <param name="nightTask"></param>
        /// <returns></returns>
        public static bool DateCheckValid (DateTime date, RichTextBox nightSeatpacks, RichTextBox nightTask, Button save)
        {
            if(date < DateTime.Now.Date)
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
        public static void SaveChanges (DateTime date, RichTextBox nightSeatpacks, RichTextBox nightTask)
        {          
            using(SqlConnection conn = new SqlConnection(ConnectionLoader.ConnectionString("LoadPlanner")))
            {
                conn.Open();
                SqlCommand saveInformation = new SqlCommand("SELECT 1 FROM NightCheckList WHERE DateID = @DateID", conn);
                saveInformation.Parameters.AddWithValue("@DateID", date);
                var rowsCounted = (int)saveInformation.ExecuteScalar() > 0; // Check if it finds any rows in Database. If it does - update  | If not - insert. 
                if(rowsCounted)
                {
                    conn.Open();
                    SqlCommand updateInformation = new SqlCommand("UPDATE NightChecklist SET SeatpackNumber = @SeatpackNumber, NightTask =@NightTask, DateID =@DateID", conn);
                    updateInformation.Parameters.AddWithValue("@SeatpackNumber", nightSeatpacks);
                    updateInformation.Parameters.AddWithValue("@NightTask", nightTask);
                    updateInformation.Parameters.AddWithValue("@DateID", date);
                  
                }
                else
                {
                    conn.Open();
                    SqlCommand insertInformation = new SqlCommand("INSERT INTO NightCheckList (SeatpackNumber, NightTask, DateID) VALUES (@SeatpackNumber, @NightTask, " +
                        "@DateID)", conn);
                    insertInformation.Parameters.AddWithValue("@SeatpackNumber", nightSeatpacks);
                    insertInformation.Parameters.AddWithValue("@NightTask", nightTask);
                    insertInformation.Parameters.AddWithValue("@DateID", date);
                }

                MessageBox.Show("Night Checklist Saved", "Save Sucessful", MessageBoxButtons.OK);
            }
        }
    }
}
