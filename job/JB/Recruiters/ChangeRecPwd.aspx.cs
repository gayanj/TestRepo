using System;
using System.Text;
using Msftlayer;

namespace JB.Recruiters
{
    public partial class Changerecpwd : ClCookie
    {
        private bool performchecks()
        {
            var _sbr = new StringBuilder();
            bool flag = false;

            if (TextBox1.Text == "")
            {
                _sbr.Append("<b>Old password</b> is required!<br/>");
                flag = true;
            }

            else if (TextBox2.Text == "")
            {
                _sbr.Append("<b>New password</b> is required!<br/>");
                flag = true;
            }

            else if (TextBox3.Text == "")
            {
                _sbr.Clear();
                _sbr.Append("Confirm New password!<br/>");
                flag = true;
            }

            else  if (TextBox2.Text != TextBox3.Text)
            {
                _sbr.Append("New passwords donot match!<br/>");
                flag = true;
            }

            //call password validator
            var vpass = new ClPwdHash();

            if (vpass.Validatepassword(TextBox3.Text) == true && vpass.Validatepassword(TextBox2.Text) == true)
            {
                _sbr.Append("Password should only use Alphanumeric characters and symbols like @,#,$,! !<br/>");
                flag = true;
            }

            var _outstring = _sbr.ToString().TrimEnd('<', 'b', 'r', '/', '>');

            LabelNotify.Text = _outstring;

            return flag;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Isuserloginvalid();

            //set default inputs
            TextBox1.Focus();
            Page.Form.DefaultButton = Button1.UniqueID;

        }

        protected void Button1Click(object sender, EventArgs e)
        {
            if (performchecks() == false)
            {
                var cllg = new ClLogins();

                //check passwords is ok first
                if (cllg.Getuser(Session["pusername"].ToString(), TextBox1.Text) != null)
                {
                    if (TextBox2.Text == TextBox3.Text)
                    {
                        //change pwd
                        cllg.Updaterecpwd(Session["pusername"].ToString(), TextBox2.Text);
                        var sb = new StringBuilder();
                        for (int iasb = 0; iasb < TextBox3.Text.Length; iasb++)
                        {
                            sb.Append("*");
                        }
                        Session["reasons"] = "Password Changed to " + sb + " Please use this from now onwards";
                        Response.Redirect("/Recruiters/RecConfirm.aspx");
                    }

                    else
                    {
                        LabelNotify.Text = "New Password donot match";
                    }
                }

                else
                {
                    //check pwd
                    LabelNotify.Text = "Please Check your old password";
                }
            }
        }

        protected void Button2Click(object sender, EventArgs e)
        {
            Response.Redirect("/Recruiters/RecHome.aspx");
        }
    }
}