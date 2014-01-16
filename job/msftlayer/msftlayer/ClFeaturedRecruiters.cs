using System.Data;
using Memorylayer;

namespace Msftlayer
{
    public class ClFeaturedRecruiters
    {
        //get recruiters logo for profiles form
        public string Getrecformimage(string recsids)
        {
            var mfeatures = new MlFeaturedRecruiters();
            return mfeatures.Getrecformimage(recsids);
        }

        //featured recruiters on searched.aspx
        public DataTable GetFRecs()
        {
            var mfeatures = new MlFeaturedRecruiters();

            return mfeatures.GetFRecs();
        }

        public object Getrecofweek()
        {
            var mfeatures = new MlFeaturedRecruiters();
            return mfeatures.Getrecofweek();
        }
    }
}