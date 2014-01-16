using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace Msftlayer
{
    public class ClWebFetch
    {
        public Stream Gethtmlpage(string webpage)
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


        public string FilterTags(string __Input)
        {
            Regex _R = new Regex(@">\s+<",RegexOptions.Compiled);

            string _Output = _R.Replace(__Input, "");

            return _Output;
        }
    }
}