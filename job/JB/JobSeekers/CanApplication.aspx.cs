using System;
using System.Globalization;
using Msftlayer;
using minGuid;
using System.Configuration;

namespace JB.Jobseekers
{
    public partial class Canapplication : ClCookie
    {
        readonly string _pathsetter = System.Configuration.ConfigurationManager.AppSettings["cvpath"].ToString(CultureInfo.InvariantCulture);

        protected void Page_Load(object sender, EventArgs e)
        {
            #region pgload

            //set default inputs
            TextBox2.Focus();
            Page.Form.DefaultButton = Button2.UniqueID;

            Isuserloginvalid();
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
            ////////////////////////////////////

            Label15.Text = "hi, " + Session["pusername"] + " please choose/update your cv/resume here";

            #endregion pgload
        }

        private void Adddata(string idjobs)
        {
            //get candidate first name, last name etc from db.
            var cclid = new ClCandidates();

            var temphldoldcan = cclid.Getcandidatesindb(Session["pusername"].ToString());

            if (temphldoldcan[0].Length > 0)
            {
                var mgid = new Minimumguid();

                //add max count                
                string fnames = mgid.MinGuid();
                var fileorigname = FileUpload1.FileName;

                FileUpload1.SaveAs(Server.MapPath(_pathsetter) + fnames + fileorigname);

                var app = new ClApps();                

                //apps add
                string mxdocid = mgid.MinGuid();
                string mxappid = mgid.MinGuid();

                //fill in app.
                app.Insertapplicationcan(mxappid, temphldoldcan[3], temphldoldcan[1], temphldoldcan[2], TextBox2.Text, mxdocid, Session["pusername"].ToString());
                app.Insertapplicationmapping(idjobs, mxappid);
                app.Insertdocuments(fileorigname, _pathsetter + fnames + fileorigname);

            }

            //ask the candidate to fill in his/her details
            else
            {
                LabelNotify.Text = "Please complete your candidate profile in order to apply!";
            }
        }

        private int Processapp(string idjobs)
        {
            var emp = new ClEmailProcessor();
            var fname = FileUpload1.PostedFile.FileName.ToString(CultureInfo.InvariantCulture);
            var ext = string.Empty;

            if (fname.Contains("doc") || fname.Contains("docx") || fname.Contains("pdf"))
            {

                Adddata(idjobs);
                emp.Sendmailproc(Session["pusername"].ToString(), "FashionQuadrant: Application Confirmation!", "<div style=\"width:500px\"><div style=\"-moz-box-shadow: 3px 3px 4px #ccc; -webkit-box-shadow: 3px 3px 4px #ccc; box-shadow: 3px 3px 4px #ccc;-ms-filter: \"progid:DXImageTransform.Microsoft.Shadow(Strength=4, Direction=135, Color=\"#cccccc\")\";filter: progid:DXImageTransform.Microsoft.Shadow(Strength=4,Direction=135,Color=\"#cccccc\"); font-family: Helvetica, Verdana, sans-serif; margin: 10px 0px 0px 10px;\"><div style=\"background-color: #000; border-width: 1px; border-collapse: collapse; border-style: solid;\"><div style=\"color: #FFFFFF; min-height: 48px; background-color: #000; display: inline-block; vertical-align: middle;\"><img alt=\"fashion quadrant\" src=\"" + ConfigurationManager.AppSettings["httppaths"].ToString() + "/brandimages/brand_mail.png\"/></div><div style=\"border-color: #999; border-bottom-style: solid; border-width: 2px; border-top-style: solid; background-color: #666; padding: 10px 10px 10px 10px; color: #E6E6E6; font-size: 14px; min-height:300px;\"><span style=\"font-size:20px;\">Dear Candidate,</span><br/><br/>Thankyou for applying on fashion quadrant, if you are shortlisted the recruiter will get in touch with you directly. We wish you best of luck in your job hunt.<br/><br/>Sincerely,<br/><br/><b>Fashion Quadrant</b><br/><br/><br/><br/><span style=\"line-height:12px;font-size:11px;\"> NOTE: We will never ask you for any payment neither your credit or debit card numbers or any relating financial information via Email.</span> </div><div style=\"color:#ccc; background-color: #333; padding: 2px 4px 2px 4px; border-color: GrayText; line-height:12px; font-size: 11px;\">Copyrights 2013 Fashion Quadrant</b><br/>Please do not reply to this auto generated message. We respect your privacy, to review our privacy policy visit <a style=\"color: #ccc; text-decoration: none;\" href=\"http://fashionquadrant.com/privacy\" >www.fashionquadrant.com/privacy</a>. If you need to contact us send us an email at: <a href=\"mailto:info@fashionquadrant.com\" style=\"color: #ccc; text-decoration: underline\">info@fashionquadrant.com</a>.If you don&#39;t want to receive these emails from fashionquadrant in the future or have your email address re-used, you can unsubscribe by sending an email with subject unsubscribe to: <a href=\"mailto:info@fashionquadrant.com\" style=\"color: #ccc; text-decoration: underline\">info@fashionquadrant.com</a></div></div></div></div>", 8);
                //emp.sendmailproc(Session["pusername"].ToString(), "Application Confirmation: Recruiter Name/Job Name", "Your application has been submitted sucessfully we will contact you in due course");
                //emp.Insertappemaildb(Session["pusername"].ToString(), 1);

                return 0;
            }

            else
            {
                return 1;
            }
        }

