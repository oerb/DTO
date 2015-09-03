using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Interop.Outlook;
using System.Windows.Forms;

namespace OutlookAddIn_MailForm

{
    public class MSG_Parameter
    {
        public string filelocaiton;
        public int Mandant = 0;
        public int Unternehmen = 0;
        public int WE = 0;
        public int HausNr = 0;
        public int Wohnung = 0;
        public int AdresseNr = 0;
        public string DokuArt = "DT_Mail";
        public string VorgangKZ = "DT_Mail";
        public string Vorname = "";
        public string Name = "";
        public int FolgeNr = 0;
        public Outlook.MailItem MailItem;
        public DateTime datum1 = DateTime.Now;
        public DateTime datum2 = DateTime.Now;
        public string WeBeszeichnung = "";
        public string NeStrasse = "";
        public string NeOrt = "";
        public string NeEtage = "";
        public string MiTel = "";
        public string MiTel2 = "";
        public string MiMob = "";
        public string KreditorName = "";
        public string KreditorEmail = "";
        public int KreditorAdr = 0;
        public string BriefAnrede = "";
   }
}
