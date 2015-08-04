namespace OutlookAddIn_MailForm
{
    partial class Schadensmeldung
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
            this.button1 = new System.Windows.Forms.Button();
            this.txb_object = new System.Windows.Forms.TextBox();
            this.lbl_object = new System.Windows.Forms.Label();
            this.lbl_we = new System.Windows.Forms.Label();
            this.txb_we = new System.Windows.Forms.TextBox();
            this.lbl_headtext = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(427, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Senden";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txb_object
            // 
            this.txb_object.Location = new System.Drawing.Point(101, 76);
            this.txb_object.Name = "txb_object";
            this.txb_object.Size = new System.Drawing.Size(260, 22);
            this.txb_object.TabIndex = 1;
            // 
            // lbl_object
            // 
            this.lbl_object.AutoSize = true;
            this.lbl_object.Location = new System.Drawing.Point(38, 80);
            this.lbl_object.Name = "lbl_object";
            this.lbl_object.Size = new System.Drawing.Size(57, 17);
            this.lbl_object.TabIndex = 2;
            this.lbl_object.Text = "Objekt: ";
            // 
            // lbl_we
            // 
            this.lbl_we.AutoSize = true;
            this.lbl_we.Location = new System.Drawing.Point(38, 108);
            this.lbl_we.Name = "lbl_we";
            this.lbl_we.Size = new System.Drawing.Size(38, 17);
            this.lbl_we.TabIndex = 4;
            this.lbl_we.Text = "WE: ";
            // 
            // txb_we
            // 
            this.txb_we.Location = new System.Drawing.Point(101, 104);
            this.txb_we.Name = "txb_we";
            this.txb_we.Size = new System.Drawing.Size(260, 22);
            this.txb_we.TabIndex = 3;
            // 
            // lbl_headtext
            // 
            this.lbl_headtext.AutoSize = true;
            this.lbl_headtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_headtext.Location = new System.Drawing.Point(26, 9);
            this.lbl_headtext.Name = "lbl_headtext";
            this.lbl_headtext.Size = new System.Drawing.Size(489, 32);
            this.lbl_headtext.TabIndex = 5;
            this.lbl_headtext.Text = "Schadensmeldung noch als Muster";
            this.lbl_headtext.Click += new System.EventHandler(this.label1_Click);
            // 
            // Schadensmeldung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 434);
            this.Controls.Add(this.lbl_headtext);
            this.Controls.Add(this.lbl_we);
            this.Controls.Add(this.txb_we);
            this.Controls.Add(this.lbl_object);
            this.Controls.Add(this.txb_object);
            this.Controls.Add(this.button1);
            this.Name = "Schadensmeldung";
            this.Text = "Schadensmeldung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txb_object;
        private System.Windows.Forms.Label lbl_object;
        private System.Windows.Forms.Label lbl_we;
        private System.Windows.Forms.TextBox txb_we;
        private System.Windows.Forms.Label lbl_headtext;
    }
}