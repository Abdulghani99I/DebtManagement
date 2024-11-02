using DebtManagement.AddPAage;
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
using DebtManagement_Business;
using System.Windows.Controls;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;

namespace DebtManagement.Pages
{
    public partial class ctrlPage_Suppliers : DevExpress.XtraEditors.XtraUserControl
    {
        public ctrlPage_Suppliers()
        {
            InitializeComponent();
        }

        private async void ctrlPage_Suppliers_Load(object sender, EventArgs e)
        {
            gridSuppliers.DataSource = await clsSupplier.GetAllSuppliersAsync();

            SetColumnsName();
        }

        private void SetColumnsName()
        {
            var gridView = gridSuppliers.MainView as DevExpress.XtraGrid.Views.Grid.GridView;

            if (gridView != null)
            {
                gridView.Columns["FullName"].Caption = "اسم المورد";
                gridView.Columns["BalanceDinar"].Caption = "الرصيد (بالعراقي)";
                gridView.Columns["Phone"].Caption = "رقم الهاتف";
                gridView.Columns["Address"].Caption = "العنوان";
                gridView.Columns["CreatedAt"].Caption = "تاريخ الاضافة";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAdd_Supplier frm = new frmAdd_Supplier();

            frm.ShowDialog();
        }

        private void btnShowRgistry_Click(object sender, EventArgs e)
        {
            frmViewRegister frm = new frmViewRegister();

            frm.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

    }
}
