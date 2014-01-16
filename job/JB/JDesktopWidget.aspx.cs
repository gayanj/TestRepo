using System;
using System.Globalization;
using System.Web.UI;

namespace JB
{
    public partial class Jdesktopwidget : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.IsSecureConnection)
            {
                Response.Redirect(System.Configuration.ConfigurationManager.AppSettings["httppaths"].ToString(CultureInfo.InvariantCulture) + "/desktopwidget");
            }
        }

        protected void ImageButton1Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("/en_GB/dtwidget.exe");
        }
    }
}