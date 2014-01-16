using System.Collections;
using System.Data;
using Memorylayer;

namespace Msftlayer
{
    public class ClHistory
    {
        public void Insertsavedjobs(string userid, string jobid)
        {
            var mlh = new MlHistory();
            mlh.Insertsavedjobs(userid, jobid);
        }

        public DataTable Getsavedjobs(string idusers)
        {
            var mlh = new MlHistory();
            return mlh.Getsavedjobs(idusers);
        }

        public string Getsavedsearchout(int idsearch)
        {
            var mlh = new MlHistory();
            return mlh.Getsavedsearchout(idsearch);
        }

        public void Insertsavedsearch(string userid, string search, string ipaddr, string searchname)
        {
            var mlh = new MlHistory();
            mlh.Insertsavedsearch(userid, search, ipaddr, searchname);
        }

        public void Inserthistorytext(string userip, string historytext)
        {
            var mlh = new MlHistory();
            mlh.Inserthistorytext(userip, historytext);
        }

        public DataTable Getsavedsearch(string idusers)
        {
            var mlh = new MlHistory();
            return mlh.Getsavedsearch(idusers);
        }

        public ArrayList Getarraysavedjobs(string uid)
        {
            var mlh = new MlHistory();
            return mlh.Getarraysavedjobs(uid);
        }
    }
}