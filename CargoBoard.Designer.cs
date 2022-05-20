
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStripSeatblock = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripFlightManager = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuModifyFlight = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripDate = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuStripShowDate = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuStripHideDate = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.dateTimeCargo = new System.Windows.Forms.DateTimePicker();
            this.pictureCargoBoard = new System.Windows.Forms.PictureBox();
            this.dgvCargoBoard = new System.Windows.Forms.DataGridView();
            this.dgvMenuStripFlights = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.subMenuDeleteFlight = new System.Windows.Forms.ToolStripMenuItem();
            this.addAWBSeatblockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCargoBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargoBoard)).BeginInit();
            this.dgvMenuStripFlights.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripSeatblock,
            this.menuStripFlightManager,
            this.menuStripDate});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1014, 24);
            this.menuStrip1.TabIndex = 0;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.dateTimeCargo);
            this.panel1.Controls.Add(this.pictureCargoBoard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 119);
            this.panel1.TabIndex = 1;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F);
            this.lblUser.Location = new System.Drawing.Point(9, 8);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(14, 18);
            this.lblUser.TabIndex = 8;
            this.lblUser.Text = "-";
            // 
            // dateTimeCargo
            // 
            this.dateTimeCargo.CalendarFont = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.dateTimeCargo.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F);
            this.dateTimeCargo.Location = new System.Drawing.Point(11, 28);
            this.dateTimeCargo.Name = "dateTimeCargo";
            this.dateTimeCargo.Size = new System.Drawing.Size(170, 25);
            this.dateTimeCargo.TabIndex = 7;
            this.dateTimeCargo.Visible = false;
            this.dateTimeCargo.ValueChanged += new System.EventHandler(this.dateTimeCargo_ValueChanged);
            // 
            // pictureCargoBoard
            // 
            this.pictureCargoBoard.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureCargoBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureCargoBoard.Image = ((System.Drawing.Image)(resources.GetObject("pictureCargoBoard.Image")));
            this.pictureCargoBoard.Location = new System.Drawing.Point(0, 0);
            this.pictureCargoBoard.Margin = new System.Windows.Forms.Padding(2);
            this.pictureCargoBoard.Name = "pictureCargoBoard";
            this.pictureCargoBoard.Size = new System.Drawing.Size(1014, 119);
            this.pictureCargoBoard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureCargoBoard.TabIndex = 1;
            this.pictureCargoBoard.TabStop = false;
            // 
            // dgvCargoBoard
            // 
            this.dgvCargoBoard.AllowUserToAddRows = false;
            this.dgvCargoBoard.AllowUserToDeleteRows = false;
            this.dgvCargoBoard.AllowUserToResizeColumns = false;
            this.dgvCargoBoard.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCargoBoard.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCargoBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCargoBoard.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCargoBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCargoBoard.Location = new System.Drawing.Point(0, 143);
            this.dgvCargoBoard.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCargoBoard.Name = "dgvCargoBoard";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCargoBoard.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCargoBoard.Size = new System.Drawing.Size(1014, 353);
            this.dgvCargoBoard.TabIndex = 5;
            this.dgvCargoBoard.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCargoBoard_CellMouseUp);
            this.dgvCargoBoard.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvCargoBoard_KeyUp);
            // 
            // dgvMenuStripFlights
            // 
            this.dgvMenuStripFlights.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuDeleteFlight,
            this.addAWBSeatblockToolStripMenuItem});
            this.dgvMenuStripFlights.Name = "contextMenuStrip1";
            this.dgvMenuStripFlights.Size = new System.Drawing.Size(185, 48);
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
            // updateTimer
            // 
            this.updateTimer.Enabled = true;
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // CargoBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 496);
            this.Controls.Add(this.dgvCargoBoard);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CargoBoard";
            this.Text = "CargoBoard";
            this.Load += new System.EventHandler(this.CargoBoard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCargoBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargoBoard)).EndInit();
            this.dgvMenuStripFlights.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuStripSeatblock;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox pictureCargoBoard;
        private System.Windows.Forms.DateTimePicker dateTimeCargo;
        private System.Windows.Forms.Label lblUser;
        public System.Windows.Forms.DataGridView dgvCargoBoard;
        private System.Windows.Forms.ToolStripMenuItem menuStripFlightManager;
        private System.Windows.Forms.ToolStripMenuItem subMenuModifyFlight;
        private System.Windows.Forms.ToolStripMenuItem menuStripDate;
        private System.Windows.Forms.ToolStripMenuItem subMenuStripShowDate;
        private System.Windows.Forms.ToolStripMenuItem subMenuStripHideDate;
        private System.Windows.Forms.ContextMenuStrip dgvMenuStripFlights;
        private System.Windows.Forms.ToolStripMenuItem subMenuDeleteFlight;
        private System.Windows.Forms.ToolStripMenuItem addAWBSeatblockToolStripMenuItem;
        private System.Windows.Forms.Timer updateTimer;
    }
}