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

namespace DebtManagement
{
    public partial class Main : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoadHomePage();
        }

       
        private void btnHome_Click(object sender, EventArgs e)
        {
            LoadHomePage();
        }

        private void LoadHomePage()
        {
            ctrlPage_Home page = new ctrlPage_Home();
            LoadPage(page);
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            ctrlPage_Suppliers page = new ctrlPage_Suppliers();

            LoadPage(page);
        }

        private void btnClients_Click(object sender, EventArgs e)
        {

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {

        }

        private void btnAnalysis_Click(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }

        private void LoadPage(XtraUserControl Page)
        {
            panelContainer.Controls.Clear();

            panelContainer.AddControl(Page);
            Page.Dock = DockStyle.Fill;
        }

    }
}
