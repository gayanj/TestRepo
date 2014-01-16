using System;
using System.Globalization;
using System.Text;
using System.Xml;
using Msftlayer;

namespace JB.V1
{
    public partial class Jobx : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the themes
            //gray default theme
            var themeidstr = "type=\"text/xsl\" href=\"hawkx1.xslt\"";

            if (Request.QueryString["theme"] != null)
            {
                var themename = Request.QueryString["theme"];
                switch (themename)
                {
                    case "Aqua":
                        themeidstr = "type=\"text/xsl\" href=\"hawkx2.xslt\"";
                        break;
                    case "Soil":
                        themeidstr = "type=\"text/xsl\" href=\"hawkx1.xslt\"";
                        break;
                    case "Rose":
                        themeidstr = "type=\"text/xsl\" href=\"hawkx3.xslt\"";
                        break;
                    case "Dewgreen":
                        themeidstr = "type=\"text/xsl\" href=\"hawkx4.xslt\"";
                        break;
                    default:
                        break;
                }
            }

            //set culture for future use
            var langs = "en-GB";

            if (Request.QueryString["lang"] != null)
            {
                langs = Request.QueryString["lang"];
            }

            //get the string details for text ads
            var clads = new ClAdverts();
            var tarr = clads.Getdesktoptadstr();
            Response.Clear();
            Response.ContentType = "text/xml";
            var writer = new XmlTextWriter(Response.OutputStream, Encoding.UTF8);
            writer.WriteStartDocument();
            writer.WriteProcessingInstruction("xml-stylesheet", themeidstr);
            writer.WriteStartElement("catalog");
            writer.WriteAttributeString("culture", langs);

            #region advert

            //write adverts
            writer.WriteStartElement("advertcatalog");
            writer.WriteStartElement("advert");
            writer.WriteAttributeString("id", "1");
            writer.WriteElementString("title", tarr[0]);
            writer.WriteElementString("headerad", "Ads");
            writer.WriteElementString("shortdescription", tarr[1]);
            writer.WriteElementString("hlink", tarr[2]);
            writer.WriteEndElement();
            writer.WriteEndElement();

            #endregion advert

            writer.WriteStartElement("jobcatalog");

            //for loop here
            var clrs = new ClJobFeed();
            var rssarray = clrs.Getrss();

            for (var i = 0; i < rssarray.GetLength(1); i++)
            {
                if (rssarray[0, i] != null)
                {
                    writer.WriteStartElement("job");
                    writer.WriteAttributeString("id", rssarray[0, i]);
                    writer.WriteElementString("title", rssarray[1, i]);
                    writer.WriteElementString("shortdescription", rssarray[2, i].ToString(CultureInfo.InvariantCulture).Length > 99 ? rssarray[2, i].Substring(0, 100) + "..." : rssarray[2, i].ToString(CultureInfo.InvariantCulture));
                    writer.WriteElementString("posteddate", Convert.ToDateTime(rssarray[3, i]).ToShortDateString());
                    writer.WriteElementString("hlink", System.Configuration.ConfigurationManager.AppSettings["httppaths"].ToString(CultureInfo.InvariantCulture) + "/Jobdetails.aspx?jobid=" + rssarray[0, i] + "&jobtitle=" + rssarray[1, i]);
                    writer.WriteEndElement();
                }
            }

            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Flush();
            writer.Close();
            Response.End();
        }
    }
}