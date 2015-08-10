namespace OutlookAddIn_MailForm
{
    partial class Frm_MailMain : Microsoft.Office.Tools.Outlook.ImportedFormRegionBase
    {
            private Microsoft.Office.Interop.Outlook._DRecipientControl to;
    private Microsoft.Office.Interop.Outlook._DRecipientControl cC;
    private Microsoft.Office.Interop.Outlook._DDocSiteControl _DocSiteControl1;
    private Microsoft.Office.Interop.Outlook.OlkCommandButton toButton;
    private Microsoft.Office.Interop.Outlook.OlkCommandButton cCButton;
    private Microsoft.Office.Interop.Outlook.OlkTextBox subject;
    private Microsoft.Office.Interop.Outlook.OlkLabel subjectLabel;
    private Microsoft.Office.Interop.Outlook.OlkCommandButton cmd_Unternehmen;
    private Microsoft.Office.Interop.Outlook.OlkCommandButton cmd_WE;
    private Microsoft.Office.Interop.Outlook.OlkCommandButton cmd_Haus;
    private Microsoft.Office.Interop.Outlook.OlkCommandButton cmd_Wohnung;
    private Microsoft.Office.Interop.Outlook.OlkCommandButton cmd_Mieter;
    //private Microsoft.Office.Interop.Outlook.OlkCommandButton cmd_Kreditor;
    private Microsoft.Office.Interop.Outlook.OlkTextBox txtUnternehmen;
    private Microsoft.Office.Interop.Outlook.OlkLabel lbl_Unternehmen;
    private Microsoft.Office.Interop.Outlook.OlkTextBox txtWE;
    private Microsoft.Office.Interop.Outlook.OlkLabel olkLabel2;
    private Microsoft.Office.Interop.Outlook.OlkTextBox txtWohnung;
    private Microsoft.Office.Interop.Outlook.OlkLabel lbl_Wohnung;
    private Microsoft.Office.Interop.Outlook.OlkTextBox txtHaus;
    private Microsoft.Office.Interop.Outlook.OlkLabel lblHaus;
    private Microsoft.Office.Interop.Outlook.OlkTextBox txtMieter;
    private Microsoft.Office.Interop.Outlook.OlkLabel lblMieter;
    private Microsoft.Office.Interop.Outlook.OlkTextBox txtKreditor;
    private Microsoft.Office.Interop.Outlook.OlkLabel olkLabel6;
    private Microsoft.Office.Interop.Outlook.OlkComboBox cbx_Dokuart;
    private Microsoft.Office.Interop.Outlook.OlkLabel lbl_Dokuart;
    private Microsoft.Office.Interop.Outlook.OlkComboBox cbx_VorgangKZ;
    private Microsoft.Office.Interop.Outlook.OlkLabel lbl_VorgangKZ;

        public Frm_MailMain(Microsoft.Office.Interop.Outlook.FormRegion formRegion)
            : base(Globals.Factory, formRegion)
        {
            this.FormRegionShowing += new System.EventHandler(this.Frm_MailMain_FormRegionShowing);
            this.FormRegionClosed += new System.EventHandler(this.Frm_MailMain_FormRegionClosed);
        }

        protected override void InitializeControls()
        {
                    this.to = (Microsoft.Office.Interop.Outlook._DRecipientControl)GetFormRegionControl("To");
        this.cC = (Microsoft.Office.Interop.Outlook._DRecipientControl)GetFormRegionControl("CC");
        this._DocSiteControl1 = (Microsoft.Office.Interop.Outlook._DDocSiteControl)GetFormRegionControl("_DocSiteControl1");
        this.toButton = (Microsoft.Office.Interop.Outlook.OlkCommandButton)GetFormRegionControl("ToButton");
        this.cCButton = (Microsoft.Office.Interop.Outlook.OlkCommandButton)GetFormRegionControl("CCButton");
        this.subject = (Microsoft.Office.Interop.Outlook.OlkTextBox)GetFormRegionControl("Subject");
        this.subjectLabel = (Microsoft.Office.Interop.Outlook.OlkLabel)GetFormRegionControl("SubjectLabel");
        this.cmd_Unternehmen = (Microsoft.Office.Interop.Outlook.OlkCommandButton)GetFormRegionControl("cmd_Unternehmen");
        this.cmd_WE = (Microsoft.Office.Interop.Outlook.OlkCommandButton)GetFormRegionControl("cmd_WE");
        this.cmd_Haus = (Microsoft.Office.Interop.Outlook.OlkCommandButton)GetFormRegionControl("cmd_Haus");
        this.cmd_Wohnung = (Microsoft.Office.Interop.Outlook.OlkCommandButton)GetFormRegionControl("cmd_Wohnung");
        this.cmd_Mieter = (Microsoft.Office.Interop.Outlook.OlkCommandButton)GetFormRegionControl("cmd_Mieter");
        //this.cmd_Kreditor = (Microsoft.Office.Interop.Outlook.OlkCommandButton)GetFormRegionControl("cmd_Kreditor");
        this.txtUnternehmen = (Microsoft.Office.Interop.Outlook.OlkTextBox)GetFormRegionControl("txtUnternehmen");
        this.lbl_Unternehmen = (Microsoft.Office.Interop.Outlook.OlkLabel)GetFormRegionControl("lbl_Unternehmen");
        this.txtWE = (Microsoft.Office.Interop.Outlook.OlkTextBox)GetFormRegionControl("txtWE");
        this.olkLabel2 = (Microsoft.Office.Interop.Outlook.OlkLabel)GetFormRegionControl("OlkLabel2");
        this.txtWohnung = (Microsoft.Office.Interop.Outlook.OlkTextBox)GetFormRegionControl("txtWohnung");
        this.lbl_Wohnung = (Microsoft.Office.Interop.Outlook.OlkLabel)GetFormRegionControl("lbl_Wohnung");
        this.txtHaus = (Microsoft.Office.Interop.Outlook.OlkTextBox)GetFormRegionControl("txtHaus");
        this.lblHaus = (Microsoft.Office.Interop.Outlook.OlkLabel)GetFormRegionControl("lblHaus");
        this.txtMieter = (Microsoft.Office.Interop.Outlook.OlkTextBox)GetFormRegionControl("txtMieter");
        this.lblMieter = (Microsoft.Office.Interop.Outlook.OlkLabel)GetFormRegionControl("lblMieter");
        this.txtKreditor = (Microsoft.Office.Interop.Outlook.OlkTextBox)GetFormRegionControl("txtKreditor");
        this.olkLabel6 = (Microsoft.Office.Interop.Outlook.OlkLabel)GetFormRegionControl("OlkLabel6");
        this.cbx_Dokuart = (Microsoft.Office.Interop.Outlook.OlkComboBox)GetFormRegionControl("cbx_Dokuart");
        this.lbl_Dokuart = (Microsoft.Office.Interop.Outlook.OlkLabel)GetFormRegionControl("lbl_Dokuart");
        this.cbx_VorgangKZ = (Microsoft.Office.Interop.Outlook.OlkComboBox)GetFormRegionControl("cbx_VorgangKZ");
        this.lbl_VorgangKZ = (Microsoft.Office.Interop.Outlook.OlkLabel)GetFormRegionControl("lbl_VorgangKZ");

        }

        public partial class Frm_MailMainFactory : Microsoft.Office.Tools.Outlook.IFormRegionFactory
        {
            public event Microsoft.Office.Tools.Outlook.FormRegionInitializingEventHandler FormRegionInitializing;

            private Microsoft.Office.Tools.Outlook.FormRegionManifest _Manifest;

            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public Frm_MailMainFactory()
            {
                this._Manifest = Globals.Factory.CreateFormRegionManifest();
                this.InitializeManifest();
                this.FormRegionInitializing += new Microsoft.Office.Tools.Outlook.FormRegionInitializingEventHandler(this.Frm_MailMainFactory_FormRegionInitializing);
            }

            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public Microsoft.Office.Tools.Outlook.FormRegionManifest Manifest
            {
                get
                {
                    return this._Manifest;
                }
            }

            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            Microsoft.Office.Tools.Outlook.IFormRegion Microsoft.Office.Tools.Outlook.IFormRegionFactory.CreateFormRegion(Microsoft.Office.Interop.Outlook.FormRegion formRegion)
            {
                Frm_MailMain form = new Frm_MailMain(formRegion);
                form.Factory = this;
                return form;
            }

            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            byte[] Microsoft.Office.Tools.Outlook.IFormRegionFactory.GetFormRegionStorage(object outlookItem, Microsoft.Office.Interop.Outlook.OlFormRegionMode formRegionMode, Microsoft.Office.Interop.Outlook.OlFormRegionSize formRegionSize)
            {
                System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Frm_MailMain));
                return (byte[])resources.GetObject("test12");
            }

            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            bool Microsoft.Office.Tools.Outlook.IFormRegionFactory.IsDisplayedForItem(object outlookItem, Microsoft.Office.Interop.Outlook.OlFormRegionMode formRegionMode, Microsoft.Office.Interop.Outlook.OlFormRegionSize formRegionSize)
            {
                if (this.FormRegionInitializing != null)
                {
                    Microsoft.Office.Tools.Outlook.FormRegionInitializingEventArgs cancelArgs = Globals.Factory.CreateFormRegionInitializingEventArgs(outlookItem, formRegionMode, formRegionSize, false);
                    this.FormRegionInitializing(this, cancelArgs);
                    return !cancelArgs.Cancel;
                }
                else
                {
                    return true;
                }
            }

            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            Microsoft.Office.Tools.Outlook.FormRegionKindConstants Microsoft.Office.Tools.Outlook.IFormRegionFactory.Kind
            {
                get
                {
                    return Microsoft.Office.Tools.Outlook.FormRegionKindConstants.Ofs;
                }
            }
        }
    }

    partial class WindowFormRegionCollection
    {
        internal Frm_MailMain Frm_MailMain
        {
            get
            {
                foreach (var item in this)
                {
                    if (item.GetType() == typeof(Frm_MailMain))
                        return (Frm_MailMain)item;
                }
                return null;
            }
        }
    }
}
