using System;
using Microsoft.Reporting.WebForms;
using Msftlayer;

namespace JB.Cms
{
    public partial class Cmshome : System.Web.UI.Page
    {
        private void Getrptdashboard()
        {
            ReportViewer1.ShowToolBar = false;
            ReportViewer1.ProcessingMode = ProcessingMode.Local;
            ReportViewer1.LocalReport.ReportPath = Server.MapPath("/Cms/Reports/") + "rpt_cmsdashboard.rdlc";
            ReportViewer1.LocalReport.EnableHyperlinks = true;

            ReportViewer1.LocalReport.DataSources.Clear();
            var rd = new ReportDataSource();

            var clrpt = new ClRptApplications();
            rd.Name = "DataSet1";

            //check report type here
            rd.Value = clrpt.CmsGetjobviewdata();

            ReportViewer1.LocalReport.DataSources.Add(rd);
            ReportViewer1.DataBind();
            //ReportViewer1.LocalReport.Refresh();
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            //hookup reports
            Getrptdashboard();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //load analytics
            var _analyseurls = new ClCmsAnalytics();
            GridView1.DataSource = _analyseurls.GetUrlIn();
            GridView1.DataBind();

            GridView2.DataSource = _analyseurls.GetUrlByCountry();
            GridView2.DataBind();
        }

        protected void GridView1_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            var _analyseurls = new ClCmsAnalytics();
            GridView1.DataSource = _analyseurls.GetUrlIn();
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();

            GridView2.DataSource = _analyseurls.GetUrlByCountry();
            GridView2.PageIndex = e.NewPageIndex;
            GridView2.DataBind();
        }
    }
}