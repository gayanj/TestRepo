using Mysqllayer;

namespace Memorylayer
{
    public class MlJobCart
    {
        public string Getjobscart(string jid)
        {
            var sljb = new SlJobCart();
            return sljb.Getjobscart(jid);
        }
    }
}