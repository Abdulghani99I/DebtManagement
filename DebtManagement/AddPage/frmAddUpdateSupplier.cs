using DebtManagement_Business;
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
using clsMessageBox;
using DevExpress.XtraRichEdit.Model;
using System.Xml.Linq;

namespace DebtManagement.AddPAage
{
    public partial class frmAddUpdateSupplier : XtraForm
    {
        private int _SupplierID = -1;
        private clsSupplier _Supplier = new clsSupplier();

        public delegate Task MyDelegate();
        public event MyDelegate RefreshTable;

        enum Mode { AddNew, Update }

        Mode mode = Mode.AddNew;

        public frmAddUpdateSupplier()
        {
            InitializeComponent();

            mode = Mode.AddNew;
        }

        public frmAddUpdateSupplier(int SupplierID)
        {
            InitializeComponent();

            _SupplierID = SupplierID;

            mode = Mode.Update;
        }

        private void frmAdd_Supplier_Load(object sender, EventArgs e)
        {
            if (Mode.Update == mode)
            {
                this.Text = "تعديل معلومات المورد";

                btnAdd.Text = "تعديل";

                int screenWidth = this.ClientSize.Width;
                int buttonWidth = btnAdd.Width;
                btnAdd.Left = (screenWidth - buttonWidth) / 2;

                btnAddAndClose.Visible = false;


                _Supplier = clsSupplier.Find(_SupplierID);

                if (_Supplier != null)
                {
                    txtClientName.Text = _Supplier.FullName;
                    txtAddress.Text = _Supplier.Address;
                    txtPhone.Text = _Supplier.Phone;
                }
            }
        }

        private void txtClientName_Enter(object sender, EventArgs e)
        {
            panelBorderBottom.Location = new Point(panelBorderBottom.Location.X, txtClientName.Location.Y + txtClientName.Size.Height);
        }

        private void txtAddress_Enter(object sender, EventArgs e)
        {
            panelBorderBottom.Location = new Point(panelBorderBottom.Location.X, txtAddress.Location.Y + txtAddress.Size.Height);
        }

        private void txtPhone_Enter(object sender, EventArgs e)
        {
            panelBorderBottom.Location = new Point(panelBorderBottom.Location.X, txtPhone.Location.Y + txtPhone.Size.Height);
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckInfoValid())
            {
                await AddOrUpdateSupplier();

                if (mode == Mode.Update) // When Update Supplier Close This Form.
                    this.Close();
            }
            else
            {
                frmMessageBox.ShowDialog("يرجى ادخال المعلومات بشكل صحيح", "خطا", "حسنا");
                return;
            }

            // reset textbox.
            txtClientName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtPhone.Text = string.Empty;
        }

        private async void btnAddAndClose_Click(object sender, EventArgs e)
        {
            if (CheckInfoValid())
            {
                await AddOrUpdateSupplier();
            }
            else
            {
                frmMessageBox.ShowDialog("يرجى ادخال المعلومات بشكل صحيح", "خطا", "حسنا");
                return;
            }

            this.Close();
        }

        private bool CheckInfoValid()
        {
            txtClientName_Validated(null, null);
            txtPhone_Validated(null, null);
            txtAddress_Validated(null, null);

            if ( errorProvider1.GetError(txtClientName) != string.Empty ||
                 errorProvider1.GetError(txtPhone) != string.Empty      ||
                 errorProvider1.GetError(txtAddress) != string.Empty)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        private async Task AddOrUpdateSupplier()
        {
            _Supplier.FullName = txtClientName.Text;
            _Supplier.Address = txtAddress.Text;
            _Supplier.Phone = txtPhone.Text;

            bool result = await _Supplier.SaveAsync();

            if (Mode.AddNew == mode)
            {
                if (result)
                {
                    await RefreshTable?.Invoke();
                    frmMessageBox.ShowDialog("تمت إضافة المورد", "معلومة", "حسنا");
                }
                else
                {
                    frmMessageBox.ShowDialog("حدث خطأ ما اثناء الاضافة", "خطا", "حسنا");
                }
            }
            else
            {
                if (result)
                {
                    await RefreshTable?.Invoke();
                    frmMessageBox.ShowDialog("تم تحديث  بيانات المورد", "معلومة", "حسنا");
                }
                else
                {
                    frmMessageBox.ShowDialog("حدث خطأ ما اثناء التحديث", "خطا", "حسنا");
                }
            }
        }

        private void txtClientName_Validated(object sender, EventArgs e)
        {
            // Check if the TextBox is empty
            if (string.IsNullOrWhiteSpace(txtClientName.Text))
            {
                // Set the error message on the TextBox
                errorProvider1.SetError(txtClientName, "الرجاء إدخال اسم المورد");
            }
            else
            {
                errorProvider1.SetError(txtClientName, string.Empty);
            }
        }

        private void txtPhone_Validated(object sender, EventArgs e)
        {
            // Check if the TextBox is empty
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                // Set the error message on the TextBox
                errorProvider1.SetError(txtPhone, "الرجاء ادخال رقم الهاتف");
            }
            else
            {
                errorProvider1.SetError(txtPhone, string.Empty);
            }
        }

        private void txtAddress_Validated(object sender, EventArgs e)
        {
            // Check if the TextBox is empty
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                // Set the error message on the TextBox
                errorProvider1.SetError(txtAddress, "الرجاء ادخال العنوان او يمكنك ترك اي شي مثل '_'");
            }
            else
            {
                errorProvider1.SetError(txtAddress, string.Empty);
            }

        }

    }
}