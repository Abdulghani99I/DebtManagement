using DebtManagement;
using DebtManagement.AddPAage;
using DebtManagement.SetConnection;
using DebtManagement.Settings;
using DebtManagement.SupplierForms;
using DebtManagement.User;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.XtraRichEdit.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DebtManagement1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmStartApp());
        }
    }
}
