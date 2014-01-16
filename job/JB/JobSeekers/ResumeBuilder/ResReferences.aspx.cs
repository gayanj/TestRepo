using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Msftlayer;
using System.Globalization;

namespace JB.Jobseekers.ResumeBuilder
{
    public partial class ResReferences : ClCookie
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Isuserloginvalid();

            ResFirstName.Focus();
            Page.Form.DefaultButton = ButtonAdd.UniqueID;

            if (!IsPostBack)
            {
                ClResumeBuilder clb = new ClResumeBuilder();

                if (Request.QueryString["refid"] != null)
                {
                    ButtonAdd.Visible = false;
                    ButtonUpdate.Visible = true;

                    Page.Form.DefaultButton = ButtonUpdate.UniqueID;

                    //edit the data for current qualification
                    string[] arr = clb.GetReferencebyId(Convert.ToInt32(Request.QueryString["refid"]));
                    ResFirstName.Text = arr[1];
                    ResLastName.Text = arr[2];
                    DropDownList1.SelectedValue = arr[3];
                    ResEmail.Text = arr[4];
                    ResLocalPhone.Text = arr[5];
                    ResMobilePhone.Text = arr[6];
                    ResAddress.Text = arr[7];
                }

                ClPrivacy clp = new ClPrivacy();
                var candidateid = clp.Getcandidattesid(Session["pusername"].ToString());
                Gridreference.DataSource = clb.GetReference(candidateid);
                Gridreference.DataBind();
            }
        }

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            ClResumeBuilder clb = new ClResumeBuilder();
            ClPrivacy clp = new ClPrivacy();

            string candidateid = clp.Getcandidattesid(Session["pusername"].ToString());
            var rfname = Server.HtmlEncode(ResFirstName.Text);
            var rlname = Server.HtmlEncode(ResLastName.Text);
            var rreftype = Convert.ToInt16(DropDownList1.SelectedValue);
            var remail = Server.HtmlEncode(ResEmail.Text);
            var rlocalph = Server.HtmlEncode(ResLocalPhone.Text);
            var rmobileph = Server.HtmlEncode(ResMobilePhone.Text);
            var raddress = Server.HtmlEncode(ResAddress.Text);

            clb.InsertReference(candidateid, rfname, rlname, rreftype, remail, rlocalph, rmobileph, raddress);
            Gridreference.DataSource = clb.GetReference(candidateid);
            Gridreference.DataBind();

            ResFirstName.Text = "";
            ResLastName.Text = "";
            ResEmail.Text = "";
            ResLocalPhone.Text = "";
            ResMobilePhone.Text = "";
            ResAddress.Text = "";
        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            Response.Redirect("ResReview.aspx");
        }

        protected void GridReference_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            string firstColumnValue = string.Empty;
            var clp = new ClPrivacy();
            var clb = new ClResumeBuilder();

            switch (e.CommandName)
            {
                case "Delete":
                    {
                        firstColumnValue = e.CommandArgument.ToString();
                        //delete from back end

                        clb.DeleteReference(firstColumnValue);
                        Gridreference.DataSource = clb.GetReference(firstColumnValue);
                        Gridreference.DataBind();

                        break;
                    }
                case "Edit":
                    {
                        firstColumnValue = e.CommandArgument.ToString();
                        Response.Redirect("resReferences.aspx?refid=" + firstColumnValue);

                        break;
                    }
                default:
                    break;
            }
        }

        protected void GridReference_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            ClResumeBuilder clb = new ClResumeBuilder();
            ClPrivacy clp = new ClPrivacy();

            var candidateid = clp.Getcandidattesid(Session["pusername"].ToString());
            Gridreference.DataSource = clb.GetReference(candidateid);
            Gridreference.DataBind();
        }

        protected void ButtonUpdate_Click(object sender, EventArgs e)
        {
            ClPrivacy clp = new ClPrivacy();
            var refid = Convert.ToInt32(Request.QueryString["refid"]);

            var candidateid = clp.Getcandidattesid(Session["pusername"].ToString());
            var rfname = Server.HtmlEncode(ResFirstName.Text);
            var rlname = Server.HtmlEncode(ResLastName.Text);
            var rreftype = Convert.ToInt16(DropDownList1.SelectedValue);
            var remail = Server.HtmlEncode(ResEmail.Text);
            var rlocalph = Server.HtmlEncode(ResLocalPhone.Text);
            var rmobileph = Server.HtmlEncode(ResMobilePhone.Text);
            var raddress = Server.HtmlEncode(ResAddress.Text);

            //update Reference
            ClResumeBuilder clb = new ClResumeBuilder();
            clb.UpdateReference(refid, rfname, rlname, rreftype, remail, rlocalph, rmobileph, raddress);

        }
    }
}