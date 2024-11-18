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

namespace DebtManagement.Pages
{
    public partial class ctrlPage_Home : DevExpress.XtraEditors.XtraUserControl
    {
        DateTime dt = DateTime.Now;
        public ctrlPage_Home()
        {
            InitializeComponent();

            timer1.Start();
            labDateTime.Text = dt.ToString("yyy-MM-dd   hh:mm:ss tt");


            ctrlPage_Home_Load();
        }

        private void ctrlPage_Home_Load()
        {
            clsSettingsUser settingsUser = clsSettingsUser.FindSettingsUser(Properties.Settings.Default.Username);

            labCompanyName.Text = settingsUser.CompanyName;
            pictureBoxCompanyPicture.Image = LoadImageFromSettings(settingsUser.PictureData);
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            dt = dt.AddSeconds(1);
            labDateTime.Text = dt.ToString("yyy-MM-dd   hh:mm:ss tt");
        }
    }
}
