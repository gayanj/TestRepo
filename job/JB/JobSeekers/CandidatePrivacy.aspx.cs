using System;
using System.Web.UI.WebControls;
using Msftlayer;

namespace JB.Jobseekers
{
    public partial class Candidateprivacy : ClCookie
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            #region pgload

            Isuserloginvalid();

            ////read and validate login
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
            //////////////////////////////////////

            var clp = new ClPrivacy();
            string canid = clp.Getcandidattesid(Session["pusername"].ToString());

            if (!IsPostBack)
            {
                //checkcode
                //get all privacy settings for current candidate

                int totalprivopt = clp.Getdefaultcanpol();

                //lookup can table
                int[] privstatus = clp.Getpollookuparray(canid, totalprivopt);

                //setup check boxes
                if (privstatus[1] == 1) { firstname.Checked = true; }
                if (privstatus[2] == 1) { lastname.Checked = true; }
                if (privstatus[3] == 1) { address1.Checked = true; }
                if (privstatus[4] == 1) { address2.Checked = true; }
                if (privstatus[5] == 1) { address3.Checked = true; }
                if (privstatus[6] == 1) { town.Checked = true; }
                if (privstatus[7] == 1) { county.Checked = true; }
                if (privstatus[8] == 1) { country.Checked = true; }
                if (privstatus[9] == 1) { postcode.Checked = true; }
                if (privstatus[10] == 1) { homephone.Checked = true; }
                if (privstatus[11] == 1) { workphone.Checked = true; }
            }

            //get items in blocked list

            recpriv.DataSource = clp.Getlistedrec(canid);
            recpriv.DataBind();

            #endregion pgload
        }

        protected void AddprivClick(object sender, EventArgs e)
        {
            //get empid
            var clrac = new ClRecruiters();
            var clp = new ClPrivacy();

            string recid = clrac.Getrecid(recprivtext.Text);
            string canid = clp.Getcandidattesid(Session["pusername"].ToString());

            if (recid != string.Empty)
            {
                switch (clp.Getcurrblockedrec(recid, canid))
                {
                    case false:
                        clp.Insertrecblock(recid, canid);
                        blocknotify.Visible = false;
                        break;
                    default:
                        blocknotify.Visible = true;
                        break;
                }
            }

            recprivtext.Text = string.Empty;
            recpriv.DataSource = clp.Getlistedrec(canid);
            recpriv.DataBind();
        }

        protected void RecprivRowCommand(object sender, GridViewCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Click":
                    {
                        string firstColumnValue = e.CommandArgument.ToString();
                        //delete from back end
                        var clp = new ClPrivacy();
                        string canid = clp.Getcandidattesid(Session["pusername"].ToString());
                        clp.Deleterecblock(firstColumnValue, canid);
                        recpriv.DataSource = clp.Getlistedrec(canid);
                        recpriv.DataBind();

                        break;
                    }
                default:
                    break;
            }
        }

        protected void BtsaveClick(object sender, EventArgs e)
        {
            //use business layer here to insert the privacy settings
            var clp = new ClPrivacy();
            string canid = clp.Getcandidattesid(Session["pusername"].ToString());
            
            switch (firstname.Checked)
            {
                case true:
                    clp.Updatecanpriv(1, canid, true);
                    break;
                default:
                    clp.Updatecanpriv(1, canid, false);
                    break;
            }
            switch (lastname.Checked)
            {
                case true:
                    clp.Updatecanpriv(2, canid, true);
                    break;
                default:
                    clp.Updatecanpriv(2, canid, false);
                    break;
            }
            switch (address1.Checked)
            {
                case true:
                    clp.Updatecanpriv(3, canid, true);
                    break;
                default:
                    clp.Updatecanpriv(3, canid, false);
                    break;
            }
            switch (address2.Checked)
            {
                case true:
                    clp.Updatecanpriv(4, canid, true);
                    break;
                default:
                    clp.Updatecanpriv(4, canid, false);
                    break;
            }
            switch (address3.Checked)
            {
                case true:
                    clp.Updatecanpriv(5, canid, true);
                    break;
                default:
                    clp.Updatecanpriv(5, canid, false);
                    break;
            }
            switch (town.Checked)
            {
                case true:
                    clp.Updatecanpriv(6, canid, true);
                    break;
                default:
                    clp.Updatecanpriv(6, canid, false);
                    break;
            }
            switch (county.Checked)
            {
                case true:
                    clp.Updatecanpriv(7, canid, true);
                    break;
                default:
                    clp.Updatecanpriv(7, canid, false);
                    break;
            }
            switch (country.Checked)
            {
                case true:
                    clp.Updatecanpriv(8, canid, true);
                    break;
                default:
                    clp.Updatecanpriv(8, canid, false);
                    break;
            }
            switch (postcode.Checked)
            {
                case true:
                    clp.Updatecanpriv(9, canid, true);
                    break;
                default:
                    clp.Updatecanpriv(9, canid, false);
                    break;
            }
            switch (homephone.Checked)
            {
                case true:
                    clp.Updatecanpriv(10, canid, true);
                    break;
                default:
                    clp.Updatecanpriv(10, canid, false);
                    break;
            }
            switch (workphone.Checked)
            {
                case true:
                    clp.Updatecanpriv(11, canid, true);
                    break;
                default:
                    clp.Updatecanpriv(11, canid, false);
                    break;
            }

            Session["reasons"] = "You have sucessfully updated your privacy details!";
            Response.Redirect("Canconfirm.aspx");
        }

        protected void BtcancelClick(object sender, EventArgs e)
        {
            Response.Redirect("jobseekerhome.aspx");
        }
    }
}