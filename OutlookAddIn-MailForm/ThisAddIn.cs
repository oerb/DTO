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
using System.IO;


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
        
        #region publicProperties

        //public string filelocaiton;
        //public int Mandant = 0;
        //public int Unternehmen = 0;
        //public int WE = 0;
        //public int HausNr = 0;
        //public int Wohnung = 0;
        //public int AdresseNr = 0;
        //public string DokuArt = "DT_Mail";
        //public string VorgangKZ = "DT_Mail";
        //public string Vorname = "";
        //public string Name = "";
        //public int FolgeNr = 0;
        //public Outlook.MailItem MailItem;
        //public DateTime datum1 = DateTime.Now;
        //public DateTime datum2 = DateTime.Now;
        //public string WeBeszeichnung = "";
        //public string NeStrasse = "";
        //public string NeOrt = "";
        //public string NeEtage = "";
        //public string MiTel = "";
        //public string MiMob = "";
        //public string KreditorName = "";
        
        // NEW
        
        public MSG_Parameter msg_parameter;
        public bool ArchivingAktive = false;
        private string Sachberarbeiter = Environment.UserName;
        public string SachBearb
        {
            get
            {
                return Sachberarbeiter;
            }
        }

        #endregion

        private void actionOnEmailSend(object Item, ref bool Cancel)
        {
            // Send E-Mail with or with out archiving 
            // and if ask for archiving or not 
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
                    // Set archiving back to Standard
                    this.ArchivingAktive = false;
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


            try
            {
                Archivieren DtSap = new Archivieren();
                System.Reflection.Assembly assemblyInfo = System.Reflection.Assembly.GetExecutingAssembly();
                string FileLocation = Path.GetDirectoryName(assemblyInfo.Location);
                FileLocation += "mail.msg";
                this.msg_parameter.MailItem.SaveAs(FileLocation);
                this.msg_parameter.filelocaiton = FileLocation;
                //this.msg_parameter.MailItem.SaveAs(@"C:\Install\DTO\mail.msg");
                //this.msg_parameter.filelocaiton = @"C:\Install\DTO\mail.msg";
                string Subject = this.msg_parameter.MailItem.Subject;
                string Memo2 = msg_parameter.KreditorAdr + " - " + msg_parameter.KreditorName;
                // string Subject2 = Subject.Substring(0, 149);
                DtSap.saveDokument(msg_parameter.filelocaiton, msg_parameter.Mandant, msg_parameter.Unternehmen,
                    msg_parameter.WE, msg_parameter.HausNr, msg_parameter.Wohnung, msg_parameter.FolgeNr,
                    msg_parameter.AdresseNr, msg_parameter.DokuArt, msg_parameter.VorgangKZ,
                    msg_parameter.Vorname, msg_parameter.Name, Sachberarbeiter, Subject,
                    msg_parameter.AdresseNr, Memo2, msg_parameter.datum2);  
            }
            catch (System.Exception e)
            {
                string msgtext = "Ein Fehler ist beim Archivieren aufgetreten, ggf. war z.B. der Betreff zu lang:/n ";
                msgtext += e.ToString();
                MessageBox.Show(msgtext);
                throw;
            }            
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
