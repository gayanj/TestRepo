using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using Msftlayer;

namespace JB.wap
{
    public partial class Searched : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Form.DefaultFocus = searchtext.UniqueID;
            Page.Form.DefaultButton = searchbutton.UniqueID;

            if (!IsPostBack)
            {
                if (Request.QueryString["q"] != null)
                {
                    //get pager 
                    int lowlimit = 0;
                    int pagesize = 10;

                    var titles = Server.HtmlEncode(Request.QueryString["q"]);
                    var cpfilt = new ClSearchFilters();

                    //var _countjobs = cpfilt.GetAllWapJobs();

                    if (titles != "ALL")
                    {
                        searchtext.Text = Request.QueryString["q"];
                        //bind the grid view with above criteria
                        var criterion = string.Empty;
                        JobGrid.DataSource = cpfilt.WapSearchByText(titles, "", lowlimit, pagesize);
                        JobGrid.DataBind();
                        int _maxrows = cpfilt.WapSearchByText(titles, "");
                        if (_maxrows == JobGrid.Rows.Count)
                        {
                            PageMore.Visible = false;
                        }
                        else { PageMore.Visible = true; }
                    }
                    else
                    {
                        //bind the gird with above criteria
                        //JobGrid.DataSource = cpfilt.Gettballsrchval();
                        JobGrid.DataSource = cpfilt.GetAllWapJobs(lowlimit, pagesize);
                        JobGrid.DataBind();
                        int _maxrows = cpfilt.GetAllWapJobs();
                        if (_maxrows == JobGrid.Rows.Count)
                        {
                            PageMore.Visible = false;
                        }
                        else { PageMore.Visible = true; }
                    }
                }
            }

            if (JobGrid.Rows.Count == 0)
            {
                LabelJobsFound.Text = "No Results Found!";
                LabelJobsFound.Visible = true;
                PageMore.Visible = false;
            }
        }

        protected void searchbutton_Click(object sender, EventArgs e)
        {
            if (searchtext.Text.Trim().Length > 1)
            {
                Response.Redirect("searched.aspx?q=" + searchtext.Text);
            }

            else
            {
                Response.Redirect("searched.aspx?q=ALL");
            }
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("searched.aspx?q=" + Server.HtmlEncode(Request.QueryString["q"]));
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("default.aspx");
        }

        protected void PageMore_Click(object sender, EventArgs e)
        {
            var _currcount = JobGrid.Rows.Count;

            if (Request.QueryString["q"] != null)
            {
                //get pager 
                int lowlimit = 0;
                //int maxpages = 0;

                int pagesize = 10 + _currcount;

                var titles = Server.HtmlEncode(Request.QueryString["q"]);
                var cpfilt = new ClSearchFilters();

                //var _countjobs = cpfilt.GetAllWapJobs();

                if (titles != "ALL")
                {
                    searchtext.Text = Request.QueryString["q"];
                    //bind the grid view with above criteria
                    var criterion = string.Empty;
                    JobGrid.DataSource = cpfilt.WapSearchByText(titles, "", lowlimit, pagesize);
                    JobGrid.DataBind();
                    int _maxrows = cpfilt.WapSearchByText(titles, "");
                    if (_maxrows == JobGrid.Rows.Count)
                    {
                        PageMore.Visible = false;
                    }
                    else { PageMore.Visible = true; }
                }

                else
                {
                    //bind the gird with above criteria
                    //JobGrid.DataSource = cpfilt.Gettballsrchval();
                    JobGrid.DataSource = cpfilt.GetAllWapJobs(lowlimit, pagesize);
                    JobGrid.DataBind();
                    int _maxrows = cpfilt.GetAllWapJobs();
                    if (_maxrows == JobGrid.Rows.Count)
                    {
                        PageMore.Visible = false;
                    }
                    else { PageMore.Visible = true; }
                }
            }

            if (JobGrid.Rows.Count == 0)
            {
                LabelJobsFound.Text = "No Results Found!";
                LabelJobsFound.Visible = true;
                PageMore.Visible = false;
            }
        }
    }
}