using System.Collections;
using Memorylayer;

namespace Msftlayer
{
    public class ClAdverts
    {
        //get all adverts realing to string litral

        public ArrayList Getmasterpagesiteads()
        {
            var mladv = new MlAdverts();
            return mladv.Getmasterpagesiteads();
        }

        public ArrayList Getmicrologinads()
        {
            var mladv = new MlAdverts();
            return mladv.Getmicrologinads();
        }

        public ArrayList Getstockbarads()
        {
            var sladv = new MlAdverts();
            return sladv.Getstockbarads();
        }

        public string Getadvertstring(int r1)
        {
            var mladvert = new MlAdverts();
            var tempst = (ArrayList)mladvert.Getadvertstring();
            var temret = tempst[r1].ToString();
            tempst.Clear();
            return temret;
        }

        public ArrayList Getjobtextadverts()
        {
            var mladvert = new MlAdverts();
            return mladvert.Getjobtextadverts();
        }

        public string[] Getdesktoptadstr()
        {
            var sladv = new MlAdverts();
            return sladv.Getdesktoptadstr();
        }
    }
}