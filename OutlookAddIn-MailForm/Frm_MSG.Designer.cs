namespace OutlookAddIn_MailForm
{
    partial class Frm_MSG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MSG));
            this.lbl_Subject = new System.Windows.Forms.Label();
            this.txb_Subject = new System.Windows.Forms.TextBox();
            this.lbl_Objekt = new System.Windows.Forms.Label();
            this.lbl_Kreditor = new System.Windows.Forms.Label();
            this.lbl_Mandant = new System.Windows.Forms.Label();
            this.lbl_meldungstyp = new System.Windows.Forms.Label();
            this.lbl_Wohnung = new System.Windows.Forms.Label();
            this.txt_Mandant = new System.Windows.Forms.TextBox();
            this.txt_kreditor = new System.Windows.Forms.TextBox();
            this.txt_objekt = new System.Windows.Forms.TextBox();
            this.txt_wohnung = new System.Windows.Forms.TextBox();
            this.txt_meldungstyp = new System.Windows.Forms.TextBox();
            this.btn_mandant = new System.Windows.Forms.Button();
            this.btn_kreditor = new System.Windows.Forms.Button();
            this.btn_objekt = new System.Windows.Forms.Button();
            this.btn_wohnung = new System.Windows.Forms.Button();
            this.btn_MSGtyp = new System.Windows.Forms.Button();
            this.btn_create_MSG = new System.Windows.Forms.Button();
            this.btn_haus = new System.Windows.Forms.Button();
            this.txt_haus = new System.Windows.Forms.TextBox();
            this.lbl_haus = new System.Windows.Forms.Label();
            this.lbl_mandant_txt = new System.Windows.Forms.Label();
            this.lbl_kreditor_txt = new System.Windows.Forms.Label();
            this.lbl_objekt_txt = new System.Windows.Forms.Label();
            this.lbl_haus_txt = new System.Windows.Forms.Label();
            this.lbl_we_txt = new System.Windows.Forms.Label();
            this.lbl_me_txt = new System.Windows.Forms.Label();
            this.cmb_dokuart = new System.Windows.Forms.ComboBox();
            this.wOWIDOKARTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saperionDataSetDokuartDokuKZBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saperionDataSet_Dokuart_DokuKZ = new OutlookAddIn_MailForm.saperionDataSet_Dokuart_DokuKZ();
            this.lbl_dokuart = new System.Windows.Forms.Label();
            this.cmb_vorgangkz = new System.Windows.Forms.ComboBox();
            this.wOWIVORGANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_vorgangkz = new System.Windows.Forms.Label();
            this.wOWIDOKARTTableAdapter = new OutlookAddIn_MailForm.saperionDataSet_Dokuart_DokuKZTableAdapters.WOWIDOKARTTableAdapter();
            this.wOWIVORGANGTableAdapter = new OutlookAddIn_MailForm.saperionDataSet_Dokuart_DokuKZTableAdapters.WOWIVORGANGTableAdapter();
            this.lbl_mieter_txt = new System.Windows.Forms.Label();
            this.btn_mieter = new System.Windows.Forms.Button();
            this.txt_Mieter = new System.Windows.Forms.TextBox();
            this.lbl_Mieter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wOWIDOKARTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saperionDataSetDokuartDokuKZBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saperionDataSet_Dokuart_DokuKZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wOWIVORGANGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Subject
            // 
            this.lbl_Subject.AutoSize = true;
            this.lbl_Subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Subject.Location = new System.Drawing.Point(12, 288);
            this.lbl_Subject.Name = "lbl_Subject";
            this.lbl_Subject.Size = new System.Drawing.Size(78, 25);
            this.lbl_Subject.TabIndex = 19;
            this.lbl_Subject.Text = "Subject";
            // 
            // txb_Subject
            // 
            this.txb_Subject.Location = new System.Drawing.Point(96, 292);
            this.txb_Subject.Name = "txb_Subject";
            this.txb_Subject.Size = new System.Drawing.Size(557, 22);
            this.txb_Subject.TabIndex = 18;
            // 
            // lbl_Objekt
            // 
            this.lbl_Objekt.AutoSize = true;
            this.lbl_Objekt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Objekt.Location = new System.Drawing.Point(12, 67);
            this.lbl_Objekt.Name = "lbl_Objekt";
            this.lbl_Objekt.Size = new System.Drawing.Size(45, 25);
            this.lbl_Objekt.TabIndex = 17;
            this.lbl_Objekt.Text = "WE";
            // 
            // lbl_Kreditor
            // 
            this.lbl_Kreditor.AutoSize = true;
            this.lbl_Kreditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Kreditor.Location = new System.Drawing.Point(12, 39);
            this.lbl_Kreditor.Name = "lbl_Kreditor";
            this.lbl_Kreditor.Size = new System.Drawing.Size(80, 25);
            this.lbl_Kreditor.TabIndex = 16;
            this.lbl_Kreditor.Text = "Kreditor";
            // 
            // lbl_Mandant
            // 
            this.lbl_Mandant.AutoSize = true;
            this.lbl_Mandant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mandant.Location = new System.Drawing.Point(12, 9);
            this.lbl_Mandant.Name = "lbl_Mandant";
            this.lbl_Mandant.Size = new System.Drawing.Size(130, 25);
            this.lbl_Mandant.TabIndex = 15;
            this.lbl_Mandant.Text = "Unternehmen";
            // 
            // lbl_meldungstyp
            // 
            this.lbl_meldungstyp.AutoSize = true;
            this.lbl_meldungstyp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_meldungstyp.Location = new System.Drawing.Point(12, 179);
            this.lbl_meldungstyp.Name = "lbl_meldungstyp";
            this.lbl_meldungstyp.Size = new System.Drawing.Size(130, 25);
            this.lbl_meldungstyp.TabIndex = 14;
            this.lbl_meldungstyp.Text = "Meldungstyp:";
            // 
            // lbl_Wohnung
            // 
            this.lbl_Wohnung.AutoSize = true;
            this.lbl_Wohnung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Wohnung.Location = new System.Drawing.Point(12, 120);
            this.lbl_Wohnung.Name = "lbl_Wohnung";
            this.lbl_Wohnung.Size = new System.Drawing.Size(39, 25);
            this.lbl_Wohnung.TabIndex = 20;
            this.lbl_Wohnung.Text = "NE";
            // 
            // txt_Mandant
            // 
            this.txt_Mandant.Location = new System.Drawing.Point(148, 13);
            this.txt_Mandant.Name = "txt_Mandant";
            this.txt_Mandant.Size = new System.Drawing.Size(100, 22);
            this.txt_Mandant.TabIndex = 21;
            this.txt_Mandant.TextChanged += new System.EventHandler(this.txt_Mandant_TextChanged);
            // 
            // txt_kreditor
            // 
            this.txt_kreditor.Location = new System.Drawing.Point(148, 43);
            this.txt_kreditor.Name = "txt_kreditor";
            this.txt_kreditor.Size = new System.Drawing.Size(100, 22);
            this.txt_kreditor.TabIndex = 22;
            this.txt_kreditor.TextChanged += new System.EventHandler(this.txt_kreditor_TextChanged);
            // 
            // txt_objekt
            // 
            this.txt_objekt.Location = new System.Drawing.Point(148, 71);
            this.txt_objekt.Name = "txt_objekt";
            this.txt_objekt.Size = new System.Drawing.Size(100, 22);
            this.txt_objekt.TabIndex = 23;
            this.txt_objekt.TextChanged += new System.EventHandler(this.txt_objekt_TextChanged);
            // 
            // txt_wohnung
            // 
            this.txt_wohnung.Location = new System.Drawing.Point(148, 127);
            this.txt_wohnung.Name = "txt_wohnung";
            this.txt_wohnung.Size = new System.Drawing.Size(100, 22);
            this.txt_wohnung.TabIndex = 24;
            this.txt_wohnung.TextChanged += new System.EventHandler(this.txt_wohnung_TextChanged);
            // 
            // txt_meldungstyp
            // 
            this.txt_meldungstyp.Location = new System.Drawing.Point(148, 183);
            this.txt_meldungstyp.Name = "txt_meldungstyp";
            this.txt_meldungstyp.Size = new System.Drawing.Size(100, 22);
            this.txt_meldungstyp.TabIndex = 25;
            this.txt_meldungstyp.TextChanged += new System.EventHandler(this.txt_meldungstyp_TextChanged);
            // 
            // btn_mandant
            // 
            this.btn_mandant.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mandant.Location = new System.Drawing.Point(254, 12);
            this.btn_mandant.Name = "btn_mandant";
            this.btn_mandant.Size = new System.Drawing.Size(23, 23);
            this.btn_mandant.TabIndex = 26;
            this.btn_mandant.Text = "?";
            this.btn_mandant.UseVisualStyleBackColor = true;
            this.btn_mandant.Click += new System.EventHandler(this.btn_search_click);
            // 
            // btn_kreditor
            // 
            this.btn_kreditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kreditor.Location = new System.Drawing.Point(254, 41);
            this.btn_kreditor.Name = "btn_kreditor";
            this.btn_kreditor.Size = new System.Drawing.Size(23, 23);
            this.btn_kreditor.TabIndex = 27;
            this.btn_kreditor.Text = "?";
            this.btn_kreditor.UseVisualStyleBackColor = true;
            this.btn_kreditor.Click += new System.EventHandler(this.btn_search_click);
            // 
            // btn_objekt
            // 
            this.btn_objekt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_objekt.Location = new System.Drawing.Point(254, 70);
            this.btn_objekt.Name = "btn_objekt";
            this.btn_objekt.Size = new System.Drawing.Size(23, 23);
            this.btn_objekt.TabIndex = 28;
            this.btn_objekt.Text = "?";
            this.btn_objekt.UseVisualStyleBackColor = true;
            this.btn_objekt.Click += new System.EventHandler(this.btn_search_click);
            // 
            // btn_wohnung
            // 
            this.btn_wohnung.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_wohnung.Location = new System.Drawing.Point(254, 124);
            this.btn_wohnung.Name = "btn_wohnung";
            this.btn_wohnung.Size = new System.Drawing.Size(23, 23);
            this.btn_wohnung.TabIndex = 29;
            this.btn_wohnung.Text = "?";
            this.btn_wohnung.UseVisualStyleBackColor = true;
            this.btn_wohnung.Visible = false;
            this.btn_wohnung.Click += new System.EventHandler(this.btn_search_click);
            // 
            // btn_MSGtyp
            // 
            this.btn_MSGtyp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MSGtyp.Location = new System.Drawing.Point(254, 181);
            this.btn_MSGtyp.Name = "btn_MSGtyp";
            this.btn_MSGtyp.Size = new System.Drawing.Size(23, 23);
            this.btn_MSGtyp.TabIndex = 30;
            this.btn_MSGtyp.Text = "?";
            this.btn_MSGtyp.UseVisualStyleBackColor = true;
            this.btn_MSGtyp.Click += new System.EventHandler(this.btn_search_click);
            // 
            // btn_create_MSG
            // 
            this.btn_create_MSG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create_MSG.Image = ((System.Drawing.Image)(resources.GetObject("btn_create_MSG.Image")));
            this.btn_create_MSG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_create_MSG.Location = new System.Drawing.Point(445, 320);
            this.btn_create_MSG.Name = "btn_create_MSG";
            this.btn_create_MSG.Size = new System.Drawing.Size(208, 46);
            this.btn_create_MSG.TabIndex = 31;
            this.btn_create_MSG.Text = "MSG erstellen";
            this.btn_create_MSG.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_create_MSG.UseVisualStyleBackColor = true;
            this.btn_create_MSG.Click += new System.EventHandler(this.btn_create_MSG_Click);
            // 
            // btn_haus
            // 
            this.btn_haus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_haus.Location = new System.Drawing.Point(254, 96);
            this.btn_haus.Name = "btn_haus";
            this.btn_haus.Size = new System.Drawing.Size(23, 23);
            this.btn_haus.TabIndex = 34;
            this.btn_haus.Text = "?";
            this.btn_haus.UseVisualStyleBackColor = true;
            this.btn_haus.Click += new System.EventHandler(this.btn_search_click);
            // 
            // txt_haus
            // 
            this.txt_haus.Location = new System.Drawing.Point(148, 99);
            this.txt_haus.Name = "txt_haus";
            this.txt_haus.Size = new System.Drawing.Size(100, 22);
            this.txt_haus.TabIndex = 33;
            this.txt_haus.TextChanged += new System.EventHandler(this.txt_haus_TextChanged);
            // 
            // lbl_haus
            // 
            this.lbl_haus.AutoSize = true;
            this.lbl_haus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_haus.Location = new System.Drawing.Point(12, 92);
            this.lbl_haus.Name = "lbl_haus";
            this.lbl_haus.Size = new System.Drawing.Size(58, 25);
            this.lbl_haus.TabIndex = 32;
            this.lbl_haus.Text = "Haus";
            // 
            // lbl_mandant_txt
            // 
            this.lbl_mandant_txt.AutoSize = true;
            this.lbl_mandant_txt.Location = new System.Drawing.Point(302, 15);
            this.lbl_mandant_txt.Name = "lbl_mandant_txt";
            this.lbl_mandant_txt.Size = new System.Drawing.Size(46, 17);
            this.lbl_mandant_txt.TabIndex = 35;
            this.lbl_mandant_txt.Text = "label1";
            this.lbl_mandant_txt.Visible = false;
            // 
            // lbl_kreditor_txt
            // 
            this.lbl_kreditor_txt.AutoSize = true;
            this.lbl_kreditor_txt.Location = new System.Drawing.Point(302, 46);
            this.lbl_kreditor_txt.Name = "lbl_kreditor_txt";
            this.lbl_kreditor_txt.Size = new System.Drawing.Size(30, 17);
            this.lbl_kreditor_txt.TabIndex = 36;
            this.lbl_kreditor_txt.Text = "K-0";
            this.lbl_kreditor_txt.Visible = false;
            // 
            // lbl_objekt_txt
            // 
            this.lbl_objekt_txt.AutoSize = true;
            this.lbl_objekt_txt.Location = new System.Drawing.Point(302, 75);
            this.lbl_objekt_txt.Name = "lbl_objekt_txt";
            this.lbl_objekt_txt.Size = new System.Drawing.Size(46, 17);
            this.lbl_objekt_txt.TabIndex = 37;
            this.lbl_objekt_txt.Text = "label1";
            this.lbl_objekt_txt.Visible = false;
            // 
            // lbl_haus_txt
            // 
            this.lbl_haus_txt.AutoSize = true;
            this.lbl_haus_txt.Location = new System.Drawing.Point(302, 102);
            this.lbl_haus_txt.Name = "lbl_haus_txt";
            this.lbl_haus_txt.Size = new System.Drawing.Size(46, 17);
            this.lbl_haus_txt.TabIndex = 38;
            this.lbl_haus_txt.Text = "label1";
            this.lbl_haus_txt.Visible = false;
            // 
            // lbl_we_txt
            // 
            this.lbl_we_txt.AutoSize = true;
            this.lbl_we_txt.Location = new System.Drawing.Point(302, 130);
            this.lbl_we_txt.Name = "lbl_we_txt";
            this.lbl_we_txt.Size = new System.Drawing.Size(46, 17);
            this.lbl_we_txt.TabIndex = 39;
            this.lbl_we_txt.Text = "label1";
            this.lbl_we_txt.Visible = false;
            // 
            // lbl_me_txt
            // 
            this.lbl_me_txt.AutoSize = true;
            this.lbl_me_txt.Location = new System.Drawing.Point(302, 184);
            this.lbl_me_txt.Name = "lbl_me_txt";
            this.lbl_me_txt.Size = new System.Drawing.Size(46, 17);
            this.lbl_me_txt.TabIndex = 40;
            this.lbl_me_txt.Text = "label1";
            this.lbl_me_txt.Visible = false;
            // 
            // cmb_dokuart
            // 
            this.cmb_dokuart.DataSource = this.wOWIDOKARTBindingSource;
            this.cmb_dokuart.DisplayMember = "DOKUART";
            this.cmb_dokuart.FormattingEnabled = true;
            this.cmb_dokuart.Location = new System.Drawing.Point(148, 211);
            this.cmb_dokuart.Name = "cmb_dokuart";
            this.cmb_dokuart.Size = new System.Drawing.Size(352, 24);
            this.cmb_dokuart.TabIndex = 41;
            this.cmb_dokuart.ValueMember = "DOKUART";
            this.cmb_dokuart.DropDown += new System.EventHandler(this.cmb_dokuart_DropDown);
            this.cmb_dokuart.SelectedIndexChanged += new System.EventHandler(this.cmb_dokuart_SelectedIndexChanged);
            // 
            // wOWIDOKARTBindingSource
            // 
            this.wOWIDOKARTBindingSource.DataMember = "WOWIDOKART";
            this.wOWIDOKARTBindingSource.DataSource = this.saperionDataSetDokuartDokuKZBindingSource;
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
            this.lbl_dokuart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dokuart.Location = new System.Drawing.Point(12, 211);
            this.lbl_dokuart.Name = "lbl_dokuart";
            this.lbl_dokuart.Size = new System.Drawing.Size(80, 25);
            this.lbl_dokuart.TabIndex = 42;
            this.lbl_dokuart.Text = "Dokuart";
            // 
            // cmb_vorgangkz
            // 
            this.cmb_vorgangkz.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.wOWIDOKARTBindingSource, "DOKUART", true));
            this.cmb_vorgangkz.DataSource = this.wOWIVORGANGBindingSource;
            this.cmb_vorgangkz.DisplayMember = "VORGANG";
            this.cmb_vorgangkz.FormattingEnabled = true;
            this.cmb_vorgangkz.Location = new System.Drawing.Point(148, 241);
            this.cmb_vorgangkz.Name = "cmb_vorgangkz";
            this.cmb_vorgangkz.Size = new System.Drawing.Size(352, 24);
            this.cmb_vorgangkz.TabIndex = 43;
            this.cmb_vorgangkz.ValueMember = "VORGANG";
            this.cmb_vorgangkz.SelectedIndexChanged += new System.EventHandler(this.cmb_vorgangkz_SelectedIndexChanged);
            // 
            // wOWIVORGANGBindingSource
            // 
            this.wOWIVORGANGBindingSource.DataMember = "WOWIVORGANG";
            this.wOWIVORGANGBindingSource.DataSource = this.saperionDataSetDokuartDokuKZBindingSource;
            // 
            // lbl_vorgangkz
            // 
            this.lbl_vorgangkz.AutoSize = true;
            this.lbl_vorgangkz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vorgangkz.Location = new System.Drawing.Point(12, 240);
            this.lbl_vorgangkz.Name = "lbl_vorgangkz";
            this.lbl_vorgangkz.Size = new System.Drawing.Size(118, 25);
            this.lbl_vorgangkz.TabIndex = 44;
            this.lbl_vorgangkz.Text = "Vorgang KZ";
            // 
            // wOWIDOKARTTableAdapter
            // 
            this.wOWIDOKARTTableAdapter.ClearBeforeFill = true;
            // 
            // wOWIVORGANGTableAdapter
            // 
            this.wOWIVORGANGTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_mieter_txt
            // 
            this.lbl_mieter_txt.AutoSize = true;
            this.lbl_mieter_txt.Location = new System.Drawing.Point(302, 158);
            this.lbl_mieter_txt.Name = "lbl_mieter_txt";
            this.lbl_mieter_txt.Size = new System.Drawing.Size(32, 17);
            this.lbl_mieter_txt.TabIndex = 48;
            this.lbl_mieter_txt.Text = "M-0";
            this.lbl_mieter_txt.Visible = false;
            // 
            // btn_mieter
            // 
            this.btn_mieter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mieter.Location = new System.Drawing.Point(254, 152);
            this.btn_mieter.Name = "btn_mieter";
            this.btn_mieter.Size = new System.Drawing.Size(23, 23);
            this.btn_mieter.TabIndex = 47;
            this.btn_mieter.Text = "?";
            this.btn_mieter.UseVisualStyleBackColor = true;
            this.btn_mieter.Click += new System.EventHandler(this.btn_search_click);
            // 
            // txt_Mieter
            // 
            this.txt_Mieter.Location = new System.Drawing.Point(148, 155);
            this.txt_Mieter.Name = "txt_Mieter";
            this.txt_Mieter.Size = new System.Drawing.Size(100, 22);
            this.txt_Mieter.TabIndex = 46;
            // 
            // lbl_Mieter
            // 
            this.lbl_Mieter.AutoSize = true;
            this.lbl_Mieter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mieter.Location = new System.Drawing.Point(12, 151);
            this.lbl_Mieter.Name = "lbl_Mieter";
            this.lbl_Mieter.Size = new System.Drawing.Size(121, 25);
            this.lbl_Mieter.TabIndex = 45;
            this.lbl_Mieter.Text = "Mieter (Adr.)";
            // 
            // Frm_MSG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 377);
            this.Controls.Add(this.lbl_mieter_txt);
            this.Controls.Add(this.btn_mieter);
            this.Controls.Add(this.txt_Mieter);
            this.Controls.Add(this.lbl_Mieter);
            this.Controls.Add(this.lbl_vorgangkz);
            this.Controls.Add(this.cmb_vorgangkz);
            this.Controls.Add(this.lbl_dokuart);
            this.Controls.Add(this.cmb_dokuart);
            this.Controls.Add(this.lbl_me_txt);
            this.Controls.Add(this.lbl_we_txt);
            this.Controls.Add(this.lbl_haus_txt);
            this.Controls.Add(this.lbl_objekt_txt);
            this.Controls.Add(this.lbl_kreditor_txt);
            this.Controls.Add(this.lbl_mandant_txt);
            this.Controls.Add(this.btn_haus);
            this.Controls.Add(this.txt_haus);
            this.Controls.Add(this.lbl_haus);
            this.Controls.Add(this.btn_create_MSG);
            this.Controls.Add(this.btn_MSGtyp);
            this.Controls.Add(this.btn_wohnung);
            this.Controls.Add(this.btn_objekt);
            this.Controls.Add(this.btn_kreditor);
            this.Controls.Add(this.btn_mandant);
            this.Controls.Add(this.txt_meldungstyp);
            this.Controls.Add(this.txt_wohnung);
            this.Controls.Add(this.txt_objekt);
            this.Controls.Add(this.txt_kreditor);
            this.Controls.Add(this.txt_Mandant);
            this.Controls.Add(this.lbl_Wohnung);
            this.Controls.Add(this.lbl_Subject);
            this.Controls.Add(this.txb_Subject);
            this.Controls.Add(this.lbl_Objekt);
            this.Controls.Add(this.lbl_Kreditor);
            this.Controls.Add(this.lbl_Mandant);
            this.Controls.Add(this.lbl_meldungstyp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(683, 422);
            this.MinimumSize = new System.Drawing.Size(683, 422);
            this.Name = "Frm_MSG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meldung";
            this.Load += new System.EventHandler(this.Frm_MSG_Load);
            this.Click += new System.EventHandler(this.btn_search_click);
            ((System.ComponentModel.ISupportInitialize)(this.wOWIDOKARTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saperionDataSetDokuartDokuKZBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saperionDataSet_Dokuart_DokuKZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wOWIVORGANGBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Subject;
        private System.Windows.Forms.Label lbl_Objekt;
        private System.Windows.Forms.Label lbl_Kreditor;
        private System.Windows.Forms.Label lbl_Mandant;
        private System.Windows.Forms.Label lbl_meldungstyp;
        private System.Windows.Forms.Label lbl_Wohnung;
        private System.Windows.Forms.Button btn_mandant;
        private System.Windows.Forms.Button btn_kreditor;
        private System.Windows.Forms.Button btn_objekt;
        private System.Windows.Forms.Button btn_wohnung;
        private System.Windows.Forms.Button btn_MSGtyp;
        private System.Windows.Forms.Button btn_create_MSG;
        private System.Windows.Forms.Button btn_haus;
        private System.Windows.Forms.Label lbl_haus;
        public System.Windows.Forms.TextBox txb_Subject;
        public System.Windows.Forms.TextBox txt_objekt;
        public System.Windows.Forms.TextBox txt_wohnung;
        public System.Windows.Forms.TextBox txt_meldungstyp;
        private System.Windows.Forms.TextBox txt_Mandant;
        private System.Windows.Forms.TextBox txt_kreditor;
        public System.Windows.Forms.Label lbl_kreditor_txt;
        public System.Windows.Forms.Label lbl_objekt_txt;
        public System.Windows.Forms.Label lbl_haus_txt;
        public System.Windows.Forms.Label lbl_we_txt;
        public System.Windows.Forms.Label lbl_me_txt;
        public System.Windows.Forms.Label lbl_mandant_txt;
        private System.Windows.Forms.ComboBox cmb_dokuart;
        private System.Windows.Forms.Label lbl_dokuart;
        private System.Windows.Forms.ComboBox cmb_vorgangkz;
        private System.Windows.Forms.Label lbl_vorgangkz;
        private System.Windows.Forms.BindingSource saperionDataSetDokuartDokuKZBindingSource;
        private saperionDataSet_Dokuart_DokuKZ saperionDataSet_Dokuart_DokuKZ;
        private System.Windows.Forms.BindingSource wOWIDOKARTBindingSource;
        private saperionDataSet_Dokuart_DokuKZTableAdapters.WOWIDOKARTTableAdapter wOWIDOKARTTableAdapter;
        private System.Windows.Forms.BindingSource wOWIVORGANGBindingSource;
        private saperionDataSet_Dokuart_DokuKZTableAdapters.WOWIVORGANGTableAdapter wOWIVORGANGTableAdapter;
        private System.Windows.Forms.TextBox txt_haus;
        public System.Windows.Forms.Label lbl_mieter_txt;
        private System.Windows.Forms.Button btn_mieter;
        public System.Windows.Forms.TextBox txt_Mieter;
        private System.Windows.Forms.Label lbl_Mieter;
    }
}