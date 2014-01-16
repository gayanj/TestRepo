using System;
using Msftlayer;

namespace JB.Cms
{
    public partial class CmsEmailtemplates : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //email templates add
            var cempr = new ClEmailProcessor();
            cempr.Insertemailtemplate(Editor1.Content, 2, TextBox1.Text, Editor2.Content, Editor3.Content);
        }
    }
}