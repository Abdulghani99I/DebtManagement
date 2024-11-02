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
            FormContainer = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            panelContainer = new System.Windows.Forms.Panel();
            accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            btnHome = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            btnSuppliers = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            btnClients = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            btnUsers = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            btnAnalysis = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            btnSettings = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(components);
            FormContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)accordionControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fluentDesignFormControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fluentFormDefaultManager1).BeginInit();
            SuspendLayout();
            // 
            // FormContainer
            // 
            FormContainer.Controls.Add(panelContainer);
            FormContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            FormContainer.Location = new System.Drawing.Point(0, 31);
            FormContainer.Name = "FormContainer";
            FormContainer.Size = new System.Drawing.Size(781, 530);
            FormContainer.TabIndex = 0;
            // 
            // panelContainer
            // 
            panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            panelContainer.Location = new System.Drawing.Point(0, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new System.Drawing.Size(781, 530);
            panelContainer.TabIndex = 0;
            // 
            // accordionControl1
            // 
            accordionControl1.Appearance.AccordionControl.BackColor = System.Drawing.Color.FromArgb(62, 91, 135);
            accordionControl1.Appearance.AccordionControl.Options.UseBackColor = true;
            accordionControl1.Appearance.Item.Default.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold);
            accordionControl1.Appearance.Item.Default.Options.UseFont = true;
            accordionControl1.Dock = System.Windows.Forms.DockStyle.Right;
            accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { btnHome, btnSuppliers, btnClients, btnUsers, btnAnalysis, btnSettings });
            accordionControl1.Location = new System.Drawing.Point(781, 31);
            accordionControl1.Name = "accordionControl1";
            accordionControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            accordionControl1.Size = new System.Drawing.Size(260, 530);
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
            // btnSettings
            // 
            btnSettings.ImageOptions.SvgImage = Properties.Resources.properties;
            btnSettings.Name = "btnSettings";
            btnSettings.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            btnSettings.Text = "الاعدادات";
            btnSettings.Click += btnSettings_Click;
            // 
            // fluentDesignFormControl1
            // 
            fluentDesignFormControl1.FluentDesignForm = this;
            fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            fluentDesignFormControl1.Manager = fluentFormDefaultManager1;
            fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            fluentDesignFormControl1.Size = new System.Drawing.Size(1041, 31);
            fluentDesignFormControl1.TabIndex = 2;
            fluentDesignFormControl1.TabStop = false;
            // 
            // fluentFormDefaultManager1
            // 
            fluentFormDefaultManager1.Form = this;
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
            MinimumSize = new System.Drawing.Size(1043, 562);
            Name = "Main";
            NavigationControl = accordionControl1;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Main";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += Main_Load;
            FormContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)accordionControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fluentDesignFormControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fluentFormDefaultManager1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer FormContainer;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnHome;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnSuppliers;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnClients;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnUsers;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnAnalysis;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnSettings;
        private System.Windows.Forms.Panel panelContainer;
    }
}