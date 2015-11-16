using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutlookAddIn_MailForm
{
    public partial class Frm_MSG : Form
    {
        public Frm_MSG()
        {
            InitializeComponent();
            Globals.ThisAddIn.msg_parameter = new MSG_Parameter();
            this.mandant1 = Globals.ThisAddIn.msg_parameter.Mandant;
        } 

        #region Properties definition

        //public MSG_Parameter msg_parameter = Globals.ThisAddIn.msg_parameter;


        // Data
        public string filelocation;

        private int _msgtyp;
        public int msgtyp
        {
            get { return _msgtyp; }
            set 
            {
                Database1DataSet_MSGTYPES.TableDataTable msgtypTable;
                msgtypTable = this.tableTableAdapter.GetDataByID(value);
                this.cmb_dokuart.Text = msgtypTable[0].Dokuart;
                this.cmb_vorgangkz.Text = msgtypTable[0].VorgangKZ;
                this.dtp_Datum1.Visible = msgtypTable[0].Datum1show;
                this.lbl_Datum1.Visible = msgtypTable[0].Datum1show;
                this.lbl_Datum1.Text = msgtypTable[0].Datum1Name;
                this.dtp_Datum2.Visible = msgtypTable[0].Datum2show;
                this.lbl_Datum2.Visible = msgtypTable[0].Datum2show;
                this.lbl_Datum2.Text = msgtypTable[0].Datum2Name;
                //Unternehmen zeigen
                this.txt_Mandant.Visible = msgtypTable[0].UnternehmenAnz;
                this.lbl_Mandant.Visible = msgtypTable[0].UnternehmenAnz;
                this.btn_mandant.Visible = msgtypTable[0].UnternehmenAnz;
                //Mandant zeigen
                this.txt_mandant1.Visible = msgtypTable[0].MandantAnz;
                this.lbl_mandant1.Visible = msgtypTable[0].MandantAnz;
                this.btn_mandant1.Visible = msgtypTable[0].MandantAnz;
                //Kreditor zeigen
                this.txt_kreditor.Visible = msgtypTable[0].KreditorAnz;
                this.lbl_Kreditor.Visible = msgtypTable[0].KreditorAnz;
                this.btn_kreditor.Visible = msgtypTable[0].KreditorAnz;
                //WE zeigen
                this.txt_objekt.Visible = msgtypTable[0].WEanz;
                this.lbl_Objekt.Visible = msgtypTable[0].WEanz;
                this.btn_objekt.Visible = msgtypTable[0].WEanz;
                //Haus zeigen
                this.txt_haus.Visible = msgtypTable[0].HausAnz;
                this.lbl_haus.Visible = msgtypTable[0].HausAnz;
                this.btn_haus.Visible = msgtypTable[0].HausAnz;
                //NE zeigen
                this.txt_wohnung.Visible = msgtypTable[0].NEanz;
                this.lbl_Wohnung.Visible = msgtypTable[0].NEanz;
                this.btn_wohnung.Visible = msgtypTable[0].NEanz;
                //Mieter zeigen
                this.txt_Mieter.Visible = msgtypTable[0].MieterAnz;
                this.lbl_Mieter.Visible = msgtypTable[0].MieterAnz;
                this.btn_mieter.Visible = msgtypTable[0].MieterAnz;
                //Adresse zeigen
                this.grb_adress_search.Visible = msgtypTable[0].AdresseAnz;
            }
        }


        public int mandant1 // Mandante
        {
            get
            {
                if (this.txt_mandant1.Text != "")
                {
                    return int.Parse(this.txt_mandant1.Text);
                }
                else
                {
                    return 1;
                }
            }

            set
            {                
                this.txt_mandant1.Text = value.ToString();
                Globals.ThisAddIn.msg_parameter.Mandant = value;
            }
        }
        public int mandant // Unternehmen
        {
            get { 
                    if (this.txt_Mandant.Text != "")
                    {
                        return int.Parse(this.txt_Mandant.Text); 
                    }
                    else
                    {
                        return 0;
                    }
                }
            set 
            { 
                this.txt_Mandant.Text = value.ToString();                
                string companyname = "";
                if (value == 0)
                {
                    companyname = "";
                }
                else
                {
                    companyname = this.mandantTableAdapter1.GetCompanyName(this.mandant1,value).ToString();
                }               
                this.lbl_mandant_txt.Text = companyname;
                this.lbl_mandant_txt.Visible = true;
                Globals.ThisAddIn.msg_parameter.Unternehmen = value;
            }
        }

        public int kreditor
        {
            get
            {
                if (this.txt_kreditor.Text != "")
                {
                    return int.Parse(this.txt_kreditor.Text); 
                }
                else
                {
                    return 0;
                }
            }
            set 
            { 
                this.txt_kreditor.Text = value.ToString(); 
                this.lbl_kreditor_txt.Text = "";
                Globals.ThisAddIn.msg_parameter.KreditorAdr = value;
            }
        }

        public int objekt
        {
            get
            {
                if (this.txt_objekt.Text != "")
                {
                    return int.Parse(this.txt_objekt.Text);
                }
                else
                {
                    return 0;
                }
            }
            set 
            { 
                this.txt_objekt.Text = value.ToString(); 
                this.lbl_objekt_txt.Text = "";
                Globals.ThisAddIn.msg_parameter.WE = value;
            }
        }

        private string _eMail;

        public string eMail
        {
            get { return _eMail; }
            set { _eMail = value; }
        }

        public int HausNr
        {
            get
            {
                if (this.txt_haus.Text != "")
                {
                    return int.Parse(this.txt_haus.Text);
                }
                else
                {
                    return 0;
                }
            }
            set 
            { 
                this.txt_haus.Text = value.ToString(); 
                this.lbl_haus_txt.Text = "";
                Globals.ThisAddIn.msg_parameter.HausNr = value;
            }
        }

        public int Mieter
        {
            get
            {
                if (this.txt_Mieter.Text != "")
                {
                    return int.Parse(this.txt_Mieter.Text);
                }
                else
                {
                    return 0;
                }
            }
            set 
            { 
                this.txt_Mieter.Text = value.ToString();
                Globals.ThisAddIn.msg_parameter.AdresseNr = value;
            }
        }

        // NE = wohnung
        public int wohnung
        {
            get
            {
                if (this.txt_wohnung.Text != "")
                {
                    return int.Parse(this.txt_wohnung.Text);
                }
                else
                {
                    return 0;
                }
            }
            set 
            { 
                this.txt_wohnung.Text = value.ToString();
                Globals.ThisAddIn.msg_parameter.Wohnung = value;
            }
        }

        #endregion

        // One search Buttonhandler 
        // btn_typ: "ma" (Mandant), "kr" (Kreditor), "ob" Objekt, "ha" Haus, 
        // "we" WE, "me" MSGtyp
        private void btn_search_click(object sender, EventArgs e)
        {
            string btn_typ = "none";
            if (sender == btn_mandant)
                { btn_typ = "ma"; }
            // TODO: btn_mandant rename to btn_unternehmen
            else if (sender == btn_mandant1)
                { btn_typ = "m1"; }
            else if (sender == btn_kreditor)
                { btn_typ = "kr"; }
            else if (sender == btn_objekt)
                { btn_typ = "ob"; }
            else if (sender == btn_MSGtyp)
                { btn_typ = "me"; }
            else if (sender == btn_haus)
                { btn_typ = "ha"; }
            else if (sender == btn_wohnung)
                { btn_typ = "wo"; }
            else if (sender == btn_mieter)
                { btn_typ = "mi"; }
            else if (sender == btn_Adresse)
                { btn_typ = "ad"; }
            else
                { btn_typ = "none"; }
            // Open Form 
            Frm_Search frm_Search = new Frm_Search(btn_typ);
            // frm_Search.MdiParent = this;
            frm_Search.ParentForm = this; // TODO: Replace this by FormClass inherited MdiParent
            //DialogResult result = frm_Search.ShowDialog();
            frm_Search.Show(); // TODO: Do not know what is better to use. Show or ShowDialog ... test it
        }

        private void btn_create_MSG_Click(object sender, EventArgs e)
        {            
            //Globals.ThisAddIn.msg_parameter = this.msg_parameter;
            if (this.txt_meldungstyp.Text != "")
            {
                this.DialogResult = DialogResult.OK;                
                this.Close();
            }
            else
            {
                MessageBox.Show("Bitte geben Sie einen Meldungstyp an!");
            }            
        }

        private void txt_meldungstyp_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.txt_meldungstyp.Text != "")
                {
                    Globals.ThisAddIn.msg_parameter.filelocaiton = this.filelocation;
                }
            }
            catch
            {
                this.txt_meldungstyp.Text = null;
                MessageBox.Show("Filelocation Error in Frm_MSG.cs txt_meldungstyp_TextChanged");
            }
        }

        // setting WE Infotext by current WE data
        public void set_WE_lable()
        {
            // Getting Objekt Lable and Fill it to Form and Global Data
            //***Begin***
            DataSet1_WoWi_Objekte.WirtschaftseinheitDataTable weTable;
            weTable = this.wirtschaftseinheitTableAdapter.GetDataByWE(this.objekt, this.mandant1, this.mandant);
            if (weTable.Rows.Count > 0)
            {
                string webez = weTable[0].Ortname + ", " + weTable[0].Strasse;
                Globals.ThisAddIn.msg_parameter.WeBeszeichnung = webez;
                this.lbl_objekt_txt.Text = webez;
                this.lbl_objekt_txt.Visible = true;               
            }
            else
            {
                MessageBox.Show("Mandant und Unternehmen müssen einen Wert haben!");
                this.txt_objekt.Text = "0";
            }
            //***END*** 
        }

        public void set_Kreditor_lable()
        {
            //DataSet1_WoWi_Kreditor._Kreditor_KontoDataTable krTable;            
            if (this.mandant != 0 && this.mandant1 !=0)
            {
                //kreditorKontoBindingSource.Filter = "Unternehmen = " + this.ParentForm.mandant;
                //this.dgv_TableSelect.DataSource = kreditorKontoBindingSource;
                string kreditorname = this.kreditor_KontoTableAdapter.GetKreditorNameBYMaUnKr(this.mandant1, this.mandant, this.kreditor);
                Globals.ThisAddIn.msg_parameter.KreditorName = kreditorname;
                this.lbl_kreditor_txt.Text = kreditorname;
                this.lbl_kreditor_txt.Visible = true;
            }
            else
            {
                //this.dgv_TableSelect.DataSource = kreditorKontoBindingSource;
            }
        }

        public void set_Haus_lable()
        {
            if (this.mandant != 0 && this.mandant1 != 0 && this.objekt != 0)
            {
                string hausbez = tblHausTableAdapter.GetBezeichnBYMaUnWeHa(this.mandant1, this.mandant, this.objekt, this.HausNr);
                this.lbl_haus_txt.Text = hausbez;
                this.lbl_haus_txt.Visible = true; 
            }
        }

        public void set_Wohnung_lable()
        {            
            if (this.mandant != 0 && this.mandant1 != 0 && this.objekt != 0 && this.HausNr != 0)
            {
                DataSet1_WOWI_SEARCH.tblWohnungDataTable woTable;
                woTable = tblWohnungTableAdapter.GetDataByMaUnWeHaWo(this.mandant, this.objekt, this.HausNr, this.mandant1, this.wohnung);
                if (woTable.Rows.Count > 0)
                {
                    string etage = woTable[0].GeschossText + ", " + woTable[0].WohnlageText;
                    Globals.ThisAddIn.msg_parameter.NeEtage = etage;
                    this.lbl_wo_txt.Text = etage;
                    this.lbl_wo_txt.Visible = true;
                }
            }
        }

        private void Frm_MSG_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1_WOWI_SEARCH.tblDokuart' table. You can move, or remove it, as needed.
            this.tblDokuartTableAdapter.Fill(this.dataSet1_WOWI_SEARCH.tblDokuart);
            // TODO: This line of code loads data into the 'saperionDataSet_Dokuart_DokuKZ.WOWIVORGANG' table. You can move, or remove it, as needed.
            //this.wOWIVORGANGTableAdapter.Fill_DOKUKZ(this.saperionDataSet_Dokuart_DokuKZ.WOWIVORGANG);
            // TODO: This line of code loads data into the 'saperionDataSet_Dokuart_DokuKZ.WOWIDOKART' table. You can move, or remove it, as needed.                       
            // Prefilling Dokuart and DokuKZ by Static Properties ( defined by Frm_UserSettings.cs )
            if (Properties.Settings.Default.uDokuart.ToString() != "")
            {
                this.cmb_dokuart.SelectedValue = Properties.Settings.Default.uDokuart;
            }            
            if (Properties.Settings.Default.uVorgangKZ.ToString() != "")
            {
                this.cmb_vorgangkz.SelectedValue = Properties.Settings.Default.uVorgangKZ;
            }            
        }

        private void cmb_dokuart_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Fill VorgangKZ with Filtered Data
            this.tblVorgangKZTableAdapter.FillbyDokuart(this.dataSet1_WOWI_SEARCH.tblVorgangKZ, this.cmb_dokuart.Text);
            //this.wOWIVORGANGTableAdapter.Fill_DOKUKZ(this.saperionDataSet_Dokuart_DokuKZ.WOWIVORGANG, this.cmb_dokuart.Text);
            // Set Global VorgangKZ for Archiving Function
            Globals.ThisAddIn.msg_parameter.DokuArt = this.cmb_dokuart.Text;
        }

        private void cmb_vorgangkz_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Set Global VorgangKZ for Archiving Function
            Globals.ThisAddIn.msg_parameter.VorgangKZ = this.cmb_vorgangkz.Text;
        }

        private void cmb_dokuart_DropDown(object sender, EventArgs e)
        {
            // This Refille have to be done because the Dropdown was 
            // losing Items when changing Items in both
            // cmd_Dokuart and cmd_DokuKZ
            //this.wOWIDOKARTTableAdapter.Fill_Dokuart(this.saperionDataSet_Dokuart_DokuKZ.WOWIDOKART);
            this.tblDokuartTableAdapter.Fill(this.dataSet1_WOWI_SEARCH.tblDokuart);
        }

        // clear all Info-lables behind Textboxes
        // TODO: Rename this to clear_Formdata
        public void clear_form_data()
        {
            this.mandant = 0;
            this.mandant1 = Globals.ThisAddIn.msg_parameter.Mandant;
            this.HausNr = 0;
            this.objekt = 0;
            //this.kreditor = 0;
            this.wohnung = 0;
            this.Mieter = 0;           
        }

        private void btn_clearform_Click(object sender, EventArgs e)
        {
            clear_form_data();
        }

        private void txt_Mieter_TextChanged(object sender, EventArgs e)
        {
            // Set Global Mieter for Archiving Function
            try
            {
                if (this.txt_Mieter.Text != "")
                {
                    this.Mieter = int.Parse(this.txt_Mieter.Text);
                    Globals.ThisAddIn.msg_parameter.AdresseNr = this.Mieter;
                }
            }
            catch
            {
                this.txt_Mieter.Text = null;
                MessageBox.Show("Mieter. muss eine Zahl sein");
            }
        }

        private void dtp_Datum1_ValueChanged(object sender, EventArgs e)
        {
            Globals.ThisAddIn.msg_parameter.datum1 = this.dtp_Datum1.Value;
        }

        private void dtp_Datum2_ValueChanged(object sender, EventArgs e)
        {
            Globals.ThisAddIn.msg_parameter.datum2 = this.dtp_Datum2.Value;
        }

        private void lbl_Mandant_Click(object sender, EventArgs e)
        {

        }

        private void lbl_mandant_txt_Click(object sender, EventArgs e)
        {

        }

        private void btn_adr_as_mieter_Click(object sender, EventArgs e)
        {
            if (this.txt_Adresse.Text != "")
            {
                 // Open Form 
                Frm_Search frm_Search = new Frm_Search("MiAd");
                // frm_Search.MdiParent = this;
                frm_Search.ParentForm = this; // TODO: Replace this by FormClass inherited MdiParent
                //DialogResult result = frm_Search.ShowDialog();
                frm_Search.Show(); // TODO: Do not know what is better to use. Show or ShowDialog ... test it
            }
        }

        private void btn_adr_as_kreditor_Click(object sender, EventArgs e)
        {
            if (this.txt_Adresse.Text != "")
            {
                // Open Form 
                Frm_Search frm_Search = new Frm_Search("KrAd");
                // frm_Search.MdiParent = this;
                frm_Search.ParentForm = this; // TODO: Replace this by FormClass inherited MdiParent
                //DialogResult result = frm_Search.ShowDialog();
                frm_Search.Show(); // TODO: Do not know what is better to use. Show or ShowDialog ... test it
            }
        }

        private void txt_objekt_Leave(object sender, EventArgs e)
        {
            try
            {
                if (this.txt_objekt.Text != "")
                {
                    if (this.mandant1 != 0 && this.mandant != 0)
                    {
                        this.objekt = int.Parse(this.txt_objekt.Text);
                        Globals.ThisAddIn.msg_parameter.WE = this.objekt;
                        this.set_WE_lable();
                    }
                    else
                    {
                        MessageBox.Show("Mandant und Unternehmen müssen einen Wert haben!");
                    }
                }
            }
            catch
            {
                this.txt_objekt.Text = null;
                //MessageBox.Show("Objekt muss eine Zahl sein");
            }
        }

        private void txt_kreditor_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (this.txt_kreditor.Text != "" && this.mandant1 != 0 && this.mandant != 0)
                {
                    this.kreditor = int.Parse(this.txt_kreditor.Text);
                    Globals.ThisAddIn.msg_parameter.KreditorAdr = this.kreditor;
                    this.set_Kreditor_lable();
                }
                else
                {
                    MessageBox.Show("Mandant und Unternehmen müssen einen Wert haben!");
                }
            }
            catch
            {
                this.txt_kreditor.Text = null;
               // MessageBox.Show("Kreditor muss eine Zahl sein");
            }
        }

        private void txt_Mandant_Leave(object sender, EventArgs e)
        {
            try
            {
                if (this.txt_Mandant.Text != "")
                {
                    this.mandant = int.Parse(this.txt_Mandant.Text);
                    Globals.ThisAddIn.msg_parameter.Unternehmen = this.mandant;
                }
            }
            catch
            {
                this.txt_Mandant.Text = null;
                //MessageBox.Show("Mandant muss eine Zahl sein");
            }
        }

        private void txt_haus_Leave(object sender, EventArgs e)
        {
            try
            {
                if (this.txt_Mandant.Text != "" && this.mandant != 0 && this.mandant1 != 0 && this.objekt != 0)
                {
                    this.mandant = int.Parse(this.txt_Mandant.Text);
                    Globals.ThisAddIn.msg_parameter.Unternehmen = this.mandant;
                    this.set_Haus_lable();
                }
                else
                {
                    MessageBox.Show("Mandant, Unternehmen und WE müssen einen Wert haben!");
                    this.txt_haus.Text = "";
                }
            }
            catch
            {
                this.txt_Mandant.Text = null;
                //MessageBox.Show("Mandant muss eine Zahl sein");
            }
        }

        private void txt_wohnung_Leave(object sender, EventArgs e)
        {
            //this.wohnung = Convert.ToInt32(this.txt_wohnung.Text);
            // Set Global HausNr for Archiving Function
            try
            {
                if (this.txt_wohnung.Text != "")
                {
                    if (this.txt_Mandant.Text != "" && this.mandant != 0 && this.mandant1 != 0 && this.objekt != 0 && this.HausNr != 0)
                    {
                        this.wohnung = int.Parse(this.txt_wohnung.Text);
                        Globals.ThisAddIn.msg_parameter.Wohnung = this.wohnung;
                        this.set_Wohnung_lable();
                    }
                    else
                    {
                        MessageBox.Show("Mandant, Unternehmen, WE und Haus müssen einen Wert haben!");
                        this.txt_wohnung.Text = "";
                    }
                }
            }
            catch
            {
                this.txt_wohnung.Text = null;
                //MessageBox.Show("NE. muss eine Zahl sein");
            }
        }
    }
}
