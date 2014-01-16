using Memorylayer;

namespace Msftlayer
{
    public class ClDebug
    {
        public void Insertdebuggcode(string rawvalues, string pagename, string ex_data, string ex_type, string ex_innerexception, string ex_messege, string ex_source, string ex_stack, string ex_targetsite, string ex_url)
        {
            var sld = new MlDebug();
            sld.Insertdebuggcode(rawvalues, pagename, ex_data, ex_type, ex_innerexception, ex_messege, ex_source, ex_stack, ex_targetsite, ex_url);
        }
    }
}