using System.Collections;
using System.Data;
using Memorylayer;

namespace Msftlayer
{
    public class ClArticles
    {
        public void Insertarticles(string articlename, string articleurl, string articledata)
        {
            var sla = new MlArticles();
            sla.Insertarticles(articlename, articleurl, articledata);
        }

        public DataTable Getallartlist()
        {
            var sla = new MlArticles();
            return sla.Getallartlist();
        }

        public ArrayList Getallarticlebyid(string idart)
        {
            var sla = new MlArticles();
            return sla.Getallarticlebyid(idart);
        }
    }
}