using System.Data;
using Memorylayer;
using System.Text;

namespace Msftlayer
{
    public class ClSearchFilters
    {
        /// <summary>
        /// one eye search
        /// </summary>
        /// <returns></returns>
        ///

        public int CaseBrowseGridAll()
        {
            var slf = new MlSearchFilters();
            return slf.CaseBrowseGridAll();
        }

        public int Casebrowsergrid(string criterion)
        {
            var _cs = new MlSearchFilters();
            return _cs.Casebrowsergrid(criterion);
        }

        public DataTable Casebrowsergrid(string criterion, int _low, int _high)
        {
            var slf = new MlSearchFilters();
            return slf.Casebrowsergrid(criterion, _low, _high);
        }

        public DataTable Casebrowserfilter(string criterion)
        {
            var slf = new MlSearchFilters();
            return slf.Casebrowserfilter(criterion);
        }

        public int CaseallCount()
        {
            var slf = new MlSearchFilters();
            return slf.CaseallCount();
        }

        public DataTable Caseall(int _lowlimit, int _highlimit)
        {
            var mls = new MlSearchFilters();
            return mls.Caseall(_lowlimit, _highlimit);
        }

        public int CaseWithCheckBoxes(string criterion)
        {
            var slf = new MlSearchFilters();
            return slf.CaseWithCheckBoxes(criterion);
        }

        public DataTable CaseWithCheckBoxes(string criterion, int low, int high)
        {
            var mls = new MlSearchFilters();
            return mls.CaseWithCheckBoxes(criterion, low, high);
        }

        public int Casewochkbox(string criterion)
        {
            var slf = new MlSearchFilters();
            return slf.Casewochkbox(criterion);
        }

        public DataTable Casewochkbox(string criterion, int _low, int _high)
        {
            var mls = new MlSearchFilters();
            return mls.Casewochkbox(criterion, _low, _high);
        }

        /// <summary>
        /// old search
        /// </summary>
        public DataSet Getsearchbydate(string titles, string postcode, string addedcrit, string company,
                                       string dtval, string usercity)
        {
            string qry = "select * from vw_applytitlefilter where match (sfreetext) against ('" + titles +
                          "' IN NATURAL LANGUAGE MODE ) and spostcode like '%" + postcode + "%' and Company like '%" +
                          company + "%'" + addedcrit;
            string _dt = string.Empty;

            switch (dtval)
            {
                case "12002":
                    _dt = "curdate()-1";
                    qry = qry + " and dtentereddate = " + _dt + " limit 500";
                    break;
                case "12003":
                    _dt = "curdate()-3";
                    qry = qry + " and dtentereddate >= " + _dt + " limit 500";
                    break;
                case "12004":
                    _dt = "curdate()-7";
                    qry = qry + " and dtentereddate >= " + _dt + " limit 500";
                    break;
                case "12005":
                    _dt = "curdate()-30";
                    qry = qry + " and dtentereddate >= " + _dt + " limit 500";
                    break;
                default:
                    _dt = "curdate()";
                    qry = qry + " and dtentereddate = " + _dt + " limit 500";
                    break;
            }

            //now for the title filters
            switch (titles)
            {
                case "":
                    qry = qry.Replace("match (sfreetext) against ('' IN NATURAL LANGUAGE MODE ) and", "");
                    break;
            }

            switch (postcode)
            {
                case "":
                    qry = qry.Replace("spostcode like '%%' and", "");
                    break;
            }

            switch (company)
            {
                case "":
                    qry = qry.Replace("Company like '%%' and", "");
                    break;
            }

            qry = qry + usercity;

            var srch = new MlSearchFilters();
            return srch.Getsearchbydate(titles, postcode, addedcrit, company, _dt, qry);
        }

