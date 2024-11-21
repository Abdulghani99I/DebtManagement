namespace DebtManagement
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            txtUserName = new System.Windows.Forms.TextBox();
            btnLogin = new System.Windows.Forms.Button();
            panelBottomBorder = new System.Windows.Forms.Panel();
            checkBoxRememberMe = new System.Windows.Forms.CheckBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(429, 154);
            label3.Name = "label3";
            label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            label3.Size = new System.Drawing.Size(100, 36);
            label3.TabIndex = 19;
            label3.Text = "كلمة السر";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(409, 32);
            label2.Name = "label2";
            label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            label2.Size = new System.Drawing.Size(141, 36);
            label2.TabIndex = 20;
            label2.Text = "اسم المستخدم";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtPassword.Font = new System.Drawing.Font("Cairo", 15F);
            txtPassword.Location = new System.Drawing.Point(257, 193);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(422, 38);
            txtPassword.TabIndex = 1;
            txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            txtPassword.Enter += txtPassword_Enter;
            // 
            // txtUserName
            // 
            txtUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtUserName.Font = new System.Drawing.Font("Cairo", 15F);
            txtUserName.Location = new System.Drawing.Point(257, 71);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new System.Drawing.Size(422, 38);
            txtUserName.TabIndex = 0;
            txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            txtUserName.Enter += txtUserName_Enter;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            btnLogin.BackColor = System.Drawing.Color.White;
            btnLogin.FlatAppearance.BorderSize = 2;
            btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogin.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnLogin.ForeColor = System.Drawing.Color.Black;
            btnLogin.Image = (System.Drawing.Image)resources.GetObject("btnLogin.Image");
            btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnLogin.Location = new System.Drawing.Point(370, 320);
            btnLogin.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(197, 47);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "تسجيل الدخول";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // panelBottomBorder
            // 
            panelBottomBorder.Anchor = System.Windows.Forms.AnchorStyles.None;
            panelBottomBorder.BackColor = System.Drawing.Color.FromArgb(0, 192, 192);
            panelBottomBorder.Location = new System.Drawing.Point(257, 106);
            panelBottomBorder.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            panelBottomBorder.Name = "panelBottomBorder";
            panelBottomBorder.Size = new System.Drawing.Size(422, 3);
            panelBottomBorder.TabIndex = 22;
            // 
            // checkBoxRememberMe
            // 
            checkBoxRememberMe.Anchor = System.Windows.Forms.AnchorStyles.None;
            checkBoxRememberMe.AutoSize = true;
            checkBoxRememberMe.Font = new System.Drawing.Font("Cairo", 12F);
            checkBoxRememberMe.Location = new System.Drawing.Point(601, 237);
            checkBoxRememberMe.Name = "checkBoxRememberMe";
            checkBoxRememberMe.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            checkBoxRememberMe.Size = new System.Drawing.Size(78, 34);
            checkBoxRememberMe.TabIndex = 2;
            checkBoxRememberMe.Text = "تذكرني";
            checkBoxRememberMe.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(232, 455);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(721, 455);
            Controls.Add(pictureBox1);
            Controls.Add(checkBoxRememberMe);
            Controls.Add(panelBottomBorder);
            Controls.Add(btnLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            DoubleBuffered = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "تسجيل دخول";
            FormClosed += frmLogin_FormClosed;
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panelBottomBorder;
        private System.Windows.Forms.CheckBox checkBoxRememberMe;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}