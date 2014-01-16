using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Msftlayer;

namespace JB.Facebook
{
    public partial class SearchJobs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {                         

                if (!IsPostBack)
                {
                    if (Request.QueryString["q"] != null)
                    {
                        TextBox1.Text = Request.QueryString["q"];
                    }

                    if (Request.QueryString["l"] != null)
                    {
                        TextBox2.Text = Request.QueryString["l"];
                    }

                    //get pager 
                    int lowlimit = 0;
                    int pagesize = 10;

                    var m = new ClFacebook();

                    int _maxrows = 0;

                    if (Request.QueryString["q"] != null && Request.QueryString["l"] != null)
                    {
                        _maxrows = m.GetJobsTotal(Request.QueryString["q"], Request.QueryString["l"], lowlimit, pagesize);

                        JobGrid.DataSource = m.GetJobs(Request.QueryString["q"], Request.QueryString["l"], lowlimit, pagesize);
                        JobGrid.DataBind();
                    }

                    else if (Request.QueryString["l"] != null)
                    {
                        _maxrows = m.GetJobsTotal(null, Request.QueryString["l"], lowlimit, pagesize);

                        JobGrid.DataSource = m.GetJobs(null, Request.QueryString["l"], lowlimit, pagesize);
                        JobGrid.DataBind();
                    }

                    else if (Request.QueryString["q"] != null)
                    {
                        _maxrows = m.GetJobsTotal(Request.QueryString["q"], null, lowlimit, pagesize);

                        JobGrid.DataSource = m.GetJobs(Request.QueryString["q"], null, lowlimit, pagesize);
                        JobGrid.DataBind();
                    }

                    else
                    {
                        _maxrows = m.GetJobsTotal(lowlimit, pagesize);

                        JobGrid.DataSource = m.GetJobs(lowlimit, pagesize);
                        JobGrid.DataBind();
                    }

                    LabelTotal.Text = _maxrows.ToString() + " jobs found...";

                    if (_maxrows == JobGrid.Rows.Count)
                    {
                        PageMore.Visible = false;
                    }
                    else { PageMore.Visible = true; }


                    if (JobGrid.Rows.Count == 0)
                    {
                        LabelJobsFound.Text = "No Results Found!";
                        LabelJobsFound.Visible = true;
                        PageMore.Visible = false;
                    }
                }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Trim() != "" && TextBox2.Text.Trim() != "")
            {
                Response.Redirect("home.aspx?q=" + TextBox1.Text.Trim() + "&l=" + TextBox2.Text.Trim());
            }

            else if (TextBox1.Text.Trim() != "")
            {
                Response.Redirect("home.aspx?q=" + TextBox1.Text.Trim());
            }

            else if (TextBox2.Text.Trim() != "")
            {
                Response.Redirect("home.aspx?l=" + TextBox2.Text.Trim());
            }

            else
            {
                Response.Redirect("home.aspx");
            }
        }

        protected void PageMore_Click(object sender, EventArgs e)
        {
            var _currcount = JobGrid.Rows.Count;

            //get pager 
            int lowlimit = 0;
            int pagesize = 10 + _currcount;

            var m = new ClFacebook();

            int _maxrows = 0;

            if (Request.QueryString["q"] != null && Request.QueryString["l"] != null)
            {
                _maxrows = m.GetJobsTotal(Request.QueryString["q"], Request.QueryString["l"], lowlimit, pagesize);

                JobGrid.DataSource = m.GetJobs(Request.QueryString["q"], Request.QueryString["l"], lowlimit, pagesize);
                JobGrid.DataBind();
            }

            else if (Request.QueryString["l"] != null)
            {
                _maxrows = m.GetJobsTotal(null, Request.QueryString["l"], lowlimit, pagesize);

                JobGrid.DataSource = m.GetJobs(null, Request.QueryString["l"], lowlimit, pagesize);
                JobGrid.DataBind();
            }

            else if (Request.QueryString["q"] != null)
            {
                _maxrows = m.GetJobsTotal(Request.QueryString["q"], null, lowlimit, pagesize);

                JobGrid.DataSource = m.GetJobs(Request.QueryString["q"], null, lowlimit, pagesize);
                JobGrid.DataBind();
            }

            else
            {
                _maxrows = m.GetJobsTotal(lowlimit, pagesize);

                JobGrid.DataSource = m.GetJobs(lowlimit, pagesize);
                JobGrid.DataBind();
            }

            LabelTotal.Text = _maxrows.ToString() + " jobs found...";

            if (_maxrows == JobGrid.Rows.Count)
            {
                PageMore.Visible = false;
            }
            else { PageMore.Visible = true; }


            if (JobGrid.Rows.Count == 0)
            {
                LabelJobsFound.Text = "No Results Found!";
                LabelJobsFound.Visible = true;
                PageMore.Visible = false;
            }

        }

        protected string GetRedir(object title, object id)
        {
            return "http://fashionquadrant.com/jobdetails?jobid=" + id + "&title=" + title;
        }
    }
}