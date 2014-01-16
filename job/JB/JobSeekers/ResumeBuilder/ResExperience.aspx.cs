using System;
using System.Web.UI.WebControls;
using Msftlayer;
using System.Globalization;

namespace JB.Jobseekers.ResumeBuilder
{
    public partial class ResExperience : ClCookie
    {
        private string[] Splitdate(string _input)
        {
            char[] splitter = { '/', ' ' };
            string[] _output = _input.Split(splitter);
            return _output;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Isuserloginvalid();

            ResSchool.Focus();
            Page.Form.DefaultButton = ButtonAdd.UniqueID;

            if (!IsPostBack)
            {
                var clb = new ClResumeBuilder();

                if (Request.QueryString["expid"] != null)
                {
                    ButtonAdd.Visible = false;
                    ButtonUpdate.Visible = true;

                    Page.Form.DefaultButton = ButtonUpdate.UniqueID;

                    string cult = System.Configuration.ConfigurationManager.AppSettings["localization"].ToString();
                    var cinfo = new CultureInfo(cult);
                    //edit the data for current qualification
                    string[] arr = clb.GetExperiencebyId(Convert.ToInt32(Request.QueryString["expid"]));
                    ResSchool.Text = arr[1];
                    ResDegree.Text = arr[2];

                    var ResStartDate = Splitdate(arr[3]);

                    ResStartDate1.Text = ResStartDate[0];
                    ResStartDate2.Text = ResStartDate[1];
                    ResStartDate3.Text = ResStartDate[2];

                    var ResEndDate = Splitdate(arr[4]);

                    ResEndDate1.Text = ResEndDate[0];
                    ResEndDate2.Text = ResEndDate[1];
                    ResEndDate3.Text = ResEndDate[2];

                    ResDesc.Text = arr[5];
                }

                var clp = new ClPrivacy();
                var candidateid = clp.Getcandidattesid(Session["pusername"].ToString());
                GridExperience.DataSource = clb.GetExperience(candidateid);
                GridExperience.DataBind();
            }
        }

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            var clb = new ClResumeBuilder();
            var clp = new ClPrivacy();

            //string cult = System.Configuration.ConfigurationManager.AppSettings["localization"].ToString();
            //var cinf = new CultureInfo(cult);
            //var cinf = new CultureInfo("en-GB");
            var sdate = ResStartDate3.Text + "-" + ResStartDate2.Text + "-" + ResStartDate1.Text;
            var edate = ResEndDate3.Text + "-" + ResEndDate2.Text + "-" + ResEndDate1.Text;

            //var sdate = startdate.ToString("MM/dd/yyyy");
            //var edate = enddate.ToString("MM/dd/yyyy");
            string candidateid = clp.Getcandidattesid(Session["pusername"].ToString());
            var schoolname = ResSchool.Text;
            var degree = ResDegree.Text;
            var desc = ResDesc.Text;

            clb.InsertExperience(candidateid, schoolname, degree, sdate, edate, desc);
            GridExperience.DataSource = clb.GetExperience(candidateid);
            GridExperience.DataBind();

            ResSchool.Text = "";
            ResDegree.Text = "";
            ResStartDate1.Text = "";
            ResStartDate2.Text = "";
            ResStartDate3.Text = "";
            ResEndDate1.Text = "";
            ResEndDate2.Text = "";
            ResEndDate3.Text = "";
            ResDesc.Text = "";

        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            Response.Redirect("ResReferences.aspx");
        }

        protected void GridExperience_RowCommand(object sender, GridViewCommandEventArgs e)
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

                        clb.DeleteExperience(firstColumnValue);
                        GridExperience.DataSource = clb.GetExperience(firstColumnValue);
                        GridExperience.DataBind();

                        break;
                    }
                case "Edit":
                    {
                        firstColumnValue = e.CommandArgument.ToString();

                        Response.Redirect("ResExperience.aspx?expid=" + firstColumnValue);

                        break;
                    }
                default:
                    break;
            }
        }

        protected void GridExperience_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            var clb = new ClResumeBuilder();
            var clp = new ClPrivacy();
            var candidateid = clp.Getcandidattesid(Session["pusername"].ToString());
            GridExperience.DataSource = clb.GetExperience(candidateid);
            GridExperience.DataBind();
        }

        protected void ButtonUpdate_Click(object sender, EventArgs e)
        {
            var eduid = Convert.ToInt32(Request.QueryString["expid"]);
            //var cinf = new CultureInfo("en-GB");
            string cult = System.Configuration.ConfigurationManager.AppSettings["localization"].ToString();
            var cinf = new CultureInfo(cult);

            var sdate = ResStartDate3.Text + "-" + ResStartDate2.Text + "-" + ResStartDate1.Text;
            var edate = ResEndDate3.Text + "-" + ResEndDate2.Text + "-" + ResEndDate1.Text;

            //update Experience
            var clb = new ClResumeBuilder();
            clb.UpdateExperience(eduid, ResSchool.Text, ResDegree.Text, sdate, edate, ResDesc.Text);
        }
    }
}