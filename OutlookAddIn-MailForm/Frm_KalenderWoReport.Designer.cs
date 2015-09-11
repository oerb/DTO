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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet1_WoWi_WirtschaftseinheitTEST = new OutlookAddIn_MailForm.DataSet1_WoWi_WirtschaftseinheitTEST();
            this.WirtschaftseinheitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.WirtschaftseinheitTableAdapter = new OutlookAddIn_MailForm.DataSet1_WoWi_WirtschaftseinheitTESTTableAdapters.WirtschaftseinheitTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1_WoWi_WirtschaftseinheitTEST)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WirtschaftseinheitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1_WoWi_WirtschaftseinhTestRP";
            reportDataSource1.Value = this.WirtschaftseinheitBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OutlookAddIn_MailForm.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(503, 444);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet1_WoWi_WirtschaftseinheitTEST
            // 
            this.DataSet1_WoWi_WirtschaftseinheitTEST.DataSetName = "DataSet1_WoWi_WirtschaftseinheitTEST";
            this.DataSet1_WoWi_WirtschaftseinheitTEST.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // WirtschaftseinheitBindingSource
            // 
            this.WirtschaftseinheitBindingSource.DataMember = "Wirtschaftseinheit";
            this.WirtschaftseinheitBindingSource.DataSource = this.DataSet1_WoWi_WirtschaftseinheitTEST;
            // 
            // WirtschaftseinheitTableAdapter
            // 
            this.WirtschaftseinheitTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_KalenderWoReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 468);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_KalenderWoReport";
            this.Text = "Frm_KalenderWoReport";
            this.Load += new System.EventHandler(this.Frm_KalenderWoReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1_WoWi_WirtschaftseinheitTEST)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WirtschaftseinheitBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource WirtschaftseinheitBindingSource;
        private DataSet1_WoWi_WirtschaftseinheitTEST DataSet1_WoWi_WirtschaftseinheitTEST;
        private DataSet1_WoWi_WirtschaftseinheitTESTTableAdapters.WirtschaftseinheitTableAdapter WirtschaftseinheitTableAdapter;
    }
}