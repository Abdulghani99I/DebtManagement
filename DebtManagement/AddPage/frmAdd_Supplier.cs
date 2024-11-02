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

namespace DebtManagement.AddPAage
{
    public partial class frmAdd_Supplier : XtraForm
    {
        public frmAdd_Supplier()
        {
            InitializeComponent();
        }

        private void txtClientName_Enter(object sender, EventArgs e)
        {
            panelBorderBottom.Location = new Point(panelBorderBottom.Location.X, txtClientName.Location.Y + txtClientName.Size.Height);
        }

        private void txtAddress_Enter(object sender, EventArgs e)
        {
            panelBorderBottom.Location = new Point(panelBorderBottom.Location.X, txtAddress.Location.Y + txtAddress.Size.Height);
        }

        private void txtPhone_Enter(object sender, EventArgs e)
        {
            panelBorderBottom.Location = new Point(panelBorderBottom.Location.X, txtPhone.Location.Y + txtPhone.Size.Height);
        }
    }
}