using clsMessageBox;
using DebtManagement_Business;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DebtManagement.User
{
    public partial class CreateNewUser : DevExpress.XtraEditors.XtraForm
    {
        public CreateNewUser()
        {
            InitializeComponent();
        }
        private void txtUserName_Enter(object sender, EventArgs e)
        {
            panelBottomBorder.Location = new Point(panelBottomBorder.Location.X, txtFulName.Location.Y + txtFulName.Size.Height);

        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            panelBottomBorder.Location = new Point(panelBottomBorder.Location.X, txtPassword.Location.Y + txtPassword.Size.Height);
        }

        private void txtConfirmPassword_Enter(object sender, EventArgs e)
        {
            panelBottomBorder.Location = new Point(panelBottomBorder.Location.X, txtConfirmPassword.Location.Y + txtConfirmPassword.Size.Height);
        }

        private void txtFullNameValidated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFulName.Text))
            {
                errorProvider1.SetError(txtFulName, "الرجاء ادخال الاسم الكامل");
                return;
            }
            else
            {
                errorProvider1.SetError(txtFulName, string.Empty);
            }
        }


        private void txtUsername_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                errorProvider1.SetError(txtUsername, "الرجاء ادخال اسم المستخدم");
                return;
            }
            else
            {
                errorProvider1.SetError(txtUsername, string.Empty);
            }

            if (clsUser.FindUser(txtUsername.Text) != null)
            {
                errorProvider1.SetError(txtUsername, "هذا الاسم موجود مسبقا الرجاء ادخال اسم مستخدم غير مستعمل");
                return;
            }
            else
            {
                errorProvider1.SetError(txtUsername, string.Empty);
            }
        }



        private void txtPassword_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, "يرجى ادخال كلمة المرور");
            }
            else
            {
                errorProvider1.SetError(txtPassword, string.Empty);
            }
        }

        private void txtConfirmPassword_Validated(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                errorProvider1.SetError(txtConfirmPassword, "كلمة المرور غير متطابقة");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, string.Empty);
            }
        }

        private async void btnAddAndLogin_Click(object sender, EventArgs e)
        {
            // This Controls Should Return Empty string. Else Should Out From This Function.
            if (
                !string.IsNullOrEmpty(errorProvider1.GetError(txtFulName)) ||
                !string.IsNullOrEmpty(errorProvider1.GetError(txtFulName)) ||
                !string.IsNullOrEmpty(errorProvider1.GetError(txtPassword)) ||
                !string.IsNullOrEmpty(errorProvider1.GetError(txtConfirmPassword))
                )
            {
                frmMessageBoxDev.ShowDialog("يرجى ادخال البيانات بشكل صحيح", "خطا", "حسنا", frmMessageBoxDev.ModeDialog.Error, frmMessageBoxDev.Focus.btn1);
                return;
            }

            clsUser user = new clsUser();

            user.FullName = txtFulName.Text;
            user.UserName = txtUsername.Text;
            user.Password = txtPassword.Text;
            user.IsManager = true;
            

            if (await user.SaveAsync())
            {
                frmMessageBoxDev.ShowDialog("تم حفط بيانات المستخدم", "تم الاضافة", "حسنا", frmMessageBoxDev.ModeDialog.Information, frmMessageBoxDev.Focus.btn1);
                this.Close();
            }

            else
            {
                frmMessageBoxDev.ShowDialog("حدث خطأ ما اثناء اضافة المستخدم", "خطأ", "حسنا", frmMessageBoxDev.ModeDialog.Error, frmMessageBoxDev.Focus.btn1);
            }
        }

        public string ConvertImageToBase64String(Image image)
        {
            if (image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    image.Save(ms, image.RawFormat); // Save image to memory stream
                    string base64String = Convert.ToBase64String(ms.ToArray()); // Convert to Base64 string
                    return base64String;
                }
            }

            return null;
        }

    }
}