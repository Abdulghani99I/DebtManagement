using clsMessageBox;
using DebtManagement_Business;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DebtManagement.SetConnection
{
    public partial class frmLocalConnection : DevExpress.XtraEditors.XtraForm
    {
        enum enStatusConnection { Connect, Disconnect };

        public frmLocalConnection()
        {
            InitializeComponent();
        }

        private async void frmLocalConnection_Load(object sender, EventArgs e)
        {
            await LoadInfoConnection();
        }


        private async Task LoadInfoConnection()
        {
            bool isConnected = await clsConnection.CheckCurrentDatabaseConnectionAsync();

            if (isConnected)
            {
                labStatusConnection.Text = "الاتصال ناجح";
                labStatusConnection.ForeColor = Color.Green;

                string connectionString = ConfigurationManager.ConnectionStrings["DebtManagement"].ConnectionString;

                var builder = new SqlConnectionStringBuilder(connectionString);

                txtServerName.Text = builder.DataSource;
                txtDatabaseName.Text = builder.InitialCatalog;
                cmbTrustedConnection.SelectedIndex = builder.IntegratedSecurity ? 0 : 1; // index zero is equal true 1 equal false.
                comEncrypt.SelectedIndex = builder.Encrypt ? 0 : 1;
            }
            else
            {
                labStatusConnection.Text = "هناك خطا في الاتصال بقاعدة البيانات";
                labStatusConnection.ForeColor = Color.Red;
            }
        }


        private async void btnSave_Click(object sender, EventArgs e)
        {
            progressPanel1.Visible = true;

            string ConnectionString = $"Server = {txtServerName.Text}; Database = {txtDatabaseName.Text};  Trusted_Connection = {cmbTrustedConnection.Text}; Encrypt = {comEncrypt.Text};";
            bool isConnected = await clsConnection.CheckDatabaseConnectionAsync(ConnectionString);

            progressPanel1.Visible = false;
            if (isConnected)
            {
                labStatusConnection.Text = "الاتصال ناجح";
                labStatusConnection.ForeColor = Color.Green;

                if (UpdateConnectionString(ConnectionString))
                {
                    frmMessageBoxDev.ShowDialog("تم حفظ اعدادات الاتصال المحلي", "معلومة", "حسنا", frmMessageBoxDev.ModeDialog.Information, frmMessageBoxDev.Focus.btn1);
                }
            }
            else
            {
                labStatusConnection.Text = "هناك خطا في الاتصال بقاعدة البيانات";
                labStatusConnection.ForeColor = Color.Red;
                frmMessageBoxDev.ShowDialog("هناك خطا في الاتصال بقاعدة البيانات", "معلومة", "حسنا", frmMessageBoxDev.ModeDialog.Information, frmMessageBoxDev.Focus.btn1);
            }

            this.Close();
        }


        private async void btnTestConnection_Click(object sender, EventArgs e)
        {

            progressPanel1.Visible = true;
            string ConnectionString = $"Server = {txtServerName.Text}; Database = {txtDatabaseName.Text};  Trusted_Connection = {cmbTrustedConnection.Text}; Encrypt = {comEncrypt.Text};";
            bool isConnected = await clsConnection.CheckDatabaseConnectionAsync(ConnectionString);

            progressPanel1.Visible = false;
            if (isConnected)
            {
                labStatusConnection.Text = "الاتصال ناجح";
                labStatusConnection.ForeColor = Color.Green;
                frmMessageBoxDev.ShowDialog("الاتصال ناجح", "معلومة", "حسنا", frmMessageBoxDev.ModeDialog.Information, frmMessageBoxDev.Focus.btn1);
            }
            else
            {
                labStatusConnection.Text = "هناك خطا في الاتصال بقاعدة البيانات";
                labStatusConnection.ForeColor = Color.Red;
                frmMessageBoxDev.ShowDialog("هناك خطا في الاتصال بقاعدة البيانات", "معلومة", "حسنا", frmMessageBoxDev.ModeDialog.Information, frmMessageBoxDev.Focus.btn1);
            }
        }


        private void llabNetworkConnection_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmNetworkConnection frm = new frmNetworkConnection();

            frm.ShowDialog();
        }

        private void txtServerName_Enter(object sender, EventArgs e)
        {
            panelBottomBorder.Location = new Point(panelBottomBorder.Location.X, txtServerName.Location.Y + txtServerName.Size.Height);
        }

        private void txtDatabaseName_Enter(object sender, EventArgs e)
        {
            panelBottomBorder.Location = new Point(panelBottomBorder.Location.X, txtDatabaseName.Location.Y + txtDatabaseName.Size.Height);
        }

        private void cmbTrustedConnection_Enter(object sender, EventArgs e)
        {
            panelBottomBorder.Location = new Point(panelBottomBorder.Location.X, cmbTrustedConnection.Location.Y + cmbTrustedConnection.Size.Height);
        }

        private void comEncrypt_Enter(object sender, EventArgs e)
        {
            panelBottomBorder.Location = new Point(panelBottomBorder.Location.X, comEncrypt.Location.Y + comEncrypt.Size.Height);
        }

        private static bool UpdateConnectionString(string newConnectionString)
        {
            string name = "DebtManagement";

            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            var connectionStringsSection = config.ConnectionStrings;

            if (connectionStringsSection.ConnectionStrings[name] != null)
            {
                connectionStringsSection.ConnectionStrings[name].ConnectionString = newConnectionString;

                config.Save(ConfigurationSaveMode.Modified);

                return true;
            }
            else
            {
                return false;
            }
        }

        private void comEncrypt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}