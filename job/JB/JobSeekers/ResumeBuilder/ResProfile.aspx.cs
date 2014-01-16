using System;
using Msftlayer;

namespace JB.Jobseekers.ResumeBuilder
{
    public partial class ResProfile : ClCookie
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Isuserloginvalid();

            TextBox1.Focus();

            if (!IsPostBack)
            {
                if (Request.QueryString["redit"] != null)
                {
                    if (Request.QueryString["redit"] == "1")
                    {
                        var clb = new ClResumeBuilder();
                        var clp = new ClPrivacy();
                        string canid = clp.Getcandidattesid(Session["pusername"].ToString());
                        string temp_prof = clb.GetProfile(canid);

                        TextBox1.Text = temp_prof;
                    }
                }
            }
        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            var imsft = new ClResumeBuilder();
            var clp = new ClPrivacy();
            var tempprofile = Server.HtmlEncode(TextBox1.Text);
            string canid = clp.Getcandidattesid(Session["pusername"].ToString());

            if (Request.QueryString["redit"] != null)
            {
                if (Request.QueryString["redit"] == "1")
                {
                    //update profile
                    imsft.UpdateProfile(tempprofile, canid);

                    //redirect
                    Response.Redirect("ResEducation.aspx");
                }
            }

            else
            {
                //save and continue
                imsft.InsertProfile(tempprofile,canid);
                Response.Redirect("ResEducation.aspx");            
            }
            
        }
    }
}