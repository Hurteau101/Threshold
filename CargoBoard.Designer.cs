
namespace Perimeter_Threshold
{
    partial class CargoBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CargoBoard));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvMenuStripFlights = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.subMenuDeleteFlight = new System.Windows.Forms.ToolStripMenuItem();
            this.addAWBSeatblockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flightInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStripSeatblock = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripFlightManager = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuModifyFlight = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripDate = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuStripShowDate = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuStripHideDate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.changelogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimeCargo = new System.Windows.Forms.DateTimePicker();
            this.lblUser = new System.Windows.Forms.Label();
            this.panelColors = new System.Windows.Forms.Panel();
            this.lblEarly = new System.Windows.Forms.Label();
            this.smallPanelCompletion = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureCargoBoard = new System.Windows.Forms.PictureBox();
            this.dgvCargoBoard = new System.Windows.Forms.DataGridView();
            this.RefreshBoard = new System.Windows.Forms.Timer(this.components);
            this.dgvMenuStripFlights.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelColors.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCargoBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargoBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMenuStripFlights
            // 
            this.dgvMenuStripFlights.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.dgvMenuStripFlights.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuDeleteFlight,
            this.addAWBSeatblockToolStripMenuItem,
            this.flightInformationToolStripMenuItem});
            this.dgvMenuStripFlights.Name = "contextMenuStrip1";
            this.dgvMenuStripFlights.Size = new System.Drawing.Size(185, 70);
            // 
            // subMenuDeleteFlight
            // 
            this.subMenuDeleteFlight.Name = "subMenuDeleteFlight";
            this.subMenuDeleteFlight.Size = new System.Drawing.Size(184, 22);
            this.subMenuDeleteFlight.Text = "Delete Flight";
            this.subMenuDeleteFlight.Click += new System.EventHandler(this.subMenuDeleteFlight_Click);
            // 
            // addAWBSeatblockToolStripMenuItem
            // 
            this.addAWBSeatblockToolStripMenuItem.Name = "addAWBSeatblockToolStripMenuItem";
            this.addAWBSeatblockToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.addAWBSeatblockToolStripMenuItem.Text = "Add AWB | Seatblock";
            this.addAWBSeatblockToolStripMenuItem.Click += new System.EventHandler(this.addAWBSeatblockToolStripMenuItem_Click);
            // 
            // flightInformationToolStripMenuItem
            // 
            this.flightInformationToolStripMenuItem.Name = "flightInformationToolStripMenuItem";
            this.flightInformationToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.flightInformationToolStripMenuItem.Text = "Flight Information";
            this.flightInformationToolStripMenuItem.Click += new System.EventHandler(this.flightInformationToolStripMenuItem_Click);
            // 
            // updateTimer
            // 
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripSeatblock,
            this.menuStripFlightManager,
            this.menuStripDate,
            this.menuRefresh,
            this.changelogToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(608, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStripSeatblock
            // 
            this.menuStripSeatblock.Name = "menuStripSeatblock";
            this.menuStripSeatblock.Size = new System.Drawing.Size(129, 20);
            this.menuStripSeatblock.Text = "Add AWB | Seatblock";
            this.menuStripSeatblock.Click += new System.EventHandler(this.menuStripSeatblock_Click);
            // 
            // menuStripFlightManager
            // 
            this.menuStripFlightManager.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuModifyFlight});
            this.menuStripFlightManager.Name = "menuStripFlightManager";
            this.menuStripFlightManager.Size = new System.Drawing.Size(99, 20);
            this.menuStripFlightManager.Text = "Flight Manager";
            // 
            // subMenuModifyFlight
            // 
            this.subMenuModifyFlight.Name = "subMenuModifyFlight";
            this.subMenuModifyFlight.Size = new System.Drawing.Size(176, 22);
            this.subMenuModifyFlight.Text = "Add | Update Flight";
            this.subMenuModifyFlight.Click += new System.EventHandler(this.subMenuModifyFlight_Click);
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
            this.subMenuStripShowDate.Image = global::Perimeter_Threshold.Properties.Resources.LOGO;
            this.subMenuStripShowDate.Name = "subMenuStripShowDate";
            this.subMenuStripShowDate.Size = new System.Drawing.Size(130, 22);
            this.subMenuStripShowDate.Text = "Show Date";
            this.subMenuStripShowDate.Click += new System.EventHandler(this.subMenuStripShowDate_Click);
            // 
            // subMenuStripHideDate
            // 
            this.subMenuStripHideDate.Checked = true;
            this.subMenuStripHideDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.subMenuStripHideDate.Image = global::Perimeter_Threshold.Properties.Resources.LOGO;
            this.subMenuStripHideDate.Name = "subMenuStripHideDate";
            this.subMenuStripHideDate.Size = new System.Drawing.Size(130, 22);
            this.subMenuStripHideDate.Text = "Hide Date";
            this.subMenuStripHideDate.Click += new System.EventHandler(this.subMenuStripHideDate_Click);
            // 
            // menuRefresh
            // 
            this.menuRefresh.Name = "menuRefresh";
            this.menuRefresh.Size = new System.Drawing.Size(111, 20);
            this.menuRefresh.Text = "Refrsh (CTRL + R)";
            this.menuRefresh.Click += new System.EventHandler(this.menuRefresh_Click_1);
            // 
            // changelogToolStripMenuItem
            // 
            this.changelogToolStripMenuItem.Name = "changelogToolStripMenuItem";
            this.changelogToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.changelogToolStripMenuItem.Text = "Changelog";
            this.changelogToolStripMenuItem.Click += new System.EventHandler(this.changelogToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // dateTimeCargo
            // 
            this.dateTimeCargo.CalendarFont = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.dateTimeCargo.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F);
            this.dateTimeCargo.Location = new System.Drawing.Point(11, 28);
            this.dateTimeCargo.Name = "dateTimeCargo";
            this.dateTimeCargo.Size = new System.Drawing.Size(170, 25);
            this.dateTimeCargo.TabIndex = 15;
            this.dateTimeCargo.Visible = false;
            this.dateTimeCargo.ValueChanged += new System.EventHandler(this.dateTimeCargo_ValueChanged_1);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblUser.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F);
            this.lblUser.Location = new System.Drawing.Point(9, 8);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(14, 18);
            this.lblUser.TabIndex = 16;
            this.lblUser.Text = "-";
            // 
            // panelColors
            // 
            this.panelColors.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelColors.Controls.Add(this.lblEarly);
            this.panelColors.Controls.Add(this.smallPanelCompletion);
            this.panelColors.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelColors.Location = new System.Drawing.Point(458, 0);
            this.panelColors.Name = "panelColors";
            this.panelColors.Size = new System.Drawing.Size(150, 119);
            this.panelColors.TabIndex = 17;
            // 
            // lblEarly
            // 
            this.lblEarly.AutoSize = true;
            this.lblEarly.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEarly.Location = new System.Drawing.Point(30, 20);
            this.lblEarly.Name = "lblEarly";
            this.lblEarly.Size = new System.Drawing.Size(101, 14);
            this.lblEarly.TabIndex = 4;
            this.lblEarly.Text = "Flight Completion";
            // 
            // smallPanelCompletion
            // 
            this.smallPanelCompletion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.smallPanelCompletion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.smallPanelCompletion.Location = new System.Drawing.Point(11, 18);
            this.smallPanelCompletion.Name = "smallPanelCompletion";
            this.smallPanelCompletion.Size = new System.Drawing.Size(17, 20);
            this.smallPanelCompletion.TabIndex = 2;
            this.smallPanelCompletion.Click += new System.EventHandler(this.smallPanelCompletion_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelColors);
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.dateTimeCargo);
            this.panel1.Controls.Add(this.pictureCargoBoard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 119);
            this.panel1.TabIndex = 4;
            // 
            // pictureCargoBoard
            // 
            this.pictureCargoBoard.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureCargoBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureCargoBoard.Image = ((System.Drawing.Image)(resources.GetObject("pictureCargoBoard.Image")));
            this.pictureCargoBoard.Location = new System.Drawing.Point(0, 0);
            this.pictureCargoBoard.Margin = new System.Windows.Forms.Padding(2);
            this.pictureCargoBoard.Name = "pictureCargoBoard";
            this.pictureCargoBoard.Size = new System.Drawing.Size(608, 119);
            this.pictureCargoBoard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureCargoBoard.TabIndex = 14;
            this.pictureCargoBoard.TabStop = false;
            // 
            // dgvCargoBoard
            // 
            this.dgvCargoBoard.AllowUserToAddRows = false;
            this.dgvCargoBoard.AllowUserToResizeColumns = false;
            this.dgvCargoBoard.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCargoBoard.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCargoBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCargoBoard.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCargoBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCargoBoard.Location = new System.Drawing.Point(0, 143);
            this.dgvCargoBoard.Name = "dgvCargoBoard";
            this.dgvCargoBoard.RowHeadersWidth = 51;
            this.dgvCargoBoard.Size = new System.Drawing.Size(608, 227);
            this.dgvCargoBoard.TabIndex = 5;
            this.dgvCargoBoard.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCargoBoard_CellClick_1);
            this.dgvCargoBoard.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCargoBoard_CellContentClick_1);
            this.dgvCargoBoard.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCargoBoard_CellMouseUp_1);
            this.dgvCargoBoard.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvCargoBoard_KeyUp);
            // 
            // RefreshBoard
            // 
            this.RefreshBoard.Enabled = true;
            this.RefreshBoard.Interval = 300000;
            this.RefreshBoard.Tick += new System.EventHandler(this.RefreshBoard_Tick);
            // 
            // CargoBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 370);
            this.Controls.Add(this.dgvCargoBoard);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "CargoBoard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CargoBoard_FormClosed);
            this.Load += new System.EventHandler(this.CargoBoard_Load);
            this.ResizeEnd += new System.EventHandler(this.CargoBoard_ResizeEnd);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CargoBoard_KeyDown);
            this.Resize += new System.EventHandler(this.CargoBoard_Resize);
            this.dgvMenuStripFlights.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelColors.ResumeLayout(false);
            this.panelColors.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCargoBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargoBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip dgvMenuStripFlights;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.ToolStripMenuItem flightInformationToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem subMenuDeleteFlight;
        public System.Windows.Forms.ToolStripMenuItem addAWBSeatblockToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem menuStripSeatblock;
        public System.Windows.Forms.ToolStripMenuItem menuStripFlightManager;
        private System.Windows.Forms.ToolStripMenuItem subMenuModifyFlight;
        private System.Windows.Forms.ToolStripMenuItem menuStripDate;
        private System.Windows.Forms.ToolStripMenuItem subMenuStripShowDate;
        private System.Windows.Forms.ToolStripMenuItem subMenuStripHideDate;
        private System.Windows.Forms.ToolStripMenuItem menuRefresh;
        private System.Windows.Forms.DateTimePicker dateTimeCargo;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel panelColors;
        private System.Windows.Forms.Label lblEarly;
        private System.Windows.Forms.Panel smallPanelCompletion;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox pictureCargoBoard;
        public System.Windows.Forms.DataGridView dgvCargoBoard;
        private System.Windows.Forms.Timer RefreshBoard;
        private System.Windows.Forms.ToolStripMenuItem changelogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}