namespace DebtManagement.User
{
    partial class CreateNewUser
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNewUser));
            btnAddAndLogin = new System.Windows.Forms.Button();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            label6 = new System.Windows.Forms.Label();
            txtUsername = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            txtConfirmPassword = new System.Windows.Forms.TextBox();
            panelBottomBorder = new System.Windows.Forms.Panel();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            txtFullName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnAddAndLogin
            // 
            btnAddAndLogin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            btnAddAndLogin.BackColor = System.Drawing.Color.White;
            btnAddAndLogin.FlatAppearance.BorderSize = 2;
            btnAddAndLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            btnAddAndLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            btnAddAndLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddAndLogin.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnAddAndLogin.ForeColor = System.Drawing.Color.Black;
            btnAddAndLogin.Image = (System.Drawing.Image)resources.GetObject("btnAddAndLogin.Image");
            btnAddAndLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnAddAndLogin.Location = new System.Drawing.Point(132, 370);
            btnAddAndLogin.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            btnAddAndLogin.Name = "btnAddAndLogin";
            btnAddAndLogin.Size = new System.Drawing.Size(250, 47);
            btnAddAndLogin.TabIndex = 4;
            btnAddAndLogin.Text = "اضافة + تسجيل الدخول";
            btnAddAndLogin.UseVisualStyleBackColor = false;
            btnAddAndLogin.Click += btnAddAndLogin_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label6
            // 
            label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.ForeColor = System.Drawing.Color.Black;
            label6.Location = new System.Drawing.Point(181, 83);
            label6.Name = "label6";
            label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            label6.Size = new System.Drawing.Size(141, 36);
            label6.TabIndex = 46;
            label6.Text = "اسم المستخدم";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtUsername.Font = new System.Drawing.Font("Cairo", 15F);
            txtUsername.Location = new System.Drawing.Point(49, 122);
            txtUsername.MaxLength = 20;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(422, 38);
            txtUsername.TabIndex = 1;
            txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            txtUsername.Enter += txtUsername_Enter;
            txtUsername.Validated += txtUsername_Validated;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(177, 246);
            label1.Name = "label1";
            label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            label1.Size = new System.Drawing.Size(148, 36);
            label1.TabIndex = 45;
            label1.Text = "تاكيد كلمة السر";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtConfirmPassword.Font = new System.Drawing.Font("Cairo", 15F);
            txtConfirmPassword.Location = new System.Drawing.Point(49, 285);
            txtConfirmPassword.MaxLength = 20;
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new System.Drawing.Size(422, 38);
            txtConfirmPassword.TabIndex = 3;
            txtConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            txtConfirmPassword.Enter += txtConfirmPassword_Enter;
            txtConfirmPassword.Validated += txtConfirmPassword_Validated;
            // 
            // panelBottomBorder
            // 
            panelBottomBorder.Anchor = System.Windows.Forms.AnchorStyles.None;
            panelBottomBorder.BackColor = System.Drawing.Color.FromArgb(0, 192, 192);
            panelBottomBorder.Location = new System.Drawing.Point(49, 77);
            panelBottomBorder.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            panelBottomBorder.Name = "panelBottomBorder";
            panelBottomBorder.Size = new System.Drawing.Size(422, 3);
            panelBottomBorder.TabIndex = 44;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.Black;
            label3.Location = new System.Drawing.Point(201, 163);
            label3.Name = "label3";
            label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            label3.Size = new System.Drawing.Size(100, 36);
            label3.TabIndex = 42;
            label3.Text = "كلمة السر";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(188, 0);
            label2.Name = "label2";
            label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            label2.Size = new System.Drawing.Size(126, 36);
            label2.TabIndex = 43;
            label2.Text = "الاسم الكامل";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtPassword.Font = new System.Drawing.Font("Cairo", 15F);
            txtPassword.Location = new System.Drawing.Point(49, 205);
            txtPassword.MaxLength = 20;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(422, 38);
            txtPassword.TabIndex = 2;
            txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Validated += txtPassword_Validated;
            // 
            // txtFullName
            // 
            txtFullName.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtFullName.Font = new System.Drawing.Font("Cairo", 15F);
            txtFullName.Location = new System.Drawing.Point(49, 39);
            txtFullName.MaxLength = 30;
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new System.Drawing.Size(422, 38);
            txtFullName.TabIndex = 0;
            txtFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            txtFullName.Enter += txtFullName_Enter;
            txtFullName.Validated += txtFullNameValidated;
            // 
            // CreateNewUser
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(519, 455);
            Controls.Add(label6);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Controls.Add(txtConfirmPassword);
            Controls.Add(panelBottomBorder);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(txtFullName);
            Controls.Add(btnAddAndLogin);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            IconOptions.ShowIcon = false;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreateNewUser";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "مستخدم جديد";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnAddAndLogin;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Panel panelBottomBorder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtFullName;
    }
}