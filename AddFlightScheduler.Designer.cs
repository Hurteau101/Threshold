
namespace Perimeter_Threshold
{
    partial class AddFlightScheduler
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
            this.label10 = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddFlight = new System.Windows.Forms.Button();
            this.tbRouting = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDeparture = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFlightNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkListBoxDayOfWeek = new System.Windows.Forms.CheckedListBox();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(39, 14);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(191, 24);
            this.label10.TabIndex = 19;
            this.label10.Text = "Add Flight Schedule";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(112)))), ((int)(((byte)(34)))));
            this.panelHeader.Controls.Add(this.label10);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(314, 53);
            this.panelHeader.TabIndex = 61;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F);
            this.label9.Location = new System.Drawing.Point(21, 110);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 18);
            this.label9.TabIndex = 60;
            this.label9.Text = "Day Of Week:";
            // 
            // btnAddFlight
            // 
            this.btnAddFlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(112)))), ((int)(((byte)(34)))));
            this.btnAddFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFlight.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F);
            this.btnAddFlight.ForeColor = System.Drawing.Color.White;
            this.btnAddFlight.Location = new System.Drawing.Point(133, 342);
            this.btnAddFlight.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddFlight.Name = "btnAddFlight";
            this.btnAddFlight.Size = new System.Drawing.Size(122, 25);
            this.btnAddFlight.TabIndex = 56;
            this.btnAddFlight.Text = "Add Flight";
            this.btnAddFlight.UseVisualStyleBackColor = false;
            this.btnAddFlight.Click += new System.EventHandler(this.btnAddFlight_Click);
            // 
            // tbRouting
            // 
            this.tbRouting.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbRouting.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F);
            this.tbRouting.Location = new System.Drawing.Point(133, 307);
            this.tbRouting.Margin = new System.Windows.Forms.Padding(2);
            this.tbRouting.Name = "tbRouting";
            this.tbRouting.Size = new System.Drawing.Size(122, 25);
            this.tbRouting.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F);
            this.label3.Location = new System.Drawing.Point(21, 308);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 59;
            this.label3.Text = "Routing:";
            // 
            // tbDeparture
            // 
            this.tbDeparture.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F);
            this.tbDeparture.Location = new System.Drawing.Point(133, 271);
            this.tbDeparture.Margin = new System.Windows.Forms.Padding(2);
            this.tbDeparture.Name = "tbDeparture";
            this.tbDeparture.Size = new System.Drawing.Size(122, 25);
            this.tbDeparture.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F);
            this.label2.Location = new System.Drawing.Point(21, 272);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 58;
            this.label2.Text = "Departure:";
            // 
            // tbFlightNumber
            // 
            this.tbFlightNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbFlightNumber.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F);
            this.tbFlightNumber.Location = new System.Drawing.Point(133, 72);
            this.tbFlightNumber.Margin = new System.Windows.Forms.Padding(2);
            this.tbFlightNumber.Name = "tbFlightNumber";
            this.tbFlightNumber.Size = new System.Drawing.Size(122, 25);
            this.tbFlightNumber.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F);
            this.label1.Location = new System.Drawing.Point(21, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 57;
            this.label1.Text = "Flight Number:";
            // 
            // chkListBoxDayOfWeek
            // 
            this.chkListBoxDayOfWeek.BackColor = System.Drawing.SystemColors.Control;
            this.chkListBoxDayOfWeek.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chkListBoxDayOfWeek.CheckOnClick = true;
            this.chkListBoxDayOfWeek.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F);
            this.chkListBoxDayOfWeek.FormattingEnabled = true;
            this.chkListBoxDayOfWeek.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.chkListBoxDayOfWeek.Location = new System.Drawing.Point(135, 110);
            this.chkListBoxDayOfWeek.Name = "chkListBoxDayOfWeek";
            this.chkListBoxDayOfWeek.Size = new System.Drawing.Size(120, 140);
            this.chkListBoxDayOfWeek.TabIndex = 62;
            // 
            // AddFlightScheduler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 394);
            this.Controls.Add(this.chkListBoxDayOfWeek);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnAddFlight);
            this.Controls.Add(this.tbRouting);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDeparture);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFlightNumber);
            this.Controls.Add(this.label1);
            this.Name = "AddFlightScheduler";
            this.Text = "AddFlightScheduler";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddFlight;
        private System.Windows.Forms.TextBox tbRouting;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDeparture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFlightNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox chkListBoxDayOfWeek;
    }
}