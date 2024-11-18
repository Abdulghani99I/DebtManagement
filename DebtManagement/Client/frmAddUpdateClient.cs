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
    public partial class frmAddUpdateClient : XtraForm
    {
        private int _ClientID = -1;
        private clsClient _Client = new clsClient();

        public delegate Task MyDelegate();
        public event MyDelegate RefreshTable;

        enum Mode { AddNew, Update }

        Mode mode = Mode.AddNew;

        public frmAddUpdateClient()
        {
            InitializeComponent();

            mode = Mode.AddNew;
        }

        public frmAddUpdateClient(int ClientID)
        {
            InitializeComponent();

            _ClientID = ClientID;

            mode = Mode.Update;
        }

        private void frmAdd_Client_Load(object sender, EventArgs e)
        {
            if (Mode.Update == mode)
            {
                this.Text = "تعديل معلومات العميل";

                btnAdd.Text = "تعديل";

                int screenWidth = this.ClientSize.Width;
                int buttonWidth = btnAdd.Width;
                btnAdd.Left = (screenWidth - buttonWidth) / 2;

                btnAddAndClose.Visible = false;


                _Client = clsClient.Find(_ClientID);

                if (_Client != null)
                {
                    txtClientName.Text = _Client.FullName;
                    txtAddress.Text = _Client.Address;
                    mtxtPhoneNumber.Text = _Client.Phone;
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

        private void mtxtPhoneNumber_Enter(object sender, EventArgs e)
        {
            panelBorderBottom.Location = new Point(panelBorderBottom.Location.X, mtxtPhoneNumber.Location.Y + mtxtPhoneNumber.Size.Height);
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckInfoValid())
            {
                await AddOrUpdateClient();

                if (mode == Mode.Update) // When Update Client Close This Form.
                    this.Close();
            }
            else
            {
                frmMessageBoxDev.ShowDialog("يرجى ادخال المعلومات بشكل صحيح", "خطا", "حسنا", frmMessageBoxDev.ModeDialog.Error);
                return;
            }

            // reset textbox.
            txtClientName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            mtxtPhoneNumber.Text = string.Empty;
        }

        private async void btnAddAndClose_Click(object sender, EventArgs e)
        {
            if (CheckInfoValid())
            {
                await AddOrUpdateClient();
            }
            else
            {
                frmMessageBoxDev.ShowDialog("يرجى ادخال المعلومات بشكل صحيح", "خطا", "حسنا", frmMessageBoxDev.ModeDialog.Error);
                return;
            }

            this.Close();
        }

        private bool CheckInfoValid()
        {
            txtClientName_Validated(null, null);
            mtxtPhoneNumber_Validated(null, null);
            txtAddress_Validated(null, null);

            if (errorProvider1.GetError(txtClientName) != string.Empty ||
                 errorProvider1.GetError(mtxtPhoneNumber) != string.Empty ||
                 errorProvider1.GetError(txtAddress) != string.Empty)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private async Task AddOrUpdateClient()
        {
            _Client.FullName = txtClientName.Text;
            _Client.Address = txtAddress.Text;
            _Client.Phone = mtxtPhoneNumber.Text.Replace("-", "");

            bool result = await _Client.SaveAsync();

            if (Mode.AddNew == mode)
            {
                if (result)
                {
                    await RefreshTable?.Invoke();
                    frmMessageBoxDev.ShowDialog("تمت إضافة العميل", "معلومة", "حسنا", frmMessageBoxDev.ModeDialog.Information);
                }
                else
                {
                    frmMessageBoxDev.ShowDialog("حدث خطأ ما اثناء الاضافة", "خطا", "حسنا", frmMessageBoxDev.ModeDialog.Error);
                }
            }
            else
            {
                if (result)
                {
                    await RefreshTable?.Invoke();
                    frmMessageBoxDev.ShowDialog("تم تحديث  بيانات العميل", "معلومة", "حسنا", frmMessageBoxDev.ModeDialog.Information);
                }
                else
                {
                    frmMessageBoxDev.ShowDialog("حدث خطأ ما اثناء التحديث", "خطا", "حسنا", frmMessageBoxDev.ModeDialog.Error);
                }
            }
        }

        private void txtClientName_Validated(object sender, EventArgs e)
        {
            // Check if the TextBox is empty
            if (string.IsNullOrWhiteSpace(txtClientName.Text))
            {
                // Set the error message on the TextBox
                errorProvider1.SetError(txtClientName, "الرجاء إدخال اسم العميل");
            }
            else
            {
                errorProvider1.SetError(txtClientName, string.Empty);
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

        private void mtxtPhoneNumber_Validated(object sender, EventArgs e)
        {
            // Check if the MaskedTextBox is Full.
            if (!mtxtPhoneNumber.MaskFull)
            {
                // Set the error message on the TextBox
                errorProvider1.SetError(mtxtPhoneNumber, "الرجاء ادخال رقم الهاتف");
            }
            else
            {
                errorProvider1.SetError(mtxtPhoneNumber, string.Empty);
            }
        }
    }
}