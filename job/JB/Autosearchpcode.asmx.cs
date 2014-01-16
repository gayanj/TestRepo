using System.Collections;
using System.Web.Services;
using Msftlayer;

namespace JB
{
    [WebService(Namespace = "http://postcode.fashionquadrant.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.Web.Script.Services.ScriptService]

    public class Autosearchpcode : WebService
    {
        public Autosearchpcode()
        {
        }

        [WebMethod]
        public string[] GetCompletionList(string prefixText, int count)
        {
            switch (count)
            {
                case 0:
                    count = 10;
                    break;
            }

            var items = new ArrayList();

            //loop here to get items
            var clauto = new ClMemLoad();
            var temparr = (ArrayList)clauto.Mcgetpostcodes();

            var j = 0;
            var i = 1;
            var indexs = 1;

            for (var xsi = 0; xsi < temparr.Count; xsi += 2)
            {
                var cultureinv = temparr[indexs].ToString().ToLower();
                var ind = cultureinv.StartsWith(prefixText.ToLower());
                indexs++;

                if (j < 10)
                {
                    switch (ind)
                    {
                        case true:
                            items.Add(temparr[i].ToString());
                            j++;
                            ind = false;
                            break;
                    }
                }
                i++;
            }

            var arrl = new string[items.Count];
            var ei = 0;

            foreach (string sitem in items)
            {
                arrl[ei] = sitem;
                ei++;
            }

            temparr.Clear();
            items.Clear();

            return arrl;
        }
    }
}