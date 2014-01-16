using System;
using Msftlayer;

namespace JB.Jobseekers
{
    public partial class Jobseekerhome : ClCookie
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //read and validate login

            Isuserloginvalid();

            //if (Session["cuserval"] != null)
            //{
            //    if (Session["cuserval"].ToString() == Readjobcookie())
            //    {
            //    }
            //    else
            //    {
            //        Response.Redirect("login.aspx");
            //    }
            //}

            //else
            //{
            //    Response.Redirect("login.aspx");
            //}

            ////////////////////////////////////
            //get profile strength
            ////////////////////////////////////

            var clm = new ClMainPagePopulator();
            string getprofstrength = clm.Profilestrind(Session["pusername"].ToString());

            LabelStrenght.Text = getprofstrength;

            if (getprofstrength == "Low")
            {
                Image1.ImageUrl = "/images/profile_low.png";
            }

            if (getprofstrength == "Medium")
            {
                Image1.ImageUrl = "/images/profile_medium.png";
            }

            if (getprofstrength == "High")
            {
                Image1.ImageUrl = "/images/profile_high.png";
            }

            var cclid = new ClCandidates();
            string[] temphldoldcan = cclid.Getcandidatesindb(Session["pusername"].ToString());

            var clap = new ClApps();
            //total for job seeker job applications
            LabelJobsAppliedTo.Text = clap.Getcanjobapptotal(temphldoldcan[3]);

            //total views for all jobs
        }
    }
}