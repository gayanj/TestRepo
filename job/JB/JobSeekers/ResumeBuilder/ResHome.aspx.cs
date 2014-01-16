using System;
using Msftlayer;

namespace JB.Jobseekers.ResumeBuilder
{
    public partial class ResHome : ClCookie
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Isuserloginvalid();

            ClPrivacy clp = new ClPrivacy();
            ClResumeBuilder clr = new ClResumeBuilder();
            
            string canid = clp.Getcandidattesid(Session["pusername"].ToString());
            var profilecount = clr.GetStatusProfile(canid);
            var educationcount = clr.GetStatusEducation(canid);
            var expereincecount = clr.GetStatusExperience(canid);
            var skillcount = clr.GetStatusSkills(canid);
            var referncecount = clr.GetStatusReferences(canid);

            if (profilecount > 0)
            {
                StatusProfile.Text = "Complete";
                LinkProfileNew.Visible = false;
                LinkProfileEdit.Visible = true;
            }

            if (educationcount > 0)
            {
                StatusEducation.Text = "Complete";
                LinkEducationNew.Visible = false;
                LinkEducationEdit.Visible = true;
            }

            if (expereincecount > 0)
            {
                StatusExperience.Text = "Complete";
                LinkExperienceNew.Visible = false;
                LinkExperienceEdit.Visible = true;
            }

            if (skillcount > 0)
            {
                StatusSkills.Text = "Complete";
                LinkSkillsNew.Visible = false;
                LinkSkillsEdit.Visible = true;
            }

            if (referncecount > 0)
            {
                StatusReferences.Text = "Complete";
                LinkReferenceNew.Visible = false;
                LinkReferenceEdit.Visible = true;
            }

        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            Response.Redirect("resprofile.aspx");
        }
    }
}