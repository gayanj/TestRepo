using System;
using System.Globalization;
using System.Web.UI.WebControls;
using Msftlayer;

namespace JB
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.IsSecureConnection)
            {
                Response.Redirect(System.Configuration.ConfigurationManager.AppSettings["httppaths"].ToString(CultureInfo.InvariantCulture));
            }

            if (!IsPostBack)
            {
                //set default button etc
                searchtext.Focus();
                Page.Form.DefaultButton = DefButton1.UniqueID;

                //get articles list
                var cart = new ClArticles();
                Articlelist.DataSource = cart.Getallartlist();
                Articlelist.DataBind();

                var cfr = new ClFeaturedRecruiters();
                recshufflegrid.DataSource = cfr.Getrecofweek();
                recshufflegrid.DataBind();

                var clhme = new ClHome();

                //bind locations
                Locationlist.DataSource = clhme.Gethplocation();
                Locationlist.DataBind();

                //bind industry
                Industrylist.DataSource = clhme.Gethpindustry();
                Industrylist.DataBind();

                //bind salary
                Salarylist.DataSource = clhme.Gethpsalary();
                Salarylist.DataBind();
            }
        }

        protected void LinksalaryPress(object sender, EventArgs e)
        {
            var lb = (LinkButton)sender;
            Response.Redirect("/searched.aspx?qry=" + lb.Text + "&lev=2&item=1005&list=" + lb.CommandArgument);
        }

        protected void LinklocationPress(object sender, EventArgs e)
        {
            var lb = (LinkButton)sender;
            Response.Redirect("/searched.aspx?qry=" + lb.Text + "&lev=2&item=1000&list=" + lb.CommandArgument);
        }

        protected void LinkindustryPress(object sender, EventArgs e)
        {
            var lb = (LinkButton)sender;
            Response.Redirect("/searched.aspx?qry=" + lb.Text + "&lev=2&item=1001&list=" + lb.CommandArgument);
        }

        protected void SearchbuttonClick(object sender, EventArgs e)
        {
            Session["currip"] = Request.ServerVariables["REMOTE_ADDR"];

            if (TargetCurrent.Checked == true)
            {
                switch (searchtext.Text.Length)
                {
                    case 0:
                        Response.Redirect("/search?q=ALL&i=1");
                        break;
                    default:
                        Response.Redirect("/search?q=" + searchtext.Text + "&i=1");
                        break;
                }
            }

            else
            {
                switch (searchtext.Text.Length)
                {
                    case 0:
                        Response.Redirect("/search?q=ALL");
                        break;
                    default:
                        Response.Redirect("/search?q=" + searchtext.Text);
                        break;
                }
            }
        }

        protected void LinksalaryClick(object sender, EventArgs e)
        {
            var lb = (LinkButton)sender;
            Response.Redirect("/articles?articleid=" + lb.CommandArgument);
        }
    }
}