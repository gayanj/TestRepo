using System.Data;
using Memorylayer;

namespace Msftlayer
{
    public class ClRptApplications
    {
        public DataTable VwRptAppsall()
        {
            var slrpt = new MlrptApplications();
            return slrpt.VwRptAppsall();
        }

        public DataTable VwRptAppscurrmonth()
        {
            var slrpt = new MlrptApplications();
            return slrpt.VwRptAppscurrmonth();
        }

        public DataTable VwRptAppslast3Months()
        {
            var slrpt = new MlrptApplications();
            return slrpt.VwRptAppslast3Months();
        }

        public DataTable VwRptAppslast6Month()
        {
            var slrpt = new MlrptApplications();
            return slrpt.VwRptAppslast6Month();
        }

        public DataTable VwRptAppslastmonth()
        {
            var slrpt = new MlrptApplications();
            return slrpt.VwRptAppslastmonth();
        }

        public DataTable VwRptAppslastyear()
        {
            var slrpt = new MlrptApplications();
            return slrpt.VwRptAppslastyear();
        }

        public DataTable VwRptAppsthisyear()
        {
            var slrpt = new MlrptApplications();
            return slrpt.VwRptAppsthisyear();
        }

        public DataTable VwRptAppstoday()
        {
            var slrpt = new MlrptApplications();
            return slrpt.VwRptAppstoday();
        }

        public DataTable VwRptAppsyesterday()
        {
            var slrpt = new MlrptApplications();
            return slrpt.VwRptAppsyesterday();
        }

        //cms dashboard
        public DataTable CmsGetjobviewdata()
        {
            var slrpt = new MlrptApplications();
            return slrpt.CmsGetjobviewdata();
        }

        //security logs
        public DataTable CmsAuditcan()
        {
            var slrpt = new MlrptApplications();
            return slrpt.CmsAuditcan();
        }

        public DataTable CmsAuditrec()
        {
            var slrpt = new MlrptApplications();
            return slrpt.CmsAuditrec();
        }

        public DataTable CmsAuditall()
        {
            var slrpt = new MlrptApplications();
            return slrpt.CmsAuditall();
        }

        //server logs
        public DataTable Getsitelogs()
        {
            var slrpt = new MlrptApplications();
            return slrpt.Getsitelogs();
        }

        //spam reports
        public DataTable CmsSpamreport()
        {
            var slrpt = new MlrptApplications();
            return slrpt.CmsSpamreport();
        }
    }
}