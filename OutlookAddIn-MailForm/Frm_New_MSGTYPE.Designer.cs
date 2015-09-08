namespace OutlookAddIn_MailForm
{
    partial class Frm_New_MSGTYPE
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_New_MSGTYPE));
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_filesearch = new System.Windows.Forms.Button();
            this.txt_filelocation = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet_MSGTYPES = new OutlookAddIn_MailForm.Database1DataSet_MSGTYPES();
            this.tableTableAdapter = new OutlookAddIn_MailForm.Database1DataSet_MSGTYPESTableAdapters.TableTableAdapter();
            this.txt_mailtype = new System.Windows.Forms.TextBox();
            this.lbl_msgtyp = new System.Windows.Forms.Label();
            this.lbl_filelocation = new System.Windows.Forms.Label();
            this.lbl_vorgangkz = new System.Windows.Forms.Label();
            this.cmb_vorgangkz = new System.Windows.Forms.ComboBox();
            this.wOWIVORGANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saperionDataSetDokuartDokuKZBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saperionDataSet_Dokuart_DokuKZ = new OutlookAddIn_MailForm.saperionDataSet_Dokuart_DokuKZ();
            this.lbl_dokuart = new System.Windows.Forms.Label();
            this.cmb_dokuart = new System.Windows.Forms.ComboBox();
            this.wOWIDOKARTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grbVorbelegungen = new System.Windows.Forms.GroupBox();
            this.cbx_adresse_anzeigen = new System.Windows.Forms.CheckBox();
            this.cbx_mieter_anzeigen = new System.Windows.Forms.CheckBox();
            this.cbx_ne_anzeigen = new System.Windows.Forms.CheckBox();
            this.cbx_haus_anzeigen = new System.Windows.Forms.CheckBox();
            this.cbx_we_anzeigen = new System.Windows.Forms.CheckBox();
            this.cbx_kreditor_anzeigen = new System.Windows.Forms.CheckBox();
            this.cbx_unternehmen_anzeigen = new System.Windows.Forms.CheckBox();
            this.cbx_mandant_anzeigen = new System.Windows.Forms.CheckBox();
            this.cbxDatum2Anzeigen = new System.Windows.Forms.CheckBox();
            this.lblDatum2 = new System.Windows.Forms.Label();
            this.txtDatum2Bezeichnung = new System.Windows.Forms.TextBox();
            this.cbxDatum1Anzeigen = new System.Windows.Forms.CheckBox();
            this.lblDatumBezeichnung = new System.Windows.Forms.Label();
            this.txtDatum1Bezeichnung = new System.Windows.Forms.TextBox();
            this.btn_help = new System.Windows.Forms.Button();
            this.wOWIDOKARTTableAdapter = new OutlookAddIn_MailForm.saperionDataSet_Dokuart_DokuKZTableAdapters.WOWIDOKARTTableAdapter();
            this.wOWIVORGANGTableAdapter = new OutlookAddIn_MailForm.saperionDataSet_Dokuart_DokuKZTableAdapters.WOWIVORGANGTableAdapter();
            this.dataSet1_WOWI_SEARCH = new OutlookAddIn_MailForm.DataSet1_WOWI_SEARCH();
            this.tblDokuartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblDokuartTableAdapter = new OutlookAddIn_MailForm.DataSet1_WOWI_SEARCHTableAdapters.tblDokuartTableAdapter();
            this.dataSet1WOWISEARCHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblVorgangKZBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblVorgangKZTableAdapter = new OutlookAddIn_MailForm.DataSet1_WOWI_SEARCHTableAdapters.tblVorgangKZTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet_MSGTYPES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wOWIVORGANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saperionDataSetDokuartDokuKZBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saperionDataSet_Dokuart_DokuKZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wOWIDOKARTBindingSource)).BeginInit();
            this.grbVorbelegungen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1_WOWI_SEARCH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDokuartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1WOWISEARCHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVorgangKZBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.Location = new System.Drawing.Point(421, 410);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(194, 48);
            this.btn_save.TabIndex = 17;
            this.btn_save.Text = "übernehmen";
            this.btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_filesearch
            // 
            this.btn_filesearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_filesearch.Image = ((System.Drawing.Image)(resources.GetObject("btn_filesearch.Image")));
            this.btn_filesearch.Location = new System.Drawing.Point(570, 45);
            this.btn_filesearch.Name = "btn_filesearch";
            this.btn_filesearch.Size = new System.Drawing.Size(45, 33);
            this.btn_filesearch.TabIndex = 16;
            this.btn_filesearch.UseVisualStyleBackColor = true;
            this.btn_filesearch.Click += new System.EventHandler(this.btn_filesearch_Click);
            // 
            // txt_filelocation
            // 
            this.txt_filelocation.Location = new System.Drawing.Point(143, 50);
            this.txt_filelocation.Name = "txt_filelocation";
            this.txt_filelocation.Size = new System.Drawing.Size(421, 22);
            this.txt_filelocation.TabIndex = 18;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Outlook MSG Dateien (.msg) |*.msg";
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.database1DataSet_MSGTYPES;
            // 
            // database1DataSet_MSGTYPES
            // 
            this.database1DataSet_MSGTYPES.DataSetName = "Database1DataSet_MSGTYPES";
            this.database1DataSet_MSGTYPES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // txt_mailtype
            // 
            this.txt_mailtype.Location = new System.Drawing.Point(143, 22);
            this.txt_mailtype.MaxLength = 50;
            this.txt_mailtype.Name = "txt_mailtype";
            this.txt_mailtype.Size = new System.Drawing.Size(421, 22);
            this.txt_mailtype.TabIndex = 22;
            // 
            // lbl_msgtyp
            // 
            this.lbl_msgtyp.AutoSize = true;
            this.lbl_msgtyp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_msgtyp.Location = new System.Drawing.Point(22, 25);
            this.lbl_msgtyp.Name = "lbl_msgtyp";
            this.lbl_msgtyp.Size = new System.Drawing.Size(89, 20);
            this.lbl_msgtyp.TabIndex = 23;
            this.lbl_msgtyp.Text = "MSG Typ: ";
            // 
            // lbl_filelocation
            // 
            this.lbl_filelocation.AutoSize = true;
            this.lbl_filelocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filelocation.Location = new System.Drawing.Point(22, 53);
            this.lbl_filelocation.Name = "lbl_filelocation";
            this.lbl_filelocation.Size = new System.Drawing.Size(91, 20);
            this.lbl_filelocation.TabIndex = 24;
            this.lbl_filelocation.Text = "Dateipfad: ";
            // 
            // lbl_vorgangkz
            // 
            this.lbl_vorgangkz.AutoSize = true;
            this.lbl_vorgangkz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vorgangkz.Location = new System.Drawing.Point(10, 54);
            this.lbl_vorgangkz.Name = "lbl_vorgangkz";
            this.lbl_vorgangkz.Size = new System.Drawing.Size(96, 20);
            this.lbl_vorgangkz.TabIndex = 48;
            this.lbl_vorgangkz.Text = "Vorgang KZ";
            // 
            // cmb_vorgangkz
            // 
            this.cmb_vorgangkz.DataSource = this.tblVorgangKZBindingSource;
            this.cmb_vorgangkz.DisplayMember = "VorgangKZ";
            this.cmb_vorgangkz.FormattingEnabled = true;
            this.cmb_vorgangkz.Location = new System.Drawing.Point(145, 51);
            this.cmb_vorgangkz.Name = "cmb_vorgangkz";
            this.cmb_vorgangkz.Size = new System.Drawing.Size(408, 24);
            this.cmb_vorgangkz.TabIndex = 47;
            this.cmb_vorgangkz.ValueMember = "VorgangKZ";
            // 
            // wOWIVORGANGBindingSource
            // 
            this.wOWIVORGANGBindingSource.DataMember = "WOWIVORGANG";
            this.wOWIVORGANGBindingSource.DataSource = this.saperionDataSetDokuartDokuKZBindingSource;
            // 
            // saperionDataSetDokuartDokuKZBindingSource
            // 
            this.saperionDataSetDokuartDokuKZBindingSource.DataSource = this.saperionDataSet_Dokuart_DokuKZ;
            this.saperionDataSetDokuartDokuKZBindingSource.Position = 0;
            // 
            // saperionDataSet_Dokuart_DokuKZ
            // 
            this.saperionDataSet_Dokuart_DokuKZ.DataSetName = "saperionDataSet_Dokuart_DokuKZ";
            this.saperionDataSet_Dokuart_DokuKZ.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_dokuart
            // 
            this.lbl_dokuart.AutoSize = true;
            this.lbl_dokuart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dokuart.Location = new System.Drawing.Point(10, 25);
            this.lbl_dokuart.Name = "lbl_dokuart";
            this.lbl_dokuart.Size = new System.Drawing.Size(68, 20);
            this.lbl_dokuart.TabIndex = 46;
            this.lbl_dokuart.Text = "Dokuart";
            // 
            // cmb_dokuart
            // 
            this.cmb_dokuart.DataSource = this.tblDokuartBindingSource;
            this.cmb_dokuart.DisplayMember = "DOKUART";
            this.cmb_dokuart.FormattingEnabled = true;
            this.cmb_dokuart.Location = new System.Drawing.Point(145, 21);
            this.cmb_dokuart.Name = "cmb_dokuart";
            this.cmb_dokuart.Size = new System.Drawing.Size(408, 24);
            this.cmb_dokuart.TabIndex = 45;
            this.cmb_dokuart.ValueMember = "DOKUART";
            this.cmb_dokuart.DropDown += new System.EventHandler(this.cmb_dokuart_DropDown);
            this.cmb_dokuart.SelectedIndexChanged += new System.EventHandler(this.cmb_dokuart_SelectedIndexChanged);
            // 
            // wOWIDOKARTBindingSource
            // 
            this.wOWIDOKARTBindingSource.DataMember = "WOWIDOKART";
            this.wOWIDOKARTBindingSource.DataSource = this.saperionDataSetDokuartDokuKZBindingSource;
            // 
            // grbVorbelegungen
            // 
            this.grbVorbelegungen.Controls.Add(this.cbx_adresse_anzeigen);
            this.grbVorbelegungen.Controls.Add(this.cbx_mieter_anzeigen);
            this.grbVorbelegungen.Controls.Add(this.cbx_ne_anzeigen);
            this.grbVorbelegungen.Controls.Add(this.cbx_haus_anzeigen);
            this.grbVorbelegungen.Controls.Add(this.cbx_we_anzeigen);
            this.grbVorbelegungen.Controls.Add(this.cbx_kreditor_anzeigen);
            this.grbVorbelegungen.Controls.Add(this.cbx_unternehmen_anzeigen);
            this.grbVorbelegungen.Controls.Add(this.cbx_mandant_anzeigen);
            this.grbVorbelegungen.Controls.Add(this.cbxDatum2Anzeigen);
            this.grbVorbelegungen.Controls.Add(this.lblDatum2);
            this.grbVorbelegungen.Controls.Add(this.txtDatum2Bezeichnung);
            this.grbVorbelegungen.Controls.Add(this.cbxDatum1Anzeigen);
            this.grbVorbelegungen.Controls.Add(this.lblDatumBezeichnung);
            this.grbVorbelegungen.Controls.Add(this.txtDatum1Bezeichnung);
            this.grbVorbelegungen.Controls.Add(this.cmb_dokuart);
            this.grbVorbelegungen.Controls.Add(this.lbl_vorgangkz);
            this.grbVorbelegungen.Controls.Add(this.lbl_dokuart);
            this.grbVorbelegungen.Controls.Add(this.cmb_vorgangkz);
            this.grbVorbelegungen.Location = new System.Drawing.Point(26, 109);
            this.grbVorbelegungen.Name = "grbVorbelegungen";
            this.grbVorbelegungen.Size = new System.Drawing.Size(589, 295);
            this.grbVorbelegungen.TabIndex = 49;
            this.grbVorbelegungen.TabStop = false;
            this.grbVorbelegungen.Text = "Vorbelegungen";
            // 
            // cbx_adresse_anzeigen
            // 
            this.cbx_adresse_anzeigen.AutoSize = true;
            this.cbx_adresse_anzeigen.Checked = true;
            this.cbx_adresse_anzeigen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx_adresse_anzeigen.Location = new System.Drawing.Point(223, 240);
            this.cbx_adresse_anzeigen.Name = "cbx_adresse_anzeigen";
            this.cbx_adresse_anzeigen.Size = new System.Drawing.Size(145, 21);
            this.cbx_adresse_anzeigen.TabIndex = 62;
            this.cbx_adresse_anzeigen.Text = "Adresse Anzeigen";
            this.cbx_adresse_anzeigen.UseVisualStyleBackColor = true;
            // 
            // cbx_mieter_anzeigen
            // 
            this.cbx_mieter_anzeigen.AutoSize = true;
            this.cbx_mieter_anzeigen.Checked = true;
            this.cbx_mieter_anzeigen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx_mieter_anzeigen.Location = new System.Drawing.Point(223, 213);
            this.cbx_mieter_anzeigen.Name = "cbx_mieter_anzeigen";
            this.cbx_mieter_anzeigen.Size = new System.Drawing.Size(132, 21);
            this.cbx_mieter_anzeigen.TabIndex = 61;
            this.cbx_mieter_anzeigen.Text = "Mieter Anzeigen";
            this.cbx_mieter_anzeigen.UseVisualStyleBackColor = true;
            // 
            // cbx_ne_anzeigen
            // 
            this.cbx_ne_anzeigen.AutoSize = true;
            this.cbx_ne_anzeigen.Checked = true;
            this.cbx_ne_anzeigen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx_ne_anzeigen.Location = new System.Drawing.Point(223, 186);
            this.cbx_ne_anzeigen.Name = "cbx_ne_anzeigen";
            this.cbx_ne_anzeigen.Size = new System.Drawing.Size(112, 21);
            this.cbx_ne_anzeigen.TabIndex = 60;
            this.cbx_ne_anzeigen.Text = "NE Anzeigen";
            this.cbx_ne_anzeigen.UseVisualStyleBackColor = true;
            // 
            // cbx_haus_anzeigen
            // 
            this.cbx_haus_anzeigen.AutoSize = true;
            this.cbx_haus_anzeigen.Checked = true;
            this.cbx_haus_anzeigen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx_haus_anzeigen.Location = new System.Drawing.Point(223, 159);
            this.cbx_haus_anzeigen.Name = "cbx_haus_anzeigen";
            this.cbx_haus_anzeigen.Size = new System.Drawing.Size(126, 21);
            this.cbx_haus_anzeigen.TabIndex = 59;
            this.cbx_haus_anzeigen.Text = "Haus Anzeigen";
            this.cbx_haus_anzeigen.UseVisualStyleBackColor = true;
            // 
            // cbx_we_anzeigen
            // 
            this.cbx_we_anzeigen.AutoSize = true;
            this.cbx_we_anzeigen.Checked = true;
            this.cbx_we_anzeigen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx_we_anzeigen.Location = new System.Drawing.Point(14, 240);
            this.cbx_we_anzeigen.Name = "cbx_we_anzeigen";
            this.cbx_we_anzeigen.Size = new System.Drawing.Size(115, 21);
            this.cbx_we_anzeigen.TabIndex = 58;
            this.cbx_we_anzeigen.Text = "WE Anzeigen";
            this.cbx_we_anzeigen.UseVisualStyleBackColor = true;
            // 
            // cbx_kreditor_anzeigen
            // 
            this.cbx_kreditor_anzeigen.AutoSize = true;
            this.cbx_kreditor_anzeigen.Checked = true;
            this.cbx_kreditor_anzeigen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx_kreditor_anzeigen.Location = new System.Drawing.Point(14, 213);
            this.cbx_kreditor_anzeigen.Name = "cbx_kreditor_anzeigen";
            this.cbx_kreditor_anzeigen.Size = new System.Drawing.Size(143, 21);
            this.cbx_kreditor_anzeigen.TabIndex = 57;
            this.cbx_kreditor_anzeigen.Text = "Kreditor Anzeigen";
            this.cbx_kreditor_anzeigen.UseVisualStyleBackColor = true;
            // 
            // cbx_unternehmen_anzeigen
            // 
            this.cbx_unternehmen_anzeigen.AutoSize = true;
            this.cbx_unternehmen_anzeigen.Checked = true;
            this.cbx_unternehmen_anzeigen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx_unternehmen_anzeigen.Location = new System.Drawing.Point(14, 186);
            this.cbx_unternehmen_anzeigen.Name = "cbx_unternehmen_anzeigen";
            this.cbx_unternehmen_anzeigen.Size = new System.Drawing.Size(179, 21);
            this.cbx_unternehmen_anzeigen.TabIndex = 56;
            this.cbx_unternehmen_anzeigen.Text = "Unternehmen Anzeigen";
            this.cbx_unternehmen_anzeigen.UseVisualStyleBackColor = true;
            // 
            // cbx_mandant_anzeigen
            // 
            this.cbx_mandant_anzeigen.AutoSize = true;
            this.cbx_mandant_anzeigen.Checked = true;
            this.cbx_mandant_anzeigen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx_mandant_anzeigen.Location = new System.Drawing.Point(14, 159);
            this.cbx_mandant_anzeigen.Name = "cbx_mandant_anzeigen";
            this.cbx_mandant_anzeigen.Size = new System.Drawing.Size(148, 21);
            this.cbx_mandant_anzeigen.TabIndex = 55;
            this.cbx_mandant_anzeigen.Text = "Mandant Anzeigen";
            this.cbx_mandant_anzeigen.UseVisualStyleBackColor = true;
            // 
            // cbxDatum2Anzeigen
            // 
            this.cbxDatum2Anzeigen.AutoSize = true;
            this.cbxDatum2Anzeigen.Location = new System.Drawing.Point(412, 116);
            this.cbxDatum2Anzeigen.Name = "cbxDatum2Anzeigen";
            this.cbxDatum2Anzeigen.Size = new System.Drawing.Size(89, 21);
            this.cbxDatum2Anzeigen.TabIndex = 54;
            this.cbxDatum2Anzeigen.Text = "Anzeigen";
            this.cbxDatum2Anzeigen.UseVisualStyleBackColor = true;
            // 
            // lblDatum2
            // 
            this.lblDatum2.AutoSize = true;
            this.lblDatum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum2.Location = new System.Drawing.Point(10, 118);
            this.lblDatum2.Name = "lblDatum2";
            this.lblDatum2.Size = new System.Drawing.Size(147, 20);
            this.lblDatum2.TabIndex = 53;
            this.lblDatum2.Text = "Datum2 Bezeichn.";
            // 
            // txtDatum2Bezeichnung
            // 
            this.txtDatum2Bezeichnung.Location = new System.Drawing.Point(186, 116);
            this.txtDatum2Bezeichnung.MaxLength = 15;
            this.txtDatum2Bezeichnung.Name = "txtDatum2Bezeichnung";
            this.txtDatum2Bezeichnung.Size = new System.Drawing.Size(185, 22);
            this.txtDatum2Bezeichnung.TabIndex = 52;
            this.txtDatum2Bezeichnung.Text = "Datum2";
            // 
            // cbxDatum1Anzeigen
            // 
            this.cbxDatum1Anzeigen.AutoSize = true;
            this.cbxDatum1Anzeigen.Location = new System.Drawing.Point(412, 88);
            this.cbxDatum1Anzeigen.Name = "cbxDatum1Anzeigen";
            this.cbxDatum1Anzeigen.Size = new System.Drawing.Size(89, 21);
            this.cbxDatum1Anzeigen.TabIndex = 51;
            this.cbxDatum1Anzeigen.Text = "Anzeigen";
            this.cbxDatum1Anzeigen.UseVisualStyleBackColor = true;
            // 
            // lblDatumBezeichnung
            // 
            this.lblDatumBezeichnung.AutoSize = true;
            this.lblDatumBezeichnung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatumBezeichnung.Location = new System.Drawing.Point(10, 90);
            this.lblDatumBezeichnung.Name = "lblDatumBezeichnung";
            this.lblDatumBezeichnung.Size = new System.Drawing.Size(147, 20);
            this.lblDatumBezeichnung.TabIndex = 50;
            this.lblDatumBezeichnung.Text = "Datum1 Bezeichn.";
            // 
            // txtDatum1Bezeichnung
            // 
            this.txtDatum1Bezeichnung.Location = new System.Drawing.Point(186, 88);
            this.txtDatum1Bezeichnung.MaxLength = 15;
            this.txtDatum1Bezeichnung.Name = "txtDatum1Bezeichnung";
            this.txtDatum1Bezeichnung.Size = new System.Drawing.Size(185, 22);
            this.txtDatum1Bezeichnung.TabIndex = 49;
            this.txtDatum1Bezeichnung.Text = "Datum1";
            // 
            // btn_help
            // 
            this.btn_help.Cursor = System.Windows.Forms.Cursors.Help;
            this.btn_help.Image = global::OutlookAddIn_MailForm.Properties.Resources.question_button;
            this.btn_help.Location = new System.Drawing.Point(570, 12);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(45, 30);
            this.btn_help.TabIndex = 50;
            this.btn_help.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_help.UseVisualStyleBackColor = true;
            // 
            // wOWIDOKARTTableAdapter
            // 
            this.wOWIDOKARTTableAdapter.ClearBeforeFill = true;
            // 
            // wOWIVORGANGTableAdapter
            // 
            this.wOWIVORGANGTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet1_WOWI_SEARCH
            // 
            this.dataSet1_WOWI_SEARCH.DataSetName = "DataSet1_WOWI_SEARCH";
            this.dataSet1_WOWI_SEARCH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDokuartBindingSource
            // 
            this.tblDokuartBindingSource.DataMember = "tblDokuart";
            this.tblDokuartBindingSource.DataSource = this.dataSet1_WOWI_SEARCH;
            // 
            // tblDokuartTableAdapter
            // 
            this.tblDokuartTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet1WOWISEARCHBindingSource
            // 
            this.dataSet1WOWISEARCHBindingSource.DataSource = this.dataSet1_WOWI_SEARCH;
            this.dataSet1WOWISEARCHBindingSource.Position = 0;
            // 
            // tblVorgangKZBindingSource
            // 
            this.tblVorgangKZBindingSource.DataMember = "tblVorgangKZ";
            this.tblVorgangKZBindingSource.DataSource = this.dataSet1WOWISEARCHBindingSource;
            // 
            // tblVorgangKZTableAdapter
            // 
            this.tblVorgangKZTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_New_MSGTYPE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 470);
            this.Controls.Add(this.btn_help);
            this.Controls.Add(this.grbVorbelegungen);
            this.Controls.Add(this.lbl_filelocation);
            this.Controls.Add(this.lbl_msgtyp);
            this.Controls.Add(this.txt_mailtype);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_filesearch);
            this.Controls.Add(this.txt_filelocation);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(688, 515);
            this.MinimumSize = new System.Drawing.Size(688, 515);
            this.Name = "Frm_New_MSGTYPE";
            this.Text = "MSG Typ festlegen";
            this.Load += new System.EventHandler(this.Frm_New_MSGTYPE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet_MSGTYPES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wOWIVORGANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saperionDataSetDokuartDokuKZBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saperionDataSet_Dokuart_DokuKZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wOWIDOKARTBindingSource)).EndInit();
            this.grbVorbelegungen.ResumeLayout(false);
            this.grbVorbelegungen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1_WOWI_SEARCH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDokuartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1WOWISEARCHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVorgangKZBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_filesearch;
        private System.Windows.Forms.TextBox txt_filelocation;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Database1DataSet_MSGTYPES database1DataSet_MSGTYPES;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private Database1DataSet_MSGTYPESTableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.TextBox txt_mailtype;
        private System.Windows.Forms.Label lbl_msgtyp;
        private System.Windows.Forms.Label lbl_filelocation;
        private System.Windows.Forms.Label lbl_vorgangkz;
        private System.Windows.Forms.ComboBox cmb_vorgangkz;
        private System.Windows.Forms.Label lbl_dokuart;
        private System.Windows.Forms.ComboBox cmb_dokuart;
        private System.Windows.Forms.GroupBox grbVorbelegungen;
        private System.Windows.Forms.CheckBox cbxDatum2Anzeigen;
        private System.Windows.Forms.Label lblDatum2;
        private System.Windows.Forms.TextBox txtDatum2Bezeichnung;
        private System.Windows.Forms.CheckBox cbxDatum1Anzeigen;
        private System.Windows.Forms.Label lblDatumBezeichnung;
        private System.Windows.Forms.TextBox txtDatum1Bezeichnung;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.BindingSource wOWIDOKARTBindingSource;
        private System.Windows.Forms.BindingSource saperionDataSetDokuartDokuKZBindingSource;
        private saperionDataSet_Dokuart_DokuKZ saperionDataSet_Dokuart_DokuKZ;
        private System.Windows.Forms.BindingSource wOWIVORGANGBindingSource;
        private saperionDataSet_Dokuart_DokuKZTableAdapters.WOWIDOKARTTableAdapter wOWIDOKARTTableAdapter;
        private saperionDataSet_Dokuart_DokuKZTableAdapters.WOWIVORGANGTableAdapter wOWIVORGANGTableAdapter;
        private System.Windows.Forms.CheckBox cbx_mandant_anzeigen;
        private System.Windows.Forms.CheckBox cbx_adresse_anzeigen;
        private System.Windows.Forms.CheckBox cbx_mieter_anzeigen;
        private System.Windows.Forms.CheckBox cbx_ne_anzeigen;
        private System.Windows.Forms.CheckBox cbx_haus_anzeigen;
        private System.Windows.Forms.CheckBox cbx_we_anzeigen;
        private System.Windows.Forms.CheckBox cbx_kreditor_anzeigen;
        private System.Windows.Forms.CheckBox cbx_unternehmen_anzeigen;
        private DataSet1_WOWI_SEARCH dataSet1_WOWI_SEARCH;
        private System.Windows.Forms.BindingSource tblDokuartBindingSource;
        private DataSet1_WOWI_SEARCHTableAdapters.tblDokuartTableAdapter tblDokuartTableAdapter;
        private System.Windows.Forms.BindingSource tblVorgangKZBindingSource;
        private System.Windows.Forms.BindingSource dataSet1WOWISEARCHBindingSource;
        private DataSet1_WOWI_SEARCHTableAdapters.tblVorgangKZTableAdapter tblVorgangKZTableAdapter;

    }
}