        public DataSet Getsearchbycompany(string titles, string postcode, string addedcrit, string company,
                                          string usercity)
        {
            string qry = "select * from vw_applytitlefilter where match (sfreetext) against ('" + titles +
                          "' IN NATURAL LANGUAGE MODE ) and spostcode like '%" + postcode + "%' and Company like '%" +
                          company + "%'" + addedcrit + " limit 500";
            bool flg = false;

            if (titles == "")
            {
                qry = qry.Replace("match (sfreetext) against ('' IN NATURAL LANGUAGE MODE ) and", "");
                flg = true;
            }

            if (postcode == "")
            {
                if (flg)
                {
                    qry = qry.Replace(" spostcode like '%%' and", "");
                }

                else
                {
                    qry = qry.Replace("and spostcode like '%%'", "");
                }
            }

            qry = qry + usercity;

            var srch = new MlSearchFilters();
            return srch.Getsearchbycompany(titles, postcode, addedcrit, company, qry);
        }

        public DataSet Getsearchbypostcode(string titles, string postcode, string addedcrit, string usercity)
        {
            var srch = new MlSearchFilters();
            addedcrit = addedcrit + usercity;
            return srch.Getsearchbypostcode(titles, postcode, addedcrit);
        }

        public DataSet Getsearchbypostcode(string postcode, string overide, string usercity)
        {
            var srch = new MlSearchFilters();
            postcode = postcode + usercity;
            return srch.Getsearchbypostcode(postcode);
        }

        public DataSet Getsearchbypostcode(string postcode, string addedcrit)
        {
            addedcrit = addedcrit.Replace("where", "");
            var srch = new MlSearchFilters();
            return srch.Getsearchbypostcode(postcode, addedcrit);
        }

        public DataTable Singlesearchsmatch(string ftsearch, string usercity)
        {
            var srch = new MlSearchFilters();
            ftsearch = ftsearch + " " + usercity;
            return srch.Singlesearchsmatch(ftsearch);
        }

        public DataTable Getgriditeml2(int itemid)
        {
            var srch = new MlSearchFilters();

            return srch.Getgriditeml2(itemid);
        }

        public void Reloadgettballsrchval()
        {
            var srch = new MlSearchFilters();
            srch.Reloadgettballsrchval();
        }

        public void Reloadsearchbrall()
        {
            var srch = new MlSearchFilters();
            srch.Reloadsearchbrall();
        }

        public object Gettballsrchval()
        {
            var srch = new MlSearchFilters();
            return srch.Gettballsrchval();
        }

        public object Getdefaultbrall()
        {
            var srch = new MlSearchFilters();
            return srch.Getdefaultbrall();
        }

        public DataTable Getdefaulttxtcat(string ftsearch)
        {
            var srch = new MlSearchFilters();
            return srch.Getdefaulttxtcat(ftsearch);
        }

        public DataTable Getgridsetitems(int itemid)
        {
            var srch = new MlSearchFilters();
            return srch.Getgridsetitems(itemid);
        }

        public DataTable WapLevel2(int itemid, int _level, int low, int high)
        {
            var srch = new MlSearchFilters();
            return srch.WapLevel2(itemid, _level, low, high);
        }

        public int WapLevel2(int itemid, int _level)
        {
            var srch = new MlSearchFilters();
            return srch.WapLevel2(itemid, _level);
        }

        public DataTable WapLevelItems(int itemid, int _lev, int low, int high)
        {
            var srch = new MlSearchFilters();
            return srch.WapLevelItems(itemid, _lev, low, high);
        }

        public int WapLevelItems(int itemid, int _lev)
        {
            var srch = new MlSearchFilters();
            return srch.WapLevelItems(itemid, _lev);
        }

        public DataTable WapLevelCat(int itemid, int low, int high)
        {
            var srch = new MlSearchFilters();
            return srch.WapLevelCat(itemid, low, high);
        }

        public int WapLevelCat(int itemid)
        {
            var srch = new MlSearchFilters();
            return srch.WapLevelCat(itemid);
        }

        public DataView Dpbrowseitem(int itemid)
        {
            var mlsearch = new MlSearchFilters();
            var dview = new DataView { Table = (DataTable)mlsearch.CategoryBrowser(), RowFilter = "subcatid = '" + itemid + "'" };

            return dview;
        }

        //this part handles browsing control bar
        //get filtered / searched values
        //get data for browsing categories :: main cats

