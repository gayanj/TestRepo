using System;
using System.Collections;
using System.Globalization;
using System.Web.UI;
using System.Web.UI.WebControls;
using JB.Properties;
using Msftlayer;
using System.Web;

namespace JB
{
    public partial class Job : ClHtmlWrap
    {
        readonly string _cpath = System.Configuration.ConfigurationManager.AppSettings["httpspaths"].ToString(CultureInfo.InvariantCulture);

        //protected void Page_Error(object sender, EventArgs e)
        //{
        //    // Get the exception object.
        //    Exception exc = Server.GetLastError();

        //    var PageName = "";

        //    if (Request.Url.PathAndQuery != null)
        //    {
        //        PageName = Request.Url.PathAndQuery;
        //    }

        //    ClExceptionHandler _clh = new ClExceptionHandler();
        //    _clh.AddError(exc, PageName);

        //    // Clear the error from the server
        //    Server.ClearError();

        //    //redirect
        //    Server.Transfer("/jberror.aspx");
        //}

        protected void Page_Load(object sender, EventArgs e)
        {
            if (HiddenField1.Value != "6e97555a3158609611292")
            {
                Response.Redirect("/fraudfilters/fraudaction.aspx");
            }

            LabelPolicy.Text = "By using our site you explicitly accept our cookie usage policy listed under ";

            //check page loading time
            //start0.Text = "<!-- start time : " + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString() + ":" + DateTime.Now.Millisecond.ToString() + " -->";

            //local resources
            //debugme.Text = Resources.Job_Page_Load_Debugme;

            //set searchbox button
            //Paneltopslide.DefaultButton = SiteSearchButton.UniqueID;

            //set the searchbox for site
            if (Request.QueryString["track"] != null)
            {
                switch (Request.QueryString["track"])
                {
                    case "2":
                        TextBoxSearchSite.Visible = false;
                        SiteSearchButton.Visible = false;
                        break;
                }
            }

            //set languages
            //var clang = new ClLanguage();
            //var alist1 = (ArrayList)clang.Getlanguage();

            //var lba = new LinkButton { Text = @"EN", ID = "Lang0", CssClass = "ft_bluelink" };
            //lba.Attributes.Add("onmouseover", "this.className='ft_bluelink'");
            //lba.Attributes.Add("onmouseout", "this.className='ft_bluelinkwnodeco'");
            //lba.CausesValidation = false;
            //lba.Click += new EventHandler(Plholderclick);
            //PlaceHolderLang.Controls.Add(lba);

            /*
            for (var il = 0; il <= 3; il++)
            {
                var li = new Label { Text = @" | ", CssClass = "ft_blue" };
                //PlaceHolderLang.Controls.Add(li);

                var lb = new LinkButton { ID = "Lang" + (il + 1), Text = alist1[il].ToString(), CssClass = "ft_bluelink" };
                lb.CausesValidation = false;
                lb.Click += new EventHandler(Plholderclick);

                //PlaceHolderLang.Controls.Add(lb);
            }
             */

            var sladv = new ClAdverts();
            //set the top advert

            var alisti = sladv.Getmasterpagesiteads();
            var lbit1 = new Literal
                            {
                                Text =
                                    @"<a href=" + alisti[2] + @"><img border=""0"" width=""400"" height=""60"" src=" +
                                    alisti[1] + @" alt=""sponsored advertisements""/></a>"
                            };

            PlaceHolderheadbanner.Controls.Add(lbit1);
            alisti.Clear();

            //set stock bar items
            var alist2 = sladv.Getstockbarads();

            var lts1 = new Label { Text = " Sponsored: ", CssClass = "ft_black" };
            Panelstockbar.Controls.Add(lts1);

            for (var il1 = 0; il1 < alist2.Count; il1 += 3)
            {
                var imgs = new Image { ImageUrl = "/images/img_bull2.gif" };
                Panelstockbar.Controls.Add(imgs);

                var lnk1 = new HyperLink
                               {
                                   ID = "Stockbarad" + (il1),
                                   Text = alist2[il1].ToString(),
                                   NavigateUrl = alist2[il1 + 2].ToString(),
                                   CssClass = "ft_stock"
                               };
                
                Panelstockbar.Controls.Add(lnk1);
            }

            //cleanup
           // alist1.Clear();
            alist2.Clear();

            //set header links

            //set middle links
            var clcust = new ClCustomizeOption1();
            DataListmidlinks.DataSource = clcust.Getmiddlelinks();
            DataListmidlinks.DataBind();

            //set footer links
            DataListnfooter.DataSource = clcust.Getfooterlinks();
            DataListnfooter.DataBind();

            //set site pref
            //or site header
            var clpref = new ClSiteprefs();
            var lit = new Literal { Text = clpref.Getsitepref() };
            sitepref.Controls.Add(lit);

            //get user machine key I will use this later in code
            var machkey = Guid.NewGuid().ToString() + Guid.NewGuid().ToString();
            var litmachkey = new Literal { Text = @"<!-- machineid: " + machkey.Replace("-", "") + @"-->" };
            sitepref.Controls.Add(litmachkey);

            //set branding
            //checkcode
            //can be set to move from memory
            var clbr = new ClBranding();
            Page.Title = clbr.Getbrandoption("pagetitle");

            //set time
            Timesetlabel.Text = DateTime.Now.ToLongDateString();

            //LinkButton5.Visible = false;

            if (Session["pwelcomename"] != null)
            {
                //this is recruiter
                if (Session["isrecruiter"] != null)
                {
                    LinkButton1.Text = @" " + Session["pwelcomename"] + "'s cpanel";
                    LinkButton2.Visible = false;
                    LinkButton2.CssClass = "ft_graysimple";
                }

                //this is a normal user
                else
                {
                    LinkButton2.Text = @" " + Session["pwelcomename"] + "'s cpanel";
                    LinkButton1.Visible = false;
                    LinkButton1.CssClass = "ft_graysimple";
                }

                //check recruiters
            }

            //start1.Text = "<!-- start time : " + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString() + ":" + DateTime.Now.Millisecond.ToString() + " -->";
        }

        protected void Plholderclick(object sender, EventArgs e)
        {
            LinkButton lb = (LinkButton)sender;
            Session["language"] = lb.Text;
        }

        protected void LinkButton1Click(object sender, EventArgs e)
        {
            if (LinkButton1.Text.Contains("cpanel"))
            {
                Response.Redirect("/Recruiters/RecHome.aspx");
            }

            else
            {
                Response.Redirect("/Recruiters/Login.aspx");
            }
        }

        protected void LinkButton2Click(object sender, EventArgs e)
        {
            if (LinkButton2.Text.Contains("cpanel"))
            {
                Response.Redirect("/JobSeekers/JobSeekerHome.aspx");
            }

            else
            {
                Response.Redirect("/JobSeekers/Login.aspx");
            }
        }

        protected void ImageButton1Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("/Default.aspx");
        }

        protected void LinkButton3Click(object sender, EventArgs e)
        {
            Response.Redirect("/Default.aspx");
        }

        protected void SiteSearchButtonClick(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("/sitesearch?track=2&q=" + Server.HtmlEncode(TextBoxSearchSite.Text));
        }
    }
}