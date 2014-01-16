using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using Msftlayer;

namespace JB.wap
{
    public partial class Browse : System.Web.UI.Page
    {
        private void DoSearch(int __ispaged)
        {
            var cpfilt = new ClSearchFilters();

            //get pager 
            int lowlimit = 0;
            int pagesize = 10;

            if (__ispaged == 1)
            {
                var _currcount = JobGrid.Rows.Count;
                pagesize = 10 + _currcount;
            }

            var _count = cpfilt.GetAllWapJobs();

            var __list = 0;

            if (Request.QueryString["list"] != null)
            {
                __list = Convert.ToInt16(Request.QueryString["list"]);
            }

            switch (Request.QueryString["lev"])
            {
                case "1":
                    {
                        var _qry = Server.HtmlEncode(Request.QueryString["qry"]);
                        var __items = Convert.ToInt32(Server.HtmlEncode(Request.QueryString["item"]));
                        browselist1.DataSource = cpfilt.CategoryBrowser(__items, 0, _qry, __list);
                        browselist1.DataBind();

                        JobGrid.DataSource = cpfilt.WapLevelCat(__items, lowlimit, pagesize);
                        JobGrid.DataBind();
                        int _tempcount = cpfilt.WapLevelCat(__items);

                        if (_tempcount == JobGrid.Rows.Count)
                        {
                            PageMore.Visible = false;
                        }

                        else { PageMore.Visible = true; }
                    }
                    break;
                case "2":
                    {
                        var _qry = Server.HtmlEncode(Request.QueryString["qry"].Trim());
                        var __items = Convert.ToInt32(Server.HtmlEncode(Request.QueryString["item"]));
                        browselist1.DataSource = cpfilt.CategoryBrowser(__items, 1, _qry, __list);
                        browselist1.DataBind();

                        var _lev = Convert.ToInt16(Request.QueryString["lev"]);

                      
                        JobGrid.DataSource = cpfilt.WapLevelItems(__list, _lev, lowlimit, pagesize);
                        JobGrid.DataBind();
                        int _tempcount = cpfilt.WapLevelItems(__list, _lev);

                        if (_tempcount == JobGrid.Rows.Count)
                        {
                            PageMore.Visible = false;
                        }

                        else { PageMore.Visible = true; }
                    }
                    break;
                case "3":
                    {
                        var _qry = Server.HtmlEncode(Request.QueryString["qry"]);
                        var __items = Convert.ToInt32(Server.HtmlEncode(Request.QueryString["item"]));
                        browselist1.DataSource = cpfilt.CategoryBrowser(__items, 2, _qry, __list);
                        browselist1.DataBind();

                        var _lev = Convert.ToInt16(Request.QueryString["lev"]);

                        JobGrid.DataSource = cpfilt.WapLevelItems(__list, _lev, lowlimit, pagesize);
                        JobGrid.DataBind();
                        int _tempcount = cpfilt.WapLevelItems(__list, _lev);

                        if (_tempcount == JobGrid.Rows.Count)
                        {
                            PageMore.Visible = false;
                        }

                        else { PageMore.Visible = true; }
                    }
                    break;
                case "4":
                    {
                        var _qry = Server.HtmlEncode(Request.QueryString["qry"]);
                        var __items = Convert.ToInt32(Server.HtmlEncode(Request.QueryString["item"]));
                        browselist1.DataSource = cpfilt.CategoryBrowser(__items, 3, _qry, __list);
                        browselist1.DataBind();

                        var _lev = Convert.ToInt16(Request.QueryString["lev"]);

                        JobGrid.DataSource = cpfilt.WapLevelItems(__list, _lev, lowlimit, pagesize);
                        JobGrid.DataBind();
                        int _tempcount = cpfilt.WapLevelItems(__list, _lev);

                        if (_tempcount == JobGrid.Rows.Count)
                        {
                            PageMore.Visible = false;
                        }

                        else { PageMore.Visible = true; }
                    }
                    break;
                default:
                    browselist1.DataSource = cpfilt.Getdefaultbrall();
                    browselist1.DataBind();
                    JobGrid.DataSource = cpfilt.GetAllWapJobs(lowlimit, pagesize);
                    JobGrid.DataBind();
                    int _maxrows = cpfilt.GetAllWapJobs();
                    if (_maxrows == JobGrid.Rows.Count)
                    {
                        PageMore.Visible = false;
                    }
                    else { PageMore.Visible = true; }
                    break;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DoSearch(0);
            }

            if (JobGrid.Rows.Count == 0)
            {
                LabelJobsFound.Text = "No Results Found!";
                LabelJobsFound.Visible = true;
                PageMore.Visible = false;
            }
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            #region browsecontrolactions
            
            if (Convert.ToInt16(Request.QueryString["lev"]) < 4)
            {
                //work around for leveling subcats
                var lb = (LinkButton)sender;

                int _templev = Convert.ToInt16(Request.QueryString["lev"]) + 1;
                Response.Redirect("browse.aspx?qry=" + lb.Text + "&lev=" + _templev + "&item=" + lb.CommandArgument);
            }

            #endregion browsecontrolactions
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("default.aspx");
        }

        protected void PageMore_Click(object sender, EventArgs e)
        {
            DoSearch(1);
        }

        protected string GetUrl(object cat, object subcat)
        {
            if (subcat.ToString() != "")
            {
                return cat.ToString() + "&list=" + subcat.ToString();
            }

            else
            {
                return cat.ToString();
            }

        }

    }
}