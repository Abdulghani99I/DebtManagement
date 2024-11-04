using DebtManagement.AddPAage;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DebtManagement_Business;
using System.Windows.Controls;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using DevExpress.XtraVerticalGrid;
using clsMessageBox;
using DevExpress.DataAccess.Native.ObjectBinding;

namespace DebtManagement.Pages
{
    public partial class ctrlPage_Suppliers : DevExpress.XtraEditors.XtraUserControl
    {
        public ctrlPage_Suppliers()
        {
            InitializeComponent();
        }

        private async void ctrlPage_Suppliers_Load(object sender, EventArgs e)
        {
            await ReloadTableSuppliers();
            SetColumnsName();
        }

        private async Task ReloadTableSuppliers()
        {
            gridSuppliers.DataSource = await clsSupplier.GetAllSuppliersAsync();

            // Hide Column SupplierID.
            if (gridViewSuppliers.RowCount > 0) 
            {
                if (gridViewSuppliers != null)
                    gridViewSuppliers.Columns["SupplierID"].Visible = false;
            }
        }

        private void SetColumnsName()
        {
            //var gridView = gridSuppliers.MainView as DevExpress.XtraGrid.Views.Grid.GridView;

            if (gridViewSuppliers != null && gridViewSuppliers.RowCount > 0)
            {
                // Note: Column "PersonID" Is Hidden.
                gridViewSuppliers.Columns["FullName"].Caption = "اسم المورد";
                gridViewSuppliers.Columns["BalanceDinar"].Caption = "الرصيد (بالعراقي)";
                gridViewSuppliers.Columns["Phone"].Caption = "رقم الهاتف";
                gridViewSuppliers.Columns["Address"].Caption = "العنوان";
                gridViewSuppliers.Columns["CreatedAt"].Caption = "تاريخ الاضافة";
            }
            else
            {
                ShowEmptyTable();
            }
        }

        private void ShowEmptyTable()
        {
            // Add Column SupplierID And Make it (Visible = false).
            DevExpress.XtraGrid.Columns.GridColumn supplierIDColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            //supplierIDColumn.Caption = "رقم المعرف";
            supplierIDColumn.FieldName = "SupplierID";
            supplierIDColumn.Visible = false;
            gridViewSuppliers.Columns.Add(supplierIDColumn);

            // Add Column FullName.
            DevExpress.XtraGrid.Columns.GridColumn supplierNameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            supplierNameColumn.Caption = "اسم المورد";
            supplierNameColumn.FieldName = "FullName"; 
            supplierNameColumn.Visible = true;
            gridViewSuppliers.Columns.Add(supplierNameColumn);

            // Add Column BalanceDinar.
            DevExpress.XtraGrid.Columns.GridColumn balanceColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            balanceColumn.Caption = "الرصيد (بالعراقي)";
            balanceColumn.FieldName = "BalanceDinar"; 
            balanceColumn.Visible = true;
            gridViewSuppliers.Columns.Add(balanceColumn);

            // Add Column Phone.
            DevExpress.XtraGrid.Columns.GridColumn phoneColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            phoneColumn.Caption = "رقم الهاتف";
            phoneColumn.FieldName = "Phone";
            phoneColumn.Visible = true;
            gridViewSuppliers.Columns.Add(phoneColumn);

            // Add Column Address.
            DevExpress.XtraGrid.Columns.GridColumn addressColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            addressColumn.Caption = "العنوان";
            addressColumn.FieldName = "Address"; 
            addressColumn.Visible = true;
            gridViewSuppliers.Columns.Add(addressColumn);

            // Add Column CreatedAt.
            DevExpress.XtraGrid.Columns.GridColumn addedDateColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            addedDateColumn.Caption = "تاريخ الاضافة";
            addedDateColumn.FieldName = "CreatedAt";
            addedDateColumn.Visible = true;
            gridViewSuppliers.Columns.Add(addedDateColumn);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUpdateSupplier frm = new frmAddUpdateSupplier();
            frm.RefreshTable += ReloadTableSuppliers;
            frm.ShowDialog();

            //await ReloadTableSuppliers();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Select Current SupplerID.
            int SupplerID = -1;

            if (gridViewSuppliers != null && gridViewSuppliers.FocusedRowHandle >= 0)
            {
                SupplerID = Convert.ToInt32(gridViewSuppliers.GetRowCellValue(gridViewSuppliers.FocusedRowHandle, "SupplierID"));
            }
            else
            {
                // In This Case No Rows In Table.
                frmMessageBox.ShowDialog("الرجاء قم بتحديد المورد اولاً", "خطا", "حسنا");
                return;
            }

            frmAddUpdateSupplier frm = new frmAddUpdateSupplier(SupplerID);
            frm.RefreshTable += ReloadTableSuppliers;
            frm.ShowDialog();

            //await ReloadTableSuppliers();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            await ReloadTableSuppliers();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            // Select Current "Name Suppler" And "SupplierID".
            string SupplerName = string.Empty;
            int SupplierID = -1;

            var view = gridSuppliers.FocusedView as DevExpress.XtraGrid.Views.Grid.GridView;

            if (view != null && view.FocusedRowHandle >= 0) {
                SupplerName = (view.GetRowCellValue(view.FocusedRowHandle, "FullName")).ToString();
                SupplierID = Convert.ToInt32(view.GetRowCellValue(view.FocusedRowHandle, "SupplierID"));
            }
            else
            {
                // In This Case No Rows In Table.
                frmMessageBox.ShowDialog("الرجاء قم بتحديد المورد اولاً", "خطا", "حسنا");
                return;
            }

            if (frmMessageBox.ShowDialog($"هل تريد حذف المورد [{SupplerName}]", "تحذير", "نعم", "لا") == DialogResult.Yes)
            {
                bool result = await clsSupplier.DeleteSupplierAsync(SupplierID);

                if (result)
                {
                    await ReloadTableSuppliers();
                    frmMessageBox.ShowDialog($"تم حذف المورد [{SupplerName}] بنجاح", "معلومة", "حسنا");
                }
                else
                {
                    frmMessageBox.ShowDialog("حدث خطأ ما اثناء الحذف", "خطا", "حسنا");
                }
            }
        }
        
        private async void btnShowRgistry_Click(object sender, EventArgs e)
        {
            frmViewRegister frm = new frmViewRegister();

            frm.ShowDialog();

            await ReloadTableSuppliers();
        }
    }
}