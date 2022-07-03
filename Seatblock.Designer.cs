
namespace Perimeter_Threshold
{
    partial class Seatblock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Seatblock));
            this.dateSeatblock = new System.Windows.Forms.DateTimePicker();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.rchSeatblock = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFlightNumber = new System.Windows.Forms.TextBox();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateSeatblock
            // 
            this.dateSeatblock.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F);
            this.dateSeatblock.Location = new System.Drawing.Point(150, 15);
            this.dateSeatblock.Margin = new System.Windows.Forms.Padding(2);
            this.dateSeatblock.Name = "dateSeatblock";
            this.dateSeatblock.Size = new System.Drawing.Size(170, 25);
            this.dateSeatblock.TabIndex = 1;
            this.dateSeatblock.ValueChanged += new System.EventHandler(this.dateSeatblock_ValueChanged);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(112)))), ((int)(((byte)(34)))));
            this.panelHeader.Controls.Add(this.label10);
            this.panelHeader.Controls.Add(this.dateSeatblock);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(354, 53);
            this.panelHeader.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(21, 15);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 24);
            this.label10.TabIndex = 19;
            this.label10.Text = "Seatblock";
            // 
            // rchSeatblock
            // 
            this.rchSeatblock.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.rchSeatblock.Location = new System.Drawing.Point(23, 154);
            this.rchSeatblock.Margin = new System.Windows.Forms.Padding(2);
            this.rchSeatblock.Name = "rchSeatblock";
            this.rchSeatblock.Size = new System.Drawing.Size(309, 141);
            this.rchSeatblock.TabIndex = 2;
            this.rchSeatblock.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F);
            this.label6.Location = new System.Drawing.Point(23, 118);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(282, 24);
            this.label6.TabIndex = 69;
            this.label6.Text = "Current Seatblock Information";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(112)))), ((int)(((byte)(34)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(23, 318);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(309, 46);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F);
            this.label2.Location = new System.Drawing.Point(23, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 59;
            this.label2.Text = "Flight #:";
            // 
            // tbFlightNumber
            // 
            this.tbFlightNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbFlightNumber.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F);
            this.tbFlightNumber.Location = new System.Drawing.Point(118, 70);
            this.tbFlightNumber.Margin = new System.Windows.Forms.Padding(2);
            this.tbFlightNumber.Name = "tbFlightNumber";
            this.tbFlightNumber.Size = new System.Drawing.Size(159, 25);
            this.tbFlightNumber.TabIndex = 1;
            this.tbFlightNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbFlightNumber.TextChanged += new System.EventHandler(this.tbFlightNumber_TextChanged);
            // 
            // Seatblock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 395);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rchSeatblock);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbFlightNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(370, 434);
            this.Name = "Seatblock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.Seatblock_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateSeatblock;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.RichTextBox rchSeatblock;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFlightNumber;
    }
}