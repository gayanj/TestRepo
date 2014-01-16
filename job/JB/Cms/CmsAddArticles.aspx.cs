using System;
using Msftlayer;

namespace JB.Cms
{
    public partial class Cmsarticles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var iclass = new ClCmsClass();
            DropDownList1.DataSource = iclass.Getcmsarticletheme();
            DropDownList1.DataTextField = "Name";
            DropDownList1.DataValueField = "idthemes";
            DropDownList1.DataBind();
            
        }

        protected void Buttonsave_Click(object sender, EventArgs e)
        {
            var clart = new ClArticles();
            var articleurl = Server.HtmlEncode(TextBoxarticlename.Text.ToLower()).Replace(" ", "-");
            clart.Insertarticles(Server.HtmlEncode(TextBoxarticlename.Text), Server.HtmlEncode(articleurl), Server.HtmlEncode(Editor1.Content));
        }
    }
}