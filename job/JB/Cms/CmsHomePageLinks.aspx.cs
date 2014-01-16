using System;
using Msftlayer;

namespace JB.Cms
{
    public partial class CmsHomePageLinks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["type"] != null)
            {
               
                    switch (Request.QueryString["type"])
                    {
                        case "header":
                            {
                                Labelheaddetail.Text = "Header Links";
                                var slcms = new ClCmsClass();
                                GridView1.DataSource = slcms.Getcmshomepglinks("header");
                                GridView1.DataBind();
                            }
                            break;
                        case "footer":
                            {
                                Labelheaddetail.Text = "Footer Links";
                                var slcms = new ClCmsClass();
                                GridView1.DataSource = slcms.Getcmshomepglinks("footer");
                                GridView1.DataBind();
                            }
                            break;
                        case "middle":
                            {
                                Labelheaddetail.Text = "Middle Links";
                                var slcms = new ClCmsClass();
                                GridView1.DataSource = slcms.Getcmshomepglinks("middle");
                                GridView1.DataBind();
                            }
                            break;
                        default:
                            {
                                Labelheaddetail.Text = "All Links";
                                var slcms = new ClCmsClass();
                                GridView1.DataSource = slcms.Getcmshomepglinks("All");
                                GridView1.DataBind();
                            }
                            break;
                    }
                
            }
        }

        protected void GridView1_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            if (Request.QueryString["type"] != null)
            {
                
                    switch (Request.QueryString["type"])
                    {
                        case "header":
                            {
                                Labelheaddetail.Text = "Header Links";
                                var slcms = new ClCmsClass();
                                GridView1.DataSource = slcms.Getcmshomepglinks("header");
                                GridView1.PageIndex = e.NewPageIndex;
                                GridView1.DataBind();
                            }
                            break;
                        case "footer":
                            {
                                Labelheaddetail.Text = "Footer Links";
                                var slcms = new ClCmsClass();
                                GridView1.DataSource = slcms.Getcmshomepglinks("footer");
                                GridView1.PageIndex = e.NewPageIndex;
                                GridView1.DataBind();
                            }
                            break;
                        case "middle":
                            {
                                Labelheaddetail.Text = "Middle Links";
                                var slcms = new ClCmsClass();
                                GridView1.DataSource = slcms.Getcmshomepglinks("middle");
                                GridView1.PageIndex = e.NewPageIndex;
                                GridView1.DataBind();
                            }
                            break;
                        default:
                            {
                                Labelheaddetail.Text = "All Links";
                                var slcms = new ClCmsClass();
                                GridView1.DataSource = slcms.Getcmshomepglinks("All");
                                GridView1.PageIndex = e.NewPageIndex;
                                GridView1.DataBind();
                            }
                            break;
                    }
                
            }
        }
    }
}