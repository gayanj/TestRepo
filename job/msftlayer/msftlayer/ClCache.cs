using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Memorylayer;

namespace Msftlayer
{
    public class ClCache
    {
        public void firecache()
        {
            var clman = new MLMemCached();

            try
            {
                clman.Fireservers();
            }

            catch
            {

            }
        }
    }
}
