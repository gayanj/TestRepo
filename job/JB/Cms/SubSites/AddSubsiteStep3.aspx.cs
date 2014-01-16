using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Msftlayer;

namespace JB.Cms.Subsites
{
    public partial class AddSubsiteStep3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["edit"] != null && Request.QueryString["siteid"] != null)
            {
                if (Request.QueryString["edit"] == "1")
                {
                    var sid = new ClSubsite();
                    var siteid = Convert.ToInt32(Server.HtmlEncode(Request.QueryString["siteid"]));

                    int checkvalue = sid.GetPageTemplate(siteid, 2);

                    if (checkvalue == 1)
                    {
                        RadioButton1.Checked = true;
                    }
                }
            }          
        }

        protected void SaveAction_Click(object sender, EventArgs e)
        {
            var template = 0;
            var siteid = 0;

            if (Request.QueryString["siteid"] != null)
            {
                Convert.ToInt32(Server.HtmlEncode(Request.QueryString["siteid"]));
            }

            var sid = new ClSubsite();
            sid.UpdateSearchPageTemplate(template, siteid);

            if (Request.QueryString["edit"] != null)
            {
                if (Request.QueryString["edit"] == "1")
                {
                    Response.Redirect("AddSubsiteStep4.aspx?siteid=" + siteid + "&edit=1");
                }
            }

            else
            {
                Response.Redirect("AddSubsiteStep4.aspx?siteid=" + siteid);
            }
          
        }

        protected void CancelAction_Click(object sender, EventArgs e)
        {

        }
    }
}