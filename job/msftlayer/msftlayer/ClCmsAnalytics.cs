using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Memorylayer;
using System.Data;

namespace Msftlayer
{
    public class ClCmsAnalytics
    {
        public DataSet GetUrlIn()
        {
            var _url = new MlCmsAnalytics();
            return _url.GetURLIn();
        }

        public DataSet GetUrlByCountry()
        {
            var _url = new MlCmsAnalytics();
            return _url.GetURLByCountry();
        }

        public void InsertAnalytics(string vid, string vip, string vic, string vicy, string vurl)
        {
            MlCmsAnalytics _mc = new MlCmsAnalytics();
            _mc.InsertAnalytics(vid, vip, vic, vicy, vurl);
        }
    }
}
