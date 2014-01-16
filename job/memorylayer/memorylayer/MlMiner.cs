using Mysqllayer;

namespace Memorylayer
{
    public class MlMiner
    {
        public string[,] Getmarketbasket(string matchs)
        {
            var slm = new SlMiner();
            return slm.Getmarketbasket(matchs);
        }
    }
}