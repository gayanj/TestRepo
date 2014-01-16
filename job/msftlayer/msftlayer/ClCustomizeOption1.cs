using System.Data;
using Memorylayer;

namespace Msftlayer
{
    public class ClCustomizeOption1
    {
        public DataTable Getfooterlinks()
        {
            var slcust = new MlCustomizeOption1();
            return slcust.Getfooterlinks();
        }

        public DataTable Getmiddlelinks()
        {
            var slcust = new MlCustomizeOption1();
            return slcust.Getmiddlelinks();
        }
    }
}