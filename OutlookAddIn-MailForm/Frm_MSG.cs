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
            set { this.txt_kreditor.Text = value.ToString(); this.lbl_kreditor_txt.Text = ""; }
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
            set { this.txt_objekt.Text = value.ToString(); this.lbl_objekt_txt.Text = ""; }
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
            set { this.txt_haus.Text = value.ToString(); this.lbl_haus_txt.Text = ""; }
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
            set { this.txt_Mieter.Text = value.ToString(); }
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
            set { this.txt_wohnung.Text = value.ToString(); }
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
                Globals.ThisAddIn.ArchivingAktive = true;
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

        private void txt_Mandant_TextChanged(object sender, EventArgs e)
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
                MessageBox.Show("Mandant muss eine Zahl sein");
            }
        }

        private void txt_kreditor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.txt_kreditor.Text != "")
                {
                    this.kreditor = int.Parse(this.txt_kreditor.Text);
                    Globals.ThisAddIn.msg_parameter.KreditorAdr = this.kreditor;
                    
                }   
            }
            catch
            {
                this.txt_kreditor.Text = null;
                MessageBox.Show("Kreditor muss eine Zahl sein");
            }
        }

        private void txt_objekt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.txt_objekt.Text != "")
                {
                    this.objekt = int.Parse(this.txt_objekt.Text);
                    Globals.ThisAddIn.msg_parameter.WE = this.objekt;
                }
            }
            catch
            {
                this.txt_objekt.Text = null;
                MessageBox.Show("Objekt muss eine Zahl sein");
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

        private void txt_haus_TextChanged(object sender, EventArgs e)
        {
            // Set Global HausNr for Archiving Function
            try
            {
                if (this.txt_objekt.Text != "")
                {
                    this.HausNr = int.Parse(this.txt_haus.Text);
                    Globals.ThisAddIn.msg_parameter.HausNr = this.HausNr;
                }
            }
            catch
            {
                this.txt_haus.Text = null;
                MessageBox.Show("HausNr. muss eine Zahl sein");
            }
        }

        private void cmb_dokuart_DropDown(object sender, EventArgs e)
        {
            // This Refille have to be done because the Dropdown was 
            // losing Items when changing Items in both
            // cmd_Dokuart and cmd_DokuKZ
            //this.wOWIDOKARTTableAdapter.Fill_Dokuart(this.saperionDataSet_Dokuart_DokuKZ.WOWIDOKART);
            this.tblDokuartTableAdapter.Fill(this.dataSet1_WOWI_SEARCH.tblDokuart);
        }

        private void txt_wohnung_TextChanged(object sender, EventArgs e)
        {
            //this.wohnung = Convert.ToInt32(this.txt_wohnung.Text);
            // Set Global HausNr for Archiving Function
            try
            {
                if (this.txt_wohnung.Text != "")
                {
                    this.wohnung = int.Parse(this.txt_wohnung.Text);
                    Globals.ThisAddIn.msg_parameter.Wohnung = this.wohnung;
                }
            }
            catch
            {
                this.txt_wohnung.Text = null;
                MessageBox.Show("NE. muss eine Zahl sein");
            }
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
    }
}
