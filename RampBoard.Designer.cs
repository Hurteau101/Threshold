
namespace Perimeter_Threshold
{
    partial class RampBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RampBoard));
            this.smallPanelEarly = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelColors = new System.Windows.Forms.Panel();
            this.lblArrived = new System.Windows.Forms.Label();
            this.lblOnTime = new System.Windows.Forms.Label();
            this.lblUnserviceable = new System.Windows.Forms.Label();
            this.lblLate = new System.Windows.Forms.Label();
            this.lblEarly = new System.Windows.Forms.Label();
            this.smallPanelArrived = new System.Windows.Forms.Panel();
            this.smallPanelOnTime = new System.Windows.Forms.Panel();
            this.smallPanelUnserviceable = new System.Windows.Forms.Panel();
            this.smallPanelLate = new System.Windows.Forms.Panel();
            this.dateTimeRamp = new System.Windows.Forms.DateTimePicker();
            this.lblUser = new System.Windows.Forms.Label();
            this.pictureHeader = new System.Windows.Forms.PictureBox();
            this.dgvMenuStripFlights = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.subMenuDeleteFlight = new System.Windows.Forms.ToolStripMenuItem();
            this.setAircraftStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unserviceableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flightInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvRampBoard = new System.Windows.Forms.DataGridView();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.arrivalTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStripFlights = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuAddFlight = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuMasterSchedule = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripDate = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuStripShowDate = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuStripHideDate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripDelays = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuStripDelayCodes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripNightCheckList = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuNightChecklist = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.changeLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshBoard = new System.Windows.Forms.Timer(this.components);
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelHeader.SuspendLayout();
            this.panelColors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHeader)).BeginInit();
            this.dgvMenuStripFlights.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRampBoard)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // smallPanelEarly
            // 
            this.smallPanelEarly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.smallPanelEarly.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.smallPanelEarly.Location = new System.Drawing.Point(11, 18);
            this.smallPanelEarly.Name = "smallPanelEarly";
            this.smallPanelEarly.Size = new System.Drawing.Size(17, 20);
            this.smallPanelEarly.TabIndex = 2;
            this.smallPanelEarly.DoubleClick += new System.EventHandler(this.smallPanelEarly_DoubleClick);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelHeader.Controls.Add(this.panelColors);
            this.panelHeader.Controls.Add(this.dateTimeRamp);
            this.panelHeader.Controls.Add(this.lblUser);
            this.panelHeader.Controls.Add(this.pictureHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 24);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(608, 119);
            this.panelHeader.TabIndex = 3;
            // 
            // panelColors
            // 
            this.panelColors.Controls.Add(this.lblArrived);
            this.panelColors.Controls.Add(this.lblOnTime);
            this.panelColors.Controls.Add(this.lblUnserviceable);
            this.panelColors.Controls.Add(this.lblLate);
            this.panelColors.Controls.Add(this.lblEarly);
            this.panelColors.Controls.Add(this.smallPanelArrived);
            this.panelColors.Controls.Add(this.smallPanelOnTime);
            this.panelColors.Controls.Add(this.smallPanelUnserviceable);
            this.panelColors.Controls.Add(this.smallPanelLate);
            this.panelColors.Controls.Add(this.smallPanelEarly);
            this.panelColors.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelColors.Location = new System.Drawing.Point(458, 0);
            this.panelColors.Name = "panelColors";
            this.panelColors.Size = new System.Drawing.Size(150, 119);
            this.panelColors.TabIndex = 4;
            // 
            // lblArrived
            // 
            this.lblArrived.AutoSize = true;
            this.lblArrived.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrived.Location = new System.Drawing.Point(89, 53);
            this.lblArrived.Name = "lblArrived";
            this.lblArrived.Size = new System.Drawing.Size(45, 14);
            this.lblArrived.TabIndex = 8;
            this.lblArrived.Text = "Arrived";
            // 
            // lblOnTime
            // 
            this.lblOnTime.AutoSize = true;
            this.lblOnTime.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnTime.Location = new System.Drawing.Point(88, 20);
            this.lblOnTime.Name = "lblOnTime";
            this.lblOnTime.Size = new System.Drawing.Size(51, 14);
            this.lblOnTime.TabIndex = 7;
            this.lblOnTime.Text = "On Time";
            // 
            // lblUnserviceable
            // 
            this.lblUnserviceable.AutoSize = true;
            this.lblUnserviceable.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnserviceable.Location = new System.Drawing.Point(30, 83);
            this.lblUnserviceable.Name = "lblUnserviceable";
            this.lblUnserviceable.Size = new System.Drawing.Size(102, 14);
            this.lblUnserviceable.TabIndex = 6;
            this.lblUnserviceable.Text = "A/C Unserviceable";
            // 
            // lblLate
            // 
            this.lblLate.AutoSize = true;
            this.lblLate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLate.Location = new System.Drawing.Point(30, 51);
            this.lblLate.Name = "lblLate";
            this.lblLate.Size = new System.Drawing.Size(29, 14);
            this.lblLate.TabIndex = 5;
            this.lblLate.Text = "Late";
            // 
            // lblEarly
            // 
            this.lblEarly.AutoSize = true;
            this.lblEarly.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEarly.Location = new System.Drawing.Point(30, 20);
            this.lblEarly.Name = "lblEarly";
            this.lblEarly.Size = new System.Drawing.Size(32, 14);
            this.lblEarly.TabIndex = 4;
            this.lblEarly.Text = "Early";
            // 
            // smallPanelArrived
            // 
            this.smallPanelArrived.BackColor = System.Drawing.Color.DimGray;
            this.smallPanelArrived.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.smallPanelArrived.Location = new System.Drawing.Point(68, 49);
            this.smallPanelArrived.Name = "smallPanelArrived";
            this.smallPanelArrived.Size = new System.Drawing.Size(17, 20);
            this.smallPanelArrived.TabIndex = 3;
            this.smallPanelArrived.DoubleClick += new System.EventHandler(this.smallPanelArrived_DoubleClick);
            // 
            // smallPanelOnTime
            // 
            this.smallPanelOnTime.BackColor = System.Drawing.Color.Black;
            this.smallPanelOnTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.smallPanelOnTime.Location = new System.Drawing.Point(68, 18);
            this.smallPanelOnTime.Name = "smallPanelOnTime";
            this.smallPanelOnTime.Size = new System.Drawing.Size(17, 20);
            this.smallPanelOnTime.TabIndex = 3;
            this.smallPanelOnTime.DoubleClick += new System.EventHandler(this.smallPanelOnTime_DoubleClick);
            // 
            // smallPanelUnserviceable
            // 
            this.smallPanelUnserviceable.BackColor = System.Drawing.Color.Yellow;
            this.smallPanelUnserviceable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.smallPanelUnserviceable.Location = new System.Drawing.Point(11, 83);
            this.smallPanelUnserviceable.Name = "smallPanelUnserviceable";
            this.smallPanelUnserviceable.Size = new System.Drawing.Size(17, 20);
            this.smallPanelUnserviceable.TabIndex = 4;
            this.smallPanelUnserviceable.DoubleClick += new System.EventHandler(this.smallPanelUnserviceable_DoubleClick);
            // 
            // smallPanelLate
            // 
            this.smallPanelLate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(13)))), ((int)(((byte)(26)))));
            this.smallPanelLate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.smallPanelLate.Location = new System.Drawing.Point(11, 49);
            this.smallPanelLate.Name = "smallPanelLate";
            this.smallPanelLate.Size = new System.Drawing.Size(17, 20);
            this.smallPanelLate.TabIndex = 3;
            this.smallPanelLate.DoubleClick += new System.EventHandler(this.smallPanelLate_DoubleClick);
            // 
            // dateTimeRamp
            // 
            this.dateTimeRamp.CalendarFont = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.dateTimeRamp.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F);
            this.dateTimeRamp.Location = new System.Drawing.Point(11, 28);
            this.dateTimeRamp.Name = "dateTimeRamp";
            this.dateTimeRamp.Size = new System.Drawing.Size(170, 25);
            this.dateTimeRamp.TabIndex = 6;
            this.dateTimeRamp.Visible = false;
            this.dateTimeRamp.ValueChanged += new System.EventHandler(this.dateTimeRamp_ValueChanged);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F);
            this.lblUser.Location = new System.Drawing.Point(9, 8);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(14, 18);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "-";
            // 
            // pictureHeader
            // 
            this.pictureHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureHeader.Image = global::Perimeter_Threshold.Properties.Resources.RampBoardHeader;
            this.pictureHeader.Location = new System.Drawing.Point(0, 0);
            this.pictureHeader.Name = "pictureHeader";
            this.pictureHeader.Size = new System.Drawing.Size(608, 119);
            this.pictureHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureHeader.TabIndex = 4;
            this.pictureHeader.TabStop = false;
            // 
            // dgvMenuStripFlights
            // 
            this.dgvMenuStripFlights.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.dgvMenuStripFlights.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuDeleteFlight,
            this.setAircraftStatusToolStripMenuItem,
            this.flightInformationToolStripMenuItem});
            this.dgvMenuStripFlights.Name = "contextMenuStrip1";
            this.dgvMenuStripFlights.Size = new System.Drawing.Size(171, 70);
            // 
            // subMenuDeleteFlight
            // 
            this.subMenuDeleteFlight.Name = "subMenuDeleteFlight";
            this.subMenuDeleteFlight.Size = new System.Drawing.Size(170, 22);
            this.subMenuDeleteFlight.Text = "Delete Flight";
            this.subMenuDeleteFlight.Click += new System.EventHandler(this.subMenuDeleteFlight_Click);
            // 
            // setAircraftStatusToolStripMenuItem
            // 
            this.setAircraftStatusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serviceableToolStripMenuItem,
            this.unserviceableToolStripMenuItem});
            this.setAircraftStatusToolStripMenuItem.Name = "setAircraftStatusToolStripMenuItem";
            this.setAircraftStatusToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.setAircraftStatusToolStripMenuItem.Text = "Set Aircraft Status";
            // 
            // serviceableToolStripMenuItem
            // 
            this.serviceableToolStripMenuItem.Name = "serviceableToolStripMenuItem";
            this.serviceableToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.serviceableToolStripMenuItem.Text = "Serviceable";
            this.serviceableToolStripMenuItem.Click += new System.EventHandler(this.serviceableToolStripMenuItem_Click);
            // 
            // unserviceableToolStripMenuItem
            // 
            this.unserviceableToolStripMenuItem.Name = "unserviceableToolStripMenuItem";
            this.unserviceableToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.unserviceableToolStripMenuItem.Text = "Unserviceable";
            this.unserviceableToolStripMenuItem.Click += new System.EventHandler(this.unserviceableToolStripMenuItem_Click);
            // 
            // flightInformationToolStripMenuItem
            // 
            this.flightInformationToolStripMenuItem.Name = "flightInformationToolStripMenuItem";
            this.flightInformationToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.flightInformationToolStripMenuItem.Text = "Flight Information";
            this.flightInformationToolStripMenuItem.Click += new System.EventHandler(this.flightInformationToolStripMenuItem_Click);
            // 
            // dgvRampBoard
            // 
            this.dgvRampBoard.AllowUserToAddRows = false;
            this.dgvRampBoard.AllowUserToDeleteRows = false;
            this.dgvRampBoard.AllowUserToResizeColumns = false;
            this.dgvRampBoard.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRampBoard.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRampBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRampBoard.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRampBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRampBoard.Location = new System.Drawing.Point(0, 143);
            this.dgvRampBoard.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRampBoard.Name = "dgvRampBoard";
            this.dgvRampBoard.RowHeadersWidth = 51;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRampBoard.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRampBoard.Size = new System.Drawing.Size(608, 227);
            this.dgvRampBoard.TabIndex = 4;
            this.dgvRampBoard.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvRampBoard_CellFormatting);
            this.dgvRampBoard.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRampBoard_CellMouseUp);
            this.dgvRampBoard.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvRampBoard_KeyUp);
            // 
            // updateTimer
            // 
            this.updateTimer.Enabled = true;
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // arrivalTimer
            // 
            this.arrivalTimer.Enabled = true;
            this.arrivalTimer.Interval = 30000;
            this.arrivalTimer.Tick += new System.EventHandler(this.arrivalTimer_Tick);
            // 
            // menuStripFlights
            // 
            this.menuStripFlights.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuAddFlight,
            this.subMenuMasterSchedule});
            this.menuStripFlights.Name = "menuStripFlights";
            this.menuStripFlights.Size = new System.Drawing.Size(54, 20);
            this.menuStripFlights.Text = "Flights";
            // 
            // subMenuAddFlight
            // 
            this.subMenuAddFlight.Name = "subMenuAddFlight";
            this.subMenuAddFlight.Size = new System.Drawing.Size(165, 22);
            this.subMenuAddFlight.Text = "Add Flight";
            this.subMenuAddFlight.Click += new System.EventHandler(this.subMenuAddFlight_Click);
            // 
            // subMenuMasterSchedule
            // 
            this.subMenuMasterSchedule.Name = "subMenuMasterSchedule";
            this.subMenuMasterSchedule.Size = new System.Drawing.Size(165, 22);
            this.subMenuMasterSchedule.Text = "Master Scheduler";
            this.subMenuMasterSchedule.Click += new System.EventHandler(this.subMenuMasterSchedule_Click);
            // 
            // menuStripDate
            // 
            this.menuStripDate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuStripShowDate,
            this.subMenuStripHideDate});
            this.menuStripDate.Name = "menuStripDate";
            this.menuStripDate.Size = new System.Drawing.Size(43, 20);
            this.menuStripDate.Text = "Date";
            // 
            // subMenuStripShowDate
            // 
            this.subMenuStripShowDate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.subMenuStripShowDate.Image = global::Perimeter_Threshold.Properties.Resources.LOGO;
            this.subMenuStripShowDate.Name = "subMenuStripShowDate";
            this.subMenuStripShowDate.Size = new System.Drawing.Size(180, 22);
            this.subMenuStripShowDate.Text = "Show Date Calendar";
            this.subMenuStripShowDate.Click += new System.EventHandler(this.showDateCalanderToolStripMenuItem_Click);
            // 
            // subMenuStripHideDate
            // 
            this.subMenuStripHideDate.Checked = true;
            this.subMenuStripHideDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.subMenuStripHideDate.Image = global::Perimeter_Threshold.Properties.Resources.LOGO;
            this.subMenuStripHideDate.Name = "subMenuStripHideDate";
            this.subMenuStripHideDate.Size = new System.Drawing.Size(180, 22);
            this.subMenuStripHideDate.Text = "Hide Date Calendar";
            this.subMenuStripHideDate.Click += new System.EventHandler(this.hideDateCalenderToolStripMenuItem_Click);
            // 
            // menuStripDelays
            // 
            this.menuStripDelays.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuStripDelayCodes});
            this.menuStripDelays.Name = "menuStripDelays";
            this.menuStripDelays.Size = new System.Drawing.Size(48, 20);
            this.menuStripDelays.Text = "Delay";
            // 
            // subMenuStripDelayCodes
            // 
            this.subMenuStripDelayCodes.Name = "subMenuStripDelayCodes";
            this.subMenuStripDelayCodes.Size = new System.Drawing.Size(139, 22);
            this.subMenuStripDelayCodes.Text = "Delay Codes";
            // 
            // menuStripNightCheckList
            // 
            this.menuStripNightCheckList.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuNightChecklist});
            this.menuStripNightCheckList.Name = "menuStripNightCheckList";
            this.menuStripNightCheckList.Size = new System.Drawing.Size(87, 20);
            this.menuStripNightCheckList.Text = "Night Report";
            // 
            // subMenuNightChecklist
            // 
            this.subMenuNightChecklist.Name = "subMenuNightChecklist";
            this.subMenuNightChecklist.Size = new System.Drawing.Size(155, 22);
            this.subMenuNightChecklist.Text = "Night Checklist";
            this.subMenuNightChecklist.Click += new System.EventHandler(this.subMenuNightChecklist_Click);
            // 
            // menuRefresh
            // 
            this.menuRefresh.Name = "menuRefresh";
            this.menuRefresh.Size = new System.Drawing.Size(117, 20);
            this.menuRefresh.Text = "Refresh (CTRL + R)";
            this.menuRefresh.Click += new System.EventHandler(this.menuRefresh_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripFlights,
            this.menuStripDate,
            this.menuStripDelays,
            this.menuStripNightCheckList,
            this.menuRefresh,
            this.changeLogToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(608, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // changeLogToolStripMenuItem
            // 
            this.changeLogToolStripMenuItem.Name = "changeLogToolStripMenuItem";
            this.changeLogToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.changeLogToolStripMenuItem.Text = "Change Log";
            this.changeLogToolStripMenuItem.Click += new System.EventHandler(this.changeLogToolStripMenuItem_Click);
            // 
            // RefreshBoard
            // 
            this.RefreshBoard.Enabled = true;
            this.RefreshBoard.Interval = 300000;
            this.RefreshBoard.Tick += new System.EventHandler(this.RefreshBoard_Tick);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // RampBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(608, 370);
            this.Controls.Add(this.dgvRampBoard);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "RampBoard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RampBoard_FormClosed);
            this.Load += new System.EventHandler(this.RampBoard_Load);
            this.ResizeEnd += new System.EventHandler(this.RampBoard_ResizeEnd);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RampBoard_KeyDown);
            this.Resize += new System.EventHandler(this.RampBoard_Resize);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelColors.ResumeLayout(false);
            this.panelColors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHeader)).EndInit();
            this.dgvMenuStripFlights.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRampBoard)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel smallPanelEarly;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelColors;
        private System.Windows.Forms.Label lblArrived;
        private System.Windows.Forms.Label lblOnTime;
        private System.Windows.Forms.Label lblUnserviceable;
        private System.Windows.Forms.Label lblLate;
        private System.Windows.Forms.Label lblEarly;
        private System.Windows.Forms.Panel smallPanelArrived;
        private System.Windows.Forms.Panel smallPanelOnTime;
        private System.Windows.Forms.Panel smallPanelUnserviceable;
        private System.Windows.Forms.Panel smallPanelLate;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.DateTimePicker dateTimeRamp;
        private System.Windows.Forms.ContextMenuStrip dgvMenuStripFlights;
        public System.Windows.Forms.DataGridView dgvRampBoard;
        private System.Windows.Forms.PictureBox pictureHeader;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.Timer arrivalTimer;
        private System.Windows.Forms.ToolStripMenuItem serviceableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unserviceableToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem subMenuAddFlight;
        public System.Windows.Forms.ToolStripMenuItem subMenuMasterSchedule;
        private System.Windows.Forms.ToolStripMenuItem menuStripDate;
        private System.Windows.Forms.ToolStripMenuItem subMenuStripShowDate;
        private System.Windows.Forms.ToolStripMenuItem subMenuStripHideDate;
        public System.Windows.Forms.ToolStripMenuItem menuStripDelays;
        private System.Windows.Forms.ToolStripMenuItem subMenuStripDelayCodes;
        private System.Windows.Forms.ToolStripMenuItem menuRefresh;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Timer RefreshBoard;
        public System.Windows.Forms.ToolStripMenuItem menuStripFlights;
        internal System.Windows.Forms.ToolStripMenuItem subMenuDeleteFlight;
        internal System.Windows.Forms.ToolStripMenuItem setAircraftStatusToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem subMenuNightChecklist;
        internal System.Windows.Forms.ToolStripMenuItem menuStripNightCheckList;
        internal System.Windows.Forms.ToolStripMenuItem flightInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}