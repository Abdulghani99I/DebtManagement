using clsMessageBox;
using DebtManagement_Business;
using DebtManagement_Data;
using DevExpress.PivotGrid.Criteria;
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
using System.Windows.Forms.VisualStyles;

namespace DebtManagement.Client
{
    public partial class AddPayment : DevExpress.XtraEditors.XtraForm
    {
        int _ClientID = -1;
        int _PaymentID = -1;
        bool _isUpdate = false;

        public AddPayment(int ClientID)
        {
            InitializeComponent();

            _ClientID = ClientID;
        }

        public AddPayment(int PaymentID, bool isUpdate = true)
        {
            InitializeComponent();

            _PaymentID = PaymentID;
            _isUpdate = isUpdate;
        }

        private void AddPayment_Load(object sender, EventArgs e)
        {
            
            if (_isUpdate)
            {
                this.Text = "التعديل على قيمة الدفع";
                labTitle.Text = "تعديل قيمة الدفع";
                btnAdd.Text = "تعديل";

                decimal Amount = 0;

                clsClient.FindClientPaymentAsync(_PaymentID, ref Amount);

                txtCalcTotalAmount.Text = Amount.ToString();
            }
        }

        private void txtCalcTotalAmount_Enter(object sender, EventArgs e)
        {
            panelBottomBorder.Visible = true;
        }

        private void txtCalcTotalAmount_Leave(object sender, EventArgs e)
        {
            panelBottomBorder.Visible = false;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            decimal Amount = Convert.ToDecimal(txtCalcTotalAmount.Text);

            if (!_isUpdate)
            {
                // In This Case We Add The New Client Payment.
                int PaymentID = await clsClient.AddClientPaymentAsync(_ClientID, Amount);

                if (PaymentID == -1)
                {
                    frmMessageBoxDev.ShowDialog("حدث خطأ ما اثناء الاضافة", "خطا", "حسنا", frmMessageBoxDev.ModeDialog.Error);
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                // In This Case We Update The Client Payment.

                bool Result = await clsClient.UpdateClientPaymentAsync(_PaymentID, Amount);

                if (!Result)
                {
                    frmMessageBoxDev.ShowDialog("حدث خطأ ما اثناء التعديل", "خطا", "حسنا", frmMessageBoxDev.ModeDialog.Error);
                }
                else
                {
                    this.Close();
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