        public DataSet Dpbrowse(string valuein)
        {
            var mlsearch = new MlSearchFilters();
            return mlsearch.Dpbrowse(valuein);
        }

        //this is for subcats
        public DataView CategoryBrowser(string cat)
        {
            var mlsearch = new MlSearchFilters();
            var dview = new DataView { Table = (DataTable)mlsearch.CategoryBrowser(), RowFilter = "cdefinition = '" + cat + "'" };

            return dview;
        }

        public int BrowseCheck(int catid, string qry)
        {
            var m = new MlSearchFilters();
            return m.BrowseCheck(catid, qry);
        }

        public string BrowseCheck(int listid)
        {
            var m = new MlSearchFilters();
            return m.BrowseCheck(listid);
        }

        public DataView CategoryBrowser(int cat, int parent, string qry, int list)
        {
            var mlsearch = new MlSearchFilters();

            //donot download too much data on mobile device
            //use queries later

            //check children if yes give data else redirect to x
            if (parent < 1)
            {
                var dview = new DataView { Table = (DataTable)mlsearch.CategoryBrowser(), RowFilter = "viewcatid = " + cat + " AND liparent = " + parent };
                return dview;
            }

            else
            {
                if (mlsearch.BrowseCheck(list) != "" && list != 0)
                {
                    var dview = new DataView { Table = (DataTable)mlsearch.CategoryBrowser(), RowFilter = mlsearch.BrowseCheck(list) };
                    return dview;
                }

                if (mlsearch.BrowseCheck(cat, qry) == 1)
                {
                    var dview = new DataView { Table = (DataTable)mlsearch.CategoryBrowser(), RowFilter = "viewcatid = " + cat + " AND liparent = " + parent };
                    return dview;
                }

                else
                {
                    var dview = new DataView { Table = (DataTable)mlsearch.CategoryBrowser(), RowFilter = "viewcatid = " + cat + " AND sdefinition = '" + qry + "'" };
                    return dview;
                }
            }

        }

        //get filtered / searched values
        public DataSet Applytitlefilter(string titles, string addedcrit, string usercity)
        {
            var mlsearch = new MlSearchFilters();
            addedcrit = addedcrit + usercity;

            return mlsearch.Applytitlefilter(titles, addedcrit);
        }

        //apply browse filter on searchgrid
        //get filtered / searched values

        public DataSet Applygridfilter(string addedcrit)
        {
            var mlsearch = new MlSearchFilters();
            return mlsearch.Applygridfilter(addedcrit);
        }

        //get results returned by the Query
        public int Getsearchcounts(string titles, string addedcrit)
        {
            var mlsearch = new MlSearchFilters();
            return mlsearch.Getsearchcounts(titles, addedcrit);
        }

        //New Paging
        //wap
        public int GetAllWapJobs()
        {
            MlSearchFilters m = new MlSearchFilters();
            return m.GetAllWapJobs();
        }

        public DataTable GetAllWapJobs(int _lowlimit, int _highlimit)
        {
            MlSearchFilters m = new MlSearchFilters();
            return m.GetAllWapJobs(_lowlimit, _highlimit);
        }

        public DataTable WapSearchByText(string ftsearch, string usercity, int _lowlimit, int _highlimit)
        {
            ftsearch = ftsearch + " " + usercity;
            MlSearchFilters m = new MlSearchFilters();
            return m.WapSearchByText(ftsearch, _lowlimit, _highlimit);
        }

        public int WapSearchByText(string ftsearch, string usercity)
        {
            ftsearch = ftsearch + " " + usercity;
            MlSearchFilters m = new MlSearchFilters();
            return m.WapSearchByText(ftsearch);
        }

        public DataTable GetWapTextWBars(int itemid, int _lowlimit, int _highlimit)
        {
            MlSearchFilters s = new MlSearchFilters();
            return s.GetWapTextWBars(itemid, _lowlimit, _highlimit);
        }

        public int GetWapTextWBars(int itemid)
        {
            MlSearchFilters s = new MlSearchFilters();
            return s.GetWapTextWBars(itemid);
        }
    }
}