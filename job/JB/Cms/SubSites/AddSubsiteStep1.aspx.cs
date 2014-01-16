using System;
using Msftlayer;
using minGuid;

namespace JB.Cms.Subsites
{
    public partial class AddSubsiteStep1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["edit"] != null && Request.QueryString["siteid"] != null)
            {
                if (Request.QueryString["edit"] == "1")
                {
                    //pull up site by id
                    var sid = new ClSubsite();

                    string[] sar = sid.GetSubsiteName(Convert.ToInt32(Server.HtmlEncode(Request.QueryString["siteid"])));

                    TextBox1.Text = sar[0];
                    TextBoxURL.Text = sar[1];

                    if (sar[2] == "1")
                    {
                        CheckBoxSubdomain.Checked = true;
                    }

                    else
                    {
                        CheckBoxSubdomain.Checked = false;
                    }
                }
            }
        }

        protected void SaveAction_Click(object sender, EventArgs e)
        {
            //for new site pass siteid = 0;

            //insert subsite
            var sid = new ClSubsite();
            var siteid = 0;
            var checkexistsite = sid.GetSubsiteId(Server.HtmlEncode(TextBox1.Text));

            if (Request.QueryString["siteid"] != null)
            {
                siteid = Convert.ToInt32(Server.HtmlEncode(Request.QueryString["siteid"]));
            }

            var sitename = Server.HtmlEncode(TextBox1.Text);
            string siteurl = TextBoxURL.Text;
            int checkcname = 0;

            if (CheckBoxSubdomain.Checked == true) { checkcname = 1; };

            if (Request.QueryString["edit"] != null)
            {
                if (Request.QueryString["edit"] == "1")
                {
                    //update site name
                    sid.UpdateSubsite(sitename, siteurl, checkcname, siteid);

                    Response.Redirect("AddSubsiteStep2.aspx?siteid=" + siteid + "&edit=1");
                }
            }

            else
            {
                //newsite
                if (checkexistsite == 0)
                {
                    var mguid = new Minimumguid();

                    //get max site id
                    string maxsiteid = mguid.MinGuid();

                    sid.InsertSubsite(sitename, siteurl, checkcname, maxsiteid);
                    //finally redirect
                    Response.Redirect("AddSubsiteStep2.aspx?siteid=" + maxsiteid);
                }

                else
                {
                    //subsite already exists display message

                }
            }

        }
    }
}