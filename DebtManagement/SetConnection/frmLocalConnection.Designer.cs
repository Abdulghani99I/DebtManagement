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
            btnTestConnection = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            labStatusConnection = new System.Windows.Forms.Label();
            linkLabel1 = new System.Windows.Forms.LinkLabel();
            label4 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            panelBottomBorder = new System.Windows.Forms.Panel();
            txtServerName = new System.Windows.Forms.TextBox();
            txtDatabaseName = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            cmbTrustedConnection = new DevExpress.XtraEditors.ComboBoxEdit();
            comEncrypt = new DevExpress.XtraEditors.ComboBoxEdit();
            btnSave = new System.Windows.Forms.Button();
            progressPanel1 = new DevExpress.XtraWaitForm.ProgressPanel();
            ((System.ComponentModel.ISupportInitialize)cmbTrustedConnection.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comEncrypt.Properties).BeginInit();
            SuspendLayout();
            // 
            // btnTestConnection
            // 
            btnTestConnection.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnTestConnection.BackColor = System.Drawing.Color.White;
            btnTestConnection.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnTestConnection.ForeColor = System.Drawing.Color.Black;
            btnTestConnection.Image = (System.Drawing.Image)resources.GetObject("btnTestConnection.Image");
            btnTestConnection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnTestConnection.Location = new System.Drawing.Point(291, 439);
            btnTestConnection.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            btnTestConnection.Name = "btnTestConnection";
            btnTestConnection.Size = new System.Drawing.Size(167, 45);
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
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(74, -64);
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
            labStatusConnection.Location = new System.Drawing.Point(69, 378);
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
            linkLabel1.ForeColor = System.Drawing.Color.Black;
            linkLabel1.LinkColor = System.Drawing.Color.Black;
            linkLabel1.Location = new System.Drawing.Point(321, 502);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new System.Drawing.Size(164, 24);
            linkLabel1.TabIndex = 15;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "ضبط اعدادات الاتصال الشبكي";
            linkLabel1.LinkClicked += llabNetworkConnection_LinkClicked;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.ForeColor = System.Drawing.Color.Black;
            label4.Location = new System.Drawing.Point(206, 274);
            label4.Name = "label4";
            label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            label4.Size = new System.Drawing.Size(78, 36);
            label4.TabIndex = 29;
            label4.Text = "Encrypt";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(160, 94);
            label2.Name = "label2";
            label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            label2.Size = new System.Drawing.Size(171, 36);
            label2.TabIndex = 27;
            label2.Text = "اسم قاعدة البيانات";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBottomBorder
            // 
            panelBottomBorder.Anchor = System.Windows.Forms.AnchorStyles.None;
            panelBottomBorder.BackColor = System.Drawing.Color.FromArgb(0, 192, 192);
            panelBottomBorder.Location = new System.Drawing.Point(33, 75);
            panelBottomBorder.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            panelBottomBorder.Name = "panelBottomBorder";
            panelBottomBorder.Size = new System.Drawing.Size(425, 3);
            panelBottomBorder.TabIndex = 26;
            // 
            // txtServerName
            // 
            txtServerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtServerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtServerName.Font = new System.Drawing.Font("Cairo", 14F);
            txtServerName.Location = new System.Drawing.Point(33, 43);
            txtServerName.Name = "txtServerName";
            txtServerName.Size = new System.Drawing.Size(425, 35);
            txtServerName.TabIndex = 21;
            txtServerName.Text = ".";
            txtServerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            txtServerName.Enter += txtServerName_Enter;
            // 
            // txtDatabaseName
            // 
            txtDatabaseName.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtDatabaseName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtDatabaseName.Font = new System.Drawing.Font("Cairo", 14F);
            txtDatabaseName.Location = new System.Drawing.Point(33, 133);
            txtDatabaseName.Name = "txtDatabaseName";
            txtDatabaseName.Size = new System.Drawing.Size(425, 35);
            txtDatabaseName.TabIndex = 22;
            txtDatabaseName.Text = "DebtManagement";
            txtDatabaseName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            txtDatabaseName.Enter += txtDatabaseName_Enter;
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.ForeColor = System.Drawing.Color.Black;
            label5.Location = new System.Drawing.Point(186, 4);
            label5.Name = "label5";
            label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            label5.Size = new System.Drawing.Size(118, 36);
            label5.TabIndex = 25;
            label5.Text = "اسم السيرفر";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.Black;
            label3.Location = new System.Drawing.Point(155, 184);
            label3.Name = "label3";
            label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            label3.Size = new System.Drawing.Size(181, 36);
            label3.TabIndex = 28;
            label3.Text = "Trusted_Connection";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbTrustedConnection
            // 
            cmbTrustedConnection.Anchor = System.Windows.Forms.AnchorStyles.None;
            cmbTrustedConnection.EditValue = "True";
            cmbTrustedConnection.Location = new System.Drawing.Point(33, 223);
            cmbTrustedConnection.Name = "cmbTrustedConnection";
            cmbTrustedConnection.Properties.Appearance.BackColor = System.Drawing.Color.White;
            cmbTrustedConnection.Properties.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            cmbTrustedConnection.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            cmbTrustedConnection.Properties.Appearance.Options.UseBackColor = true;
            cmbTrustedConnection.Properties.Appearance.Options.UseFont = true;
            cmbTrustedConnection.Properties.Appearance.Options.UseForeColor = true;
            cmbTrustedConnection.Properties.Appearance.Options.UseTextOptions = true;
            cmbTrustedConnection.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            cmbTrustedConnection.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cmbTrustedConnection.Properties.Items.AddRange(new object[] { "True", "False" });
            cmbTrustedConnection.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            cmbTrustedConnection.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            cmbTrustedConnection.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            cmbTrustedConnection.Size = new System.Drawing.Size(425, 36);
            cmbTrustedConnection.TabIndex = 30;
            cmbTrustedConnection.Enter += cmbTrustedConnection_Enter;
            // 
            // comEncrypt
            // 
            comEncrypt.Anchor = System.Windows.Forms.AnchorStyles.None;
            comEncrypt.EditValue = "False";
            comEncrypt.Location = new System.Drawing.Point(33, 313);
            comEncrypt.Name = "comEncrypt";
            comEncrypt.Properties.Appearance.BackColor = System.Drawing.Color.White;
            comEncrypt.Properties.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            comEncrypt.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            comEncrypt.Properties.Appearance.Options.UseBackColor = true;
            comEncrypt.Properties.Appearance.Options.UseFont = true;
            comEncrypt.Properties.Appearance.Options.UseForeColor = true;
            comEncrypt.Properties.Appearance.Options.UseTextOptions = true;
            comEncrypt.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            comEncrypt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comEncrypt.Properties.Items.AddRange(new object[] { "True", "False" });
            comEncrypt.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            comEncrypt.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            comEncrypt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            comEncrypt.Size = new System.Drawing.Size(425, 36);
            comEncrypt.TabIndex = 31;
            comEncrypt.Enter += comEncrypt_Enter;
            // 
            // btnSave
            // 
            btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnSave.BackColor = System.Drawing.Color.White;
            btnSave.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnSave.ForeColor = System.Drawing.Color.Black;
            btnSave.Image = Properties.Resources.saveall_32x32;
            btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSave.Location = new System.Drawing.Point(33, 439);
            btnSave.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(167, 45);
            btnSave.TabIndex = 5;
            btnSave.Text = "حفظ";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // progressPanel1
            // 
            progressPanel1.Appearance.BackColor = System.Drawing.Color.Transparent;
            progressPanel1.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            progressPanel1.Appearance.Options.UseBackColor = true;
            progressPanel1.Appearance.Options.UseFont = true;
            progressPanel1.AppearanceCaption.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            progressPanel1.AppearanceCaption.Options.UseFont = true;
            progressPanel1.AppearanceCaption.Options.UseTextOptions = true;
            progressPanel1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            progressPanel1.AppearanceDescription.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold);
            progressPanel1.AppearanceDescription.Options.UseFont = true;
            progressPanel1.AppearanceDescription.Options.UseTextOptions = true;
            progressPanel1.AppearanceDescription.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            progressPanel1.AppearanceDescription.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            progressPanel1.Caption = "جاري اختبار الاتصال";
            progressPanel1.Description = "يرجى الانتضار";
            progressPanel1.Location = new System.Drawing.Point(69, 361);
            progressPanel1.Name = "progressPanel1";
            progressPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            progressPanel1.Size = new System.Drawing.Size(362, 66);
            progressPanel1.TabIndex = 32;
            progressPanel1.Text = "progressPanel1";
            progressPanel1.Visible = false;
            // 
            // frmLocalConnection
            // 
            Appearance.BackColor = System.Drawing.SystemColors.Control;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(491, 532);
            Controls.Add(progressPanel1);
            Controls.Add(comEncrypt);
            Controls.Add(cmbTrustedConnection);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panelBottomBorder);
            Controls.Add(txtServerName);
            Controls.Add(txtDatabaseName);
            Controls.Add(label5);
            Controls.Add(linkLabel1);
            Controls.Add(labStatusConnection);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(btnTestConnection);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLocalConnection";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "اتصال قاعدة البيانات";
            Load += frmLocalConnection_Load;
            ((System.ComponentModel.ISupportInitialize)cmbTrustedConnection.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)comEncrypt.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labStatusConnection;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelBottomBorder;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.TextBox txtDatabaseName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.ComboBoxEdit cmbTrustedConnection;
        private DevExpress.XtraEditors.ComboBoxEdit comEncrypt;
        private System.Windows.Forms.Button btnSave;
        private DevExpress.XtraWaitForm.ProgressPanel progressPanel1;
    }
}