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
            this.groupSource = new System.Windows.Forms.GroupBox();
            this.listSource = new System.Windows.Forms.ListBox();
            this.labelSource = new System.Windows.Forms.Label();
            this.btnBrowseSource = new System.Windows.Forms.Button();
            this.groupDestintation = new System.Windows.Forms.GroupBox();
            this.listDest = new System.Windows.Forms.ListBox();
            this.labelDest = new System.Windows.Forms.Label();
            this.btnBrowseDest = new System.Windows.Forms.Button();
            this.groupBackup = new System.Windows.Forms.GroupBox();
            this.listBackup = new System.Windows.Forms.ListBox();
            this.labelBackup = new System.Windows.Forms.Label();
            this.btnBrowseBackup = new System.Windows.Forms.Button();
            this.btnOperate = new System.Windows.Forms.Button();
            this.textLog = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupSource.SuspendLayout();
            this.groupDestintation.SuspendLayout();
            this.groupBackup.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupSource
            // 
            this.groupSource.Controls.Add(this.listSource);
            this.groupSource.Controls.Add(this.labelSource);
            this.groupSource.Controls.Add(this.btnBrowseSource);
            this.groupSource.Location = new System.Drawing.Point(13, 13);
            this.groupSource.Name = "groupSource";
            this.groupSource.Size = new System.Drawing.Size(600, 250);
            this.groupSource.TabIndex = 0;
            this.groupSource.TabStop = false;
            this.groupSource.Text = "Source";
            // 
            // listSource
            // 
            this.listSource.FormattingEnabled = true;
            this.listSource.ItemHeight = 16;
            this.listSource.Location = new System.Drawing.Point(7, 22);
            this.listSource.Name = "listSource";
            this.listSource.Size = new System.Drawing.Size(580, 180);
            this.listSource.TabIndex = 5;
            // 
            // labelSource
            // 
            this.labelSource.AutoSize = true;
            this.labelSource.Location = new System.Drawing.Point(6, 227);
            this.labelSource.Name = "labelSource";
            this.labelSource.Size = new System.Drawing.Size(0, 17);
            this.labelSource.TabIndex = 4;
            // 
            // btnBrowseSource
            // 
            this.btnBrowseSource.Location = new System.Drawing.Point(487, 204);
            this.btnBrowseSource.Name = "btnBrowseSource";
            this.btnBrowseSource.Size = new System.Drawing.Size(100, 40);
            this.btnBrowseSource.TabIndex = 2;
            this.btnBrowseSource.Text = "Browse...";
            this.btnBrowseSource.UseVisualStyleBackColor = true;
            this.btnBrowseSource.Click += new System.EventHandler(this.btnBrowseSource_Click);
            // 
            // groupDestintation
            // 
            this.groupDestintation.Controls.Add(this.listDest);
            this.groupDestintation.Controls.Add(this.labelDest);
            this.groupDestintation.Controls.Add(this.btnBrowseDest);
            this.groupDestintation.Location = new System.Drawing.Point(619, 13);
            this.groupDestintation.Name = "groupDestintation";
            this.groupDestintation.Size = new System.Drawing.Size(600, 250);
            this.groupDestintation.TabIndex = 1;
            this.groupDestintation.TabStop = false;
            this.groupDestintation.Text = "Destination";
            // 
            // listDest
            // 
            this.listDest.FormattingEnabled = true;
            this.listDest.ItemHeight = 16;
            this.listDest.Location = new System.Drawing.Point(6, 22);
            this.listDest.Name = "listDest";
            this.listDest.Size = new System.Drawing.Size(580, 180);
            this.listDest.TabIndex = 6;
            // 
            // labelDest
            // 
            this.labelDest.AutoSize = true;
            this.labelDest.Location = new System.Drawing.Point(6, 227);
            this.labelDest.Name = "labelDest";
            this.labelDest.Size = new System.Drawing.Size(0, 17);
            this.labelDest.TabIndex = 5;
            // 
            // btnBrowseDest
            // 
            this.btnBrowseDest.Location = new System.Drawing.Point(486, 204);
            this.btnBrowseDest.Name = "btnBrowseDest";
            this.btnBrowseDest.Size = new System.Drawing.Size(100, 40);
            this.btnBrowseDest.TabIndex = 3;
            this.btnBrowseDest.Text = "Browse...";
            this.btnBrowseDest.UseVisualStyleBackColor = true;
            this.btnBrowseDest.Click += new System.EventHandler(this.btnBrowseDest_Click);
            // 
            // groupBackup
            // 
            this.groupBackup.Controls.Add(this.listBackup);
            this.groupBackup.Controls.Add(this.labelBackup);
            this.groupBackup.Controls.Add(this.btnBrowseBackup);
            this.groupBackup.Location = new System.Drawing.Point(13, 269);
            this.groupBackup.Name = "groupBackup";
            this.groupBackup.Size = new System.Drawing.Size(600, 250);
            this.groupBackup.TabIndex = 2;
            this.groupBackup.TabStop = false;
            this.groupBackup.Text = "Backup";
            // 
            // listBackup
            // 
            this.listBackup.FormattingEnabled = true;
            this.listBackup.ItemHeight = 16;
            this.listBackup.Location = new System.Drawing.Point(7, 22);
            this.listBackup.Name = "listBackup";
            this.listBackup.Size = new System.Drawing.Size(580, 180);
            this.listBackup.TabIndex = 5;
            // 
            // labelBackup
            // 
            this.labelBackup.AutoSize = true;
            this.labelBackup.Location = new System.Drawing.Point(6, 227);
            this.labelBackup.Name = "labelBackup";
            this.labelBackup.Size = new System.Drawing.Size(0, 17);
            this.labelBackup.TabIndex = 4;
            // 
            // btnBrowseBackup
            // 
            this.btnBrowseBackup.Location = new System.Drawing.Point(487, 204);
            this.btnBrowseBackup.Name = "btnBrowseBackup";
            this.btnBrowseBackup.Size = new System.Drawing.Size(100, 40);
            this.btnBrowseBackup.TabIndex = 2;
            this.btnBrowseBackup.Text = "Browse...";
            this.btnBrowseBackup.UseVisualStyleBackColor = true;
            this.btnBrowseBackup.Click += new System.EventHandler(this.btnBrowseBackup_Click);
            // 
            // btnOperate
            // 
            this.btnOperate.Enabled = false;
            this.btnOperate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperate.Location = new System.Drawing.Point(1215, 409);
            this.btnOperate.Name = "btnOperate";
            this.btnOperate.Size = new System.Drawing.Size(128, 113);
            this.btnOperate.TabIndex = 3;
            this.btnOperate.Text = "Do";
            this.btnOperate.UseVisualStyleBackColor = true;
            this.btnOperate.Click += new System.EventHandler(this.btnOperate_Click);
            // 
            // textLog
            // 
            this.textLog.BackColor = System.Drawing.SystemColors.Info;
            this.textLog.Location = new System.Drawing.Point(628, 409);
            this.textLog.Name = "textLog";
            this.textLog.Size = new System.Drawing.Size(565, 110);
            this.textLog.TabIndex = 4;
            this.textLog.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(906, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "SafeCopy v1 by quigela";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 534);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textLog);
            this.Controls.Add(this.btnOperate);
            this.Controls.Add(this.groupBackup);
            this.Controls.Add(this.groupDestintation);
            this.Controls.Add(this.groupSource);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupSource.ResumeLayout(false);
            this.groupSource.PerformLayout();
            this.groupDestintation.ResumeLayout(false);
            this.groupDestintation.PerformLayout();
            this.groupBackup.ResumeLayout(false);
            this.groupBackup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupSource;
        private System.Windows.Forms.GroupBox groupDestintation;
        private System.Windows.Forms.Label labelSource;
        private System.Windows.Forms.Button btnBrowseSource;
        private System.Windows.Forms.Label labelDest;
        private System.Windows.Forms.Button btnBrowseDest;
        private System.Windows.Forms.ListBox listSource;
        private System.Windows.Forms.ListBox listDest;
        private System.Windows.Forms.GroupBox groupBackup;
        private System.Windows.Forms.ListBox listBackup;
        private System.Windows.Forms.Label labelBackup;
        private System.Windows.Forms.Button btnBrowseBackup;
        private System.Windows.Forms.Button btnOperate;
        private System.Windows.Forms.RichTextBox textLog;
        private System.Windows.Forms.Label label1;
    }
}

