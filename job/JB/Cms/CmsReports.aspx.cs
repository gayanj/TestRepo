using System;
using Microsoft.Reporting.WebForms;
using Msftlayer;

namespace JB.Cms
{
    public partial class Cmsreports : System.Web.UI.Page
    {
        private void Setreport(string reportfilter, string reportname, string contenttype)
        {
            ReportViewer1.ProcessingMode = ProcessingMode.Local;
            ReportViewer1.LocalReport.ReportPath = Server.MapPath("/Cms/Reports/") + reportname;
            ReportViewer1.LocalReport.EnableHyperlinks = true;

            ReportViewer1.LocalReport.DataSources.Clear();
            var rd = new ReportDataSource();
            var clrpt = new ClRptApplications();

            rd.Name = "DataSet1";

            #region cms_application

            switch (contenttype)
            {
                case "Applications":
                    switch (reportfilter)
                    {
                        case "Currentmonth":
                            rd.Value = clrpt.VwRptAppscurrmonth();
                            break;
                        case "Lastthreemonths":
                            rd.Value = clrpt.VwRptAppslast3Months();
                            break;
                        case "Lastsixmonths":
                            rd.Value = clrpt.VwRptAppslast6Month();
                            break;
                        case "Lastmonth":
                            rd.Value = clrpt.VwRptAppslastmonth();
                            break;
                        case "Lastyear":
                            rd.Value = clrpt.VwRptAppslastyear();
                            break;
                        case "Currentyear":
                            rd.Value = clrpt.VwRptAppsthisyear();
                            break;
                        case "Today":
                            rd.Value = clrpt.VwRptAppstoday();
                            break;
                        case "Yesterday":
                            rd.Value = clrpt.VwRptAppsyesterday();
                            break;
                        default:
                            rd.Value = clrpt.VwRptAppsall();
                            break;
                    }
                    break;
            }

            #endregion cms_application

            #region cms_spamreport

            switch (contenttype)
            {
                case "Spamreport":
                    rd.Value = clrpt.CmsSpamreport();
                    break;
            }

            #endregion cms_spamreport

            #region cms_security

            switch (contenttype)
            {
                case "Security":
                    switch (reportfilter)
                    {
                        case "Jobseekerlog":
                            rd.Value = clrpt.CmsAuditcan();
                            break;
                        case "Recruiterlog":
                            rd.Value = clrpt.CmsAuditrec();
                            break;
                        default:
                            rd.Value = clrpt.CmsAuditall();
                            break;
                    }
                    break;
            }

            #endregion cms_security

            #region cms_sitelog

            switch (contenttype)
            {
                case "Logging":
                    switch (reportfilter)
                    {
                        case "Sitelog":
                            rd.Value = clrpt.Getsitelogs();
                            break;
                    }
                    break;
            }

            #endregion cms_sitelog

            ReportViewer1.LocalReport.DataSources.Add(rd);
            ReportViewer1.LocalReport.Refresh();
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            if (Request.QueryString["content"] != null)
            {
              
                    switch (Request.QueryString["content"])
                    {
                        case "Applications":
                            Setreport(Server.HtmlEncode(Request.QueryString["filter"]), "rpt_applications.rdlc", Server.HtmlEncode(Request.QueryString["content"]));
                            break;
                        case "Logging":
                            Setreport(Server.HtmlEncode(Request.QueryString["filter"]), "rpt_cmssitelogs.rdlc", Server.HtmlEncode(Request.QueryString["content"]));
                            break;
                        case "Spamreport":
                            Setreport(Server.HtmlEncode(Request.QueryString["filter"]), "rpt_spamreport.rdlc", Server.HtmlEncode(Request.QueryString["content"]));
                            break;
                        default:
                            Setreport(Server.HtmlEncode(Request.QueryString["filter"]), "rpt_securitylog.rdlc", Server.HtmlEncode(Request.QueryString["content"]));
                            break;
                    }
                
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["filter"]!=null)
            {
                Labelreportname.Text = Server.HtmlEncode(Request.QueryString["filter"]);
            }
        }
    }
}