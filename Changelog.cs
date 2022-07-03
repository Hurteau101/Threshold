using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perimeter_Threshold
{
    public partial class Changelog : Form
    {
        public int RoleId { get; set; }

        public Changelog()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load changelog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Changelog_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                connection.Open();
                SqlCommand findChangeLog = new SqlCommand("SELECT DisplayChangeLog FROM ChangeLog", connection);
                SqlDataReader readChangeLog = findChangeLog.ExecuteReader();
                if(readChangeLog.Read())
                {
                    rchChangeLog.Text = (readChangeLog["DisplayChangeLog"].ToString());
                }
            }
        }

        private void Changelog_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Check if user is admin to update the change log. 
            if (RoleId == 8)
            {
                using (SqlConnection connection = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
                {
                    connection.Open();
                    SqlCommand updateChangeLog = new SqlCommand("Update ChangeLog SET DisplayChangeLog =@DisplayChangeLog", connection);
                    updateChangeLog.Parameters.AddWithValue("@DisplayChangeLog", rchChangeLog.Text);
                    updateChangeLog.ExecuteNonQuery();
                }
            }
        }
    }
}
