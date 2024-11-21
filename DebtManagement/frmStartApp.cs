using clsMessageBox;
using DebtManagement.SetConnection;
using DebtManagement.User;
using DebtManagement_Business;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using internalDilog = DevExpress.Utils.CommonDialogs.Internal;

namespace DebtManagement
{
    public partial class frmStartApp : SplashScreen
    {
        public frmStartApp()
        {
            InitializeComponent();
            this.labelCopyright.Text = "Copyright © 2024-" + DateTime.Now.Year.ToString();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        private async void frmStartApp_Load(object sender, EventArgs e)
        {
            // Default Settings:
            //DebtManagement.Properties.Settings.Default.Username = string.Empty;
            //DebtManagement.Properties.Settings.Default.Password = string.Empty;
            //DebtManagement.Properties.Settings.Default.isClickRememberMe = false;
            //DebtManagement.Properties.Settings.Default.IsManager = true;
            //DebtManagement.Properties.Settings.Default.IsLightMode = true;
            //DebtManagement.Properties.Settings.Default.UserEnterToAppFirstTime = true;
            //DebtManagement.Properties.Settings.Default.Save();


            await Task.Run(() => Thread.Sleep(2500));
            bool isConnect = await clsConnection.CheckCurrentDatabaseConnectionAsync();
            if (isConnect)
            {
                // If User Enter In App First Time Show form CreateNewUser.
                if (DebtManagement.Properties.Settings.Default.UserEnterToAppFirstTime)
                {
                    frmMessageBoxDev.ShowDialog("مرحبا بك, يجب عليك اولا انشاء حساب", "ملاحظة", "حسنا", frmMessageBoxDev.ModeDialog.Information, frmMessageBoxDev.Focus.btn1);

                    CreateNewUser createNewUser = new CreateNewUser();
                    this.Hide();
                    createNewUser.ShowDialog();         
                    
                    this.Show();
                    await Task.Run(() => Thread.Sleep(2000));
                }
               
                frmLogin frmLogin = new frmLogin();
                this.Hide();
                frmLogin.ShowDialog();
            }
            else
            {
                // In This Case Show form frmLocalConnection.
                frmLocalConnection frmLocalConnection = new frmLocalConnection();
                frmLocalConnection.ShowDialog();

                var result = frmMessageBoxDev.ShowDialog("هل تريد إعادة تشغيل البرنامج", "سؤال", "نعم", "لا", frmMessageBoxDev.ModeDialog.Question, frmMessageBoxDev.Focus.btn1);
                
                Application.Exit();

                if (result == internalDilog.DialogResult.Yes)
                {
                    Application.Restart();
                }
            }
        }

        private void frmStartApp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}