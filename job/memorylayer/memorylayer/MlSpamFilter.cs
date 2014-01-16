using Mysqllayer;

namespace Memorylayer
{
    public class MlSpamFilter
    {
        public void Addspamrec(int spamid, string spamreason, string remaddr, string usragnt, string jobid)
        {
            var clspam = new SlSpamFilter();
            clspam.Addspamrec(spamid, spamreason, remaddr, usragnt, jobid);
        }
    }
}