namespace SafeCopy
{
    partial class Form1
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
            this.GroupSource = new System.Windows.Forms.GroupBox();
            this.ListSource = new System.Windows.Forms.ListBox();
            this.LabelSource = new System.Windows.Forms.Label();
            this.BtnBrowseSource = new System.Windows.Forms.Button();
            this.GroupDestintation = new System.Windows.Forms.GroupBox();
            this.ListDest = new System.Windows.Forms.ListBox();
            this.LabelDest = new System.Windows.Forms.Label();
            this.BtnBrowseDest = new System.Windows.Forms.Button();
            this.GroupBackup = new System.Windows.Forms.GroupBox();
            this.ListBackup = new System.Windows.Forms.ListBox();
            this.LabelBackup = new System.Windows.Forms.Label();
            this.BtnBrowseBackup = new System.Windows.Forms.Button();
            this.BtnOperate = new System.Windows.Forms.Button();
            this.TextLog = new System.Windows.Forms.RichTextBox();
            this.Shoutout = new System.Windows.Forms.Label();
            this.GroupSource.SuspendLayout();
            this.GroupDestintation.SuspendLayout();
            this.GroupBackup.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupSource
            // 
            this.GroupSource.Controls.Add(this.ListSource);
            this.GroupSource.Controls.Add(this.LabelSource);
            this.GroupSource.Controls.Add(this.BtnBrowseSource);
            this.GroupSource.Location = new System.Drawing.Point(13, 13);
            this.GroupSource.Name = "GroupSource";
            this.GroupSource.Size = new System.Drawing.Size(600, 250);
            this.GroupSource.TabIndex = 0;
            this.GroupSource.TabStop = false;
            this.GroupSource.Text = "Source";
            // 
            // ListSource
            // 
            this.ListSource.FormattingEnabled = true;
            this.ListSource.ItemHeight = 16;
            this.ListSource.Location = new System.Drawing.Point(7, 22);
            this.ListSource.Name = "ListSource";
            this.ListSource.Size = new System.Drawing.Size(580, 180);
            this.ListSource.TabIndex = 5;
            // 
            // LabelSource
            // 
            this.LabelSource.AutoSize = true;
            this.LabelSource.Location = new System.Drawing.Point(6, 227);
            this.LabelSource.Name = "LabelSource";
            this.LabelSource.Size = new System.Drawing.Size(0, 17);
            this.LabelSource.TabIndex = 4;
            // 
            // BtnBrowseSource
            // 
            this.BtnBrowseSource.Location = new System.Drawing.Point(487, 204);
            this.BtnBrowseSource.Name = "BtnBrowseSource";
            this.BtnBrowseSource.Size = new System.Drawing.Size(100, 40);
            this.BtnBrowseSource.TabIndex = 2;
            this.BtnBrowseSource.Text = "Browse...";
            this.BtnBrowseSource.UseVisualStyleBackColor = true;
            this.BtnBrowseSource.Click += new System.EventHandler(this.BtnBrowseSource_Click);
            // 
            // GroupDestintation
            // 
            this.GroupDestintation.Controls.Add(this.ListDest);
            this.GroupDestintation.Controls.Add(this.LabelDest);
            this.GroupDestintation.Controls.Add(this.BtnBrowseDest);
            this.GroupDestintation.Location = new System.Drawing.Point(619, 13);
            this.GroupDestintation.Name = "GroupDestintation";
            this.GroupDestintation.Size = new System.Drawing.Size(600, 250);
            this.GroupDestintation.TabIndex = 1;
            this.GroupDestintation.TabStop = false;
            this.GroupDestintation.Text = "Destination";
            // 
            // ListDest
            // 
            this.ListDest.FormattingEnabled = true;
            this.ListDest.ItemHeight = 16;
            this.ListDest.Location = new System.Drawing.Point(6, 22);
            this.ListDest.Name = "ListDest";
            this.ListDest.Size = new System.Drawing.Size(580, 180);
            this.ListDest.TabIndex = 6;
            // 
            // LabelDest
            // 
            this.LabelDest.AutoSize = true;
            this.LabelDest.Location = new System.Drawing.Point(6, 227);
            this.LabelDest.Name = "LabelDest";
            this.LabelDest.Size = new System.Drawing.Size(0, 17);
            this.LabelDest.TabIndex = 5;
            // 
            // BtnBrowseDest
            // 
            this.BtnBrowseDest.Location = new System.Drawing.Point(486, 204);
            this.BtnBrowseDest.Name = "BtnBrowseDest";
            this.BtnBrowseDest.Size = new System.Drawing.Size(100, 40);
            this.BtnBrowseDest.TabIndex = 3;
            this.BtnBrowseDest.Text = "Browse...";
            this.BtnBrowseDest.UseVisualStyleBackColor = true;
            this.BtnBrowseDest.Click += new System.EventHandler(this.BtnBrowseDest_Click);
            // 
            // GroupBackup
            // 
            this.GroupBackup.Controls.Add(this.ListBackup);
            this.GroupBackup.Controls.Add(this.LabelBackup);
            this.GroupBackup.Controls.Add(this.BtnBrowseBackup);
            this.GroupBackup.Location = new System.Drawing.Point(13, 269);
            this.GroupBackup.Name = "GroupBackup";
            this.GroupBackup.Size = new System.Drawing.Size(600, 250);
            this.GroupBackup.TabIndex = 2;
            this.GroupBackup.TabStop = false;
            this.GroupBackup.Text = "Backup";
            // 
            // ListBackup
            // 
            this.ListBackup.FormattingEnabled = true;
            this.ListBackup.ItemHeight = 16;
            this.ListBackup.Location = new System.Drawing.Point(7, 22);
            this.ListBackup.Name = "ListBackup";
            this.ListBackup.Size = new System.Drawing.Size(580, 180);
            this.ListBackup.TabIndex = 5;
            // 
            // LabelBackup
            // 
            this.LabelBackup.AutoSize = true;
            this.LabelBackup.Location = new System.Drawing.Point(6, 227);
            this.LabelBackup.Name = "LabelBackup";
            this.LabelBackup.Size = new System.Drawing.Size(0, 17);
            this.LabelBackup.TabIndex = 4;
            // 
            // BtnBrowseBackup
            // 
            this.BtnBrowseBackup.Location = new System.Drawing.Point(487, 204);
            this.BtnBrowseBackup.Name = "BtnBrowseBackup";
            this.BtnBrowseBackup.Size = new System.Drawing.Size(100, 40);
            this.BtnBrowseBackup.TabIndex = 2;
            this.BtnBrowseBackup.Text = "Browse...";
            this.BtnBrowseBackup.UseVisualStyleBackColor = true;
            this.BtnBrowseBackup.Click += new System.EventHandler(this.BtnBrowseBackup_Click);
            // 
            // BtnOperate
            // 
            this.BtnOperate.Enabled = false;
            this.BtnOperate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOperate.Location = new System.Drawing.Point(1215, 409);
            this.BtnOperate.Name = "BtnOperate";
            this.BtnOperate.Size = new System.Drawing.Size(128, 113);
            this.BtnOperate.TabIndex = 3;
            this.BtnOperate.Text = "Do";
            this.BtnOperate.UseVisualStyleBackColor = true;
            this.BtnOperate.Click += new System.EventHandler(this.BtnOperate_Click);
            // 
            // TextLog
            // 
            this.TextLog.BackColor = System.Drawing.SystemColors.Info;
            this.TextLog.Location = new System.Drawing.Point(628, 409);
            this.TextLog.Name = "TextLog";
            this.TextLog.Size = new System.Drawing.Size(565, 110);
            this.TextLog.TabIndex = 4;
            this.TextLog.Text = "";
            // 
            // Shoutout
            // 
            this.Shoutout.AutoSize = true;
            this.Shoutout.Location = new System.Drawing.Point(906, 330);
            this.Shoutout.Name = "Shoutout";
            this.Shoutout.Size = new System.Drawing.Size(157, 17);
            this.Shoutout.TabIndex = 5;
            this.Shoutout.Text = "SafeCopy v1 by quigela";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 534);
            this.Controls.Add(this.Shoutout);
            this.Controls.Add(this.TextLog);
            this.Controls.Add(this.BtnOperate);
            this.Controls.Add(this.GroupBackup);
            this.Controls.Add(this.GroupDestintation);
            this.Controls.Add(this.GroupSource);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GroupSource.ResumeLayout(false);
            this.GroupSource.PerformLayout();
            this.GroupDestintation.ResumeLayout(false);
            this.GroupDestintation.PerformLayout();
            this.GroupBackup.ResumeLayout(false);
            this.GroupBackup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupSource;
        private System.Windows.Forms.GroupBox GroupDestintation;
        private System.Windows.Forms.Label LabelSource;
        private System.Windows.Forms.Button BtnBrowseSource;
        private System.Windows.Forms.Label LabelDest;
        private System.Windows.Forms.Button BtnBrowseDest;
        private System.Windows.Forms.ListBox ListSource;
        private System.Windows.Forms.ListBox ListDest;
        private System.Windows.Forms.GroupBox GroupBackup;
        private System.Windows.Forms.ListBox ListBackup;
        private System.Windows.Forms.Label LabelBackup;
        private System.Windows.Forms.Button BtnBrowseBackup;
        private System.Windows.Forms.Button BtnOperate;
        private System.Windows.Forms.RichTextBox TextLog;
        private System.Windows.Forms.Label Shoutout;
    }
}

