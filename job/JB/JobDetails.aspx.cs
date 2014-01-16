using System;
using System.Globalization;
using System.Web;
using System.Web.UI.WebControls;
using Msftlayer;

namespace JB
{
    public partial class Jobdetails : System.Web.UI.Page
    {
        protected void Marketboxevent(object sender, EventArgs e)
        {
            var tlink = (LinkButton)sender;
            var tlinkjobid = tlink.ID.Replace("marketbox", "");

            //get title for job
            var cljcart = new ClJobCart();
            var temptitle = cljcart.Getjobscart(tlinkjobid).Replace(" ", "-").Replace("--", "-");

            Response.Redirect("/jobdetails?jobid=" + tlinkjobid + "&jobtitle=" + temptitle.ToLower());
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            var mpage = new ClMainPagePopulator();
            var clplug = new ClPlugins();

            if (Request.QueryString["jobid"] != null)
            {
                //set share this
                Labelsharethis.Text = Server.HtmlDecode(clplug.Getpluginsharethis());

                string tempjobid = Server.HtmlEncode(Request.QueryString["jobid"]);

                //add iframe
                try
                {
                    #region marketbasket

                    //set market baskets
                    var clmarket = new ClMiner();

                    var tempcreader = string.Empty;

                    if (Request.QueryString["jobtitle"] != null)
                    {
                        tempcreader = Server.HtmlEncode(Request.QueryString[1].Replace("-", " "));
                    }
                    string[,] tempmarket = clmarket.Getmarketbasket(tempcreader);

                    for (var imkt = 0; imkt < 4; imkt++)
                    {
                        if (tempmarket[1, imkt] != null && tempmarket[0, imkt] != tempjobid.ToString(CultureInfo.InvariantCulture))
                        {
                            var lb = new LinkButton
                                         {
                                             ID = "marketbox" + tempmarket[0, imkt],
                                             Text =
                                                 (tempmarket[1, imkt].Length > 30)
                                                     ? tempmarket[1, imkt].Substring(0, 30) + "..."
                                                     : tempmarket[1, imkt] + "..."
                                         };
                            lb.Click += new EventHandler(Marketboxevent);
                            lb.CssClass = "ft_bluelink";
                            Marketbasketdetail.Controls.Add(lb);

                            var lit = new Literal
                                          {
                                              Text =
                                                  "<div class='ln_fixx4'></div><div class='ln_ccc'></div><div class='ln_fixx4'></div>"
                                          };
                            Marketbasketdetail.Controls.Add(lit);
                        }
                    }

                    //market baskets end here

                    #endregion marketbasket
                }
                catch (Exception e1)
                {
                    Server.ClearError();

                    ClExceptionHandler _clh = new ClExceptionHandler();
                    _clh.AddError(e1, "/jobdetail?category=e1");
                }

                try
                {
                    #region videolookup

                    var jobid = Request.QueryString["jobid"];
                    var clvid = new ClVideo();
                    var vidarr = clvid.Getvideo(jobid);

                    if (vidarr != null)
                    {
                        var ili1 = new Literal { Text = "<br /><div class=\"smap_lefts\">" };

                        var label4 = new Label { ID = "oLabel4", Text = "Attached Videos" };

                        var ili2 = new Literal
                                       {
                                           Text =
                                               "</div><div class=\"dv_fix\"></div><div class=\"tb_headone\"></div><div class=\"ln_fixx4\"></div><div class=\"dv_fix\"></div><div class=\"ln_444\"></div><iframe width=\"200\" height=\"200\" src=\"" +
                                               vidarr[1].ToString(CultureInfo.InvariantCulture) + "\" frameborder=\"0\" allowfullscreen></iframe>"
                                       };
                        //ili2.Text = "</div><div class=\"ln_fixx4\"></div><div class=\"dv_fix\"></div><div class=\"ln_444\"></div><iframe type=\"text/html\" src=\"" + vidarr[1].ToString() + "\"  width=\"200\" height=\"200\" frameborder=\"0\"></iframe>";

                        Marketbasketdetail.Controls.Add(ili1);
                        Marketbasketdetail.Controls.Add(label4);
                        Marketbasketdetail.Controls.Add(ili2);
                    }

                    #endregion videolookup
                }

                catch (Exception e2)
                {
                    Server.ClearError();

                    ClExceptionHandler _clh = new ClExceptionHandler();
                    _clh.AddError(e2, "/jobdetail?category=e2");
                }

                var plc = mpage.Getdetailspage(tempjobid);

                try
                {
                    Label32.Text = plc[0];
                    Label26.Text = plc[1];
                    Label18.Text = plc[2];
                    Label31.Text = plc[6];
                    Label21.Text = plc[4];
                }

                catch (Exception e3)
                {
                    Server.ClearError();

                    ClExceptionHandler _clh = new ClExceptionHandler();
                    _clh.AddError(e3, "/jobdetail?category=e3");
                }

                try
                {
                    var culinf = new CultureInfo("pt-BR");
                    Label23.Text = Convert.ToDateTime(plc[3]).ToString("d", culinf);

                    //get locations
                    Label19.Text = mpage.Getdetailspagecats(tempjobid, 1000);

                    //get industries
                    LabelIndustries.Text = mpage.Getdetailspagecats(tempjobid, 1001);

                    //get salary
                    Label20.Text = mpage.Getdetailspagecats(tempjobid, 1005, 0);

                    //get contract type
                    Label22.Text = mpage.Getdetailspagecats(tempjobid, 1002);

                    //get hours
                    Label30.Text = mpage.Getdetailspagecats(tempjobid, 1003);

                    //get employer types
                    Label3.Text = mpage.Getdetailspagecats(tempjobid, 1004);

                    //get sectors
                    Labelsectors.Text = mpage.Getdetailspagecats(tempjobid, 1006);

                    //get education level
                    Labeleducation.Text = mpage.Getdetailspagecats(tempjobid, 1008);

                    //get career
                    Labelcareer.Text = mpage.Getdetailspagecats(tempjobid, 1007);
                }
                catch (Exception e4)
                {
                    Server.ClearError();

                    ClExceptionHandler _clh = new ClExceptionHandler();
                    _clh.AddError(e4, "/jobdetail?category=e4");
                }

                try
                {
                    //get rec logo
                    var recid = plc[7];
                    Image7.ImageUrl = mpage.Getcurrrec(recid);

                    //get contact person name if any
                    var contactpname = string.Empty;

                    var rcl2 = new ClRecruiters();

                    if (Request.QueryString["jobid"] != null)
                    {
                        contactpname = rcl2.Contactperson(Server.HtmlEncode(Request.QueryString["jobid"]));
                        if (contactpname != "")
                        {
                            Label27.Text = contactpname;
                        }
                    }


                    //update job views for recruiter graph

                    var cljb = new ClJobViewData();
                    cljb.Insertjobview(recid, DateTime.Now);
                }
                catch (Exception e5)
                {
                    Server.ClearError();

                    ClExceptionHandler _clh = new ClExceptionHandler();
                    _clh.AddError(e5, "/jobdetail?category=e5");
                }
            }
        }

