using DebtManagement.Reports;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DebtManagement
{
    public partial class ctrlPrintReports : DevExpress.XtraEditors.XtraUserControl
    {
        public ctrlPrintReports()
        {
            InitializeComponent();
        }

        private void btnPrintReportSuppliers_Click(object sender, EventArgs e)
        {
            ReportSuppliers reportsSuppliers = new ReportSuppliers();


            reportsSuppliers.ShowPreviewDialog();

        }

        private void btnPrintReportClients_Click(object sender, EventArgs e)
        {
            ReportClients reportsClients = new ReportClients();


            reportsClients.ShowPreviewDialog();

        }
    }
}
