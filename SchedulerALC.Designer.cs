namespace Perimeter_Threshold
{
    partial class SchedulerALC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchedulerALC));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStripFlights = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuAddFlight = new System.Windows.Forms.ToolStripMenuItem();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.dateTimeALC = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvSchedulerALC = new System.Windows.Forms.DataGridView();
            this.dgvMenuStripFlights = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.subMenuDeleteFlight = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedulerALC)).BeginInit();
            this.dgvMenuStripFlights.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripFlights});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1014, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStripFlights
            // 
            this.menuStripFlights.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuAddFlight});
            this.menuStripFlights.Name = "menuStripFlights";
            this.menuStripFlights.Size = new System.Drawing.Size(54, 20);
            this.menuStripFlights.Text = "Flights";
            // 
            // subMenuAddFlight
            // 
            this.subMenuAddFlight.Name = "subMenuAddFlight";
            this.subMenuAddFlight.Size = new System.Drawing.Size(129, 22);
            this.subMenuAddFlight.Text = "Add Flight";
            this.subMenuAddFlight.Click += new System.EventHandler(this.subMenuAddFlight_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.dateTimeALC);
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 24);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1014, 100);
            this.panelHeader.TabIndex = 1;
            // 
            // dateTimeALC
            // 
            this.dateTimeALC.CalendarFont = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.dateTimeALC.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F);
            this.dateTimeALC.Location = new System.Drawing.Point(12, 17);
            this.dateTimeALC.Name = "dateTimeALC";
            this.dateTimeALC.Size = new System.Drawing.Size(170, 25);
            this.dateTimeALC.TabIndex = 31;
            this.dateTimeALC.ValueChanged += new System.EventHandler(this.dateTimeALC_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1014, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // dgvSchedulerALC
            // 
            this.dgvSchedulerALC.AllowUserToAddRows = false;
            this.dgvSchedulerALC.AllowUserToDeleteRows = false;
            this.dgvSchedulerALC.AllowUserToResizeColumns = false;
            this.dgvSchedulerALC.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSchedulerALC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSchedulerALC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSchedulerALC.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSchedulerALC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSchedulerALC.Location = new System.Drawing.Point(0, 124);
            this.dgvSchedulerALC.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSchedulerALC.Name = "dgvSchedulerALC";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSchedulerALC.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSchedulerALC.Size = new System.Drawing.Size(1014, 372);
            this.dgvSchedulerALC.TabIndex = 6;
            this.dgvSchedulerALC.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSchedulerALC_CellMouseUp);
            this.dgvSchedulerALC.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvSchedulerALC_KeyUp);
            // 
            // dgvMenuStripFlights
            // 
            this.dgvMenuStripFlights.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuDeleteFlight});
            this.dgvMenuStripFlights.Name = "contextMenuStrip1";
            this.dgvMenuStripFlights.Size = new System.Drawing.Size(141, 26);
            // 
            // subMenuDeleteFlight
            // 
            this.subMenuDeleteFlight.Name = "subMenuDeleteFlight";
            this.subMenuDeleteFlight.Size = new System.Drawing.Size(140, 22);
            this.subMenuDeleteFlight.Text = "Delete Flight";
            this.subMenuDeleteFlight.Click += new System.EventHandler(this.subMenuDeleteFlight_Click);
            // 
            // SchedulerALC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 496);
            this.Controls.Add(this.dgvSchedulerALC);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SchedulerALC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SchedulerALC_FormClosing);
            this.Load += new System.EventHandler(this.SchedulerALC_Load);
            this.Resize += new System.EventHandler(this.SchedulerALC_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedulerALC)).EndInit();
            this.dgvMenuStripFlights.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuStripFlights;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimeALC;
        public System.Windows.Forms.DataGridView dgvSchedulerALC;
        private System.Windows.Forms.ToolStripMenuItem subMenuAddFlight;
        private System.Windows.Forms.ContextMenuStrip dgvMenuStripFlights;
        private System.Windows.Forms.ToolStripMenuItem subMenuDeleteFlight;
    }
}