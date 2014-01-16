using Memorylayer;

namespace Msftlayer
{
    public class ClSpamFilter
    {
        public void Addspamrec(int spamid, string spamreason, string remaddr, string usragnt, string jobid)
        {
            var dlspam = new MlSpamFilter();
            dlspam.Addspamrec(spamid, spamreason, remaddr, usragnt, jobid);
        }
    }
}