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

namespace DebtManagement.SetConnection
{
    public partial class frmLocalConnection : DevExpress.XtraEditors.XtraForm
    {
        enum enStatusConnection { Connect, Disconnect};

        enStatusConnection _StatusConnection = enStatusConnection.Connect;

        public frmLocalConnection()
        {
            InitializeComponent();
        }

        private void frmLocalConnection_Load(object sender, EventArgs e)
        {
            CheckConnection();

        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            CheckConnection();
            

            if (_StatusConnection == enStatusConnection.Connect)
            {
                frmMessageBoxDev.ShowDialog("الاتصال ناجح", "معلومة", "حسنا", frmMessageBoxDev.ModeDialog.Information, frmMessageBoxDev.Focus.btn1);
            }
            else
            {
                frmMessageBoxDev.ShowDialog("هناك خطا في الاتصال بقاعدة البيانات", "معلومة", "حسنا", frmMessageBoxDev.ModeDialog.Information, frmMessageBoxDev.Focus.btn1);
            }
        }

        private void CheckConnection()
        {
            if (clsConnection.CheckCurrentDatabaseConnection())
            {
                labStatusConnection.Text = "الاتصال ناجح";
                labStatusConnection.ForeColor = Color.Green;
                pictureBox1.Image = Properties.Resources.wifi_100;

                _StatusConnection = enStatusConnection.Connect;
            }
            else
            {
                labStatusConnection.Text = "هناك خطا في الاتصال بقاعدة البيانات";
                labStatusConnection.ForeColor = Color.Red;
                pictureBox1.Image = Properties.Resources.offline_100;

                _StatusConnection = enStatusConnection.Disconnect;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmNetworkConnection frm = new frmNetworkConnection();

            frm.ShowDialog();
        }
    }
}