using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using Msftlayer;
using System.Collections;

namespace JB.wap
{
    public partial class JobApplication : System.Web.UI.Page
    {
        private void PopulateData()
        {
            //if job id = single then one question.
            var iqs = new ClQuestions();
            var jid = string.Empty;

            if (Request.QueryString["jobid"] != null)
            {
                jid = Request.QueryString["jobid"];
            }

            ArrayList al = iqs.GetQuestion(jid);
            PanelQuestions.Controls.Clear();

            for (int qs = 0; qs < al.Count; qs += 2)
            {
                Panel p = new Panel();
                p.ID = "Panel_" + al[qs].ToString();
                PanelQuestions.Controls.Add(p);

                Label lb = new Label();
                lb.Text = "<br/>Question: ";
                lb.CssClass = "m_ft_blackbd";
                Label tb = new Label();
                tb.Text = al[qs + 1].ToString();
                tb.ID = "Question_" + al[qs].ToString();
                tb.CssClass = "m_ft_blackbd";

                Literal li = new Literal();
                li.Text = "<br/>";

                RadioButtonList rb = new RadioButtonList();
                rb.ID = "RList_" + al[qs].ToString();
                rb.CssClass = "m_ft_black";
                rb.RepeatLayout = RepeatLayout.Flow;
                rb.RepeatDirection = RepeatDirection.Horizontal;

                p.Controls.Add(lb);
                p.Controls.Add(tb);
                p.Controls.Add(li);

                ArrayList alans = iqs.GetAnswers(al[qs].ToString());

                for (int an = 0; an < alans.Count; an += 3)
                {
                    //add answer                    
                    ListItem tba = new ListItem();
                    tba.Text = alans[an + 2].ToString();
                    tba.Value = "Answer_" + alans[an + 1].ToString();
                    Literal litpx = new Literal();
                    litpx.Text = "<div class=\"ln_fixx2\"></div>";

                    rb.Items.Add(tba);
                    p.Controls.Add(litpx);

                }

                p.Controls.Add(rb);
            }
        }

        private void Addans(string idjobs, string appid)
        {
            var iqs = new ClQuestions();

            foreach (Control ci in PanelQuestions.Controls)
            {
                var p = (Panel)ci;

                foreach (Control cp in p.Controls)
                {
                    try
                    {
                        var rb = (RadioButtonList)cp;
                        var qs = Convert.ToInt32(rb.ID.ToString().Replace("RList_", ""));

                        foreach (ListItem li in rb.Items)
                        {
                            if (li.Selected == true)
                            {
                                var ansid = Convert.ToInt32(li.Value.Replace("Answer_", ""));
                                string ans = li.Text;

                                //insert into db.
                                iqs.InsertAnswerByUser(ansid, qs, idjobs, appid, ans);
                            }
                        }
                    }
                    catch
                    {
                        //this will ignore any labels
                    }
                }
            }
        }

        private bool RunValidator()
        {
            bool _flag = false;

            if (TextBoxFirstName.Text == "")
            {
                LabelNotify.Text = "First Name is Required!";
                _flag = true; return _flag;
            }

            else if (TextBoxLastName.Text == "")
            {
                LabelNotify.Text = "Last Name is Required!"; _flag = true; return _flag;
            }

            else if (TextBoxCover.Text == "")
            {
                LabelNotify.Text = "Covering Letter is Required!"; _flag = true; return _flag;
            }

            else if (TbSchoolName.Text == "")
            {
                LabelNotify.Text = "School Name is Required!"; _flag = true; return _flag;
            }

            else if (TbDegree.Text == "")
            {
                LabelNotify.Text = "Degree Title is Required!"; _flag = true; return _flag;
            }

            else if (TbStartDate.Text == "")
            {
                LabelNotify.Text = "Schooling Start Date is Required!"; _flag = true; return _flag;
            }

            else if (TbEndDate.Text == "")
            {
                LabelNotify.Text = "Schooling End Date is Required!"; _flag = true; return _flag;
            }

            else if (TbEducationDetail.Text == "")
            {
                LabelNotify.Text = "Education Detail is Required!"; _flag = true; return _flag;
            }

            else if (TbCompany.Text == "")
            {
                LabelNotify.Text = "Company Name is Required!"; _flag = true; return _flag;
            }

            else if (TbTitle.Text == "")
            {
                LabelNotify.Text = "Last Job Title is Required!"; _flag = true; return _flag;
            }

            else if (TbJobStartDate.Text == "")
            {
                LabelNotify.Text = "Job Start Date is Required!"; _flag = true; return _flag;
            }

            else if (TbJobEndDate.Text == "")
            {
                LabelNotify.Text = "Job End Date is Required!"; _flag = true; return _flag;
            }

            else if (TbJobDetails.Text == "")
            {
                LabelNotify.Text = "Job detail is Required!"; _flag = true; return _flag;
            }

            else if (TSkill.Text == "")
            {
                LabelNotify.Text = "Skills need to be Filled!"; _flag = true; return _flag;
            }

            else if (TbRefFirstName.Text == "")
            {
                LabelNotify.Text = "Referal First Name is Required!"; _flag = true; return _flag;
            }

            else if (TbRefLastName.Text == "")
            {
                LabelNotify.Text = "Referal Last Name is Required!"; _flag = true; return _flag;
            }

            else if (TbRefEmail.Text == "")
            {
                LabelNotify.Text = "Referal Email is Required!"; _flag = true; return _flag;
            }

            else if (TbLocalPhone.Text == "")
            {
                LabelNotify.Text = "Referal Local Phone Required!"; _flag = true; return _flag;
            }

            else if (TbMobilePhone.Text == "")
            {
                LabelNotify.Text = "Referal Local Phone Required!"; _flag = true; return _flag;
            }

            else if (TbRefAddress.Text == "")
            {
                LabelNotify.Text = "Referal Address Required!"; _flag = true; return _flag;
            }

            else { return _flag; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Form.DefaultButton = ButtonApply.UniqueID;

            if (Request.QueryString["jobid"] != null)
            {
                var cmp = new ClMainPagePopulator();
                string[] plc = cmp.Getdetailspage(Request.QueryString["jobid"]);

                LabelJobTitle.Text = "Role: " + plc[0];
                LabelCompany.Text = "Recruiter: " + plc[4];
                LabelDescription.Text = "Description:<br/>" + plc[2];

                PopulateData();
            }
        }

        protected void ButtonApply_Click(object sender, EventArgs e)
        {
            if (RunValidator() == false)
            {
                Response.Redirect("/Confirm.aspx");
            }

        }
    }
}