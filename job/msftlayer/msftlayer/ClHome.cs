using Memorylayer;

namespace Msftlayer
{
    public class ClHome
    {
        public object Gethplocation()
        {
            var clh = new MlHome();
            return clh.Gethplocation();
        }

        public object Gethpindustry()
        {
            var clh = new MlHome();
            return clh.Gethpindustry();
        }

        public object Gethpsalary()
        {
            var clh = new MlHome();
            return clh.Gethpsalary();
        }

        public void Reloadgethpindustry()
        {
            var clh = new MlHome();
            clh.Reloadgethpindustry();
        }

        public void Reloadgethplocation()
        {
            var clh = new MlHome();
            clh.Reloadgethplocation();
        }

        public void Reloadgethpsalary()
        {
            var clh = new MlHome();
            clh.Reloadgethpsalary();
        }
    }
}