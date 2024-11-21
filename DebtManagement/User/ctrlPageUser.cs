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
using DevExpress.XtraGrid.Views.Grid;
using InternalDialog = DevExpress.Utils.CommonDialogs.Internal;
using System.Windows.Controls;
using DevExpress.XtraMap;
using DevExpress.XtraReports.UI;
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
            string UserType = string.Empty;

            if (gridViewUsers != null && gridViewUsers.FocusedRowHandle >= 0)
            {
                UserID = Convert.ToInt32(gridViewUsers.GetRowCellValue(gridViewUsers.FocusedRowHandle, "UserID"));
                UserType = gridViewUsers.GetRowCellValue(gridViewUsers.FocusedRowHandle, "UserType").ToString();
            }

            // If There Are Only One Manager Should Disable Select User Type (In Form "frmAddUpdateUser").
            bool isThereOnlyOnManager = isThereOnlyOneManagerInGrid();

            bool EnableSelectUserType = (UserType == "مدير" && isThereOnlyOnManager) ? false : true;

            frmAddUpdateUser frm = new frmAddUpdateUser(UserID, EnableSelectUserType);

            frm.ShowDialog();

            await LoadUser();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {

            // Select Current UserID.
            int UserID = -1;
            string UserName = "";
            string UserType = "";
            bool isThereOnlyOneManager = false;


            if (gridViewUsers != null && gridViewUsers.FocusedRowHandle >= 0)
            {
                UserID = Convert.ToInt32(gridViewUsers.GetRowCellValue(gridViewUsers.FocusedRowHandle, "UserID"));
                UserName = gridViewUsers.GetRowCellValue(gridViewUsers.FocusedRowHandle, "UserName").ToString();
                UserType = gridViewUsers.GetRowCellValue(gridViewUsers.FocusedRowHandle, "UserType").ToString();

                isThereOnlyOneManager = isThereOnlyOneManagerInGrid();
            }


            // If There Are Only One Manager Don't Deleted (Out Of this Function).
            if (isThereOnlyOneManager && UserType == "مدير")
            {
                frmMessageBoxDev.ShowDialog("لاتستطيع حذف هذا الحساب لانه المدير الوحيد", "خطا", "حسنا", frmMessageBoxDev.ModeDialog.Error, frmMessageBoxDev.Focus.btn1);
                return;
            }


            var result = frmMessageBoxDev.ShowDialog($"تاكيد عملية حذف {UserType} [{UserName}]", "تحذير", "حذف", "الغاء", frmMessageBoxDev.ModeDialog.Question);

            if (result == InternalDialog.DialogResult.Yes)
            {
                if (await clsUser.DeleteUserAsync(UserID))
                {
                    await LoadUser();
                    frmMessageBoxDev.ShowDialog($"تم حذف {UserType}", "نجت العملية", "حسنا", frmMessageBoxDev.ModeDialog.Information, frmMessageBoxDev.Focus.btn1);
                }
                else
                {
                    frmMessageBoxDev.ShowDialog($"حدث خطا اثناء حذف {UserType}", "حدث خطا", "حسنا", frmMessageBoxDev.ModeDialog.Error, frmMessageBoxDev.Focus.btn1);
                }
            }
        }

        
        private bool isThereOnlyOneManagerInGrid()
        {
            string FiledName = "UserType";
            string targetValue = "مدير";

            // Initialize the counter
            int count = 0;

            // Loop through all rows in the GridView
            for (int i = 0; i < gridViewUsers.RowCount; i++)
            {
                // Get the value of the cell in the specified column
                object cellValue = gridViewUsers.GetRowCellValue(i, FiledName);
                if (cellValue != null && cellValue.ToString() == targetValue)
                {
                    count++;

                    if (count > 1)
                        return false;
                }
            }

            return true;
        }
    }
}
