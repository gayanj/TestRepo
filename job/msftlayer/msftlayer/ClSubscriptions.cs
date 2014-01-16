using Memorylayer;

namespace Msftlayer
{
    public class ClSubscriptions
    {
        public void Addsubscriptions(string emailaddr, int catid, int subcatid)
        {
            var mlsubsribe = new MlSubscriptions();
            mlsubsribe.Addsubscriptions(emailaddr, catid, subcatid);
        }

        public void Addsubscriptionpref(string emailaddr, int stype, int sfreq)
        {
            var clsubsribe = new MlSubscriptions();
            clsubsribe.Addsubscriptionpref(emailaddr, stype, sfreq);
        }

        public string Unsubscribe(string emailaddress)
        {
            var subscribe = new MlSubscriptions();

            if (subscribe.GetUnsubscriberId(emailaddress) == true)
            {
                return "You have already un-subscribed!";
            }

            else
            {
                subscribe.Unsubscribe(emailaddress);
                return emailaddress +" have unsubscribed from our future emails.";
            }
        }
    }
}