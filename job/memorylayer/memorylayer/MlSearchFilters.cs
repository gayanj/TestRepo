using System;
using System.Configuration;
using System.Data;
using Mysqllayer;

namespace Memorylayer
{
    public class MlSearchFilters
    {
        /// <summary>
        /// one eye search
        /// (*)
        /// </summary>
        /// <returns></returns>
        ///

        public int CaseBrowseGridAll()
        {
            var slf = new SlSearchfilters();
            return slf.CaseBrowseGridAll();
        }

        public int Casebrowsergrid(string criterion)
        {
            var _cs = new SlSearchfilters();
            return _cs.Casebrowsergrid(criterion);
        }

        public DataTable Casebrowsergrid(string criterion, int _low, int _high)
        {
            var slf = new SlSearchfilters();
            return slf.Casebrowsergrid(criterion, _low, _high);
        }

        public DataTable Casebrowserfilter(string criterion)
        {
            var slf = new SlSearchfilters();
            return slf.Casebrowserfilter(criterion);
        }

        public int CaseallCount()
        {
            var slf = new SlSearchfilters();
            return slf.CaseallCount();
        }

        public DataTable Caseall(int _low, int _high)
        {
            var slf = new SlSearchfilters();
            return slf.Caseall(_low, _high);
        }

        public int CaseWithCheckBoxes(string criterion)
        {
            var slf = new SlSearchfilters();
            return slf.CaseWithCheckBoxes(criterion);
        }

        public DataTable CaseWithCheckBoxes(string criterion, int low, int high)
        {
            var slf = new SlSearchfilters();
            return slf.CaseWithCheckBoxes(criterion, low, high);
        }

        public int Casewochkbox(string criterion)
        {
            var slf = new SlSearchfilters();
            return slf.Casewochkbox(criterion);
        }

        public DataTable Casewochkbox(string criterion, int _low, int _high)
        {
            var slf = new SlSearchfilters();
            return slf.Casewochkbox(criterion, _low, _high);
        }

        /// <summary>
        /// old search
        /// </summary>
        public DataSet Getsearchbydate(string titles, string postcode, string addedcrit, string company,
                                       string dt, string qry)
        {
            var srch = new SlSearchfilters();
            return srch.Getsearchbydate(titles, postcode, addedcrit, company, dt, qry);
        }

        public DataSet Getsearchbycompany(string titles, string postcode, string addedcrit, string company,
                                          string qry)
        {
            var srch = new SlSearchfilters();
            return srch.Getsearchbycompany(titles, postcode, addedcrit, company, qry);
        }

        public DataSet Getsearchbypostcode(string titles, string postcode, string addedcrit)
        {
            var srch = new SlSearchfilters();
            return srch.Getsearchbypostcode(titles, postcode, addedcrit);
        }

        public DataSet Getsearchbypostcode(string postcode)
        {
            var srch = new SlSearchfilters();
            return srch.Getsearchbypostcode(postcode);
        }

        public DataSet Getsearchbypostcode(string postcode, string addedcrit)
        {
            var srch = new SlSearchfilters();
            return srch.Getsearchbypostcode(postcode, addedcrit);
        }

        public DataTable Singlesearchsmatch(string ftsearch)
        {
            var srch = new SlSearchfilters();
            return srch.Singlesearchsmatch(ftsearch);
        }

        public DataTable Getgriditeml2(int itemid)
        {
            var srch = new SlSearchfilters();
            return srch.Getgriditeml2(itemid);
        }

        public void Reloadgettballsrchval()
        {
            var clman = new MLMemCached();
            //try
            //{
            //    clman.Fireservers();
            //}
            //catch (Exception e)
            //{
            //    Console.Write(e.Message);
            //}

            var srch = new SlSearchfilters();
            //clman.revmemc("mchomepgloc");
            clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcgettballsrchval", srch.Gettballsrchval());
        }

        public object Gettballsrchval()
        {
            var clman = new MLMemCached();
            //try
            //{
            //    clman.Fireservers();
            //}
            //catch (Exception e)
            //{
            //    Console.Write(e.Message);
            //}

