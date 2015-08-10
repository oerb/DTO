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
        }

        #region Properties definition

        // Data
        public string filelocation;

        public int mandant 
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
            set { this.txt_Mandant.Text = value.ToString(); }
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
            set { this.txt_kreditor.Text = value.ToString(); }
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
            set { this.txt_objekt.Text = value.ToString(); }
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
            set { this.txt_haus.Text = value.ToString(); }
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
            this.DialogResult = DialogResult.OK;
            Globals.ThisAddIn.ArchivingAktive = true;
            this.Close();
        }

        private void txt_meldungstyp_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.txt_meldungstyp.Text != "")
                {
                    Globals.ThisAddIn.filelocaiton = this.filelocation;
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
                if ( this.txt_Mandant.Text != "")
                {
                    this.mandant = int.Parse(this.txt_Mandant.Text);
                    Globals.ThisAddIn.Unternehmen = this.mandant;
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
                    Globals.ThisAddIn.AdresseNr = this.kreditor;
                    
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
                    Globals.ThisAddIn.WE = this.objekt;
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
            // TODO: This line of code loads data into the 'saperionDataSet_Dokuart_DokuKZ.WOWIVORGANG' table. You can move, or remove it, as needed.
            //this.wOWIVORGANGTableAdapter.Fill_DOKUKZ(this.saperionDataSet_Dokuart_DokuKZ.WOWIVORGANG);
            // TODO: This line of code loads data into the 'saperionDataSet_Dokuart_DokuKZ.WOWIDOKART' table. You can move, or remove it, as needed.
            this.wOWIDOKARTTableAdapter.Fill_Dokuart(this.saperionDataSet_Dokuart_DokuKZ.WOWIDOKART);            
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
            this.wOWIVORGANGTableAdapter.Fill_DOKUKZ(this.saperionDataSet_Dokuart_DokuKZ.WOWIVORGANG, this.cmb_dokuart.Text);
            // Set Global VorgangKZ for Archiving Function
            Globals.ThisAddIn.DokuArt = this.cmb_dokuart.Text;
        }

        private void cmb_vorgangkz_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Set Global VorgangKZ for Archiving Function
            Globals.ThisAddIn.VorgangKZ = this.cmb_vorgangkz.Text;
        }

        private void txt_haus_TextChanged(object sender, EventArgs e)
        {
            // Set Global HausNr for Archiving Function
            try
            {
                if (this.txt_objekt.Text != "")
                {
                    this.HausNr = int.Parse(this.txt_haus.Text);
                    Globals.ThisAddIn.HausNr = this.HausNr;
                }
            }
            catch
            {
                this.txt_objekt.Text = null;
                MessageBox.Show("HausNr. muss eine Zahl sein");
            }
        }

        private void cmb_dokuart_DropDown(object sender, EventArgs e)
        {
            // This Refille have to be done because the Dropdown was 
            // losing Items when changing Items in both
            // cmd_Dokuart and cmd_DokuKZ
            this.wOWIDOKARTTableAdapter.Fill_Dokuart(this.saperionDataSet_Dokuart_DokuKZ.WOWIDOKART); 
        }

        private void txt_wohnung_TextChanged(object sender, EventArgs e)
        {
            this.wohnung = Convert.ToInt32(this.txt_wohnung.Text);
        }
    }
}
