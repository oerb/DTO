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
    public partial class Frm_New_MSGTYPE : Form
    {
        // formmode has two Values  new or edit
        public Frm_New_MSGTYPE(string formmode, int id, string msgtype, string filelocation, bool Date1show
            , string Date1Name, bool Date2show, string Date2Name )
        {
            InitializeComponent();
            this.formmode = formmode;
            if (formmode == "edit")
            {
                this.txt_mailtype.Text = msgtype;
                this.txt_filelocation.Text = filelocation;
                this.id = id;                
            }
            else if ( formmode == "new")
            {
                // do nothing and go on
            }
            else
            {
                MessageBox.Show("ERROR: (Frm_New_MSGTYPE.cs) - Wrong formmode !");
            }
        }

        //// Inheriting the calling Parent Form for recalls
        private Frm_Settings _ParentForm;

        public new Frm_Settings ParentForm
        {
            get { return _ParentForm; }
            set { _ParentForm = value; }
        }
        

        //// Prefilling Data to Form
        //public string msgtype
        //{
        //    get { return this.txt_mailtype.Text; }
        //    set { this.txt_mailtype.Text = value; }
        //}

        //public string filelocation
        //{
        //    get { return this.txt_filelocation.Text; }
        //    set { this.txt_filelocation.Text = value; }
        //}

        // Formmode New or Edit
        private string _formmode;

        public string formmode
        {
            get { return this._formmode; }
            set { this._formmode = value; }
        }

        // Id of the Row for Edit DataSet
        private int _id;

        public int id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ParentForm.update_lbx_MSGTYPES(this.formmode, this.id, this.txt_mailtype.Text, this.txt_filelocation.Text
                , this.cmb_dokuart.Text, this.cmb_vorgangkz.Text, this.cbxDatum1Anzeigen.Checked, 
                this.txtDatum1Bezeichnung.Text, this.cxbDatum2Anzeigen.Checked, this.txtDatum2Bezeichnung.Text);
            this.Close();            
        }

        private void btn_filesearch_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.txt_filelocation.Text = openFileDialog1.FileName;
            }
        }
    }
}
