using System;
using System.Globalization;
using Msftlayer;

namespace JB
{
    public partial class Pwdchange : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Request.IsSecureConnection)
            {
                //Response.Redirect(System.Configuration.ConfigurationManager.AppSettings["httpspaths"].ToString(CultureInfo.InvariantCulture) + "/passwordchanging");
            }
        }

        protected void Button2Click(object sender, EventArgs e)
        {
            Response.Redirect("/home");
        }

        protected void Button1Click(object sender, EventArgs e)
        {
            //set up passwords
            //but check first if the login really exists
            int usertype = Convert.ToInt16(Request.QueryString["utype"]);

            if (Request.QueryString["keyid"] != null)
            {
                var keyid = Request.QueryString["keyid"];

                var clapslog = new ClLogins();
                if (keyid == clapslog.Getkeyuser(keyid, usertype))
                {
                    //change password user
                    switch (usertype)
                    {
                        case 2:
                            clapslog.Updatepwdjswkey(keyid, TextBox1.Text);
                            Session["reasons"] = "Password Change sucessfull! <br /> Please login with your new password. <br /> ";
                            Response.Redirect("/confirm");
                            break;
                    }

                    //change admin password
                    switch (usertype)
                    {
                        case 1:
                            clapslog.Updatepwdrecwkey(keyid, TextBox1.Text);
                            Session["reasons"] = "Password Change sucessfull! <br /> Please login with your new password. <br /> ";
                            Response.Redirect("/confirm");
                            break;
                    }
                }
            }
        }
    }
}