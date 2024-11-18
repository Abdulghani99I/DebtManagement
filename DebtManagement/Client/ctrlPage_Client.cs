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
using DevExpress.XtraVerticalGrid;
using clsMessageBox;
using DevExpress.DataAccess.Native.ObjectBinding;
using DevExpressInternal = DevExpress.Utils.CommonDialogs.Internal;


namespace DebtManagement.Pages
{
    public partial class ctrlPage_Clients : DevExpress.XtraEditors.XtraUserControl
    {
        public ctrlPage_Clients()
        {
            InitializeComponent();
        }

        private async void ctrlPage_Clients_Load(object sender, EventArgs e)
        {
            await ReloadTableClients();
            //SetColumnsName();
        }

        private async Task ReloadTableClients()
        {
            gridClients.DataSource = await clsClient.GetAllClientsAsync();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUpdateClient frm = new frmAddUpdateClient();
            frm.RefreshTable += ReloadTableClients;
            frm.ShowDialog();

            //await ReloadTableClients();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Select Current SupplerID.
            int SupplerID = -1;

            if (gridViewClients != null && gridViewClients.FocusedRowHandle >= 0)
            {
                SupplerID = Convert.ToInt32(gridViewClients.GetRowCellValue(gridViewClients.FocusedRowHandle, "ClientID"));
            }
            else
            {
                // In This Case No Rows In Table.
                frmMessageBoxDev.ShowDialog("الرجاء قم بتحديد العميل اولاً", "خطا", "حسنا", frmMessageBoxDev.ModeDialog.Error);
                return;
            }

            frmAddUpdateClient frm = new frmAddUpdateClient(SupplerID);
            frm.RefreshTable += ReloadTableClients;
            frm.ShowDialog();

            //await ReloadTableClients();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            await ReloadTableClients();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            // Select Current "Name Suppler" And "ClientID".
            string SupplerName = string.Empty;
            int ClientID = -1;

            //var view = gridClients.FocusedView as DevExpress.XtraGrid.Views.Grid.GridView;

            if (gridViewClients != null && gridViewClients.FocusedRowHandle >= 0)
            {
                SupplerName = (gridViewClients.GetRowCellValue(gridViewClients.FocusedRowHandle, "FullName")).ToString();
                ClientID = Convert.ToInt32(gridViewClients.GetRowCellValue(gridViewClients.FocusedRowHandle, "ClientID"));
            }
            else
            {
                // In This Case No Rows In Table.
                frmMessageBoxDev.ShowDialog("الرجاء قم بتحديد العميل اولاً", "خطا", "حسنا", frmMessageBoxDev.ModeDialog.Error);
                return;
            }

            if (frmMessageBoxDev.ShowDialog($"هل تريد حذف العميل [{SupplerName}]", "تحذير", "حذف", "الغاء", frmMessageBoxDev.ModeDialog.Question) == DevExpressInternal.DialogResult.Yes)
            {
                bool result = await clsClient.DeleteClientAsync(ClientID);

                if (result)
                {
                    await ReloadTableClients();
                    frmMessageBoxDev.ShowDialog($"تم حذف العميل [{SupplerName}] بنجاح", "معلومة", "حسنا", frmMessageBoxDev.ModeDialog.Information);
                }
                else
                {
                    frmMessageBoxDev.ShowDialog("ا حدث خطأ ما اثناء الحذف تاكد من تنظيف سجل العميل", "خطا", "حسنا", frmMessageBoxDev.ModeDialog.Error);
                }
            }
        }

        private async void btnShowRgistry_Click(object sender, EventArgs e)
        {
            int SupplerID = -1;

            if (gridViewClients != null && gridViewClients.FocusedRowHandle >= 0)
            {
                SupplerID = Convert.ToInt32(gridViewClients.GetRowCellValue(gridViewClients.FocusedRowHandle, "ClientID"));
            }


            frmViewRegisterClient frm = new frmViewRegisterClient(SupplerID);

            frm.ShowDialog();

            await ReloadTableClients();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            gridViewClients.ShowPrintPreview();
        }
    }
}