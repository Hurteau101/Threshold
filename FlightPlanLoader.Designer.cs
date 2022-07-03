namespace Perimeter_Threshold
{
    partial class FlightPlanLoader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightPlanLoader));
            this.tbFlightPlan = new System.Windows.Forms.TextBox();
            this.btnAddFlight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbFlightPlan
            // 
            this.tbFlightPlan.AllowDrop = true;
            this.tbFlightPlan.Location = new System.Drawing.Point(12, 12);
            this.tbFlightPlan.Multiline = true;
            this.tbFlightPlan.Name = "tbFlightPlan";
            this.tbFlightPlan.ReadOnly = true;
            this.tbFlightPlan.Size = new System.Drawing.Size(463, 30);
            this.tbFlightPlan.TabIndex = 0;
            this.tbFlightPlan.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbFlightPlan_DragDrop);
            this.tbFlightPlan.DragOver += new System.Windows.Forms.DragEventHandler(this.tbFlightPlan_DragOver);
            // 
            // btnAddFlight
            // 
            this.btnAddFlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(112)))), ((int)(((byte)(34)))));
            this.btnAddFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFlight.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFlight.ForeColor = System.Drawing.Color.White;
            this.btnAddFlight.Location = new System.Drawing.Point(12, 56);
            this.btnAddFlight.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddFlight.Name = "btnAddFlight";
            this.btnAddFlight.Size = new System.Drawing.Size(463, 25);
            this.btnAddFlight.TabIndex = 6;
            this.btnAddFlight.Text = "Open File Explorer";
            this.btnAddFlight.UseVisualStyleBackColor = false;
            this.btnAddFlight.Click += new System.EventHandler(this.btnAddFlight_Click);
            // 
            // FlightPlanLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 98);
            this.Controls.Add(this.btnAddFlight);
            this.Controls.Add(this.tbFlightPlan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FlightPlanLoader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FlightPlanLoader_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFlightPlan;
        private System.Windows.Forms.Button btnAddFlight;
    }
}