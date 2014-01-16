using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Memorylayer;

namespace Msftlayer
{
    public class ClCmsWiki
    {
        public DataSet GetWiki()
        {
            var _wiki = new MlCmsWiki();
            return _wiki.GetWiki();
        }
    }
}
