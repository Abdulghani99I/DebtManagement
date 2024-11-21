using clsMessageBox;
using DebtManagement.Supplier;
using DebtManagement.SupplierForms;
using DebtManagement_Business;
using DebtManagement_Data;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using DevExpressInternal = DevExpress.Utils.CommonDialogs.Internal;


namespace DebtManagement
{
    public partial class frmViewRegisterSupplier : XtraForm
    {
        private int _SupplierID = -1;

        public frmViewRegisterSupplier(int SupplerID)
        {
            InitializeComponent();
            _SupplierID = SupplerID;
        }

        private async void frmViewRegisterSupplier_Load(object sender, EventArgs e)
        {
            await RefreshForm();
        }

        private void SetInfoSupplier()
        {
            Decimal TotalRequired = 0, TotalPayments = 0;

            // Set up summary Amount On Table SuppliersDebt.
            if (gridViewSuppliersDebt.RowCount > 0)
            {
                gridViewSuppliersDebt.Columns["Amount"].Summary.Clear();
                gridViewSuppliersDebt.Columns["Amount"].Summary.Add(DevExpress.Data.SummaryItemType.Sum, "Amount", "Total: {0:n2}");

                // Set Supplier Debt
                TotalRequired = Convert.ToDecimal(gridViewSuppliersDebt.Columns["Amount"].SummaryItem.SummaryValue);
            }

            // Set up summary Amount On Table SuppliersPayments.
            if (gridViewSuppliersPayments.RowCount > 0)
            {
                gridViewSuppliersPayments.Columns["Amount"].Summary.Clear();
                gridViewSuppliersPayments.Columns["Amount"].Summary.Add(DevExpress.Data.SummaryItemType.Sum, "Amount", "Total: {0:n2}");

                // Set Supplier Payments
                TotalPayments = Convert.ToDecimal(gridViewSuppliersPayments.Columns["Amount"].SummaryItem.SummaryValue);
            }

            // Show Data.
            labName.Text = clsSupplier.Find(_SupplierID).FullName;
            labRequired.Text = TotalRequired.ToString(("#,##0"));
            labPayments.Text = TotalPayments.ToString(("#,##0"));
            labRemaining.Text = (TotalRequired - TotalPayments).ToString(("#,##0"));

        }

        private async Task RefreshForm()
        {
            gridControlSuppliersDebt.DataSource = await clsSupplier.GetSupplierDebtBySupplierIDAsync(_SupplierID);
            gridControlSuppliersPayments.DataSource = await clsSupplier.GetSupplierPaymentsBySupplierIDAsync(_SupplierID);

            SetInfoSupplier();

            // Hide Column DebtMenuID.
            if (gridViewSuppliersDebt.RowCount > 0)
            {
                if (gridViewSuppliersDebt != null)
                    gridViewSuppliersDebt.Columns["DebtMenuID"].Visible = false;
            }

            // Hide Column PaymentID.
            if (gridViewSuppliersPayments.RowCount > 0)
            {
                if (gridViewSuppliersPayments != null)
                    gridViewSuppliersPayments.Columns["PaymentID"].Visible = false;
            }
        }

        private void btnAddDebtMenu_Click(object sender, EventArgs e)
        {
            frmAddUpdateDebtMenu frm = new frmAddUpdateDebtMenu(_SupplierID);
            frm.RefreshTable += RefreshForm;
            frm.ShowDialog();

            SetInfoSupplier();
        }

        private void btnEditDebtMenu_Click(object sender, EventArgs e)
        {
            if (gridViewSuppliersDebt.RowCount <= 0)
            {
                frmMessageBoxDev.ShowDialog("يرجى تحديد قائمة الدين اولا", "خطا", "حسنا", frmMessageBoxDev.ModeDialog.Information);
                return;
            }

            // Select Current DebtMenuID.
            int DebtMenuID = -1;

            if (gridViewSuppliersDebt != null && gridViewSuppliersDebt.FocusedRowHandle >= 0)
            {
                DebtMenuID = Convert.ToInt32(gridViewSuppliersDebt.GetRowCellValue(gridViewSuppliersDebt.FocusedRowHandle, "DebtMenuID"));
            }


            frmAddUpdateDebtMenu frm = new frmAddUpdateDebtMenu(DebtMenuID, isUpdateMode: true);
            frm.RefreshTable += RefreshForm;
            frm.ShowDialog();

            SetInfoSupplier();
        }

