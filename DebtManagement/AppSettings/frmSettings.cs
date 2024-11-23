using clsMessageBox;
using DebtManagement.SetConnection;
using DebtManagement_Business;
using DevExpress.XtraEditors;
using DevExpress.XtraSpreadsheet.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using InternalDialog = DevExpress.Utils.CommonDialogs.Internal;

namespace DebtManagement.Settings
{
    public partial class frmSettings : DevExpress.XtraEditors.XtraForm
    {
        private clsSettingsUser _settingUsere = new clsSettingsUser();
        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            _settingUsere = clsSettingsUser.FindSettingsUser(Properties.Settings.Default.Username);
            if (_settingUsere != null)
            {
                richtxtDescription.Text = _settingUsere.CompanyDescription;

                pictureEdit1.Image = LoadImageFromSettings(_settingUsere.PictureData);

                txtConversionAmount.Text = _settingUsere.ConversionValue.ToString();
                
                txtCompanyName.Text = _settingUsere.CompanyName;
            }


            // Change Icon To Night And Make Switch Mode On If Mode Is Light.
            if (!Properties.Settings.Default.IsLightMode)
            {
                toggleSwitchMode.IsOn = true;
                labIconMode.Text = "🌙";
            }
        }

        private void btnGeneralSettings_Click(object sender, EventArgs e)
        {
            navigationFrame1.SelectedPage = pageGeneralSettings;
        }

        private void btnDatabaseSettings_Click(object sender, EventArgs e)
        {
            navigationFrame1.SelectedPage = pageDatabaseSettings;
        }

        private void btnCurrencySettings_Click(object sender, EventArgs e)
        {
            navigationFrame1.SelectedPage = pageCurrencySettings;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            // Check On User Permission 
            if (!Properties.Settings.Default.IsManager)
            {
                frmMessageBoxDev.ShowDialog("ليس لديك الصلاحية الكافية للقيام بهذه العلملية", "خطا", "حسنا", frmMessageBoxDev.ModeDialog.Error, frmMessageBoxDev.Focus.btn1);
                return;
            }

            string x = ConvertImageToBase64String(pictureEdit1.Image);
            if (_settingUsere != null)
            {
                _settingUsere.CompanyName = txtCompanyName.Text;

                _settingUsere.CompanyDescription = richtxtDescription.Text;

                if (!(pictureEdit1.EditValue == null))
                {
                    _settingUsere.PictureData = ConvertImageToBase64String(pictureEdit1.Image);
                }
                else
                {
                    _settingUsere.PictureData = string.Empty;
                }

                _settingUsere.ConversionValue = Convert.ToInt32(txtConversionAmount.Text);

                if (await _settingUsere.SaveSettings())
                {
                    frmMessageBoxDev.ShowDialog("تم حفظ الاعدادات العامة", "معلومة", "حسنا", frmMessageBoxDev.ModeDialog.Information, frmMessageBoxDev.Focus.btn1);
                }
                else
                {
                    frmMessageBoxDev.ShowDialog("حدث خطا اثناء حفظ الاعدادت", "خطا", "حسنا", frmMessageBoxDev.ModeDialog.Error, frmMessageBoxDev.Focus.btn1);
                }

                // If Switch Not On Then Save In File Settings Light Mode equal False;
                Properties.Settings.Default.IsLightMode = !(toggleSwitchMode.IsOn);
                Properties.Settings.Default.Save();

            }
        }

        public string ConvertImageToBase64String(Image image)
        {
            if (image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    ImageFormat format = image.RawFormat ?? ImageFormat.Png; // استخدم تنسيق افتراضي في حالة عدم توفر RawFormat
                    image.Save(ms, format); // Save image to memory stream
                    string base64String = Convert.ToBase64String(ms.ToArray()); // Convert to Base64 string
                    return base64String;
                }
            }

