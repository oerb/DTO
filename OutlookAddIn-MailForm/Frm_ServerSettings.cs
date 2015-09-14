using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace OutlookAddIn_MailForm
{
    public partial class Frm_ServerSettings : Form
    {
        public Frm_ServerSettings()
        {
            InitializeComponent();
            this.txt_pwd.Text = "";
            this.txt_pwd.PasswordChar = '*';
            this.txt_pwd.MaxLength = 10;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_helphtmlfile help = new Frm_helphtmlfile();
            //help.url = @"C:\Users\leppin\Documents\Visual Studio 2013\" +
            //@"Projects\OutlookAddIn-MailForm\OutlookAddIn-MailForm\" + 
            //@"Resources\Helpdocs\Saperion_Serverlocation.mht";
            help.url = @"https://github.com/oerb/DTO/wiki/Help---WoWi-ODBC-Connectionstring";
            DialogResult result = help.ShowDialog(); 
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_helphtmlfile help = new Frm_helphtmlfile();
            //help.url = @"C:\Users\leppin\Documents\Visual Studio 2013\" +
            //@"Projects\OutlookAddIn-MailForm\OutlookAddIn-MailForm\" +
            //@"Resources\Helpdocs\SaperionSQL_ConnectionString.mht";
            help.url = @"https://github.com/oerb/DTO/wiki/Help---WoWi-ODBC-Connectionstring";
            DialogResult result = help.ShowDialog(); 
        }

        private void btn_locationstring_Click(object sender, EventArgs e)
        {
            Frm_helphtmlfile help = new Frm_helphtmlfile();
            //help.url = @"C:\Users\leppin\Documents\Visual Studio 2013\" +
            //@"Projects\OutlookAddIn-MailForm\OutlookAddIn-MailForm\" +
            //@"Resources\Helpdocs\wowi_ODBC_Connectionstring.mht";
            help.url = @"https://github.com/oerb/DTO/wiki/Help---WoWi-ODBC-Connectionstring";
            DialogResult result = help.ShowDialog(); 
        }

        private void Frm_ServerSettings_Load(object sender, EventArgs e)
        {
            string wowi_connectionstring = Properties.Settings.Default.ConnectionStringWoWiODBC.ToString();
            char[] delimiterChars = { ',', ';', '=' };
            string[] wowi_connectionstring_split = wowi_connectionstring.Split(delimiterChars);
            this.txt_dsn.Text = wowi_connectionstring_split[1];
            this.txt_uid.Text = wowi_connectionstring_split[3];
            this.txt_pwd.Text = wowi_connectionstring_split[5];
            this.txb_wowi_locationstring.Text = wowi_connectionstring;
            //this.txt_saperion_connectionstring.Text = Properties.Settings.Default.saperionConnectionString.ToString();        
        }

        private void btn_saveChanges_Click(object sender, EventArgs e)
        {
            string newCnnStr = "Dsn=" + this.txt_dsn.Text;
            newCnnStr += ";uid=" + this.txt_uid.Text;
            newCnnStr += ";pwd=" + this.txt_pwd.Text;
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            try
            {
                config.ConnectionStrings.ConnectionStrings["OutlookAddIn_MailForm.Properties.Settings.ConnectionStringWoWiODBC"].ConnectionString = newCnnStr;
                config.Save(ConfigurationSaveMode.Modified);
                Properties.Settings.Default["ConnectionStringWoWiODBC"] = newCnnStr;
            }
            catch (ConfigurationErrorsException ex)
            {
                string msgtext = "Error: WoWi Connectionstring Configfile not found; \n\nEXCEPTTION: " + ex.ToString();
                MessageBox.Show(msgtext);
                throw;
            }            
        }
    }
}
