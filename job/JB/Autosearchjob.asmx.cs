using System.Collections;
using System.Web.Services;
using Msftlayer;

namespace JB
{
    [WebService(Namespace = "http://jobs.fashionquadrant.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.Web.Script.Services.ScriptService]

    public class Autosearchjob : WebService
    {
        public Autosearchjob()
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
            var clauto = new CLAutoComplete();

            var temparr = (ArrayList)clauto.Getsearchjobcp();
            var j = 0;
            var i = 1;

            foreach (string st in temparr)
            {
                var cultureinv = st.ToLower();
                var ind = cultureinv.StartsWith(prefixText.ToLower());

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