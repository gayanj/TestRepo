using System;
using Msftlayer;

namespace JB.Jobseekers
{
    public partial class Cannotes : ClCookie
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //read and validate login
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
            Isuserloginvalid();

            if (!IsPostBack)
            {
                //get can id
                var clpv = new ClPrivacy();
                string canids = clpv.Getcandidattesid(Session["pusername"].ToString());

                //get data from db
                var clns = new ClNotes();
                Editor1.Text = clns.Getnote(canids);
            }
        }

        protected void UpdatenotebuttonClick(object sender, EventArgs e)
        {
            if (Editor1.Text.Trim() == "")
            {
                LabelNotify.Text = "Please write something and then click save!";
            }
            else
            {
                //retreive current candidate id
                var clpriv = new ClPrivacy();
                string clcanid = clpriv.Getcandidattesid(Session["pusername"].ToString());

                //update add data
                var clns = new ClNotes();
                clns.Updatenote(clcanid, Editor1.Text);

                Session["reasons"] = "You have sucessfully saved your notes!";
                Response.Redirect("Canconfirm.aspx");
            }
        }
    }
}