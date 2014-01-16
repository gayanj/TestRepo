using System;
using System.Text.RegularExpressions;
using System.Web.UI;

namespace JB.ResumeCenter
{
    public partial class Index : System.Web.UI.Page
    {
        protected override void Render(HtmlTextWriter writer)
        {
            using (var htmlwriter = new HtmlTextWriter(new System.IO.StringWriter()))
            {
                base.Render(htmlwriter);
                var html = htmlwriter.InnerWriter.ToString();

                var regexBetweenTags = new Regex(@">\s+<", RegexOptions.Compiled);
                var regexLineBreaks = new Regex(@"\n\s+", RegexOptions.Compiled);

                html = html.Replace("  ", " ");
                html = regexBetweenTags.Replace(html, "> <");
                html = regexLineBreaks.Replace(html, "");
                //html = html.Replace("\f", "");
                //html = html.Replace("\v", "");
                //html = html.Replace("\n", "");
                //html = html.Replace("<td>", "");
                //html = html.Replace("</td>", "");
                writer.Write(html.Trim());
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }
    }
}