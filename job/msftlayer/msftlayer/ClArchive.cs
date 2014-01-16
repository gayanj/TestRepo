using System;
using System.Data;
using Memorylayer;

namespace Msftlayer
{
    public class ClArchive
    {
        public void Insertarchives(string uusername, DateTime dtentered, int uusertype, string userdevice, string userip)
        {
            var slarc = new MlArchive();
            slarc.Insertarchives(uusername, dtentered, uusertype, userdevice, userip);
        }

        public DataTable Getacsecuritycan(string uusername)
        {
            var slarc = new MlArchive();
            return slarc.Getacsecuritycan(uusername);
        }

        public DataTable Getacsecurityrec(string uusername)
        {
            var slarc = new MlArchive();
            return slarc.Getacsecurityrec(uusername);
        }
    }
}