using System;
using System.Globalization;
using System.Web.UI.WebControls;
using Msftlayer;

namespace JB
{
    public partial class Jobsbyrecruiter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.IsSecureConnection)
            {
                Response.Redirect(System.Configuration.ConfigurationManager.AppSettings["httppaths"].ToString(CultureInfo.InvariantCulture) + "/jobsbyrecruiter");
            }

            if (!IsPostBack && Request.QueryString["empid"] != null)
            {
                string qry = Server.HtmlEncode(Request.QueryString["empid"]);
                var rcl = new ClRecruiters();
                Gridjobsbyrec.DataSource = rcl.Getrecwithjobs(qry);
                Gridjobsbyrec.DataBind();

                //get data
                var temparr = rcl.Getrecbyidstrarr(qry);
                rTitle.Text = temparr[0];
                rDescription.Text = temparr[1];
                rWebsite.Text = temparr[2];
                rWebsite.NavigateUrl = temparr[2]; 
                rCountry.Text = temparr[3];
                aartifactdata.ImageUrl = temparr[4];
            }
        }

        protected void GridjobsbyrecPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            if (Request.QueryString["empid"] != null)
            {
                var rcl = new ClRecruiters();
                Gridjobsbyrec.DataSource = rcl.Getrecwithjobs(Server.HtmlEncode(Request.QueryString["empid"]));
                Gridjobsbyrec.PageIndex = e.NewPageIndex;
                Gridjobsbyrec.DataBind();
            }
        }

        protected void GridjobsbyrecRowDataBound(object sender, GridViewRowEventArgs e)
        {
            switch (e.Row.RowType)
            {
                case DataControlRowType.DataRow:
                    e.Row.Attributes.Add("onmouseover", "this.className='dv_shadowa1'");
                    e.Row.Attributes.Add("onmouseout", "this.className=''");
                    break;
            }
        }
    }
}