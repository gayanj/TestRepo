using System;
using System.Globalization;
using System.Text;
using System.Xml;
using Msftlayer;

namespace JB.V1
{
    public partial class Jobxout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Clear();
            Response.ContentType = "text/xml";

            var writer = new XmlTextWriter(Response.OutputStream, Encoding.UTF8);

            //get adverts
            var clads = new ClAdverts();
            var adds = clads.Getdesktoptadstr();
            writer.WriteStartDocument();
            writer.WriteStartElement("catalog");
            writer.WriteAttributeString("culture", "en-GB");

            #region advert

            //write adverts
            writer.WriteStartElement("advertcatalog");
            writer.WriteStartElement("advert");
            writer.WriteAttributeString("id", "1");
            writer.WriteElementString("title", adds[0]);
            writer.WriteElementString("headerad", "Ads");
            writer.WriteElementString("shortdescription", adds[1]);
            writer.WriteElementString("hlink", adds[2]);
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