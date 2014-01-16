using System;
using System.Globalization;
using System.Web.UI.WebControls;
using Msftlayer;

namespace JB.Recruiters
{
    public partial class Editjobs : ClCookie
    {
        public string GetUrl(object idjob)
        {
            return "/recruiters/jobform.aspx?jobid=" + idjob;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //read and validate login
            Isuserloginvalid();

            if (!IsPostBack)
            {
                string _ruser = string.Empty;

                if (Session["pusername"] != null)
                {
                    ClRecruiters cl = new ClRecruiters();

                    string _r = Session["pusername"].ToString();
                    _ruser = cl.GetRecbyUserName(_r);
                }

                //active
                var cljb = new ClJobs();

                //archived
                Labelarchived.Text = "[" + cljb.Getarcjobs(_ruser) + "]";
                Labelactive.Text = "[" + cljb.Getacjobs(_ruser) + "]";


                if (!IsPostBack)
                {
                    if (Request.QueryString["type"] != null)
                    {
                        if (Request.QueryString["type"] == "1")
                        {

                            //bind jobs
                            GridView1.DataSource = cljb.GetActiveJobs(_ruser);
                            GridView1.DataBind();
                        }

                        else
                        {

                            //bind jobs
                            GridView1.DataSource = cljb.GetArchJobs(_ruser);
                            GridView1.DataBind();
                        }
                    }

                    else
                    {

                        //bind jobs
                        GridView1.DataSource = cljb.GetActiveJobs(_ruser);
                        GridView1.DataBind();
                    }
                }
            }

        }

        protected void LinkButton4Click(object sender, EventArgs e)
        {
            Response.Redirect("/recruiters/editjobs.aspx?type=1");
        }

        protected void LinkButton5Click(object sender, EventArgs e)
        {
            Response.Redirect("/recruiters/editjobs.aspx?type=2");
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            string _ruser = string.Empty;

            if (Session["pusername"] != null)
            {
                ClRecruiters cl = new ClRecruiters();

                string _r = Session["pusername"].ToString();
                _ruser = cl.GetRecbyUserName(_r);
            }

            //active
            var cljb = new ClJobs();

            //archived
            Labelarchived.Text = "[" + cljb.Getarcjobs(_ruser) + "]";
            Labelactive.Text = "[" + cljb.Getacjobs(_ruser) + "]";



            if (Request.QueryString["type"] != null)
            {
                if (Request.QueryString["type"] == "1")
                {

                    //bind jobs
                    GridView1.DataSource = cljb.GetActiveJobs(_ruser);
                    GridView1.PageIndex = e.NewPageIndex;
                    GridView1.DataBind();
                }

                else
                {

                    //bind jobs
                    GridView1.DataSource = cljb.GetArchJobs(_ruser);
                    GridView1.PageIndex = e.NewPageIndex;
                    GridView1.DataBind();
                }
            }

            else
            {

                //bind jobs
                GridView1.DataSource = cljb.GetActiveJobs(_ruser);
                GridView1.PageIndex = e.NewPageIndex;
                GridView1.DataBind();
            }
        }

    }
}