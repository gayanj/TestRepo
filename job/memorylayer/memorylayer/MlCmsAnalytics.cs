using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mysqllayer;
using System.Data;

namespace Memorylayer
{
    public class MlCmsAnalytics
    {
        public DataSet GetURLIn()
        {
            var _url = new SlCmsAnalytics();
            return _url.GetURLIn();
        }

        public DataSet GetURLByCountry()
        {
            var _url = new SlCmsAnalytics();
            return _url.GetURLByCountry();
        }

        public void InsertAnalytics(string vid, string vip, string vic, string vicy, string vurl)
        {
            SlCmsAnalytics _sc = new SlCmsAnalytics();
            _sc.InsertAnalytics(vid, vip, vic, vicy, vurl);
        }

    }
}
