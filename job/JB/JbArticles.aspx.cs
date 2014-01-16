using System;
using System.Collections;
using System.Globalization;
using System.Web.UI.WebControls;
using Msftlayer;

namespace JB
{
    public partial class Jbarticles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.IsSecureConnection)
            {
                Response.Redirect(System.Configuration.ConfigurationManager.AppSettings["httppaths"].ToString(CultureInfo.InvariantCulture) + "/articles");
            }

            if (Request.QueryString["articleid"] != null)
            {
                string aid = Server.HtmlEncode(Request.QueryString["articleid"]);

                var lbl1 = new Label();
                var clart = new ClArticles();

                ArrayList al = clart.Getallarticlebyid(aid);

                Label1.Text = al[1].ToString();
                lbl1.Text = Server.HtmlDecode(al[3].ToString());

                PlaceHolder1.Controls.Add(lbl1);
            }
        }
    }
}