            return null;
        }

        public Image LoadImageFromSettings(string base64String)
        {
            if (!string.IsNullOrEmpty(base64String))
            {
                byte[] imageBytes = Convert.FromBase64String(base64String);
                MemoryStream ms = new MemoryStream(imageBytes); // لا تغلق التدفق هنا
                return Image.FromStream(ms); // الصورة ستتحكم في التدفق
            }
            return null;
        }

        private void llabLocalConnection_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLocalConnection frm = new frmLocalConnection();

            frm.ShowDialog();
        }

        private void llabNetworkConnection_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmNetworkConnection frm = new frmNetworkConnection();

            frm.ShowDialog();
        }

        private async void btnBackUp_Click(object sender, EventArgs e)
        {
            // Check On User Permission 
            if (!Properties.Settings.Default.IsManager)
            {
                frmMessageBoxDev.ShowDialog("ليس لديك الصلاحية الكافية للقيام بهذه العلملية", "خطا", "حسنا", frmMessageBoxDev.ModeDialog.Error, frmMessageBoxDev.Focus.btn1);
                return;
            }

            if (IsRunningAsAdministrator())
            {
                frmMessageBoxDev.ShowDialog("الرجاء تشغيل البرنامج كمسؤل اولا", "خطا", "حسنا", frmMessageBoxDev.ModeDialog.Error, frmMessageBoxDev.Focus.btn1);
                return;
            }


            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            var Result = folderBrowserDialog.ShowDialog();

            
            if (Result == DialogResult.OK)
            {
                progressPanel1.Caption = "جاري اتمام عملية النسخ الاحتياطي...";
                progressPanel1.Visible = true;

                await Task.Run(() => Thread.Sleep(1500));
                
                bool isBackupSuccessfully = await clsBackUpAndRestoreDataBase.BackUp(folderBrowserDialog.SelectedPath);

                progressPanel1.Visible = false;

                if (isBackupSuccessfully)
                {
                    var result = frmMessageBoxDev.ShowDialog("تمت العملية بنجاح هل تريد فتح المجلد", "معلومة", "فتح", "الغاء", frmMessageBoxDev.ModeDialog.Question, frmMessageBoxDev.Focus.btn1);
                    if (result == InternalDialog.DialogResult.Yes)
                    {
                        OpenInExplorer(folderBrowserDialog.SelectedPath);
                    }
                }
                else
                {
                    frmMessageBoxDev.ShowDialog("حدث خطا ما اثناء محاولة عمل نسخة احتياطية", "خطا", "حسنا", frmMessageBoxDev.ModeDialog.Error, frmMessageBoxDev.Focus.btn1);
                }

            }
        }

        private async void btnRestoreDatabase_Click(object sender, EventArgs e)
        {
            // Check On User Permission 
            if (!Properties.Settings.Default.IsManager)
            {
                frmMessageBoxDev.ShowDialog("ليس لديك الصلاحية الكافية للقيام بهذه العلملية", "خطا", "حسنا", frmMessageBoxDev.ModeDialog.Error, frmMessageBoxDev.Focus.btn1);
                return;
            }


            if (IsRunningAsAdministrator())
            {
                frmMessageBoxDev.ShowDialog("الرجاء تشغيل البرنامج كمسؤل اولا", "خطا", "حسنا", frmMessageBoxDev.ModeDialog.Error, frmMessageBoxDev.Focus.btn1);
                return;
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();

            var Result = openFileDialog.ShowDialog();


            if (Result == DialogResult.OK)
            {
                if (frmMessageBoxDev.ShowDialog("سيتم الغاء قاعدة البيانات الحالية واستبدالها بالبيانات الجديدة", "تحذير", "موافق", "الغاء", frmMessageBoxDev.ModeDialog.Question) == InternalDialog.DialogResult.No)
                {
                    return;
                }
                progressPanel1.Caption = "جاري اتمام عملية الاستعادة..";
                progressPanel1.Visible = true;

                await Task.Run(() => Thread.Sleep(1500));


                bool isSuccessfully = await clsBackUpAndRestoreDataBase.Restore(openFileDialog.FileName);
                progressPanel1.Visible = false;

                if (isSuccessfully)
                {
                    frmMessageBoxDev.ShowDialog("تمت العملية بنجاح", "معلومة", "حسنا", frmMessageBoxDev.ModeDialog.Information, frmMessageBoxDev.Focus.btn1);
                }
                else
                {
                    frmMessageBoxDev.ShowDialog("حدث خطا ما اثناء محاولة استعادة النسخة الاحتياطية", "خطا", "حسنا", frmMessageBoxDev.ModeDialog.Error, frmMessageBoxDev.Focus.btn1);
                }
            }
        }

        public static void OpenInExplorer(string folderPath)
        {
            try
            {
                // Ensure the folder path exists
                if (Directory.Exists(folderPath))
                {
                    // Use Process.Start to open the folder in Windows Explorer
                    Process.Start("explorer.exe", folderPath);
                }
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the process
            }
        }

        private void btnModeApp_Click(object sender, EventArgs e)
        {
            navigationFrame1.SelectedPage = navigationPageModeApp;


        }

        private void toggleSwitchMode_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitchMode.IsOn)
            {
                // Set the theme to "Office 2016 Black"
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2016 Black");
                labIconMode.Text = "🌙";
            }
            else
            {
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Basic");
                labIconMode.Text = "🌤️";
            }
        }



        public static bool IsRunningAsAdministrator()
        {
            // الحصول على هوية المستخدم الحالي
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            if (identity != null)
            {
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                // التحقق من إذا كان المستخدم ضمن مجموعة المسؤولين
                return principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
            return false;
        }
    }
}