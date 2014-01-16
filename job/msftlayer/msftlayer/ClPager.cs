using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Web.UI;

namespace Msftlayer
{
    public class ClPager : Page
    {
        public string CreatePageLinks(int totalRecords, int pageSize, string qry)
        {
            int totalPages = totalRecords / pageSize + (totalRecords % pageSize > 0 ? 1 : 0);
            const int totalNoLink = 5;

            if (totalRecords <= pageSize)
                return "";
            StringBuilder strPager = new StringBuilder();
            int currentPage = 1;
            string pageUrl = Context.Request.Url.AbsolutePath;
            if (Request.QueryString["page"] == null)
                currentPage = 1;
            if (Request.QueryString["page"] != null)
            {
                if (!int.TryParse(Request.QueryString["page"], out currentPage))
                    currentPage = 1;
                if (currentPage > totalPages)
                    currentPage = totalPages;
            }
            if (currentPage > 1)
                strPager.Append(string.Format("<a class=\"ux_newpage\" title=\"Previous page\" href=\"{1}?{2}&page={0}\"><</a>", (currentPage - 2) + 1, pageUrl, qry));
            int min, max;
            if (totalNoLink >= totalPages)
            {
                min = 1;
                max = totalPages;
            }
            else
            {
                if (currentPage - totalNoLink / 2 > 0)
                    max = (currentPage + totalNoLink / 2 - (totalNoLink - 1) % 2);
                else
                    max = totalNoLink;
                if (max > totalPages) max = totalPages;
                min = max - totalNoLink + 1 > 0 ? max - totalNoLink + 1 : 1;
            }
            for (int n = min; n <= max; n++)
            {
                if (n > totalPages)
                    break;
                if (n == currentPage)
                    strPager.Append(String.Format("<div class=\"ux_newpagecurr\">{0}</div>", n.ToString(CultureInfo.InvariantCulture)));
                else
                    strPager.Append(String.Format("<a class=\"ux_newpage\" title=\"{0}\" href=\"{2}?{3}&page={1}\">{0}</a> ", n, (n - 1) + 1, pageUrl, qry));
            }
            if (currentPage < totalPages)
                strPager.Append(String.Format("<a class=\"ux_newpage\" title=\"Next page\" href=\"{1}?{2}&page={0}\">></a>", currentPage + 1, pageUrl, qry));
            return strPager.ToString();
        }

    }
}
