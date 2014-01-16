using System;
using System.Text;
using Msftlayer;

namespace JB.Jobseekers
{
    public partial class Changeuserpwd : ClCookie
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //set default inputs
            TextBox1.Focus();
            Page.Form.DefaultButton = Button1.UniqueID;

            Isuserloginvalid();
        }

        protected void Button1Click(object sender, EventArgs e)
        {
            var cllg = new ClLogins();

            //check passwords is ok first
            if (cllg.Getjobuser(Session["pusername"].ToString(), TextBox1.Text) != null)
            {
                if (TextBox2.Text != "" || TextBox3.Text != "")
                {
                    if (TextBox2.Text == TextBox3.Text)
                    {
                        //change pwd
                        cllg.Updatejspwd(Session["pusername"].ToString(), TextBox2.Text);
                        var sb = new StringBuilder();
                        for (int iasb = 0; iasb < TextBox3.Text.Length; iasb++)
                        {
                            sb.Append("*");
                        }
                        Session["reasons"] = "Password Changed to " + sb.ToString() + " Please use this from now onwards";
                        Response.Redirect("Canconfirm.aspx");
                    }

                    else
                    {
                        LabelNotify.Text = "New Password donot match!";
                    }
                }
                else
                {
                    LabelNotify.Text = "Password cannot be Empty!";
                }
            }

            else
            {
                //check pwd
                LabelNotify.Text = "Please check your old password!";
            }
        }

        protected void Button2Click(object sender, EventArgs e)
        {
            Response.Redirect("/jobseekers/home");
        }
    }
}