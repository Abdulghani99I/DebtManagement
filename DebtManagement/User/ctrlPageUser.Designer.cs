namespace DebtManagement
{
    partial class ctrlPageUser
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
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            btnDelete = new DevExpress.XtraEditors.SimpleButton();
            btnEdit = new DevExpress.XtraEditors.SimpleButton();
            btnAdd = new DevExpress.XtraEditors.SimpleButton();
            colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            colPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            gridUsers = new DevExpress.XtraGrid.GridControl();
            gridViewUsers = new DevExpress.XtraGrid.Views.Grid.GridView();
            columnFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            columnUserNamew = new DevExpress.XtraGrid.Columns.GridColumn();
            columnPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            colUserType = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewUsers).BeginInit();
            SuspendLayout();
            // 
            // panelControl1
            // 
            panelControl1.Appearance.BackColor = System.Drawing.Color.Silver;
            panelControl1.Appearance.Options.UseBackColor = true;
            panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            panelControl1.Controls.Add(btnRefresh);
            panelControl1.Controls.Add(btnDelete);
            panelControl1.Controls.Add(btnEdit);
            panelControl1.Controls.Add(btnAdd);
            panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelControl1.Location = new System.Drawing.Point(0, 451);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(844, 100);
            panelControl1.TabIndex = 3;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnRefresh.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnRefresh.Appearance.Options.UseFont = true;
            btnRefresh.Appearance.Options.UseTextOptions = true;
            btnRefresh.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            btnRefresh.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            btnRefresh.ImageOptions.Image = Properties.Resources.refresh_32x32;
            btnRefresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            btnRefresh.Location = new System.Drawing.Point(203, 13);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new System.Drawing.Size(106, 76);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "تحديث";
            btnRefresh.Click += btnRefresh_Click;
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
            btnDelete.Location = new System.Drawing.Point(314, 13);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(106, 76);
            btnDelete.TabIndex = 5;
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
            btnEdit.ImageOptions.Image = Properties.Resources.edit_32x32;
            btnEdit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            btnEdit.Location = new System.Drawing.Point(425, 13);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(106, 76);
            btnEdit.TabIndex = 6;
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
            btnAdd.Location = new System.Drawing.Point(536, 13);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(106, 76);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "اضافة";
            btnAdd.Click += btnAdd_Click;
            // 
            // colUserName
            // 
            colUserName.Name = "colUserName";
            // 
            // colPassword
            // 
            colPassword.Name = "colPassword";
            // 
            // gridUsers
            // 
            gridUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            gridUsers.Location = new System.Drawing.Point(0, 0);
            gridUsers.MainView = gridViewUsers;
            gridUsers.Name = "gridUsers";
            gridUsers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            gridUsers.Size = new System.Drawing.Size(844, 451);
            gridUsers.TabIndex = 4;
            gridUsers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewUsers });
            // 
            // gridViewUsers
            // 
            gridViewUsers.Appearance.GroupPanel.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            gridViewUsers.Appearance.GroupPanel.Options.UseFont = true;
            gridViewUsers.Appearance.HeaderPanel.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            gridViewUsers.Appearance.HeaderPanel.Options.UseFont = true;
            gridViewUsers.Appearance.HeaderPanel.Options.UseTextOptions = true;
            gridViewUsers.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridViewUsers.Appearance.Row.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            gridViewUsers.Appearance.Row.Options.UseFont = true;
            gridViewUsers.Appearance.Row.Options.UseTextOptions = true;
            gridViewUsers.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridViewUsers.Appearance.TopNewRow.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            gridViewUsers.Appearance.TopNewRow.Options.UseFont = true;
            gridViewUsers.AppearancePrint.EvenRow.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            gridViewUsers.AppearancePrint.EvenRow.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            gridViewUsers.AppearancePrint.EvenRow.Options.UseBackColor = true;
            gridViewUsers.AppearancePrint.EvenRow.Options.UseFont = true;
            gridViewUsers.AppearancePrint.EvenRow.Options.UseTextOptions = true;
            gridViewUsers.AppearancePrint.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridViewUsers.AppearancePrint.FilterPanel.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            gridViewUsers.AppearancePrint.FilterPanel.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            gridViewUsers.AppearancePrint.FilterPanel.Options.UseBackColor = true;
            gridViewUsers.AppearancePrint.FilterPanel.Options.UseFont = true;
            gridViewUsers.AppearancePrint.FilterPanel.Options.UseTextOptions = true;
            gridViewUsers.AppearancePrint.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridViewUsers.AppearancePrint.FooterPanel.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            gridViewUsers.AppearancePrint.FooterPanel.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            gridViewUsers.AppearancePrint.FooterPanel.Options.UseBackColor = true;
            gridViewUsers.AppearancePrint.FooterPanel.Options.UseFont = true;
            gridViewUsers.AppearancePrint.FooterPanel.Options.UseTextOptions = true;
            gridViewUsers.AppearancePrint.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridViewUsers.AppearancePrint.GroupFooter.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            gridViewUsers.AppearancePrint.GroupFooter.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            gridViewUsers.AppearancePrint.GroupFooter.Options.UseBackColor = true;
            gridViewUsers.AppearancePrint.GroupFooter.Options.UseFont = true;
            gridViewUsers.AppearancePrint.GroupFooter.Options.UseTextOptions = true;
            gridViewUsers.AppearancePrint.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridViewUsers.AppearancePrint.GroupRow.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            gridViewUsers.AppearancePrint.GroupRow.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            gridViewUsers.AppearancePrint.GroupRow.Options.UseBackColor = true;
            gridViewUsers.AppearancePrint.GroupRow.Options.UseFont = true;
            gridViewUsers.AppearancePrint.GroupRow.Options.UseTextOptions = true;
            gridViewUsers.AppearancePrint.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridViewUsers.AppearancePrint.HeaderPanel.BackColor = System.Drawing.Color.Gray;
            gridViewUsers.AppearancePrint.HeaderPanel.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            gridViewUsers.AppearancePrint.HeaderPanel.Options.UseBackColor = true;
            gridViewUsers.AppearancePrint.HeaderPanel.Options.UseFont = true;
            gridViewUsers.AppearancePrint.HeaderPanel.Options.UseTextOptions = true;
            gridViewUsers.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridViewUsers.AppearancePrint.Lines.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            gridViewUsers.AppearancePrint.Lines.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            gridViewUsers.AppearancePrint.Lines.ForeColor = System.Drawing.Color.Black;
            gridViewUsers.AppearancePrint.Lines.Options.UseBackColor = true;
            gridViewUsers.AppearancePrint.Lines.Options.UseFont = true;
            gridViewUsers.AppearancePrint.Lines.Options.UseForeColor = true;
            gridViewUsers.AppearancePrint.Lines.Options.UseTextOptions = true;
            gridViewUsers.AppearancePrint.Lines.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridViewUsers.AppearancePrint.OddRow.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            gridViewUsers.AppearancePrint.OddRow.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            gridViewUsers.AppearancePrint.OddRow.Options.UseBackColor = true;
            gridViewUsers.AppearancePrint.OddRow.Options.UseFont = true;
            gridViewUsers.AppearancePrint.OddRow.Options.UseTextOptions = true;
            gridViewUsers.AppearancePrint.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridViewUsers.AppearancePrint.Preview.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            gridViewUsers.AppearancePrint.Preview.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            gridViewUsers.AppearancePrint.Preview.Options.UseBackColor = true;
            gridViewUsers.AppearancePrint.Preview.Options.UseFont = true;
            gridViewUsers.AppearancePrint.Preview.Options.UseTextOptions = true;
            gridViewUsers.AppearancePrint.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridViewUsers.AppearancePrint.Row.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            gridViewUsers.AppearancePrint.Row.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            gridViewUsers.AppearancePrint.Row.Options.UseBackColor = true;
            gridViewUsers.AppearancePrint.Row.Options.UseFont = true;
            gridViewUsers.AppearancePrint.Row.Options.UseTextOptions = true;
            gridViewUsers.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridViewUsers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { columnFullName, columnUserNamew, columnPassword, colUserType });
            gridViewUsers.GridControl = gridUsers;
            gridViewUsers.Name = "gridViewUsers";
            gridViewUsers.OptionsBehavior.AutoSelectAllInEditor = false;
            gridViewUsers.OptionsBehavior.Editable = false;
            gridViewUsers.OptionsFilter.AllowAutoFilterConditionChange = DevExpress.Utils.DefaultBoolean.False;
            gridViewUsers.OptionsFilter.AllowFilterEditor = false;
            gridViewUsers.OptionsMenu.DialogFormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            gridViewUsers.OptionsMenu.EnableColumnMenu = false;
            gridViewUsers.OptionsMenu.ShowAutoFilterRowItem = false;
            gridViewUsers.OptionsPrint.EnableAppearanceEvenRow = true;
            gridViewUsers.OptionsPrint.EnableAppearanceOddRow = true;
            gridViewUsers.OptionsPrint.PrintHorzLines = false;
            gridViewUsers.OptionsSelection.EnableAppearanceFocusedCell = false;
            // 
            // columnFullName
            // 
            columnFullName.Caption = "الاسم الكامل";
            columnFullName.FieldName = "FullName";
            columnFullName.Name = "columnFullName";
            columnFullName.Visible = true;
            columnFullName.VisibleIndex = 0;
            // 
            // columnUserNamew
            // 
            columnUserNamew.Caption = "اسم المستخدم";
            columnUserNamew.FieldName = "UserName";
            columnUserNamew.Name = "columnUserNamew";
            columnUserNamew.Visible = true;
            columnUserNamew.VisibleIndex = 1;
            // 
            // columnPassword
            // 
            columnPassword.Caption = "كلمة المرور";
            columnPassword.FieldName = "Password";
            columnPassword.Name = "columnPassword";
            columnPassword.Visible = true;
            columnPassword.VisibleIndex = 2;
            // 
            // colUserType
            // 
            colUserType.Caption = "الصلاحية";
            colUserType.FieldName = "UserType";
            colUserType.Name = "colUserType";
            colUserType.Visible = true;
            colUserType.VisibleIndex = 3;
            // 
            // ctrlPageUser
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(gridUsers);
            Controls.Add(panelControl1);
            Name = "ctrlPageUser";
            Size = new System.Drawing.Size(844, 551);
            Load += ctrlPageUser_Load;
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraGrid.Columns.GridColumn columnFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colPassword;
        private DevExpress.XtraGrid.GridControl gridUsers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewUsers;
        private DevExpress.XtraGrid.Columns.GridColumn columnUserNamew;
        private DevExpress.XtraGrid.Columns.GridColumn columnPassword;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraGrid.Columns.GridColumn colUserType;
    }
}
