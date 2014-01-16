using System;
using System.Collections;
using System.Globalization;
using System.Web.UI;
using System.Web.UI.WebControls;
using Msftlayer;
using minGuid;
using System.Configuration;

namespace JB.Jobseekers
{
    public partial class Directapplication : System.Web.UI.Page
    {
        readonly string _pathsetter = System.Configuration.ConfigurationManager.AppSettings["cvpath"].ToString(CultureInfo.InvariantCulture);

        private void PopulateData()
        {           
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
                lb.CssClass = "ft_blackbd";
                Label tb = new Label();
                tb.Text = al[qs + 1].ToString();
                tb.ID = "Question_" + al[qs].ToString();
                tb.CssClass = "ft_blackbd";

                Literal li = new Literal();
                li.Text = "<br/>";

                RadioButtonList rb = new RadioButtonList();
                rb.ID = "RList_" + al[qs].ToString();
                rb.CssClass = "ft_black";
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

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //set default inputs
                TextBox3.Focus();
                Page.Form.DefaultButton = Button4.UniqueID;

                PopulateData();
            }

            //else loop through the cookie.
        }

        private void Addans(string idjobs, string appid)
        {
            var iqs = new ClQuestions();

            foreach (Control ci in PanelQuestions.Controls)
            {
                if (ci is Panel)
                {
                    Panel p = (Panel)ci;

                    foreach (Control cp in p.Controls)
                    {
                        try
                        {
                            RadioButtonList rb = (RadioButtonList)cp;
                            var qs = Convert.ToInt32(rb.ID.ToString().Replace("RList_", ""));

                            foreach (ListItem li in rb.Items)
                            {
                                if (li.Selected == true)
                                {
                                    var ansid = Convert.ToInt32(li.Value.Replace("Answer_", ""));
                                    var ans = li.Text;

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
        }

        private void Adddata(string idjobs)
        {
            //add max count
            var cc = new Minimumguid();
            string fnames = cc.MinGuid();
            string fileorigname = FileUpload2.FileName;

            FileUpload2.SaveAs(Server.MapPath(_pathsetter) + fnames + fileorigname);

            var app = new ClApps();
            var mgid = new Minimumguid();

            //apps add
            string mxdocid = mgid.MinGuid();
            string mxappid = mgid.MinGuid();

            //insert apps
            app.Insertapplication(Server.HtmlEncode(TextBox3.Text), Server.HtmlEncode(TextBox4.Text), Server.HtmlEncode(TextBox2.Text), mxdocid, Server.HtmlEncode(TextBox6.Text));
            app.Insertapplicationmapping(idjobs, mxappid);
            app.Insertdocuments(fileorigname, _pathsetter + fnames + fileorigname);

            //hook up questions

            Addans(idjobs, mxappid);
        }

        private int Processapp(string idjobs)
        {
            //checkcode
            //get email body
            var emp = new ClEmailProcessor();

            string fname = FileUpload2.PostedFile.FileName.ToString(CultureInfo.InvariantCulture);

            string ext = string.Empty;

            //get jobname and recruiters name
            //string subjects = emp.Getsubdirectapp(idjobs);

            if (fname.Contains("doc") || fname.Contains("docx") || fname.Contains("pdf"))
            {
                Adddata(idjobs);
                emp.Sendmailproc(TextBox6.Text, "FashionQuadrant: Application Confirmation!", "<div style=\"width:500px\"><div style=\"-moz-box-shadow: 3px 3px 4px #ccc; -webkit-box-shadow: 3px 3px 4px #ccc; box-shadow: 3px 3px 4px #ccc;-ms-filter: \"progid:DXImageTransform.Microsoft.Shadow(Strength=4, Direction=135, Color=\"#cccccc\")\";filter: progid:DXImageTransform.Microsoft.Shadow(Strength=4,Direction=135,Color=\"#cccccc\"); font-family: Helvetica, Verdana, sans-serif; margin: 10px 0px 0px 10px;\"><div style=\"background-color: #000; border-width: 1px; border-collapse: collapse; border-style: solid;\"><div style=\"color: #FFFFFF; min-height: 48px; background-color: #000; display: inline-block; vertical-align: middle;\"><img alt=\"fashion quadrant\" src=\"" + ConfigurationManager.AppSettings["httppaths"].ToString() + "/brandimages/brand_mail.png\"/></div><div style=\"border-color: #999; border-bottom-style: solid; border-width: 2px; border-top-style: solid; background-color: #666; padding: 10px 10px 10px 10px; color: #E6E6E6; font-size: 14px; min-height:300px;\"><span style=\"font-size:20px;\">Dear " + TextBox3.Text + " " + TextBox4.Text + ",</span><br/><br/>Thankyou for applying on fashion quadrant, if you are shortlisted the recruiter will get in touch with you directly. We wish you best of luck in your job hunt.<br/><br/>Sincerely,<br/><br/><b>Fashion Quadrant</b><br/><br/><br/><br/><span style=\"line-height:12px;font-size:11px;\"> NOTE: We will never ask you for any payment neither your credit or debit card numbers or any relating financial information via Email.</span> </div><div style=\"color:#ccc; background-color: #333; padding: 2px 4px 2px 4px; border-color: GrayText; line-height:12px; font-size: 11px;\">Copyrights 2013 Fashion Quadrant</b><br/>Please do not reply to this auto generated message. We respect your privacy, to review our privacy policy visit <a style=\"color: #ccc; text-decoration: none;\" href=\"http://fashionquadrant.com/privacy\" >www.fashionquadrant.com/privacy</a>. If you need to contact us send us an email at: <a href=\"mailto:info@fashionquadrant.com\" style=\"color: #ccc; text-decoration: underline\">info@fashionquadrant.com</a>.If you don&#39;t want to receive these emails from fashionquadrant in the future or have your email address re-used, you can unsubscribe by sending an email with subject unsubscribe to: <a href=\"mailto:info@fashionquadrant.com\" style=\"color: #ccc; text-decoration: underline\">info@fashionquadrant.com</a></div></div></div></div>", 0);
                //emp.Insertappemaildb(TextBox6.Text, 0);

                return 0;
            }

            else
            {
                return 1;
            }
        }

        protected void Button3Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }

        private int RequestCheck()
        {
            if (TextBox3.Text == "")
            {
                LabelNotify.Text = "FirstName is required!";
                return 1;
            }

            else if (TextBox4.Text == "")
            {
                LabelNotify.Text = "LastName is required!";
                return 1;
            }

            else if (TextBox6.Text == "")
            {
                LabelNotify.Text = "Please enter email address!";
                return 1;
            }

            else if (TextBox6.Text.Contains("@") == false && TextBox6.Text.Contains(".") == false)
            {
                LabelNotify.Text = "Not a valid email!";
                return 1;
            }

            else
            {
                return 0;
            }
        }

        protected void Button4Click(object sender, EventArgs e)
        {
            var rq = RequestCheck();

            if (rq == 0)
            {
                if (CapText.Text == Session["capts"].ToString())
                {

                    #region processapp

                    //Image11.Visible = true;
                    if (FileUpload2.HasFile)
                    {
                        if (FileUpload2.PostedFile.ContentLength <
                            Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["uploadfilesize"]))
                        {
                            string fname = FileUpload2.FileName;
                            string fext = System.IO.Path.GetExtension(fname);

                            if (fext == ".txt" || fext == ".doc" || fext == ".docx" || fext == ".pdf")
                            {
                                #region beginfupload

                                int statusf = 0;

                                //handle resume upload from user
                                if (Request.QueryString["jobid"] != null)
                                {
                                    if (Request.QueryString["jobid"] == "incart")
                                    {
                                        //process job cart loop
                                        string jobcart = null; //readcookies("jobcart");
                                        if (jobcart != null)
                                        {
                                            string[] splitonchar = { "," };
                                            string[] jobcartsplitter = jobcart.Split(splitonchar,
                                                                                     StringSplitOptions.None);

                                            //get jobs from db
                                            //Cljobcart clcart = new Cljobcart();
                                            foreach (string si in jobcartsplitter)
                                            {
                                                statusf = Processapp(Server.HtmlEncode(si));
                                            }
                                        }
                                    }
                                    else
                                    {
                                        string tempjid = Server.HtmlEncode(Request.QueryString["jobid"]);
                                        statusf = Processapp(tempjid);
                                    }
                                }

                                else
                                {
                                    //this is just for resume uploaders who want cv floated
                                    statusf = Processapp("0");
                                }

                                if (statusf == 0)
                                {
                                    //ClientScript.RegisterStartupScript(this.GetType(), "scriptrg4", "<script type=\"text/javascript\">clearjobbasket();</script>");

                                    Session["reasons"] =
                                        "Thank you for applying, we wish you best of luck with your application!!!";
                                    Response.Redirect("~/confirm.aspx");
                                }

                                else
                                {
                                    LabelNotify.Text = "Error Uploading file!!!";
                                }

                                #endregion beginfupload
                            }
                            else
                            {
                                LabelNotify.Text = "Only text, doc, docx and pdf documents are allowed!";
                            }
                        }

                        else
                        {
                            LabelNotify.Text = "File size more then 512kb!";
                        }
                    }
                    else
                    {
                        LabelNotify.Text = "Please select a resume to upload!";
                    }

                    #endregion processapp

                }

                else
                {
                    LabelNotify.Text = "Please type text as shown in captcha!";
                }
            }
        }

    }
}