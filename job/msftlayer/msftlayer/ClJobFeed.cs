using Memorylayer;

namespace Msftlayer
{
    public class ClJobFeed
    {
        public string[,] Getrss()
        {
            var mlr = new MlJobFeed();
            return mlr.Getrss();
        }
    }
}