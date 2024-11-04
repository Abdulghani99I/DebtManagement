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
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labDateTime = new DevExpress.XtraEditors.LabelControl();
            pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureEdit2.Properties).BeginInit();
            SuspendLayout();
            // 
            // labelControl2
            // 
            labelControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            labelControl2.Appearance.Font = new System.Drawing.Font("Cairo", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelControl2.Appearance.ForeColor = System.Drawing.Color.DimGray;
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Appearance.Options.UseForeColor = true;
            labelControl2.Location = new System.Drawing.Point(89, 235);
            labelControl2.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(542, 89);
            labelControl2.TabIndex = 1;
            labelControl2.Text = "اسم الشركة يمكنك تغييرة";
            // 
            // labDateTime
            // 
            labDateTime.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labDateTime.Appearance.Font = new System.Drawing.Font("Cairo SemiBold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labDateTime.Appearance.ForeColor = System.Drawing.Color.DarkGray;
            labDateTime.Appearance.Options.UseFont = true;
            labDateTime.Appearance.Options.UseForeColor = true;
            labDateTime.Location = new System.Drawing.Point(50, 407);
            labDateTime.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            labDateTime.Name = "labDateTime";
            labDateTime.Size = new System.Drawing.Size(189, 75);
            labDateTime.TabIndex = 2;
            labDateTime.Text = "                     ";
            // 
            // pictureEdit2
            // 
            pictureEdit2.Anchor = System.Windows.Forms.AnchorStyles.None;
            pictureEdit2.EditValue = Properties.Resources.financial_32x321;
            pictureEdit2.Location = new System.Drawing.Point(271, 93);
            pictureEdit2.Name = "pictureEdit2";
            pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            pictureEdit2.Size = new System.Drawing.Size(187, 132);
            pictureEdit2.TabIndex = 4;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // ctrlPage_Home
            // 
            Appearance.BackColor = System.Drawing.Color.White;
            Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Appearance.Options.UseBackColor = true;
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 30F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(pictureEdit2);
            Controls.Add(labDateTime);
            Controls.Add(labelControl2);
            Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            Name = "ctrlPage_Home";
            Size = new System.Drawing.Size(738, 518);
            ((System.ComponentModel.ISupportInitialize)pictureEdit2.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labDateTime;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private System.Windows.Forms.Timer timer1;
    }
}
