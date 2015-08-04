using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using System.Threading.Tasks;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;
using System.Globalization;
using dialog = System.Windows.Forms;
using DTsaperionVBNETLib;



namespace OutlookAddIn_MailForm
{
    public partial class Mangel : Form
    {
        public string MailBody;
        public string MailSubject;

        public Mangel()
        {
            InitializeComponent();
            cmb_Meldungstyp.Items.Add("Mängelrüge §4");
            cmb_Meldungstyp.Items.Add("Mängelrüge §13");
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            this.Close();         
        }

        private void cmb_Meldungstyp_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (this.cmb_Meldungstyp.SelectedItem.ToString() == "Mängelrüge §4")
           {
               this.MailSubject = Properties.Settings.Default["Mangel4"].ToString();
           }
           if (this.cmb_Meldungstyp.SelectedItem.ToString() == "Mängelrüge §13")
           {
               this.MailSubject = Properties.Settings.Default["Mangel13"].ToString();
           }
        }

        private void rtb_Meldungstext_TextChanged(object sender, EventArgs e)
        {
            this.MailBody = rtb_Meldungstext.Text;    
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void Mangel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'woWi_WirtschEinhDataSet.Wirtschaftseinheit' table. You can move, or remove it, as needed.
            //this.wirtschaftseinheitTableAdapter.Fill(this.woWi_WirtschEinhDataSet.Wirtschaftseinheit);
            // TODO: This line of code loads data into the 'wOWI_Mandant.Mandant' table. You can move, or remove it, as needed.
            this.mandantTableAdapter.Fill(this.wOWI_Mandant.Mandant);
        }

        private void cmb_Objekt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Saperion Example
            //filelocation As String, Mandant As Integer,
            //                     Unternehmen As Integer, WE As Integer,
            //                     HausNr As Integer, Wohnung As Integer,
            //                     AdresseNr As Integer, DokuArt As String,
            //                     VorgangKZ As String, Vorname As String,
            //                     Name As String)
            //string filelocation = @"E:\Projekte\SapTESTle.txt";
            //Archivieren DtSap = new Archivieren();
            //DtSap.saveDokument(filelocation);  
            
            //TESTING Current User
            //string msgtxt = Environment.UserName + "  System: " + System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            //MessageBox.Show(msgtxt);
            // Environment looks good for Sachbearbeiter to put in Saperion
        }
    }
}
