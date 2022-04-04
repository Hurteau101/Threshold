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
            var validLogin = loginUser.CheckValidCredentials(tbUsername.Text, tbPassword.Text);
            if (validLogin.Item1)
            {      
                RampBoard openRampBoard = new RampBoard();
                openRampBoard.Name = loginUser.FullName;
                openRampBoard.Show();
            }
        }

    }
}
