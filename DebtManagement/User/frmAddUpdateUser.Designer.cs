namespace DebtManagement.User
{
    partial class frmAddUpdateUser
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
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            txtUserName = new System.Windows.Forms.TextBox();
            panelBottomBorder = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            txtFullName = new System.Windows.Forms.TextBox();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            btnSave = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            cmbPermissionUser = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbPermissionUser.Properties).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(198, 195);
            label3.Name = "label3";
            label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            label3.Size = new System.Drawing.Size(100, 36);
            label3.TabIndex = 15;
            label3.Text = "كلمة السر";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(176, 98);
            label2.Name = "label2";
            label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            label2.Size = new System.Drawing.Size(141, 36);
            label2.TabIndex = 16;
            label2.Text = "اسم المستخدم";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtPassword.Font = new System.Drawing.Font("Cairo", 14F);
            txtPassword.Location = new System.Drawing.Point(33, 234);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(422, 35);
            txtPassword.TabIndex = 2;
            txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Validated += txtPassword_Validated;
            // 
            // txtUserName
            // 
            txtUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtUserName.Font = new System.Drawing.Font("Cairo", 14F);
            txtUserName.Location = new System.Drawing.Point(33, 137);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new System.Drawing.Size(422, 35);
            txtUserName.TabIndex = 1;
            txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            txtUserName.Enter += txtUserName_Enter;
            txtUserName.Validated += txtUserName_Validated;
            // 
            // panelBottomBorder
            // 
            panelBottomBorder.Anchor = System.Windows.Forms.AnchorStyles.None;
            panelBottomBorder.BackColor = System.Drawing.Color.FromArgb(0, 192, 192);
            panelBottomBorder.Location = new System.Drawing.Point(33, 72);
            panelBottomBorder.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            panelBottomBorder.Name = "panelBottomBorder";
            panelBottomBorder.Size = new System.Drawing.Size(422, 3);
            panelBottomBorder.TabIndex = 12;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(191, 1);
            label1.Name = "label1";
            label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            label1.Size = new System.Drawing.Size(126, 36);
            label1.TabIndex = 11;
            label1.Text = "الاسم الكامل";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFullName
            // 
            txtFullName.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtFullName.Font = new System.Drawing.Font("Cairo", 14F);
            txtFullName.Location = new System.Drawing.Point(33, 40);
            txtFullName.Name = "txtFullName";
            txtFullName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txtFullName.Size = new System.Drawing.Size(422, 35);
            txtFullName.TabIndex = 0;
            txtFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            txtFullName.Enter += txtFullName_Enter;
            txtFullName.Validated += txtFullName_Validated;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnSave
            // 
            btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            btnSave.BackColor = System.Drawing.Color.White;
            btnSave.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnSave.Image = Properties.Resources.saveto_32x32;
            btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnSave.Location = new System.Drawing.Point(156, 410);
            btnSave.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(177, 54);
            btnSave.TabIndex = 4;
            btnSave.Text = "اضافة";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(164, 292);
            label4.Name = "label4";
            label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            label4.Size = new System.Drawing.Size(166, 36);
            label4.TabIndex = 15;
            label4.Text = "صلاحية المستخدم";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbPermissionUser
            // 
            cmbPermissionUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            cmbPermissionUser.Location = new System.Drawing.Point(33, 331);
            cmbPermissionUser.Name = "cmbPermissionUser";
            cmbPermissionUser.Properties.Appearance.Font = new System.Drawing.Font("Cairo", 14F);
            cmbPermissionUser.Properties.Appearance.Options.UseFont = true;
            cmbPermissionUser.Properties.Appearance.Options.UseTextOptions = true;
            cmbPermissionUser.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            cmbPermissionUser.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Cairo", 14F);
            cmbPermissionUser.Properties.AppearanceDropDown.Options.UseFont = true;
            cmbPermissionUser.Properties.AppearanceDropDown.Options.UseTextOptions = true;
            cmbPermissionUser.Properties.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            cmbPermissionUser.Properties.AppearanceFocused.Font = new System.Drawing.Font("Cairo", 14F);
            cmbPermissionUser.Properties.AppearanceFocused.Options.UseFont = true;
            cmbPermissionUser.Properties.AppearanceFocused.Options.UseTextOptions = true;
            cmbPermissionUser.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            cmbPermissionUser.Properties.AppearanceItemHighlight.Font = new System.Drawing.Font("Cairo", 14F);
            cmbPermissionUser.Properties.AppearanceItemHighlight.Options.UseFont = true;
            cmbPermissionUser.Properties.AppearanceItemHighlight.Options.UseTextOptions = true;
            cmbPermissionUser.Properties.AppearanceItemHighlight.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            cmbPermissionUser.Properties.AppearanceItemSelected.Font = new System.Drawing.Font("Cairo", 14F);
            cmbPermissionUser.Properties.AppearanceItemSelected.Options.UseFont = true;
            cmbPermissionUser.Properties.AppearanceItemSelected.Options.UseTextOptions = true;
            cmbPermissionUser.Properties.AppearanceItemSelected.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            cmbPermissionUser.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            cmbPermissionUser.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cmbPermissionUser.Properties.Items.AddRange(new object[] { "مدير", "مستخدم" });
            cmbPermissionUser.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            cmbPermissionUser.Size = new System.Drawing.Size(422, 40);
            cmbPermissionUser.TabIndex = 3;
            cmbPermissionUser.Enter += cmbPermissionUser_Enter;
            cmbPermissionUser.Validated += cmbPermissionUser_Validated;
            // 
            // frmAddUpdateUser
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(489, 483);
            Controls.Add(cmbPermissionUser);
            Controls.Add(btnSave);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(panelBottomBorder);
            Controls.Add(label1);
            Controls.Add(txtFullName);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddUpdateUser";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "اضافة مستخدم";
            Load += frmAddUpdateUser_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbPermissionUser.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Panel panelBottomBorder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.ComboBoxEdit cmbPermissionUser;
    }
}