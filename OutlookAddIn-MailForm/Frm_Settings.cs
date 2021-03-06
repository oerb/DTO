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
    public partial class Frm_Settings : Form
    {
        public Frm_Settings()
        {
            InitializeComponent();
        }
        // Is for saving Data to Table and Refresh Form
        // TODO: Trennen von Speichern und Füllen
        public void update_lbx_MSGTYPES(string formmode, int id, string msgtype, string filelocation,
            string dokuart, string vorgangkz, bool datum1show, string datum1name, bool datum2show, 
            string datum2name, bool MandantAnz, bool UnternehmenAnz,
            bool KreditorAnz, bool WEanz, bool HausAnz, bool NEanz, bool MieterAnz, bool AdresseAnz)
        {         
            if (formmode == "new")
            {
                this.tableTableAdapter.Insert(msgtype, filelocation, dokuart, vorgangkz, datum1show
                    , datum1name, datum2show, datum2name, MandantAnz, UnternehmenAnz, KreditorAnz, 
                    WEanz, HausAnz, NEanz, MieterAnz, AdresseAnz);
            }
            else if (formmode == "edit")
            {
                this.tableTableAdapter.UpdateByID(msgtype, filelocation, dokuart, vorgangkz, datum1show
                    , datum1name, datum2show, datum2name, MandantAnz, UnternehmenAnz, KreditorAnz, 
                    WEanz, HausAnz, NEanz, MieterAnz, AdresseAnz, id);
            }
            else
            {
                MessageBox.Show("Error unknown formmode");
            }
            this.tableTableAdapter.Fill(this.database1DataSet_MSGTYPES.Table);
        }

        private void btn_new_msgtype_Click(object sender, EventArgs e)
        {
            Frm_New_MSGTYPE frm_New_MSGTYPE = new Frm_New_MSGTYPE("new", 0, " ", " ", " ", " ", false, " ", false, " ",
                false, false, false, false, false, false, false, false);
            frm_New_MSGTYPE.ParentForm = this;
            DialogResult result = frm_New_MSGTYPE.ShowDialog();
        }

        private void Frm_Settings_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet_MSGTYPES.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.database1DataSet_MSGTYPES.Table);
            
        }
        
        private void btn_delete_Click(object sender, EventArgs e)
        {
            //string meldung = this.lbx_mbstypes.SelectedIndex.ToString() + " " + this.lbx_mbstypes.SelectedValue.ToString();
            //MessageBox.Show(meldung);
            // this link helped in Line *1
            // http://stackoverflow.com/questions/15428542/why-i-get-system-data-datarowview-instead-of-real-values-in-my-listbox
            if (this.lbx_mbstypes.SelectedItems.Count > 0)
            {
                this.tableTableAdapter.DeleteByID((int)this.lbx_mbstypes.SelectedValue);
                this.tableTableAdapter.Update(this.database1DataSet_MSGTYPES.Table); // *1
                this.tableTableAdapter.Fill(this.database1DataSet_MSGTYPES.Table);
            }
            
        }

        private void lbx_mbstypes_Click(object sender, EventArgs e)
        {
            //string meldung = this.lbx_mbstypes.SelectedIndex.ToString() + " " + this.lbx_mbstypes.DisplayMember.ToString();
            //MessageBox.Show(meldung);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (this.lbx_mbstypes.SelectedItems.Count > 0)
            {
                //MessageBox.Show(this.tableTableAdapter.GetMSGTYP((int)this.lbx_mbstypes.SelectedValue).ToString());
                string msgtyp = this.tableTableAdapter.GetMSGTYP((int)this.lbx_mbstypes.SelectedValue).ToString();
                string filelocation = this.tableTableAdapter.GetFileLocation((int)this.lbx_mbstypes.SelectedValue).ToString();
                int id = (int)this.lbx_mbstypes.SelectedValue;
                Database1DataSet_MSGTYPES.TableDataTable msgtypTable;
                msgtypTable = this.tableTableAdapter.GetDataByID((int)this.lbx_mbstypes.SelectedValue);                
                Frm_New_MSGTYPE frm_New_MSGTYPE = new Frm_New_MSGTYPE("edit", id, msgtyp, filelocation, 
                    msgtypTable[0].Dokuart.ToString(), msgtypTable[0].VorgangKZ.ToString() , msgtypTable[0].Datum1show,
                    msgtypTable[0].Datum1Name.ToString(), msgtypTable[0].Datum2show, msgtypTable[0].Datum2Name.ToString(),
                    msgtypTable[0].MandantAnz, msgtypTable[0].UnternehmenAnz, msgtypTable[0].KreditorAnz, msgtypTable[0].WEanz,
                    msgtypTable[0].HausAnz, msgtypTable[0].NEanz, msgtypTable[0].MieterAnz, msgtypTable[0].AdresseAnz);
                frm_New_MSGTYPE.ParentForm = this;
                DialogResult result = frm_New_MSGTYPE.ShowDialog();
            }           
        }
    }
}
