namespace DebtManagement
{
    partial class frmNetworkConnection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNetworkConnection));
            label1 = new System.Windows.Forms.Label();
            txtDatabaseName = new System.Windows.Forms.TextBox();
            panelBottomBorder = new System.Windows.Forms.Panel();
            txtServerName = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txtUsername = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            btnConnection = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(185, 27);
            label1.Name = "label1";
            label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            label1.Size = new System.Drawing.Size(118, 36);
            label1.TabIndex = 12;
            label1.Text = "اسم السيرفر";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDatabaseName
            // 
            txtDatabaseName.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtDatabaseName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtDatabaseName.Font = new System.Drawing.Font("Cairo", 14F);
            txtDatabaseName.Location = new System.Drawing.Point(32, 163);
            txtDatabaseName.Name = "txtDatabaseName";
            txtDatabaseName.Size = new System.Drawing.Size(425, 35);
            txtDatabaseName.TabIndex = 1;
            txtDatabaseName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            txtDatabaseName.Enter += txtDatabaseName_Enter;
            // 
            // panelBottomBorder
            // 
            panelBottomBorder.Anchor = System.Windows.Forms.AnchorStyles.None;
            panelBottomBorder.BackColor = System.Drawing.Color.FromArgb(0, 192, 192);
            panelBottomBorder.Location = new System.Drawing.Point(32, 98);
            panelBottomBorder.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            panelBottomBorder.Name = "panelBottomBorder";
            panelBottomBorder.Size = new System.Drawing.Size(425, 3);
            panelBottomBorder.TabIndex = 15;
            // 
            // txtServerName
            // 
            txtServerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtServerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtServerName.Font = new System.Drawing.Font("Cairo", 14F);
            txtServerName.Location = new System.Drawing.Point(32, 66);
            txtServerName.Name = "txtServerName";
            txtServerName.Size = new System.Drawing.Size(425, 35);
            txtServerName.TabIndex = 0;
            txtServerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            txtServerName.Enter += txtServerName_Enter;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(159, 124);
            label2.Name = "label2";
            label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            label2.Size = new System.Drawing.Size(171, 36);
            label2.TabIndex = 16;
            label2.Text = "اسم قاعدة البيانات";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(174, 221);
            label3.Name = "label3";
            label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            label3.Size = new System.Drawing.Size(141, 36);
            label3.TabIndex = 18;
            label3.Text = "اسم المستخدم";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtUsername.Font = new System.Drawing.Font("Cairo", 14F);
            txtUsername.Location = new System.Drawing.Point(32, 260);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(425, 35);
            txtUsername.TabIndex = 2;
            txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            txtUsername.Enter += txtUsername_Enter;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(188, 318);
            label4.Name = "label4";
            label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            label4.Size = new System.Drawing.Size(113, 36);
            label4.TabIndex = 20;
            label4.Text = "كلمة المرور";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtPassword.Font = new System.Drawing.Font("Cairo", 14F);
            txtPassword.Location = new System.Drawing.Point(32, 357);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(425, 35);
            txtPassword.TabIndex = 3;
            txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            txtPassword.Enter += txtPassword_Enter;
            // 
            // btnConnection
            // 
            btnConnection.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnConnection.BackColor = System.Drawing.Color.White;
            btnConnection.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnConnection.Image = (System.Drawing.Image)resources.GetObject("btnConnection.Image");
            btnConnection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnConnection.Location = new System.Drawing.Point(174, 434);
            btnConnection.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            btnConnection.Name = "btnConnection";
            btnConnection.Size = new System.Drawing.Size(141, 45);
            btnConnection.TabIndex = 4;
            btnConnection.Text = "اتصال     ";
            btnConnection.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnConnection.UseVisualStyleBackColor = false;
            btnConnection.Click += btnSave_Click;
            // 
            // frmSetConnection
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(489, 511);
            Controls.Add(btnConnection);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(panelBottomBorder);
            Controls.Add(txtServerName);
            Controls.Add(txtDatabaseName);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            IconOptions.ShowIcon = false;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmSetConnection";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "إعدادات الاتصال";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDatabaseName;
        private System.Windows.Forms.Panel panelBottomBorder;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnConnection;
    }
}