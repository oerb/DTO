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
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet_MSGTYPES)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(421, 95);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(143, 48);
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
            this.btn_filesearch.Location = new System.Drawing.Point(570, 56);
            this.btn_filesearch.Name = "btn_filesearch";
            this.btn_filesearch.Size = new System.Drawing.Size(45, 33);
            this.btn_filesearch.TabIndex = 16;
            this.btn_filesearch.UseVisualStyleBackColor = true;
            this.btn_filesearch.Click += new System.EventHandler(this.btn_filesearch_Click);
            // 
            // txt_filelocation
            // 
            this.txt_filelocation.Location = new System.Drawing.Point(143, 61);
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
            this.txt_mailtype.Name = "txt_mailtype";
            this.txt_mailtype.Size = new System.Drawing.Size(421, 22);
            this.txt_mailtype.TabIndex = 22;
            // 
            // lbl_msgtyp
            // 
            this.lbl_msgtyp.AutoSize = true;
            this.lbl_msgtyp.Location = new System.Drawing.Point(22, 25);
            this.lbl_msgtyp.Name = "lbl_msgtyp";
            this.lbl_msgtyp.Size = new System.Drawing.Size(75, 17);
            this.lbl_msgtyp.TabIndex = 23;
            this.lbl_msgtyp.Text = "MSG Typ: ";
            // 
            // lbl_filelocation
            // 
            this.lbl_filelocation.AutoSize = true;
            this.lbl_filelocation.Location = new System.Drawing.Point(22, 64);
            this.lbl_filelocation.Name = "lbl_filelocation";
            this.lbl_filelocation.Size = new System.Drawing.Size(77, 17);
            this.lbl_filelocation.TabIndex = 24;
            this.lbl_filelocation.Text = "Dateipfad: ";
            // 
            // Frm_New_MSGTYPE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 155);
            this.Controls.Add(this.lbl_filelocation);
            this.Controls.Add(this.lbl_msgtyp);
            this.Controls.Add(this.txt_mailtype);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_filesearch);
            this.Controls.Add(this.txt_filelocation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_New_MSGTYPE";
            this.Text = "MSG Typ festlegen";
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet_MSGTYPES)).EndInit();
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

    }
}