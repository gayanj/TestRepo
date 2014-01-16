using Mysqllayer;
using System.Data;
using System.Collections;

namespace Memorylayer
{
    public class MlSubsite
    {
        public void Insertcandata(string username, string pwd, string firstname, string lastname, string telephone,
                                  string website, string gender, string address1, string address2, string address3,
                                  string town, string county, string postcode, string country, string city,
                                  string employername, string employerlocation, string employerposition,
                                  string employerjobdescription, string educationschoolname, string educationtype,
                                  string educationdegree, string educationyear, string educationconcentration,
                                  string spokenlang1, string spokenlang2, string spokenlang3, string hobbies)
        {
            var slsub = new SlSubsite();
            slsub.Insertcandata(username, pwd, firstname, lastname, telephone, website, gender, address1, address2,
                                address3, town, county, postcode, country, city, employername, employerlocation,
                                employerposition, employerjobdescription, educationschoolname, educationtype,
                                educationdegree, educationyear, educationconcentration, spokenlang1, spokenlang2,
                                spokenlang3, hobbies);
        }

        public string Getuserexitid(string webuserid)
        {
            var slsub = new SlSubsite();
            return slsub.Getuserexitid(webuserid);
        }

        /*
        public string GetSubsiteMax()
        {
            var sid = new Slsubsite();
            return sid.GetSubsiteMax();
        }
         */

        public int GetSubsiteId(string sitename)
        {
            var sid = new SlSubsite();
            return sid.GetSubsiteId(sitename);
        }

        public void InsertSubsite(string sitename, string siteurl, int iscname, string siteid)
        {
            var sid = new SlSubsite();
            sid.InsertSubsite(sitename, siteurl, iscname, siteid);
        }

        public void UpdateSubsite(string sitename, string siteurl, int iscname, int siteid)
        {
            var sid = new SlSubsite();
            sid.UpdateSubsite(sitename, siteurl, iscname, siteid);
        }

        public string[] GetSubsiteName(int siteid)
        {
            var sid = new SlSubsite();
            return sid.GetSubsiteName(siteid);
        }

        public void UpdateSearchPageTemplate(int templateid, int siteid)
        {
            var sid = new SlSubsite();
            sid.UpdateSearchPageTemplate(templateid, siteid);
        }

        public void UpdateMainPageTemplate(int templateid, int siteid)
        {
            var sid = new SlSubsite();
            sid.UpdateMainPageTemplate(templateid, siteid);
        }

        public int GetMainPageTemplate(int siteid)
        {
            var sid = new SlSubsite();
            return sid.GetMainPageTemplate(siteid);
        }

        public int GetSearchPageTemplate(int siteid)
        {
            var sid = new SlSubsite();
            return sid.GetSearchPageTemplate(siteid);
        }

        public void InsertSubsiteCat(string category, int siteid)
        {
            var sid = new SlSubsite();
            sid.InsertSubsiteCat(category, siteid);
        }

        public DataTable GetSubsiteCat(int siteid)
        {
            var sid = new SlSubsite();
            return sid.GetSubsiteCat(siteid);
        }

        public ArrayList GetSubsiteCatListView(int siteid)
        {
            var sid = new SlSubsite();
            return sid.GetSubsiteCatListView(siteid);
        }

        public ArrayList GetSubsiteSubCatListView(int siteid, int catid)
        {
            var sid = new SlSubsite();
            return sid.GetSubsiteSubCatListView(siteid, catid);
        }

        public void DeleteSubsiteCat(int siteid, int catid)
        {
            var sid = new SlSubsite();
            sid.DeleteSubsiteCat(siteid, catid);
        }

        public void DeleteSubsiteCatLookup(int catid, int subcatid)
        {
            var sid = new SlSubsite();
            sid.DeleteSubsiteCatLookup(catid, subcatid);
        }

        public void DeleteSubsiteSubCat(int siteid, int subcatid)
        {
            var sid = new SlSubsite();
            sid.DeleteSubsiteSubCat(siteid, subcatid);
        }

        /*
        public string GetSubsiteSubcatsId()
        {
            var sid = new Slsubsite();
            return sid.GetSubsiteSubcatsId();
        }
         */

        public void InsertSubsiteCatLinks(int catid,string subcatid)
        {
            var sid = new SlSubsite();
            sid.InsertSubsiteCatLinks(catid, subcatid);
        }

        public void InsertSubsiteSubcat(string subcatid, string subcatname)
        {
            var sid = new SlSubsite();
            sid.InsertSubsiteSubcat(subcatid, subcatname);
        }

        public void InsertSubsiteBrandColor(string tColor1, string tColor2, string tColor3, string tColor4, string tColor5, string tColor6, string tColor7, string tColor8, int siteid)
        {
            var sid = new SlSubsite();
            sid.InsertSubsiteBrandColor(tColor1, tColor2, tColor3, tColor4, tColor5, tColor6, tColor7, tColor8, siteid);
        }

        //handle ads
        public void InsertSubsiteAds(string mainpagescript, string searchpagescript, string applicationpagescript, int isonheader, int isonrightpanel, int isonsearchcat, int isonsearchtop, int isonsearchbottom, int idsubsite)
        {
            var sid = new SlSubsite();
            sid.InsertSubsiteAds(mainpagescript, searchpagescript, applicationpagescript, isonheader, isonrightpanel, isonsearchcat, isonsearchtop, isonsearchbottom, idsubsite);
        }

        public void UpdateSubsiteAds(string mainpagescript, string searchpagescript, string applicationpagescript, int isonheader, int isonrightpanel, int isonsearchcat, int isonsearchtop, int isonsearchbottom, int idsubsite)
        {
            var sid = new SlSubsite();
            sid.UpdateSubsiteAds(mainpagescript, searchpagescript, applicationpagescript, isonheader, isonrightpanel, isonsearchcat, isonsearchtop, isonsearchbottom, idsubsite);
        }

        //get fonts
        public DataTable GetSubsiteFonts()
        {
            SlSubsite slsub = new SlSubsite();
            return slsub.GetSubsiteFonts();
        }

        //set images
        public void InsertSubsiteImages(string iURL, string iImageName, int idsubsite)
        {
            var sid = new SlSubsite();
            sid.InsertSubsiteImages(iURL, iImageName, idsubsite);
        }

        //get images
        public string[] GetSubsiteImages(int subsiteid)
        {
            var sid = new SlSubsite();
            return sid.GetSubsiteImages(subsiteid);
        }

        /*Update Statement*/
        public void UpdatetbSubsiteImages(string iURL, string iImageName, int idsubsite)
        {
            SlSubsite sid = new SlSubsite();
            sid.UpdatetbSubsiteImages(iURL, iImageName, idsubsite);
        }

    }
}