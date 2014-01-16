using System;
using System.Globalization;
using Msftlayer;

namespace JB.Jobseekers
{
    public partial class Myresumes : ClCookie
    {
        readonly string _pathsetter = System.Configuration.ConfigurationManager.AppSettings["cvpath"].ToString(CultureInfo.InvariantCulture);

        protected void Page_Load(object sender, EventArgs e)
        {
            //read and validate login

            Isuserloginvalid();

            if (!IsPostBack)
            {
                //set conditions
                if (Session["pusername"] != null)
                {
                    //get resume
                    var clpriv = new ClPrivacy();
                    var apps = new ClApps();

                    string tempcanid = clpriv.Getcandidattesid(Session["pusername"].ToString());
                    string[] myresume = apps.Getmyresumes(tempcanid);
                    currresume.Text = myresume[0];

                    if (myresume[0] == "default")
                    {
                        curresumeimg.ImageUrl = "~/images/nopic.gif";
                        currresume.Text = "No resume on file!";
                    }

                    else if (myresume[0].Contains(".txt"))
                    {
                        curresumeimg.ImageUrl = "~/images/textresume.gif";
                    }

                    else if (myresume[0].Contains(".pdf"))
                    {
                        curresumeimg.ImageUrl = "~/images/pdfresume.gif";
                    }

                    else
                    {
                        curresumeimg.ImageUrl = "~/images/wordresume.gif";
                    }
                }
            }
        }

        protected void ButtoncancelClick(object sender, EventArgs e)
        {
            Response.Redirect("/jobseekers/home");
        }

        protected void ButtonsaveClick(object sender, EventArgs e)
        {
            if (Fupload.FileName != "")
            {
                if (Fupload.FileBytes.Length < Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["uploadfilesize"]))
                {
                    string fname = Fupload.FileName;
                    string fext = System.IO.Path.GetExtension(fname);

                    switch (fext)
                    {
                        case ".pdf":
                        case ".docx":
                        case ".doc":
                        case ".txt":
                            if (Session["pusername"] != null)
                            {
                                //get candidateid
                                var clpriv = new ClPrivacy();
                                string tempcanid = clpriv.Getcandidattesid(Session["pusername"].ToString());

                                var clap = new ClApps();
                                clap.Updatemyresumes(Fupload.FileName, _pathsetter, tempcanid);

                                Response.Redirect("myresumes.aspx");
                            }
                            break;
                        default:
                            Label2.Text = "Only text, doc, docx and pdf documents are allowed!";
                            break;
                    }
                }

                else
                {
                    Label2.Text = "File size more then 512kb!";
                }
            }
            else
            {
                Label2.Text = "required";
            }
        }
    }
}