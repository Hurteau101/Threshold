using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;


namespace Perimeter_Threshold
{
    public class Users
    {
        public string Username { get; set; }
        public int RoleID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return $"Welcome, {FirstName} {LastName}"; } }
        public string Password { get; set; }
        public int UserID { get; set; }



        /// *** WHEN CREATING A PAGE FOR CREATE A USER. MAKE SURE YOU SET USER PREFERENCE DEFAULTS OR ELSE PREFERENCES WILL THROW ERRORS SINCE IT WILL 
        /// BE NULL IN THE DATABASE. 

        /// <summary>
        /// Check if user is valid or not. If user is valid, return true and their username. Also check if its password or username that doesn't exist. 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public (bool, string) CheckValidCredentials(string username, string password)
        {
            /// <summary>
            /// * Nested loop to first check if username exist, if it does, check username & password combination.  
            /// * If valid user, store RoleID & Username in property. 
            /// * Return tuple to evaluate if its a valid user or not. 
            /// </summary>
            
            using (SqlConnection connection = new SqlConnection(ConnectionLoader.ConnectionString("Threshold")))
            {
                connection.Open();
                SqlCommand findUser = new SqlCommand("SELECT * FROM Users WHERE User_Username =@User_Username", connection);
                findUser.Parameters.AddWithValue("@User_Username", username);
                SqlDataReader searchUser = findUser.ExecuteReader();
                if (searchUser.Read())
                {
                    SqlCommand validCredentials = new SqlCommand("LoginVerfication", connection);
                    validCredentials.CommandType = CommandType.StoredProcedure;
                    validCredentials.Parameters.AddWithValue("@Username", username);
                    validCredentials.Parameters.AddWithValue("@Password", password);
                    SqlDataReader readCredentials = validCredentials.ExecuteReader();
                    if (readCredentials.Read())
                    {
                        Username = (readCredentials["User_Username"].ToString());
                        RoleID = Convert.ToInt32(readCredentials["Role_ID"].ToString());
                        UserID = Convert.ToInt32(readCredentials["User_IDs"].ToString());
                        FirstName = (readCredentials["First_Name"].ToString());
                        LastName = (readCredentials["Last_Name"].ToString());
                        return (true, username);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Password");
                        return (false, String.Empty);
                    }
                }
                else
                {
                    MessageBox.Show("User doesn't exist");
                    return (false, String.Empty);
                }
            }
        }

    }
}
