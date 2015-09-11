using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutlookAddIn_MailForm
{
    public partial class Frm_KalenderWoReport : Form
    {
        public Frm_KalenderWoReport()
        {
            InitializeComponent();
        }

        private void Frm_KalenderWoReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1_WoWi_WirtschaftseinheitTEST.Wirtschaftseinheit' table. You can move, or remove it, as needed.
            this.WirtschaftseinheitTableAdapter.Fill(this.DataSet1_WoWi_WirtschaftseinheitTEST.Wirtschaftseinheit);
            this.reportViewer1.RefreshReport();
        }
    }
}
