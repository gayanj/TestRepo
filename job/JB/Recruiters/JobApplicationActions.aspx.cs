using System;
using Msftlayer;

namespace JB.Recruiters
{
    public partial class JobApplicationActions : ClCookie
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Isuserloginvalid();

            if (Request.QueryString["status"] != null)
            {
                string status = Request.QueryString["status"];

                LabelMessage.Text = "Are you sure you want to change the application status to " + status;

            }
        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("recapplication.aspx");
        }

        protected void ButtonAccept_Click(object sender, EventArgs e)
        {
            //update status here
            var iapp = new ClApps();
            var statusid = Convert.ToInt32(Request.QueryString["sid"]);
            var appid = Request.QueryString["appid"];

            iapp.UpdateAppStatuses(appid, statusid);
            Response.Redirect("Recapplication.aspx");
        }
    }
}