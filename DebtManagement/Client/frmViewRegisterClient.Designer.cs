namespace DebtManagement
{
    partial class frmViewRegisterClient
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
            panel1 = new System.Windows.Forms.Panel();
            labRemaining = new System.Windows.Forms.Label();
            labPayments = new System.Windows.Forms.Label();
            labRequired = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            panel11 = new System.Windows.Forms.Label();
            pannel10 = new System.Windows.Forms.Label();
            panel9 = new System.Windows.Forms.Label();
            labName = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            gridControlClientsDebt = new DevExpress.XtraGrid.GridControl();
            gridViewClientsDebt = new DevExpress.XtraGrid.Views.Grid.GridView();
            colDebtID = new DevExpress.XtraGrid.Columns.GridColumn();
            colDebtMenu = new DevExpress.XtraGrid.Columns.GridColumn();
            colAmountDebt = new DevExpress.XtraGrid.Columns.GridColumn();
            colDateDebt = new DevExpress.XtraGrid.Columns.GridColumn();
            panel6 = new System.Windows.Forms.Panel();
            label4 = new System.Windows.Forms.Label();
            panel4 = new System.Windows.Forms.Panel();
            btnDeleteDebtMenu = new DevExpress.XtraEditors.SimpleButton();
            btnEditDebtMenu = new DevExpress.XtraEditors.SimpleButton();
            btnAddDebtMenu = new DevExpress.XtraEditors.SimpleButton();
            panel3 = new System.Windows.Forms.Panel();
            gridControlClientsPayments = new DevExpress.XtraGrid.GridControl();
            gridViewClientsPayments = new DevExpress.XtraGrid.Views.Grid.GridView();
            colPaymentID = new DevExpress.XtraGrid.Columns.GridColumn();
            colPaymentAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            colDatePayment = new DevExpress.XtraGrid.Columns.GridColumn();
            panel7 = new System.Windows.Forms.Panel();
            label6 = new System.Windows.Forms.Label();
            panel5 = new System.Windows.Forms.Panel();
            btnAddPayment = new DevExpress.XtraEditors.SimpleButton();
            btnDeletePayment = new DevExpress.XtraEditors.SimpleButton();
            btnEditPayment = new DevExpress.XtraEditors.SimpleButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControlClientsDebt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewClientsDebt).BeginInit();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControlClientsPayments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewClientsPayments).BeginInit();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            panel1.Controls.Add(labRemaining);
            panel1.Controls.Add(labPayments);
            panel1.Controls.Add(labRequired);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel11);
            panel1.Controls.Add(pannel10);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(labName);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            panel1.Location = new System.Drawing.Point(0, 496);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1013, 67);
            panel1.TabIndex = 0;
            // 
            // labRemaining
            // 
            labRemaining.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            labRemaining.BackColor = System.Drawing.Color.Gray;
            labRemaining.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            labRemaining.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold);
            labRemaining.ForeColor = System.Drawing.Color.Black;
            labRemaining.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            labRemaining.Location = new System.Drawing.Point(206, 15);
            labRemaining.Name = "labRemaining";
            labRemaining.RightToLeft = System.Windows.Forms.RightToLeft.No;
            labRemaining.Size = new System.Drawing.Size(114, 36);
            labRemaining.TabIndex = 10;
            labRemaining.Text = "????????????";
            labRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labPayments
            // 
            labPayments.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            labPayments.BackColor = System.Drawing.Color.FromArgb(164, 151, 0);
            labPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            labPayments.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold);
            labPayments.ForeColor = System.Drawing.Color.Black;
            labPayments.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            labPayments.Location = new System.Drawing.Point(413, 15);
            labPayments.Name = "labPayments";
            labPayments.RightToLeft = System.Windows.Forms.RightToLeft.No;
            labPayments.Size = new System.Drawing.Size(114, 36);
            labPayments.TabIndex = 9;
            labPayments.Text = "????????????";
            labPayments.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labRequired
            // 
            labRequired.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            labRequired.BackColor = System.Drawing.Color.FromArgb(109, 100, 0);
            labRequired.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            labRequired.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold);
            labRequired.ForeColor = System.Drawing.Color.Black;
            labRequired.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            labRequired.Location = new System.Drawing.Point(615, 15);
            labRequired.Name = "labRequired";
            labRequired.RightToLeft = System.Windows.Forms.RightToLeft.No;
            labRequired.Size = new System.Drawing.Size(114, 36);
            labRequired.TabIndex = 8;
            labRequired.Text = "????????????";
            labRequired.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(192, 0, 0);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            button1.ForeColor = System.Drawing.Color.White;
            button1.Location = new System.Drawing.Point(12, 15);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(156, 40);
            button1.TabIndex = 6;
            button1.Text = "تنظيف السجل";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnResetDebtAndPayments;
            // 
            // panel11
            // 
            panel11.BackColor = System.Drawing.Color.Gray;
            panel11.Dock = System.Windows.Forms.DockStyle.Right;
            panel11.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            panel11.ForeColor = System.Drawing.Color.Black;
            panel11.Location = new System.Drawing.Point(205, 0);
            panel11.Name = "panel11";
            panel11.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            panel11.Size = new System.Drawing.Size(202, 67);
            panel11.TabIndex = 5;
            panel11.Text = "المتبقي:";
            panel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pannel10
            // 
            pannel10.BackColor = System.Drawing.Color.FromArgb(164, 151, 0);
            pannel10.Dock = System.Windows.Forms.DockStyle.Right;
            pannel10.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            pannel10.ForeColor = System.Drawing.Color.Black;
            pannel10.Location = new System.Drawing.Point(407, 0);
            pannel10.Name = "pannel10";
            pannel10.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            pannel10.Size = new System.Drawing.Size(202, 67);
            pannel10.TabIndex = 3;
            pannel10.Text = "المدفوع:";
            pannel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel9
            // 
            panel9.BackColor = System.Drawing.Color.FromArgb(109, 100, 0);
            panel9.Dock = System.Windows.Forms.DockStyle.Right;
            panel9.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            panel9.ForeColor = System.Drawing.Color.Black;
            panel9.Location = new System.Drawing.Point(609, 0);
            panel9.Name = "panel9";
            panel9.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            panel9.Size = new System.Drawing.Size(202, 67);
            panel9.TabIndex = 2;
            panel9.Text = "المطلوب:";
            panel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labName
            // 
            labName.BackColor = System.Drawing.Color.WhiteSmoke;
            labName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            labName.Dock = System.Windows.Forms.DockStyle.Right;
            labName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            labName.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            labName.ForeColor = System.Drawing.Color.Black;
            labName.Location = new System.Drawing.Point(811, 0);
            labName.Name = "labName";
            labName.Size = new System.Drawing.Size(202, 67);
            labName.TabIndex = 1;
            labName.Text = "اسم العميل";
            labName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.SystemColors.Control;
            panel2.Controls.Add(gridControlClientsDebt);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel4);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1013, 496);
            panel2.TabIndex = 1;
            // 
            // gridControlClientsDebt
            // 
            gridControlClientsDebt.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            gridControlClientsDebt.EmbeddedNavigator.AutoSize = true;
            gridControlClientsDebt.Location = new System.Drawing.Point(478, 38);
            gridControlClientsDebt.MainView = gridViewClientsDebt;
            gridControlClientsDebt.Name = "gridControlClientsDebt";
            gridControlClientsDebt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            gridControlClientsDebt.Size = new System.Drawing.Size(535, 368);
            gridControlClientsDebt.TabIndex = 7;
            gridControlClientsDebt.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewClientsDebt });
            // 
            // gridViewClientsDebt
            // 
            gridViewClientsDebt.Appearance.GroupPanel.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            gridViewClientsDebt.Appearance.GroupPanel.Options.UseFont = true;
            gridViewClientsDebt.Appearance.HeaderPanel.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            gridViewClientsDebt.Appearance.HeaderPanel.Options.UseFont = true;
            gridViewClientsDebt.Appearance.HeaderPanel.Options.UseTextOptions = true;
            gridViewClientsDebt.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridViewClientsDebt.Appearance.Row.Font = new System.Drawing.Font("Cairo", 12F);
            gridViewClientsDebt.Appearance.Row.Options.UseFont = true;
            gridViewClientsDebt.Appearance.Row.Options.UseTextOptions = true;
            gridViewClientsDebt.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridViewClientsDebt.Appearance.TopNewRow.Font = new System.Drawing.Font("Cairo", 12F);
            gridViewClientsDebt.Appearance.TopNewRow.Options.UseFont = true;
            gridViewClientsDebt.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colDebtID, colDebtMenu, colAmountDebt, colDateDebt });
            gridViewClientsDebt.GridControl = gridControlClientsDebt;
            gridViewClientsDebt.Name = "gridViewClientsDebt";
            gridViewClientsDebt.OptionsBehavior.AutoSelectAllInEditor = false;
            gridViewClientsDebt.OptionsBehavior.Editable = false;
            gridViewClientsDebt.OptionsFilter.AllowAutoFilterConditionChange = DevExpress.Utils.DefaultBoolean.False;
            gridViewClientsDebt.OptionsFilter.AllowFilterEditor = false;
            gridViewClientsDebt.OptionsMenu.DialogFormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            gridViewClientsDebt.OptionsMenu.EnableColumnMenu = false;
            gridViewClientsDebt.OptionsMenu.ShowAutoFilterRowItem = false;
            gridViewClientsDebt.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridViewClientsDebt.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full;
            // 
            // colDebtID
            // 
            colDebtID.Caption = "gridColumn1";
            colDebtID.FieldName = "DebMenuID";
            colDebtID.Name = "colDebtID";
            // 
            // colDebtMenu
            // 
            colDebtMenu.Caption = "اسم القائمة";
            colDebtMenu.FieldName = "MenuName";
            colDebtMenu.Name = "colDebtMenu";
            colDebtMenu.Visible = true;
            colDebtMenu.VisibleIndex = 0;
            // 
            // colAmountDebt
            // 
            colAmountDebt.Caption = "المبلغ";
            colAmountDebt.DisplayFormat.FormatString = "n0";
            colAmountDebt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colAmountDebt.FieldName = "Amount";
            colAmountDebt.Name = "colAmountDebt";
            colAmountDebt.Visible = true;
            colAmountDebt.VisibleIndex = 1;
            // 
            // colDateDebt
            // 
            colDateDebt.Caption = "التاريخ";
            colDateDebt.DisplayFormat.FormatString = "yyyy/MM/dd";
            colDateDebt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            colDateDebt.FieldName = "CreatedAt";
            colDateDebt.Name = "colDateDebt";
            colDateDebt.Visible = true;
            colDateDebt.VisibleIndex = 2;
            // 
            // panel6
            // 
            panel6.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel6.BackColor = System.Drawing.Color.Teal;
            panel6.Controls.Add(label4);
            panel6.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            panel6.Location = new System.Drawing.Point(478, -1);
            panel6.Name = "panel6";
            panel6.Size = new System.Drawing.Size(535, 39);
            panel6.TabIndex = 5;
            // 
            // label4
            // 
            label4.AccessibleDescription = "d";
            label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            label4.AutoSize = true;
            label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label4.Font = new System.Drawing.Font("Cairo", 15F, System.Drawing.FontStyle.Bold);
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(244, 1);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(73, 37);
            label4.TabIndex = 1;
            label4.Text = "الديون";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel4.BackColor = System.Drawing.Color.Teal;
            panel4.Controls.Add(btnDeleteDebtMenu);
            panel4.Controls.Add(btnEditDebtMenu);
            panel4.Controls.Add(btnAddDebtMenu);
            panel4.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            panel4.Location = new System.Drawing.Point(478, 407);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(535, 89);
            panel4.TabIndex = 0;
            // 
            // btnDeleteDebtMenu
            // 
            btnDeleteDebtMenu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            btnDeleteDebtMenu.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnDeleteDebtMenu.Appearance.Options.UseFont = true;
            btnDeleteDebtMenu.Appearance.Options.UseTextOptions = true;
            btnDeleteDebtMenu.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            btnDeleteDebtMenu.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            btnDeleteDebtMenu.ImageOptions.Image = Properties.Resources.deletelist_32x32;
            btnDeleteDebtMenu.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            btnDeleteDebtMenu.Location = new System.Drawing.Point(109, 9);
            btnDeleteDebtMenu.Name = "btnDeleteDebtMenu";
            btnDeleteDebtMenu.Size = new System.Drawing.Size(109, 71);
            btnDeleteDebtMenu.TabIndex = 8;
            btnDeleteDebtMenu.Text = "حذف";
            btnDeleteDebtMenu.Click += btnDeleteDebtMenu_Click;
            // 
            // btnEditDebtMenu
            // 
            btnEditDebtMenu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            btnEditDebtMenu.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnEditDebtMenu.Appearance.Options.UseFont = true;
            btnEditDebtMenu.Appearance.Options.UseTextOptions = true;
            btnEditDebtMenu.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            btnEditDebtMenu.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            btnEditDebtMenu.ImageOptions.Image = Properties.Resources.edit_32x32;
            btnEditDebtMenu.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            btnEditDebtMenu.Location = new System.Drawing.Point(221, 9);
            btnEditDebtMenu.Name = "btnEditDebtMenu";
            btnEditDebtMenu.Size = new System.Drawing.Size(109, 71);
            btnEditDebtMenu.TabIndex = 3;
            btnEditDebtMenu.Text = "تتعديل";
            btnEditDebtMenu.Click += btnEditDebtMenu_Click;
            // 
            // btnAddDebtMenu
            // 
            btnAddDebtMenu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            btnAddDebtMenu.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnAddDebtMenu.Appearance.Options.UseFont = true;
            btnAddDebtMenu.Appearance.Options.UseTextOptions = true;
            btnAddDebtMenu.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            btnAddDebtMenu.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            btnAddDebtMenu.ImageOptions.Image = Properties.Resources.add_32x32;
            btnAddDebtMenu.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            btnAddDebtMenu.Location = new System.Drawing.Point(333, 9);
            btnAddDebtMenu.Name = "btnAddDebtMenu";
            btnAddDebtMenu.Size = new System.Drawing.Size(109, 71);
            btnAddDebtMenu.TabIndex = 7;
            btnAddDebtMenu.Text = "اضافة";
            btnAddDebtMenu.Click += btnAddDebtMenu_Click;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.SystemColors.Control;
            panel3.Controls.Add(gridControlClientsPayments);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panel5);
            panel3.Dock = System.Windows.Forms.DockStyle.Left;
            panel3.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            panel3.Location = new System.Drawing.Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(478, 496);
            panel3.TabIndex = 2;
            // 
            // gridControlClientsPayments
            // 
            gridControlClientsPayments.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            gridControlClientsPayments.Location = new System.Drawing.Point(0, 38);
            gridControlClientsPayments.MainView = gridViewClientsPayments;
            gridControlClientsPayments.Name = "gridControlClientsPayments";
            gridControlClientsPayments.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            gridControlClientsPayments.Size = new System.Drawing.Size(478, 368);
            gridControlClientsPayments.TabIndex = 7;
            gridControlClientsPayments.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewClientsPayments });
            // 
            // gridViewClientsPayments
            // 
            gridViewClientsPayments.Appearance.GroupPanel.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            gridViewClientsPayments.Appearance.GroupPanel.Options.UseFont = true;
            gridViewClientsPayments.Appearance.HeaderPanel.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            gridViewClientsPayments.Appearance.HeaderPanel.Options.UseFont = true;
            gridViewClientsPayments.Appearance.HeaderPanel.Options.UseTextOptions = true;
            gridViewClientsPayments.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridViewClientsPayments.Appearance.Row.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            gridViewClientsPayments.Appearance.Row.Options.UseFont = true;
            gridViewClientsPayments.Appearance.Row.Options.UseTextOptions = true;
            gridViewClientsPayments.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridViewClientsPayments.Appearance.TopNewRow.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            gridViewClientsPayments.Appearance.TopNewRow.Options.UseFont = true;
            gridViewClientsPayments.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colPaymentID, colPaymentAmount, colDatePayment });
            gridViewClientsPayments.GridControl = gridControlClientsPayments;
            gridViewClientsPayments.Name = "gridViewClientsPayments";
            gridViewClientsPayments.OptionsBehavior.AutoSelectAllInEditor = false;
            gridViewClientsPayments.OptionsBehavior.Editable = false;
            gridViewClientsPayments.OptionsFilter.AllowAutoFilterConditionChange = DevExpress.Utils.DefaultBoolean.False;
            gridViewClientsPayments.OptionsFilter.AllowFilterEditor = false;
            gridViewClientsPayments.OptionsMenu.DialogFormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            gridViewClientsPayments.OptionsMenu.EnableColumnMenu = false;
            gridViewClientsPayments.OptionsMenu.ShowAutoFilterRowItem = false;
            gridViewClientsPayments.OptionsSelection.EnableAppearanceFocusedCell = false;
            // 
            // colPaymentID
            // 
            colPaymentID.Caption = "gridColumn1";
            colPaymentID.FieldName = "PaymentID";
            colPaymentID.Name = "colPaymentID";
            // 
            // colPaymentAmount
            // 
            colPaymentAmount.Caption = "المبلغ";
            colPaymentAmount.DisplayFormat.FormatString = "n0";
            colPaymentAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colPaymentAmount.FieldName = "Amount";
            colPaymentAmount.Name = "colPaymentAmount";
            colPaymentAmount.Visible = true;
            colPaymentAmount.VisibleIndex = 0;
            // 
            // colDatePayment
            // 
            colDatePayment.Caption = "التاريخ";
            colDatePayment.DisplayFormat.FormatString = "yyyy/MM/dd";
            colDatePayment.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            colDatePayment.FieldName = "CreatedAt";
            colDatePayment.Name = "colDatePayment";
            colDatePayment.Visible = true;
            colDatePayment.VisibleIndex = 1;
            // 
            // panel7
            // 
            panel7.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            panel7.Controls.Add(label6);
            panel7.Dock = System.Windows.Forms.DockStyle.Top;
            panel7.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            panel7.Location = new System.Drawing.Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new System.Drawing.Size(478, 38);
            panel7.TabIndex = 6;
            // 
            // label6
            // 
            label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            label6.Font = new System.Drawing.Font("Cairo", 15F, System.Drawing.FontStyle.Bold);
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(184, 1);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(113, 36);
            label6.TabIndex = 0;
            label6.Text = "التسديد";
            // 
            // panel5
            // 
            panel5.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            panel5.Controls.Add(btnAddPayment);
            panel5.Controls.Add(btnDeletePayment);
            panel5.Controls.Add(btnEditPayment);
            panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel5.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            panel5.Location = new System.Drawing.Point(0, 407);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(478, 89);
            panel5.TabIndex = 0;
            panel5.Paint += panel5_Paint;
            // 
            // btnAddPayment
            // 
            btnAddPayment.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            btnAddPayment.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnAddPayment.Appearance.Options.UseFont = true;
            btnAddPayment.Appearance.Options.UseTextOptions = true;
            btnAddPayment.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            btnAddPayment.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            btnAddPayment.ImageOptions.Image = Properties.Resources.add_32x32;
            btnAddPayment.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            btnAddPayment.Location = new System.Drawing.Point(290, 9);
            btnAddPayment.Name = "btnAddPayment";
            btnAddPayment.Size = new System.Drawing.Size(109, 71);
            btnAddPayment.TabIndex = 4;
            btnAddPayment.Text = "اضافة";
            btnAddPayment.Click += btnAddPayment_Click;
            // 
            // btnDeletePayment
            // 
            btnDeletePayment.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            btnDeletePayment.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnDeletePayment.Appearance.Options.UseFont = true;
            btnDeletePayment.Appearance.Options.UseTextOptions = true;
            btnDeletePayment.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            btnDeletePayment.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            btnDeletePayment.ImageOptions.Image = Properties.Resources.deletelist_32x32;
            btnDeletePayment.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            btnDeletePayment.Location = new System.Drawing.Point(68, 9);
            btnDeletePayment.Name = "btnDeletePayment";
            btnDeletePayment.Size = new System.Drawing.Size(109, 71);
            btnDeletePayment.TabIndex = 5;
            btnDeletePayment.Text = "حذف";
            btnDeletePayment.Click += btnDeletePayment_Click;
            // 
            // btnEditPayment
            // 
            btnEditPayment.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            btnEditPayment.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnEditPayment.Appearance.Options.UseFont = true;
            btnEditPayment.Appearance.Options.UseTextOptions = true;
            btnEditPayment.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            btnEditPayment.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            btnEditPayment.ImageOptions.Image = Properties.Resources.edit_32x32;
            btnEditPayment.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            btnEditPayment.Location = new System.Drawing.Point(179, 9);
            btnEditPayment.Name = "btnEditPayment";
            btnEditPayment.Size = new System.Drawing.Size(109, 71);
            btnEditPayment.TabIndex = 6;
            btnEditPayment.Text = "تتعديل";
            btnEditPayment.Click += btnEditPayment_Click;
            // 
            // frmViewRegisterClient
            // 
            Appearance.BackColor = System.Drawing.Color.LightGray;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1013, 563);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            IconOptions.ShowIcon = false;
            MinimumSize = new System.Drawing.Size(1015, 595);
            Name = "frmViewRegisterClient";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "سجل العميل";
            Load += frmViewRegisterClient_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControlClientsDebt).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewClientsDebt).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControlClientsPayments).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewClientsPayments).EndInit();
            panel7.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label labName;
        private DevExpress.XtraEditors.SimpleButton btnEditDebtMenu;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnDeletePayment;
        private DevExpress.XtraEditors.SimpleButton btnEditPayment;
        private DevExpress.XtraEditors.SimpleButton btnAddDebtMenu;
        private System.Windows.Forms.Label panel11;
        private System.Windows.Forms.Label pannel10;
        private System.Windows.Forms.Label panel9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SimpleButton btnAddPayment;
        private DevExpress.XtraGrid.GridControl gridControlClientsPayments;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewClientsPayments;
        private DevExpress.XtraGrid.GridControl gridControlClientsDebt;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewClientsDebt;
        private System.Windows.Forms.Label labRequired;
        private System.Windows.Forms.Label labRemaining;
        private System.Windows.Forms.Label labPayments;
        private DevExpress.XtraEditors.SimpleButton btnDeleteDebtMenu;
        private DevExpress.XtraGrid.Columns.GridColumn colDebtID;
        private DevExpress.XtraGrid.Columns.GridColumn colDebtMenu;
        private DevExpress.XtraGrid.Columns.GridColumn colAmountDebt;
        private DevExpress.XtraGrid.Columns.GridColumn colDateDebt;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentID;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colDatePayment;
    }
}