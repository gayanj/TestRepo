using System;
using Microsoft.Reporting.WebForms;
using Msftlayer;

namespace JB.SalaryCalc
{
    public partial class Salaryresult : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            Getsalarydashboard();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        private void Getsalarydashboard()
        {
            ReportViewerSal.ShowToolBar = false;
            ReportViewerSal.ProcessingMode = ProcessingMode.Local;
            ReportViewerSal.LocalReport.ReportPath = Server.MapPath("/Cms/Reports/") + "rpt_glbsalresult.rdlc";
            ReportViewerSal.LocalReport.EnableHyperlinks = true;

            ReportViewerSal.LocalReport.DataSources.Clear();
            var rd = new ReportDataSource();

            var srcalc = new ClSalaryCalc();
            rd.Name = "DataSet1";

            //check report type here
            rd.Value = srcalc.Getsals();

            ReportViewerSal.LocalReport.DataSources.Add(rd);
            ReportViewerSal.LocalReport.Refresh();
        }
    }
}