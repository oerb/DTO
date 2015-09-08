namespace OutlookAddIn_MailForm
{
    partial class Frm_ServerSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ServerSettings));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tab_settings = new System.Windows.Forms.TabControl();
            this.tbp_wowinex = new System.Windows.Forms.TabPage();
            this.lbl_serverlocationstring = new System.Windows.Forms.Label();
            this.txb_wowi_locationstring = new System.Windows.Forms.TextBox();
            this.btn_locationstring = new System.Windows.Forms.Button();
            this.tbp_saperion = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_saperion_connectionstring = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_saveChanges = new System.Windows.Forms.Button();
            this.lbl_dsn = new System.Windows.Forms.Label();
            this.lbl_uid = new System.Windows.Forms.Label();
            this.lbl_pwd = new System.Windows.Forms.Label();
            this.txt_dsn = new System.Windows.Forms.TextBox();
            this.txt_uid = new System.Windows.Forms.TextBox();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.tab_settings.SuspendLayout();
            this.tbp_wowinex.SuspendLayout();
            this.tbp_saperion.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // tab_settings
            // 
            this.tab_settings.AccessibleDescription = "";
            this.tab_settings.AccessibleName = "";
            this.tab_settings.Controls.Add(this.tbp_wowinex);
            this.tab_settings.Controls.Add(this.tbp_saperion);
            this.tab_settings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tab_settings.Location = new System.Drawing.Point(0, 24);
            this.tab_settings.Name = "tab_settings";
            this.tab_settings.SelectedIndex = 0;
            this.tab_settings.Size = new System.Drawing.Size(633, 238);
            this.tab_settings.TabIndex = 0;
            // 
            // tbp_wowinex
            // 
            this.tbp_wowinex.Controls.Add(this.txt_pwd);
            this.tbp_wowinex.Controls.Add(this.txt_uid);
            this.tbp_wowinex.Controls.Add(this.txt_dsn);
            this.tbp_wowinex.Controls.Add(this.lbl_pwd);
            this.tbp_wowinex.Controls.Add(this.lbl_uid);
            this.tbp_wowinex.Controls.Add(this.lbl_dsn);
            this.tbp_wowinex.Controls.Add(this.lbl_serverlocationstring);
            this.tbp_wowinex.Controls.Add(this.txb_wowi_locationstring);
            this.tbp_wowinex.Controls.Add(this.btn_locationstring);
            this.tbp_wowinex.Location = new System.Drawing.Point(4, 25);
            this.tbp_wowinex.Name = "tbp_wowinex";
            this.tbp_wowinex.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_wowinex.Size = new System.Drawing.Size(625, 209);
            this.tbp_wowinex.TabIndex = 0;
            this.tbp_wowinex.Text = "wowinex";
            this.tbp_wowinex.UseVisualStyleBackColor = true;
            // 
            // lbl_serverlocationstring
            // 
            this.lbl_serverlocationstring.AutoSize = true;
            this.lbl_serverlocationstring.Location = new System.Drawing.Point(8, 13);
            this.lbl_serverlocationstring.Name = "lbl_serverlocationstring";
            this.lbl_serverlocationstring.Size = new System.Drawing.Size(147, 17);
            this.lbl_serverlocationstring.TabIndex = 2;
            this.lbl_serverlocationstring.Text = "Server Locationstring:";
            // 
            // txb_wowi_locationstring
            // 
            this.txb_wowi_locationstring.Location = new System.Drawing.Point(11, 41);
            this.txb_wowi_locationstring.Name = "txb_wowi_locationstring";
            this.txb_wowi_locationstring.ReadOnly = true;
            this.txb_wowi_locationstring.Size = new System.Drawing.Size(377, 22);
            this.txb_wowi_locationstring.TabIndex = 1;
            // 
            // btn_locationstring
            // 
            this.btn_locationstring.Location = new System.Drawing.Point(394, 40);
            this.btn_locationstring.Name = "btn_locationstring";
            this.btn_locationstring.Size = new System.Drawing.Size(32, 23);
            this.btn_locationstring.TabIndex = 0;
            this.btn_locationstring.Text = "?";
            this.btn_locationstring.UseVisualStyleBackColor = true;
            this.btn_locationstring.Click += new System.EventHandler(this.btn_locationstring_Click);
            // 
            // tbp_saperion
            // 
            this.tbp_saperion.Controls.Add(this.label2);
            this.tbp_saperion.Controls.Add(this.txt_saperion_connectionstring);
            this.tbp_saperion.Controls.Add(this.button2);
            this.tbp_saperion.Location = new System.Drawing.Point(4, 25);
            this.tbp_saperion.Name = "tbp_saperion";
            this.tbp_saperion.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_saperion.Size = new System.Drawing.Size(625, 209);
            this.tbp_saperion.TabIndex = 1;
            this.tbp_saperion.Text = "Saperion";
            this.tbp_saperion.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "SQL-Datenbank Locationstring:";
            // 
            // txt_saperion_connectionstring
            // 
            this.txt_saperion_connectionstring.Location = new System.Drawing.Point(24, 135);
            this.txt_saperion_connectionstring.Name = "txt_saperion_connectionstring";
            this.txt_saperion_connectionstring.Size = new System.Drawing.Size(377, 22);
            this.txt_saperion_connectionstring.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(407, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_saveChanges
            // 
            this.btn_saveChanges.Location = new System.Drawing.Point(364, 12);
            this.btn_saveChanges.Name = "btn_saveChanges";
            this.btn_saveChanges.Size = new System.Drawing.Size(246, 31);
            this.btn_saveChanges.TabIndex = 1;
            this.btn_saveChanges.Text = "Änderungen Speichern";
            this.btn_saveChanges.UseVisualStyleBackColor = true;
            this.btn_saveChanges.Click += new System.EventHandler(this.btn_saveChanges_Click);
            // 
            // lbl_dsn
            // 
            this.lbl_dsn.AutoSize = true;
            this.lbl_dsn.Location = new System.Drawing.Point(8, 66);
            this.lbl_dsn.Name = "lbl_dsn";
            this.lbl_dsn.Size = new System.Drawing.Size(327, 17);
            this.lbl_dsn.TabIndex = 3;
            this.lbl_dsn.Text = "Dsn (siehe Systemsteuerung/Datenquellen(ODBC)";
            // 
            // lbl_uid
            // 
            this.lbl_uid.AutoSize = true;
            this.lbl_uid.Location = new System.Drawing.Point(8, 115);
            this.lbl_uid.Name = "lbl_uid";
            this.lbl_uid.Size = new System.Drawing.Size(98, 17);
            this.lbl_uid.TabIndex = 4;
            this.lbl_uid.Text = "Anmeldename";
            // 
            // lbl_pwd
            // 
            this.lbl_pwd.AutoSize = true;
            this.lbl_pwd.Location = new System.Drawing.Point(8, 157);
            this.lbl_pwd.Name = "lbl_pwd";
            this.lbl_pwd.Size = new System.Drawing.Size(65, 17);
            this.lbl_pwd.TabIndex = 5;
            this.lbl_pwd.Text = "Passwort";
            // 
            // txt_dsn
            // 
            this.txt_dsn.Location = new System.Drawing.Point(11, 90);
            this.txt_dsn.Name = "txt_dsn";
            this.txt_dsn.Size = new System.Drawing.Size(219, 22);
            this.txt_dsn.TabIndex = 6;
            // 
            // txt_uid
            // 
            this.txt_uid.Location = new System.Drawing.Point(11, 135);
            this.txt_uid.Name = "txt_uid";
            this.txt_uid.Size = new System.Drawing.Size(219, 22);
            this.txt_uid.TabIndex = 7;
            // 
            // txt_pwd
            // 
            this.txt_pwd.Location = new System.Drawing.Point(11, 177);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Size = new System.Drawing.Size(219, 22);
            this.txt_pwd.TabIndex = 8;
            // 
            // Frm_ServerSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 262);
            this.Controls.Add(this.btn_saveChanges);
            this.Controls.Add(this.tab_settings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(651, 307);
            this.MinimumSize = new System.Drawing.Size(651, 307);
            this.Name = "Frm_ServerSettings";
            this.Text = "Server Verbindungseinstellungen";
            this.Load += new System.EventHandler(this.Frm_ServerSettings_Load);
            this.tab_settings.ResumeLayout(false);
            this.tbp_wowinex.ResumeLayout(false);
            this.tbp_wowinex.PerformLayout();
            this.tbp_saperion.ResumeLayout(false);
            this.tbp_saperion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabControl tab_settings;
        private System.Windows.Forms.TabPage tbp_wowinex;
        private System.Windows.Forms.TabPage tbp_saperion;
        private System.Windows.Forms.Label lbl_serverlocationstring;
        private System.Windows.Forms.TextBox txb_wowi_locationstring;
        private System.Windows.Forms.Button btn_locationstring;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_saperion_connectionstring;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_saveChanges;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.TextBox txt_uid;
        private System.Windows.Forms.TextBox txt_dsn;
        private System.Windows.Forms.Label lbl_pwd;
        private System.Windows.Forms.Label lbl_uid;
        private System.Windows.Forms.Label lbl_dsn;
    }
}