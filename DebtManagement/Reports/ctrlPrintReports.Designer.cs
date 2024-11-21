namespace DebtManagement
{
    partial class ctrlPrintReports
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
            btnPrintReportSuppliers = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            btnPrintReportClients = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnPrintReportSuppliers
            // 
            btnPrintReportSuppliers.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnPrintReportSuppliers.BackColor = System.Drawing.Color.LightGray;
            btnPrintReportSuppliers.FlatAppearance.BorderSize = 0;
            btnPrintReportSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPrintReportSuppliers.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnPrintReportSuppliers.ForeColor = System.Drawing.Color.Black;
            btnPrintReportSuppliers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnPrintReportSuppliers.Location = new System.Drawing.Point(374, 251);
            btnPrintReportSuppliers.Name = "btnPrintReportSuppliers";
            btnPrintReportSuppliers.Size = new System.Drawing.Size(298, 62);
            btnPrintReportSuppliers.TabIndex = 0;
            btnPrintReportSuppliers.Text = "طباعة تقرير الموردين";
            btnPrintReportSuppliers.UseVisualStyleBackColor = false;
            btnPrintReportSuppliers.Click += btnPrintReportSuppliers_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            pictureBox1.BackgroundImage = Properties.Resources.summary_32x32;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox1.Location = new System.Drawing.Point(259, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(144, 103);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Cairo", 22F, System.Drawing.FontStyle.Bold);
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(237, 121);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(207, 56);
            label1.TabIndex = 2;
            label1.Text = "طباعة التقارير";
            // 
            // btnPrintReportClients
            // 
            btnPrintReportClients.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnPrintReportClients.BackColor = System.Drawing.Color.LightGray;
            btnPrintReportClients.FlatAppearance.BorderSize = 0;
            btnPrintReportClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPrintReportClients.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnPrintReportClients.ForeColor = System.Drawing.Color.Black;
            btnPrintReportClients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnPrintReportClients.Location = new System.Drawing.Point(23, 251);
            btnPrintReportClients.Name = "btnPrintReportClients";
            btnPrintReportClients.Size = new System.Drawing.Size(298, 62);
            btnPrintReportClients.TabIndex = 3;
            btnPrintReportClients.Text = "طباعة تقرير العملاء";
            btnPrintReportClients.UseVisualStyleBackColor = false;
            btnPrintReportClients.Click += btnPrintReportClients_Click;
            // 
            // ctrlPrintReports
            // 
            Appearance.BackColor = System.Drawing.Color.White;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(btnPrintReportClients);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnPrintReportSuppliers);
            Name = "ctrlPrintReports";
            Size = new System.Drawing.Size(698, 475);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnPrintReportSuppliers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrintReportClients;
    }
}
