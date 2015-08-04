using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutlookAddIn_MailForm
{
    public partial class Frm_helphtmlfile : Form
    {
        public Frm_helphtmlfile()
        {
            InitializeComponent();
        }

        public string url
        {
            get { return this.webBrowser1.Url.ToString(); }
            set 
            {
                // Instanziieren eines URL objektes
                Uri uri = new Uri(value);
                this.webBrowser1.Url = uri; 
            }
        }
        
    }
}
