using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Msftlayer;

namespace JB.Cms.Subsites
{
    public partial class AddSubsiteStep6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SaveAction_Click(object sender, EventArgs e)
        {
            var siteid = 0;

            if (Request.QueryString["siteid"] != null)
            {
              siteid =  Convert.ToInt32(Request.QueryString["siteid"]);
            }

            int flginsideheader = 0;
            int flgchecksearchcat = 0;
            int flgsearchtop = 0;
            int flgsearchbottom = 0;
            int flgrightsearchright = 0;

            string scriptmptext = Server.HtmlEncode(MainPageAdvert.Text);
            string scriptsptext = Server.HtmlEncode(SearchPageAdvert.Text);
            string scriptaptext = Server.HtmlEncode(DetailPageAdvert.Text);

            if (CheckHeader.Checked == true) { flginsideheader = 1; }
            if (CheckSearchbottom.Checked == true) { flgsearchbottom = 1; }
            if (CheckSearchCat.Checked == true) { flgchecksearchcat = 1; }
            if (CheckSearchRight.Checked == true) { flgrightsearchright = 1; }
            if (CheckSearchtop.Checked == true) { flgsearchtop = 1; }

            var clrb = new ClSubsite();

            if (Request.QueryString["edit"] != null)
            {
                if (Request.QueryString["edit"] == "1")
                {
                    //update db for subsites
                    clrb.UpdateSubsiteAds(scriptmptext, scriptsptext, scriptaptext, flginsideheader, flgrightsearchright, flgchecksearchcat, flgsearchtop, flgsearchbottom, siteid);
                }
            }

            else
            {
                //insert it for search page.
                clrb.InsertSubsiteAds(scriptmptext, scriptsptext, scriptaptext, flginsideheader, flgrightsearchright, flgchecksearchcat, flgsearchtop, flgsearchbottom, siteid);
            }

            //redirect to subsite home.
            Response.Redirect("/cms/CmsSubsiteAll.aspx");

        }
    }
}