            object mrec = clman.Getmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcgettballsrchval");

            if (mrec != null)
            {
                DateTime mcrsststamp =
                    Convert.ToDateTime(clman.Getmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcdaytstamp6"));
                if (mcrsststamp == DateTime.Now.Date)
                {
                    return mrec;
                }
                else
                {
                    //add a time stamp for refreshing memory
                    clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcdaytstamp6", DateTime.Now.Date);

                    //add to memory array
                    var srch = new SlSearchfilters();
                    clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcgettballsrchval",
                                     srch.Gettballsrchval());
                    mrec = srch.Gettballsrchval();
                    return mrec;
                }
            }

            else
            {
                //add a time stamp for refreshing memory
                clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcdaytstamp6", DateTime.Now.Date);

                //add to memory object
                var srch = new SlSearchfilters();
                clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcgettballsrchval",
                                 srch.Gettballsrchval());
                mrec = srch.Gettballsrchval();
                return mrec;
            }

            //SLSearchfilters srch = new SLSearchfilters();
            //return srch.gettballsrchval();
        }

        public object Getdefaultbrall()
        {
            var clman = new MLMemCached();
            //try
            //{
            //    clman.Fireservers();
            //}
            //catch (Exception e)
            //{
            //    Console.Write(e.Message);
            //}

            object mrec = clman.Getmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcgetdefaultbrall");

            if (mrec != null)
            {
                int mcrsststamp =
                    Convert.ToInt32(clman.Getmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mchrtstamp3"));
                if (mcrsststamp == DateTime.Now.Hour)
                {
                    return mrec;
                }
                else
                {
                    //add a time stamp for refreshing memory
                    clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mchrtstamp3", DateTime.Now.Hour);

                    //add to memory array
                    var srch = new SlSearchfilters();
                    clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcgetdefaultbrall",
                                     srch.Getdefaultbrall());
                    mrec = srch.Getdefaultbrall();
                    return mrec;
                }
            }

            else
            {
                //add a time stamp for refreshing memory
                clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mchrtstamp3", DateTime.Now.Hour);

                //add to memory object
                var srch = new SlSearchfilters();
                clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcgetdefaultbrall",
                                 srch.Getdefaultbrall());
                mrec = srch.Getdefaultbrall();
                return mrec;
            }

