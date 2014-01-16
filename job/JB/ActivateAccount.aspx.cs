using System;
using Msftlayer;

namespace JB
{
    public partial class ActivateAccount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1Click(object sender, EventArgs e)
        {
            if (RadioButtonList1.SelectedItem.Value == "1")
            {
                //activate the account
                if (Request.QueryString["usertype"] != null && Request.QueryString["username"] != null && Request.QueryString["activationid"] != null)
                {
                    int usertype = Convert.ToInt16(Request.QueryString["usertype"]);
                    var username = Request.QueryString["username"];
                    var activation = Request.QueryString["activationid"];

                    var cllog = new ClLogins();
                    cllog.UpdateactivateAcc(usertype, username, activation);
                }

                //redirect
                Session["reasons"] = "Your account has been activated please login using your email and password!";
                Response.Redirect("/confirm.aspx");
            }

            else
            {
                Session["reasons"] = "You must agree to subcats and conditions before using our site!";
                Response.Redirect("/confirm.aspx");
            }
        }
    }
}