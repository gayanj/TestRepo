using System;
using Msftlayer;

namespace JB.Recruiters
{
    public partial class Jobvideos : ClCookie
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
            //        Response.Redirect("/Login");
            //    }
            //}

            //else
            //{
            //    Response.Redirect("/Login");
            //}

            if (!IsPostBack)
            {
                var jobid = Request.QueryString["jobid"];
                var clvid = new ClVideo();
                var vidarr = clvid.Getvideo(jobid);

                if (vidarr != null)
                {
                    CheckBoxvid.Checked = true;
                    TextBoxvidtitle.Text = vidarr[0];
                    TextBoxvidurl.Text = vidarr[1];
                }
            }
        }

        protected void Button1Click(object sender, EventArgs e)
        {
            #region videoprocessing

            //update videos
            var jobid = Request.QueryString["jobid"];
            var clvid = new ClVideo();

            //update videourl
            switch (CheckBoxvid.Checked)
            {
                case true:
                    {
                        var chkvid1 = clvid.Getvideo(jobid);
                        if (chkvid1 != null)
                        {
                            //update videos
                            clvid.Updatevideo(TextBoxvidtitle.Text, TextBoxvidurl.Text, jobid);
                        }

                        else
                        {
                            //add video
                            clvid.Addvideo(TextBoxvidtitle.Text, TextBoxvidurl.Text, jobid);
                        }

                        clvid.Enablevideo(jobid);
                    }
                    break;
                default:
                    {
                        //check if video exists.
                        string[] chkvid2 = clvid.Getvideo(jobid);
                        if (chkvid2 != null)
                        {
                            //delete videos
                            clvid.Removevideo(jobid);
                            clvid.Disablevideo(jobid);
                        }
                    }
                    break;
            }

            #endregion videoprocessing

            Response.Redirect("/recruiters/jobquestions.aspx?jobid=" + Request.QueryString["jobid"]);
        }
    }
}