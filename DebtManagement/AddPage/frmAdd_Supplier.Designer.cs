﻿namespace DebtManagement.AddPAage
{
    partial class frmAdd_Supplier
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
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            panelBorderBottom = new System.Windows.Forms.Panel();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            panel1 = new System.Windows.Forms.Panel();
            btnAddAndClose = new DevExpress.XtraEditors.SimpleButton();
            btnAdd = new DevExpress.XtraEditors.SimpleButton();
            txtPhone = new DevExpress.XtraEditors.TextEdit();
            txtAddress = new DevExpress.XtraEditors.TextEdit();
            txtClientName = new DevExpress.XtraEditors.TextEdit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtPhone.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAddress.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtClientName.Properties).BeginInit();
            SuspendLayout();
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new System.Drawing.Font("Cairo", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseForeColor = true;
            labelControl1.Location = new System.Drawing.Point(214, 12);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(116, 42);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "اسم العميل";
            // 
            // panelBorderBottom
            // 
            panelBorderBottom.BackColor = System.Drawing.Color.FromArgb(0, 192, 192);
            panelBorderBottom.Location = new System.Drawing.Point(83, 96);
            panelBorderBottom.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            panelBorderBottom.Name = "panelBorderBottom";
            panelBorderBottom.Size = new System.Drawing.Size(379, 4);
            panelBorderBottom.TabIndex = 2;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new System.Drawing.Font("Cairo", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Appearance.Options.UseForeColor = true;
            labelControl2.Location = new System.Drawing.Point(236, 122);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(73, 42);
            labelControl2.TabIndex = 3;
            labelControl2.Text = "العنوان";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new System.Drawing.Font("Cairo", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Appearance.Options.UseForeColor = true;
            labelControl3.Location = new System.Drawing.Point(218, 243);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(109, 42);
            labelControl3.TabIndex = 5;
            labelControl3.Text = "رقم الهاتف";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAddAndClose);
            panel1.Controls.Add(btnAdd);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 374);
            panel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(544, 73);
            panel1.TabIndex = 7;
            // 
            // btnAddAndClose
            // 
            btnAddAndClose.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnAddAndClose.Appearance.Options.UseFont = true;
            btnAddAndClose.ImageOptions.Image = Properties.Resources.saveandclose_32x32;
            btnAddAndClose.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            btnAddAndClose.Location = new System.Drawing.Point(11, 16);
            btnAddAndClose.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            btnAddAndClose.Name = "btnAddAndClose";
            btnAddAndClose.Size = new System.Drawing.Size(142, 46);
            btnAddAndClose.TabIndex = 4;
            btnAddAndClose.Text = "اضافة + غلق";
            // 
            // btnAdd
            // 
            btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnAdd.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnAdd.Appearance.Options.UseFont = true;
            btnAdd.ImageOptions.Image = Properties.Resources.saveto_32x32;
            btnAdd.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            btnAdd.Location = new System.Drawing.Point(391, 16);
            btnAdd.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(142, 46);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "اضافة";
            // 
            // txtPhone
            // 
            txtPhone.Location = new System.Drawing.Point(83, 289);
            txtPhone.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            txtPhone.Name = "txtPhone";
            txtPhone.Properties.Appearance.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtPhone.Properties.Appearance.Options.UseFont = true;
            txtPhone.Properties.Appearance.Options.UseTextOptions = true;
            txtPhone.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            txtPhone.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.DeepSkyBlue;
            txtPhone.Properties.AppearanceFocused.Options.UseBorderColor = true;
            txtPhone.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            txtPhone.Size = new System.Drawing.Size(379, 36);
            txtPhone.TabIndex = 2;
            txtPhone.Enter += txtPhone_Enter;
            // 
            // txtAddress
            // 
            txtAddress.Location = new System.Drawing.Point(83, 168);
            txtAddress.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            txtAddress.Name = "txtAddress";
            txtAddress.Properties.Appearance.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtAddress.Properties.Appearance.Options.UseFont = true;
            txtAddress.Properties.Appearance.Options.UseTextOptions = true;
            txtAddress.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            txtAddress.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.DeepSkyBlue;
            txtAddress.Properties.AppearanceFocused.Options.UseBorderColor = true;
            txtAddress.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            txtAddress.Size = new System.Drawing.Size(379, 36);
            txtAddress.TabIndex = 1;
            txtAddress.Enter += txtAddress_Enter;
            // 
            // txtClientName
            // 
            txtClientName.Location = new System.Drawing.Point(83, 58);
            txtClientName.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            txtClientName.Name = "txtClientName";
            txtClientName.Properties.Appearance.BackColor = System.Drawing.Color.White;
            txtClientName.Properties.Appearance.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtClientName.Properties.Appearance.Options.UseBackColor = true;
            txtClientName.Properties.Appearance.Options.UseFont = true;
            txtClientName.Properties.Appearance.Options.UseTextOptions = true;
            txtClientName.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            txtClientName.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.DeepSkyBlue;
            txtClientName.Properties.AppearanceFocused.Options.UseBorderColor = true;
            txtClientName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            txtClientName.Size = new System.Drawing.Size(379, 36);
            txtClientName.TabIndex = 0;
            txtClientName.Enter += txtClientName_Enter;
            // 
            // frmAdd_Supplier
            // 
            Appearance.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            Appearance.Options.UseBackColor = true;
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(544, 447);
            Controls.Add(panel1);
            Controls.Add(txtPhone);
            Controls.Add(labelControl3);
            Controls.Add(txtAddress);
            Controls.Add(labelControl2);
            Controls.Add(panelBorderBottom);
            Controls.Add(txtClientName);
            Controls.Add(labelControl1);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            IconOptions.ShowIcon = false;
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(810, 788);
            MinimizeBox = false;
            Name = "frmAdd_Supplier";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "اضافة مورد";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtPhone.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtAddress.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtClientName.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtClientName;
        private System.Windows.Forms.Panel panelBorderBottom;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnAddAndClose;
    }
}