﻿
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuStripFlights = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuAddFlight = new System.Windows.Forms.ToolStripMenuItem();
            this.smallPanelEarly = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pictureHeader = new System.Windows.Forms.PictureBox();
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
            this.dgvRampBoard = new System.Windows.Forms.DataGridView();
            this.lblUser = new System.Windows.Forms.Label();
            this.dateTimeRamp = new System.Windows.Forms.DateTimePicker();
            this.menuStrip.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHeader)).BeginInit();
            this.panelColors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRampBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripFlights});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1014, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
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
            // smallPanelEarly
            // 
            this.smallPanelEarly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.smallPanelEarly.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.smallPanelEarly.Location = new System.Drawing.Point(11, 18);
            this.smallPanelEarly.Name = "smallPanelEarly";
            this.smallPanelEarly.Size = new System.Drawing.Size(17, 20);
            this.smallPanelEarly.TabIndex = 2;
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
            this.panelHeader.Size = new System.Drawing.Size(1014, 119);
            this.panelHeader.TabIndex = 3;
            // 
            // pictureHeader
            // 
            this.pictureHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureHeader.Image = global::Perimeter_Threshold.Properties.Resources.RampBoardHeader;
            this.pictureHeader.Location = new System.Drawing.Point(0, 0);
            this.pictureHeader.Name = "pictureHeader";
            this.pictureHeader.Size = new System.Drawing.Size(1014, 119);
            this.pictureHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureHeader.TabIndex = 4;
            this.pictureHeader.TabStop = false;
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
            this.panelColors.Location = new System.Drawing.Point(864, 0);
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
            // 
            // smallPanelOnTime
            // 
            this.smallPanelOnTime.BackColor = System.Drawing.Color.Black;
            this.smallPanelOnTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.smallPanelOnTime.Location = new System.Drawing.Point(68, 18);
            this.smallPanelOnTime.Name = "smallPanelOnTime";
            this.smallPanelOnTime.Size = new System.Drawing.Size(17, 20);
            this.smallPanelOnTime.TabIndex = 3;
            // 
            // smallPanelUnserviceable
            // 
            this.smallPanelUnserviceable.BackColor = System.Drawing.Color.Yellow;
            this.smallPanelUnserviceable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.smallPanelUnserviceable.Location = new System.Drawing.Point(11, 80);
            this.smallPanelUnserviceable.Name = "smallPanelUnserviceable";
            this.smallPanelUnserviceable.Size = new System.Drawing.Size(17, 20);
            this.smallPanelUnserviceable.TabIndex = 4;
            // 
            // smallPanelLate
            // 
            this.smallPanelLate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(13)))), ((int)(((byte)(26)))));
            this.smallPanelLate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.smallPanelLate.Location = new System.Drawing.Point(11, 49);
            this.smallPanelLate.Name = "smallPanelLate";
            this.smallPanelLate.Size = new System.Drawing.Size(17, 20);
            this.smallPanelLate.TabIndex = 3;
            // 
            // dgvRampBoard
            // 
            this.dgvRampBoard.AllowUserToAddRows = false;
            this.dgvRampBoard.AllowUserToDeleteRows = false;
            this.dgvRampBoard.AllowUserToResizeColumns = false;
            this.dgvRampBoard.AllowUserToResizeRows = false;
            this.dgvRampBoard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRampBoard.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvRampBoard.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvRampBoard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRampBoard.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRampBoard.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRampBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRampBoard.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRampBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRampBoard.GridColor = System.Drawing.Color.White;
            this.dgvRampBoard.Location = new System.Drawing.Point(0, 143);
            this.dgvRampBoard.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRampBoard.Name = "dgvRampBoard";
            this.dgvRampBoard.RowHeadersWidth = 51;
            this.dgvRampBoard.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRampBoard.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRampBoard.RowTemplate.Height = 24;
            this.dgvRampBoard.Size = new System.Drawing.Size(1014, 353);
            this.dgvRampBoard.TabIndex = 4;
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
            // dateTimeRamp
            // 
            this.dateTimeRamp.CalendarFont = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.dateTimeRamp.Location = new System.Drawing.Point(11, 28);
            this.dateTimeRamp.Name = "dateTimeRamp";
            this.dateTimeRamp.Size = new System.Drawing.Size(151, 20);
            this.dateTimeRamp.TabIndex = 6;
            // 
            // RampBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1014, 496);
            this.Controls.Add(this.dgvRampBoard);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.menuStrip);
            this.Name = "RampBoard";
            this.Text = "RampBoard";
            this.Load += new System.EventHandler(this.RampBoard_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHeader)).EndInit();
            this.panelColors.ResumeLayout(false);
            this.panelColors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRampBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuStripFlights;
        private System.Windows.Forms.Panel smallPanelEarly;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pictureHeader;
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
        public System.Windows.Forms.DataGridView dgvRampBoard;
        private System.Windows.Forms.ToolStripMenuItem subMenuAddFlight;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.DateTimePicker dateTimeRamp;
    }
}