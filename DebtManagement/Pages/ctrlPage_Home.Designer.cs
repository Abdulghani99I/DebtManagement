namespace DebtManagement.Pages
{
    partial class ctrlPage_Home
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            labCompanyName = new DevExpress.XtraEditors.LabelControl();
            labDateTime = new DevExpress.XtraEditors.LabelControl();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBoxCompanyPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCompanyPicture).BeginInit();
            SuspendLayout();
            // 
            // labCompanyName
            // 
            labCompanyName.Anchor = System.Windows.Forms.AnchorStyles.None;
            labCompanyName.Appearance.Font = new System.Drawing.Font("Cairo", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labCompanyName.Appearance.ForeColor = System.Drawing.Color.DimGray;
            labCompanyName.Appearance.Options.UseFont = true;
            labCompanyName.Appearance.Options.UseForeColor = true;
            labCompanyName.Appearance.Options.UseTextOptions = true;
            labCompanyName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            labCompanyName.AutoEllipsis = true;
            labCompanyName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labCompanyName.Location = new System.Drawing.Point(42, 259);
            labCompanyName.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            labCompanyName.Name = "labCompanyName";
            labCompanyName.Size = new System.Drawing.Size(655, 66);
            labCompanyName.TabIndex = 1;
            labCompanyName.Text = "اسم الشركة يمكنك تغييرة";
            // 
            // labDateTime
            // 
            labDateTime.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labDateTime.Appearance.Font = new System.Drawing.Font("Cairo", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labDateTime.Appearance.ForeColor = System.Drawing.Color.DarkGray;
            labDateTime.Appearance.Options.UseFont = true;
            labDateTime.Appearance.Options.UseForeColor = true;
            labDateTime.Location = new System.Drawing.Point(51, 427);
            labDateTime.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            labDateTime.Name = "labDateTime";
            labDateTime.Size = new System.Drawing.Size(147, 60);
            labDateTime.TabIndex = 2;
            labDateTime.Text = "                     ";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBoxCompanyPicture
            // 
            pictureBoxCompanyPicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            pictureBoxCompanyPicture.Location = new System.Drawing.Point(277, 71);
            pictureBoxCompanyPicture.Name = "pictureBoxCompanyPicture";
            pictureBoxCompanyPicture.Size = new System.Drawing.Size(184, 178);
            pictureBoxCompanyPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBoxCompanyPicture.TabIndex = 3;
            pictureBoxCompanyPicture.TabStop = false;
            // 
            // ctrlPage_Home
            // 
            Appearance.BackColor = System.Drawing.Color.White;
            Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Appearance.Options.UseBackColor = true;
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 30F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(pictureBoxCompanyPicture);
            Controls.Add(labDateTime);
            Controls.Add(labCompanyName);
            Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            Name = "ctrlPage_Home";
            Size = new System.Drawing.Size(738, 518);
            ((System.ComponentModel.ISupportInitialize)pictureBoxCompanyPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labCompanyName;
        private DevExpress.XtraEditors.LabelControl labDateTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBoxCompanyPicture;
    }
}
