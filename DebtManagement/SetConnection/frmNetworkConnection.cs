using clsMessageBox;
using DebtManagement_Business;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DebtManagement
{
    public partial class frmNetworkConnection : DevExpress.XtraEditors.XtraForm
    {
        public frmNetworkConnection()
        {
            InitializeComponent();
        }

        private void txtServerName_Enter(object sender, EventArgs e)
        {
            panelBottomBorder.Location = new Point(panelBottomBorder.Location.X, txtServerName.Location.Y + txtServerName.Size.Height);
        }

        private void txtDatabaseName_Enter(object sender, EventArgs e)
        {
            panelBottomBorder.Location = new Point(panelBottomBorder.Location.X, txtDatabaseName.Location.Y + txtDatabaseName.Size.Height);
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            panelBottomBorder.Location = new Point(panelBottomBorder.Location.X, txtUsername.Location.Y + txtUsername.Size.Height);
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            panelBottomBorder.Location = new Point(panelBottomBorder.Location.X, txtPassword.Location.Y + txtPassword.Size.Height);
        }


        private void btnSave_Click(object sender, EventArgs e)
        {

            frmMessageBoxDev.ShowDialog("البرنامج لايدعم الاتصال الشبكي في الوقت الحالي", "معلومة", "حسنا", frmMessageBoxDev.ModeDialog.Information);
        }
    }
}