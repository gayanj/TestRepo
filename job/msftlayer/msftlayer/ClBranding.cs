using Memorylayer;

namespace Msftlayer
{
    public class ClBranding
    {
        //global branding option get
        public string Getbrandoption(string kname)
        {
            var mlbrand = new MlBranding();
            return mlbrand.Getbrandoption(kname);
        }
    }
}