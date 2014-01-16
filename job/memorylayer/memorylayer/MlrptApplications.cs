using System.Data;
using Mysqllayer;

namespace Memorylayer
{
    public class MlrptApplications
    {
        public DataTable VwRptAppsall()
        {
            var slrpt = new SlRptApplications();
            return slrpt.VwRptAppsall();
        }

        public DataTable VwRptAppscurrmonth()
        {
            var slrpt = new SlRptApplications();
            return slrpt.VwRptAppscurrmonth();
        }

        public DataTable VwRptAppslast3Months()
        {
            var slrpt = new SlRptApplications();
            return slrpt.VwRptAppslast3Months();
        }

        public DataTable VwRptAppslast6Month()
        {
            var slrpt = new SlRptApplications();
            return slrpt.VwRptAppslast6Month();
        }

        public DataTable VwRptAppslastmonth()
        {
            var slrpt = new SlRptApplications();
            return slrpt.VwRptAppslastmonth();
        }

        public DataTable VwRptAppslastyear()
        {
            var slrpt = new SlRptApplications();
            return slrpt.VwRptAppslastyear();
        }

        public DataTable VwRptAppsthisyear()
        {
            var slrpt = new SlRptApplications();
            return slrpt.VwRptAppsthisyear();
        }

        public DataTable VwRptAppstoday()
        {
            var slrpt = new SlRptApplications();
            return slrpt.VwRptAppstoday();
        }

        public DataTable VwRptAppsyesterday()
        {
            var slrpt = new SlRptApplications();
            return slrpt.VwRptAppsyesterday();
        }

        //cms dashboard
        public DataTable CmsGetjobviewdata()
        {
            var slrpt = new SlRptApplications();
            return slrpt.CmsGetjobviewdata();
        }

        //security log
        public DataTable CmsAuditcan()
        {
            var slrpt = new SlRptApplications();
            return slrpt.CmsAuditcan();
        }

        public DataTable CmsAuditrec()
        {
            var slrpt = new SlRptApplications();
            return slrpt.CmsAuditrec();
        }

        public DataTable CmsAuditall()
        {
            var slrpt = new SlRptApplications();
            return slrpt.CmsAuditall();
        }

        //server logs
        public DataTable Getsitelogs()
        {
            var slrpt = new SlRptApplications();
            return slrpt.Getsitelogs();
        }

        //spam reports
        public DataTable CmsSpamreport()
        {
            var slrpt = new SlRptApplications();
            return slrpt.CmsSpamreport();
        }
    }
}