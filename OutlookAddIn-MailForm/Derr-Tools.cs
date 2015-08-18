﻿using System;
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

        // TODO: OLD remove this ?!
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
            
            //Globals.ThisAddIn.msg_parameter = frm_MSG.msg_parameter;
            Outlook.Application application = Globals.ThisAddIn.Application;
            Outlook.ExchangeUser currentUser = application.Session.CurrentUser.AddressEntry.GetExchangeUser();
            Outlook.MailItem myMailItem = (Outlook.MailItem)application.CreateItem(Outlook.OlItemType.olMailItem);
            try
            {
                // load a Outlook Predesign by an Outlook Filetyp MSG
                Outlook.MailItem myStorageItem = (Outlook.MailItem)application.Session.OpenSharedItem(frm_MSG.filelocation);
                myMailItem.HTMLBody = myStorageItem.HTMLBody;
                
                // proof if Kreditor or Mieter is Set an Preset the String Var in common
                string kreditor = "";
                if(frm_MSG.kreditor != 0)
                {
                    kreditor = " : " + frm_MSG.kreditor.ToString() + " - " +
                    frm_MSG.lbl_kreditor_txt.Text;
                }
                string mieter = "";
                if(frm_MSG.Mieter != 0)
                {
                    mieter = " : " + frm_MSG.Mieter.ToString() + " - " +
                    frm_MSG.lbl_mieter_txt.Text;
                }
                string wohnung = "";
                if (frm_MSG.wohnung != 0)
                {
                    wohnung = "/ " + frm_MSG.wohnung.ToString() + " - " + frm_MSG.txt_objekt.Text + " - " +
                        frm_MSG.lbl_haus_txt.Text;
                }
                // Parsing a nice Subject String out of the Form
                string subject = "U/W/H/WO:"+ frm_MSG.mandant.ToString() + "/ " + frm_MSG.txt_objekt.Text + "/ " +
                    frm_MSG.HausNr.ToString()  + wohnung
                     + mieter + kreditor +
                     " : " + myStorageItem.Subject + " : " +
                    frm_MSG.txb_Subject.Text;
                myMailItem.Subject = subject;
                // set prefillifo about E-Mail in Mail-TO:
                myMailItem.To = frm_MSG.eMail;
                myMailItem = this.replaceFormfields(myMailItem, frm_MSG, Globals.ThisAddIn.msg_parameter);
                // Desplay the Mail form with all Inherited
                Globals.ThisAddIn.msg_parameter.MailItem = myMailItem;               
                myMailItem.Display();
               
            }
            catch //(Exception e)
            {
                string msgtxt = "Meldungstyp nicht gesetzt oder Dateipfad ist nicht korrekt."; // Exeption: " +e.ToString();
                MessageBox.Show(msgtxt);
            }       
        }

        // All Parameters from Frm_MSG.cs to use im Mailboddy
        private Outlook.MailItem replaceFormfields(Outlook.MailItem myMailItem, Frm_MSG frm_MSG, MSG_Parameter msg_parameter)
        {
            string datum1 = msg_parameter.datum1.ToString("dd.MM.yyyy");
            string datum2 = msg_parameter.datum2.ToString("dd.MM.yyyy");
            myMailItem.HTMLBody = myMailItem.HTMLBody.Replace("[Mandant]", msg_parameter.Mandant.ToString());
            myMailItem.HTMLBody = myMailItem.HTMLBody.Replace("[Unternehmen]", msg_parameter.Unternehmen.ToString());
            myMailItem.HTMLBody = myMailItem.HTMLBody.Replace("[WE]", msg_parameter.WE.ToString());
            myMailItem.HTMLBody = myMailItem.HTMLBody.Replace("[HAUSNR]", msg_parameter.HausNr.ToString());
            myMailItem.HTMLBody = myMailItem.HTMLBody.Replace("[NE]", msg_parameter.Wohnung.ToString());
            string adr = Globals.ThisAddIn.msg_parameter.AdresseNr.ToString();
            myMailItem.HTMLBody = myMailItem.HTMLBody.Replace("[ADRNR]", adr);
            myMailItem.HTMLBody = myMailItem.HTMLBody.Replace("[DOKUART]", msg_parameter.DokuArt);
            myMailItem.HTMLBody = myMailItem.HTMLBody.Replace("[VORGANGKZ]", msg_parameter.VorgangKZ);
            myMailItem.HTMLBody = myMailItem.HTMLBody.Replace("[FOLGENR]", msg_parameter.FolgeNr.ToString());
            myMailItem.HTMLBody = myMailItem.HTMLBody.Replace("[Name]", msg_parameter.Name);
            myMailItem.HTMLBody = myMailItem.HTMLBody.Replace("[Vorname]", msg_parameter.Vorname);
            myMailItem.HTMLBody = myMailItem.HTMLBody.Replace("[Sachbearbeiter]", Globals.ThisAddIn.SachBearb);
            myMailItem.HTMLBody = myMailItem.HTMLBody.Replace("[Datum1]", datum1);          
            myMailItem.HTMLBody = myMailItem.HTMLBody.Replace("[Datum2]", datum2 );
            myMailItem.HTMLBody = myMailItem.HTMLBody.Replace("[WEBEZEICHNUNG]", msg_parameter.WeBeszeichnung);
            myMailItem.HTMLBody = myMailItem.HTMLBody.Replace("[NESTRASSE]", msg_parameter.NeStrasse);
            myMailItem.HTMLBody = myMailItem.HTMLBody.Replace("[NEORT]", msg_parameter.NeOrt);
            myMailItem.HTMLBody = myMailItem.HTMLBody.Replace("[NEETAGE]", msg_parameter.NeEtage);
            myMailItem.HTMLBody = myMailItem.HTMLBody.Replace("[MITEL]", msg_parameter.MiTel);
            myMailItem.HTMLBody = myMailItem.HTMLBody.Replace("[MITEL2]", msg_parameter.MiTel2);
            myMailItem.HTMLBody = myMailItem.HTMLBody.Replace("[MIMOB]", msg_parameter.MiMob);
            myMailItem.HTMLBody = myMailItem.HTMLBody.Replace("[KREDITORNAME]", msg_parameter.KreditorName);
            // TODO: Remove this Helper MSGBox
            //string msgtext = "Datum1 ist: " + datum1 + " Datum2 ist: " + datum2 + " AdresseNr: " + adr;
            //MessageBox.Show(msgtext);
            return myMailItem;
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

        private void btn_Info_Click(object sender, RibbonControlEventArgs e)
        {
            System.Reflection.Assembly assemblyInfo = System.Reflection.Assembly.GetExecutingAssembly();


            string boxtext = "This is an Alpha Version of DTO";
            boxtext += "\n\n GPL v. 3 Copyright 2015 by Björn Leppin, Hilden, Germany";
            boxtext += "\n\n Pojektside: https://github.com/oerb/DTO \n\n";
            boxtext += assemblyInfo.FullName.ToString();
            MessageBox.Show(boxtext, "DTO Information", MessageBoxButtons.OK ,MessageBoxIcon.Information);
        }
    }
}
