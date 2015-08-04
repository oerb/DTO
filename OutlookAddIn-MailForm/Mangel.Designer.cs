namespace OutlookAddIn_MailForm
{
    partial class Mangel
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
            this.rtb_Meldungstext = new System.Windows.Forms.RichTextBox();
            this.dtp_erledigtbis = new System.Windows.Forms.DateTimePicker();
            this.lbl_erledigtbis = new System.Windows.Forms.Label();
            this.cmb_Meldungstyp = new System.Windows.Forms.ComboBox();
            this.lbl_meldungstyp = new System.Windows.Forms.Label();
            this.btn_send = new System.Windows.Forms.Button();
            this.cmb_Mandant = new System.Windows.Forms.ComboBox();
            this.mandantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wOWI_Mandant = new OutlookAddIn_MailForm.WOWI_Mandant();
            this.lbl_Mandant = new System.Windows.Forms.Label();
            this.lbl_Kreditor = new System.Windows.Forms.Label();
            this.cmb_Kreditor = new System.Windows.Forms.ComboBox();
            this.lbl_Objekt = new System.Windows.Forms.Label();
            this.cmb_Objekt = new System.Windows.Forms.ComboBox();
            this.wirtschaftseinheitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txb_Subject = new System.Windows.Forms.TextBox();
            this.lbl_Subject = new System.Windows.Forms.Label();
            this.mandantTableAdapter = new OutlookAddIn_MailForm.WOWI_MandantTableAdapters.MandantTableAdapter();
            this.woWi_WirtschEinhDataSet = new OutlookAddIn_MailForm.WoWi_WirtschEinhDataSet();
            this.woWiWirtschEinhDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wirtschaftseinheitBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mandantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wOWI_Mandant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wirtschaftseinheitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.woWi_WirtschEinhDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.woWiWirtschEinhDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wirtschaftseinheitBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // rtb_Meldungstext
            // 
            this.rtb_Meldungstext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_Meldungstext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_Meldungstext.Location = new System.Drawing.Point(12, 308);
            this.rtb_Meldungstext.Name = "rtb_Meldungstext";
            this.rtb_Meldungstext.Size = new System.Drawing.Size(763, 258);
            this.rtb_Meldungstext.TabIndex = 0;
            this.rtb_Meldungstext.Text = "Meldungstext";
            this.rtb_Meldungstext.TextChanged += new System.EventHandler(this.rtb_Meldungstext_TextChanged);
            // 
            // dtp_erledigtbis
            // 
            this.dtp_erledigtbis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_erledigtbis.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_erledigtbis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_erledigtbis.Location = new System.Drawing.Point(547, 214);
            this.dtp_erledigtbis.Name = "dtp_erledigtbis";
            this.dtp_erledigtbis.Size = new System.Drawing.Size(228, 30);
            this.dtp_erledigtbis.TabIndex = 1;
            // 
            // lbl_erledigtbis
            // 
            this.lbl_erledigtbis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_erledigtbis.AutoSize = true;
            this.lbl_erledigtbis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_erledigtbis.Location = new System.Drawing.Point(374, 214);
            this.lbl_erledigtbis.Name = "lbl_erledigtbis";
            this.lbl_erledigtbis.Size = new System.Drawing.Size(159, 25);
            this.lbl_erledigtbis.TabIndex = 2;
            this.lbl_erledigtbis.Text = "zu erledigen bis: ";
            // 
            // cmb_Meldungstyp
            // 
            this.cmb_Meldungstyp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Meldungstyp.DisplayMember = "Mängelrüge §4";
            this.cmb_Meldungstyp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Meldungstyp.FormattingEnabled = true;
            this.cmb_Meldungstyp.Location = new System.Drawing.Point(377, 166);
            this.cmb_Meldungstyp.Name = "cmb_Meldungstyp";
            this.cmb_Meldungstyp.Size = new System.Drawing.Size(393, 33);
            this.cmb_Meldungstyp.TabIndex = 3;
            this.cmb_Meldungstyp.SelectedIndexChanged += new System.EventHandler(this.cmb_Meldungstyp_SelectedIndexChanged);
            // 
            // lbl_meldungstyp
            // 
            this.lbl_meldungstyp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_meldungstyp.AutoSize = true;
            this.lbl_meldungstyp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_meldungstyp.Location = new System.Drawing.Point(234, 169);
            this.lbl_meldungstyp.Name = "lbl_meldungstyp";
            this.lbl_meldungstyp.Size = new System.Drawing.Size(130, 25);
            this.lbl_meldungstyp.TabIndex = 4;
            this.lbl_meldungstyp.Text = "Meldungstyp:";
            // 
            // btn_send
            // 
            this.btn_send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_send.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send.Location = new System.Drawing.Point(635, 12);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(140, 46);
            this.btn_send.TabIndex = 5;
            this.btn_send.Text = "Senden";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // cmb_Mandant
            // 
            this.cmb_Mandant.DataSource = this.mandantBindingSource;
            this.cmb_Mandant.DisplayMember = "Unternehmen";
            this.cmb_Mandant.FormattingEnabled = true;
            this.cmb_Mandant.Location = new System.Drawing.Point(377, 73);
            this.cmb_Mandant.Name = "cmb_Mandant";
            this.cmb_Mandant.Size = new System.Drawing.Size(395, 24);
            this.cmb_Mandant.TabIndex = 6;
            // 
            // mandantBindingSource
            // 
            this.mandantBindingSource.DataMember = "Mandant";
            this.mandantBindingSource.DataSource = this.wOWI_Mandant;
            // 
            // wOWI_Mandant
            // 
            this.wOWI_Mandant.DataSetName = "WOWI_Mandant";
            this.wOWI_Mandant.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_Mandant
            // 
            this.lbl_Mandant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Mandant.AutoSize = true;
            this.lbl_Mandant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mandant.Location = new System.Drawing.Point(234, 73);
            this.lbl_Mandant.Name = "lbl_Mandant";
            this.lbl_Mandant.Size = new System.Drawing.Size(89, 25);
            this.lbl_Mandant.TabIndex = 7;
            this.lbl_Mandant.Text = "Mandant";
            this.lbl_Mandant.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_Kreditor
            // 
            this.lbl_Kreditor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Kreditor.AutoSize = true;
            this.lbl_Kreditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Kreditor.Location = new System.Drawing.Point(234, 103);
            this.lbl_Kreditor.Name = "lbl_Kreditor";
            this.lbl_Kreditor.Size = new System.Drawing.Size(80, 25);
            this.lbl_Kreditor.TabIndex = 9;
            this.lbl_Kreditor.Text = "Kreditor";
            this.lbl_Kreditor.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cmb_Kreditor
            // 
            this.cmb_Kreditor.FormattingEnabled = true;
            this.cmb_Kreditor.Location = new System.Drawing.Point(377, 103);
            this.cmb_Kreditor.Name = "cmb_Kreditor";
            this.cmb_Kreditor.Size = new System.Drawing.Size(395, 24);
            this.cmb_Kreditor.TabIndex = 8;
            // 
            // lbl_Objekt
            // 
            this.lbl_Objekt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Objekt.AutoSize = true;
            this.lbl_Objekt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Objekt.Location = new System.Drawing.Point(234, 135);
            this.lbl_Objekt.Name = "lbl_Objekt";
            this.lbl_Objekt.Size = new System.Drawing.Size(69, 25);
            this.lbl_Objekt.TabIndex = 11;
            this.lbl_Objekt.Text = "Objekt";
            // 
            // cmb_Objekt
            // 
            this.cmb_Objekt.DisplayMember = "WE";
            this.cmb_Objekt.FormattingEnabled = true;
            this.cmb_Objekt.Location = new System.Drawing.Point(377, 136);
            this.cmb_Objekt.Name = "cmb_Objekt";
            this.cmb_Objekt.Size = new System.Drawing.Size(395, 24);
            this.cmb_Objekt.TabIndex = 10;
            this.cmb_Objekt.ValueMember = "WE";
            this.cmb_Objekt.SelectedIndexChanged += new System.EventHandler(this.cmb_Objekt_SelectedIndexChanged);
            // 
            // txb_Subject
            // 
            this.txb_Subject.Location = new System.Drawing.Point(190, 264);
            this.txb_Subject.Name = "txb_Subject";
            this.txb_Subject.Size = new System.Drawing.Size(580, 22);
            this.txb_Subject.TabIndex = 12;
            // 
            // lbl_Subject
            // 
            this.lbl_Subject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Subject.AutoSize = true;
            this.lbl_Subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Subject.Location = new System.Drawing.Point(21, 264);
            this.lbl_Subject.Name = "lbl_Subject";
            this.lbl_Subject.Size = new System.Drawing.Size(78, 25);
            this.lbl_Subject.TabIndex = 13;
            this.lbl_Subject.Text = "Subject";
            this.lbl_Subject.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // mandantTableAdapter
            // 
            this.mandantTableAdapter.ClearBeforeFill = true;
            // 
            // woWi_WirtschEinhDataSet
            // 
            this.woWi_WirtschEinhDataSet.DataSetName = "WoWi_WirtschEinhDataSet";
            this.woWi_WirtschEinhDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // woWiWirtschEinhDataSetBindingSource
            // 
            this.woWiWirtschEinhDataSetBindingSource.DataSource = this.woWi_WirtschEinhDataSet;
            this.woWiWirtschEinhDataSetBindingSource.Position = 0;
            // 
            // wirtschaftseinheitBindingSource1
            // 
            this.wirtschaftseinheitBindingSource1.DataMember = "Wirtschaftseinheit";
            this.wirtschaftseinheitBindingSource1.DataSource = this.woWiWirtschEinhDataSetBindingSource;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 14;
            this.button1.Text = "test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Mangel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 578);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_Subject);
            this.Controls.Add(this.txb_Subject);
            this.Controls.Add(this.lbl_Objekt);
            this.Controls.Add(this.cmb_Objekt);
            this.Controls.Add(this.lbl_Kreditor);
            this.Controls.Add(this.cmb_Kreditor);
            this.Controls.Add(this.lbl_Mandant);
            this.Controls.Add(this.cmb_Mandant);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.lbl_meldungstyp);
            this.Controls.Add(this.cmb_Meldungstyp);
            this.Controls.Add(this.lbl_erledigtbis);
            this.Controls.Add(this.dtp_erledigtbis);
            this.Controls.Add(this.rtb_Meldungstext);
            this.Name = "Mangel";
            this.Text = "Mängelrüge";
            this.Load += new System.EventHandler(this.Mangel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mandantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wOWI_Mandant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wirtschaftseinheitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.woWi_WirtschEinhDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.woWiWirtschEinhDataSetBindingSource)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.wirtschaftseinheitBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_Meldungstext;
        private System.Windows.Forms.DateTimePicker dtp_erledigtbis;
        private System.Windows.Forms.Label lbl_erledigtbis;
        private System.Windows.Forms.ComboBox cmb_Meldungstyp;
        private System.Windows.Forms.Label lbl_meldungstyp;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.ComboBox cmb_Mandant;
        private System.Windows.Forms.Label lbl_Mandant;
        private System.Windows.Forms.Label lbl_Kreditor;
        private System.Windows.Forms.ComboBox cmb_Kreditor;
        private System.Windows.Forms.Label lbl_Objekt;
        private System.Windows.Forms.ComboBox cmb_Objekt;
        private System.Windows.Forms.TextBox txb_Subject;
        private System.Windows.Forms.Label lbl_Subject;
        private WOWI_Mandant wOWI_Mandant;
        private System.Windows.Forms.BindingSource mandantBindingSource;
        private WOWI_MandantTableAdapters.MandantTableAdapter mandantTableAdapter;
        private System.Windows.Forms.BindingSource wirtschaftseinheitBindingSource;
        private WoWi_WirtschEinhDataSet woWi_WirtschEinhDataSet;
        private System.Windows.Forms.BindingSource woWiWirtschEinhDataSetBindingSource;
        private System.Windows.Forms.BindingSource wirtschaftseinheitBindingSource1;
        private System.Windows.Forms.Button button1;
        //private WoWi_WirtschEinhDataSetTableAdapters.WirtschaftseinheitTableAdapter wirtschaftseinheitTableAdapter;
    }
}