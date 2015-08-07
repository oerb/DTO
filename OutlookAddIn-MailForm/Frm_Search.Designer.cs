namespace OutlookAddIn_MailForm
{
    partial class Frm_Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Search));
            this.dgv_TableSelect = new System.Windows.Forms.DataGridView();
            this.btn_select = new System.Windows.Forms.Button();
            this.dataSet1_WoWi_Objekte = new OutlookAddIn_MailForm.DataSet1_WoWi_Objekte();
            this.wirtschaftseinheitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wirtschaftseinheitTableAdapter = new OutlookAddIn_MailForm.DataSet1_WoWi_ObjekteTableAdapters.WirtschaftseinheitTableAdapter();
            this.dataSet1_WoWi_Mandant = new OutlookAddIn_MailForm.DataSet1_WoWi_Mandant();
            this.mandantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mandantTableAdapter = new OutlookAddIn_MailForm.DataSet1_WoWi_MandantTableAdapters.MandantTableAdapter();
            this.dataSet1_WoWi_Haus = new OutlookAddIn_MailForm.DataSet1_WoWi_Haus();
            this.hausBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hausTableAdapter = new OutlookAddIn_MailForm.DataSet1_WoWi_HausTableAdapters.HausTableAdapter();
            this.database1DataSet_MSGtyp = new OutlookAddIn_MailForm.Database1DataSet_MSGtyp();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new OutlookAddIn_MailForm.Database1DataSet_MSGtypTableAdapters.TableTableAdapter();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.txt_filer1 = new System.Windows.Forms.TextBox();
            this.txt_filter2 = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.dataSet1_WoWi_Kreditor = new OutlookAddIn_MailForm.DataSet1_WoWi_Kreditor();
            this.kreditorKontoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kreditor_KontoTableAdapter = new OutlookAddIn_MailForm.DataSet1_WoWi_KreditorTableAdapters.Kreditor_KontoTableAdapter();
            this.dataSet1_WoWi_Kreditor1 = new OutlookAddIn_MailForm.DataSet1_WoWi_Kreditor();
            this.dataSet1xyMieter = new OutlookAddIn_MailForm.DataSet1xyMieter();
            this.xyMieterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.xyMieterTableAdapter = new OutlookAddIn_MailForm.DataSet1xyMieterTableAdapters.xyMieterTableAdapter();
            this.dataSet1Wohnung = new OutlookAddIn_MailForm.DataSet1Wohnung();
            this.wohnungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wohnungTableAdapter = new OutlookAddIn_MailForm.DataSet1WohnungTableAdapters.WohnungTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TableSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1_WoWi_Objekte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wirtschaftseinheitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1_WoWi_Mandant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mandantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1_WoWi_Haus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hausBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet_MSGtyp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1_WoWi_Kreditor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kreditorKontoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1_WoWi_Kreditor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1xyMieter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xyMieterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1Wohnung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wohnungBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_TableSelect
            // 
            this.dgv_TableSelect.AllowUserToAddRows = false;
            this.dgv_TableSelect.AllowUserToDeleteRows = false;
            this.dgv_TableSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_TableSelect.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dgv_TableSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TableSelect.Location = new System.Drawing.Point(0, 0);
            this.dgv_TableSelect.MultiSelect = false;
            this.dgv_TableSelect.Name = "dgv_TableSelect";
            this.dgv_TableSelect.ReadOnly = true;
            this.dgv_TableSelect.RowTemplate.Height = 24;
            this.dgv_TableSelect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_TableSelect.Size = new System.Drawing.Size(471, 295);
            this.dgv_TableSelect.TabIndex = 0;
            this.dgv_TableSelect.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TableSelect_CellClick);
            this.dgv_TableSelect.SelectionChanged += new System.EventHandler(this.dgv_TableSelect_SelectionChanged);
            this.dgv_TableSelect.Click += new System.EventHandler(this.dgv_TableSelect_Click);
            this.dgv_TableSelect.DoubleClick += new System.EventHandler(this.dgv_TableSelect_DoubleClick);
            // 
            // btn_select
            // 
            this.btn_select.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_select.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_select.Location = new System.Drawing.Point(477, 12);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(224, 44);
            this.btn_select.TabIndex = 1;
            this.btn_select.Text = "übernehmen";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // dataSet1_WoWi_Objekte
            // 
            this.dataSet1_WoWi_Objekte.DataSetName = "DataSet1_WoWi_Objekte";
            this.dataSet1_WoWi_Objekte.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wirtschaftseinheitBindingSource
            // 
            this.wirtschaftseinheitBindingSource.DataMember = "Wirtschaftseinheit";
            this.wirtschaftseinheitBindingSource.DataSource = this.dataSet1_WoWi_Objekte;
            // 
            // wirtschaftseinheitTableAdapter
            // 
            this.wirtschaftseinheitTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet1_WoWi_Mandant
            // 
            this.dataSet1_WoWi_Mandant.DataSetName = "DataSet1_WoWi_Mandant";
            this.dataSet1_WoWi_Mandant.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mandantBindingSource
            // 
            this.mandantBindingSource.DataMember = "Mandant";
            this.mandantBindingSource.DataSource = this.dataSet1_WoWi_Mandant;
            this.mandantBindingSource.CurrentItemChanged += new System.EventHandler(this.tableBindingSource_CurrentItemChanged);
            // 
            // mandantTableAdapter
            // 
            this.mandantTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet1_WoWi_Haus
            // 
            this.dataSet1_WoWi_Haus.DataSetName = "DataSet1_WoWi_Haus";
            this.dataSet1_WoWi_Haus.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hausBindingSource
            // 
            this.hausBindingSource.DataMember = "Haus";
            this.hausBindingSource.DataSource = this.dataSet1_WoWi_Haus;
            // 
            // hausTableAdapter
            // 
            this.hausTableAdapter.ClearBeforeFill = true;
            // 
            // database1DataSet_MSGtyp
            // 
            this.database1DataSet_MSGtyp.DataSetName = "Database1DataSet_MSGtyp";
            this.database1DataSet_MSGtyp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.database1DataSet_MSGtyp;
            this.tableBindingSource.CurrentItemChanged += new System.EventHandler(this.tableBindingSource_CurrentItemChanged);
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_1
            // 
            this.lbl_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_1.AutoSize = true;
            this.lbl_1.Location = new System.Drawing.Point(477, 73);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(46, 17);
            this.lbl_1.TabIndex = 2;
            this.lbl_1.Text = "label1";
            this.lbl_1.Visible = false;
            // 
            // lbl_2
            // 
            this.lbl_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_2.AutoSize = true;
            this.lbl_2.Location = new System.Drawing.Point(477, 118);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(46, 17);
            this.lbl_2.TabIndex = 3;
            this.lbl_2.Text = "label1";
            this.lbl_2.Visible = false;
            // 
            // txt_filer1
            // 
            this.txt_filer1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_filer1.Location = new System.Drawing.Point(480, 93);
            this.txt_filer1.Name = "txt_filer1";
            this.txt_filer1.Size = new System.Drawing.Size(221, 22);
            this.txt_filer1.TabIndex = 4;
            this.txt_filer1.Visible = false;
            this.txt_filer1.TextChanged += new System.EventHandler(this.txt_filer1_TextChanged);
            // 
            // txt_filter2
            // 
            this.txt_filter2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_filter2.Location = new System.Drawing.Point(480, 138);
            this.txt_filter2.Name = "txt_filter2";
            this.txt_filter2.Size = new System.Drawing.Size(221, 22);
            this.txt_filter2.TabIndex = 5;
            this.txt_filter2.Visible = false;
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.Location = new System.Drawing.Point(665, 166);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(36, 37);
            this.btn_search.TabIndex = 6;
            this.btn_search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Visible = false;
            this.btn_search.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataSet1_WoWi_Kreditor
            // 
            this.dataSet1_WoWi_Kreditor.DataSetName = "DataSet1_WoWi_Kreditor";
            this.dataSet1_WoWi_Kreditor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kreditorKontoBindingSource
            // 
            this.kreditorKontoBindingSource.DataMember = "Kreditor-Konto";
            this.kreditorKontoBindingSource.DataSource = this.dataSet1_WoWi_Kreditor;
            // 
            // kreditor_KontoTableAdapter
            // 
            this.kreditor_KontoTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet1_WoWi_Kreditor1
            // 
            this.dataSet1_WoWi_Kreditor1.DataSetName = "DataSet1_WoWi_Kreditor";
            this.dataSet1_WoWi_Kreditor1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1xyMieter
            // 
            this.dataSet1xyMieter.DataSetName = "DataSet1xyMieter";
            this.dataSet1xyMieter.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // xyMieterBindingSource
            // 
            this.xyMieterBindingSource.DataMember = "xyMieter";
            this.xyMieterBindingSource.DataSource = this.dataSet1xyMieter;
            // 
            // xyMieterTableAdapter
            // 
            this.xyMieterTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet1Wohnung
            // 
            this.dataSet1Wohnung.DataSetName = "DataSet1Wohnung";
            this.dataSet1Wohnung.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wohnungBindingSource
            // 
            this.wohnungBindingSource.DataMember = "Wohnung";
            this.wohnungBindingSource.DataSource = this.dataSet1Wohnung;
            // 
            // wohnungTableAdapter
            // 
            this.wohnungTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 295);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_filter2);
            this.Controls.Add(this.txt_filer1);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.dgv_TableSelect);
            this.MinimumSize = new System.Drawing.Size(731, 340);
            this.Name = "Frm_Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Search";
            this.Load += new System.EventHandler(this.Frm_Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TableSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1_WoWi_Objekte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wirtschaftseinheitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1_WoWi_Mandant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mandantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1_WoWi_Haus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hausBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet_MSGtyp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1_WoWi_Kreditor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kreditorKontoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1_WoWi_Kreditor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1xyMieter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xyMieterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1Wohnung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wohnungBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_TableSelect;
        private System.Windows.Forms.Button btn_select;
        private DataSet1_WoWi_Objekte dataSet1_WoWi_Objekte;
        private System.Windows.Forms.BindingSource wirtschaftseinheitBindingSource;
        private DataSet1_WoWi_ObjekteTableAdapters.WirtschaftseinheitTableAdapter wirtschaftseinheitTableAdapter;
        private DataSet1_WoWi_Mandant dataSet1_WoWi_Mandant;
        private System.Windows.Forms.BindingSource mandantBindingSource;
        private DataSet1_WoWi_MandantTableAdapters.MandantTableAdapter mandantTableAdapter;
        private DataSet1_WoWi_Kreditor dataSet1_WoWi_Kreditor;
        private System.Windows.Forms.BindingSource kreditorKontoBindingSource;
        private DataSet1_WoWi_KreditorTableAdapters.Kreditor_KontoTableAdapter kreditor_KontoTableAdapter;
        private DataSet1_WoWi_Haus dataSet1_WoWi_Haus;
        private System.Windows.Forms.BindingSource hausBindingSource;
        private DataSet1_WoWi_HausTableAdapters.HausTableAdapter hausTableAdapter;
        private Database1DataSet_MSGtyp database1DataSet_MSGtyp;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private Database1DataSet_MSGtypTableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.TextBox txt_filer1;
        private System.Windows.Forms.TextBox txt_filter2;
        private System.Windows.Forms.Button btn_search;
        private DataSet1_WoWi_Kreditor dataSet1_WoWi_Kreditor1;
        private DataSet1Wohnung dataSet1Wohnung;
        private System.Windows.Forms.BindingSource wohnungBindingSource;
        private DataSet1WohnungTableAdapters.WohnungTableAdapter wohnungTableAdapter;
        private DataSet1xyMieter dataSet1xyMieter;
        private System.Windows.Forms.BindingSource xyMieterBindingSource;
        private DataSet1xyMieterTableAdapters.xyMieterTableAdapter xyMieterTableAdapter;
        //private DataSet1_WoWi_KreditorTableAdapters.Kreditor_AdresseTableAdapter kreditor_AdresseTableAdapter;
    }
}