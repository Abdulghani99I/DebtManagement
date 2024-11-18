using clsMessageBox;
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
            SetDebtAndPaymentsTableColumns();
        }

        private void SetInfoClient()
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

            SetInfoClient();

            // Hide Column DebtMenuID.
            if (gridViewClientsDebt.RowCount > 0)
            {
                if (gridViewClientsDebt != null)
                    gridViewClientsDebt.Columns["DebtMenuID"].Visible = false;
            }

            // Hide Column PaymentID.
            if (gridViewClientsPayments.RowCount > 0)
            {
                if (gridViewClientsPayments != null)
                    gridViewClientsPayments.Columns["PaymentID"].Visible = false;
            }
        }

        private void SetDebtAndPaymentsTableColumns()
        {
            // Set Columns Table (Clients Debt).
            if (gridViewClientsDebt != null && gridViewClientsDebt.RowCount > 0)
            {
                // Note: Column "DebtMenuID" Is Hidden.
                //gridViewClientsDebt.Columns["DebtMenuID"].Caption = "";

                gridViewClientsDebt.Columns["MenuName"].Caption = "اسم القائمة";

                gridViewClientsDebt.Columns["Amount"].Caption = "المبلغ";
                gridViewClientsDebt.Columns["Amount"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                gridViewClientsDebt.Columns["Amount"].DisplayFormat.FormatString = "n0";



                gridViewClientsDebt.Columns["CreatedAt"].Caption = "التاريخ";
                gridViewClientsDebt.Columns["CreatedAt"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                gridViewClientsDebt.Columns["CreatedAt"].DisplayFormat.FormatString = "yyyy/MM/dd";
            }
            else
            {
                ShowEmptyClientsDebtTable();
            }

            // Set Columns Table (Clients Payments).
            if (gridViewClientsPayments != null && gridViewClientsPayments.RowCount > 0)
            {
                // Note: Column "PaymentID" Is Hidden.
                //gridViewClientsPayments.Columns["PaymentID"].Caption = "";

                gridViewClientsPayments.Columns["Amount"].Caption = "المبلغ";
                gridViewClientsPayments.Columns["Amount"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                gridViewClientsPayments.Columns["Amount"].DisplayFormat.FormatString = "n0";

                gridViewClientsPayments.Columns["CreatedAt"].Caption = "التاريخ";
                gridViewClientsPayments.Columns["CreatedAt"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                gridViewClientsPayments.Columns["CreatedAt"].DisplayFormat.FormatString = "yyyy/MM/dd";
            }
            else
            {
                ShowEmptyTableClientsPayment();
            }
        }

        private void ShowEmptyClientsDebtTable()
        {
            // Add Column DebtMenuID And Make it (Visible = false).
            DevExpress.XtraGrid.Columns.GridColumn ClientIDColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            //ClientIDColumn.Caption = "";
            ClientIDColumn.FieldName = "DebtMenuID";
            ClientIDColumn.Visible = false;
            gridViewClientsDebt.Columns.Add(ClientIDColumn);

            // Add Column MenuName.
            DevExpress.XtraGrid.Columns.GridColumn MenuNameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            MenuNameColumn.Caption = "اسم القائمة";
            MenuNameColumn.FieldName = "MenuName";
            MenuNameColumn.Visible = true;
            gridViewClientsDebt.Columns.Add(MenuNameColumn);

            // Add Column AmountColumn.
            DevExpress.XtraGrid.Columns.GridColumn AmountColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            AmountColumn.Caption = "المبلغ";
            AmountColumn.FieldName = "Amount";
            AmountColumn.Visible = true;
            gridViewClientsDebt.Columns.Add(AmountColumn);

            // Add Column CreatedAt.
            DevExpress.XtraGrid.Columns.GridColumn CreatedAtColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            CreatedAtColumn.Caption = "التاريخ";
            CreatedAtColumn.FieldName = "CreatedAt";
            CreatedAtColumn.Visible = true;
            gridViewClientsDebt.Columns.Add(CreatedAtColumn);
        }

        private void ShowEmptyTableClientsPayment()
        {
            // Add Column PaymentID And Make it (Visible = false).
            DevExpress.XtraGrid.Columns.GridColumn PaymentIDColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            //PaymentIDColumn.Caption = "";
            PaymentIDColumn.FieldName = "PaymentID";
            PaymentIDColumn.Visible = false;
            gridViewClientsPayments.Columns.Add(PaymentIDColumn);

            // Add Column Amount.
            DevExpress.XtraGrid.Columns.GridColumn AmountColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            AmountColumn.Caption = "المبلغ";
            AmountColumn.FieldName = "Amount";
            AmountColumn.Visible = true;
            gridViewClientsPayments.Columns.Add(AmountColumn);

            // Add Column CreatedAt.
            DevExpress.XtraGrid.Columns.GridColumn CreatedAtColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            CreatedAtColumn.Caption = "التاريخ";
            CreatedAtColumn.FieldName = "CreatedAt";
            CreatedAtColumn.Visible = true;
            gridViewClientsPayments.Columns.Add(CreatedAtColumn);

        }

        private void btnAddDebtMenu_Click(object sender, EventArgs e)
        {
            frmAddUpdateDebtMenu frm = new frmAddUpdateDebtMenu(_ClientID);
            frm.RefreshTable += RefreshForm;
            frm.ShowDialog();

            SetInfoClient();
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

            SetInfoClient();
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

            if (frmMessageBoxDev.ShowDialog("تاكيد عملية الحذف", "تحذير", "حذف", "الغاء", frmMessageBoxDev.ModeDialog.Question) == DevExpressInternal.DialogResult.Yes)
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

                    frmMessageBoxDev.ShowDialog("تم الحذف بنجاح", "نجحت العملية", "حسنا", frmMessageBoxDev.ModeDialog.Information);
                }
                else
                {
                    frmMessageBoxDev.ShowDialog("حدث خطا اثناء الحذف", "حدث خطأ", "حسنا", frmMessageBoxDev.ModeDialog.Error);
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