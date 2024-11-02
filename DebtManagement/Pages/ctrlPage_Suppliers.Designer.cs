namespace DebtManagement.Pages
{
    partial class ctrlPage_Suppliers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlPage_Suppliers));
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            btnShowRgistry = new DevExpress.XtraEditors.SimpleButton();
            btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            btnDelete = new DevExpress.XtraEditors.SimpleButton();
            btnEdit = new DevExpress.XtraEditors.SimpleButton();
            btnAdd = new DevExpress.XtraEditors.SimpleButton();
            gridSuppliers = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridSuppliers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // panelControl1
            // 
            panelControl1.Appearance.BackColor = System.Drawing.Color.Silver;
            panelControl1.Appearance.Options.UseBackColor = true;
            panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            panelControl1.Controls.Add(btnShowRgistry);
            panelControl1.Controls.Add(btnUpdate);
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
            btnShowRgistry.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            btnShowRgistry.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnShowRgistry.ImageOptions.SvgImage");
            btnShowRgistry.Location = new System.Drawing.Point(77, 11);
            btnShowRgistry.Name = "btnShowRgistry";
            btnShowRgistry.Size = new System.Drawing.Size(193, 77);
            btnShowRgistry.TabIndex = 1;
            btnShowRgistry.Text = "عرض السجل";
            btnShowRgistry.Click += btnShowRgistry_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnUpdate.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnUpdate.Appearance.Options.UseFont = true;
            btnUpdate.Appearance.Options.UseTextOptions = true;
            btnUpdate.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            btnUpdate.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            btnUpdate.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            btnUpdate.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnUpdate.ImageOptions.SvgImage");
            btnUpdate.Location = new System.Drawing.Point(276, 11);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(121, 77);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "تحديث";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnDelete.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnDelete.Appearance.Options.UseFont = true;
            btnDelete.Appearance.Options.UseTextOptions = true;
            btnDelete.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            btnDelete.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            btnDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            btnDelete.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnDelete.ImageOptions.SvgImage");
            btnDelete.Location = new System.Drawing.Point(403, 11);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(121, 77);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "حذف";
            // 
            // btnEdit
            // 
            btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnEdit.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnEdit.Appearance.Options.UseFont = true;
            btnEdit.Appearance.Options.UseTextOptions = true;
            btnEdit.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            btnEdit.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            btnEdit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            btnEdit.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnEdit.ImageOptions.SvgImage");
            btnEdit.Location = new System.Drawing.Point(530, 11);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(121, 77);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "تتعديل";
            // 
            // btnAdd
            // 
            btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnAdd.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnAdd.Appearance.Options.UseFont = true;
            btnAdd.Appearance.Options.UseTextOptions = true;
            btnAdd.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            btnAdd.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            btnAdd.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            btnAdd.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnAdd.ImageOptions.SvgImage");
            btnAdd.Location = new System.Drawing.Point(657, 11);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(121, 77);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "اضافة";
            btnAdd.Click += btnAdd_Click;
            // 
            // gridSuppliers
            // 
            gridSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            gridSuppliers.Location = new System.Drawing.Point(0, 0);
            gridSuppliers.MainView = gridView1;
            gridSuppliers.Name = "gridSuppliers";
            gridSuppliers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            gridSuppliers.Size = new System.Drawing.Size(854, 458);
            gridSuppliers.TabIndex = 3;
            gridSuppliers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Appearance.GroupPanel.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            gridView1.Appearance.GroupPanel.Options.UseFont = true;
            gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Appearance.Row.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            gridView1.Appearance.Row.Options.UseFont = true;
            gridView1.Appearance.Row.Options.UseTextOptions = true;
            gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Appearance.TopNewRow.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            gridView1.Appearance.TopNewRow.Options.UseFont = true;
            gridView1.GridControl = gridSuppliers;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.AutoSelectAllInEditor = false;
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsFilter.AllowAutoFilterConditionChange = DevExpress.Utils.DefaultBoolean.False;
            gridView1.OptionsFilter.AllowFilterEditor = false;
            gridView1.OptionsMenu.DialogFormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            gridView1.OptionsMenu.EnableColumnMenu = false;
            gridView1.OptionsMenu.ShowAutoFilterRowItem = false;
            gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            // 
            // ctrlPage_Suppliers
            // 
            Appearance.BackColor = System.Drawing.Color.White;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(gridSuppliers);
            Controls.Add(panelControl1);
            Name = "ctrlPage_Suppliers";
            Size = new System.Drawing.Size(854, 558);
            Load += ctrlPage_Suppliers_Load;
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridSuppliers).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnShowRgistry;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraGrid.GridControl gridSuppliers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
