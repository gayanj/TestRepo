using Mysqllayer;

namespace Memorylayer
{
    public class MlBranding
    {
        //global branding option get
        public string Getbrandoption(string kname)
        {
            var clbrand = new SlBranding();
            return clbrand.Getbrandoption(kname);
        }
    }
}