using Memorylayer;
using System.Data;
using System.Collections;

namespace Msftlayer
{
    public class ClSubsite
    {
        public void Insertcandata(string username, string pwd, string firstname, string lastname, string telephone,
                                  string website, string gender, string address1, string address2, string address3,
                                  string town, string county, string postcode, string country, string city,
                                  string employername, string employerlocation, string employerposition,
                                  string employerjobdescription, string educationschoolname, string educationtype,
                                  string educationdegree, string educationyear, string educationconcentration,
                                  string spokenlang1, string spokenlang2, string spokenlang3, string hobbies)
        {
            var mlsub = new MlSubsite();
            mlsub.Insertcandata(username, pwd, firstname, lastname, telephone, website, gender, address1, address2,
                                address3, town, county, postcode, country, city, employername, employerlocation,
                                employerposition, employerjobdescription, educationschoolname, educationtype,
                                educationdegree, educationyear, educationconcentration, spokenlang1, spokenlang2,
                                spokenlang3, hobbies);
        }

        public string Getuserexitid(string webuserid)
        {
            var mlsub = new MlSubsite();
            return mlsub.Getuserexitid(webuserid);
        }

        /*
        public string GetSubsiteMax()
        {
            var sid = new Mlsubsite();
            return sid.GetSubsiteMax();
        }
         */

        public int GetSubsiteId(string sitename)
        {
            var sid = new MlSubsite();
            return sid.GetSubsiteId(sitename);
        }

        public void InsertSubsite(string sitename, string siteurl, int iscname, string siteid)
        {
            var sid = new MlSubsite();
            sid.InsertSubsite(sitename, siteurl, iscname, siteid);
        }

        public void UpdateSubsite(string sitename, string siteurl, int iscname, int siteid)
        {
            var sid = new MlSubsite();
            sid.UpdateSubsite(sitename, siteurl, iscname, siteid);
        }

        public string[] GetSubsiteName(int siteid)
        {
            var sid = new MlSubsite();
            return sid.GetSubsiteName(siteid);
        }

        public void UpdateSearchPageTemplate(int templateid, int siteid)
        {
            var sid = new MlSubsite();
            sid.UpdateSearchPageTemplate(templateid, siteid);
        }

        public void UpdateMainPageTemplate(int templateid, int siteid)
        {
            var sid = new MlSubsite();
            sid.UpdateMainPageTemplate(templateid, siteid);
        }

        public int GetPageTemplate(int siteid, int sitetype)
        {
            var sid = new MlSubsite();
            int tempstore = 0;

            if (sitetype == 1)
            {
                //main page              
                tempstore = sid.GetMainPageTemplate(siteid);
            }

            else
            {
                //search page                
                tempstore = sid.GetSearchPageTemplate(siteid);
            }

            return tempstore;
        }

        public void InsertSubsiteCat(string category, int siteid)
        {
            var sid = new MlSubsite();
            sid.InsertSubsiteCat(category, siteid);
        }

        public DataTable GetSubsiteCat(int siteid)
        {
            var sid = new MlSubsite();
            return sid.GetSubsiteCat(siteid);
        }

        public ArrayList GetSubsiteCatListView(int siteid)
        {
            var sid = new MlSubsite();
            return sid.GetSubsiteCatListView(siteid);
        }

        public ArrayList GetSubsiteSubCatListView(int siteid, int catid)
        {
            var sid = new MlSubsite();
            return sid.GetSubsiteSubCatListView(siteid, catid);
        }

        public void DeleteSubsiteCat(int siteid, int catid)
        {
            var sid = new MlSubsite();
            sid.DeleteSubsiteCat(siteid, catid);
        }

        public void DeleteSubsiteSubCat(int siteid, int subcatid, int catid)
        {
            var sid = new MlSubsite();

            sid.DeleteSubsiteCatLookup(catid, subcatid);
            sid.DeleteSubsiteSubCat(siteid, subcatid);
        }

        /*
        public string GetSubsiteSubcatsId()
        {
            var sid = new Mlsubsite();
            return sid.GetSubsiteSubcatsId();
        }
         */

        public void InsertSubsiteCatLinks(int catid, string subcatid)
        {
            var sid = new MlSubsite();
            sid.InsertSubsiteCatLinks(catid, subcatid);
        }

        public void InsertSubsiteSubcat(string subcatid, string subcatname)
        {
            var sid = new MlSubsite();
            sid.InsertSubsiteSubcat(subcatid, subcatname);
        }

        public void InsertSubsiteBrandColor(string tColor1, string tColor2, string tColor3, string tColor4, string tColor5, string tColor6, string tColor7, string tColor8, int siteid)
        {
            var sid = new MlSubsite();
            sid.InsertSubsiteBrandColor(tColor1, tColor2, tColor3, tColor4, tColor5, tColor6, tColor7, tColor8, siteid);
        }

        //handle ads
        public void InsertSubsiteAds(string mainpagescript, string searchpagescript, string applicationpagescript, int isonheader, int isonrightpanel, int isonsearchcat, int isonsearchtop, int isonsearchbottom, int idsubsite)
        {
            var sid = new MlSubsite();
            sid.InsertSubsiteAds(mainpagescript, searchpagescript, applicationpagescript, isonheader, isonrightpanel, isonsearchcat, isonsearchtop, isonsearchbottom, idsubsite);
        }

        public void UpdateSubsiteAds(string mainpagescript, string searchpagescript, string applicationpagescript, int isonheader, int isonrightpanel, int isonsearchcat, int isonsearchtop, int isonsearchbottom, int idsubsite)
        {
            var sid = new MlSubsite();
            sid.UpdateSubsiteAds(mainpagescript, searchpagescript, applicationpagescript, isonheader, isonrightpanel, isonsearchcat, isonsearchtop, isonsearchbottom, idsubsite);
        }

        //get fonts
        public DataTable GetSubsiteFonts()
        {
            MlSubsite mlsub = new MlSubsite();
            return mlsub.GetSubsiteFonts();
        }

        //set images
        public void InsertSubsiteImages(string iURL, string iImageName, int idsubsite)
        {
            var sid = new MlSubsite();
            sid.InsertSubsiteImages(iURL, iImageName, idsubsite);
        }

        //get images
        public string[] GetSubsiteImages(int subsiteid)
        {
            var sid = new MlSubsite();
            return sid.GetSubsiteImages(subsiteid);
        }

        /*Update Statement*/
        public void UpdatetbSubsiteImages(string iURL, string iImageName, int idsubsite)
        {
            MlSubsite mid = new MlSubsite();
            mid.UpdatetbSubsiteImages(iURL, iImageName, idsubsite);
        }

    }
}