        protected void Button2Click(object sender, EventArgs e)
        {

            Response.Redirect("/applicationoptions?jobid=" + Request.QueryString["jobid"]);

        }

        protected void Button1Click(object sender, EventArgs e)
        {
            Response.Redirect("/reportapage?pageid=" + Request.QueryString[0]);
        }

        protected void JdprevjobClick(object sender, EventArgs e)
        {
            var tempjid = Server.HtmlEncode(Request.QueryString["jobid"]);
            //get max jobid
            var cjobs = new ClJobs();
            var mnpgid = cjobs.Getprevjobid(tempjid);

            if (mnpgid != string.Empty)
            {
                //get title for job
                var cljcart = new ClJobCart();
                var temptitle = cljcart.Getjobscart(mnpgid);
                temptitle = temptitle.Replace(" ", "-").Replace("--", "-").Replace("--", "-");
                Response.Redirect("/jobdetails?jobid=" + mnpgid + "&jobtitle=" + temptitle.ToLower());
            }
        }

        protected void JdnextjobClick(object sender, EventArgs e)
        {
            string tempjid = Server.HtmlEncode(Request.QueryString["jobid"]);

            //get max jobid
            var cjobs = new ClJobs();
            var mxpgid = cjobs.Getnextjobid(tempjid);

            if (mxpgid != string.Empty)
            {
                //get title for job
                var cljcart = new ClJobCart();
                var temptitle = cljcart.Getjobscart(mxpgid);
                temptitle = temptitle.Replace(" ", "-").Replace("--", "-").Replace("--", "-");
                Response.Redirect("/jobdetails?jobid=" + mxpgid + "&jobtitle=" + temptitle.ToLower());
            }
        }

        //custom functions
        public string Readcookies(string cookieName)
        {
            var myCookie = new HttpCookie(cookieName);
            myCookie = Request.Cookies[cookieName];

            // Read the cookie information and return it.
            if (myCookie != null)
            {
                return myCookie.Value;
            }
            else
            {
                return null;
            }
        }

        protected void LinkButton1Click(object sender, EventArgs e)
        {
            Response.Redirect("/emailtofriend?jobid=" + Request.QueryString["jobid"] + "&jobtitle=" + Request.QueryString["jobtitle"]);
        }
    }
}