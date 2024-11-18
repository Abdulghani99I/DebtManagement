using clsMessageBox;
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

namespace DebtManagement
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // We Should Set "txtUsername" And "txtPassword" And "checkBoxRememberMe" Because we Check Info Login By It.
            // Set Data Info Login (We Save It before Now In File Settings)
            txtUserName.Text = Properties.Settings.Default.Username;
            txtPassword.Text = Properties.Settings.Default.Password;

            bool isClickRememberMe = Properties.Settings.Default.isClickRememberMe;
            checkBoxRememberMe.Checked = isClickRememberMe;


            if (isClickRememberMe)
            {
                btnLogin_Click(null, null);
            }
        }


        private void txtUserName_Enter(object sender, EventArgs e)
        {
            panelBottomBorder.Location = new Point(panelBottomBorder.Location.X, txtUserName.Location.Y + txtUserName.Size.Height);
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            panelBottomBorder.Location = new Point(panelBottomBorder.Location.X, txtPassword.Location.Y + txtPassword.Size.Height);

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (CheckIsValidInfoLogin())
            {
                // save Username and Password if checkBox (Remember Me) is Checked.
                if (checkBoxRememberMe.Checked)
                {

                    Properties.Settings.Default.Username = txtUserName.Text;
                    Properties.Settings.Default.Password = txtPassword.Text;
                    Properties.Settings.Default.isClickRememberMe = checkBoxRememberMe.Checked;

                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.Username = string.Empty;
                    Properties.Settings.Default.Password = string.Empty;
                    Properties.Settings.Default.isClickRememberMe = false;

                    Properties.Settings.Default.Save();
                }


                Main main = new Main();
                this.Visible = false;
                main.ShowFormLogin += ((sender, e) => this.Visible = true);
                main.ShowDialog();

                //// If Login Form Hide Close It. If Set As Visible True Don't Close It (Because User Click On LogOut And We Should Show Login Form).
                if (this.Visible)
                {
                    if (!Properties.Settings.Default.isClickRememberMe)
                    {
                        // Reset Info Login Because In Settings Not Set Remember Me.
                        txtUserName.Text = string.Empty;
                        txtPassword.Text = string.Empty;
                        checkBoxRememberMe.Checked = false;
                    }
                }
                else
                {
                    main.Close();
                    this.Close();
                }
            }
            else
            {
                frmMessageBoxDev.ShowDialog("خطا في معلومات تسجيل الدخول", "خطا", "حسنا", frmMessageBoxDev.ModeDialog.Error, frmMessageBoxDev.Focus.btn1);
            }
        }


        private bool CheckIsValidInfoLogin()
        {
            string Username = txtUserName.Text;
            string Password = txtPassword.Text;


            clsUser user = clsUser.FindUser(Username);

            if (user != null)
            {
                // Set Current Acount Is Manager Or Not And Save This Info In File Settings.
                Properties.Settings.Default.IsManager = user.IsManager;
                Properties.Settings.Default.Save();

                if (user.UserName == Username && user.Password == Password)
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }
        }

    }
}