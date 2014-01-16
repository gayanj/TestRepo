using System.Text.RegularExpressions;
using System.Web.UI;

namespace Msftlayer
{
    public class ClHtmlWrap : System.Web.UI.MasterPage
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

                //if (Session["language"] != null)
                //{
                //    //var lang = Session["language"].ToString();
                //    //if (lang == "DE")
                //    //{
                //    //    var itranslate = new ClTranslator();
                //    //    html = itranslate.Getsplitedstring(html);
                //    //    writer.Write(html.Trim());
                //    //}

                //    else { writer.Write(html.Trim()); }                    
                //}

                //else { 
                    writer.Write(html.Trim()); 
            //}
                
            }
        }
    }
}