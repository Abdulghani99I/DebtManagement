using clsMessageBox;
using DebtManagement.User;
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
using InternalDialog = DevExpress.Utils.CommonDialogs.Internal;
namespace DebtManagement
{
    public partial class ctrlPageUser : DevExpress.XtraEditors.XtraUserControl
    {
        public ctrlPageUser()
        {
            InitializeComponent();
        }

        private async void ctrlPageUser_Load(object sender, EventArgs e)
        {
            await LoadUser();
        }

        private async Task LoadUser()
        {
            gridUsers.DataSource = await clsUser.GetAllUserAsync();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser();

            frm.ShowDialog();

            await LoadUser();
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadUser();
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            // Select Current UserID.
            int UserID = -1;

            if (gridViewUsers != null && gridViewUsers.FocusedRowHandle >= 0)
            {
                UserID = Convert.ToInt32(gridViewUsers.GetRowCellValue(gridViewUsers.FocusedRowHandle, "UserID"));
            }

            frmAddUpdateUser frm = new frmAddUpdateUser(UserID);

            frm.ShowDialog();

            await LoadUser();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            // Select Current UserID.
            int UserID = -1;
            string UserName = "";

            if (gridViewUsers != null && gridViewUsers.FocusedRowHandle >= 0)
            {
                UserID = Convert.ToInt32(gridViewUsers.GetRowCellValue(gridViewUsers.FocusedRowHandle, "UserID"));
                UserName = gridViewUsers.GetRowCellValue(gridViewUsers.FocusedRowHandle, "UserName").ToString();
            }

            var result = frmMessageBoxDev.ShowDialog($"تاكيد عملية حذف المستخدم [{UserName}]", "تحذير", "حذف", "الغاء", frmMessageBoxDev.ModeDialog.Question);

            if (result == InternalDialog.DialogResult.Yes)
            {
                if (await clsUser.DeleteUserAsync(UserID))
                {
                    await LoadUser();
                    frmMessageBoxDev.ShowDialog("تم حذف المستخدم", "نجت العملية", "حسنا", frmMessageBoxDev.ModeDialog.Information, frmMessageBoxDev.Focus.btn1);
                }
                else
                {
                    frmMessageBoxDev.ShowDialog("حدث خطا اثناء حذف المستخدم", "حدث خطا", "حسنا", frmMessageBoxDev.ModeDialog.Error, frmMessageBoxDev.Focus.btn1);
                }
            }
        }
    }
}
