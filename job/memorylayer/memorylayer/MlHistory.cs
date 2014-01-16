using System.Collections;
using System.Data;
using Mysqllayer;

namespace Memorylayer
{
    public class MlHistory
    {
        public void Insertsavedjobs(string userid, string jobid)
        {
            var slh = new SlHistory();
            slh.Insertsavedjobs(userid, jobid);
        }

        public DataTable Getsavedjobs(string idusers)
        {
            var slh = new SlHistory();
            return slh.Getsavedjobs(idusers);
        }

        public string Getsavedsearchout(int idsearch)
        {
            var slh = new SlHistory();
            return slh.Getsavedsearchout(idsearch);
        }

        public void Insertsavedsearch(string userid, string search, string ipaddr, string searchname)
        {
            var slh = new SlHistory();
            slh.Insertsavedsearch(userid, search, ipaddr, searchname);
        }

        public void Inserthistorytext(string userip, string historytext)
        {
            var slh = new SlHistory();
            slh.Inserthistorytext(userip, historytext);
        }

        public DataTable Getsavedsearch(string idusers)
        {
            var slh = new SlHistory();
            return slh.Getsavedsearch(idusers);
        }

        public ArrayList Getarraysavedjobs(string uid)
        {
            var slh = new SlHistory();
            return slh.Getarraysavedjobs(uid);
        }
    }
}