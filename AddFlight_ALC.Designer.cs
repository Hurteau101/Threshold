
namespace Perimeter_Threshold
{
    partial class AddFlight_ALC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFlight_ALC));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.lblDeparture = new System.Windows.Forms.Label();
            this.tbRouting = new System.Windows.Forms.TextBox();
            this.lblRouting = new System.Windows.Forms.Label();
            this.tbFlightNumber = new System.Windows.Forms.TextBox();
            this.lblFlightNumber = new System.Windows.Forms.Label();
            this.tbDeparture = new System.Windows.Forms.TextBox();
            this.btnAddFlight = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFlightNumber = new System.Windows.Forms.ComboBox();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(112)))), ((int)(((byte)(34)))));
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(472, 65);
            this.panelHeader.TabIndex = 60;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(41, 18);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(130, 30);
            this.lblHeader.TabIndex = 19;
            this.lblHeader.Text = "Add Flight";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(43, 149);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(52, 22);
            this.lblDate.TabIndex = 59;
            this.lblDate.Text = "Date:";
            // 
            // datePicker
            // 
            this.datePicker.CalendarFont = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.CustomFormat = "";
            this.datePicker.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Location = new System.Drawing.Point(196, 146);
            this.datePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(225, 29);
            this.datePicker.TabIndex = 58;
            // 
            // lblDeparture
            // 
            this.lblDeparture.AutoSize = true;
            this.lblDeparture.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeparture.Location = new System.Drawing.Point(43, 281);
            this.lblDeparture.Name = "lblDeparture";
            this.lblDeparture.Size = new System.Drawing.Size(95, 22);
            this.lblDeparture.TabIndex = 49;
            this.lblDeparture.Text = "Departure:";
            // 
            // tbRouting
            // 
            this.tbRouting.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.tbRouting.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbRouting.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbRouting.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRouting.Location = new System.Drawing.Point(196, 236);
            this.tbRouting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRouting.Name = "tbRouting";
            this.tbRouting.Size = new System.Drawing.Size(225, 29);
            this.tbRouting.TabIndex = 3;
            // 
            // lblRouting
            // 
            this.lblRouting.AutoSize = true;
            this.lblRouting.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRouting.Location = new System.Drawing.Point(43, 238);
            this.lblRouting.Name = "lblRouting";
            this.lblRouting.Size = new System.Drawing.Size(77, 22);
            this.lblRouting.TabIndex = 46;
            this.lblRouting.Text = "Routing:";
            // 
            // tbFlightNumber
            // 
            this.tbFlightNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.tbFlightNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbFlightNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbFlightNumber.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFlightNumber.Location = new System.Drawing.Point(196, 106);
            this.tbFlightNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFlightNumber.Name = "tbFlightNumber";
            this.tbFlightNumber.Size = new System.Drawing.Size(225, 29);
            this.tbFlightNumber.TabIndex = 1;
            // 
            // lblFlightNumber
            // 
            this.lblFlightNumber.AutoSize = true;
            this.lblFlightNumber.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightNumber.Location = new System.Drawing.Point(43, 106);
            this.lblFlightNumber.Name = "lblFlightNumber";
            this.lblFlightNumber.Size = new System.Drawing.Size(129, 22);
            this.lblFlightNumber.TabIndex = 41;
            this.lblFlightNumber.Text = "Flight Number:";
            // 
            // tbDeparture
            // 
            this.tbDeparture.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.tbDeparture.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbDeparture.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDeparture.Location = new System.Drawing.Point(196, 279);
            this.tbDeparture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDeparture.Name = "tbDeparture";
            this.tbDeparture.Size = new System.Drawing.Size(225, 29);
            this.tbDeparture.TabIndex = 4;
            // 
            // btnAddFlight
            // 
            this.btnAddFlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(112)))), ((int)(((byte)(34)))));
            this.btnAddFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFlight.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFlight.ForeColor = System.Drawing.Color.White;
            this.btnAddFlight.Location = new System.Drawing.Point(196, 331);
            this.btnAddFlight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddFlight.Name = "btnAddFlight";
            this.btnAddFlight.Size = new System.Drawing.Size(227, 31);
            this.btnAddFlight.TabIndex = 5;
            this.btnAddFlight.Text = "Add Flight";
            this.btnAddFlight.UseVisualStyleBackColor = false;
            this.btnAddFlight.Click += new System.EventHandler(this.btnAddFlight_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 22);
            this.label1.TabIndex = 63;
            this.label1.Text = "Number of Legs";
            // 
            // cbFlightNumber
            // 
            this.cbFlightNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFlightNumber.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F);
            this.cbFlightNumber.FormattingEnabled = true;
            this.cbFlightNumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbFlightNumber.Location = new System.Drawing.Point(196, 190);
            this.cbFlightNumber.Name = "cbFlightNumber";
            this.cbFlightNumber.Size = new System.Drawing.Size(227, 30);
            this.cbFlightNumber.TabIndex = 2;
            // 
            // AddFlight_ALC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 377);
            this.Controls.Add(this.cbFlightNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddFlight);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.tbDeparture);
            this.Controls.Add(this.lblDeparture);
            this.Controls.Add(this.tbRouting);
            this.Controls.Add(this.lblRouting);
            this.Controls.Add(this.tbFlightNumber);
            this.Controls.Add(this.lblFlightNumber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(490, 424);
            this.Name = "AddFlight_ALC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.AddFlight_ALC_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label lblDeparture;
        private System.Windows.Forms.TextBox tbRouting;
        private System.Windows.Forms.Label lblRouting;
        private System.Windows.Forms.TextBox tbFlightNumber;
        private System.Windows.Forms.Label lblFlightNumber;
        private System.Windows.Forms.TextBox tbDeparture;
        private System.Windows.Forms.Button btnAddFlight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFlightNumber;
    }
}