namespace OutlookAddIn_MailForm
{
    partial class Frm_Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Settings));
            this.btn_new_msgtype = new System.Windows.Forms.Button();
            this.lbx_mbstypes = new System.Windows.Forms.ListBox();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet_MSGTYPES = new OutlookAddIn_MailForm.Database1DataSet_MSGTYPES();
            this.btn_delete = new System.Windows.Forms.Button();
            this.tableTableAdapter = new OutlookAddIn_MailForm.Database1DataSet_MSGTYPESTableAdapters.TableTableAdapter();
            this.btn_edit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet_MSGTYPES)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_new_msgtype
            // 
            this.btn_new_msgtype.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_new_msgtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new_msgtype.Image = ((System.Drawing.Image)(resources.GetObject("btn_new_msgtype.Image")));
            this.btn_new_msgtype.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_new_msgtype.Location = new System.Drawing.Point(42, 594);
            this.btn_new_msgtype.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_new_msgtype.Name = "btn_new_msgtype";
            this.btn_new_msgtype.Size = new System.Drawing.Size(210, 42);
            this.btn_new_msgtype.TabIndex = 1;
            this.btn_new_msgtype.Text = "MSG Typ erstellen";
            this.btn_new_msgtype.UseVisualStyleBackColor = true;
            this.btn_new_msgtype.Click += new System.EventHandler(this.btn_new_msgtype_Click);
            // 
            // lbx_mbstypes
            // 
            this.lbx_mbstypes.DataSource = this.tableBindingSource;
            this.lbx_mbstypes.DisplayMember = "MSGtyp";
            this.lbx_mbstypes.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbx_mbstypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_mbstypes.FormattingEnabled = true;
            this.lbx_mbstypes.ItemHeight = 20;
            this.lbx_mbstypes.Location = new System.Drawing.Point(0, 0);
            this.lbx_mbstypes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbx_mbstypes.Name = "lbx_mbstypes";
            this.lbx_mbstypes.Size = new System.Drawing.Size(682, 564);
            this.lbx_mbstypes.TabIndex = 2;
            this.lbx_mbstypes.ValueMember = "Id";
            this.lbx_mbstypes.Click += new System.EventHandler(this.lbx_mbstypes_Click);
            this.lbx_mbstypes.DoubleClick += new System.EventHandler(this.btn_edit_Click);
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
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(477, 594);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(192, 42);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Löschen";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.Image")));
            this.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edit.Location = new System.Drawing.Point(260, 594);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(209, 42);
            this.btn_edit.TabIndex = 4;
            this.btn_edit.Text = "Bearbeiten";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // Frm_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 650);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.lbx_mbstypes);
            this.Controls.Add(this.btn_new_msgtype);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(700, 695);
            this.MinimumSize = new System.Drawing.Size(700, 695);
            this.Name = "Frm_Settings";
            this.Text = "MSG Typ Einstellungen";
            this.Load += new System.EventHandler(this.Frm_Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet_MSGTYPES)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_new_msgtype;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ListBox lbx_mbstypes;
        private Database1DataSet_MSGTYPES database1DataSet_MSGTYPES;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private Database1DataSet_MSGTYPESTableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.Button btn_edit;
    }
}