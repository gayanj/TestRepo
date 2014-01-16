using System.Data;
using Memorylayer;

namespace Msftlayer
{
    public class ClCmsApplications
    {
        //selected candidates, candidates for interview
        public DataTable Cmsselectedapps()
        {
            var scms = new MlCmsApplications();
            return scms.Cmsselectedapps();
        }

        //rejected applications
        public DataTable Cmsrejectedapps()
        {
            var scms = new MlCmsApplications();
            return scms.Cmsrejectedapps();
        }

        //apps under review
        public DataTable Cmsawaitingdapps()
        {
            var scms = new MlCmsApplications();
            return scms.Cmsawaitingdapps();
        }

        //all applications
        public DataTable Cmsallapps()
        {
            var scms = new MlCmsApplications();
            return scms.Cmsallapps();
        }
    }
}