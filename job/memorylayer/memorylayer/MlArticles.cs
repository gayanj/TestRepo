using System.Collections;
using System.Data;
using Mysqllayer;

namespace Memorylayer
{
    public class MlArticles
    {
        public void Insertarticles(string articlename, string articleurl, string articledata)
        {
            var sla = new SlArticles();
            sla.Insertarticles(articlename, articleurl, articledata);
        }

        public DataTable Getallartlist()
        {
            var sla = new SlArticles();
            return sla.Getallartlist();
        }

        public ArrayList Getallarticlebyid(string idart)
        {
            var sla = new SlArticles();
            return sla.Getallarticlebyid(idart);
        }
    }
}