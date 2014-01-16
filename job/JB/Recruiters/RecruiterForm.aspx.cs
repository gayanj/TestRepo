using System;
using System.Globalization;
using System.IO;
using Msftlayer;

namespace JB.Recruiters
{
    public partial class RecruiterForm : ClCookie
    {
        private bool validator()
        {
            if (TextBox2.Text == "")
            {
                LabelNotify.Text = "First Name required!";
                return true;
            }

            else if (TextBox3.Text == "")
            {
                LabelNotify.Text = "Last Name required!";
                return true;
            }

            else if (TextBox4.Text == "")
            {
                LabelNotify.Text = "Address1 is required!";
                return true;
            }

            else if (TextBox7.Text == "")
            {
                LabelNotify.Text = "Town is required!";
                return true;
            }

            else if (TextBox8.Text == "")
            {
                LabelNotify.Text = "County is required!";
                return true;
            }

            else if (TextBox9.Text == "")
            {
                LabelNotify.Text = "Post Code is required!";
                return true;
            }

            else
            {
                return false;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //set default inputs
            TextBox2.Focus();
            Page.Form.DefaultButton = Button2.UniqueID;

            if (!IsPostBack)
            {
                if (Session["pusername"] != null)
                {
                    //int Fg = Convert.ToInt16(Request.QueryString["Fg"]);

                    var mpage = new ClMainPagePopulator();

                    string recsid = mpage.Getrecname(Session["pusername"].ToString());

                    //panel2 should be hidden as it has recruiter pwds
                    //Panel2.Visible = false;

                    //disable required fields
                    //RequiredFieldValidator9.Enabled = false;
                    //RequiredFieldValidator11.Enabled = false;

                    Isuserloginvalid();
                    ////////////////////////////////////

                    //make sure recruiters cannot change companies
                    TextBox10.Enabled = false;

                    string[] arr = mpage.GetRecDetails(Session["pusername"].ToString());

                    TextBox2.Text = arr[0];
                    TextBox3.Text = arr[1];

                    TextBox10.Text = arr[2];

                    TextBox4.Text = arr[3];
                    TextBox5.Text = arr[4];
                    TextBox6.Text = arr[5];

                    TextBox7.Text = arr[6];
                    TextBox8.Text = arr[7];
                    //TextBox9.Text = arr[8];
                    TextBox9.Text = arr[9];

                    //TextBox12.Text = arr[10];
                    //TextBox13.Text = arr[11];

                    //TextBox11.Text = Session["pusername"].ToString();
                    //TextBox11.Enabled = false;

                    TextBox14.Text = arr[15];
                    TextBox16.Text = arr[14];

                    TextBox15.Text = arr[13];
                    DropDownList1.SelectedValue = arr[16];

                    //TextBox12.Enabled = false;
                    //TextBox13.Enabled = false;
                    //TextBox17.Enabled = false;
                    Button3.Visible = false;

                    //Panel1.Visible = false;

                    // featured recurites
                    var frs = new ClFeaturedRecruiters();

                    //get recruters image
                    Image8.Visible = true;
                    Image8.ImageUrl = frs.Getrecformimage(recsid);
                }

                else
                {
                    Image8.Visible = false;
                }
            }
        }

        private string en(string _input)
        {
            return Server.HtmlEncode(_input.Trim());
        }

        protected void Button2Click(object sender, EventArgs e)
        {
            if (validator() == false)
            {
                //check if the current user exists in the database
                var lgeins = new ClLogins();

                //Fg = Convert.ToInt16(Request.QueryString["Fg"]);

                #region update rec

                //update
                //update user rec information
                var yohrecl = new ClRecruiters();

                string rectmpsid = Session["pusername"].ToString();

                yohrecl.Runrecuserupdate(en(TextBox2.Text), en(TextBox3.Text), rectmpsid);

                //update logo
                if (FileUpload1.HasFile)
                {
                    //get current artifact id for the logo.
                    var tmpartid = yohrecl.Getartifactids(rectmpsid);

                    //save to hlogo
                    var hlogo = Path.GetFileName(FileUpload1.FileName.ToString(CultureInfo.InvariantCulture));

                    //update artifacts
                    FileUpload1.PostedFile.SaveAs(Server.MapPath("/artifacts/") + tmpartid + hlogo);

                    //update artifacts in db
                    yohrecl.Runreclogoupdate("/artifacts/" + tmpartid + hlogo, FileUpload1.FileName.ToString(CultureInfo.InvariantCulture), rectmpsid);
                }

                var tempcmptype = true;

                switch (DropDownList1.SelectedValue)
                {
                    case "0":
                        tempcmptype = false;
                        break;
                    default:
                        tempcmptype = true;
                        break;
                }

                //update recruiters own information
                yohrecl.Runrectableupdate(en(TextBox4.Text), en(TextBox5.Text), en(TextBox6.Text), en(TextBox7.Text), en(TextBox8.Text), en(TextBox9.Text), en(TextBox10.Text), en(TextBox15.Text), en(TextBox16.Text), TextBox14.Text, Session["pusername"].ToString(), tempcmptype);

                Session["reasons"] = "Profile information updated sucessfully!";
                Response.Redirect("/recruiters/confirmation");

                #endregion update rec

            }
        }

        protected void Button3Click(object sender, EventArgs e)
        {
            Response.Redirect("/home");
        }
    }
}