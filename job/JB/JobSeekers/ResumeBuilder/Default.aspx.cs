using System;
using Msftlayer;

namespace JB.Jobseekers.ResumeBuilder
{
    public partial class Default : ClCookie
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Isuserloginvalid();

           
        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            Response.Redirect("resprofile.aspx");
        }
    }
}