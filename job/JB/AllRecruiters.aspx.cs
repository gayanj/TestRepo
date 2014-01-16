using System;
using System.Globalization;
using System.Web.UI.WebControls;
using Msftlayer;

namespace JB
{
    public partial class Allrecruiters : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.IsSecureConnection)
            {
                Response.Redirect(System.Configuration.ConfigurationManager.AppSettings["httppaths"].ToString(CultureInfo.InvariantCulture) + "/allrecruiters");
            }

            Textboxrec.Focus();
            Page.Form.DefaultButton = Buttonsearch.UniqueID;

            //constructor
            var rcl = new ClRecruiters();

            if (Request.QueryString["q"] == null && Request.QueryString["Type"] == null)
            {
                RecrutiersGrid.DataSource = rcl.Getallrecwithjobs();
                RecrutiersGrid.DataBind();
            }

            else
            {
                #region searchrecruiters

                //try request
                if (Request.QueryString["q"] != null)
                {

                    Textboxrec.Text = Server.HtmlEncode(Request.QueryString["q"]);

                    string crit = Server.HtmlEncode(Request.QueryString["q"]);

                    switch (Request.QueryString["Type"])
                    {
                        case "AllTypes":
                            DropDownList1.SelectedValue = "AllTypes";
                            Textboxrec.Text = crit;
                            RecrutiersGrid.DataSource = rcl.Getallrecwithjobsfiltered(crit);
                            RecrutiersGrid.DataBind();
                            break;
                        case "Company":
                            DropDownList1.SelectedValue = "Company";
                            RecrutiersGrid.DataSource = rcl.Getallbyqrycriteria(1, crit);
                            RecrutiersGrid.DataBind();
                            break;
                        default:
                            DropDownList1.SelectedValue = "Agent";
                            RecrutiersGrid.DataSource = rcl.Getallbyqrycriteria(0, crit);
                            RecrutiersGrid.DataBind();
                            break;
                    }
                }

                else
                {
                    switch (Request.QueryString["Type"])
                    {
                        case "AllTypes":
                            DropDownList1.SelectedValue = "AllTypes";
                            RecrutiersGrid.DataSource = rcl.Getallrecwithjobs();
                            RecrutiersGrid.DataBind();
                            break;
                        case "Company":
                            DropDownList1.SelectedValue = "Company";
                            RecrutiersGrid.DataSource = rcl.Getallbycriteria(1);
                            RecrutiersGrid.DataBind();
                            break;
                        default:
                            DropDownList1.SelectedValue = "Agent";
                            RecrutiersGrid.DataSource = rcl.Getallbycriteria(0);
                            RecrutiersGrid.DataBind();
                            break;
                    }
                }

                #endregion searchrecruiters
            }
        }

        protected void RecrutiersGridPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            Textboxrec.Focus();
            Page.Form.DefaultButton = Buttonsearch.UniqueID;

            //constructor
            var rcl = new ClRecruiters();

            if (Request.QueryString["q"] == null && Request.QueryString["Type"] == null)
            {

                RecrutiersGrid.DataSource = rcl.Getallrecwithjobs();
                RecrutiersGrid.PageIndex = e.NewPageIndex;
                RecrutiersGrid.DataBind();

            }

            else
            {
                #region searchrecruiters

                //try request
                if (Request.QueryString["q"] != null)
                {

                    Textboxrec.Text = Server.HtmlEncode(Request.QueryString["q"]);

                    var crit = Server.HtmlEncode(Request.QueryString["q"]);

                    if (Request.QueryString["Type"] != null)
                    {
                        switch (Request.QueryString["Type"])
                        {
                            case "AllTypes":
                                DropDownList1.SelectedValue = "AllTypes";
                                Textboxrec.Text = crit;
                                RecrutiersGrid.DataSource = rcl.Getallrecwithjobsfiltered(crit);
                                RecrutiersGrid.PageIndex = e.NewPageIndex;
                                RecrutiersGrid.DataBind();
                                break;
                            case "Company":
                                DropDownList1.SelectedValue = "Company";
                                RecrutiersGrid.DataSource = rcl.Getallbyqrycriteria(1, crit);
                                RecrutiersGrid.PageIndex = e.NewPageIndex;
                                RecrutiersGrid.DataBind();
                                break;
                            default:
                                DropDownList1.SelectedValue = "Agent";
                                RecrutiersGrid.DataSource = rcl.Getallbyqrycriteria(0, crit);
                                RecrutiersGrid.PageIndex = e.NewPageIndex;
                                RecrutiersGrid.DataBind();
                                break;
                        }

                    }
                }

                else
                {
                    if (Request.QueryString["Type"] != null)
                    {

                        switch (Request.QueryString["Type"])
                        {
                            case "AllTypes":
                                DropDownList1.SelectedValue = "AllTypes";
                                RecrutiersGrid.DataSource = rcl.Getallrecwithjobs();
                                RecrutiersGrid.PageIndex = e.NewPageIndex;
                                RecrutiersGrid.DataBind();
                                break;
                            case "Company":
                                DropDownList1.SelectedValue = "Company";
                                RecrutiersGrid.DataSource = rcl.Getallbycriteria(1);
                                RecrutiersGrid.PageIndex = e.NewPageIndex;
                                RecrutiersGrid.DataBind();
                                break;
                            default:
                                DropDownList1.SelectedValue = "Agent";
                                RecrutiersGrid.DataSource = rcl.Getallbycriteria(0);
                                RecrutiersGrid.PageIndex = e.NewPageIndex;
                                RecrutiersGrid.DataBind();
                                break;
                        }

                    }
                }

                #endregion searchrecruiters
            }
        }

        protected void ButtonsearchClick(object sender, EventArgs e)
        {
            RecrutiersGrid.PageIndex = 0;

            var tmpqrys = Server.HtmlEncode(Textboxrec.Text);

            if (tmpqrys != "")
            {
                Response.Redirect("/allrecruiters?q=" + tmpqrys + "&Type=" + DropDownList1.SelectedValue);
            }

            else
            {
                Response.Redirect("/allrecruiters?Type=" + DropDownList1.SelectedValue);
            }
        }

        protected void RecrutiersGridRowDataBound(object sender, GridViewRowEventArgs e)
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