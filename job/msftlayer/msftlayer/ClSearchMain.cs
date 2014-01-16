using System;
using System.Data;
using System.Text;
using Memorylayer;

namespace Msftlayer
{
    public class ClSearchMain
    {
        public string Searchmodif(string sqry)
        {
            string sqrys = sqry.Trim();
            char[] arrchar = { ' ' };
            string[] arrtmp = sqrys.Split(arrchar, StringSplitOptions.RemoveEmptyEntries);
            var sb = new StringBuilder();

            foreach (string str in arrtmp)
            {
                sb.Append("+");
                sb.Append(str);
                sb.Append(" ");
            }

            return sb.ToString();
        }

        public DataTable Getsitesearch(string qry)
        {
            var mlc = new MlSearchMain();
            return mlc.Getsitesearch(qry);
        }

        public object Mcjobtable()
        {
            var slsrch = new MlSearchMain();
            return slsrch.Mcjobtable();
        }

        public void Reloadmcjobstable()
        {
            var mlsrcls = new MlSearchMain();
            mlsrcls.Reloadmcjobstable();
        }
    }
}