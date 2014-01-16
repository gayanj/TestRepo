using Mysqllayer;

namespace Memorylayer
{
    public class MlVideo
    {
        public void Addvideo(string videotitle, string videourl,string idjobs)
        {
            var slv = new SlVideo();
            slv.Addvideo(videotitle, videourl, idjobs);
        }

        public void Enablevideo(string idjobs)
        {
            var slv = new SlVideo();
            slv.Enablevideo(idjobs);
        }

        public void Disablevideo(string idjobs)
        {
            var slv = new SlVideo();
            slv.Disablevideo(idjobs);
        }

        public void Updatevideo(string videotitle, string videourl, string idjobs)
        {
            var slv = new SlVideo();
            slv.Updatevideo(videotitle, videourl, idjobs);
        }

        public void Removevideo(string idjobs)
        {
            var slv = new SlVideo();
            slv.Removevideo(idjobs);
        }

        public string[] Getvideo(string idjobs)
        {
            var slv = new SlVideo();
            return slv.Getvideo(idjobs);
        }
    }
}