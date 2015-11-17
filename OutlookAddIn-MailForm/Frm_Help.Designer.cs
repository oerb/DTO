namespace OutlookAddIn_MailForm
{
    partial class Frm_Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Help));
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.llb_MeldungErstellen = new System.Windows.Forms.LinkLabel();
            this.llb_MSGtypEinstellung = new System.Windows.Forms.LinkLabel();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.llb_Issues = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(7, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(554, 73);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "Das Outlook-Addon DTO wird auf einer GitHub Seite gepflegt. Dort finden sich auch" +
    " die Hilfedateien, die sie unten als Verweislink angezeigt bekommen.\n\n";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 94);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(137, 17);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Hilfe Übersichtsseite";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // llb_MeldungErstellen
            // 
            this.llb_MeldungErstellen.AutoSize = true;
            this.llb_MeldungErstellen.Location = new System.Drawing.Point(12, 146);
            this.llb_MeldungErstellen.Name = "llb_MeldungErstellen";
            this.llb_MeldungErstellen.Size = new System.Drawing.Size(120, 17);
            this.llb_MeldungErstellen.TabIndex = 3;
            this.llb_MeldungErstellen.TabStop = true;
            this.llb_MeldungErstellen.Text = "Meldung erstellen";
            this.llb_MeldungErstellen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_MeldungErstellen_LinkClicked);
            // 
            // llb_MSGtypEinstellung
            // 
            this.llb_MSGtypEinstellung.AutoSize = true;
            this.llb_MSGtypEinstellung.Location = new System.Drawing.Point(12, 175);
            this.llb_MSGtypEinstellung.Name = "llb_MSGtypEinstellung";
            this.llb_MSGtypEinstellung.Size = new System.Drawing.Size(234, 17);
            this.llb_MSGtypEinstellung.TabIndex = 4;
            this.llb_MSGtypEinstellung.TabStop = true;
            this.llb_MSGtypEinstellung.Text = "Meldungstypen erstellen/bearbeiten";
            this.llb_MSGtypEinstellung.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_MSGtypEinstellung_LinkClicked);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Enabled = false;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(12, 228);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox2.Size = new System.Drawing.Size(549, 73);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "Sollten Sie Fehler im Programm feststellen, so können Sie diese auf der Github-Se" +
    "ite im Issues Tracker melden.";
            // 
            // llb_Issues
            // 
            this.llb_Issues.AutoSize = true;
            this.llb_Issues.Location = new System.Drawing.Point(12, 323);
            this.llb_Issues.Name = "llb_Issues";
            this.llb_Issues.Size = new System.Drawing.Size(221, 17);
            this.llb_Issues.TabIndex = 6;
            this.llb_Issues.TabStop = true;
            this.llb_Issues.Text = "Dto Issues Tracker/Fehler melden";
            this.llb_Issues.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_Issues_LinkClicked);
            // 
            // Frm_Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(561, 390);
            this.Controls.Add(this.llb_Issues);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.llb_MSGtypEinstellung);
            this.Controls.Add(this.llb_MeldungErstellen);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(579, 435);
            this.MinimumSize = new System.Drawing.Size(579, 435);
            this.Name = "Frm_Help";
            this.Text = "Hilfe";
            this.Load += new System.EventHandler(this.Frm_Help_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel llb_MeldungErstellen;
        private System.Windows.Forms.LinkLabel llb_MSGtypEinstellung;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.LinkLabel llb_Issues;
    }
}