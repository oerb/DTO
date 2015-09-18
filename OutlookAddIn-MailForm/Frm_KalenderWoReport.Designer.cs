namespace OutlookAddIn_MailForm
{
    partial class Frm_KalenderWoReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.bindingSourcetblMaApp = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1MaApp1RP1 = new OutlookAddIn_MailForm.DataSet1MaApp1RP();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.WirtschaftseinheitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1_WoWi_WirtschaftseinheitTEST = new OutlookAddIn_MailForm.DataSet1_WoWi_WirtschaftseinheitTEST();
            this.WirtschaftseinheitTableAdapter = new OutlookAddIn_MailForm.DataSet1_WoWi_WirtschaftseinheitTESTTableAdapters.WirtschaftseinheitTableAdapter();
            this.DataSet1MaApp1RP = new OutlookAddIn_MailForm.DataSet1MaApp1RP();
            this.tblMaAppBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcetblMaApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1MaApp1RP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WirtschaftseinheitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1_WoWi_WirtschaftseinheitTEST)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1MaApp1RP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMaAppBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSourcetblMaApp
            // 
            this.bindingSourcetblMaApp.DataMember = "tblMaApp";
            this.bindingSourcetblMaApp.DataSource = this.dataSet1MaApp1RP1;
            // 
            // dataSet1MaApp1RP1
            // 
            this.dataSet1MaApp1RP1.DataSetName = "DataSet1MaApp1RP";
            this.dataSet1MaApp1RP1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1MaApp1RP";
            reportDataSource1.Value = this.tblMaAppBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OutlookAddIn_MailForm.Rep_WochenKalender.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(951, 703);
            this.reportViewer1.TabIndex = 0;
            // 
            // WirtschaftseinheitBindingSource
            // 
            this.WirtschaftseinheitBindingSource.DataMember = "Wirtschaftseinheit";
            this.WirtschaftseinheitBindingSource.DataSource = this.DataSet1_WoWi_WirtschaftseinheitTEST;
            // 
            // DataSet1_WoWi_WirtschaftseinheitTEST
            // 
            this.DataSet1_WoWi_WirtschaftseinheitTEST.DataSetName = "DataSet1_WoWi_WirtschaftseinheitTEST";
            this.DataSet1_WoWi_WirtschaftseinheitTEST.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // WirtschaftseinheitTableAdapter
            // 
            this.WirtschaftseinheitTableAdapter.ClearBeforeFill = true;
            // 
            // DataSet1MaApp1RP
            // 
            this.DataSet1MaApp1RP.DataSetName = "DataSet1MaApp1RP";
            this.DataSet1MaApp1RP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblMaAppBindingSource
            // 
            this.tblMaAppBindingSource.DataMember = "tblMaApp";
            this.tblMaAppBindingSource.DataSource = this.DataSet1MaApp1RP;
            // 
            // Frm_KalenderWoReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 703);
            this.Controls.Add(this.reportViewer1);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Frm_KalenderWoReport";
            this.Text = "HSM Tagesbericht";
            this.Load += new System.EventHandler(this.Frm_KalenderWoReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcetblMaApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1MaApp1RP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WirtschaftseinheitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1_WoWi_WirtschaftseinheitTEST)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1MaApp1RP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMaAppBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource WirtschaftseinheitBindingSource;
        private DataSet1_WoWi_WirtschaftseinheitTEST DataSet1_WoWi_WirtschaftseinheitTEST;
        private DataSet1_WoWi_WirtschaftseinheitTESTTableAdapters.WirtschaftseinheitTableAdapter WirtschaftseinheitTableAdapter;
        private DataSet1MaApp1RP dataSet1MaApp1RP1;
        private System.Windows.Forms.BindingSource bindingSourcetblMaApp;
        private System.Windows.Forms.BindingSource tblMaAppBindingSource;
        private DataSet1MaApp1RP DataSet1MaApp1RP;
    }
}