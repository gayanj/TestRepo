using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Msftlayer;

namespace JB.Cms.Subsites
{
    public partial class AddSubsite : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["edit"] != null && Request.QueryString["siteid"] != null)
            {
                if (Request.QueryString["edit"] == "1")
                {
                    //pull up the field
                    var sid = new ClSubsite();
                    var siteid = Convert.ToInt32(Server.HtmlEncode(Request.QueryString["siteid"]));
                    int checkvalue = sid.GetPageTemplate(siteid, 1);

                    if (checkvalue == 1)
                    {
                        RadioButton1.Checked = true;
                    }

                    else if (checkvalue == 2)
                    {
                        RadioButton2.Checked = true;
                    }

                    else
                    {
                        RadioButton3.Checked = true;
                    }
                }
            }
        }

        protected void SaveAction_Click(object sender, EventArgs e)
        {

            var template = 0;

            if (RadioButton1.Checked == true)
            {
                template = 1;
            }

            else if (RadioButton2.Checked == true)
            {
                template = 2;
            }

            else
            {
                template = 3;
            }

            var sid = new ClSubsite();
            var siteid = 0;
            if (Request.QueryString["siteid"] != null)
            {
                Convert.ToInt32(Server.HtmlEncode(Request.QueryString["siteid"]));
            }

            sid.UpdateMainPageTemplate(template, siteid);

            //check edits and redirect
            //check edits


            if (Request.QueryString["edit"] != null)
            {
                if (Request.QueryString["edit"] == "1")
                {
                    Response.Redirect("AddSubsiteStep3.aspx?siteid=" + siteid + "&edit=1");
                }
            }

            else
            {
                Response.Redirect("AddSubsiteStep3.aspx?siteid=" + siteid);
            }

        }
    }
}