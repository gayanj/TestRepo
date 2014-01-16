using Mysqllayer;

namespace Memorylayer
{
    public class MlSubscriptions
    {
        public void Addsubscriptions(string emailaddr, int catid, int subcatid)
        {
            var clsubsribe = new SlSubscriptions();
            clsubsribe.Addsubscriptions(emailaddr, catid, subcatid);
        }

        public void Addsubscriptionpref(string emailaddr, int stype, int sfreq)
        {
            var clsubsribe = new SlSubscriptions();
            clsubsribe.Addsubscriptionpref(emailaddr, stype, sfreq);
        }

        public void Unsubscribe(string emailaddress)
        {
            var subscribe = new SlSubscriptions();
            subscribe.Unsubscribe(emailaddress);
        }

        public bool GetUnsubscriberId(string emailadress)
        {
            var subscribe = new SlSubscriptions();
            return subscribe.GetUnsubscriberId(emailadress);
        }
    }
}