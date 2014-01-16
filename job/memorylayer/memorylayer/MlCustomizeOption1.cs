using System.Data;
using Mysqllayer;

namespace Memorylayer
{
    public class MlCustomizeOption1
    {
        public DataTable Getfooterlinks()
        {
            var slcust = new SlCustomizeOption1();
            return slcust.Getfooterlinks();
        }

        public DataTable Getmiddlelinks()
        {
            var slcust = new SlCustomizeOption1();
            return slcust.Getmiddlelinks();
        }
    }
}