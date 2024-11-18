using clsMessageBox;
using DebtManagement_Business;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
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

namespace DebtManagement.User
{
    public partial class frmAddUpdateUser : DevExpress.XtraEditors.XtraForm
    {

        clsUser _user = new clsUser();

        enum enMode { AddNew, Update };
        enMode _mode = enMode.AddNew;

        int _UserID = -1;

        public frmAddUpdateUser()
        {
            InitializeComponent();

            _mode = enMode.AddNew;
        }

        public frmAddUpdateUser(int UserID)
        {
            InitializeComponent();

            _UserID = UserID;

            _mode = enMode.Update;
        }


        private void txtFullName_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFullName.Text))
            {
                errorProvider1.SetError(txtFullName, "الرجاء ادخال الاسم");
            }
            else
            {
                errorProvider1.SetError(txtFullName, string.Empty);
            }
        }


        private void txtFullName_Enter(object sender, EventArgs e)
        {
            panelBottomBorder.Location = new Point(panelBottomBorder.Location.X, txtFullName.Location.Y + txtFullName.Size.Height);

        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            panelBottomBorder.Location = new Point(panelBottomBorder.Location.X, txtUserName.Location.Y + txtUserName.Size.Height);

        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            panelBottomBorder.Location = new Point(panelBottomBorder.Location.X, txtPassword.Location.Y + txtPassword.Size.Height);
        }



        private void cmbPermissionUser_Enter(object sender, EventArgs e)
        {
            panelBottomBorder.Location = new Point(panelBottomBorder.Location.X, cmbPermissionUser.Location.Y + cmbPermissionUser.Size.Height);
        }

        private void txtUserName_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                errorProvider1.SetError(txtUserName, "الرجاء ادخال اسم المستخدم");
            }
            else
            {
                errorProvider1.SetError(txtUserName, string.Empty);
            }


            if (_mode == enMode.AddNew)
            {
                if (clsUser.FindUser(txtUserName.Text) != null)
                {
                    errorProvider1.SetError(txtUserName, "هذا الاسم موجود مسبقا الرجاء ادخال اسم مستخدم غير مستعمل");
                }
                else
                {
                    errorProvider1.SetError(txtUserName, string.Empty);
                }
            }
            else
            {
                // In Mode Update We Check IF Current UserName Don't Equel Entered UserName Then We Should Check Is UserName Uniq Or No't.
                if (_user.UserName != txtUserName.Text)
                {
                    if (clsUser.FindUser(txtUserName.Text) != null)
                    {
                        errorProvider1.SetError(txtUserName, "هذا الاسم موجود مسبقا الرجاء ادخال اسم مستخدم غير مستعمل");
                    }
                    else
                    {
                        errorProvider1.SetError(txtUserName, string.Empty);
                    }
                }
            }
        }

        private void txtPassword_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, "الرجاء ادخال كلمة المرور");
            }
            else
            {
                errorProvider1.SetError(txtPassword, string.Empty);
            }
        }

        private void cmbPermissionUser_Validated(object sender, EventArgs e)
        {
            if (cmbPermissionUser.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbPermissionUser, "الرجاء اختيار الصلاحية");
            }
            else
            {
                errorProvider1.SetError(cmbPermissionUser, string.Empty);
            }
        }

        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            if (_mode == enMode.Update)
            {
                this.Text = "تعديل معلومات المستخدم";
                btnSave.Text = "تعديل";

                _user = clsUser.FindUser(_UserID);

                if (_user != null)
                {
                    txtFullName.Text = _user.FullName;
                    txtUserName.Text = _user.UserName;
                    txtPassword.Text = _user.Password;
                    cmbPermissionUser.SelectedIndex = (_user.IsManager == true) ? 0 : 1; // note: 0 is represent Manager and 1 represent user.

                }
            }

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            // This Controls Should Return Empty string. Else Should Out From This Function.
            if (
                !string.IsNullOrEmpty(errorProvider1.GetError(txtFullName)) ||
                !string.IsNullOrEmpty(errorProvider1.GetError(txtUserName)) ||
                !string.IsNullOrEmpty(errorProvider1.GetError(txtPassword)) ||
                !string.IsNullOrEmpty(errorProvider1.GetError(cmbPermissionUser))
                )
            {
                frmMessageBoxDev.ShowDialog("يرجى ادخال البيانات بشكل صحيح", "خطا", "حسنا", frmMessageBoxDev.ModeDialog.Error, frmMessageBoxDev.Focus.btn1);
                return;
            }

            _user.FullName = txtFullName.Text;
            _user.UserName = txtUserName.Text;
            _user.Password = txtPassword.Text;
            _user.IsManager = (cmbPermissionUser.SelectedItem.ToString() == "مدير") ? true : false;

            if (await _user.SaveAsync())
            {
                if (_mode == enMode.AddNew)
                {
                    frmMessageBoxDev.ShowDialog("تم حفط بيانات المستخدم", "تم الاضافة", "حسنا", frmMessageBoxDev.ModeDialog.Information, frmMessageBoxDev.Focus.btn1);
                }
                else
                {
                    frmMessageBoxDev.ShowDialog("تم تعديل بيانات المستخدم", "تم تعديل", "حسنا", frmMessageBoxDev.ModeDialog.Information, frmMessageBoxDev.Focus.btn1);
                }
                this.Close();
            }
            else
            {
                if (_mode == enMode.AddNew)
                {
                    frmMessageBoxDev.ShowDialog("حدث خطأ اثناء اضافة المستخدم", "خطأ", "حسنا", frmMessageBoxDev.ModeDialog.Error, frmMessageBoxDev.Focus.btn1);
                }
                else
                {
                    frmMessageBoxDev.ShowDialog("حدث خطأ اثناء تعديل معلومات المستخدم", "خطأ", "حسنا", frmMessageBoxDev.ModeDialog.Error, frmMessageBoxDev.Focus.btn1);
                }
            }

        }

        
    }
}