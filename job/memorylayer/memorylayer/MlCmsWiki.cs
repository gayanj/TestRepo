using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mysqllayer;
using System.Data;

namespace Memorylayer
{
    public class MlCmsWiki
    {
        public DataSet GetWiki()
        {
            var _wiki = new SlCmsWiki();
            return _wiki.GetWiki();
        }
    }
}
