using Memorylayer;

namespace Msftlayer
{
    public class ClVersionControl
    {
        public string Getcurrentversion()
        {
            var mlver = new MlVersionControl();
            return mlver.Getcurrentversion().ToString();
        }
    }
}