using Memorylayer;

namespace Msftlayer
{
    public class ClMiner
    {
        public string[,] Getmarketbasket(string matchs)
        {
            var mlm = new MlMiner();
            return mlm.Getmarketbasket(matchs);
        }
    }
}