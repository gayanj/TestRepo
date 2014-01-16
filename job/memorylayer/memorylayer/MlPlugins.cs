using Mysqllayer;

namespace Memorylayer
{
    public class MlPlugins
    {
        public string Getpluginsharethis()
        {
            var slplug = new SlPlugins();
            return slplug.Getpluginsharethis();
        }
    }
}