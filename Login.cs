using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Perimeter_Threshold
{
    /// <summary>
    /// Roles:
    /// Role-ID = 1 [Ramp Supervisor]
    /// Role-ID = 2 [Cargo Supervisor]
    /// Role-ID = 3 [ALC]
    /// Role-ID = 4 [Ramp Manager]
    /// Role-ID = 5 [Cargo Manager]
    /// Role-ID = 6 [Admin]
    /// </summary>
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Create instance of User. Check if valid user returns true, if it does open appropriate form. 
            Users loginUser = new Users();
            RampBoard rampBoard = new RampBoard();
            CargoBoard cargoBoard = new CargoBoard();
            LoadPlanner loadPlan = new LoadPlanner();


            var validLogin = loginUser.CheckValidCredentials(tbUsername.Text, tbPassword.Text);
            if (validLogin.Item1)
            {      
                if(loginUser.RoleID == 1)
                {

                }
                else if(loginUser.RoleID ==2)
                {
                    
                }
                else if(loginUser.RoleID ==3)
                {
                    rampBoard.Name = loginUser.FullName;
                    rampBoard.UserID = loginUser.UserID;
                    rampBoard.Show();
                }
                else if(loginUser.RoleID == 4)
                {

                }
                else if (loginUser.RoleID == 5)
                {

                }
                else if (loginUser.RoleID == 6)
                {

                }         
            }
        }

    }
}
