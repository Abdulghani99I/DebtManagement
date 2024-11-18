namespace DebtManagement.SetConnection
{
    partial class frmLocalConnection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocalConnection));
            pictureBox1 = new System.Windows.Forms.PictureBox();
            btnTestConnection = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            labStatusConnection = new System.Windows.Forms.Label();
            linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.White;
            pictureBox1.Image = Properties.Resources.wifi_100;
            pictureBox1.Location = new System.Drawing.Point(99, 87);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(171, 89);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnTestConnection
            // 
            btnTestConnection.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnTestConnection.BackColor = System.Drawing.Color.White;
            btnTestConnection.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnTestConnection.Image = (System.Drawing.Image)resources.GetObject("btnTestConnection.Image");
            btnTestConnection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnTestConnection.Location = new System.Drawing.Point(115, 253);
            btnTestConnection.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            btnTestConnection.Name = "btnTestConnection";
            btnTestConnection.Size = new System.Drawing.Size(141, 45);
            btnTestConnection.TabIndex = 5;
            btnTestConnection.Text = "اختبار الاتصال";
            btnTestConnection.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnTestConnection.UseVisualStyleBackColor = false;
            btnTestConnection.Click += btnTestConnection_Click;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(27, 24);
            label1.Name = "label1";
            label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            label1.Size = new System.Drawing.Size(315, 36);
            label1.TabIndex = 13;
            label1.Text = "اختبار الاتصال المحلي بقاعدة البيانات";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labStatusConnection
            // 
            labStatusConnection.Anchor = System.Windows.Forms.AnchorStyles.None;
            labStatusConnection.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labStatusConnection.ForeColor = System.Drawing.Color.FromArgb(0, 192, 0);
            labStatusConnection.Location = new System.Drawing.Point(-1, 191);
            labStatusConnection.Name = "labStatusConnection";
            labStatusConnection.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            labStatusConnection.Size = new System.Drawing.Size(369, 36);
            labStatusConnection.TabIndex = 14;
            labStatusConnection.Text = "الاتصال ناجح";
            labStatusConnection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new System.Drawing.Font("Cairo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            linkLabel1.Location = new System.Drawing.Point(193, 316);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new System.Drawing.Size(164, 24);
            linkLabel1.TabIndex = 15;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "ضبط اعدادات الاتصال الشبكي";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // frmLocalConnection
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(369, 349);
            Controls.Add(linkLabel1);
            Controls.Add(labStatusConnection);
            Controls.Add(label1);
            Controls.Add(btnTestConnection);
            Controls.Add(pictureBox1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLocalConnection";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "اتصال قاعدة البيانات";
            Load += frmLocalConnection_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labStatusConnection;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}