namespace Perimeter_Threshold
{
    partial class AdminUserControl
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.cbRoleID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSearchBy = new System.Windows.Forms.ComboBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(112)))), ((int)(((byte)(34)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(269, 150);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 25);
            this.button1.TabIndex = 100;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(112)))), ((int)(((byte)(34)))));
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(0, 365);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(488, 32);
            this.btnUpdate.TabIndex = 99;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F);
            this.label7.Location = new System.Drawing.Point(266, 317);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 18);
            this.label7.TabIndex = 98;
            this.label7.Text = "Email:";
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.Gainsboro;
            this.tbEmail.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.tbEmail.Location = new System.Drawing.Point(319, 313);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.ReadOnly = true;
            this.tbEmail.Size = new System.Drawing.Size(122, 23);
            this.tbEmail.TabIndex = 97;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F);
            this.label9.Location = new System.Drawing.Point(8, 317);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 18);
            this.label9.TabIndex = 96;
            this.label9.Text = "Last Name:";
            // 
            // tbLastName
            // 
            this.tbLastName.BackColor = System.Drawing.Color.Gainsboro;
            this.tbLastName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.tbLastName.Location = new System.Drawing.Point(94, 313);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(2);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.ReadOnly = true;
            this.tbLastName.Size = new System.Drawing.Size(122, 23);
            this.tbLastName.TabIndex = 95;
            // 
            // cbRoleID
            // 
            this.cbRoleID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoleID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.cbRoleID.FormattingEnabled = true;
            this.cbRoleID.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbRoleID.Location = new System.Drawing.Point(94, 272);
            this.cbRoleID.Margin = new System.Windows.Forms.Padding(2);
            this.cbRoleID.Name = "cbRoleID";
            this.cbRoleID.Size = new System.Drawing.Size(122, 23);
            this.cbRoleID.TabIndex = 94;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F);
            this.label4.Location = new System.Drawing.Point(233, 276);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 18);
            this.label4.TabIndex = 93;
            this.label4.Text = "First Name:";
            // 
            // tbFirstName
            // 
            this.tbFirstName.BackColor = System.Drawing.Color.Gainsboro;
            this.tbFirstName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.tbFirstName.Location = new System.Drawing.Point(319, 272);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.ReadOnly = true;
            this.tbFirstName.Size = new System.Drawing.Size(122, 23);
            this.tbFirstName.TabIndex = 92;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F);
            this.label5.Location = new System.Drawing.Point(241, 236);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 18);
            this.label5.TabIndex = 91;
            this.label5.Text = "Password:";
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.Gainsboro;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.tbPassword.Location = new System.Drawing.Point(319, 232);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.ReadOnly = true;
            this.tbPassword.Size = new System.Drawing.Size(122, 23);
            this.tbPassword.TabIndex = 90;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F);
            this.label3.Location = new System.Drawing.Point(29, 276);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 89;
            this.label3.Text = "RoleID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F);
            this.label1.Location = new System.Drawing.Point(8, 236);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 88;
            this.label1.Text = "Username:";
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.Color.Gainsboro;
            this.tbUsername.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.tbUsername.Location = new System.Drawing.Point(94, 232);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(2);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.ReadOnly = true;
            this.tbUsername.Size = new System.Drawing.Size(122, 23);
            this.tbUsername.TabIndex = 87;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(112)))), ((int)(((byte)(34)))));
            this.panel1.Location = new System.Drawing.Point(-1, 195);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 8);
            this.panel1.TabIndex = 85;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F);
            this.label2.Location = new System.Drawing.Point(42, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 86;
            this.label2.Text = "Search By:";
            // 
            // cbSearchBy
            // 
            this.cbSearchBy.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.cbSearchBy.FormattingEnabled = true;
            this.cbSearchBy.Items.AddRange(new object[] {
            "Username",
            "RoleID",
            "FirstName",
            "LastName",
            "FullName",
            "EmailAddress"});
            this.cbSearchBy.Location = new System.Drawing.Point(131, 74);
            this.cbSearchBy.Margin = new System.Windows.Forms.Padding(2);
            this.cbSearchBy.Name = "cbSearchBy";
            this.cbSearchBy.Size = new System.Drawing.Size(122, 23);
            this.cbSearchBy.TabIndex = 84;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(112)))), ((int)(((byte)(34)))));
            this.panelHeader.Controls.Add(this.label10);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(488, 53);
            this.panelHeader.TabIndex = 83;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(39, 14);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(179, 24);
            this.label10.TabIndex = 19;
            this.label10.Text = "Add | Modifer User";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(112)))), ((int)(((byte)(34)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(131, 150);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(122, 25);
            this.btnSearch.TabIndex = 82;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.tbSearch.Location = new System.Drawing.Point(131, 110);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(2);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(122, 23);
            this.tbSearch.TabIndex = 81;
            // 
            // AdminUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 397);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.cbRoleID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSearchBy);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearch);
            this.Name = "AdminUserControl";
            this.Text = "AdminUserControl";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.ComboBox cbRoleID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSearchBy;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearch;
    }
}