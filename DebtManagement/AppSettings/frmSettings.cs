using clsMessageBox;
using DebtManagement.SetConnection;
using DebtManagement_Business;
using DevExpress.XtraEditors;
using DevExpress.XtraSpreadsheet.Forms;
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

            txtCompanyName.Text = _settingUsere.CompanyName;

            richtxtDescription.Text = _settingUsere.CompanyDescription;

            pictureEdit1.Image = LoadImageFromSettings(_settingUsere.PictureData);

            txtConversionAmount.Text = _settingUsere.ConversionValue.ToString();
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

        public Image LoadImageFromSettings(string base64String)
        {
            if (!string.IsNullOrEmpty(base64String))
            {
                byte[] imageBytes = Convert.FromBase64String(base64String);
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    return Image.FromStream(ms); // Convert to Image object
                }
            }
            return null; // Return null if no image is saved
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

        private void btnBackUp_Click(object sender, EventArgs e)
        {

        }

        private void btnRestoreDatabase_Click(object sender, EventArgs e)
        {

        }
    }
}