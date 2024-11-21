using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Utils.Extensions;
using DebtManagement.Pages;
using System.Windows.Controls;
using System.Threading.Tasks;
using DevExpress.XtraGrid.Tab;
using DebtManagement.User;
using DebtManagement.SetConnection;
using DebtManagement.Analysis;
using DebtManagement_Business;
using DebtManagement.Settings;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using clsMessageBox;

namespace DebtManagement
{
    public partial class Main : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {

        public delegate void myDelegate(object sender, EventArgs e);

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {


            barBtnUsername.Caption = Properties.Settings.Default.Username;
            barBtnUserPermission.Caption = (Properties.Settings.Default.IsManager ? "مدير" : "مستخدم");

            ctrlPage_Home page = new ctrlPage_Home();

            LoadPage(page, "الرئيسية");
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            if (tabControl.TabPages.Count > 0)
                tabControl.SelectedTabPage = tabControl.TabPages[0];
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            ctrlPage_Suppliers page = new ctrlPage_Suppliers();

            LoadPage(page, "الموردين");
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            ctrlPage_Clients page = new ctrlPage_Clients();

            LoadPage(page, "العملاء");
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            // Check On User Permission 
            if (!Properties.Settings.Default.IsManager)
            {
                frmMessageBoxDev.ShowDialog("ليس لديك الصلاحية الكافية للقيام بهذه العلملية", "خطا", "حسنا", frmMessageBoxDev.ModeDialog.Error, frmMessageBoxDev.Focus.btn1);
                return;
            }

            ctrlPageUser page = new ctrlPageUser();

            LoadPage(page, "المستخدمين");
        }

        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            ctrlAnalysis page = new ctrlAnalysis();

            LoadPage(page, "التحليل");
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmSettings frm = new frmSettings();

            frm.ShowDialog();
        }


        private void tabControl_CloseButtonClick(object sender, EventArgs e)
        {
            // If Tab Page Not Home Page Remove It.
            if (tabControl.SelectedTabPage != tabControl.TabPages[0])
            {
                int IndexCurrentTab = tabControl.SelectedTabPageIndex;

                tabControl.TabPages.Remove(tabControl.SelectedTabPage);

                tabControl.SelectedTabPage = tabControl.TabPages[IndexCurrentTab - 1]; // Select Previous Tab Before Remove Current Tab.

            }
        }

        private void barBtnSetConnection_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmLocalConnection frm = new frmLocalConnection();

            frm.ShowDialog();

        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ctrlPrintReports ctrlPrintReports = new ctrlPrintReports();

            LoadPage(ctrlPrintReports, "طباعة التقارير");

        }



        private void LoadPage(XtraUserControl Page, string TabName)
        {
            var existingTab = tabControl.TabPages.Cast<DevExpress.XtraTab.XtraTabPage>()
                               .FirstOrDefault(tab => tab.Text == TabName);

            if (existingTab == null)
            {
                var newTabPage = new DevExpress.XtraTab.XtraTabPage();
                newTabPage.Text = TabName;

                tabControl.TabPages.Add(newTabPage);

                tabControl.SelectedTabPage = newTabPage;

                if (TabName == "الرئيسية")
                {
                    // Disable Close Button In Tab Home.
                    newTabPage.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
                }

                newTabPage.AddControl(Page);
                Page.Dock = DockStyle.Fill;
            }
            else
            {
                tabControl.SelectedTabPage = existingTab;
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void fluentDesignFormControl_Click(object sender, EventArgs e)
        {

        }

        private void barBtnLogOut_ItemClick(object sender, ItemClickEventArgs e)
        {
            btnLogOut_Click(null, null);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutApp frm = new AboutApp();

            frm.ShowDialog();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
