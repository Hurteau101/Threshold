using System;
using System.Windows.Forms;


namespace Perimeter_Threshold
{
    /// <summary>
    /// Roles:
    /// Role-ID = 1 [Ramp Supervisor]
    /// Role-ID = 2 [Cargo Supervisor]
    /// Role-ID = 3 [ALC]
    /// Role-ID = 4 [Ramp Manager]
    /// Role-ID = 5 [Cargo Manager]
    /// Role-ID = 6 [Ramp Agent]
    /// Role-ID = 7 [Cargo Agent]
    /// Role-ID = 8 [Admin]
    /// Role-ID = 9 [Network Planner]
    /// Role-ID = 10 [Cargo Coordinator]
    /// Role-ID = 11 [Directory of Cargo]
    /// Role-ID = 12 [Charter]
    /// Role-ID = 13 [Manifestor]
    /// Role-ID = 14 [VIP]
    /// </summary>
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void EnterKeyLogin(KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(this, new EventArgs());
            }
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
                // Ramp Supervisor
                if (loginUser.RoleID == 1)
                {
                    RampBoard rampBoard = new RampBoard();
                    var screen = Screen.FromPoint(Cursor.Position);
                    rampBoard.StartPosition = FormStartPosition.Manual;
                    rampBoard.Left = screen.Bounds.Left + screen.Bounds.Width / 2 - rampBoard.Width / 2;
                    rampBoard.Top = screen.Bounds.Top + screen.Bounds.Height / 2 - rampBoard.Height / 2;

                    rampBoard.FullName = loginUser.FullName;
                    rampBoard.UserID = loginUser.UserID;
                    rampBoard.RoleID = loginUser.RoleID;
                    Permissions loadPermissions = new Permissions();
                    loadPermissions.ListOfMenus.Add(rampBoard.menuStripDelays, typeof(ToolStripMenuItem));
                    loadPermissions.ListOfMenus.Add(rampBoard.subMenuMasterSchedule, typeof(ToolStripMenuItem));
                    loadPermissions.MenuStripPermission();
                    rampBoard.Show();
                }
                // Cargo Supervisor
                else if (loginUser.RoleID == 2)
                {
                    CargoBoard cargoBoard = new CargoBoard();
                    var screen = Screen.FromPoint(Cursor.Position);
                    cargoBoard.StartPosition = FormStartPosition.Manual;
                    cargoBoard.Left = screen.Bounds.Left + screen.Bounds.Width / 2 - cargoBoard.Width / 2;
                    cargoBoard.Top = screen.Bounds.Top + screen.Bounds.Height / 2 - cargoBoard.Height / 2;

                    Permissions loadPermissions = new Permissions();
                    loadPermissions.ListOfMenus.Add(cargoBoard.subMenuDeleteFlight, typeof(ToolStripMenuItem));
                    loadPermissions.ListOfMenus.Add(cargoBoard.menuStripFlightManager, typeof(ToolStripMenuItem));
                    loadPermissions.MenuStripPermission();
                    cargoBoard.FullName = loginUser.FullName;
                    cargoBoard.UserID = loginUser.UserID;
                    cargoBoard.RoleID = loginUser.RoleID;
                    cargoBoard.Show();
                }
                // ALC
                else if (loginUser.RoleID == 3)
                {
                    LoadPlanner loadPlan = new LoadPlanner();

                    var screen = Screen.FromPoint(Cursor.Position);
                    loadPlan.StartPosition = FormStartPosition.Manual;
                    loadPlan.Left = screen.Bounds.Left + screen.Bounds.Width / 2 - loadPlan.Width / 2;
                    loadPlan.Top = screen.Bounds.Top + screen.Bounds.Height / 2 - loadPlan.Height / 2;

                    loadPlan.FullName = loginUser.FullName;
                    loadPlan.UserID = loginUser.UserID;
                    loadPlan.RoleID = loginUser.RoleID;
                    loadPlan.Show();

                }
                // Ramp Manager
                else if (loginUser.RoleID == 4)
                {
                    RampBoard rampBoard = new RampBoard();
                    var screen = Screen.FromPoint(Cursor.Position);
                    rampBoard.StartPosition = FormStartPosition.Manual;
                    rampBoard.Left = screen.Bounds.Left + screen.Bounds.Width / 2 - rampBoard.Width / 2;
                    rampBoard.Top = screen.Bounds.Top + screen.Bounds.Height / 2 - rampBoard.Height / 2;

                    rampBoard.FullName = loginUser.FullName;
                    rampBoard.UserID = loginUser.UserID;
                    rampBoard.RoleID = loginUser.RoleID;
                    Permissions loadPermissions = new Permissions();
                    loadPermissions.ListOfMenus.Add(rampBoard.menuStripDelays, typeof(ToolStripMenuItem));
                    loadPermissions.MenuStripPermission();
                    rampBoard.Show();
                }
                // Cargo Manager
                else if (loginUser.RoleID == 5)
                {
                    CargoBoard cargoBoard = new CargoBoard();
                    var screen = Screen.FromPoint(Cursor.Position);
                    cargoBoard.StartPosition = FormStartPosition.Manual;
                    cargoBoard.Left = screen.Bounds.Left + screen.Bounds.Width / 2 - cargoBoard.Width / 2;
                    cargoBoard.Top = screen.Bounds.Top + screen.Bounds.Height / 2 - cargoBoard.Height / 2;

                    cargoBoard.FullName = loginUser.FullName;
                    cargoBoard.UserID = loginUser.UserID;
                    cargoBoard.RoleID = loginUser.RoleID;
                    cargoBoard.Show();

                }
                // Ramp Agent Login
                else if (loginUser.RoleID == 6)
                {
                    RampBoard rampBoard = new RampBoard();
                    var screen = Screen.FromPoint(Cursor.Position);
                    rampBoard.StartPosition = FormStartPosition.Manual;
                    rampBoard.Left = screen.Bounds.Left + screen.Bounds.Width / 2 - rampBoard.Width / 2;
                    rampBoard.Top = screen.Bounds.Top + screen.Bounds.Height / 2 - rampBoard.Height / 2;

                    rampBoard.FullName = loginUser.FullName;
                    rampBoard.UserID = loginUser.UserID;
                    rampBoard.RoleID = loginUser.RoleID;
                    Permissions loadPermissions = new Permissions();
                    loadPermissions.ListOfMenus.Add(rampBoard.menuStripDelays, typeof(ToolStripMenuItem));
                    loadPermissions.ListOfMenus.Add(rampBoard.subMenuMasterSchedule, typeof(ToolStripMenuItem));
                    loadPermissions.ListOfMenus.Add(rampBoard.menuStripFlights, typeof(ToolStripMenuItem));
                    loadPermissions.ListOfMenus.Add(rampBoard.setAircraftStatusToolStripMenuItem, typeof(ContextMenuStrip));
                    loadPermissions.ListOfMenus.Add(rampBoard.subMenuDeleteFlight, typeof(ContextMenuStrip));
                    loadPermissions.MenuStripPermission();
                    rampBoard.Show();
                    loadPermissions.ReadOnlyPermissionRamp(rampBoard.dgvRampBoard);
                }
                // Cargo Agent Login
                else if (loginUser.RoleID == 7)
                {
                    CargoBoard cargoBoard = new CargoBoard();
                    var screen = Screen.FromPoint(Cursor.Position);
                    cargoBoard.StartPosition = FormStartPosition.Manual;
                    cargoBoard.Left = screen.Bounds.Left + screen.Bounds.Width / 2 - cargoBoard.Width / 2;
                    cargoBoard.Top = screen.Bounds.Top + screen.Bounds.Height / 2 - cargoBoard.Height / 2;

                    cargoBoard.FullName = loginUser.FullName;
                    cargoBoard.UserID = loginUser.UserID;
                    cargoBoard.RoleID = loginUser.RoleID;
                    cargoBoard.menuStripFlightManager.Visible = false;

                    Permissions loadPermissions = new Permissions();
                    loadPermissions.ListOfMenus.Add(cargoBoard.menuStripFlightManager, typeof(ToolStripMenuItem));
                    loadPermissions.ListOfMenus.Add(cargoBoard.menuStripSeatblock, typeof(ToolStripMenuItem));
                    loadPermissions.ListOfMenus.Add(cargoBoard.addAWBSeatblockToolStripMenuItem, typeof(ToolStripMenuItem));
                    loadPermissions.ListOfMenus.Add(cargoBoard.subMenuDeleteFlight, typeof(ToolStripMenuItem));
                    loadPermissions.MenuStripPermission();
                    cargoBoard.Show();
                    loadPermissions.ReadOnlyPermissionCargo(cargoBoard.dgvCargoBoard);
                }
                // Admin
                else if (loginUser.RoleID == 8)
                {
                    UserModification userModification = new UserModification();
                    Changelog changeLog = new Changelog();

                    var screen = Screen.FromPoint(Cursor.Position);
                    userModification.StartPosition = FormStartPosition.Manual;
                    userModification.Left = screen.Bounds.Left + screen.Bounds.Width / 2 - userModification.Width / 2;
                    userModification.Top = screen.Bounds.Top + screen.Bounds.Height / 2 - userModification.Height / 2;

                    changeLog.StartPosition = FormStartPosition.Manual;
                    changeLog.Left = screen.Bounds.Left + screen.Bounds.Width / 2 - userModification.Width / 2;
                    changeLog.Top = screen.Bounds.Top + screen.Bounds.Height / 2 - userModification.Height / 2;

                    changeLog.RoleId = loginUser.RoleID;
                    changeLog.rchChangeLog.ReadOnly = false; 

                    userModification.Show();
                    changeLog.Show();
                }
                // Network Planner
                else if (loginUser.RoleID == 9)
                {
                    CargoBoard cargoBoard = new CargoBoard();
                    var screen = Screen.FromPoint(Cursor.Position);
                    cargoBoard.StartPosition = FormStartPosition.Manual;
                    cargoBoard.Left = screen.Bounds.Left + screen.Bounds.Width / 2 - cargoBoard.Width / 2;
                    cargoBoard.Top = screen.Bounds.Top + screen.Bounds.Height / 2 - cargoBoard.Height / 2;

                    Permissions loadPermissions = new Permissions();
                    loadPermissions.ListOfMenus.Add(cargoBoard.subMenuDeleteFlight, typeof(ToolStripMenuItem));
                    loadPermissions.ListOfMenus.Add(cargoBoard.menuStripFlightManager, typeof(ToolStripMenuItem));
                    loadPermissions.MenuStripPermission();
                    cargoBoard.FullName = loginUser.FullName;
                    cargoBoard.UserID = loginUser.UserID;
                    cargoBoard.RoleID = loginUser.RoleID;
                    cargoBoard.Show();
                }
                // Cargo Cooridinator
                else if (loginUser.RoleID == 10)
                {
                    CargoBoard cargoBoard = new CargoBoard();
                    var screen = Screen.FromPoint(Cursor.Position);
                    cargoBoard.StartPosition = FormStartPosition.Manual;
                    cargoBoard.Left = screen.Bounds.Left + screen.Bounds.Width / 2 - cargoBoard.Width / 2;
                    cargoBoard.Top = screen.Bounds.Top + screen.Bounds.Height / 2 - cargoBoard.Height / 2;

                    Permissions loadPermissions = new Permissions();
                    loadPermissions.ListOfMenus.Add(cargoBoard.subMenuDeleteFlight, typeof(ToolStripMenuItem));
                    loadPermissions.ListOfMenus.Add(cargoBoard.menuStripFlightManager, typeof(ToolStripMenuItem));
                    loadPermissions.MenuStripPermission();
                    cargoBoard.FullName = loginUser.FullName;
                    cargoBoard.UserID = loginUser.UserID;
                    cargoBoard.RoleID = loginUser.RoleID;
                    cargoBoard.Show();
                }
                // Directory of Cargo
                else if (loginUser.RoleID == 11)
                {
                    CargoBoard cargoBoard = new CargoBoard();
                    var screen = Screen.FromPoint(Cursor.Position);
                    cargoBoard.StartPosition = FormStartPosition.Manual;
                    cargoBoard.Left = screen.Bounds.Left + screen.Bounds.Width / 2 - cargoBoard.Width / 2;
                    cargoBoard.Top = screen.Bounds.Top + screen.Bounds.Height / 2 - cargoBoard.Height / 2;

                    cargoBoard.FullName = loginUser.FullName;
                    cargoBoard.UserID = loginUser.UserID;
                    cargoBoard.RoleID = loginUser.RoleID;
                    cargoBoard.Show();

                    RampBoard rampBoard = new RampBoard();
                    rampBoard.StartPosition = FormStartPosition.Manual;
                    rampBoard.Left = screen.Bounds.Left + screen.Bounds.Width / 2 - rampBoard.Width / 2;
                    rampBoard.Top = screen.Bounds.Top + screen.Bounds.Height / 2 - rampBoard.Height / 2;

                    rampBoard.FullName = loginUser.FullName;
                    rampBoard.UserID = loginUser.UserID;
                    cargoBoard.RoleID = loginUser.RoleID;
                    Permissions loadPermissions = new Permissions();
                    loadPermissions.ListOfMenus.Add(rampBoard.menuStripDelays, typeof(ToolStripMenuItem));
                    loadPermissions.MenuStripPermission();
                    rampBoard.Show();
                }
                // Charters 
                else if (loginUser.RoleID == 12)
                {
                    RampBoard rampBoard = new RampBoard();
                    var screen = Screen.FromPoint(Cursor.Position);
                    rampBoard.StartPosition = FormStartPosition.Manual;
                    rampBoard.Left = screen.Bounds.Left + screen.Bounds.Width / 2 - rampBoard.Width / 2;
                    rampBoard.Top = screen.Bounds.Top + screen.Bounds.Height / 2 - rampBoard.Height / 2;

                    rampBoard.FullName = loginUser.FullName;
                    rampBoard.UserID = loginUser.UserID;
                    rampBoard.RoleID = loginUser.RoleID;
                    Permissions loadPermissions = new Permissions();
                    loadPermissions.ListOfMenus.Add(rampBoard.menuStripDelays, typeof(ToolStripMenuItem));
                    loadPermissions.ListOfMenus.Add(rampBoard.subMenuMasterSchedule, typeof(ToolStripMenuItem));
                    loadPermissions.ListOfMenus.Add(rampBoard.menuStripFlights, typeof(ToolStripMenuItem));
                    loadPermissions.ListOfMenus.Add(rampBoard.setAircraftStatusToolStripMenuItem, typeof(ContextMenuStrip));
                    loadPermissions.ListOfMenus.Add(rampBoard.subMenuDeleteFlight, typeof(ContextMenuStrip));
                    loadPermissions.MenuStripPermission();
                    rampBoard.Show();
                    loadPermissions.ReadOnlyPermissionRamp(rampBoard.dgvRampBoard);
                }
                // Manifestor
                else if (loginUser.RoleID == 13)
                {
                    RampBoard rampBoard = new RampBoard();
                    var screen = Screen.FromPoint(Cursor.Position);
                    rampBoard.StartPosition = FormStartPosition.Manual;
                    rampBoard.Left = screen.Bounds.Left + screen.Bounds.Width / 2 - rampBoard.Width / 2;
                    rampBoard.Top = screen.Bounds.Top + screen.Bounds.Height / 2 - rampBoard.Height / 2;

                    rampBoard.FullName = loginUser.FullName;
                    rampBoard.UserID = loginUser.UserID;
                    rampBoard.RoleID = loginUser.RoleID;
                    Permissions loadPermissions = new Permissions();
                    loadPermissions.ListOfMenus.Add(rampBoard.menuStripDelays, typeof(ToolStripMenuItem));
                    loadPermissions.ListOfMenus.Add(rampBoard.subMenuMasterSchedule, typeof(ToolStripMenuItem));
                    loadPermissions.ListOfMenus.Add(rampBoard.menuStripFlights, typeof(ToolStripMenuItem));
                    loadPermissions.ListOfMenus.Add(rampBoard.menuStripNightCheckList, typeof(ToolStripMenuItem));
                    loadPermissions.ListOfMenus.Add(rampBoard.setAircraftStatusToolStripMenuItem, typeof(ContextMenuStrip));
                    loadPermissions.ListOfMenus.Add(rampBoard.subMenuDeleteFlight, typeof(ContextMenuStrip));
                    loadPermissions.ListOfMenus.Add(rampBoard.flightInformationToolStripMenuItem, typeof(ContextMenuStrip));
                    loadPermissions.MenuStripPermission();
                    rampBoard.Show();
                    loadPermissions.ReadOnlyPermissionRamp(rampBoard.dgvRampBoard);
                }
                // VIP
                else if(loginUser.RoleID == 14)
                {
                    RampBoard rampBoard = new RampBoard();
                    var screen = Screen.FromPoint(Cursor.Position);
                    rampBoard.StartPosition = FormStartPosition.Manual;
                    rampBoard.Left = screen.Bounds.Left + screen.Bounds.Width / 2 - rampBoard.Width / 2;
                    rampBoard.Top = screen.Bounds.Top + screen.Bounds.Height / 2 - rampBoard.Height / 2;

                    rampBoard.FullName = loginUser.FullName;
                    rampBoard.UserID = loginUser.UserID;
                    rampBoard.RoleID = loginUser.RoleID;
                    Permissions loadPermissions = new Permissions();
                    loadPermissions.ListOfMenus.Add(rampBoard.menuStripDelays, typeof(ToolStripMenuItem));
                    loadPermissions.ListOfMenus.Add(rampBoard.subMenuMasterSchedule, typeof(ToolStripMenuItem));
                    loadPermissions.ListOfMenus.Add(rampBoard.menuStripFlights, typeof(ToolStripMenuItem));
                    loadPermissions.ListOfMenus.Add(rampBoard.menuStripNightCheckList, typeof(ToolStripMenuItem));
                    loadPermissions.ListOfMenus.Add(rampBoard.setAircraftStatusToolStripMenuItem, typeof(ContextMenuStrip));
                    loadPermissions.ListOfMenus.Add(rampBoard.subMenuDeleteFlight, typeof(ContextMenuStrip));
                    loadPermissions.MenuStripPermission();
                    rampBoard.Show();
                    loadPermissions.ReadOnlyPermissionRamp(rampBoard.dgvRampBoard);
                }

                this.Hide();
            }
            else
            {
                tbPassword.Clear();
            }
        }

        private void tbUsername_KeyDown(object sender, KeyEventArgs e)
        {
            EnterKeyLogin(e);
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            EnterKeyLogin(e);
        }
    }
}
