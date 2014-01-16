using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Msftlayer;

namespace JB.Cms.Subsites
{
    public partial class AddSubsiteStep5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //get fonts
            var sid = new ClSubsite();

            DropDownFontHome.DataSource = sid.GetSubsiteFonts();
            DropDownFontHome.DataTextField = "fFontName";
            DropDownFontHome.DataValueField = "id_font";
            DropDownFontHome.DataBind();

            DropDownFontSearch.DataSource = sid.GetSubsiteFonts();
            DropDownFontSearch.DataTextField = "fFontName";
            DropDownFontSearch.DataValueField = "id_font";
            DropDownFontSearch.DataBind();

            DropDownFontSite.DataSource = sid.GetSubsiteFonts();
            DropDownFontSite.DataTextField = "fFontName";
            DropDownFontSite.DataValueField = "id_font";
            DropDownFontSite.DataBind();

        }

        protected void SaveAction_Click(object sender, EventArgs e)
        {
            var sid = new ClSubsite();
            var siteid = 0;

            if (Request.QueryString["siteid"] != null)
            {
                siteid = Convert.ToInt32(Server.HtmlEncode(Request.QueryString["siteid"]));
            }

            var filesvpath = System.Configuration.ConfigurationManager.AppSettings["subsiteimgpath"].ToLowerInvariant();
            var imagename = string.Empty;


            //////////////////////////////////////////////
            //global site wide customization
            //////////////////////////////////////////////
            var sitefont = DropDownFontSite.SelectedValue;

            //colors
            var sitetextcolor = TbSiteTextColor.Text;
            var sitefootertextcolor = TbSiteFooterTextColor.Text;


            ///////////////////////////////////////////////
            //main page
            ///////////////////////////////////////////////
            var mainpagefont = DropDownFontHome.SelectedValue;

            //colors
            var cattextcolor = TbCatTextColor.Text;
            var cattexthovercolor = TbCatTextHoverColor.Text;


            ///////////////////////////////////////////////
            //search page
            ///////////////////////////////////////////////
            var searchpagefont = DropDownFontSearch.SelectedValue;

            //colors
            var searchboxgbcolor = TbSearchBoxbgColor.Text;
            var searchresulttitlecolor = TbSearchResultTitle.Text;
            var searchresultdesccolor = TbSearchResultDesc.Text;
            var searchresultreccolor = TbSearchResultRecColor.Text;

            //save files to directory
            if (UploadSiteLogo.HasFile)
            {
                imagename = UploadSiteLogo.FileName;
                UploadSiteLogo.SaveAs(filesvpath + siteid + imagename);
                sid.InsertSubsiteImages(filesvpath + siteid + imagename, "SiteLogo", siteid);
            }
            else
            {
                sid.InsertSubsiteImages(null, "SiteLogo", siteid);
            }

            //site header
            if (UploadSiteHeader.HasFile)
            {
                imagename = UploadSiteHeader.FileName;
                UploadSiteHeader.SaveAs(filesvpath + siteid + imagename);
                sid.InsertSubsiteImages(filesvpath + siteid + imagename, "SiteHeader", siteid);
            }
            else
            {
                sid.InsertSubsiteImages(null, "SiteHeader", siteid);
            }

            //site footer
            if (UploadSiteFooter.HasFile)
            {
                imagename = UploadSiteFooter.FileName;
                UploadSiteFooter.SaveAs(filesvpath + siteid + imagename);
                sid.InsertSubsiteImages(filesvpath + siteid + imagename, "SiteFooter", siteid);
            }
            else
            {
                sid.InsertSubsiteImages(null, "SiteFooter", siteid);
            }

            //site background
            if (UploadSiteBackground.HasFile)
            {
                imagename = UploadSiteBackground.FileName;
                UploadSiteBackground.SaveAs(filesvpath + siteid + imagename);
                sid.InsertSubsiteImages(filesvpath + siteid + imagename, "SiteBackground", siteid);
            }
            else
            {
                sid.InsertSubsiteImages(null, "SiteBackground", siteid);
            }

            //category background
            if (UploadhpCatColor.HasFile)
            {
                imagename = UploadhpCatColor.FileName;
                UploadhpCatColor.SaveAs(filesvpath + siteid + imagename);
                sid.InsertSubsiteImages(filesvpath + siteid + imagename, "SiteCategoryBg", siteid);
            }
            else
            {
                sid.InsertSubsiteImages(null, "SiteCategoryBg", siteid);
            }

            //featured jobs background
            if (UploadFeaturedJobs.HasFile)
            {
                imagename = UploadFeaturedJobs.FileName;
                UploadFeaturedJobs.SaveAs(filesvpath + siteid + imagename);
                sid.InsertSubsiteImages(filesvpath + siteid + imagename, "SiteFeaturedJobsBg", siteid);
            }
            else
            {
                sid.InsertSubsiteImages(null, "SiteFeaturedJobsBg", siteid);
            }

            //search page side bar
            if (UploadSearchSidebar.HasFile)
            {
                imagename = UploadSearchSidebar.FileName;
                UploadSearchSidebar.SaveAs(filesvpath + siteid + imagename);
                sid.InsertSubsiteImages(filesvpath + siteid + imagename, "SiteSearchBarBg", siteid);
            }
            else
            {
                sid.InsertSubsiteImages(null, "SiteSearchBarBg", siteid);
            }



            //add theme colors
            sid.InsertSubsiteBrandColor(sitetextcolor, sitefootertextcolor, cattextcolor, cattexthovercolor, searchboxgbcolor, searchresulttitlecolor, searchresultdesccolor, searchresultreccolor, siteid);

            Response.Redirect("AddSubsiteStep6.aspx?siteid=" + siteid);
        }
    }
}