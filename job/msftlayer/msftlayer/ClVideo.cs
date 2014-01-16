using Memorylayer;

namespace Msftlayer
{
    public class ClVideo
    {
        public void Addvideo(string videotitle, string videourl, string idjobs)
        {
            var mlv = new MlVideo();
            mlv.Addvideo(videotitle, videourl, idjobs);
        }

        public void Enablevideo(string idjobs)
        {
            var slv = new MlVideo();
            slv.Enablevideo(idjobs);
        }

        public void Disablevideo(string idjobs)
        {
            var slv = new MlVideo();
            slv.Disablevideo(idjobs);
        }

        public void Updatevideo(string videotitle, string videourl, string idjobs)
        {
            var mlv = new MlVideo();
            mlv.Updatevideo(videotitle, videourl, idjobs);
        }

        public void Removevideo(string idjobs)
        {
            var mlv = new MlVideo();
            mlv.Removevideo(idjobs);
        }

        public string[] Getvideo(string idjobs)
        {
            var mlv = new MlVideo();
            return mlv.Getvideo(idjobs);
        }
    }
}