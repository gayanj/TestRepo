using System;
using Msftlayer;
using System.Web.UI.WebControls;
using System.Collections;

namespace JB.Recruiters
{
    public partial class Recapplicationdetail : ClCookie
    {
        private void PopulateQuestions()
        {
            if (Request.QueryString["idapp"] != null)
            {
                var iqs = new ClQuestions();
                var idapps = Request.QueryString["idapp"];

                ArrayList alist1 = iqs.GetAnswerUser(idapps);

                for (int qi = 0; qi < alist1.Count; qi += 4)
                {
                    Label lb = new Label();
                    lb.ID = "Question_" + alist1[qi + 2];
                    lb.Text = "Question: " + alist1[qi + 3].ToString();
                    lb.CssClass = "ft_blackbd";

                    Literal li = new Literal();
                    li.Text = "<br/>";

                    Label lbans = new Label();
                    lbans.ID = "Answer_" + alist1[qi];
                    lbans.Text = "Answer: " + alist1[qi + 1].ToString();
                    lbans.CssClass = "ft_gray";

                    Literal lit = new Literal();
                    lit.Text = "<div class=\"dv_fix\"></div><br/>";

                    PanelQuestions.Controls.Add(lb);
                    PanelQuestions.Controls.Add(li);
                    PanelQuestions.Controls.Add(lbans);
                    PanelQuestions.Controls.Add(lit);

                }
            }
        }

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

            //set the questions
            PopulateQuestions();


            ////////////////////////////////////////////////
            //set privacy
            ////////////////////////////////////////////////
            var clp = new ClPrivacy();
            var clmain = new ClMainPagePopulator();
            var cclid = new ClCandidates();
            var claps = new ClApps();

            //candidateid
            string canid = cclid.Getcanidbyappid(Request.QueryString["Applyid"]);

            //int canid = clp.Getcandidattesid(Session["pusername"].ToString());
            string[] userdetails = clmain.Getcandidatedetails(Session["pusername"].ToString());

            if (!IsPostBack)
            {
                //checkcode
                //get all privacy settings for current candidate

                int totalprivopt = clp.Getdefaultcanpol();

                //lookup can table
                int[] privstatus = clp.Getpollookuparray(canid, totalprivopt);

                //check if recruiter is blocked
                var employeeid = clmain.Getrecname(Session["pusername"].ToString());

                bool iemployeechk = clp.Getblockedrecruiter(employeeid, canid);

                if (iemployeechk == true)
                {
                    //setup check boxes
                    if (privstatus[1] == 1) { LabelShowFName.Text = userdetails[0].ToString(); }
                    if (privstatus[2] == 1) { LabelShowLName.Text = userdetails[1].ToString(); }
                    if (privstatus[3] == 1) { LabelShowAddress1.Text = userdetails[2].ToString(); }
                    if (privstatus[4] == 1) { LabelShowAddress2.Text = userdetails[3].ToString(); }
                    if (privstatus[5] == 1) { LabelShowAddress3.Text = userdetails[4].ToString(); }
                    if (privstatus[6] == 1) { LabelShowTown.Text = userdetails[5].ToString(); }
                    if (privstatus[7] == 1) { LabelShowCounty.Text = userdetails[6].ToString(); }
                    if (privstatus[8] == 1) { LabelShowCountry.Text = userdetails[7].ToString(); }
                    if (privstatus[9] == 1) { LabelShowPostCode.Text = userdetails[8].ToString(); }
                    if (privstatus[10] == 1) { LabelShowHomePhone.Text = userdetails[9].ToString(); }
                    if (privstatus[11] == 1) { LabelShowWorkPhone.Text = userdetails[10].ToString(); }
                }

                else
                {
                    //display all fields
                    LabelShowFName.Text = privstatus[0].ToString();
                    LabelShowLName.Text = privstatus[1].ToString();
                    LabelShowAddress1.Text = privstatus[2].ToString();
                    LabelShowAddress2.Text = privstatus[3].ToString();
                    LabelShowAddress3.Text = privstatus[4].ToString();
                    LabelShowTown.Text = privstatus[5].ToString();
                    LabelShowCounty.Text = privstatus[6].ToString();
                    LabelShowCountry.Text = privstatus[7].ToString();
                    LabelShowPostCode.Text = privstatus[8].ToString();
                    LabelShowHomePhone.Text = privstatus[9].ToString();
                    LabelShowWorkPhone.Text = privstatus[10].ToString();
                }
            }

            ///////////////////////////////////////////////
            //process app details and resume
            //////////////////////////////////////////////
            if (Request.QueryString["Applyid"] != null)
            {
                //application id
                string appid = Request.QueryString["Applyid"];
                                
                //recruiter id
                string recid = clmain.Getrecname(Session["pusername"].ToString());

                //add recruiter application views here.
                claps.Insertrecview(recid, canid, appid);

                string[] showd = claps.Getapplicationdetails(Request.QueryString["Applyid"]);
                Label2.Text = showd[0];
                HyperLink1.NavigateUrl = showd[1];
            }
        }


    }
}