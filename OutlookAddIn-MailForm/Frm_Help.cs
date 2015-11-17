using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace OutlookAddIn_MailForm
{
    public partial class Frm_Help : Form
    {
        public Frm_Help()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/oerb/DTO/wiki/DTO---Hilfe");
        }

        private void Frm_Help_Load(object sender, EventArgs e)
        {

        }

        private void llb_MeldungErstellen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/oerb/DTO/wiki/Help-DTO---Meldung");
        }

        private void llb_MSGtypEinstellung_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/oerb/DTO/wiki/HELP---MSG-Typ-Einstellungen");
        }

        private void llb_Issues_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/oerb/DTO/issues");
        }
    }
}
