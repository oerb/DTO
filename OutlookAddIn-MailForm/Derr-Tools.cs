using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Outlook = Microsoft.Office.Interop.Outlook;
using dialog = System.Windows.Forms;
using System.Globalization;
using System.Windows.Forms;


namespace OutlookAddIn_MailForm
{
    public partial class DerrToolsRibbon1
    {
        public string MailBody = "Nix im Body";
        public string MailSubject = "Nix im Sybject";

        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void btn_schadensmeldung_Click(object sender, RibbonControlEventArgs e)
        {
            //opens Schadensmeldung dialog form
            //Schadensmeldung sam = new Schadensmeldung();
            //DialogResult result = sam.ShowDialog();
            
            // TODO: TESTING BUTTON REMOVE
            Frm_MSG frm_MSG = new Frm_MSG();
            DialogResult result = frm_MSG.ShowDialog();
            if (result == DialogResult.OK)
            {
                CreateMail(frm_MSG);
            }
           
        }

        private void button6_Click(object sender, RibbonControlEventArgs e)
        {
            //CreateMailItem();
            Frm_Settings frm_settings = new Frm_Settings();
            DialogResult result = frm_settings.ShowDialog();
        }

        // TODO: Exclude from Project - was just for testing
        private void buttonMangelruege_Click(object sender, RibbonControlEventArgs e)
        {
            //openTestForm();          
        }

        private void openTestForm()
        {
            //opens Mängelrüge dialog form
            Mangel ma = new Mangel();
            DialogResult result = ma.ShowDialog();
            if (result == DialogResult.OK)
            {
                //dialog.MessageBox.Show(ma.MailBody);
                this.MailBody = ma.MailBody;
                this.MailSubject = ma.MailSubject;
                try
                {
                    CreateMailItem();
                }
                catch
                {
                    MessageBox.Show("Error: CreateMailItem in Derr-Tools.cs Failed !!!");
                }

            }
        }

        private void CreateMailItem()
        {
            Outlook.Application application = Globals.ThisAddIn.Application;
            Outlook.ExchangeUser currentUser = application.Session.CurrentUser.AddressEntry.GetExchangeUser();
            Outlook.MailItem myMailItem = (Outlook.MailItem)application.CreateItem(Outlook.OlItemType.olMailItem);
            Outlook.MailItem myStorageItem = (Outlook.MailItem)application.Session.OpenSharedItem("C:\\Mängelruege4.msg");
            
            myMailItem.Subject = this.MailSubject;
            myMailItem.HTMLBody = myStorageItem.HTMLBody;
            myMailItem.Display();
        }

        private void CreateMail(Frm_MSG frm_MSG)
        {
            Outlook.Application application = Globals.ThisAddIn.Application;
            Outlook.ExchangeUser currentUser = application.Session.CurrentUser.AddressEntry.GetExchangeUser();
            Outlook.MailItem myMailItem = (Outlook.MailItem)application.CreateItem(Outlook.OlItemType.olMailItem);
            try
            {
                // load a Outlook Predesign by an Outlook Filetyp MSG
                Outlook.MailItem myStorageItem = (Outlook.MailItem)application.Session.OpenSharedItem(frm_MSG.filelocation);
                myMailItem.HTMLBody = myStorageItem.HTMLBody;
                // Parsing a nice Subject String out of the Form
                string subject = frm_MSG.mandant.ToString() + "/ " + frm_MSG.txt_objekt.Text + "/ " +
                    frm_MSG.HausNr.ToString()  + "/ " + frm_MSG.wohnung.ToString() 
                    + " : " + frm_MSG.Mieter.ToString() + " - " +
                    frm_MSG.lbl_mieter_txt.Text +
                    " : " + frm_MSG.kreditor.ToString() + " - " +
                    frm_MSG.lbl_kreditor_txt.Text + " : " + myStorageItem.Subject + " : " +
                    frm_MSG.txb_Subject.Text;
                myMailItem.Subject = subject;
                myMailItem.To = frm_MSG.eMail;
                // Desplay the Mail form with all Inherited
                Globals.ThisAddIn.MailItem = myMailItem;
                myMailItem.Display();  
            }
            catch //(Exception e)
            {
                string msgtxt = "Meldungstyp nicht gesetzt oder Dateipfad ist nicht korrekt."; // Exeption: " +e.ToString();
                MessageBox.Show(msgtxt);
            }       
        }

        private void btn_ServerSettings_Click(object sender, RibbonControlEventArgs e)
        {
            Frm_ServerSettings SeSe = new Frm_ServerSettings();
            DialogResult result = SeSe.ShowDialog();
        }

        private void btn_usersettings_Click(object sender, RibbonControlEventArgs e)
        {
            Frm_UserSettings frm_UsSe = new Frm_UserSettings();
            DialogResult result = frm_UsSe.ShowDialog();
        }
    }
}
