
namespace Perimeter_Threshold
{
    partial class MasterScheduler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterScheduler));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.cbDayOfWeek = new System.Windows.Forms.ComboBox();
            this.lblDayOfWeek = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStripFlights = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuAddFlight = new System.Windows.Forms.ToolStripMenuItem();
            this.showALCLegsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideALCLegsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvMasterSchedule = new System.Windows.Forms.DataGridView();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasterSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.cbDayOfWeek);
            this.panelHeader.Controls.Add(this.lblDayOfWeek);
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Controls.Add(this.menuStrip1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1163, 133);
            this.panelHeader.TabIndex = 0;
            // 
            // cbDayOfWeek
            // 
            this.cbDayOfWeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDayOfWeek.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDayOfWeek.FormattingEnabled = true;
            this.cbDayOfWeek.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.cbDayOfWeek.Location = new System.Drawing.Point(120, 63);
            this.cbDayOfWeek.Margin = new System.Windows.Forms.Padding(2);
            this.cbDayOfWeek.Name = "cbDayOfWeek";
            this.cbDayOfWeek.Size = new System.Drawing.Size(92, 25);
            this.cbDayOfWeek.TabIndex = 6;
            this.cbDayOfWeek.SelectedIndexChanged += new System.EventHandler(this.cbDayOfWeek_SelectedIndexChanged);
            // 
            // lblDayOfWeek
            // 
            this.lblDayOfWeek.AutoSize = true;
            this.lblDayOfWeek.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayOfWeek.Location = new System.Drawing.Point(18, 66);
            this.lblDayOfWeek.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDayOfWeek.Name = "lblDayOfWeek";
            this.lblDayOfWeek.Size = new System.Drawing.Size(100, 20);
            this.lblDayOfWeek.TabIndex = 5;
            this.lblDayOfWeek.Text = "Day Of Week:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1163, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripFlights});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1163, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStripFlights
            // 
            this.menuStripFlights.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuAddFlight,
            this.showALCLegsToolStripMenuItem,
            this.hideALCLegsToolStripMenuItem});
            this.menuStripFlights.Name = "menuStripFlights";
            this.menuStripFlights.Size = new System.Drawing.Size(54, 20);
            this.menuStripFlights.Text = "Flights";
            // 
            // subMenuAddFlight
            // 
            this.subMenuAddFlight.Name = "subMenuAddFlight";
            this.subMenuAddFlight.Size = new System.Drawing.Size(155, 22);
            this.subMenuAddFlight.Text = "Add Flight";
            this.subMenuAddFlight.Click += new System.EventHandler(this.subMenuAddFlight_Click);
            // 
            // showALCLegsToolStripMenuItem
            // 
            this.showALCLegsToolStripMenuItem.Image = global::Perimeter_Threshold.Properties.Resources.LOGO;
            this.showALCLegsToolStripMenuItem.Name = "showALCLegsToolStripMenuItem";
            this.showALCLegsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.showALCLegsToolStripMenuItem.Text = "Show ALC Legs";
            this.showALCLegsToolStripMenuItem.Click += new System.EventHandler(this.showALCLegsToolStripMenuItem_Click);
            // 
            // hideALCLegsToolStripMenuItem
            // 
            this.hideALCLegsToolStripMenuItem.Checked = true;
            this.hideALCLegsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hideALCLegsToolStripMenuItem.Image = global::Perimeter_Threshold.Properties.Resources.LOGO;
            this.hideALCLegsToolStripMenuItem.Name = "hideALCLegsToolStripMenuItem";
            this.hideALCLegsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.hideALCLegsToolStripMenuItem.Text = "Hide ALC Legs";
            this.hideALCLegsToolStripMenuItem.Click += new System.EventHandler(this.hideALCLegsToolStripMenuItem_Click);
            // 
            // dgvMasterSchedule
            // 
            this.dgvMasterSchedule.AllowUserToAddRows = false;
            this.dgvMasterSchedule.AllowUserToDeleteRows = false;
            this.dgvMasterSchedule.AllowUserToResizeColumns = false;
            this.dgvMasterSchedule.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMasterSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMasterSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMasterSchedule.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMasterSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMasterSchedule.Location = new System.Drawing.Point(0, 133);
            this.dgvMasterSchedule.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMasterSchedule.Name = "dgvMasterSchedule";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMasterSchedule.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMasterSchedule.Size = new System.Drawing.Size(1163, 349);
            this.dgvMasterSchedule.TabIndex = 5;
            this.dgvMasterSchedule.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvMasterSchedule_KeyUp);
            // 
            // MasterScheduler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 482);
            this.Controls.Add(this.dgvMasterSchedule);
            this.Controls.Add(this.panelHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MasterScheduler";
            this.Load += new System.EventHandler(this.MasterScheduler_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasterSchedule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuStripFlights;
        private System.Windows.Forms.ComboBox cbDayOfWeek;
        private System.Windows.Forms.Label lblDayOfWeek;
        public System.Windows.Forms.DataGridView dgvMasterSchedule;
        private System.Windows.Forms.ToolStripMenuItem subMenuAddFlight;
        private System.Windows.Forms.ToolStripMenuItem showALCLegsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideALCLegsToolStripMenuItem;
    }
}