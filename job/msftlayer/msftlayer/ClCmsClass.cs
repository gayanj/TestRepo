using System.Data;
using Memorylayer;

namespace Msftlayer
{
    public class ClCmsClass
    {
        public DataSet Getcmsadvertisements(string adtype)
        {
            var slcms = new MlCmsClass();
            return slcms.Getcmsadvertisements(adtype);
        }

        public DataSet Getcmshelpcat()
        {
            var slcms = new MlCmsClass();
            return slcms.Getcmshelpcat();
        }

        public DataSet Getcmshelpqs()
        {
            var slcms = new MlCmsClass();
            return slcms.Getcmshelpqs();
        }

        public DataSet GetCmsEmailTemplates()
        {
            var slcms = new MlCmsClass();
            return slcms.GetCmsEmailTemplates();
        }

        public DataSet Getcmsarticletheme()
        {
            var slcms = new MlCmsClass();
            return slcms.Getcmsarticletheme();
        }

        public DataSet Getcmssiteindex()
        {
            var slcms = new MlCmsClass();
            return slcms.Getcmssiteindex();
        }

        public DataSet Getcmssitemaps()
        {
            var slcms = new MlCmsClass();
            return slcms.Getcmssitemaps();
        }

        public DataSet Getcmshomepglinks(string linkstr)
        {
            var slcms = new MlCmsClass();

            switch (linkstr)
            {
                case "footer":
                    return slcms.Getcmshomepgfooterlinks();
                case "middle":
                    return slcms.Getcmshomepgmiddlelinks();
                case "header":
                    return slcms.Getcmshomepgheadlinks();
                default:
                    return slcms.Getcmshomepglinks();
            }
        }

        public string Getcmstracker(string trackerstr)
        {
            var slcms = new MlCmsClass();

            switch (trackerstr)
            {
                case "google":
                    return slcms.Getcmsgoogletracker();
                default:
                    return slcms.Getcmssharethistracker();
            }
        }

        public DataSet Getcmsvideos()
        {
            var slcms = new MlCmsClass();
            return slcms.Getcmsvideos();
        }

        public DataSet Getcmsarticles()
        {
            var slcms = new MlCmsClass();
            return slcms.Getcmsarticles();
        }

        public DataSet Getcmsusermoderations()
        {
            var slcms = new MlCmsClass();
            return slcms.Getcmsusermoderations();
        }

        public DataSet Getcmssalarycatgs()
        {
            var slcms = new MlCmsClass();
            return slcms.Getcmssalarycatgs();
        }

        public DataSet Getpagetitlebranding()
        {
            var slcms = new MlCmsClass();
            return slcms.Getpagetitlebranding();
        }

        public DataSet Getalljobs()
        {
            var clcms = new MlCmsClass();
            return clcms.Getalljobs();
        }

        public DataSet Getcmsusers(int usertype)
        {
            var clcms = new MlCmsClass();
            return clcms.Getcmsusers(usertype);
        }

        public DataSet Getcmsusers()
        {
            var clcms = new MlCmsClass();
            return clcms.Getcmsusers();
        }

        public DataSet Getactivejobs()
        {
            var clcms = new MlCmsClass();
            return clcms.Getactivejobs();
        }

        public DataSet Getarchivedjobs()
        {
            var clcms = new MlCmsClass();
            return clcms.Getarchivedjobs();
        }

        public DataSet Getactiverec()
        {
            var clcms = new MlCmsClass();
            return clcms.Getactiverec();
        }

        public DataSet Getarchivedrec()
        {
            var clcms = new MlCmsClass();
            return clcms.Getarchivedrec();
        }

        public DataSet Getallrec()
        {
            var clcms = new MlCmsClass();
            return clcms.Getallrec();
        }

        public DataSet Getsiteheaders()
        {
            var clcms = new MlCmsClass();
            return clcms.Getsiteheaders();
        }

        public DataSet Getcpaneloptions()
        {
            var clcms = new MlCmsClass();
            return clcms.Getcpaneloptions();
        }

        public void Deletecmsusermoderations(int val)
        {
            var slcm = new MlCmsClass();
            slcm.Deletecmsusermoderations(val);
        }

        public void Deletecmssalarycatgs(int val)
        {
            var slcm = new MlCmsClass();
            slcm.Deletecmssalarycatgs(val);
        }
    }
}