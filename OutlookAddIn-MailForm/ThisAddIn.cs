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
using System.DirectoryServices.AccountManagement;


namespace OutlookAddIn_MailForm
{
    public partial class ThisAddIn
    {
        //private Outlook.MAPIFolder mySentFolder; 
        private Outlook.NameSpace outlookNameSpace;
        private Outlook.MAPIFolder outbox;        
        private Outlook.Items items;

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            //Create an event handler for when E-Mail-Items are sent
            //Application.ItemSend += new ApplicationEvents_11_ItemSendEventHandler(actionOnEmailSend);            
            //Howto Inbox/Outbox Event https://msdn.microsoft.com/de-de/library/ms268998.aspx
            outlookNameSpace = this.Application.GetNamespace("MAPI");
            outbox = outlookNameSpace.GetDefaultFolder(
                    Outlook.OlDefaultFolders.olFolderSentMail); //for inbox use Outlook.OlDefaultFolders.olFolderInbox

            items = outbox.Items;
            items.ItemAdd +=
                new Outlook.ItemsEvents_ItemAddEventHandler(actionEmailSend);
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
        private string Sachberarbeiter = UserPrincipal.Current.DisplayName; //Environment.UserName;
        public string SachBearb
        {
            get
            {
                return Sachberarbeiter;
            }
        }

        #endregion

        //TODO: Old Method not in use anymore
        private void actionOnEmailSend(object Item, ref bool Cancel)
        {
            bool saperion = false;
            // Get the Saperion Property in an Outlook Mail-Object to determine if Saperion is set true 
            try
            {
                Outlook.UserProperties mailUserProperties = null;                
                MailItem mailItem = Item as Outlook.MailItem;
                mailUserProperties = mailItem.UserProperties;
                saperion = mailUserProperties.Find("Saperion").Value;
                // remove Property for remail purpose without DTO Data
                // TODO: Hold the Property and open the DTO Window on Remail instead
                // Objekt, WE ...else has to add to the Mailobject as Properties  
                if (saperion)
                {
                    mailUserProperties.Find("Saperion").Value = false;
                }
            }
            catch 
            {
                //nothing
            }
            // Send E-Mail with or with out archiving 
            // and if ask for archiving or not 
            if (Properties.Settings.Default.autoarchiving)
            {
                if (saperion)
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

        private void actionEmailSend(object Item)
        {
            //new Version
            bool saperion = false;
            Outlook.UserProperties mailUserProperties = null; 
            Outlook.MailItem mail = (Outlook.MailItem)Item;
            mailUserProperties = mail.UserProperties;
            // Get the Saperion Property in an Outlook Mail-Object to determine if Saperion is set true 
            try
            {
                MailItem mailItem = Item as Outlook.MailItem;
                mailUserProperties = mailItem.UserProperties;
                if (mailUserProperties.Find("Saperion") != null)
                {
                    saperion = mailUserProperties.Find("Saperion").Value;
                }
                
                // remove Property for remail purpose without DTO Data
                // TODO: Hold the Property and open the DTO Window on Remail instead
                // Objekt, WE ...else has to add to the Mailobject as Properties  
                if (saperion)
                {
                    mailUserProperties.Find("Saperion").Value = false;
                    if (Item != null)
                    {
                        
                        // Send E-Mail with or with out archiving 
                        // and if ask for archiving or not 
                        if (Properties.Settings.Default.autoarchiving)
                        {
                            if (saperion)
                            {
                                if (Properties.Settings.Default.ask_before_archiving)
                                {
                                    DialogResult result = MessageBox.Show("Soll die E-Mail auch archiviert werden?",
                                "Saperion Archiv", MessageBoxButtons.YesNo);
                                    if (result == DialogResult.Yes)
                                    {
                                        this.msg_parameter.MailItem = mailItem;
                                        saveMailtoSaperion();                                        
                                        //mailItem.Close(Outlook.OlInspectorClose.olDiscard); // Hat nicht geholfen
                                    }
                                }
                                else
                                {
                                    saveMailtoSaperion();
                                    //mailItem.Close(Outlook.OlInspectorClose.olDiscard);  // Hat nicht geholfen
                                }
                            }
                        }
                    }
                }
            }
            catch 
            {
                //nothing
            }
            
            
        }

        private void saveMailtoSaperion()
        {
            // uses DTsaperionVBNETLib to archive the Mail by the Saperion-COM-Object
            try
            {
                Archivieren DtSap = new Archivieren(); //DTsaperionVBNETLib
                // lokal zwischenspreicherung der Mail fuer Aufruf in DTsaperionVBNETLib
                System.Reflection.Assembly assemblyInfo = System.Reflection.Assembly.GetExecutingAssembly();
                string FileLocation = Path.GetDirectoryName(assemblyInfo.Location);
                FileLocation += "mail.msg";
                this.msg_parameter.MailItem.SaveAs(FileLocation);
                // handout Parameters and archiving the Document
                this.msg_parameter.filelocaiton = FileLocation;
                string Subject = this.msg_parameter.MailItem.Subject;
                string Memo2 = msg_parameter.KreditorAdr + " - " + msg_parameter.KreditorName;
                DtSap.saveDokument(msg_parameter.filelocaiton, msg_parameter.Mandant, msg_parameter.Unternehmen,
                    msg_parameter.WE, msg_parameter.HausNr, msg_parameter.Wohnung, msg_parameter.FolgeNr,
                    msg_parameter.AdresseNr, msg_parameter.DokuArt, msg_parameter.VorgangKZ,
                    msg_parameter.Vorname, msg_parameter.Name, Sachberarbeiter, Subject,
                    msg_parameter.AdresseNr, Memo2, msg_parameter.datum2, msg_parameter.KreditorAdr, 
                    msg_parameter.KreditorName);  
            }
            catch (System.Exception e)
            {
                string msgtext = "Ein Fehler ist beim Archivieren aufgetreten, ggf. war z.B. der Betreff zu lang./n/n Full Saperion-Errortext: /n ";
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