        private async void btnDeleteDebtMenu_Click(object sender, EventArgs e)
        {
            if (gridViewSuppliersDebt.RowCount <= 0)
            {
                frmMessageBoxDev.ShowDialog("يرجى تحديد قائمة الدين اولا", "خطا", "حسنا", frmMessageBoxDev.ModeDialog.Information);
                return;
            }

            // Select Current DebtMenuID.
            int DebtMenuID = -1;
            string MenuName = string.Empty;

            if (gridViewSuppliersDebt != null && gridViewSuppliersDebt.FocusedRowHandle >= 0)
            {
                DebtMenuID = Convert.ToInt32(gridViewSuppliersDebt.GetRowCellValue(gridViewSuppliersDebt.FocusedRowHandle, "DebtMenuID"));
                MenuName = gridViewSuppliersDebt.GetRowCellValue(gridViewSuppliersDebt.FocusedRowHandle, "MenuName").ToString();
            }

            if (frmMessageBoxDev.ShowDialog($"هل تريد حذف هذه القائمة [ {MenuName} ]", "تحذير", "حذف", "الغاء", frmMessageBoxDev.ModeDialog.Question) == DevExpressInternal.DialogResult.Yes)
            {
                bool isDeleted = await clsSupplier.DeleteSupplierDebtAsync(DebtMenuID);

                if (isDeleted)
                {
                    // Refresh Debt Table And Info Supplier Before Show Message.
                    await RefreshForm();

                    frmMessageBoxDev.ShowDialog("تم حذف القائمة بنجاح", "نجحت العملية", "حسنا", frmMessageBoxDev.ModeDialog.Information);
                }
                else
                {
                    frmMessageBoxDev.ShowDialog("حدث خطا اثناء الحذف", "حدث خطأ", "حسنا", frmMessageBoxDev.ModeDialog.Error);
                }
            }
        }

        private async void btnResetDebtAndPayments(object sender, EventArgs e)
        {
            // Check On User Permission 
            if (!Properties.Settings.Default.IsManager)
            {
                frmMessageBoxDev.ShowDialog("ليس لديك الصلاحية الكافية للقيام بهذه العلملية", "خطا", "حسنا", frmMessageBoxDev.ModeDialog.Error, frmMessageBoxDev.Focus.btn1);
                return;
            }


            if (gridViewSuppliersDebt.RowCount == 0 && gridViewSuppliersPayments.RowCount == 0)
            {
                frmMessageBoxDev.ShowDialog("السجل منظف بالكامل", "معلومة", "حسنا", frmMessageBoxDev.ModeDialog.Information);

                // In This Case There Are Not Debt And Payments. So Exist.
                return;
            }

            if (frmMessageBoxDev.ShowDialog("هل تريد حذف السجل بالكامل ؟", "تحذير", "تنضيف", "الغاء", frmMessageBoxDev.ModeDialog.Question) == DevExpressInternal.DialogResult.Yes)
            {
                bool isDeleted = await clsSupplier.ResetSupplierDebtAndPaymentsAsync(_SupplierID);

                if (isDeleted)
                {
                    await RefreshForm();
                    frmMessageBoxDev.ShowDialog("تم تنظيف السجل بالكامل", "نجحت العملية", "حسنا", frmMessageBoxDev.ModeDialog.Information, frmMessageBoxDev.Focus.btn1);
                }
                else
                {
                    frmMessageBoxDev.ShowDialog("حذف خطأ ما اثناء الحذف", "حدث خطأ", "حسنا", frmMessageBoxDev.ModeDialog.Error);
                }
            }
        }

        private async void btnDeletePayment_Click(object sender, EventArgs e)
        {
            if (gridViewSuppliersPayments.RowCount <= 0)
            {
                frmMessageBoxDev.ShowDialog("يرجى تحديد قائمة الدفع اولا", "خطا", "حسنا", frmMessageBoxDev.ModeDialog.Information);
                return;
            }

            if (frmMessageBoxDev.ShowDialog("تاكيد عملية حذف المبلغ", "تحذير", "حذف", "الغاء", frmMessageBoxDev.ModeDialog.Question) == DevExpressInternal.DialogResult.Yes)
            {
                // Select Current DebtMenuID.
                int PaymentID = -1;
                if (gridViewSuppliersPayments != null && gridViewSuppliersPayments.FocusedRowHandle >= 0)
                {
                    PaymentID = Convert.ToInt32(gridViewSuppliersPayments.GetRowCellValue(gridViewSuppliersPayments.FocusedRowHandle, "PaymentID"));
                }

                bool isDeleted = await clsSupplier.DeleteSupplierPaymentAsync(PaymentID);

                if (isDeleted)
                {
                    // Refresh Debt Table And Info Supplier Before Show Message.
                    await RefreshForm();

                    frmMessageBoxDev.ShowDialog("تم حذف المبلغ بنجاح", "نجحت العملية", "حسنا", frmMessageBoxDev.ModeDialog.Information);
                }
                else
                {
                    frmMessageBoxDev.ShowDialog("حدث خطا اثناء حذف المبلغ", "حدث خطأ", "حسنا", frmMessageBoxDev.ModeDialog.Error);
                }
            }
        }

        private async void btnAddPayment_Click(object sender, EventArgs e)
        {
            AddPayment frm = new AddPayment(_SupplierID);

            frm.ShowDialog();

            await RefreshForm();
        }

        private async void btnEditPayment_Click(object sender, EventArgs e)
        {

            if (gridViewSuppliersPayments.RowCount <= 0)
            {
                frmMessageBoxDev.ShowDialog("يرجى تحديد قائمة الدفع اولا", "خطا", "حسنا", frmMessageBoxDev.ModeDialog.Information);
                return;
            }

            int PaymentID = -1;

            if (gridViewSuppliersPayments != null && gridViewSuppliersPayments.FocusedRowHandle >= 0)
            {
                PaymentID = Convert.ToInt32(gridViewSuppliersPayments.GetRowCellValue(gridViewSuppliersPayments.FocusedRowHandle, "PaymentID"));
            }


            AddPayment frm = new AddPayment(PaymentID, isUpdate: true);

            frm.ShowDialog();

            await RefreshForm();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}