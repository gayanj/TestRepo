using System;
using System.Web.UI.WebControls;
using Msftlayer;

namespace JB
{
    public partial class Jbsitesearch : System.Web.UI.Page
    {
        public string GetUrl(object url)
        {
            return url.ToString();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && Request.QueryString["q"] != null)
            {
                TextBox1.Text = Request.QueryString["q"];
                var cls = new ClSearchMain();
                SearchResult.DataSource = cls.Getsitesearch(cls.Searchmodif(Server.HtmlEncode(Request.QueryString["q"])));
                SearchResult.DataBind();
            }
        }

        protected void SearchResultPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            if (Request.QueryString["q"] != null)
            {
                var cls = new ClSearchMain();
                SearchResult.DataSource = cls.Getsitesearch(cls.Searchmodif(Server.HtmlEncode(Request.QueryString["q"])));
                SearchResult.PageIndex = e.NewPageIndex;
                SearchResult.DataBind();
            }
        }

        protected void Button1Click(object sender, EventArgs e)
        {
            //Clsearchclass clc = new Clsearchclass();
            var tempq = Server.HtmlEncode(TextBox1.Text);
            Response.Redirect("/jbsitesearch.aspx?track=2&q=" + tempq);
        }

        protected void SearchResult_RowDataBound(object sender, GridViewRowEventArgs e)
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