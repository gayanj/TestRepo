using System.Collections;
using Mysqllayer;

namespace Memorylayer
{
    public class MlSiteMap
    {
        public ArrayList Getsitemapitems()
        {
            var slmap = new SlSitemap();
            return slmap.Getsitemapitems();
        }
    }
}