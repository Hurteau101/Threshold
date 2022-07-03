namespace Perimeter_Threshold
{
    partial class Changelog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Changelog));
            this.rchChangeLog = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rchChangeLog
            // 
            this.rchChangeLog.Location = new System.Drawing.Point(13, 13);
            this.rchChangeLog.Name = "rchChangeLog";
            this.rchChangeLog.ReadOnly = true;
            this.rchChangeLog.Size = new System.Drawing.Size(409, 318);
            this.rchChangeLog.TabIndex = 0;
            this.rchChangeLog.Text = "";
            // 
            // Changelog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(112)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(434, 343);
            this.Controls.Add(this.rchChangeLog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(450, 382);
            this.Name = "Changelog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Changelog_FormClosing);
            this.Load += new System.EventHandler(this.Changelog_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.RichTextBox rchChangeLog;
    }
}