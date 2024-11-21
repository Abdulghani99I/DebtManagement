namespace DebtManagement.Settings
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            navigationFrame1 = new DevExpress.XtraBars.Navigation.NavigationFrame();
            pageGeneralSettings = new DevExpress.XtraBars.Navigation.NavigationPage();
            pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            richtxtDescription = new System.Windows.Forms.RichTextBox();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txtCompanyName = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            pageDatabaseSettings = new DevExpress.XtraBars.Navigation.NavigationPage();
            progressPanel1 = new DevExpress.XtraWaitForm.ProgressPanel();
            groupBox2 = new System.Windows.Forms.GroupBox();
            llabNetworkConnection = new System.Windows.Forms.LinkLabel();
            llabLocalConnection = new System.Windows.Forms.LinkLabel();
            groupBox1 = new System.Windows.Forms.GroupBox();
            btnRestoreDatabase = new System.Windows.Forms.Button();
            btnBackUp = new System.Windows.Forms.Button();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            pageCurrencySettings = new DevExpress.XtraBars.Navigation.NavigationPage();
            cmbSecondCurrency = new DevExpress.XtraEditors.ComboBoxEdit();
            cmbMainCurrency = new DevExpress.XtraEditors.ComboBoxEdit();
            txtConversionAmount = new System.Windows.Forms.TextBox();
            label12 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            navigationPageModeApp = new DevExpress.XtraBars.Navigation.NavigationPage();
            groupBox3 = new System.Windows.Forms.GroupBox();
            toggleSwitchMode = new DevExpress.XtraEditors.ToggleSwitch();
            labIconMode = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            btnSave = new System.Windows.Forms.Button();
            btnGeneralSettings = new System.Windows.Forms.Button();
            btnDatabaseSettings = new System.Windows.Forms.Button();
            btnCurrencySettings = new System.Windows.Forms.Button();
            btnModeApp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)navigationFrame1).BeginInit();
            navigationFrame1.SuspendLayout();
            pageGeneralSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).BeginInit();
            pageDatabaseSettings.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            pageCurrencySettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbSecondCurrency.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbMainCurrency.Properties).BeginInit();
            navigationPageModeApp.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)toggleSwitchMode.Properties).BeginInit();
            SuspendLayout();
            // 
            // navigationFrame1
            // 
            navigationFrame1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            navigationFrame1.Appearance.BackColor = System.Drawing.Color.White;
            navigationFrame1.Appearance.Options.UseBackColor = true;
            navigationFrame1.Controls.Add(pageGeneralSettings);
            navigationFrame1.Controls.Add(pageDatabaseSettings);
            navigationFrame1.Controls.Add(pageCurrencySettings);
            navigationFrame1.Controls.Add(navigationPageModeApp);
            navigationFrame1.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            navigationFrame1.Location = new System.Drawing.Point(12, 12);
            navigationFrame1.Name = "navigationFrame1";
            navigationFrame1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] { pageGeneralSettings, pageDatabaseSettings, pageCurrencySettings, navigationPageModeApp });
            navigationFrame1.SelectedPage = pageGeneralSettings;
            navigationFrame1.Size = new System.Drawing.Size(827, 485);
            navigationFrame1.TabIndex = 0;
            navigationFrame1.Text = "navigationFrame1";
            navigationFrame1.TransitionAnimationProperties.FrameCount = 600;
            // 
            // pageGeneralSettings
            // 
            pageGeneralSettings.Appearance.BackColor = System.Drawing.Color.White;
            pageGeneralSettings.Appearance.Options.UseBackColor = true;
            pageGeneralSettings.Caption = "navigationPage1";
            pageGeneralSettings.Controls.Add(pictureEdit1);
            pageGeneralSettings.Controls.Add(richtxtDescription);
            pageGeneralSettings.Controls.Add(label5);
            pageGeneralSettings.Controls.Add(label4);
            pageGeneralSettings.Controls.Add(label3);
            pageGeneralSettings.Controls.Add(txtCompanyName);
            pageGeneralSettings.Controls.Add(label2);
            pageGeneralSettings.Controls.Add(label1);
            pageGeneralSettings.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            pageGeneralSettings.Name = "pageGeneralSettings";
            pageGeneralSettings.Size = new System.Drawing.Size(827, 485);
            // 
            // pictureEdit1
            // 
            pictureEdit1.Anchor = System.Windows.Forms.AnchorStyles.None;
            pictureEdit1.Location = new System.Drawing.Point(314, 303);
            pictureEdit1.Name = "pictureEdit1";
            pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            pictureEdit1.Size = new System.Drawing.Size(176, 148);
            pictureEdit1.TabIndex = 3;
            // 
            // richtxtDescription
            // 
            richtxtDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            richtxtDescription.Font = new System.Drawing.Font("Cairo", 14F);
            richtxtDescription.Location = new System.Drawing.Point(146, 168);
            richtxtDescription.MaxLength = 500;
            richtxtDescription.Name = "richtxtDescription";
            richtxtDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            richtxtDescription.Size = new System.Drawing.Size(472, 118);
            richtxtDescription.TabIndex = 2;
            richtxtDescription.Text = "";
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Cairo", 8.25F, System.Drawing.FontStyle.Bold);
            label5.ForeColor = System.Drawing.Color.Black;
            label5.Location = new System.Drawing.Point(303, 454);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(197, 20);
            label5.TabIndex = 0;
            label5.Text = "انقر كلك ايمن على الصورة ثم اختر الشعار";
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.ForeColor = System.Drawing.Color.Black;
            label4.Location = new System.Drawing.Point(649, 312);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(70, 36);
            label4.TabIndex = 0;
            label4.Text = "الشعار";
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.Black;
            label3.Location = new System.Drawing.Point(649, 167);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(75, 36);
            label3.TabIndex = 0;
            label3.Text = "الوصف";
            // 
            // txtCompanyName
            // 
            txtCompanyName.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtCompanyName.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtCompanyName.Location = new System.Drawing.Point(146, 83);
            txtCompanyName.MaxLength = 50;
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txtCompanyName.Size = new System.Drawing.Size(472, 43);
            txtCompanyName.TabIndex = 1;
            txtCompanyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(649, 84);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(116, 36);
            label2.TabIndex = 0;
            label2.Text = "اسم الشركة";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(352, 16);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(125, 36);
            label1.TabIndex = 0;
            label1.Text = "اعدادات عامة";
            // 
            // pageDatabaseSettings
            // 
            pageDatabaseSettings.Appearance.BackColor = System.Drawing.Color.White;
            pageDatabaseSettings.Appearance.Options.UseBackColor = true;
            pageDatabaseSettings.Caption = "navigationPage2";
            pageDatabaseSettings.Controls.Add(progressPanel1);
            pageDatabaseSettings.Controls.Add(groupBox2);
            pageDatabaseSettings.Controls.Add(groupBox1);
            pageDatabaseSettings.Controls.Add(label6);
            pageDatabaseSettings.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold);
            pageDatabaseSettings.Name = "pageDatabaseSettings";
            pageDatabaseSettings.Size = new System.Drawing.Size(827, 485);
            // 
            // progressPanel1
            // 
            progressPanel1.Appearance.BackColor = System.Drawing.Color.Transparent;
            progressPanel1.Appearance.Options.UseBackColor = true;
            progressPanel1.AppearanceCaption.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            progressPanel1.AppearanceCaption.Options.UseFont = true;
            progressPanel1.AppearanceDescription.Font = new System.Drawing.Font("Cairo", 9.249999F, System.Drawing.FontStyle.Bold);
            progressPanel1.AppearanceDescription.Options.UseFont = true;
            progressPanel1.Caption = "جاري إتمام العملية";
            progressPanel1.Description = "الرجاء الانتضار";
            progressPanel1.Location = new System.Drawing.Point(201, 384);
            progressPanel1.Name = "progressPanel1";
            progressPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            progressPanel1.Size = new System.Drawing.Size(313, 82);
            progressPanel1.TabIndex = 3;
            progressPanel1.Text = "progressPanel1";
            progressPanel1.Visible = false;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBox2.Controls.Add(llabNetworkConnection);
            groupBox2.Controls.Add(llabLocalConnection);
            groupBox2.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            groupBox2.Location = new System.Drawing.Point(38, 59);
            groupBox2.Name = "groupBox2";
            groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            groupBox2.Size = new System.Drawing.Size(767, 136);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "اعدادات الاتصال";
            // 
            // llabNetworkConnection
            // 
            llabNetworkConnection.AutoSize = true;
            llabNetworkConnection.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold);
            llabNetworkConnection.Location = new System.Drawing.Point(153, 50);
            llabNetworkConnection.Name = "llabNetworkConnection";
            llabNetworkConnection.Size = new System.Drawing.Size(149, 36);
            llabNetworkConnection.TabIndex = 0;
            llabNetworkConnection.TabStop = true;
            llabNetworkConnection.Text = "الاتصال الشبكي";
            llabNetworkConnection.LinkClicked += llabNetworkConnection_LinkClicked;
            // 
            // llabLocalConnection
            // 
            llabLocalConnection.AutoSize = true;
            llabLocalConnection.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold);
            llabLocalConnection.Location = new System.Drawing.Point(605, 50);
            llabLocalConnection.Name = "llabLocalConnection";
            llabLocalConnection.Size = new System.Drawing.Size(140, 36);
            llabLocalConnection.TabIndex = 0;
            llabLocalConnection.TabStop = true;
            llabLocalConnection.Text = "الاتصال المحلي";
            llabLocalConnection.LinkClicked += llabLocalConnection_LinkClicked;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBox1.Controls.Add(btnRestoreDatabase);
            groupBox1.Controls.Add(btnBackUp);
            groupBox1.Controls.Add(label7);
            groupBox1.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            groupBox1.Location = new System.Drawing.Point(32, 216);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            groupBox1.Size = new System.Drawing.Size(767, 162);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "اعدادات النسخ الاحتياطي";
            // 
            // btnRestoreDatabase
            // 
            btnRestoreDatabase.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnRestoreDatabase.BackColor = System.Drawing.Color.White;
            btnRestoreDatabase.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnRestoreDatabase.ForeColor = System.Drawing.Color.Black;
            btnRestoreDatabase.Image = Properties.Resources.newdatasource_32x32;
            btnRestoreDatabase.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnRestoreDatabase.Location = new System.Drawing.Point(26, 79);
            btnRestoreDatabase.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            btnRestoreDatabase.Name = "btnRestoreDatabase";
            btnRestoreDatabase.Size = new System.Drawing.Size(294, 47);
            btnRestoreDatabase.TabIndex = 8;
            btnRestoreDatabase.Text = "استعادة نسخة احتياطية";
            btnRestoreDatabase.UseVisualStyleBackColor = false;
            btnRestoreDatabase.Click += btnRestoreDatabase_Click;
            // 
            // btnBackUp
            // 
            btnBackUp.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnBackUp.BackColor = System.Drawing.Color.White;
            btnBackUp.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnBackUp.ForeColor = System.Drawing.Color.Black;
            btnBackUp.Image = Properties.Resources.database_32x32;
            btnBackUp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnBackUp.Location = new System.Drawing.Point(449, 79);
            btnBackUp.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            btnBackUp.Name = "btnBackUp";
            btnBackUp.Size = new System.Drawing.Size(291, 47);
            btnBackUp.TabIndex = 8;
            btnBackUp.Text = "اخذ نسخة احتياطية";
            btnBackUp.UseVisualStyleBackColor = false;
            btnBackUp.Click += btnBackUp_Click;
            // 
            // label7
            // 
            label7.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Cairo", 9.25F, System.Drawing.FontStyle.Bold);
            label7.ForeColor = System.Drawing.Color.Red;
            label7.Location = new System.Drawing.Point(26, 33);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(449, 24);
            label7.TabIndex = 1;
            label7.Text = "قم بتشغيل البرنامج كمسؤول حتى تتمكن من اجراء النسخ الاحتياطي والتعيين";
            // 
            // label6
            // 
            label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.ForeColor = System.Drawing.Color.Black;
            label6.Location = new System.Drawing.Point(315, 16);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(199, 36);
            label6.TabIndex = 1;
            label6.Text = "اعدادات قاعدة البيانات";
            // 
            // pageCurrencySettings
            // 
            pageCurrencySettings.Appearance.BackColor = System.Drawing.Color.White;
            pageCurrencySettings.Appearance.Options.UseBackColor = true;
            pageCurrencySettings.Caption = "navigationPage3";
            pageCurrencySettings.Controls.Add(cmbSecondCurrency);
            pageCurrencySettings.Controls.Add(cmbMainCurrency);
            pageCurrencySettings.Controls.Add(txtConversionAmount);
            pageCurrencySettings.Controls.Add(label12);
            pageCurrencySettings.Controls.Add(label11);
            pageCurrencySettings.Controls.Add(label10);
            pageCurrencySettings.Controls.Add(label9);
            pageCurrencySettings.Controls.Add(label8);
            pageCurrencySettings.Name = "pageCurrencySettings";
            pageCurrencySettings.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            pageCurrencySettings.Size = new System.Drawing.Size(827, 485);
            // 
            // cmbSecondCurrency
            // 
            cmbSecondCurrency.Anchor = System.Windows.Forms.AnchorStyles.None;
            cmbSecondCurrency.EditValue = "دولار";
            cmbSecondCurrency.Location = new System.Drawing.Point(162, 146);
            cmbSecondCurrency.Name = "cmbSecondCurrency";
            cmbSecondCurrency.Properties.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            cmbSecondCurrency.Properties.Appearance.Options.UseFont = true;
            cmbSecondCurrency.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cmbSecondCurrency.Properties.Items.AddRange(new object[] { "دولار" });
            cmbSecondCurrency.Properties.ReadOnly = true;
            cmbSecondCurrency.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            cmbSecondCurrency.Size = new System.Drawing.Size(307, 36);
            cmbSecondCurrency.TabIndex = 11;
            // 
            // cmbMainCurrency
            // 
            cmbMainCurrency.Anchor = System.Windows.Forms.AnchorStyles.None;
            cmbMainCurrency.EditValue = "دينار";
            cmbMainCurrency.Location = new System.Drawing.Point(162, 79);
            cmbMainCurrency.Name = "cmbMainCurrency";
            cmbMainCurrency.Properties.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            cmbMainCurrency.Properties.Appearance.Options.UseFont = true;
            cmbMainCurrency.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cmbMainCurrency.Properties.Items.AddRange(new object[] { "دينار" });
            cmbMainCurrency.Properties.ReadOnly = true;
            cmbMainCurrency.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            cmbMainCurrency.Size = new System.Drawing.Size(307, 36);
            cmbMainCurrency.TabIndex = 11;
            // 
            // txtConversionAmount
            // 
            txtConversionAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtConversionAmount.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            txtConversionAmount.ForeColor = System.Drawing.Color.Black;
            txtConversionAmount.Location = new System.Drawing.Point(162, 209);
            txtConversionAmount.MaxLength = 4;
            txtConversionAmount.Name = "txtConversionAmount";
            txtConversionAmount.Size = new System.Drawing.Size(307, 37);
            txtConversionAmount.TabIndex = 10;
            txtConversionAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            label12.Font = new System.Drawing.Font("Cairo", 12.25F, System.Drawing.FontStyle.Bold);
            label12.ForeColor = System.Drawing.Color.Black;
            label12.Location = new System.Drawing.Point(69, 299);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(691, 100);
            label12.TabIndex = 2;
            label12.Text = resources.GetString("label12.Text");
            label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label11.ForeColor = System.Drawing.Color.Black;
            label11.Location = new System.Drawing.Point(500, 208);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(132, 36);
            label11.TabIndex = 2;
            label11.Text = "مقدار التحويل";
            // 
            // label10
            // 
            label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label10.ForeColor = System.Drawing.Color.Black;
            label10.Location = new System.Drawing.Point(500, 145);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(139, 36);
            label10.TabIndex = 2;
            label10.Text = "العملة الثانوية";
            // 
            // label9
            // 
            label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label9.ForeColor = System.Drawing.Color.Black;
            label9.Location = new System.Drawing.Point(500, 82);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(147, 36);
            label9.TabIndex = 2;
            label9.Text = "العملة الرئيسية";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label8.ForeColor = System.Drawing.Color.Black;
            label8.Location = new System.Drawing.Point(301, 16);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(140, 36);
            label8.TabIndex = 2;
            label8.Text = "اعدادات العملة";
            // 
            // navigationPageModeApp
            // 
            navigationPageModeApp.Caption = "navigationPage1";
            navigationPageModeApp.Controls.Add(groupBox3);
            navigationPageModeApp.Font = new System.Drawing.Font("Cairo", 14F);
            navigationPageModeApp.Name = "navigationPageModeApp";
            navigationPageModeApp.Size = new System.Drawing.Size(827, 485);
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(toggleSwitchMode);
            groupBox3.Controls.Add(labIconMode);
            groupBox3.Controls.Add(label13);
            groupBox3.ForeColor = System.Drawing.Color.Black;
            groupBox3.Location = new System.Drawing.Point(24, 29);
            groupBox3.Name = "groupBox3";
            groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            groupBox3.Size = new System.Drawing.Size(756, 271);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "مضهر البرنامج";
            // 
            // toggleSwitchMode
            // 
            toggleSwitchMode.Location = new System.Drawing.Point(163, 179);
            toggleSwitchMode.Name = "toggleSwitchMode";
            toggleSwitchMode.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            toggleSwitchMode.Properties.Appearance.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            toggleSwitchMode.Properties.Appearance.Options.UseBackColor = true;
            toggleSwitchMode.Properties.Appearance.Options.UseFont = true;
            toggleSwitchMode.Properties.AutoHeight = false;
            toggleSwitchMode.Properties.OffText = "   نهاري";
            toggleSwitchMode.Properties.OnText = "   ليلي";
            toggleSwitchMode.Size = new System.Drawing.Size(274, 67);
            toggleSwitchMode.TabIndex = 15;
            toggleSwitchMode.Toggled += toggleSwitchMode_Toggled;
            // 
            // labIconMode
            // 
            labIconMode.Font = new System.Drawing.Font("Cairo", 50F);
            labIconMode.ForeColor = System.Drawing.Color.FromArgb(0, 64, 64);
            labIconMode.Location = new System.Drawing.Point(283, 38);
            labIconMode.Name = "labIconMode";
            labIconMode.Size = new System.Drawing.Size(191, 145);
            labIconMode.TabIndex = 14;
            labIconMode.Text = "🌤️";
            labIconMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label13.Location = new System.Drawing.Point(443, 194);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(73, 36);
            label13.TabIndex = 13;
            label13.Text = "الوضع:";
            // 
            // btnSave
            // 
            btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnSave.BackColor = System.Drawing.Color.White;
            btnSave.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnSave.ForeColor = System.Drawing.Color.Black;
            btnSave.Image = Properties.Resources.saveall_32x32;
            btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSave.Location = new System.Drawing.Point(702, 505);
            btnSave.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            btnSave.Name = "btnSave";
            btnSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            btnSave.Size = new System.Drawing.Size(137, 47);
            btnSave.TabIndex = 9;
            btnSave.Text = "حفظ";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnGeneralSettings
            // 
            btnGeneralSettings.BackColor = System.Drawing.Color.White;
            btnGeneralSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGeneralSettings.Image = Properties.Resources.customizegrid_32x32;
            btnGeneralSettings.Location = new System.Drawing.Point(24, 510);
            btnGeneralSettings.Name = "btnGeneralSettings";
            btnGeneralSettings.Size = new System.Drawing.Size(58, 39);
            btnGeneralSettings.TabIndex = 1;
            btnGeneralSettings.UseVisualStyleBackColor = false;
            btnGeneralSettings.Click += btnGeneralSettings_Click;
            // 
            // btnDatabaseSettings
            // 
            btnDatabaseSettings.BackColor = System.Drawing.Color.White;
            btnDatabaseSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDatabaseSettings.Image = Properties.Resources.managedatasource_32x32;
            btnDatabaseSettings.Location = new System.Drawing.Point(96, 510);
            btnDatabaseSettings.Name = "btnDatabaseSettings";
            btnDatabaseSettings.Size = new System.Drawing.Size(58, 39);
            btnDatabaseSettings.TabIndex = 1;
            btnDatabaseSettings.UseVisualStyleBackColor = false;
            btnDatabaseSettings.Click += btnDatabaseSettings_Click;
            // 
            // btnCurrencySettings
            // 
            btnCurrencySettings.BackColor = System.Drawing.Color.White;
            btnCurrencySettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCurrencySettings.Image = Properties.Resources.currency_32x32;
            btnCurrencySettings.Location = new System.Drawing.Point(165, 510);
            btnCurrencySettings.Name = "btnCurrencySettings";
            btnCurrencySettings.Size = new System.Drawing.Size(58, 39);
            btnCurrencySettings.TabIndex = 1;
            btnCurrencySettings.UseVisualStyleBackColor = false;
            btnCurrencySettings.Click += btnCurrencySettings_Click;
            // 
            // btnModeApp
            // 
            btnModeApp.BackColor = System.Drawing.Color.White;
            btnModeApp.FlatAppearance.BorderSize = 0;
            btnModeApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnModeApp.Font = new System.Drawing.Font("Tahoma", 20F);
            btnModeApp.ForeColor = System.Drawing.Color.Goldenrod;
            btnModeApp.Location = new System.Drawing.Point(241, 510);
            btnModeApp.Name = "btnModeApp";
            btnModeApp.Size = new System.Drawing.Size(58, 39);
            btnModeApp.TabIndex = 1;
            btnModeApp.Text = "☀️";
            btnModeApp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            btnModeApp.UseVisualStyleBackColor = false;
            btnModeApp.Click += btnModeApp_Click;
            // 
            // frmSettings
            // 
            Appearance.BackColor = System.Drawing.Color.FromArgb(53, 80, 125);
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(851, 561);
            Controls.Add(btnModeApp);
            Controls.Add(btnCurrencySettings);
            Controls.Add(btnDatabaseSettings);
            Controls.Add(btnGeneralSettings);
            Controls.Add(btnSave);
            Controls.Add(navigationFrame1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            IconOptions.ShowIcon = false;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmSettings";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "الاعدادات";
            Load += frmSettings_Load;
            ((System.ComponentModel.ISupportInitialize)navigationFrame1).EndInit();
            navigationFrame1.ResumeLayout(false);
            pageGeneralSettings.ResumeLayout(false);
            pageGeneralSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).EndInit();
            pageDatabaseSettings.ResumeLayout(false);
            pageDatabaseSettings.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            pageCurrencySettings.ResumeLayout(false);
            pageCurrencySettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cmbSecondCurrency.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbMainCurrency.Properties).EndInit();
            navigationPageModeApp.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)toggleSwitchMode.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame1;
        private DevExpress.XtraBars.Navigation.NavigationPage pageGeneralSettings;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private System.Windows.Forms.RichTextBox richtxtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.Navigation.NavigationPage pageDatabaseSettings;
        private System.Windows.Forms.Button btnSaveGeneralSettings;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel llabLocalConnection;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel llabNetworkConnection;
        private System.Windows.Forms.Button btnRestoreDatabase;
        private System.Windows.Forms.Button btnBackUp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSaveDatabaseSettings;
        private DevExpress.XtraBars.Navigation.NavigationPage pageCurrencySettings;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtConversionAmount;
        private System.Windows.Forms.Button btnGeneralSettings;
        private System.Windows.Forms.Button btnDatabaseSettings;
        private System.Windows.Forms.Button btnCurrencySettings;
        private DevExpress.XtraEditors.ComboBoxEdit cmbMainCurrency;
        private DevExpress.XtraEditors.ComboBoxEdit cmbSecondCurrency;
        private DevExpress.XtraWaitForm.ProgressPanel progressPanel1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPageModeApp;
        private System.Windows.Forms.Button btnModeApp;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labIconMode;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitchMode;
    }
}