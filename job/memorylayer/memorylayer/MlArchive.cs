using System;
using System.Data;
using Mysqllayer;

namespace Memorylayer
{
    public class MlArchive
    {
        public void Insertarchives(string uusername, DateTime dtentered, int uusertype, string userdevice, string userip)
        {
            var slarc = new SlArchive();
            slarc.Insertarchives(uusername, dtentered, uusertype, userdevice, userip);
        }

        public DataTable Getacsecuritycan(string uusername)
        {
            var slarc = new SlArchive();
            return slarc.Getacsecuritycan(uusername);
        }

        public DataTable Getacsecurityrec(string uusername)
        {
            var slarc = new SlArchive();
            return slarc.Getacsecurityrec(uusername);
        }
    }
}