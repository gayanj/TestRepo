using System;
using System.Globalization;
using System.Text;
using System.Xml;
using Msftlayer;

namespace JB.V1
{
    public partial class Jbrss : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Clear any previous output from the buffer
                Response.Clear();
                Response.ContentType = "text/xml";
                var xtwFeed = new XmlTextWriter(Response.OutputStream, Encoding.UTF8);
                xtwFeed.WriteStartDocument();
                xtwFeed.WriteStartElement("rss");
                xtwFeed.WriteAttributeString("version", "2.0");
                xtwFeed.WriteStartElement("channel");
                xtwFeed.WriteElementString("title", System.Configuration.ConfigurationManager.AppSettings["rsshead"].ToString(CultureInfo.InvariantCulture));
                xtwFeed.WriteElementString("description", System.Configuration.ConfigurationManager.AppSettings["rssdescription"].ToString(CultureInfo.InvariantCulture));
                xtwFeed.WriteElementString("link", System.Configuration.ConfigurationManager.AppSettings["httppaths"].ToString(CultureInfo.InvariantCulture));
                xtwFeed.WriteElementString("copyright", System.Configuration.ConfigurationManager.AppSettings["copyrights"].ToString(CultureInfo.InvariantCulture));

                //loop here ...
                //get job rss
                var clrs = new ClJobFeed();
                var rssarray = clrs.Getrss();
                var jobidclean = string.Empty;
                var jobtitleclean = string.Empty;

                for (var i = 0; i < rssarray.GetLength(1); i++)
                {
                    if (rssarray[0, i] != null)
                    {
                        xtwFeed.WriteStartElement("item");
                        jobidclean = rssarray[0, i].Replace("&", "&amp;").Replace("\"", "&quot;").Replace("'", "&apos;").Replace("<", "&lt;").Replace(">", "&gt;");
                        jobtitleclean = rssarray[1, i].Replace("&", "&amp;").Replace("\"", "&quot;").Replace("'", "&apos;").Replace("<", "&lt;").Replace(">", "&gt;");
                        xtwFeed.WriteElementString("title", rssarray[1, i].Replace("&", "&amp;").Replace("\"", "&quot;").Replace("'", "&apos;").Replace("<", "&lt;").Replace(">", "&gt;"));
                        xtwFeed.WriteElementString("description", rssarray[2, i].Replace("&", "&amp;").Replace("\"", "&quot;").Replace("'", "&apos;").Replace("<", "&lt;").Replace(">", "&gt;"));
                        xtwFeed.WriteElementString("pubDate", Convert.ToDateTime(rssarray[3, i]).ToString("r").Replace("&", "&amp;").Replace("\"", "&quot;").Replace("'", "&apos;").Replace("<", "&lt;").Replace(">", "&gt;"));
                        xtwFeed.WriteElementString("link", System.Configuration.ConfigurationManager.AppSettings["httppaths"].ToString(CultureInfo.InvariantCulture) + "/Jobdetails.aspx?jobid=" + jobidclean);
                        xtwFeed.WriteEndElement();
                    }
                }

                xtwFeed.WriteEndElement();
                xtwFeed.WriteEndElement();
                xtwFeed.WriteEndDocument();
                xtwFeed.Flush();
                xtwFeed.Close();
                Response.End();
            }
        }
    }
}