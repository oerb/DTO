namespace OutlookAddIn_MailForm
{
    partial class DerrToolsRibbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public DerrToolsRibbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">"true", wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls "false".</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für Designerunterstützung -
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DerrToolsRibbon1));
            this.tab2 = this.Factory.CreateRibbonTab();
            this.DerrTool_HSM_RibbonGroup = this.Factory.CreateRibbonGroup();
            this.btn_schadensmeldung = this.Factory.CreateRibbonButton();
            this.RibGroup_Development = this.Factory.CreateRibbonGroup();
            this.buttonMangelruege = this.Factory.CreateRibbonButton();
            this.groupEinstellungen = this.Factory.CreateRibbonGroup();
            this.btn_Settings = this.Factory.CreateRibbonButton();
            this.btn_ServerSettings = this.Factory.CreateRibbonButton();
            this.btn_usersettings = this.Factory.CreateRibbonButton();
            this.tab2.SuspendLayout();
            this.DerrTool_HSM_RibbonGroup.SuspendLayout();
            this.RibGroup_Development.SuspendLayout();
            this.groupEinstellungen.SuspendLayout();
            // 
            // tab2
            // 
            this.tab2.Groups.Add(this.DerrTool_HSM_RibbonGroup);
            this.tab2.Groups.Add(this.RibGroup_Development);
            this.tab2.Groups.Add(this.groupEinstellungen);
            this.tab2.Label = "DERR TOOLS";
            this.tab2.Name = "tab2";
            // 
            // DerrTool_HSM_RibbonGroup
            // 
            this.DerrTool_HSM_RibbonGroup.Items.Add(this.btn_schadensmeldung);
            this.DerrTool_HSM_RibbonGroup.Label = "Main";
            this.DerrTool_HSM_RibbonGroup.Name = "DerrTool_HSM_RibbonGroup";
            // 
            // btn_schadensmeldung
            // 
            this.btn_schadensmeldung.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btn_schadensmeldung.Image = global::OutlookAddIn_MailForm.Properties.Resources._1438712863_open_mail;
            this.btn_schadensmeldung.Label = "Meldung";
            this.btn_schadensmeldung.Name = "btn_schadensmeldung";
            this.btn_schadensmeldung.ScreenTip = "Eine neu Meldung mit Archivfilterinformation generieren.";
            this.btn_schadensmeldung.ShowImage = true;
            this.btn_schadensmeldung.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_schadensmeldung_Click);
            // 
            // RibGroup_Development
            // 
            this.RibGroup_Development.Items.Add(this.buttonMangelruege);
            this.RibGroup_Development.Label = "Development";
            this.RibGroup_Development.Name = "RibGroup_Development";
            this.RibGroup_Development.Visible = false;
            // 
            // buttonMangelruege
            // 
            this.buttonMangelruege.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonMangelruege.Image = ((System.Drawing.Image)(resources.GetObject("buttonMangelruege.Image")));
            this.buttonMangelruege.Label = "TESTING";
            this.buttonMangelruege.Name = "buttonMangelruege";
            this.buttonMangelruege.ShowImage = true;
            this.buttonMangelruege.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonMangelruege_Click);
            // 
            // groupEinstellungen
            // 
            this.groupEinstellungen.Items.Add(this.btn_Settings);
            this.groupEinstellungen.Items.Add(this.btn_ServerSettings);
            this.groupEinstellungen.Items.Add(this.btn_usersettings);
            this.groupEinstellungen.Label = "Einstellungen";
            this.groupEinstellungen.Name = "groupEinstellungen";
            // 
            // btn_Settings
            // 
            this.btn_Settings.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btn_Settings.Image = ((System.Drawing.Image)(resources.GetObject("btn_Settings.Image")));
            this.btn_Settings.Label = "MSG Typen";
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.ScreenTip = "Meldungstypen Erstellen und mit E-Mail-Vorlagen verknüpfen.";
            this.btn_Settings.ShowImage = true;
            this.btn_Settings.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button6_Click);
            // 
            // btn_ServerSettings
            // 
            this.btn_ServerSettings.Image = ((System.Drawing.Image)(resources.GetObject("btn_ServerSettings.Image")));
            this.btn_ServerSettings.Label = "Server";
            this.btn_ServerSettings.Name = "btn_ServerSettings";
            this.btn_ServerSettings.ScreenTip = "WoWi und Saperion Serververbindung konfigurieren.";
            this.btn_ServerSettings.ShowImage = true;
            this.btn_ServerSettings.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_ServerSettings_Click);
            // 
            // btn_usersettings
            // 
            this.btn_usersettings.Image = ((System.Drawing.Image)(resources.GetObject("btn_usersettings.Image")));
            this.btn_usersettings.Label = "Benutzer";
            this.btn_usersettings.Name = "btn_usersettings";
            this.btn_usersettings.ScreenTip = "Benutzereinstellungen wie z..B. Standard DokuArt";
            this.btn_usersettings.ShowImage = true;
            this.btn_usersettings.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_usersettings_Click);
            // 
            // DerrToolsRibbon1
            // 
            this.Name = "DerrToolsRibbon1";
            this.RibbonType = "Microsoft.Outlook.Explorer";
            this.Tabs.Add(this.tab2);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab2.ResumeLayout(false);
            this.tab2.PerformLayout();
            this.DerrTool_HSM_RibbonGroup.ResumeLayout(false);
            this.DerrTool_HSM_RibbonGroup.PerformLayout();
            this.RibGroup_Development.ResumeLayout(false);
            this.RibGroup_Development.PerformLayout();
            this.groupEinstellungen.ResumeLayout(false);
            this.groupEinstellungen.PerformLayout();

        }

        #endregion

        private Microsoft.Office.Tools.Ribbon.RibbonTab tab2;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup DerrTool_HSM_RibbonGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_schadensmeldung;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup RibGroup_Development;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonMangelruege;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupEinstellungen;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_Settings;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_ServerSettings;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_usersettings;
    }

    partial class ThisRibbonCollection
    {
        internal DerrToolsRibbon1 Ribbon1
        {
            get { return this.GetRibbon<DerrToolsRibbon1>(); }
        }
    }
}
