using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Perimeter_Threshold
{
    public partial class UserModification : Form
    {
        public int RoleID { get; set; }

        public UserModification()
        {
            InitializeComponent();
        }

        /// ****** WILL NEED TO FIX THIS FORM  FOR MODIFICATIONS. IT JUST ADDS USERS WITH NO CHECKS OF IF USER NAME EXISTS OR ANYTHIN *******
        private void btnModifyUser_Click(object sender, EventArgs e)
        {
            if (tbConfPw.Text != tbPassword.Text)
            {
                MessageBox.Show("Password's don't match, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbPassword.Clear();
                tbConfPw.Clear();
            }
            else
            {
                // Ramp Agent
                if (cbRoleID.SelectedIndex == 0)
                {
                    RoleID = 6;
                }
                // Ramp Supervisor
                else if (cbRoleID.SelectedIndex == 1)
                {
                    RoleID = 1;
                }
                // Ramp Manager
                else if (cbRoleID.SelectedIndex == 2)
                {
                    RoleID = 4;
                }
                // Cargo Agent
                else if (cbRoleID.SelectedIndex == 3)
                {
                    RoleID = 7;
                }
                // Cargo Supervsior
                else if (cbRoleID.SelectedIndex == 4)
                {
                    RoleID = 2;
                }
                // Cargo Manager
                else if (cbRoleID.SelectedIndex == 5)
                {
                    RoleID = 5;
                }
                // ALC
                else if (cbRoleID.SelectedIndex == 6)
                {
                    RoleID = 3;
                }
                // Admin 
                else if (cbRoleID.SelectedIndex == 7)
                {
                    RoleID = 8;
                }
                // Network Planner
                else if (cbRoleID.SelectedIndex == 8)
                {
                    RoleID = 9;
                }
                // Cargo Coordinator
                else if (cbRoleID.SelectedIndex == 9)
                {
                    RoleID = 10;
                }
                // Directory of Cargo 
                else if (cbRoleID.SelectedIndex == 10)
                {
                    RoleID = 11;
                }
                // Charters
                else if (cbRoleID.SelectedIndex == 11)
                {
                    RoleID = 12;
                }
                // Manifestor
                else if (cbRoleID.SelectedIndex == 12)
                {
                    RoleID = 13;
                }
                else if (cbRoleID.SelectedIndex == 13)
                {
                    RoleID = 14;
                }

                using (SqlConnection connection = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
                {
                    connection.Open();
                    SqlCommand addUser = new SqlCommand("AddUser", connection);
                    addUser.CommandType = CommandType.StoredProcedure;
                    addUser.Parameters.AddWithValue("@FirstName", tbFirstName.Text);
                    addUser.Parameters.AddWithValue("@LastName", tbLastName.Text);
                    addUser.Parameters.AddWithValue("@Username", tbUsername.Text);
                    addUser.Parameters.AddWithValue("@Password", tbPassword.Text);
                    addUser.Parameters.AddWithValue("@RoleID", RoleID);
                    int userID = (int)addUser.ExecuteScalar();
                    if (userID < 0)
                    {
                        MessageBox.Show("Duplicate User Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    connection.Close();

                    if (userID > 0)
                    {
                        connection.Open();
                        SqlCommand addUserColor = new SqlCommand("NewUserColors", connection);
                        addUserColor.CommandType = CommandType.StoredProcedure;
                        addUserColor.Parameters.AddWithValue("@UserID", userID);
                        addUserColor.Parameters.AddWithValue("@EarlyColor", -16725504);
                        addUserColor.Parameters.AddWithValue("@OnTimeColor", -16777216);
                        addUserColor.Parameters.AddWithValue("@LateColor", -65536);
                        addUserColor.Parameters.AddWithValue("@ArrivalColor", -8355712);
                        addUserColor.Parameters.AddWithValue("@UnserviceableColor", -256);
                        addUserColor.Parameters.AddWithValue("@CargoCompletionColor", -4144960);
                        addUserColor.ExecuteNonQuery();
                        MessageBox.Show("User Sucessfully Added", "User Sucess", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        // Clear textboxes, after flight has been added. 
                        foreach (Control control in Controls)
                            if (control is TextBox)
                            {
                                control.ResetText();
                            }
                        cbRoleID.SelectedIndex = -1;
                    }
                }
            }
        }
    }
}
