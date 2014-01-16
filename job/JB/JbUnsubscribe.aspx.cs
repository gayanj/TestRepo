using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Msftlayer;

namespace JB
{
    public partial class jbUnsubscribe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //run unsubscribing here.
            var iclass = new ClSubscriptions();

            if (Request.QueryString["email"] != null)
            {
                var emailaddress = Server.HtmlEncode(Request.QueryString["email"]);

                Label1.Text = iclass.Unsubscribe(emailaddress);
                
                Label1.Visible = true;

            }
        }
    }
}