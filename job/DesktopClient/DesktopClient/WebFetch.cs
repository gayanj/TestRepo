using System.IO;
using System.Net;
using System.Text;

namespace DesktopClient
{
    /// <summary>
    /// Fetches a Web Page
    /// </summary>
    internal class WebFetch
    {
        public Stream Gettexts(string webpage)
        {
            try
            {
                // used to build entire input
                var sb = new StringBuilder();

                // used on each read operation
                var buf = new byte[4096];

                // prepare the web page we will be asking for
                var request = (HttpWebRequest)WebRequest.Create(webpage);
                request.UserAgent = "MSIE";
                request.KeepAlive = false;
                request.MaximumAutomaticRedirections = 3;

                // execute the request
                var response = (HttpWebResponse)request.GetResponse();

                // we will read data via the response stream
                var resStream = response.GetResponseStream();

                return resStream;
            }

            catch { return null; }
        }
    }
}