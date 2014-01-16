using System;
using Microsoft.Reporting.WebForms;
using Msftlayer;

namespace JB
{
    public partial class Jbtrends : System.Web.UI.Page
    {
        private void Getsalarydashboard()
        {
            ReportViewer1.ShowToolBar = false;
            ReportViewer1.ProcessingMode = ProcessingMode.Local;
            ReportViewer1.LocalReport.ReportPath = Server.MapPath("/Cms/Reports/") + "rpt_jbtrends.rdlc";
            ReportViewer1.LocalReport.EnableHyperlinks = true;

            ReportViewer1.LocalReport.DataSources.Clear();
            var rd = new ReportDataSource();

            var cljbs = new ClJobs();
            rd.Name = "DataSet1";

            //check report type here
            rd.Value = cljbs.Gettrendsbyindustry();

            ReportViewer1.LocalReport.DataSources.Add(rd);
            ReportViewer1.LocalReport.Refresh();
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            Getsalarydashboard();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }
    }
}