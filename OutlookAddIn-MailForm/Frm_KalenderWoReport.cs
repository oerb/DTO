using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;
using System.Diagnostics;

namespace OutlookAddIn_MailForm
{
    public partial class Frm_KalenderWoReport : Form
    {
        public Frm_KalenderWoReport()
        {
            InitializeComponent();
        }
        private DataTable MarkedAppointment;
        

        private void Frm_KalenderWoReport_Load(object sender, EventArgs e)
        {
            // How the DataBinding Works in Report: Look the Code here and !!! put into the
            // reportViewer the DataSource after you had dropted from Toolbox a BindingSource
            // and connected it to the DataSet
            //reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            var DateSpan = this.getSelectedDateSpan();
            //Get Only the full Day of dateStart
            DateTime dateStart = DateSpan.Item1.Date;
            DateTime dateEnd = dateStart.AddDays(1);//DateSpan.Item2;
            //TimeSpan hours = dateStart - dateEnd;
            //string msgtext = "Zeitspanne" + hours.ToString();
            //MessageBox.Show(msgtext);
            if (DateSpan.Item3)
            {
                this.MarkedAppointment = this.GetCalenderItemsInTimeSpan(dateStart, dateEnd);                               
                this.reportViewer1.RefreshReport();                
            }
        }

        // gets the DateSpan Marked in Outlook Kalender
        // Returns Tuple with StartDateTime and EndDateTime
        public Tuple<DateTime,DateTime,bool> getSelectedDateSpan()
        {
            DateTime dateNull = new DateTime(4501, 1, 1, 0, 0, 0);
            Outlook.Explorer expl = Globals.ThisAddIn.Application.ActiveExplorer();
            Outlook.Folder folder = expl.CurrentFolder as Outlook.Folder;
            Outlook.View view = expl.CurrentView as Outlook.View;
            if (view.ViewType == Outlook.OlViewType.olCalendarView)
            {
                Outlook.CalendarView calView = view as Outlook.CalendarView;
                DateTime dateStart = calView.SelectedStartTime;
                DateTime dateEnd = calView.SelectedEndTime;
                //Outlook.AppointmentItem appt =
                //folder.Items.Add("IPM.Appointment")
                //as Outlook.AppointmentItem;
                if (dateStart != dateNull && dateEnd != dateNull)
                {
                    return Tuple.Create(dateStart, dateEnd, true);
                }                              
            }
            return Tuple.Create(DateTime.Now, DateTime.Now, false); 
        }

        private DataTable GetCalenderItemsInTimeSpan(DateTime StartDate, DateTime EndDate)
        {
            DataTable sample = this.dataSet1MaApp1RP1.tblMaApp; //Sample Data

            Outlook.Folder calFolder = Globals.ThisAddIn.Application.Session.GetDefaultFolder(
            Outlook.OlDefaultFolders.olFolderCalendar)
            as Outlook.Folder;
            Outlook.Items rangeAppts = GetAppointmentsInRange(calFolder, StartDate, EndDate);
            if (rangeAppts != null)
	        {
		        foreach (Outlook.AppointmentItem item in rangeAppts)
	            {
		            DataRow row = sample.NewRow();
                                    row["Subject"] = item.Subject;
                                    row["Location"] = item.Location;
                                    row["StartTime"] = item.Start.TimeOfDay.ToString();
                                    row["EndTime"] = item.End.TimeOfDay.ToString();
                                    row["StartDate"] = item.Start.Date;
                                    row["EndDate"] = item.End.Date;
                                    row["AllDayEvent"] = item.AllDayEvent;
                                    row["Body"] = item.Body;
                                    row["Hours"] = item.End.TimeOfDay-item.Start.TimeOfDay;
                                    sample.Rows.Add(row);  
	            }
	        }
            return sample;
        }

        private Outlook.Items GetAppointmentsInRange(Outlook.Folder folder, DateTime startTime, DateTime endTime)
        {
            string filter = "[Start] >= '"
                + startTime.ToString("g")
                + "' AND [End] <= '"
                + endTime.ToString("g") + "'";
            Debug.WriteLine(filter);
            try
            {
                Outlook.Items calItems = folder.Items;
                calItems.IncludeRecurrences = true;
                calItems.Sort("[Start]", Type.Missing);
                Outlook.Items restrictItems = calItems.Restrict(filter);
                if (restrictItems.Count > 0)
                {
                    return restrictItems;
                }
                else
                {
                    return null;
                }
            }
            catch { return null; }
        }

        private void GetAllCalenderItems()
        {
            //DataTable sample = new DataTable(); //Sample Data
            //sample.Columns.Add("Subject", typeof(string));
            //sample.Columns.Add("Location", typeof(string));
            //sample.Columns.Add("StartTime", typeof(DateTime));
            //sample.Columns.Add("EndTime", typeof(DateTime));
            //sample.Columns.Add("StartDate", typeof(DateTime));
            //sample.Columns.Add("EndDate", typeof(DateTime));
            //sample.Columns.Add("AllDayEvent", typeof(bool));
            //sample.Columns.Add("Body", typeof(string));


            //listViewContacts.Items.Clear();
            //oApp = new Outlook.Application();
            //oNS = oApp.GetNamespace("MAPI");
            //oCalenderFolder = oNS.GetDefaultFolder(Microsoft.Office.Interop.Outlook.OlDefaultFolders.olFolderCalendar);
            //outlookCalendarItems = oCalenderFolder.Items;
            //outlookCalendarItems.IncludeRecurrences = true;
            //// DataTable sample = new DataTable();
            //foreach (Microsoft.Office.Interop.Outlook.AppointmentItem item in outlookCalendarItems)
            //{
            //    DataRow row = sample.NewRow();
            //    row["Subject"] = item.Subject;
            //    row["Location"] = item.Location;
            //    row["StartTime"] = item.Start.TimeOfDay.ToString();
            //    row["EndTime"] = item.End.TimeOfDay.ToString();
            //    row["StartDate"] = item.Start.Date;
            //    row["EndDate"] = item.End.Date;
            //    row["AllDayEvent"] = item.AllDayEvent;
            //    row["Body"] = item.Body;
            //    sample.Rows.Add(row);
            //}
            //sample.AcceptChanges();
            //foreach (DataRow dr in sample.Rows)
            //{
            //    ListViewItem lvi = new ListViewItem(dr["Subject"].ToString());

            //    lvi.SubItems.Add(dr["Location"].ToString());
            //    lvi.SubItems.Add(dr["StartTime"].ToString());
            //    lvi.SubItems.Add(dr["EndTime"].ToString());
            //    lvi.SubItems.Add(dr["StartDate"].ToString());
            //    lvi.SubItems.Add(dr["EndDate"].ToString());
            //    lvi.SubItems.Add(dr["AllDayEvent"].ToString());
            //    lvi.SubItems.Add(dr["Body"].ToString());



            //    this.listViewContacts.Items.Add(lvi);
            //}
            //oApp = null;
            //oNS = null;
        }
    }
}
