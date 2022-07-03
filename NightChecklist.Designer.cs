namespace Perimeter_Threshold
{
    partial class NightChecklist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NightChecklist));
            this.rchTbSeatpacks = new System.Windows.Forms.RichTextBox();
            this.dateCheckList = new System.Windows.Forms.DateTimePicker();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.lblUpdatedTime = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rchTbTasks = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // rchTbSeatpacks
            // 
            this.rchTbSeatpacks.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.rchTbSeatpacks.Location = new System.Drawing.Point(25, 102);
            this.rchTbSeatpacks.Margin = new System.Windows.Forms.Padding(2);
            this.rchTbSeatpacks.Name = "rchTbSeatpacks";
            this.rchTbSeatpacks.Size = new System.Drawing.Size(309, 123);
            this.rchTbSeatpacks.TabIndex = 1;
            this.rchTbSeatpacks.Text = "";
            // 
            // dateCheckList
            // 
            this.dateCheckList.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F);
            this.dateCheckList.Location = new System.Drawing.Point(172, 15);
            this.dateCheckList.Margin = new System.Windows.Forms.Padding(2);
            this.dateCheckList.Name = "dateCheckList";
            this.dateCheckList.Size = new System.Drawing.Size(170, 25);
            this.dateCheckList.TabIndex = 1;
            this.dateCheckList.ValueChanged += new System.EventHandler(this.dateCheckList_ValueChanged);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(112)))), ((int)(((byte)(34)))));
            this.panelHeader.Controls.Add(this.label10);
            this.panelHeader.Controls.Add(this.dateCheckList);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(360, 53);
            this.panelHeader.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(21, 15);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 24);
            this.label10.TabIndex = 19;
            this.label10.Text = "Night Checklist";
            // 
            // lblUpdatedTime
            // 
            this.lblUpdatedTime.AutoSize = true;
            this.lblUpdatedTime.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdatedTime.Location = new System.Drawing.Point(55, 485);
            this.lblUpdatedTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdatedTime.Name = "lblUpdatedTime";
            this.lblUpdatedTime.Size = new System.Drawing.Size(12, 14);
            this.lblUpdatedTime.TabIndex = 28;
            this.lblUpdatedTime.Text = "-";
            this.lblUpdatedTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUpdatedTime.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(112)))), ((int)(((byte)(34)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(25, 427);
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
            this.label2.Location = new System.Drawing.Point(22, 254);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "Night Tasks";
            // 
            // rchTbTasks
            // 
            this.rchTbTasks.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.rchTbTasks.Location = new System.Drawing.Point(25, 280);
            this.rchTbTasks.Margin = new System.Windows.Forms.Padding(2);
            this.rchTbTasks.Name = "rchTbTasks";
            this.rchTbTasks.Size = new System.Drawing.Size(309, 123);
            this.rchTbTasks.TabIndex = 2;
            this.rchTbTasks.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F);
            this.label1.Location = new System.Drawing.Point(21, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Night Seatpacks";
            // 
            // NightChecklist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 520);
            this.Controls.Add(this.rchTbSeatpacks);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.lblUpdatedTime);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rchTbTasks);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(376, 559);
            this.Name = "NightChecklist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.NightChecklist_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox rchTbSeatpacks;
        private System.Windows.Forms.DateTimePicker dateCheckList;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label lblUpdatedTime;
        public System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.RichTextBox rchTbTasks;
        private System.Windows.Forms.Label label1;
    }
}