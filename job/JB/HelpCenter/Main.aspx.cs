using System;
using System.Web.UI.WebControls;
using Msftlayer;

namespace JB.Helpcenter
{
    public partial class Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Textboxqs.Focus();
            Page.Form.DefaultButton = Buttonsearch.UniqueID;

            if (!IsPostBack)
            {
                var chelp = new ClHelpCenter();
                browecategories.DataSource = chelp.Gethelpcategories();
                browecategories.DataBind();

                if (Server.HtmlEncode(Request.QueryString["catid"]) != null)
                {
                    var catid = Convert.ToInt32(Server.HtmlEncode(Request.QueryString["catid"]));
                    Gridviewanswers.DataSource = chelp.Gethelpquestions(catid);
                    Gridviewanswers.DataBind();
                }

                else
                {
                    if (Request.QueryString["q"] != null)
                    {
                        switch (Server.HtmlEncode(Request.QueryString["q"]).Trim())
                        {
                            case "ALL":
                                Gridviewanswers.DataSource = chelp.Gethelpquestions();
                                Gridviewanswers.DataBind();
                                break;
                            default:
                                Gridviewanswers.DataSource = chelp.Gethelpquestions(Server.HtmlEncode(Request.QueryString["q"]));
                                Gridviewanswers.DataBind();
                                Textboxqs.Text = Server.HtmlEncode(Request.QueryString["q"]).Trim();
                                break;
                        }
                    }

                    else
                    {
                        Gridviewanswers.DataSource = chelp.Gethelpquestions();
                        Gridviewanswers.DataBind();
                    }
                }
            }
        }

        protected void ButtonsearchClick(object sender, EventArgs e)
        {
            switch (Server.HtmlEncode(Textboxqs.Text).Trim())
            {
                case "":
                    Response.Redirect("main.aspx?q=ALL");
                    break;
                default:
                    Response.Redirect("main.aspx?q=" + Server.HtmlEncode(Textboxqs.Text));
                    break;
            }
        }

        protected void GridviewanswersPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            var chelp = new ClHelpCenter();

            if (Server.HtmlEncode(Request.QueryString["catid"]) != null)
            {
                var catid = Convert.ToInt32(Server.HtmlEncode(Request.QueryString["catid"]));
                Gridviewanswers.DataSource = chelp.Gethelpquestions(catid);
                Gridviewanswers.PageIndex = e.NewPageIndex;
                Gridviewanswers.DataBind();
            }

            else
            {
                if (Request.QueryString["q"] != null)
                {
                    switch (Server.HtmlEncode(Request.QueryString["q"]).Trim())
                    {
                        case "ALL":
                            Gridviewanswers.DataSource = chelp.Gethelpquestions();
                            Gridviewanswers.PageIndex = e.NewPageIndex;
                            Gridviewanswers.DataBind();
                            break;
                        default:
                            Gridviewanswers.DataSource = chelp.Gethelpquestions(Server.HtmlEncode(Request.QueryString["q"]));
                            Gridviewanswers.PageIndex = e.NewPageIndex;
                            Gridviewanswers.DataBind();
                            break;
                    }
                }

                else
                {
                    Gridviewanswers.DataSource = chelp.Gethelpquestions();
                    Gridviewanswers.PageIndex = e.NewPageIndex;
                    Gridviewanswers.DataBind();
                }
            }
        }

        protected void LinkButton3Click(object sender, EventArgs e)
        {
            var lb = (LinkButton)sender;
            Response.Redirect("main.aspx?catid=" + lb.CommandArgument);
        }
    }
}