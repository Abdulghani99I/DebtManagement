namespace DebtManagement.Pages
{
    partial class ctrlPage_Clients
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlPage_Clients));
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            btnShowRgistry = new DevExpress.XtraEditors.SimpleButton();
            btnPrint = new DevExpress.XtraEditors.SimpleButton();
            btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            btnDelete = new DevExpress.XtraEditors.SimpleButton();
            btnEdit = new DevExpress.XtraEditors.SimpleButton();
            btnAdd = new DevExpress.XtraEditors.SimpleButton();
            gridClients = new DevExpress.XtraGrid.GridControl();
            gridViewClients = new DevExpress.XtraGrid.Views.Grid.GridView();
            colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            colBalanceDinar = new DevExpress.XtraGrid.Columns.GridColumn();
            colBalanceDollar = new DevExpress.XtraGrid.Columns.GridColumn();
            colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            colCreatedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridClients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewClients).BeginInit();
            SuspendLayout();
            // 
            // panelControl1
            // 
            panelControl1.Appearance.BackColor = System.Drawing.Color.DarkGray;
            panelControl1.Appearance.Options.UseBackColor = true;
            panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            panelControl1.Controls.Add(btnShowRgistry);
            panelControl1.Controls.Add(btnPrint);
            panelControl1.Controls.Add(btnRefresh);
            panelControl1.Controls.Add(btnDelete);
            panelControl1.Controls.Add(btnEdit);
            panelControl1.Controls.Add(btnAdd);
            panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelControl1.Location = new System.Drawing.Point(0, 458);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(854, 100);
            panelControl1.TabIndex = 2;
            // 
            // btnShowRgistry
            // 
            btnShowRgistry.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnShowRgistry.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnShowRgistry.Appearance.Options.UseFont = true;
            btnShowRgistry.Appearance.Options.UseTextOptions = true;
            btnShowRgistry.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            btnShowRgistry.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            btnShowRgistry.ImageOptions.Image = Properties.Resources.calendar_32x32;
            btnShowRgistry.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            btnShowRgistry.Location = new System.Drawing.Point(70, 12);
            btnShowRgistry.Name = "btnShowRgistry";
            btnShowRgistry.Size = new System.Drawing.Size(159, 76);
            btnShowRgistry.TabIndex = 8;
            btnShowRgistry.Text = "عرض السجل";
            btnShowRgistry.Click += btnShowRgistry_Click;
            // 
            // btnPrint
            // 
            btnPrint.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnPrint.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnPrint.Appearance.Options.UseFont = true;
            btnPrint.Appearance.Options.UseTextOptions = true;
            btnPrint.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            btnPrint.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            btnPrint.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnPrint.ImageOptions.Image");
            btnPrint.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            btnPrint.Location = new System.Drawing.Point(234, 12);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new System.Drawing.Size(106, 76);
            btnPrint.TabIndex = 9;
            btnPrint.Text = "طباعة";
            btnPrint.Click += btnPrint_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnRefresh.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnRefresh.Appearance.Options.UseFont = true;
            btnRefresh.Appearance.Options.UseTextOptions = true;
            btnRefresh.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            btnRefresh.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            btnRefresh.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnRefresh.ImageOptions.Image");
            btnRefresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            btnRefresh.Location = new System.Drawing.Point(345, 12);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new System.Drawing.Size(106, 76);
            btnRefresh.TabIndex = 10;
            btnRefresh.Text = "تحديث";
            btnRefresh.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnDelete.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnDelete.Appearance.Options.UseFont = true;
            btnDelete.Appearance.Options.UseTextOptions = true;
            btnDelete.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            btnDelete.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            btnDelete.ImageOptions.Image = Properties.Resources.deletelist_32x32;
            btnDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            btnDelete.Location = new System.Drawing.Point(456, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(106, 76);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "حذف";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnEdit.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnEdit.Appearance.Options.UseFont = true;
            btnEdit.Appearance.Options.UseTextOptions = true;
            btnEdit.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            btnEdit.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            btnEdit.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnEdit.ImageOptions.Image");
            btnEdit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            btnEdit.Location = new System.Drawing.Point(567, 12);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(106, 76);
            btnEdit.TabIndex = 12;
            btnEdit.Text = "تتعديل";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnAdd.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnAdd.Appearance.Options.UseFont = true;
            btnAdd.Appearance.Options.UseTextOptions = true;
            btnAdd.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            btnAdd.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            btnAdd.ImageOptions.Image = Properties.Resources.add_32x32;
            btnAdd.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            btnAdd.Location = new System.Drawing.Point(678, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(106, 76);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "اضافة";
            btnAdd.Click += btnAdd_Click;
            // 
            // gridClients
            // 
            gridClients.Dock = System.Windows.Forms.DockStyle.Fill;
            gridClients.Location = new System.Drawing.Point(0, 0);
            gridClients.MainView = gridViewClients;
            gridClients.Name = "gridClients";
            gridClients.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            gridClients.Size = new System.Drawing.Size(854, 458);
            gridClients.TabIndex = 3;
            gridClients.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewClients });
            // 
            // gridViewClients
            // 
            gridViewClients.Appearance.GroupPanel.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            gridViewClients.Appearance.GroupPanel.Options.UseFont = true;
            gridViewClients.Appearance.HeaderPanel.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            gridViewClients.Appearance.HeaderPanel.Options.UseFont = true;
            gridViewClients.Appearance.HeaderPanel.Options.UseTextOptions = true;
            gridViewClients.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridViewClients.Appearance.Row.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            gridViewClients.Appearance.Row.Options.UseFont = true;
            gridViewClients.Appearance.Row.Options.UseTextOptions = true;
            gridViewClients.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridViewClients.Appearance.TopNewRow.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            gridViewClients.Appearance.TopNewRow.Options.UseFont = true;
            gridViewClients.AppearancePrint.EvenRow.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            gridViewClients.AppearancePrint.EvenRow.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            gridViewClients.AppearancePrint.EvenRow.Options.UseBackColor = true;
            gridViewClients.AppearancePrint.EvenRow.Options.UseFont = true;
            gridViewClients.AppearancePrint.EvenRow.Options.UseTextOptions = true;
            gridViewClients.AppearancePrint.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridViewClients.AppearancePrint.FilterPanel.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            gridViewClients.AppearancePrint.FilterPanel.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            gridViewClients.AppearancePrint.FilterPanel.Options.UseBackColor = true;
            gridViewClients.AppearancePrint.FilterPanel.Options.UseFont = true;
            gridViewClients.AppearancePrint.FilterPanel.Options.UseTextOptions = true;
            gridViewClients.AppearancePrint.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridViewClients.AppearancePrint.FooterPanel.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            gridViewClients.AppearancePrint.FooterPanel.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            gridViewClients.AppearancePrint.FooterPanel.Options.UseBackColor = true;
            gridViewClients.AppearancePrint.FooterPanel.Options.UseFont = true;
            gridViewClients.AppearancePrint.FooterPanel.Options.UseTextOptions = true;
            gridViewClients.AppearancePrint.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridViewClients.AppearancePrint.GroupFooter.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            gridViewClients.AppearancePrint.GroupFooter.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            gridViewClients.AppearancePrint.GroupFooter.Options.UseBackColor = true;
            gridViewClients.AppearancePrint.GroupFooter.Options.UseFont = true;
            gridViewClients.AppearancePrint.GroupFooter.Options.UseTextOptions = true;
            gridViewClients.AppearancePrint.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridViewClients.AppearancePrint.GroupRow.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            gridViewClients.AppearancePrint.GroupRow.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            gridViewClients.AppearancePrint.GroupRow.Options.UseBackColor = true;
            gridViewClients.AppearancePrint.GroupRow.Options.UseFont = true;
            gridViewClients.AppearancePrint.GroupRow.Options.UseTextOptions = true;
            gridViewClients.AppearancePrint.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridViewClients.AppearancePrint.HeaderPanel.BackColor = System.Drawing.Color.Gray;
            gridViewClients.AppearancePrint.HeaderPanel.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            gridViewClients.AppearancePrint.HeaderPanel.Options.UseBackColor = true;
            gridViewClients.AppearancePrint.HeaderPanel.Options.UseFont = true;
            gridViewClients.AppearancePrint.HeaderPanel.Options.UseTextOptions = true;
            gridViewClients.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridViewClients.AppearancePrint.Lines.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            gridViewClients.AppearancePrint.Lines.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            gridViewClients.AppearancePrint.Lines.ForeColor = System.Drawing.Color.Black;
            gridViewClients.AppearancePrint.Lines.Options.UseBackColor = true;
            gridViewClients.AppearancePrint.Lines.Options.UseFont = true;
            gridViewClients.AppearancePrint.Lines.Options.UseForeColor = true;
            gridViewClients.AppearancePrint.Lines.Options.UseTextOptions = true;
            gridViewClients.AppearancePrint.Lines.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridViewClients.AppearancePrint.OddRow.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            gridViewClients.AppearancePrint.OddRow.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            gridViewClients.AppearancePrint.OddRow.Options.UseBackColor = true;
            gridViewClients.AppearancePrint.OddRow.Options.UseFont = true;
            gridViewClients.AppearancePrint.OddRow.Options.UseTextOptions = true;
            gridViewClients.AppearancePrint.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridViewClients.AppearancePrint.Preview.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            gridViewClients.AppearancePrint.Preview.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            gridViewClients.AppearancePrint.Preview.Options.UseBackColor = true;
            gridViewClients.AppearancePrint.Preview.Options.UseFont = true;
            gridViewClients.AppearancePrint.Preview.Options.UseTextOptions = true;
            gridViewClients.AppearancePrint.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridViewClients.AppearancePrint.Row.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            gridViewClients.AppearancePrint.Row.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            gridViewClients.AppearancePrint.Row.Options.UseBackColor = true;
            gridViewClients.AppearancePrint.Row.Options.UseFont = true;
            gridViewClients.AppearancePrint.Row.Options.UseTextOptions = true;
            gridViewClients.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridViewClients.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colFullName, colBalanceDinar, colBalanceDollar, colPhone, colAddress, colCreatedAt });
            gridViewClients.GridControl = gridClients;
            gridViewClients.Name = "gridViewClients";
            gridViewClients.OptionsBehavior.AutoSelectAllInEditor = false;
            gridViewClients.OptionsBehavior.Editable = false;
            gridViewClients.OptionsFilter.AllowAutoFilterConditionChange = DevExpress.Utils.DefaultBoolean.False;
            gridViewClients.OptionsFilter.AllowFilterEditor = false;
            gridViewClients.OptionsMenu.DialogFormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            gridViewClients.OptionsMenu.EnableColumnMenu = false;
            gridViewClients.OptionsMenu.ShowAutoFilterRowItem = false;
            gridViewClients.OptionsPrint.EnableAppearanceOddRow = true;
            gridViewClients.OptionsSelection.EnableAppearanceFocusedCell = false;
            // 
            // colFullName
            // 
            colFullName.Caption = "أسم العميل";
            colFullName.FieldName = "FullName";
            colFullName.Name = "colFullName";
            colFullName.Visible = true;
            colFullName.VisibleIndex = 0;
            // 
            // colBalanceDinar
            // 
            colBalanceDinar.Caption = "الرصيد بالعراقي";
            colBalanceDinar.DisplayFormat.FormatString = "n0";
            colBalanceDinar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colBalanceDinar.FieldName = "BalanceDinar";
            colBalanceDinar.Name = "colBalanceDinar";
            colBalanceDinar.Visible = true;
            colBalanceDinar.VisibleIndex = 1;
            // 
            // colBalanceDollar
            // 
            colBalanceDollar.Caption = "الرصيد بالدولار";
            colBalanceDollar.DisplayFormat.FormatString = "n2";
            colBalanceDollar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colBalanceDollar.FieldName = "BalanceDollar";
            colBalanceDollar.Name = "colBalanceDollar";
            colBalanceDollar.Visible = true;
            colBalanceDollar.VisibleIndex = 2;
            // 
            // colPhone
            // 
            colPhone.Caption = "رقم الهاتف";
            colPhone.FieldName = "Phone";
            colPhone.Name = "colPhone";
            colPhone.Visible = true;
            colPhone.VisibleIndex = 3;
            // 
            // colAddress
            // 
            colAddress.Caption = "العنوان";
            colAddress.FieldName = "Address";
            colAddress.Name = "colAddress";
            colAddress.Visible = true;
            colAddress.VisibleIndex = 4;
            // 
            // colCreatedAt
            // 
            colCreatedAt.Caption = "تاريخ الاضافة";
            colCreatedAt.DisplayFormat.FormatString = "yyyy/MM/dd";
            colCreatedAt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            colCreatedAt.FieldName = "CreatedAt";
            colCreatedAt.Name = "colCreatedAt";
            colCreatedAt.Visible = true;
            colCreatedAt.VisibleIndex = 5;
            // 
            // ctrlPage_Clients
            // 
            Appearance.BackColor = System.Drawing.Color.White;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(gridClients);
            Controls.Add(panelControl1);
            Name = "ctrlPage_Clients";
            Size = new System.Drawing.Size(854, 558);
            Load += ctrlPage_Clients_Load;
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridClients).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewClients).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridClients;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewClients;
        private DevExpress.XtraEditors.SimpleButton btnShowRgistry;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colBalanceDinar;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedAt;
        private DevExpress.XtraGrid.Columns.GridColumn colBalanceDollar;
    }
}
