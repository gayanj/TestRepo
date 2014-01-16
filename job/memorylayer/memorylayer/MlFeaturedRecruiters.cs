using System;
using System.Configuration;
using System.Data;
using Mysqllayer;

namespace Memorylayer
{
    public class MlFeaturedRecruiters
    {
        //get recruiters logo for profiles form
        public string Getrecformimage(string recsids)
        {
            var cfeatures = new SlFeaturedRecruiters();
            return cfeatures.Getrecformimage(recsids);
        }

        public DataTable GetFRecs()
        {
            var cfeatures = new SlFeaturedRecruiters();
            return cfeatures.GetFRecs();
        }

        public object Getrecofweek()
        {
            var clman = new MLMemCached();
            //try
            //{
            //    clman.Fireservers();
            //}
            //catch (Exception e)
            //{
            //    Console.Write(e.Message);
            //}

            var mrec = clman.Getmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcrecofweek");

            if (mrec != null)
            {
                var mcrsststamp =
                    Convert.ToDateTime(clman.Getmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcdaytstamp1"));
                if (mcrsststamp.Date == DateTime.Now.Date)
                {
                    return mrec;
                }
                else
                {
                    //add a time stamp for refreshing memory
                    clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcdaytstamp1", DateTime.Now.Date);

                    //add to memory array
                    var cfeatures = new SlFeaturedRecruiters();
                    clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcrecofweek",
                                     cfeatures.Getrecofweek());
                    mrec = cfeatures.Getrecofweek();
                    return mrec;
                }
            }

            else
            {
                //add a time stamp for refreshing memory
                clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcdaytstamp1", DateTime.Now.Date);

                //add to memory object
                var cfeatures = new SlFeaturedRecruiters();
                clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcrecofweek", cfeatures.Getrecofweek());
                mrec = cfeatures.Getrecofweek();
                return mrec;
            }

            //SlFeaturedrecruiters cfeatures = new SlFeaturedrecruiters();
            //return cfeatures.Getrecofweek();
        }
    }
}