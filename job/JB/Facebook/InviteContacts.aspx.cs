using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Msftlayer;

namespace JB.Facebook
{
    public partial class InviteContacts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //send email
            ClEmailProcessor _em = new ClEmailProcessor();
            _em.Sendmailproc("noreply@fashionquadrant.com", TextBoxEmail.Text, Server.HtmlEncode(TextBoxSubject.Text), Server.HtmlEncode(TextBoxMsg.Text), 1);
        }
    }
}