        protected void Button2Click(object sender, EventArgs e)
        {
            //check for resume on file
            switch (CheckBox1.Checked)
            {
                case true:
                    //take a document from db here

                    Session["reasons"] = "Thank you for applying, we wish you best of luck with your application!!!";
                    Response.Redirect("Canconfirm.aspx");
                    break;
                default:
                    if (FileUpload1.HasFile)
                    {
                        if (FileUpload1.PostedFile.ContentLength < Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["uploadfilesize"]))
                        {
                            var fname = FileUpload1.FileName;
                            var fext = System.IO.Path.GetExtension(fname);

                            if (fext == ".txt" || fext == ".doc" || fext == ".docx" || fext == ".pdf")
                            {
                                #region beginfupload

                                if (Request.QueryString["jobid"] != null)
                                {
                                    if (Request.QueryString["jobid"] == "incart")
                                    {
                                        //job cart
                                        string jobcart = null;
                                        if (jobcart != null)
                                        {
                                            string[] splitonchar = { "," };
                                            string[] jobcartsplitter = jobcart.Split(splitonchar, StringSplitOptions.None);

                                            //get jobs from db
                                            //Cljobcart clcart = new Cljobcart();
                                            int status = 0;

                                            foreach (string si in jobcartsplitter)
                                            {
                                                status = Processapp(Server.HtmlEncode(si));
                                                switch (status)
                                                {
                                                    case 1:
                                                        break;
                                                }
                                            }

                                            switch (status)
                                            {
                                                case 1:
                                                    LabelNotify.Text = "Error Uploading !!!";
                                                    break;
                                                default:
                                                    Session["reasons"] = "Thank you for applying, we wish you best of luck with your application!!!";
                                                    Response.Redirect("Canconfirm.aspx");
                                                    break;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        var status = Processapp(Server.HtmlEncode(Request.QueryString["jobid"]));
                                        switch (status)
                                        {
                                            case 0:
                                                Session["reasons"] = "Thank you for applying, we wish you best of luck with your application!!!";
                                                Response.Redirect("Canconfirm.aspx");
                                                break;
                                            default:
                                                LabelNotify.Text = "Error Uploading !!!";
                                                break;
                                        }
                                    }
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
                        LabelNotify.Text = "Please select a file to upload!";
                    }
                    break;
            }
        }

        protected void Button3Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }
    }
}