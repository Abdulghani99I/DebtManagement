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
using DevExpressInternal = DevExpress.Utils.CommonDialogs.Internal;
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraReports.UI;
using DebtManagement.Supplier;


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
        }

        private async Task ReloadTableSuppliers()
        {
            gridSuppliers.DataSource = await clsSupplier.GetAllSuppliersAsync();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUpdateSupplier frm = new frmAddUpdateSupplier();
            frm.RefreshTable += ReloadTableSuppliers;
            frm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int SupplerID = -1;

            if (gridViewSuppliers != null && gridViewSuppliers.FocusedRowHandle >= 0)
            {
                SupplerID = Convert.ToInt32(gridViewSuppliers.GetRowCellValue(gridViewSuppliers.FocusedRowHandle, "SupplierID"));
            }
            else
            {
                // In This Case No Rows In Table.
                frmMessageBoxDev.ShowDialog("الرجاء قم بتحديد المورد اولاً", "خطا", "حسنا", frmMessageBoxDev.ModeDialog.Error);
                return;
            }

            frmAddUpdateSupplier frm = new frmAddUpdateSupplier(SupplerID);
            frm.RefreshTable += ReloadTableSuppliers;
            frm.ShowDialog();

        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            // Select Current "Name Suppler" And "SupplierID".
            string SupplerName = string.Empty;
            int SupplierID = -1;


            if (gridViewSuppliers != null && gridViewSuppliers.FocusedRowHandle >= 0)
            {
                SupplerName = (gridViewSuppliers.GetRowCellValue(gridViewSuppliers.FocusedRowHandle, "FullName")).ToString();
                SupplierID = Convert.ToInt32(gridViewSuppliers.GetRowCellValue(gridViewSuppliers.FocusedRowHandle, "SupplierID"));
            }
            else
            {
                // In This Case No Rows In Table.
                frmMessageBoxDev.ShowDialog("الرجاء قم بتحديد المورد اولاً", "خطا", "حسنا", frmMessageBoxDev.ModeDialog.Error);
                return;
            }

            if (frmMessageBoxDev.ShowDialog($"هل تريد حذف المورد [{SupplerName}]", "تحذير", "حذف", "الغاء", frmMessageBoxDev.ModeDialog.Question) == DevExpressInternal.DialogResult.Yes)
            {
                bool result = await clsSupplier.DeleteSupplierAsync(SupplierID);

                if (result)
                {
                    await ReloadTableSuppliers();
                    frmMessageBoxDev.ShowDialog($"تم حذف المورد [{SupplerName}] بنجاح", "معلومة", "حسنا", frmMessageBoxDev.ModeDialog.Information);
                }
                else
                {
                    frmMessageBoxDev.ShowDialog("حدث خطأ ما اثناء الحذف تاكد من تنظيف سجل المورد", "خطا", "حسنا", frmMessageBoxDev.ModeDialog.Error);
                }
            }
        }

        private async void btnShowRgistry_Click(object sender, EventArgs e)
        {
            int SupplerID = -1;

            if (gridViewSuppliers != null && gridViewSuppliers.FocusedRowHandle >= 0)
            {
                SupplerID = Convert.ToInt32(gridViewSuppliers.GetRowCellValue(gridViewSuppliers.FocusedRowHandle, "SupplierID"));
            }


            frmViewRegisterSupplier frm = new frmViewRegisterSupplier(SupplerID);

            frm.ShowDialog();

            await ReloadTableSuppliers();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            gridViewSuppliers.ShowPrintPreview();
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await ReloadTableSuppliers();
        }
    }
}