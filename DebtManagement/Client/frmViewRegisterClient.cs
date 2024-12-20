﻿using clsMessageBox;
using DebtManagement.Client;
using DebtManagement.ClientForms;
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
    public partial class frmViewRegisterClient : XtraForm
    {
        private int _ClientID = -1;

        public frmViewRegisterClient(int SupplerID)
        {
            InitializeComponent();
            _ClientID = SupplerID;
        }

        private async void frmViewRegisterClient_Load(object sender, EventArgs e)
        {
            await RefreshForm();
        }

        private void SetInfoClientPayment()
        {
            Decimal TotalRequired = 0, TotalPayments = 0;

            // Set up summary Amount On Table ClientsDebt.
            if (gridViewClientsDebt.RowCount > 0)
            {
                gridViewClientsDebt.Columns["Amount"].Summary.Clear();
                gridViewClientsDebt.Columns["Amount"].Summary.Add(DevExpress.Data.SummaryItemType.Sum, "Amount", "Total: {0:n2}");

                // Set Client Debt
                TotalRequired = Convert.ToDecimal(gridViewClientsDebt.Columns["Amount"].SummaryItem.SummaryValue);
            }

            // Set up summary Amount On Table ClientsPayments.
            if (gridViewClientsPayments.RowCount > 0)
            {
                gridViewClientsPayments.Columns["Amount"].Summary.Clear();
                gridViewClientsPayments.Columns["Amount"].Summary.Add(DevExpress.Data.SummaryItemType.Sum, "Amount", "Total: {0:n2}");

                // Set Client Payments
                TotalPayments = Convert.ToDecimal(gridViewClientsPayments.Columns["Amount"].SummaryItem.SummaryValue);
            }

            // Show Data.
            labName.Text = clsClient.Find(_ClientID).FullName;
            labRequired.Text = TotalRequired.ToString(("#,##0"));
            labPayments.Text = TotalPayments.ToString(("#,##0"));
            labRemaining.Text = (TotalRequired - TotalPayments).ToString(("#,##0"));

        }

        private async Task RefreshForm()
        {
            gridControlClientsDebt.DataSource = await clsClient.GetClientDebtByClientIDAsync(_ClientID);
            gridControlClientsPayments.DataSource = await clsClient.GetClientPaymentsByClientIDAsync(_ClientID);

            SetInfoClientPayment();
        }

        private void btnAddDebtMenu_Click(object sender, EventArgs e)
        {
            frmAddUpdateDebtMenu frm = new frmAddUpdateDebtMenu(_ClientID);
            frm.RefreshTable += RefreshForm;
            frm.ShowDialog();

            SetInfoClientPayment();
        }

        private void btnEditDebtMenu_Click(object sender, EventArgs e)
        {
            if (gridViewClientsDebt.RowCount <= 0)
            {
                frmMessageBoxDev.ShowDialog("يرجى تحديد قائمة الدين اولا", "خطا", "حسنا", frmMessageBoxDev.ModeDialog.Information);
                return;
            }

            // Select Current DebtMenuID.
            int DebtMenuID = -1;

            if (gridViewClientsDebt != null && gridViewClientsDebt.FocusedRowHandle >= 0)
            {
                DebtMenuID = Convert.ToInt32(gridViewClientsDebt.GetRowCellValue(gridViewClientsDebt.FocusedRowHandle, "DebtMenuID"));
            }


            frmAddUpdateDebtMenu frm = new frmAddUpdateDebtMenu(DebtMenuID, isUpdateMode: true);
            frm.RefreshTable += RefreshForm;
            frm.ShowDialog();

            SetInfoClientPayment();
        }

        private async void btnDeleteDebtMenu_Click(object sender, EventArgs e)
        {
            if (gridViewClientsDebt.RowCount <= 0)
            {
                frmMessageBoxDev.ShowDialog("يرجى تحديد قائمة الدين اولا", "خطا", "حسنا", frmMessageBoxDev.ModeDialog.Information);
                return;
            }

            // Select Current DebtMenuID.
            int DebtMenuID = -1;
            string MenuName = string.Empty;

            if (gridViewClientsDebt != null && gridViewClientsDebt.FocusedRowHandle >= 0)
            {
                DebtMenuID = Convert.ToInt32(gridViewClientsDebt.GetRowCellValue(gridViewClientsDebt.FocusedRowHandle, "DebtMenuID"));
                MenuName = gridViewClientsDebt.GetRowCellValue(gridViewClientsDebt.FocusedRowHandle, "MenuName").ToString();
            }

            if (frmMessageBoxDev.ShowDialog($"هل تريد حذف هذه القائمة [ {MenuName} ]", "تحذير", "حذف", "الغاء", frmMessageBoxDev.ModeDialog.Question) == DevExpressInternal.DialogResult.Yes)
            {
                bool isDeleted = await clsClient.DeleteClientDebtAsync(DebtMenuID);

                if (isDeleted)
                {
                    // Refresh Debt Table And Info Client Before Show Message.
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


            if (gridViewClientsDebt.RowCount == 0 && gridViewClientsPayments.RowCount == 0)
            {
                frmMessageBoxDev.ShowDialog("السجل منظف بالكامل", "معلومة", "حسنا", frmMessageBoxDev.ModeDialog.Information);

                // In This Case There Are Not Debt And Payments. So Exist.
                return;
            }

            if (frmMessageBoxDev.ShowDialog("هل تريد حذف السجل بالكامل ؟", "تحذير", "تنضيف", frmMessageBoxDev.ModeDialog.Question) == DevExpressInternal.DialogResult.Yes)
            {
                bool isDeleted = await clsClient.ResetClientDebtAndPaymentsAsync(_ClientID);

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
            if (gridViewClientsPayments.RowCount <= 0)
            {
                frmMessageBoxDev.ShowDialog("يرجى تحديد قائمة الدفع اولا", "خطا", "حسنا", frmMessageBoxDev.ModeDialog.Information);
                return;
            }

            if (frmMessageBoxDev.ShowDialog("تاكيد عملية حذف المبلغ", "تحذير", "حذف", "الغاء", frmMessageBoxDev.ModeDialog.Question) == DevExpressInternal.DialogResult.Yes)
            {
                // Select Current DebtMenuID.
                int PaymentID = -1;
                if (gridViewClientsPayments != null && gridViewClientsPayments.FocusedRowHandle >= 0)
                {
                    PaymentID = Convert.ToInt32(gridViewClientsPayments.GetRowCellValue(gridViewClientsPayments.FocusedRowHandle, "PaymentID"));
                }

                bool isDeleted = await clsClient.DeleteClientPaymentAsync(PaymentID);

                if (isDeleted)
                {
                    // Refresh Debt Table And Info Client Before Show Message.
                    await RefreshForm();

                    frmMessageBoxDev.ShowDialog("تم حذف المبلغ بنجاح", "نجحت العملية", "حسنا", frmMessageBoxDev.ModeDialog.Information, frmMessageBoxDev.Focus.btn1);
                }
                else
                {
                    frmMessageBoxDev.ShowDialog("حدث خطا ما اثناء حذف المبلغ", "حدث خطأ", "حسنا", frmMessageBoxDev.ModeDialog.Error);
                }
            }
        }

        private async void btnAddPayment_Click(object sender, EventArgs e)
        {
            AddPayment frm = new AddPayment(_ClientID);

            frm.ShowDialog();

            await RefreshForm();
        }

        private async void btnEditPayment_Click(object sender, EventArgs e)
        {

            if (gridViewClientsPayments.RowCount <= 0)
            {
                frmMessageBoxDev.ShowDialog("يرجى تحديد قائمة الدفع اولا", "خطا", "حسنا", frmMessageBoxDev.ModeDialog.Information);
                return;
            }

            int PaymentID = -1;

            if (gridViewClientsPayments != null && gridViewClientsPayments.FocusedRowHandle >= 0)
            {
                PaymentID = Convert.ToInt32(gridViewClientsPayments.GetRowCellValue(gridViewClientsPayments.FocusedRowHandle, "PaymentID"));
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