using Memorylayer;

namespace Msftlayer
{
    public class ClJobCart
    {
        public string Getjobscart(string jid)
        {
            var mljcart = new MlJobCart();
            return mljcart.Getjobscart(jid);
        }
    }
}