using clsMessageBox;
using DebtManagement_Business;
using DevExpress.Data.Helpers;
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

namespace DebtManagement.SupplierForms
{
    public partial class frmAddUpdateDebtMenu : DevExpress.XtraEditors.XtraForm
    {
        int _SupplierID = -1;
        bool _isUpdateMode = false;
        int _MenuID = -1;

        public delegate Task MyDelegate();

        public event MyDelegate RefreshTable;

        public frmAddUpdateDebtMenu(int SupplierID)
        {
            InitializeComponent();

            _SupplierID = SupplierID;
        }

        public frmAddUpdateDebtMenu(int MenuID, bool isUpdateMode)
        {
            InitializeComponent();

            // _SupplierID = SupplierID;
            _MenuID = MenuID;
            _isUpdateMode = isUpdateMode;
        }

        private void frmAddUpdateDebtMenu_Load(object sender, EventArgs e)
        {
            if (_isUpdateMode)
            {
                btnAdd.Visible = false;

                this.Text = "تعديل القائمة";
                btnAddAndClose.Text = "تعديل";

                btnAddAndClose.Left = (this.Width - btnAddAndClose.Width) / 2;

                string MenuName = string.Empty;
                Decimal Amount = -1;

                clsSupplier.FindSupplierDebtMenuAsync(_MenuID, ref MenuName, ref Amount);

                if (MenuName != null && Amount != -1)
                {
                    txtMenuName.Text = MenuName;
                    txtCalcTotalAmount.Text = Amount.ToString();
                }
            }
        }

        private void txtTcalc_Enter(object sender, EventArgs e)
        {
            panelBottomBorder.Visible = true;

        }

        private void txtTcalc_Leave(object sender, EventArgs e)
        {
            panelBottomBorder.Visible = false;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            await AddOrUpdateMenu();

            // Reset After Added
            txtMenuName.Text = string.Empty;
            txtCalcTotalAmount.Text = string.Empty;
        }

        private async void btnAddAndClose_Click(object sender, EventArgs e)
        {
            await AddOrUpdateMenu();
            this.Close();
        }

        private async Task AddOrUpdateMenu()
        {
            if (string.IsNullOrEmpty(txtMenuName.Text))
            {
                frmMessageBoxDev.ShowDialog("الرجاء ادخال اسم القائمة اولا", "خطأ", "حسنا", frmMessageBoxDev.ModeDialog.Error, frmMessageBoxDev.Focus.btn1);
                return;
            }

            if (string.IsNullOrEmpty(txtCalcTotalAmount.Text))
            {
                frmMessageBoxDev.ShowDialog("الرجاء ادخال المبلغ اولا", "خطأ", "حسنا", frmMessageBoxDev.ModeDialog.Error, frmMessageBoxDev.Focus.btn1);
                return;
            }

            Decimal Amount = Convert.ToDecimal(txtCalcTotalAmount.Text);
            string MenuName = txtMenuName.Text;

            if (!_isUpdateMode)
            {
                // In This Case We Add New Menu.
                int NewMenuID = await clsSupplier.AddSupplierDebtMenuAsync(_SupplierID, MenuName, Amount);

                if (NewMenuID != -1)
                {
                    await RefreshTable?.Invoke(); // Refresh Table Before Show Message.
                    frmMessageBoxDev.ShowDialog("تمت إضافة القائمة بنجاح", "نجحت العملية", "حسنا", frmMessageBoxDev.ModeDialog.Information, frmMessageBoxDev.Focus.btn1);
                }
                else
                {
                    frmMessageBoxDev.ShowDialog("حدث خطا اثناء الاضافة", "حدث خطأ", "حسنا", frmMessageBoxDev.ModeDialog.Error);
                }
            }
            else
            {
                // In This Case We Update Menu By MenuID.
                bool isUpdated = await clsSupplier.UpdateSupplierDebtAsync(_MenuID, MenuName, Amount);

                if (isUpdated)
                {
                    RefreshTable?.Invoke();
                    frmMessageBoxDev.ShowDialog("تم تحديث القائمة بنجاح", "نجحت العملية", "حسنا", frmMessageBoxDev.ModeDialog.Information, frmMessageBoxDev.Focus.btn1);
                    this.Close();
                }
                else
                {
                    frmMessageBoxDev.ShowDialog("حدث خطأ ما اثناء تحديث القائمة", "خطا", "حسنا", frmMessageBoxDev.ModeDialog.Error, frmMessageBoxDev.Focus.btn1);
                }
            }

        }

        private void txtCalcTotalAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // IF User Enter Negative Number Ignore It.
            if (e.KeyChar == '-')
            {
                e.Handled = true;
            }
        }
    }
}