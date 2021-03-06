﻿using System;
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
    public partial class Frm_Search : Form
    {

        #region Properties

        // getter var for switching the BindingSources filled by Instantiation
        private string _btn_typ;

        // Inheriting the calling Parent Form for recalls
        // TODO: use MdiParent instead
        // https://msdn.microsoft.com/de-de/library/system.windows.forms.containercontrol.parentform%28v=vs.110%29.aspx
        private Frm_MSG _ParentForm;
        public new Frm_MSG ParentForm
        {
            get { return _ParentForm; }
            set { _ParentForm = value; }
        }

        #endregion 
          
        public Frm_Search(string btn_typ)
        {
            InitializeComponent();
            // TODO: REMOVE TESTING
            //MessageBox.Show(btn_typ);
            _btn_typ = btn_typ;
            this.setFormName();
        }
        
        // Prefilling the Gridviewtable by what ist chosen in Frm_MSG.cs
        private void Frm_Search_Load(object sender, EventArgs e)
        {           
            // select the Databinding by _btn_type from Instantiation
            switch (_btn_typ)
            {
                case "m1":  //Mandant
                    {
                        this.dgv_TableSelect.DataSource = tblMandantBindingSource;
                        this.tblMandantTableAdapter.Fill(dataSet1_WOWI_SEARCH.tblMandant);
                        break;
                    }
                case "ma":  //Unternehmen
                    {
                        
                        this.dgv_TableSelect.DataSource = mandantBindingSource;        
                        this.mandantTableAdapter.Fill(this.dataSet1_WoWi_Mandant.Mandant, this.ParentForm.mandant1);
                        break;
                    }
                case "kr":
                    {
                        fill_dgv_with_Kerditor();
                        break;
                    }
                case "ob":
                    {
                        if (this.ParentForm.mandant != 0 && this.ParentForm.mandant1 != 0)
                        {
                            wirtschaftseinheitBindingSource.Filter = "Unternehmen = " + this.ParentForm.mandant;
                            this.dgv_TableSelect.DataSource = wirtschaftseinheitBindingSource;
                            this.wirtschaftseinheitTableAdapter.FillbyMaUn(this.dataSet1_WoWi_Objekte.Wirtschaftseinheit, this.ParentForm.mandant1, this.ParentForm.mandant);
                        }
                        else
                        {
                            this.dgv_TableSelect.DataSource = wirtschaftseinheitBindingSource;
                            this.wirtschaftseinheitTableAdapter.Fill(this.dataSet1_WoWi_Objekte.Wirtschaftseinheit);
                        }                                                
                        break;
                    }
                case "ha":
                    {
                        if (this.ParentForm.mandant != 0  && this.ParentForm.objekt == 0)
                        {
                            hausBindingSource.Filter = "Unternehmen = " + this.ParentForm.mandant;
                            this.dgv_TableSelect.DataSource = hausBindingSource;
                        }
                        else if (this.ParentForm.mandant == 0 && this.ParentForm.objekt != 0)
                        {
                            hausBindingSource.Filter = "WE = " + this.ParentForm.objekt;
                            this.dgv_TableSelect.DataSource = hausBindingSource;
                        }
                        else if (this.ParentForm.mandant != 0 && this.ParentForm.objekt != 0)
                        {
                            hausBindingSource.Filter = "Unternehmen = " + this.ParentForm.mandant + " AND WE = " + this.ParentForm.objekt;
                            this.dgv_TableSelect.DataSource = hausBindingSource;
                        }
                        else
                        {
                            //this.dgv_TableSelect.DataSource = hausBindingSource;
                            MessageBox.Show("Bitte wählen Sie erst einen Mandanten und ein Unternehmen");
                            this.Close();
                        }
                        this.hausTableAdapter.Fill(this.dataSet1_WoWi_Haus.Haus);
                        break;
                    }
                case "wo":
                    {
                        this.fill_dgv_with_Wohnung();
                        break;
                    }
                case "mi":
                    {
                        fill_dgv_with_Mieter();
                        break;
                    }
                case "ad":
                    {                        
                        this.txt_filer1.Visible = true;
                        this.txt_filter2.Visible = true;
                        this.lbl_1.Text = "Name1";
                        this.lbl_1.Visible = true;
                        this.lbl_2.Text = "Name2";
                        this.lbl_2.Visible = true;
                        this.btn_search.Visible = true;
                        break;
                    }
                case "MiAd":
                    {
                        fill_dgv_with_Mieter();
                        break;
                    }
                case "KrAd":
                    {
                        DataSet1_WoWi_Kreditor._Kreditor_KontoDataTable kreditorTable;
                        kreditorTable = this.kreditor_KontoTableAdapter.GetDataByKontonummer(int.Parse(this.ParentForm.txt_Adresse.Text));
                        if (kreditorTable.Rows.Count == 0)
                        {
                            this.ParentForm.kreditor = int.Parse(this.ParentForm.txt_Adresse.Text);
                            this.ParentForm.lbl_kreditor_txt.Text = this.ParentForm.lbl_Adresse_txt.Text;
                            this.ParentForm.lbl_kreditor_txt.Visible = true;
                            // this.ParentForm.eMail = dgv_TableSelect.SelectedRows[0].Cells[19].Value.ToString();
                            string KreditorBez = this.ParentForm.lbl_Adresse_txt.Text;
                            Globals.ThisAddIn.msg_parameter.KreditorName = this.ParentForm.lbl_Adresse_txt.Text;
                            this.Close();
                        }
                        if (this.ParentForm.mandant != 0)
                        {
                            kreditorKontoBindingSource.Filter = "Unternehmen = " + this.ParentForm.mandant + 
                                " AND Kontonummer = " + int.Parse(this.ParentForm.txt_Adresse.Text); 
                            this.dgv_TableSelect.DataSource = kreditorKontoBindingSource;
                        }
                        else
                        {
                            kreditorKontoBindingSource.Filter = "Kontonummer = " + int.Parse(this.ParentForm.txt_Adresse.Text);
                            this.dgv_TableSelect.DataSource = kreditorKontoBindingSource;
                        }

                        this.kreditor_KontoTableAdapter.FillByKontonummer(dataSet1_WoWi_Kreditor._Kreditor_Konto, int.Parse(this.ParentForm.txt_Adresse.Text));                        
                        this.txt_filer1.Visible = true;
                        this.lbl_1.Text = "Kontenbezeichnung suchen";
                        this.lbl_1.Visible = true;
                        this.btn_search.Visible = true;  
                        break;
                    }
                case "me":
                    {
                        this.dgv_TableSelect.DataSource = tableBindingSource;
                        this.tableTableAdapter.Fill(this.database1DataSet_MSGtyp.Table);
                        break;
                    }
            }
            
        }

        // select TableItem, Fill it to Parent and Close Form
        private void dgv_TableSelect_DoubleClick(object sender, EventArgs e)
        {
            setData_to_ParentForm();
            this.Close();
        }

        // select TableItem, Fill it to Parent and Close Form
        private void btn_select_Click(object sender, EventArgs e)
        {
            setData_to_ParentForm();
            this.Close();
        }

        // Fill selected Data to ParentForm
        private void setData_to_ParentForm()
        {
            // Setting Data to Frm_MSG.cs bei the GridView Click
            if (dgv_TableSelect.SelectedRows.Count == 0) return;
            switch (_btn_typ)
            {
                case "m1": //Mandante
                    {
                        this.ParentForm.clear_form_data();
                        this.ParentForm.mandant1 = (int)dgv_TableSelect.SelectedRows[0].Cells[0].Value;                       
                        break;
                    }
                case "ma": //Unternehmen
                    {
                        
                        this.ParentForm.mandant = (int)dgv_TableSelect.SelectedRows[0].Cells[0].Value;
                        this.ParentForm.lbl_mandant_txt.Text = dgv_TableSelect.SelectedRows[0].Cells[2].Value.ToString();
                        this.ParentForm.lbl_mandant_txt.Visible = true;
                        break;
                    }
                case "ob":
                    {
                        this.ParentForm.clear_form_data();
                        this.ParentForm.mandant1 = (int)dgv_TableSelect.SelectedRows[0].Cells[5].Value;
                        this.ParentForm.mandant = (int)dgv_TableSelect.SelectedRows[0].Cells[4].Value;
                        this.ParentForm.txt_objekt.Text = dgv_TableSelect.SelectedRows[0].Cells[0].Value.ToString();
                        string Text = dgv_TableSelect.SelectedRows[0].Cells[3].Value.ToString(); //simpler for use in  subject
                        this.ParentForm.lbl_objekt_txt.Text = Text;
                        this.ParentForm.lbl_objekt_txt.Visible = true;
                        string webez = dgv_TableSelect.SelectedRows[0].Cells[1].Value.ToString();
                        webez += " , " + dgv_TableSelect.SelectedRows[0].Cells[3].Value.ToString();
                        Globals.ThisAddIn.msg_parameter.WeBeszeichnung = webez;
                        break;
                    }
                case "kr":
                    {                        
                        this.ParentForm.kreditor = (int)dgv_TableSelect.SelectedRows[0].Cells[1].Value;
                        this.ParentForm.lbl_kreditor_txt.Text = dgv_TableSelect.SelectedRows[0].Cells[2].Value.ToString();
                        this.ParentForm.lbl_kreditor_txt.Visible = true;
                        this.ParentForm.eMail = dgv_TableSelect.SelectedRows[0].Cells[19].Value.ToString();
                        //Globals.ThisAddIn.msg_parameter.Vorname = dgv_TableSelect.SelectedRows[0].Cells[4].Value.ToString();
                        //Globals.ThisAddIn.msg_parameter.Name = dgv_TableSelect.SelectedRows[0].Cells[3].Value.ToString();
                        string KreditorBez = dgv_TableSelect.SelectedRows[0].Cells[2].Value.ToString();
                        Globals.ThisAddIn.msg_parameter.KreditorName = KreditorBez;
                        this.ParentForm.mandant = (int)dgv_TableSelect.SelectedRows[0].Cells[0].Value;
                        Globals.ThisAddIn.msg_parameter.KreditorBriefAnrede = this.getBriefAnrede((int)dgv_TableSelect.SelectedRows[0].Cells[27].Value);
                        break;
                    }
                case "KrAd":
                    {
                        this.ParentForm.kreditor = (int)dgv_TableSelect.SelectedRows[0].Cells[1].Value;
                        this.ParentForm.lbl_kreditor_txt.Text = dgv_TableSelect.SelectedRows[0].Cells[2].Value.ToString();
                        this.ParentForm.lbl_kreditor_txt.Visible = true;
                        this.ParentForm.eMail = dgv_TableSelect.SelectedRows[0].Cells[19].Value.ToString();                        
                        string KreditorBez = dgv_TableSelect.SelectedRows[0].Cells[2].Value.ToString();
                        Globals.ThisAddIn.msg_parameter.KreditorName = KreditorBez;
                        this.ParentForm.mandant = (int)dgv_TableSelect.SelectedRows[0].Cells[0].Value;
                        break;                        
                    }
                case "ha":
                    {
                        if (this.ParentForm.mandant != 0 && this.ParentForm.mandant1 != 0)
                        {
                            this.ParentForm.mandant = (int)dgv_TableSelect.SelectedRows[0].Cells[3].Value;
                            this.ParentForm.objekt = (int)dgv_TableSelect.SelectedRows[0].Cells[4].Value;
                            this.ParentForm.HausNr = (int)dgv_TableSelect.SelectedRows[0].Cells[0].Value;
                            this.ParentForm.lbl_haus_txt.Text = dgv_TableSelect.SelectedRows[0].Cells[2].Value.ToString();
                            this.ParentForm.lbl_haus_txt.Visible = true;
                            this.set_WE_lable();
                        }
                        else
                        {
                            MessageBox.Show("Bitte wählen Sie erst einen Mandanten und ein Unternehmen");
                        }
                        break;
                    }
                case "wo": //bzw. NE
                    {
                        this.ParentForm.mandant1 = (int)dgv_TableSelect.SelectedRows[0].Cells[2].Value;
                        this.ParentForm.mandant = (int)dgv_TableSelect.SelectedRows[0].Cells[3].Value;
                        this.ParentForm.objekt = (int)dgv_TableSelect.SelectedRows[0].Cells[4].Value;
                        this.ParentForm.HausNr = (int)dgv_TableSelect.SelectedRows[0].Cells[5].Value;
                        string etage = dgv_TableSelect.SelectedRows[0].Cells[1].Value.ToString() + ", " + dgv_TableSelect.SelectedRows[0].Cells[10].Value.ToString();
                        this.ParentForm.wohnung = (int)dgv_TableSelect.SelectedRows[0].Cells[6].Value;
                        this.ParentForm.lbl_wo_txt.Text = etage;
                        this.ParentForm.lbl_wo_txt.Visible = true;
                        this.ParentForm.HausNr = (int)dgv_TableSelect.SelectedRows[0].Cells[5].Value;
                        this.ParentForm.lbl_haus_txt.Text = dgv_TableSelect.SelectedRows[0].Cells[0].Value.ToString();
                        this.ParentForm.lbl_haus_txt.Visible = true;                        
                        Globals.ThisAddIn.msg_parameter.NeEtage = etage;
                        this.set_WE_lable();
                        break;
                    }
                case "mi":
                    {
                        set_mieter_to_ParentForm();
                        break;
                    }
                case "MiAd":
                    {
                        set_mieter_to_ParentForm();
                        break;
                    }
                case "ad":
                    {
                        this.ParentForm.txt_Adresse.Text = dgv_TableSelect.SelectedRows[0].Cells[10].Value.ToString();
                        this.ParentForm.lbl_Adresse_txt.Text = dgv_TableSelect.SelectedRows[0].Cells[0].Value.ToString();
                        this.ParentForm.lbl_Adresse_txt.Visible = true;
                        break;
                    }
                case "me":
                    {
                        this.ParentForm.filelocation = dgv_TableSelect.SelectedRows[0].Cells[2].Value.ToString();
                        this.ParentForm.msgtyp = (int)dgv_TableSelect.SelectedRows[0].Cells[0].Value;
                        //this.ParentForm.txb_Subject.Text = dgv_TableSelect.SelectedRows[0].Cells[1].Value.ToString();
                        this.ParentForm.txt_meldungstyp.Text = dgv_TableSelect.SelectedRows[0].Cells[1].Value.ToString();
                        break;
                    }
            }
        }

        private void set_mieter_to_ParentForm()
        {
            this.ParentForm.clear_form_data();
            this.ParentForm.Mieter = (int)dgv_TableSelect.SelectedRows[0].Cells["AdressNr"].Value;
            this.ParentForm.lbl_mieter_txt.Text = dgv_TableSelect.SelectedRows[0].Cells["Name1"].Value.ToString();
            this.ParentForm.eMail = dgv_TableSelect.SelectedRows[0].Cells["EMail"].Value.ToString();
            this.ParentForm.lbl_mieter_txt.Visible = true;
            this.ParentForm.objekt = (int)dgv_TableSelect.SelectedRows[0].Cells["WE"].Value;
            this.ParentForm.lbl_objekt_txt.Text = dgv_TableSelect.SelectedRows[0].Cells["Ortname"].Value.ToString();
            this.ParentForm.lbl_objekt_txt.Visible = true;
            this.ParentForm.mandant = (int)dgv_TableSelect.SelectedRows[0].Cells["Unternehmen"].Value;
            this.ParentForm.HausNr = (int)dgv_TableSelect.SelectedRows[0].Cells["HausNr"].Value;
            this.ParentForm.lbl_haus_txt.Text = dgv_TableSelect.SelectedRows[0].Cells["Strasse"].Value.ToString();
            this.ParentForm.lbl_haus_txt.Visible = true;
            this.ParentForm.wohnung = (int)dgv_TableSelect.SelectedRows[0].Cells["WohnNr"].Value;
            this.ParentForm.lbl_wo_txt.Text = "";
            this.ParentForm.lbl_wo_txt.Visible = true;
            // Get/Set Name2 from Adresse to ParenForm
            Globals.ThisAddIn.msg_parameter.Vorname = dgv_TableSelect.SelectedRows[0].Cells["Name2"].Value.ToString();
            Globals.ThisAddIn.msg_parameter.Name = dgv_TableSelect.SelectedRows[0].Cells["Name1"].Value.ToString();
            Globals.ThisAddIn.msg_parameter.FolgeNr = (int)dgv_TableSelect.SelectedRows[0].Cells["Folgenummer"].Value;
            Globals.ThisAddIn.msg_parameter.NeStrasse = dgv_TableSelect.SelectedRows[0].Cells["Strasse"].Value.ToString();
            Globals.ThisAddIn.msg_parameter.NeOrt = dgv_TableSelect.SelectedRows[0].Cells["Ortname"].Value.ToString();
            string MiTel = dgv_TableSelect.SelectedRows[0].Cells["Vorwahl1"].Value.ToString();
            MiTel += " / " + dgv_TableSelect.SelectedRows[0].Cells["Telefon1"].Value.ToString();
            Globals.ThisAddIn.msg_parameter.MiTel = MiTel;
            string MiMob = dgv_TableSelect.SelectedRows[0].Cells["VorwahlMobil"].Value.ToString();
            MiMob += " / " + dgv_TableSelect.SelectedRows[0].Cells["TelefonMobil"].Value.ToString();
            Globals.ThisAddIn.msg_parameter.MiMob = MiMob;
            string MiTel2 = dgv_TableSelect.SelectedRows[0].Cells["Vorwahl2"].Value.ToString();
            MiTel2 += " / " + dgv_TableSelect.SelectedRows[0].Cells["Telefon2"].Value.ToString();
            Globals.ThisAddIn.msg_parameter.MiTel2 = MiTel2;
            Globals.ThisAddIn.msg_parameter.Mandant = (int)dgv_TableSelect.SelectedRows[0].Cells["MandantNr"].Value;
            //Getting Etage and Fill it to Form and Global Data
            //***Begin***
            DataSet1_WOWI_SEARCH.tblWohnungDataTable wohnungTable;
            wohnungTable = this.tblWohnungTableAdapter.GetDataByUnWeHaNe(
                                             (int)dgv_TableSelect.SelectedRows[0].Cells[3].Value,
                                             (int)dgv_TableSelect.SelectedRows[0].Cells[4].Value,
                                             (int)dgv_TableSelect.SelectedRows[0].Cells[1].Value,
                                             (int)dgv_TableSelect.SelectedRows[0].Cells[5].Value,
                                             (int)dgv_TableSelect.SelectedRows[0].Cells[2].Value);
            if (wohnungTable.Rows.Count > 0)
            {
                string etage = wohnungTable[0].GeschossText + ", " + wohnungTable[0].WohnlageText;
                this.ParentForm.lbl_wo_txt.Text = etage;
                this.ParentForm.lbl_wo_txt.Visible = true;
                Globals.ThisAddIn.msg_parameter.NeEtage = etage;
            }
            //***End***
            this.set_WE_lable();
            Globals.ThisAddIn.msg_parameter.BriefAnrede = this.getBriefAnrede((int)dgv_TableSelect.SelectedRows[0].Cells["BriefAnrNr"].Value);            
        }

        private string getBriefAnrede(int BriefAnredeNr)
        {
            DataSet1_WOWI_SEARCH.tblBriefanredeDataTable anredeTable;
            anredeTable = this.tblBriefanredeTableAdapter.GetByNr(BriefAnredeNr);
            string BriefAnrede = "";
            if (anredeTable.Rows.Count > 0)
            {
                BriefAnrede = anredeTable[0].BriefAnrText;
            }
            return BriefAnrede;
        }

        // setting WE Infotext by current Parentform WE data
        private void set_WE_lable()
        {
            this.ParentForm.set_WE_lable();
        }

        // TODO: Not in Use - Do I need this?
        private void txt_filer1_TextChanged(object sender, EventArgs e)
        {
            switch (_btn_typ)
            {
                case "kr":
                    {

                        break;
                    }
            }
        }
         
        #region TableFillFuncitons

        private void fill_dgv_with_Kerditor()
        {
            if (this.ParentForm.mandant != 0)
            {
                kreditorKontoBindingSource.Filter = "Unternehmen = " + this.ParentForm.mandant;
                this.dgv_TableSelect.DataSource = kreditorKontoBindingSource;
            }
            else
            {
                this.dgv_TableSelect.DataSource = kreditorKontoBindingSource;
            }
            this.kreditor_KontoTableAdapter.Fill(dataSet1_WoWi_Kreditor._Kreditor_Konto);
            this.txt_filer1.Visible = true;
            this.lbl_1.Text = "Kontenbezeichnung suchen";
            this.lbl_1.Visible = true;
            this.btn_search.Visible = true;           
        }

        private void fill_dgv_with_Mieter()
        {
            // Progress ist limitating the RowCount so it need to be filtered high
            if (this.ParentForm.mandant != 0 && this.ParentForm.objekt != 0 && this.ParentForm.HausNr == 0
                 && this.ParentForm.wohnung == 0 && this.ParentForm.Mieter == 0)
            {
                this.dgv_TableSelect.DataSource = xyMieterBindingSource1;
                this.xyMieterTableAdapterWoWiSearch.FillByUnWe(dataSet1_WOWI_SEARCH.xyMieter, this.ParentForm.mandant1, this.ParentForm.mandant, this.ParentForm.objekt);  
            }
            else if (this.ParentForm.mandant !=0 && this.ParentForm.objekt !=0 && this.ParentForm.HausNr !=0
                && this.ParentForm.wohnung == 0 && this.ParentForm.Mieter == 0)
            {
                //TODO: REMOVE MessageBox.Show("TEST POS 2 - Wo und Mieter 0");
                this.dgv_TableSelect.DataSource = xyMieterBindingSource1;
                this.xyMieterTableAdapterWoWiSearch.FillByUnWeHa(dataSet1_WOWI_SEARCH.xyMieter, this.ParentForm.mandant, this.ParentForm.objekt,
                    this.ParentForm.HausNr, this.ParentForm.mandant1);  
            }
            else if (this.ParentForm.mandant != 0 && this.ParentForm.objekt != 0 && this.ParentForm.HausNr != 0
                 && this.ParentForm.wohnung != 0 && this.ParentForm.Mieter == 0)
            {
                //TODO: REMOVE MessageBox.Show("TEST POS 1 - Mieter 0");
                this.dgv_TableSelect.DataSource = xyMieterBindingSource1;
                this.xyMieterTableAdapterWoWiSearch.FillbyUnWeHaWo(dataSet1_WOWI_SEARCH.xyMieter, this.ParentForm.mandant, this.ParentForm.objekt,
                    this.ParentForm.HausNr, this.ParentForm.wohnung, this.ParentForm.mandant1);  
            }
            else if (this.ParentForm.Mieter != 0)
            {
                this.dgv_TableSelect.DataSource = xyMieterBindingSource1;
                this.xyMieterTableAdapterWoWiSearch.FillByAdrNr(dataSet1_WOWI_SEARCH.xyMieter, this.ParentForm.Mieter, this.ParentForm.mandant1);  
            }
             // Mieter comes by Address
            else if (this.ParentForm.txt_Adresse.Text != "")
            {
                int adr = int.Parse(this.ParentForm.txt_Adresse.Text);
                this.dgv_TableSelect.DataSource = xyMieterBindingSource1;
                this.xyMieterTableAdapterWoWiSearch.FillByAdrNr(dataSet1_WOWI_SEARCH.xyMieter, this.ParentForm.mandant1, adr);
            }
            else
            {
                //this.dgv_TableSelect.DataSource = xyMieterBindingSource;
            }
            //this.xyMieterTableAdapter.Fill_By_Name1(dataSet1xyMieter.xyMieter);
           
            this.txt_filer1.Visible = true;
            this.lbl_1.Text = "Name1 suchen";
            this.lbl_1.Visible = true;
            //this.txt_filter2.Visible = true;
            //this.lbl_2.Text = "Name2 suchen";
            //this.lbl_2.Visible = true;
            this.btn_search.Visible = true;
        }

        private void fill_dgv_with_Wohnung()
        {
            this.dgv_TableSelect.DataSource = tblWohnungBindingSource;
            if (this.ParentForm.mandant != 0 && this.ParentForm.objekt != 0 && this.ParentForm.HausNr == 0)
            {
                this.xyMieterTableAdapterWoWiSearch.FillByName1(dataSet1_WOWI_SEARCH.xyMieter, this.ParentForm.mandant1, this.txt_filer1.Text);
                this.tblWohnungTableAdapter.FillByUnWe(dataSet1_WOWI_SEARCH.tblWohnung, this.ParentForm.mandant,
                    this.ParentForm.objekt, this.ParentForm.mandant1);
            }
            else if (this.ParentForm.mandant != 0 && this.ParentForm.objekt != 0 && this.ParentForm.HausNr != 0)
            {
                this.xyMieterTableAdapterWoWiSearch.FillByName1(dataSet1_WOWI_SEARCH.xyMieter, this.ParentForm.mandant1, this.txt_filer1.Text);
                this.tblWohnungTableAdapter.Fillby_UnWeHa(dataSet1_WOWI_SEARCH.tblWohnung, this.ParentForm.mandant, 
                    this.ParentForm.objekt, this.ParentForm.HausNr, this.ParentForm.mandant1);
            }
            else
            {
                MessageBox.Show("Sie müssen mindestens Unternehmen und WE angegeben haben!");
                this.Close();
            }
        }

        private void fill_AdressenToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.kreditor_KontoTableAdapter.Fill(this.dataSet1_WoWi_Kreditor._Kreditor_Konto);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        #endregion

        // Search by Textboxesinput after Button Search was clicked
        private void btn_search_Click(object sender, EventArgs e)
        {
            switch (_btn_typ)
            {
                case "kr":
                    {
                        // HowTo Filter siehe:
                        // http://www.entwickler-ecke.de/topic_DataGridView+inhalte+filtern_99080,0.html
                        // Die % Zeichen sagen deinem DVG, dass es sich nicht um einen zu suchenden Begriff, sondern um eine zu suchende Zeichenfolge mitten im Text handelt. 
                        if (this.ParentForm.mandant != 0)
                        {
                            kreditorKontoBindingSource.Filter = "Unternehmen = " + this.ParentForm.mandant + " AND Kontobezeichnung LIKE '%" + this.txt_filer1.Text + "%'";
                            this.dgv_TableSelect.DataSource = kreditorKontoBindingSource;
                        }
                        else
                        {
                            kreditorKontoBindingSource.Filter = "Kontobezeichnung LIKE '%" + this.txt_filer1.Text + "%'";
                            this.dgv_TableSelect.DataSource = kreditorKontoBindingSource;
                        }
                        this.kreditor_KontoTableAdapter.Fill(dataSet1_WoWi_Kreditor._Kreditor_Konto);
                        break;
                    }
                case "mi":
                    {
                        // https://msdn.microsoft.com/de-de/library/ms171920%28v=VS.120%29.aspx
                        //this.dgv_TableSelect.DataSource = xyMieterBindingSource;
                        ////DateTime jahresbeginn = new DateTime(2015, 1, 1);
                        //this.xyMieterTableAdapter.Fill_by_Name1(dataSet1xyMieter.xyMieter, this.txt_filer1.Text);
                        this.dgv_TableSelect.DataSource = xyMieterBindingSource1;
                        this.xyMieterTableAdapterWoWiSearch.FillByName1(dataSet1_WOWI_SEARCH.xyMieter, this.ParentForm.mandant1, this.txt_filer1.Text);
                        break;
                    }
                case "ad":
                    {
                        string filter1 = '%' + txt_filer1.Text + '%';
                        string filter2 = '%' + txt_filter2.Text + '%';
                        if (string.IsNullOrWhiteSpace(txt_filer1.Text) == false && string.IsNullOrWhiteSpace(txt_filter2.Text) == false)
                        {
                                this.dgv_TableSelect.DataSource = tblAdressSearchBindingSource;
                                this.tblAdressSearchTableAdapter.FillByName1andName2(dataSet1_WOWI_SEARCH.tblAdressSearch, filter1,filter2);                            
                        }
                        else if (string.IsNullOrWhiteSpace(txt_filer1.Text) == false && (string.IsNullOrEmpty(txt_filter2.Text) || string.IsNullOrWhiteSpace(txt_filter2.Text)))
                        {
                            this.dgv_TableSelect.DataSource = tblAdressSearchBindingSource;
                            this.tblAdressSearchTableAdapter.FillByName1(dataSet1_WOWI_SEARCH.tblAdressSearch, filter1);
                        }
                        else if (string.IsNullOrWhiteSpace(txt_filter2.Text) == false && (string.IsNullOrWhiteSpace(txt_filer1.Text) || string.IsNullOrWhiteSpace(txt_filer1.Text)))
                        {
                            this.dgv_TableSelect.DataSource = tblAdressSearchBindingSource;
                            this.tblAdressSearchTableAdapter.FillByName2(dataSet1_WOWI_SEARCH.tblAdressSearch, filter2);
                        }                     
                        break;
                    }
            }
        }

        private void txt_filer1_KeyDown(object sender, KeyEventArgs e)
        {
            // Enter will do the same as the SearchButton
            if (e.KeyCode == Keys.Enter)
            {
                this.btn_search_Click(sender, e);
            }
        }

        #region FormDesign

        private void setFormName()
        {
            switch (_btn_typ)
            {
                case "ma":
                    {
                        this.Text = "MSG-Suche: Unternehmen";
                        break;
                    }
                case "ob":
                    {
                        this.Text = "MSG-Suche: WE";
                        break;
                    }
                case "kr":
                    {
                        this.Text = "MSG-Suche: Kreditor";
                        break;
                    }
                case "ha":
                    {
                        this.Text = "MSG-Suche: Haus";
                        break;
                    }
                case "wo":
                    {
                        this.Text = "MSG-Suche: Wohnung";
                        break;
                    }
                case "mi":
                    {
                        this.Text = "MSG-Suche: Mieter";
                        break;
                    }
            }
        }

        #endregion
    }
}
