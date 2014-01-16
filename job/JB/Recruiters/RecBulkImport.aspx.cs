using System;
using Msftlayer;
using minGuid;

namespace JB.Recruiters
{
    public partial class Recbulkimport : ClCookie
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
        }

        protected void ButtonuploadClick(object sender, EventArgs e)
        {
            if (FileUploademployer.HasFile)
            {
                if (FileUploademployer.FileContent.Length < 1048576)
                {
                    #region beginupload

                    bool finvalue;

                    switch (RadioButtonList1.SelectedValue)
                    {
                        case "1":
                            {
                                //this is jobs
                                var cweb = new ClWebServiceImport();
                                finvalue = cweb.ProcessJobsfile(FileUploademployer.PostedFile.InputStream);
                            }
                            break;
                        default:
                            {
                                //this is recruiters
                                var cweb = new ClWebServiceImport();
                                finvalue = cweb.ProcessRecruiterfile(FileUploademployer.PostedFile.InputStream);
                            }
                            break;
                    }

                    switch (finvalue)
                    {
                        case true:
                            {
                                string flpath = Server.MapPath("/bulkimport/");

                                //get highest index for files
                                var clconv = new Minimumguid();
                                string hiindex = clconv.MinGuid();

                                //save file
                                FileUploademployer.SaveAs(Server.MapPath("/bulkimport/") + hiindex + "." + FileUploademployer.FileName);

                                //send message
                                Session["reasons"] = "Your file has been posted sucessfully! you should receive an email shortly";
                                Response.Redirect("/recruiters/confirmation");
                            }
                            break;
                        default:
                            Session["reasons"] = "Cannot validate your file! please try again and make sure you follow import guidelines";
                            Response.Redirect("/recruiters/confirmation");
                            break;
                    }

                    #endregion beginupload
                }
                else
                {
                    Session["reasons"] = "Check File size and make sure it's < 1mb";
                    Response.Redirect("/recruiters/confirmation");
                }
            }

            else
            {
                Session["reasons"] = "Please use standard file names! like \"testdata.csv\" or \"testdata.txt\" ";
                Response.Redirect("/recruiters/confirmation");
            }
        }
    }
}