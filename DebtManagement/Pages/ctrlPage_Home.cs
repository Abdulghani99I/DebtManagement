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

namespace DebtManagement.Pages
{
    public partial class ctrlPage_Home : DevExpress.XtraEditors.XtraUserControl
    {
        DateTime dt = DateTime.Now;
        public ctrlPage_Home()
        {
            InitializeComponent();
            labDateTime.Text = dt.ToString();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dt = dt.AddSeconds(1);
            labDateTime.Text = dt.ToString("yyy-MM-dd hh:mm:ss");
        }
    }
}
