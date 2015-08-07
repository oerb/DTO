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
    public partial class Frm_Search : Form
    {

        #region Properties

        private string _btn_typ;



        #endregion 

           
        public Frm_Search(string btn_typ)
        {
            InitializeComponent();
            // TODO: REMOVE TESTING
            //MessageBox.Show(btn_typ);
            _btn_typ = btn_typ;

        }
        
        // Inheriting the calling Parent Form for recalls
        private Frm_MSG _ParentForm;
        public new Frm_MSG ParentForm
        {
            get { return _ParentForm; }
            set { _ParentForm = value; }
        }

        // Prefilling the Gridviewtable by what ist chosen in Frm_MSG.cs
        private void Frm_Search_Load(object sender, EventArgs e)
        {           
            // select the Databinding by _btn_type from Instantiation
            switch (_btn_typ)
            {
                case "ma":
                    {
                        this.dgv_TableSelect.DataSource = mandantBindingSource;        
                        this.mandantTableAdapter.Fill(this.dataSet1_WoWi_Mandant.Mandant);
                        break;
                    }
                case "kr":
                    {
                        fill_dgv_with_Kerditor();
                        break;
                    }
                case "ob":
                    {
                        if (this.ParentForm.mandant != 0)
                        {
                            wirtschaftseinheitBindingSource.Filter = "Unternehmen = " + this.ParentForm.mandant;
                            this.dgv_TableSelect.DataSource = wirtschaftseinheitBindingSource;
                        }
                        else
                        {
                            this.dgv_TableSelect.DataSource = wirtschaftseinheitBindingSource;
                        }
                        
                        this.wirtschaftseinheitTableAdapter.Fill(this.dataSet1_WoWi_Objekte.Wirtschaftseinheit);
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
                            this.dgv_TableSelect.DataSource = hausBindingSource;
                        }
                        this.hausTableAdapter.Fill(this.dataSet1_WoWi_Haus.Haus);
                        break;
                    }
                case "wo":
                    {
                        break;
                    }
                case "mi":
                    {
                        fill_dgv_with_Mieter();
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

        // Filling selected Data to Parentform
        private void setData_to_ParentForm()
        {
            // Setting Data to Frm_MSG.cs bei the GridView Click
            if (dgv_TableSelect.SelectedRows.Count == 0) return;
            switch (_btn_typ)
            {
                case "ma":
                    {
                        
                        this.ParentForm.mandant = (int)dgv_TableSelect.SelectedRows[0].Cells[0].Value;
                        this.ParentForm.lbl_mandant_txt.Text = dgv_TableSelect.SelectedRows[0].Cells[2].Value.ToString();
                        this.ParentForm.lbl_mandant_txt.Visible = true;

                        break;
                    }
                case "ob":
                    {
                        this.ParentForm.txt_objekt.Text = dgv_TableSelect.SelectedRows[0].Cells[0].Value.ToString();
                        string Text = dgv_TableSelect.SelectedRows[0].Cells[2].Value.ToString();
                        Text += ", " + dgv_TableSelect.SelectedRows[0].Cells[3].Value.ToString();
                        Text += ", " + dgv_TableSelect.SelectedRows[0].Cells[1].Value.ToString();
                        this.ParentForm.lbl_objekt_txt.Text = Text;
                        this.ParentForm.lbl_objekt_txt.Visible = true;
                        break;
                    }
                case "kr":
                    {
                        this.ParentForm.kreditor = (int)dgv_TableSelect.SelectedRows[0].Cells[1].Value;
                        this.ParentForm.lbl_kreditor_txt.Text = dgv_TableSelect.SelectedRows[0].Cells[2].Value.ToString();
                        this.ParentForm.lbl_kreditor_txt.Visible = true;
                        this.ParentForm.eMail = dgv_TableSelect.SelectedRows[0].Cells[19].Value.ToString();                        
                        break;
                    }
                case "ha":
                    {
                        this.ParentForm.HausNr = (int)dgv_TableSelect.SelectedRows[0].Cells[0].Value;
                        this.ParentForm.lbl_haus_txt.Text = dgv_TableSelect.SelectedRows[0].Cells[2].Value.ToString();
                        this.ParentForm.lbl_haus_txt.Visible = true;
                        break;
                    }
                case "wo":
                    {
                        //this.ParentForm.txt_we = dgv_TableSelect.SelectedRows[0].Cells[0].Value.ToString();
                        break;
                    }
                case "mi":
                    {
                        this.ParentForm.Mieter = (int)dgv_TableSelect.SelectedRows[0].Cells[0].Value;
                        this.ParentForm.lbl_mieter_txt.Text = dgv_TableSelect.SelectedRows[0].Cells[9].Value.ToString();
                        this.ParentForm.eMail = dgv_TableSelect.SelectedRows[0].Cells[13].Value.ToString(); 
                        this.ParentForm.lbl_mieter_txt.Visible = true;
                        break;
                    }
                case "me":
                    {
                        this.ParentForm.filelocation = dgv_TableSelect.SelectedRows[0].Cells[2].Value.ToString();
                        
                        //this.ParentForm.txb_Subject.Text = dgv_TableSelect.SelectedRows[0].Cells[1].Value.ToString();
                        this.ParentForm.txt_meldungstyp.Text = dgv_TableSelect.SelectedRows[0].Cells[1].Value.ToString();
                        break;
                    }
            }
            //if (this._btn_typ == "me")
            //{
            //    this.ParentForm.filelocation = dgv_TableSelect.SelectedRows[0].Cells[2].Value.ToString();
            //    this.ParentForm.txb_Subject.Text = dgv_TableSelect.SelectedRows[0].Cells[1].Value.ToString();
            //}
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
         
        #region TableFillFuncitons_Seperated

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
            if (this.ParentForm.mandant != 0 && this.ParentForm.objekt !=0)
            {
                //xyMieterBindingSource.Filter = "Unternehmen = " + this.ParentForm.mandant;
                //this.dgv_TableSelect.DataSource = xyMieterBindingSource;
                this.dgv_TableSelect.DataSource = xyMieterBindingSource;
                //DateTime jahresbeginn = new DateTime(2015, 1, 1);

                this.xyMieterTableAdapter.FillByIDS(dataSet1xyMieter.xyMieter, this.ParentForm.mandant, this.ParentForm.objekt);
            }
            else if (this.ParentForm.mandant !=0 && this.ParentForm.objekt !=0 && this.ParentForm.HausNr !=0)
            {
                this.dgv_TableSelect.DataSource = xyMieterBindingSource;
                this.xyMieterTableAdapter.FillBy_Haus_Unt_WE(dataSet1xyMieter.xyMieter, this.ParentForm.mandant, this.ParentForm.objekt,
                    this.ParentForm.HausNr);
            }
            else
            {
                //this.dgv_TableSelect.DataSource = xyMieterBindingSource;
            }
            //this.xyMieterTableAdapter.Fill_By_Name1(dataSet1xyMieter.xyMieter);
           
            this.txt_filer1.Visible = true;
            this.lbl_1.Text = "Name1 suchen";
            this.lbl_1.Visible = true;
            this.txt_filter2.Visible = true;
            this.lbl_2.Text = "Name2 suchen";
            this.lbl_2.Visible = true;
            this.btn_search.Visible = true;
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

        // Search by Textboxesinput after Button clicked
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
                        this.dgv_TableSelect.DataSource = xyMieterBindingSource;
                        //DateTime jahresbeginn = new DateTime(2015, 1, 1);
                        
                        this.xyMieterTableAdapter.Fill_by_Name1(dataSet1xyMieter.xyMieter, this.txt_filer1.Text);
                        break;
                    }
            }
        }


    }
}