            //SLSearchfilters srch = new SLSearchfilters();
            //return srch.getdefaultbrall();
        }

        //reload broswe complete
        public void Reloadsearchbrall()
        {
            var clman = new MLMemCached();
            //try
            //{
            //    clman.Fireservers();
            //}
            //catch (Exception e)
            //{
            //    Console.Write(e.Message);
            //}

            var srch = new SlSearchfilters();
            //clman.revmemc("mchomepgloc");
            clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcgetdefaultbrall", srch.Getdefaultbrall());
        }

        public DataTable Getdefaulttxtcat(string ftsearch)
        {
            var srch = new SlSearchfilters();
            return srch.Getdefaulttxtcat(ftsearch);
        }

        public DataTable Getgridsetitems(int itemid)
        {
            var srch = new SlSearchfilters();
            return srch.Getgridsetitems(itemid);
        }

        public DataTable WapLevel2(int itemid, int _lev, int low, int high)
        {
            var srch = new SlSearchfilters();
            return srch.WapLevel2(itemid, _lev, low, high);
        }

        public int WapLevel2(int itemid, int _lev)
        {
            var srch = new SlSearchfilters();
            return srch.WapLevel2(itemid, _lev);
        }

        public DataTable WapLevelItems(int itemid, int _lev, int low, int high)
        {
            var srch = new SlSearchfilters();
            return srch.WapLevelItems(itemid, _lev, low, high);
        }

        public int WapLevelItems(int itemid, int _lev)
        {
            var srch = new SlSearchfilters();
            return srch.WapLevelItems(itemid, _lev);
        }


        public DataTable WapLevelCat(int itemid, int low, int high)
        {
            var srch = new SlSearchfilters();
            return srch.WapLevelCat(itemid, low, high);
        }

        public int WapLevelCat(int itemid)
        {
            var srch = new SlSearchfilters();
            return srch.WapLevelCat(itemid);
        }

        //public DataTable dpbrowseitem(int itemid)
        //{
        //    SLSearchfilters srch = new SLSearchfilters();
        //    return srch.dpbrowseitem(itemid);
        //}

        //this part handles browsing control bar
        //get filtered / searched values
        //get data for browsing categories :: main cats

        public int BrowseCheck(int catid, string qry)
        {
            var s = new SlSearchfilters();
            return s.BrowseCheck(catid, qry);
        }

        public string BrowseCheck(int _listid)
        {
            var s = new SlSearchfilters();
            return s.BrowseCheck(_listid);
        }

        public DataSet Dpbrowse(string valuein)
        {
            var clsearch = new SlSearchfilters();
            return clsearch.Dpbrowse(valuein);
        }

        //this is for subcats
        public object CategoryBrowser()
        {
            var clman = new MLMemCached();
            //try
            //{
            //    clman.Fireservers();
            //}
            //catch (Exception e)
            //{
            //    Console.Write(e.Message);
            //}

            object mrec = clman.Getmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcdpbrowsecatgs");

            if (mrec != null)
            {
                DateTime mcrsststamp =
                    Convert.ToDateTime(clman.Getmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcdaytstamp8"));
                if (mcrsststamp.Date == DateTime.Now.Date)
                {
                    return mrec;
                }
                else
                {
                    //add a time stamp for refreshing memory
                    clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcdaytstamp8", DateTime.Now.Date);

                    //add to memory array
                    var srch = new SlSearchfilters();
                    clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcdpbrowsecatgs",
                                     srch.CategoryBrowser());
                    mrec = srch.CategoryBrowser();
                    return mrec;
                }
            }

            else
            {
                //add a time stamp for refreshing memory
                clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcdaytstamp8", DateTime.Now.Date);

                //add to memory object
                var srch = new SlSearchfilters();
                clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcdpbrowsecatgs", srch.CategoryBrowser());
                mrec = srch.CategoryBrowser();
                return mrec;
            }
            //SLSearchfilters clsearch = new SLSearchfilters();
            //return clsearch.CategoryBrowser(cat);
        }

        //get filtered / searched values
        public DataSet Applytitlefilter(string titles, string addedcrit)
        {
            var clsearch = new SlSearchfilters();
            return clsearch.Applytitlefilter(titles, addedcrit);
        }

        //apply browse filter on searchgrid
        //get filtered / searched values

        public DataSet Applygridfilter(string addedcrit)
        {
            var clsearch = new SlSearchfilters();
            return clsearch.Applygridfilter(addedcrit);
        }

        //get results returned by the Query
        public int Getsearchcounts(string titles, string addedcrit)
        {
            var clsearch = new SlSearchfilters();
            return clsearch.Getsearchcounts(titles, addedcrit);
        }

        //New Paging
        //wap
        public int GetAllWapJobs()
        {
            SlSearchfilters s = new SlSearchfilters();
            return s.GetAllWapJobs();
        }

        public DataTable GetAllWapJobs(int _lowlimit, int _highlimit)
        {
            SlSearchfilters s = new SlSearchfilters();
            return s.GetAllWapJobs(_lowlimit, _highlimit);
        }

        public DataTable WapSearchByText(string ftsearch, int _lowlimit, int _highlimit)
        {
            SlSearchfilters s = new SlSearchfilters();
            return s.WapSearchByText(ftsearch, _lowlimit, _highlimit);
        }

        public int WapSearchByText(string ftsearch)
        {
            SlSearchfilters s = new SlSearchfilters();
            return s.WapSearchByText(ftsearch);
        }

        public DataTable GetWapTextWBars(int itemid, int _lowlimit, int _highlimit)
        {
            SlSearchfilters s = new SlSearchfilters();
            return s.GetWapTextWBars(itemid, _lowlimit, _highlimit);
        }

        public int GetWapTextWBars(int itemid)
        {
            SlSearchfilters s = new SlSearchfilters();
            return s.GetWapTextWBars(itemid);
        }
    }
}