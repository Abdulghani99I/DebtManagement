using DebtManagement_Business;
using DebtManagement_Data;
using DevExpress.DataAccess.Native.Sql;
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

namespace DebtManagement.Analysis
{
    public partial class ctrlAnalysis : DevExpress.XtraEditors.XtraUserControl
    {
        public ctrlAnalysis()
        {
            InitializeComponent();
        }

        private async void ctrlAnalysis_Load(object sender, EventArgs e)
        {
            decimal SuppliersDebt = await clsSupplier.GetTotalSuppliersDebt();
            decimal SuppliersPayments = await clsSupplier.GetTotalSuppliersPayments();

            decimal ClientsDebt = await clsClient.GetTotalClientsDebt();
            decimal ClientsPayments = await clsClient.GetTotalClientsPayments();


            // Set Percentage Debt And Payments Suppliers;
            if (SuppliersDebt != 0)
            {
                int PercentagePaymentsSuppliers = (int)((SuppliersPayments / SuppliersDebt) * 100);
                labPercentageSuppliersPayments.Text = PercentagePaymentsSuppliers + "%";
                labPercentageSuppliersDebt.Text = (100 - PercentagePaymentsSuppliers) + "%";
            }


            // Set Percentage Debt And Payments Clients;
            if (ClientsDebt != 0)
            {
                int PercentagePaymentsClients = (int)((ClientsPayments / ClientsDebt) * 100);
                labPercentageClientsPayments.Text = PercentagePaymentsClients + "%";
                labPercentageClientsDebt.Text = (100 - PercentagePaymentsClients) + "%";
            }
            // Set Suppliers Debt As MaxValue. And Value Is Suppliers Payments.
            arcScaleComponentSuppliers.MaxValue = (float)SuppliersDebt;
            arcScaleComponentSuppliers.Value = (float)SuppliersPayments;

            // Set Clients Debt As MaxValue. And Value Is Client Payments.
            arcScaleComponentClients.MaxValue = (float)ClientsDebt;
            arcScaleComponentClients.Value = (float)ClientsPayments;


            labTotalSuppliersDebt.Text = SuppliersDebt.ToString("N0");
            labTotalSuppliersPayments.Text = SuppliersPayments.ToString("N0");

            labTotalClientsDebt.Text = ClientsDebt.ToString("N0");
            labTotalClientsPayments.Text = ClientsPayments.ToString("N0");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ctrlAnalysis_Load(null, null);
        }
    }
}
