namespace DebtManagement
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            btnHome = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            btnSuppliers = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            btnClients = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            btnUsers = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            btnAnalysis = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            btnReports = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            btnSettings = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            btnAbout = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            btnLogOut = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            barBtnSetConnection = new DevExpress.XtraBars.BarButtonItem();
            skinBarSubItem1 = new DevExpress.XtraBars.SkinBarSubItem();
            barBtnUsername = new DevExpress.XtraBars.BarButtonItem();
            barBtnUserPermission = new DevExpress.XtraBars.BarButtonItem();
            barBtnLogOut = new DevExpress.XtraBars.BarButtonItem();
            fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(components);
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            FormContainer = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            tabControl = new DevExpress.XtraTab.XtraTabControl();
            barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)accordionControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fluentDesignFormControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fluentFormDefaultManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            FormContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabControl).BeginInit();
            SuspendLayout();
            // 
            // accordionControl1
            // 
            accordionControl1.Appearance.Item.Default.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold);
            accordionControl1.Appearance.Item.Default.Options.UseFont = true;
            accordionControl1.Dock = System.Windows.Forms.DockStyle.Right;
            accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { btnHome, btnSuppliers, btnClients, btnUsers, btnAnalysis, btnReports, btnSettings, btnAbout, btnLogOut });
            accordionControl1.Location = new System.Drawing.Point(791, 46);
            accordionControl1.Name = "accordionControl1";
            accordionControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            accordionControl1.Size = new System.Drawing.Size(250, 515);
            accordionControl1.TabIndex = 1;
            accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // btnHome
            // 
            btnHome.ImageOptions.SvgImage = Properties.Resources.bo_address;
            btnHome.Name = "btnHome";
            btnHome.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            btnHome.Text = "الرئيسية";
            btnHome.Click += btnHome_Click;
            // 
            // btnSuppliers
            // 
            btnSuppliers.ImageOptions.SvgImage = Properties.Resources.bo_resume;
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            btnSuppliers.Text = "الموردين";
            btnSuppliers.Click += btnSuppliers_Click;
            // 
            // btnClients
            // 
            btnClients.ImageOptions.SvgImage = Properties.Resources.bo_position;
            btnClients.Name = "btnClients";
            btnClients.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            btnClients.Text = "العملاء";
            btnClients.Click += btnClients_Click;
            // 
            // btnUsers
            // 
            btnUsers.ImageOptions.SvgImage = Properties.Resources.bo_user;
            btnUsers.Name = "btnUsers";
            btnUsers.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            btnUsers.Text = "المستخدمين";
            btnUsers.Click += btnUsers_Click;
            // 
            // btnAnalysis
            // 
            btnAnalysis.ImageOptions.SvgImage = Properties.Resources.bo_opportunity;
            btnAnalysis.Name = "btnAnalysis";
            btnAnalysis.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            btnAnalysis.Text = "تحليل";
            btnAnalysis.Click += btnAnalysis_Click;
            // 
            // btnReports
            // 
            btnReports.ImageOptions.Image = Properties.Resources.textbox_32x32;
            btnReports.Name = "btnReports";
            btnReports.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            btnReports.Text = "التقارير";
            btnReports.Click += btnReports_Click;
            // 
            // btnSettings
            // 
            btnSettings.ImageOptions.SvgImage = Properties.Resources.properties;
            btnSettings.Name = "btnSettings";
            btnSettings.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            btnSettings.Text = "الاعدادات";
            btnSettings.Click += btnSettings_Click;
            // 
            // btnAbout
            // 
            btnAbout.ImageOptions.SvgImage = Properties.Resources.Info;
            btnAbout.Name = "btnAbout";
            btnAbout.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            btnAbout.Text = "حول";
            btnAbout.Click += btnAbout_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnLogOut.ImageOptions.Image");
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            btnLogOut.Text = "تسجيل الخروج";
            btnLogOut.Click += btnLogOut_Click;
            // 
            // fluentDesignFormControl1
            // 
            fluentDesignFormControl1.FluentDesignForm = this;
            fluentDesignFormControl1.Font = new System.Drawing.Font("Cairo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { barBtnSetConnection, skinBarSubItem1, barBtnUsername, barBtnUserPermission, barBtnLogOut });
            fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            fluentDesignFormControl1.Manager = fluentFormDefaultManager1;
            fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            fluentDesignFormControl1.Size = new System.Drawing.Size(1041, 46);
            fluentDesignFormControl1.TabIndex = 2;
            fluentDesignFormControl1.TabStop = false;
            fluentDesignFormControl1.TitleItemLinks.Add(barBtnSetConnection, true);
            fluentDesignFormControl1.TitleItemLinks.Add(barBtnUserPermission, true);
            fluentDesignFormControl1.TitleItemLinks.Add(barBtnUsername, true);
            fluentDesignFormControl1.TitleItemLinks.Add(barBtnLogOut, true);
            fluentDesignFormControl1.Click += fluentDesignFormControl_Click;
            // 
            // barBtnSetConnection
            // 
            barBtnSetConnection.Id = 3;
            barBtnSetConnection.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("barBtnSetConnection.ImageOptions.Image");
            barBtnSetConnection.ImageOptions.LargeImage = Properties.Resources.radio_32x32;
            barBtnSetConnection.Name = "barBtnSetConnection";
            barBtnSetConnection.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            barBtnSetConnection.ItemClick += barBtnSetConnection_ItemClick;
            // 
            // skinBarSubItem1
            // 
            skinBarSubItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            skinBarSubItem1.Caption = "skinBarSubItem1";
            skinBarSubItem1.Id = 4;
            skinBarSubItem1.Name = "skinBarSubItem1";
            // 
            // barBtnUsername
            // 
            barBtnUsername.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            barBtnUsername.Caption = "اسم المستخدم";
            barBtnUsername.Id = 7;
            barBtnUsername.ItemAppearance.Normal.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            barBtnUsername.ItemAppearance.Normal.Options.UseFont = true;
            barBtnUsername.Name = "barBtnUsername";
            // 
            // barBtnUserPermission
            // 
            barBtnUserPermission.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            barBtnUserPermission.Caption = "الصلاحية";
            barBtnUserPermission.Id = 8;
            barBtnUserPermission.ItemAppearance.Normal.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            barBtnUserPermission.ItemAppearance.Normal.Options.UseFont = true;
            barBtnUserPermission.Name = "barBtnUserPermission";
            // 
            // barBtnLogOut
            // 
            barBtnLogOut.Caption = "تسجيل الخروج";
            barBtnLogOut.Id = 9;
            barBtnLogOut.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("barBtnLogOut.ImageOptions.Image");
            barBtnLogOut.ItemAppearance.Normal.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            barBtnLogOut.ItemAppearance.Normal.Options.UseFont = true;
            barBtnLogOut.Name = "barBtnLogOut";
            barBtnLogOut.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            barBtnLogOut.ItemClick += barBtnLogOut_ItemClick;
            // 
            // fluentFormDefaultManager1
            // 
            fluentFormDefaultManager1.Form = this;
            fluentFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { barBtnSetConnection, skinBarSubItem1, barBtnUsername, barBtnUserPermission, barBtnLogOut });
            fluentFormDefaultManager1.MaxItemId = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.White_import_32;
            pictureBox1.Location = new System.Drawing.Point(399, 140);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(67, 63);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = System.Drawing.Color.DimGray;
            pictureBox2.Image = Properties.Resources.White_import_32;
            pictureBox2.Location = new System.Drawing.Point(516, 165);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(100, 50);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // FormContainer
            // 
            FormContainer.Controls.Add(tabControl);
            FormContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            FormContainer.Location = new System.Drawing.Point(0, 46);
            FormContainer.Name = "FormContainer";
            FormContainer.Size = new System.Drawing.Size(791, 515);
            FormContainer.TabIndex = 0;
            // 
            // tabControl
            // 
            tabControl.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tabControl.Appearance.Options.UseFont = true;
            tabControl.AppearancePage.Header.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tabControl.AppearancePage.Header.Options.UseFont = true;
            tabControl.AppearancePage.HeaderActive.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tabControl.AppearancePage.HeaderActive.Options.UseFont = true;
            tabControl.AppearancePage.HeaderDisabled.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tabControl.AppearancePage.HeaderDisabled.Options.UseFont = true;
            tabControl.AppearancePage.HeaderHotTracked.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tabControl.AppearancePage.HeaderHotTracked.Options.UseFont = true;
            tabControl.AppearancePage.PageClient.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tabControl.AppearancePage.PageClient.Options.UseFont = true;
            tabControl.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeader;
            tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl.Location = new System.Drawing.Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            tabControl.Size = new System.Drawing.Size(791, 515);
            tabControl.TabIndex = 0;
            tabControl.CloseButtonClick += tabControl_CloseButtonClick;
            // 
            // barButtonItem1
            // 
            barButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            barButtonItem1.Caption = "اسم المستخدم";
            barButtonItem1.Id = 7;
            barButtonItem1.ItemAppearance.Normal.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            barButtonItem1.ItemAppearance.Normal.Options.UseFont = true;
            barButtonItem1.Name = "barButtonItem1";
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1041, 561);
            ControlContainer = FormContainer;
            Controls.Add(FormContainer);
            Controls.Add(accordionControl1);
            Controls.Add(fluentDesignFormControl1);
            FluentDesignFormControl = fluentDesignFormControl1;
            IconOptions.Icon = (System.Drawing.Icon)resources.GetObject("Main.IconOptions.Icon");
            MinimumSize = new System.Drawing.Size(1043, 562);
            Name = "Main";
            NavigationControl = accordionControl1;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "ادارة الديون";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            FormClosed += Main_FormClosed;
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)accordionControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fluentDesignFormControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fluentFormDefaultManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            FormContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tabControl).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnHome;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnSuppliers;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnClients;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnUsers;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnAnalysis;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnSettings;
        private DevExpress.XtraBars.BarButtonItem barBtnSetConnection;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnReports;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnAbout;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnLogOut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer FormContainer;
        private DevExpress.XtraTab.XtraTabControl tabControl;
        private DevExpress.XtraBars.BarButtonItem barBtnUsername;
        private DevExpress.XtraBars.BarButtonItem barBtnUserPermission;
        private DevExpress.XtraBars.BarButtonItem barBtnLogOut;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}