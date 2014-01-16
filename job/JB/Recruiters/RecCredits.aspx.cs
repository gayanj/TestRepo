using System;
using Msftlayer;

namespace JB.Recruiters
{
    public partial class Reccredits : ClCookie
    {
        //read cookie

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
            //        Response.Redirect("/recruiters/Login");
            //    }
            //}

            //else
            //{
            //    Response.Redirect("/recruiters/Login");
            //}

            if (!IsPostBack)
            {
                var clcre = new ClCredits();
                string qryempid = clcre.Getrccreditempid(Session["pusername"].ToString());
                LabelAvailableCredit.Text = "You have [" + clcre.Getcredaysleft(qryempid) + "] days of free job posting left from <b>Standard job ad pack</b>";
            }
        }

        private void Processreq(int reqtype)
        {
            var clcre = new ClCredits();
            string qryrecid = clcre.Getrccreditempid(Session["pusername"].ToString());
            clcre.Insertcreusermod(qryrecid, reqtype);
        }

        protected void LinkButton1Click(object sender, EventArgs e)
        {
            Processreq(1);
            Session["reasons"] = "Your request is with us and we will notify you within 3 working days, this is because of this site administrators access settings";
            Response.Redirect("/recruiters/confirmation");
        }

        protected void LinkButton2Click(object sender, EventArgs e)
        {
            Processreq(2);
            Session["reasons"] = "Your request is with us and we will notify you within 3 working days, this is because of this site administrators access settings";
            Response.Redirect("/recruiters/confirmation");
        }

        protected void LinkButton3Click(object sender, EventArgs e)
        {
            Processreq(3);
            Session["reasons"] = "Your request is with us and we will notify you within 3 working days, this is because of this site administrators access settings";
            Response.Redirect("/recruiters/confirmation");
        }

        protected void LinkButton4Click(object sender, EventArgs e)
        {
            Processreq(4);
            Session["reasons"] = "Your request is with us and we will notify you within 3 working days, this is because of this site administrators access settings";
            Response.Redirect("/recruiters/confirmation");
        }

        protected void LinkButton5Click(object sender, EventArgs e)
        {
            Processreq(5);
            Session["reasons"] = "Your request is with us and we will notify you within 3 working days, this is because of this site administrators access settings";
            Response.Redirect("/recruiters/confirmation");
        }

        protected void LinkButton6Click(object sender, EventArgs e)
        {
            Processreq(6);
            Session["reasons"] = "Your request is with us and we will notify you within 3 working days, this is because of this site administrators access settings";
            Response.Redirect("/recruiters/confirmation");
        }

        protected void LinkButton7Click(object sender, EventArgs e)
        {
            Processreq(7);
            Session["reasons"] = "Your request is with us and we will notify you within 3 working days, this is because of this site administrators access settings";
            Response.Redirect("/recruiters/confirmation");
        }

        protected void LinkButton8Click(object sender, EventArgs e)
        {
            Processreq(8);
            Session["reasons"] = "Your request is with us and we will notify you within 3 working days, this is because of this site administrators access settings";
            Response.Redirect("/recruiters/confirmation");
        }
    }
}