using System.Data;
using Mysqllayer;

namespace Memorylayer
{
    public class MlCmsApplications
    {
        //selected candidates, candidates for interview
        public DataTable Cmsselectedapps()
        {
            var scms = new SlCmsApplications();
            return scms.Cmsselectedapps();
        }

        //rejected applications
        public DataTable Cmsrejectedapps()
        {
            var scms = new SlCmsApplications();
            return scms.Cmsrejectedapps();
        }

        //apps under review
        public DataTable Cmsawaitingdapps()
        {
            var scms = new SlCmsApplications();
            return scms.Cmsawaitingdapps();
        }

        //all applications
        public DataTable Cmsallapps()
        {
            var scms = new SlCmsApplications();
            return scms.Cmsallapps();
        }
    }
}