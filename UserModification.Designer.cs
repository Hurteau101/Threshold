namespace Perimeter_Threshold
{
    partial class UserModification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserModification));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModifyUser = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblDeparture = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lblRouting = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lblFlightNumber = new System.Windows.Forms.Label();
            this.cbRoleID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbConfPw = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(112)))), ((int)(((byte)(34)))));
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(385, 53);
            this.panelHeader.TabIndex = 74;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(31, 15);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(60, 24);
            this.lblHeader.TabIndex = 19;
            this.lblHeader.Text = "Users";
            // 
            // tbLastName
            // 
            this.tbLastName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.tbLastName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbLastName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastName.Location = new System.Drawing.Point(147, 110);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(170, 25);
            this.tbLastName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 75;
            this.label1.Text = "Last Name:";
            // 
            // btnModifyUser
            // 
            this.btnModifyUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(112)))), ((int)(((byte)(34)))));
            this.btnModifyUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyUser.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyUser.ForeColor = System.Drawing.Color.White;
            this.btnModifyUser.Location = new System.Drawing.Point(147, 326);
            this.btnModifyUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModifyUser.Name = "btnModifyUser";
            this.btnModifyUser.Size = new System.Drawing.Size(170, 25);
            this.btnModifyUser.TabIndex = 7;
            this.btnModifyUser.Text = "Add User";
            this.btnModifyUser.UseVisualStyleBackColor = false;
            this.btnModifyUser.Click += new System.EventHandler(this.btnModifyUser_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.tbPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(147, 196);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(170, 25);
            this.tbPassword.TabIndex = 4;
            // 
            // lblDeparture
            // 
            this.lblDeparture.AutoSize = true;
            this.lblDeparture.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeparture.Location = new System.Drawing.Point(27, 196);
            this.lblDeparture.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeparture.Name = "lblDeparture";
            this.lblDeparture.Size = new System.Drawing.Size(73, 18);
            this.lblDeparture.TabIndex = 71;
            this.lblDeparture.Text = "Password:";
            // 
            // tbUsername
            // 
            this.tbUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.tbUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbUsername.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(147, 153);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(170, 25);
            this.tbUsername.TabIndex = 3;
            // 
            // lblRouting
            // 
            this.lblRouting.AutoSize = true;
            this.lblRouting.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRouting.Location = new System.Drawing.Point(21, 154);
            this.lblRouting.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRouting.Name = "lblRouting";
            this.lblRouting.Size = new System.Drawing.Size(78, 18);
            this.lblRouting.TabIndex = 70;
            this.lblRouting.Text = "Username:";
            // 
            // tbFirstName
            // 
            this.tbFirstName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.tbFirstName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbFirstName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstName.Location = new System.Drawing.Point(147, 67);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(170, 25);
            this.tbFirstName.TabIndex = 1;
            // 
            // lblFlightNumber
            // 
            this.lblFlightNumber.AutoSize = true;
            this.lblFlightNumber.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightNumber.Location = new System.Drawing.Point(18, 70);
            this.lblFlightNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFlightNumber.Name = "lblFlightNumber";
            this.lblFlightNumber.Size = new System.Drawing.Size(82, 18);
            this.lblFlightNumber.TabIndex = 69;
            this.lblFlightNumber.Text = "First Name:";
            // 
            // cbRoleID
            // 
            this.cbRoleID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F);
            this.cbRoleID.FormattingEnabled = true;
            this.cbRoleID.Items.AddRange(new object[] {
            "Ramp Agent",
            "Ramp Supervsior",
            "Ramp Manager",
            "Cargo Agent ",
            "Cargo Supervisor",
            "Cargo Manager",
            "ALC",
            "Admin",
            "Network Planner",
            "Cargo Coordinator",
            "Directory of Cargo",
            "Charter",
            "Manifestor",
            "VIP"});
            this.cbRoleID.Location = new System.Drawing.Point(147, 282);
            this.cbRoleID.Name = "cbRoleID";
            this.cbRoleID.Size = new System.Drawing.Size(170, 26);
            this.cbRoleID.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 280);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 77;
            this.label2.Text = "Role:";
            // 
            // tbConfPw
            // 
            this.tbConfPw.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.tbConfPw.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbConfPw.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConfPw.Location = new System.Drawing.Point(147, 239);
            this.tbConfPw.Margin = new System.Windows.Forms.Padding(2);
            this.tbConfPw.Name = "tbConfPw";
            this.tbConfPw.PasswordChar = '*';
            this.tbConfPw.Size = new System.Drawing.Size(170, 25);
            this.tbConfPw.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 238);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 18);
            this.label3.TabIndex = 79;
            this.label3.Text = "Confirm Password:";
            // 
            // UserModification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 371);
            this.Controls.Add(this.tbConfPw);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbRoleID);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnModifyUser);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lblDeparture);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.lblRouting);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lblFlightNumber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserModification";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModifyUser;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblDeparture;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lblRouting;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lblFlightNumber;
        private System.Windows.Forms.ComboBox cbRoleID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbConfPw;
        private System.Windows.Forms.Label label3;
    }
}