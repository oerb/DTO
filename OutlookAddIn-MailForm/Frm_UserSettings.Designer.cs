﻿namespace OutlookAddIn_MailForm
{
    partial class Frm_UserSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_UserSettings));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chb_ask_before_archive = new System.Windows.Forms.CheckBox();
            this.chb_auto_archiving = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbl_vorgangkz = new System.Windows.Forms.Label();
            this.cmb_vorgangkz = new System.Windows.Forms.ComboBox();
            this.wOWIVORGANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saperionDataSetDokuartDokuKZBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saperionDataSet_Dokuart_DokuKZ = new OutlookAddIn_MailForm.saperionDataSet_Dokuart_DokuKZ();
            this.lbl_dokuart = new System.Windows.Forms.Label();
            this.cmb_dokuart = new System.Windows.Forms.ComboBox();
            this.wOWIDOKARTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.wOWIDOKARTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wOWIVORGANGTableAdapter = new OutlookAddIn_MailForm.saperionDataSet_Dokuart_DokuKZTableAdapters.WOWIVORGANGTableAdapter();
            this.wOWIDOKARTTableAdapter = new OutlookAddIn_MailForm.saperionDataSet_Dokuart_DokuKZTableAdapters.WOWIDOKARTTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wOWIVORGANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saperionDataSetDokuartDokuKZBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saperionDataSet_Dokuart_DokuKZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wOWIDOKARTBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wOWIDOKARTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(632, 354);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chb_ask_before_archive);
            this.tabPage1.Controls.Add(this.chb_auto_archiving);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(624, 325);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Allgemein";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chb_ask_before_archive
            // 
            this.chb_ask_before_archive.AutoSize = true;
            this.chb_ask_before_archive.Checked = global::OutlookAddIn_MailForm.Properties.Settings.Default.ask_before_archiving;
            this.chb_ask_before_archive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_ask_before_archive.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::OutlookAddIn_MailForm.Properties.Settings.Default, "ask_before_archiving", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chb_ask_before_archive.Location = new System.Drawing.Point(30, 44);
            this.chb_ask_before_archive.Name = "chb_ask_before_archive";
            this.chb_ask_before_archive.Size = new System.Drawing.Size(205, 21);
            this.chb_ask_before_archive.TabIndex = 2;
            this.chb_ask_before_archive.Text = "vor dem Archivieren Fragen";
            this.chb_ask_before_archive.UseVisualStyleBackColor = true;
            // 
            // chb_auto_archiving
            // 
            this.chb_auto_archiving.AutoSize = true;
            this.chb_auto_archiving.Checked = global::OutlookAddIn_MailForm.Properties.Settings.Default.autoarchiving;
            this.chb_auto_archiving.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_auto_archiving.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::OutlookAddIn_MailForm.Properties.Settings.Default, "autoarchiving", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chb_auto_archiving.Location = new System.Drawing.Point(30, 17);
            this.chb_auto_archiving.Name = "chb_auto_archiving";
            this.chb_auto_archiving.Size = new System.Drawing.Size(217, 21);
            this.chb_auto_archiving.TabIndex = 1;
            this.chb_auto_archiving.Text = "MSG Automatisch Archivieren";
            this.chb_auto_archiving.UseVisualStyleBackColor = true;
            this.chb_auto_archiving.CheckedChanged += new System.EventHandler(this.chb_auto_archiving_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbl_vorgangkz);
            this.tabPage2.Controls.Add(this.cmb_vorgangkz);
            this.tabPage2.Controls.Add(this.lbl_dokuart);
            this.tabPage2.Controls.Add(this.cmb_dokuart);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(624, 325);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MSG Form";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbl_vorgangkz
            // 
            this.lbl_vorgangkz.AutoSize = true;
            this.lbl_vorgangkz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vorgangkz.Location = new System.Drawing.Point(17, 264);
            this.lbl_vorgangkz.Name = "lbl_vorgangkz";
            this.lbl_vorgangkz.Size = new System.Drawing.Size(118, 25);
            this.lbl_vorgangkz.TabIndex = 48;
            this.lbl_vorgangkz.Text = "Vorgang KZ";
            // 
            // cmb_vorgangkz
            // 
            this.cmb_vorgangkz.DataSource = this.wOWIVORGANGBindingSource;
            this.cmb_vorgangkz.DisplayMember = "VORGANG";
            this.cmb_vorgangkz.FormattingEnabled = true;
            this.cmb_vorgangkz.Location = new System.Drawing.Point(153, 265);
            this.cmb_vorgangkz.Name = "cmb_vorgangkz";
            this.cmb_vorgangkz.Size = new System.Drawing.Size(352, 24);
            this.cmb_vorgangkz.TabIndex = 47;
            this.cmb_vorgangkz.ValueMember = "VORGANG";
            this.cmb_vorgangkz.SelectedIndexChanged += new System.EventHandler(this.cmb_vorgangkz_SelectedIndexChanged);
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
            this.lbl_dokuart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dokuart.Location = new System.Drawing.Point(17, 235);
            this.lbl_dokuart.Name = "lbl_dokuart";
            this.lbl_dokuart.Size = new System.Drawing.Size(80, 25);
            this.lbl_dokuart.TabIndex = 46;
            this.lbl_dokuart.Text = "Dokuart";
            // 
            // cmb_dokuart
            // 
            this.cmb_dokuart.DataSource = this.wOWIDOKARTBindingSource1;
            this.cmb_dokuart.DisplayMember = "DOKUART";
            this.cmb_dokuart.FormattingEnabled = true;
            this.cmb_dokuart.Location = new System.Drawing.Point(153, 235);
            this.cmb_dokuart.Name = "cmb_dokuart";
            this.cmb_dokuart.Size = new System.Drawing.Size(352, 24);
            this.cmb_dokuart.TabIndex = 45;
            this.cmb_dokuart.ValueMember = "DOKUART";
            this.cmb_dokuart.SelectedIndexChanged += new System.EventHandler(this.cmb_dokuart_SelectedIndexChanged);
            // 
            // wOWIDOKARTBindingSource1
            // 
            this.wOWIDOKARTBindingSource1.DataMember = "WOWIDOKART";
            this.wOWIDOKARTBindingSource1.DataSource = this.saperionDataSetDokuartDokuKZBindingSource;
            // 
            // wOWIDOKARTBindingSource
            // 
            this.wOWIDOKARTBindingSource.DataMember = "WOWIDOKART";
            this.wOWIDOKARTBindingSource.DataSource = this.saperionDataSetDokuartDokuKZBindingSource;
            // 
            // wOWIVORGANGTableAdapter
            // 
            this.wOWIVORGANGTableAdapter.ClearBeforeFill = true;
            // 
            // wOWIDOKARTTableAdapter
            // 
            this.wOWIDOKARTTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_UserSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 394);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_UserSettings";
            this.Text = "Benutzereinstellungen";
            this.Load += new System.EventHandler(this.Frm_UserSettings_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wOWIVORGANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saperionDataSetDokuartDokuKZBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saperionDataSet_Dokuart_DokuKZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wOWIDOKARTBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wOWIDOKARTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox chb_auto_archiving;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lbl_vorgangkz;
        private System.Windows.Forms.ComboBox cmb_vorgangkz;
        private System.Windows.Forms.Label lbl_dokuart;
        private System.Windows.Forms.ComboBox cmb_dokuart;
        private System.Windows.Forms.BindingSource wOWIDOKARTBindingSource;
        private System.Windows.Forms.BindingSource saperionDataSetDokuartDokuKZBindingSource;
        private saperionDataSet_Dokuart_DokuKZ saperionDataSet_Dokuart_DokuKZ;
        private System.Windows.Forms.BindingSource wOWIVORGANGBindingSource;
        private saperionDataSet_Dokuart_DokuKZTableAdapters.WOWIVORGANGTableAdapter wOWIVORGANGTableAdapter;
        private System.Windows.Forms.BindingSource wOWIDOKARTBindingSource1;
        private saperionDataSet_Dokuart_DokuKZTableAdapters.WOWIDOKARTTableAdapter wOWIDOKARTTableAdapter;
        private System.Windows.Forms.CheckBox chb_ask_before_archive;
    }
}