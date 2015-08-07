using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using Office = Microsoft.Office.Core;
using Outlook = Microsoft.Office.Interop.Outlook;
using System.Windows.Forms;

namespace OutlookAddIn_MailForm
{
    public partial class Frm_MailMain
    {
        #region Formularbereichsfactory

        [Microsoft.Office.Tools.Outlook.FormRegionMessageClass("IPM.DTO.MailMain")]
        [Microsoft.Office.Tools.Outlook.FormRegionName("OutlookAddIn-MailForm.Frm_MailMain")]
        public partial class Frm_MailMainFactory
        {
            private void InitializeManifest()
            {
                ResourceManager resources = new ResourceManager(typeof(Frm_MailMain));
                this.Manifest.FormRegionType = Microsoft.Office.Tools.Outlook.FormRegionType.Replacement;
                this.Manifest.Title = resources.GetString("Title");
                this.Manifest.FormRegionName = resources.GetString("FormRegionName");
                this.Manifest.Description = resources.GetString("Description");
                this.Manifest.ShowInspectorCompose = true;
                this.Manifest.ShowInspectorRead = true;
                this.Manifest.ShowReadingPane = true;

            }

            // Tritt ein, bevor der Formularbereich initialisiert wird.
            // Um die Anzeige des Formularbereichs zu verhindern, legen Sie e.Cancel auf True fest.
            // Verwenden Sie e.OutlookItem, um einen Verweis auf das aktuelle Outlook-Element abzurufen.
            private void Frm_MailMainFactory_FormRegionInitializing(object sender, Microsoft.Office.Tools.Outlook.FormRegionInitializingEventArgs e)
            {
            }
        }

        #endregion

        // Tritt ein, bevor der Formularbereich angezeigt wird.
        // Verwenden Sie this.OutlookItem, um einen Verweis auf das aktuelle Outlook-Element abzurufen.
        // Verwenden Sie this.OutlookFormRegion, um einen Verweis auf den Formularbereich abzurufen.
        private void Frm_MailMain_FormRegionShowing(object sender, System.EventArgs e)
        {
            //this.cmd_Kreditor.Click += new System.EventHandler(this.cmd_Kreditor_click);
            this.cmd_Mieter.Click += new Outlook.OlkCommandButtonEvents_ClickEventHandler(this.cmd_Kreditor_click);

        }

        // Tritt ein, wenn der Formularbereich geschlossen wird.
        // Verwenden Sie this.OutlookItem, um einen Verweis auf das aktuelle Outlook-Element abzurufen.
        // Verwenden Sie this.OutlookFormRegion, um einen Verweis auf den Formularbereich abzurufen.
        private void Frm_MailMain_FormRegionClosed(object sender, System.EventArgs e)
        {
        }

        private void cmd_Kreditor_click()
        {
            MessageBox.Show("Button Works");
        }
        
    }
}
