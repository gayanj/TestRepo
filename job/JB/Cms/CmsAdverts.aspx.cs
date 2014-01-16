using System;
using Msftlayer;

namespace JB.Cms
{
    public partial class CmsAllAdverts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["type"] != null)
            {
               
                    var iclass = new ClCmsClass();

                    switch (Request.QueryString["type"])
                    {
                        case "1":
                            Labelheaddetail.Text = "Login Background Ads";
                            GridView1.DataSource = iclass.Getcmsadvertisements("1");
                            GridView1.DataBind();
                            break;
                        case "2":
                            Labelheaddetail.Text = "Desktop Widget Ads";
                            GridView1.DataSource = iclass.Getcmsadvertisements("2");
                            GridView1.DataBind();
                            break;
                        case "3":
                            Labelheaddetail.Text = "Login Micro Ads";
                            GridView1.DataSource = iclass.Getcmsadvertisements("3");
                            GridView1.DataBind();
                            break;
                        case "4":
                            Labelheaddetail.Text = "Stock Bar Ads";
                            GridView1.DataSource = iclass.Getcmsadvertisements("4");
                            GridView1.DataBind();
                            break;
                        default:
                            Labelheaddetail.Text = "Site Header Ads";
                            GridView1.DataSource = iclass.Getcmsadvertisements("5");
                            GridView1.DataBind();
                            break;
                    }
                
            }
        }

        protected void GridView1_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            if (Request.QueryString["type"] != null)
            {
                
                    var iclass = new ClCmsClass();

                    switch (Request.QueryString["type"])
                    {
                        case "1":
                            Labelheaddetail.Text = "Login Background Ads";
                            GridView1.DataSource = iclass.Getcmsadvertisements("1");
                            GridView1.PageIndex = e.NewPageIndex;
                            GridView1.DataBind();
                            break;
                        case "2":
                            Labelheaddetail.Text = "Desktop Widget Ads";
                            GridView1.DataSource = iclass.Getcmsadvertisements("2");
                            GridView1.PageIndex = e.NewPageIndex;
                            GridView1.DataBind();
                            break;
                        case "3":
                            Labelheaddetail.Text = "Login Micro Ads";
                            GridView1.DataSource = iclass.Getcmsadvertisements("3");
                            GridView1.PageIndex = e.NewPageIndex;
                            GridView1.DataBind();
                            break;
                        case "4":
                            Labelheaddetail.Text = "Stock Bar Ads";
                            GridView1.DataSource = iclass.Getcmsadvertisements("4");
                            GridView1.PageIndex = e.NewPageIndex;
                            GridView1.DataBind();
                            break;
                        default:
                            Labelheaddetail.Text = "Site Header Ads";
                            GridView1.DataSource = iclass.Getcmsadvertisements("5");
                            GridView1.PageIndex = e.NewPageIndex;
                            GridView1.DataBind();
                            break;
                    }
                
            }
        }
    }
}