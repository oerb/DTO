using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Interop.Outlook;
using System.Windows.Forms;
using DTsaperionVBNETLib;


namespace OutlookAddIn_MailForm
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            //Create an event handler for when items are sent
            Application.ItemSend += new ApplicationEvents_11_ItemSendEventHandler(actionOnEmailSend);
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        // Public Properties
        #region

        public string filelocaiton;
        public int Mandant = 0;
        public int Unternehmen = 0;
        public int WE = 0;
        public int HausNr = 0;
        public int Wohnung = 0;
        public int AdresseNr = 0;
        public string DokuArt = "DT_Mail";
        public string VorgangKZ = "DT_Mail";
        public string Vorname = "";
        public string Name = "";
        public Outlook.MailItem MailItem;
        private string Sachberarbeiter = Environment.UserName;
        public bool ArchivingAktive = false;

        
        #endregion

        private void actionOnEmailSend(object Item, ref bool Cancel)
        {

            if (Properties.Settings.Default.autoarchiving)
            {
                if (this.ArchivingAktive)
                {

                    if (Properties.Settings.Default.ask_before_archiving)
                    {
                        DialogResult result = MessageBox.Show("Soll die E-Mail auch archiviert werden?",
                    "Saperion Archiv", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            saveMailtoSaperion();
                        } 
                    }
                    else
                    {
                        saveMailtoSaperion();
                    }
                } 
            }
        }

        private void saveMailtoSaperion()
        {
            // MessageBox.Show("Uhh you send an E-Mail by DT");
            // Saperion Example
            //filelocation As String, Mandant As Integer,
            //                     Unternehmen As Integer, WE As Integer,
            //                     HausNr As Integer, Wohnung As Integer,
            //                     AdresseNr As Integer, DokuArt As String,
            //                     VorgangKZ As String, Vorname As String,
            //                     Name As String)
            
                Archivieren DtSap = new Archivieren();
                //string newfilelocation = System.Uri.UnescapeDataString(filelocaiton);
                MailItem.SaveAs(@"E:\Projekte\Development\TEST\mail.msg");
                filelocaiton = @"E:\Projekte\Development\TEST\mail.msg";
                string Subject = MailItem.Subject;
                DtSap.saveDokument(filelocaiton, Mandant, Unternehmen, WE, HausNr, Wohnung, AdresseNr,
                    DokuArt, VorgangKZ, Vorname, Name, Sachberarbeiter, Subject);   
            
        }
        #region Von VSTO generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
