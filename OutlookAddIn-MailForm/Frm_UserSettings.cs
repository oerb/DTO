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
    public partial class Frm_UserSettings : Form
    {
        public Frm_UserSettings()
        {
            InitializeComponent();
        }

        private void Frm_UserSettings_Load(object sender, EventArgs e)
        {            
            this.tblDokuartTableAdapter.Fill(this.dataSet1_WOWI_SEARCH.tblDokuart);            
            if (Properties.Settings.Default.uDokuart != "")
            {
                this.cmb_dokuart.SelectedValue = Properties.Settings.Default.uDokuart;
            }
            if (Properties.Settings.Default.uVorgangKZ != "")
            {                
                this.cmb_vorgangkz.SelectedValue = Properties.Settings.Default.uVorgangKZ;
            }
        }

        private void cmb_dokuart_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.uDokuart = this.cmb_dokuart.Text;           
            Properties.Settings.Default.Save();
            // Fill VorgangKZ with Filtered Data
            //this.wOWIVORGANGTableAdapter.Fill_DOKUKZ(this.saperionDataSet_Dokuart_DokuKZ.WOWIVORGANG, this.cmb_dokuart.Text);
            this.tblVorgangKZTableAdapter.FillbyDokuart(this.dataSet1_WOWI_SEARCH.tblVorgangKZ, this.cmb_dokuart.Text);
        }

        private void cmb_vorgangkz_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.uVorgangKZ = this.cmb_vorgangkz.Text;
            Properties.Settings.Default.Save();
        }

        private void chb_auto_archiving_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
