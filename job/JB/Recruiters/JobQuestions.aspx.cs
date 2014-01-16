using System;
using System.Collections;
using System.Web.UI.WebControls;
using Msftlayer;
using System.Web.UI;
using minGuid;

namespace JB.Recruiters
{
    public partial class Jobquestions : ClCookie
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

            PopulateData();
        }

        private void PopulateData()
        {
            LabelChangesPending.Visible = false;

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
                lb.Text = "<br/>Question<br/>";
                lb.CssClass = "ft_blackbd";
                TextBox tb = new TextBox();
                tb.Text = al[qs + 1].ToString();
                tb.ID = "Question_" + al[qs].ToString();
                tb.CssClass = "cn_txtbox";
                tb.Width = 300;
                Literal li = new Literal();
                li.Text = "<br/>";
                Label lba = new Label();
                ImageButton removeqs = new ImageButton();
                removeqs.ImageUrl = "/images/dv_minus.gif";
                removeqs.ID = "RemoveQuestion_" + al[qs].ToString();
                removeqs.Click += new ImageClickEventHandler(RemoveQuestion);
                lba.Text = "Answers<br/>";
                lba.CssClass = "ft_blackbd";
                LinkButton laddans = new LinkButton();
                laddans.Text = "Add Answer";
                laddans.CssClass = "ft_bluelink";
                laddans.ID = "AddAnswer_" + al[qs].ToString();
                laddans.Click += new EventHandler(ButtonAddAnswer);

                p.Controls.Add(lb);
                p.Controls.Add(tb);
                p.Controls.Add(removeqs);
                p.Controls.Add(li);
                p.Controls.Add(lba);

                ArrayList alans = iqs.GetAnswers(al[qs].ToString());

                for (int an = 0; an < alans.Count; an += 3)
                {
                    //add answer
                    TextBox tba = new TextBox();
                    tba.Text = alans[an + 2].ToString();
                    tba.ID = "Answer_" + alans[an + 1].ToString();
                    tba.CssClass = "cn_txtbox";
                    ImageButton removeans = new ImageButton();
                    removeans.ID = "RemoveAnswer_" + alans[an + 1].ToString();
                    removeans.ImageUrl = "/images/dv_minus.gif";
                    removeans.Click += new ImageClickEventHandler(RemoveAnswers);
                    Literal litpx = new Literal();
                    litpx.Text = "<div class=\"ln_fixx2\"></div>";


                    p.Controls.Add(tba);
                    p.Controls.Add(removeans);
                    p.Controls.Add(litpx);
                    p.Controls.Add(laddans);
                }




                if (iqs.GetTempAns(al[qs].ToString()) != "")
                {
                    LabelChangesPending.Visible = true;

                    p.Controls.Remove(laddans);
                    //add answers from db here.
                    //add new answer
                    TextBox tx = new TextBox();
                    tx.ID = "TextNewAnswer";
                    tx.CssClass = "cn_txtbox";

                    //add new imgbutton
                    ImageButton imgx = new ImageButton();
                    imgx.ID = "ButtonNewRemove_" + al[qs].ToString();
                    imgx.ImageUrl = "/images/dv_minus.gif";
                    imgx.Click += new ImageClickEventHandler(ButtonNewRemove);

                    //add save button
                    LinkButton svx = new LinkButton();
                    svx.ID = "ButtonNewAnswer_" + al[qs].ToString();
                    svx.Text = "Save Answer";
                    svx.CssClass = "ft_bluelink";
                    svx.Click += new EventHandler(ButonNewAnswer);

                    //literal break
                    Literal lix = new Literal();
                    lix.Text = "<br/>";

                    p.Controls.Add(tx);
                    p.Controls.Add(imgx);
                    p.Controls.Add(lix);
                    p.Controls.Add(svx);
                }







            }
        }

        private void UpdateData()
        {

        }

        protected void RemoveQuestion(object sender, ImageClickEventArgs e)
        {
            ImageButton im = (ImageButton)sender;
            string questionid = im.ID.Replace("RemoveQuestion_", "");
            string jobid = Request.QueryString["jobid"];
            
            var iqs = new ClQuestions();
            ArrayList anslst = iqs.GetAnswers(questionid);

            iqs.DeleteQuestion(questionid);

            for (int qi = 0; qi < anslst.Count; qi += 3)
            {
                iqs.DeleteQuestionLinkQ(questionid);
                iqs.DeleteAnswer(anslst[qi].ToString());
            }

            PopulateData();
        }

        protected void RemoveAnswers(object sender, ImageClickEventArgs e)
        {
            ImageButton im = (ImageButton)sender;
            var answerid = im.ID.Replace("RemoveAnswer_", "");
            var jobid = Request.QueryString["jobid"];
            var ians = new ClQuestions();

            ians.DeleteAnswer(answerid);
            ians.DeleteQuestionLinkA(answerid);

            //do it here only as this is called even for qs deletion.
            PopulateData();
        }

        protected void LinkButtonAddQuestion_Click(object sender, EventArgs e)
        {
            LinkButtonAddQuestion.Visible = false;
            PanelAddQuestions.Visible = true;
            LabelChangesPending.Visible = true;
        }

        protected void LinkButtonSave_Click(object sender, EventArgs e)
        {
            LinkButtonAddQuestion.Visible = true;
            LabelChangesPending.Visible = false;

            //insert question and one answer
            var qs = new ClQuestions();
            var qid = qs.GetMaxQuestionId();
            var aid = qs.GetMaxAnswerId();
            var jobid = Request.QueryString["jobid"];

            var question = Server.HtmlEncode(TextBoxQuestion.Text);
            var answer = Server.HtmlEncode(TextBoxAnswer.Text);

            qs.InsertQuestion(jobid, qid, question);
            qs.InsertAnswer(aid, answer);
            qs.InsertQuestionLink(qid, aid);

            PanelAddQuestions.Visible = false;
            PopulateData();
            TextBoxAnswer.Text = "";
            TextBoxQuestion.Text = "";
        }

        protected void ButtonAddAnswer(object sender, EventArgs e)
        {
            var lb = (LinkButton)sender;
            var stringctrl = lb.ID.Replace("AddAnswer_", "");
            var jobid = Request.QueryString["jobid"];
            
            var iqs = new ClQuestions();

            iqs.DeleteTempAnsByJob(jobid);
            iqs.InsertTempAns(stringctrl, Session.SessionID.ToString(), jobid);

            PopulateData();
            
        }

        protected void LinkButtonCancel_Click(object sender, EventArgs e)
        {
            LinkButtonAddQuestion.Visible = true;
            PanelAddQuestions.Visible = false;
            LabelChangesPending.Visible = false;
        }

        protected void ButonNewAnswer(object sender, EventArgs e)
        {
            LinkButton lb = (LinkButton)sender;
            var stringcorig = lb.ID.Replace("ButtonNewAnswer_", "");
            var stringctrl = "Panel_" + stringcorig;
            Panel p = (Panel)PanelQuestions.FindControl(stringctrl);

            //get text
            var stringtextbox = "TextNewAnswer";
            TextBox tb = (TextBox)p.FindControl(stringtextbox);
            var answer = Server.HtmlEncode(tb.Text);

            //insert answer
            var ians = new ClQuestions();
            var mgui = new Minimumguid();
            var maxans = mgui.MinGuid();

            ians.DeleteTempAns(stringcorig);
            ians.InsertAnswer(maxans, answer);
            ians.InsertQuestionLink(stringcorig, maxans);

            PopulateData();
        }

        protected void ButtonNewRemove(object sender, EventArgs e)
        {
            //simple remove all from jobs as we have single saving instance of each button

            var jobid = Request.QueryString["jobid"];
            var iqs = new ClQuestions();

            iqs.DeleteTempAnsByJob(jobid);

            PopulateData();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/recruiters/editjobs.aspx");
        }

    }
}