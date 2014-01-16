using System.Data;
using Mysqllayer;

namespace Memorylayer
{
    public class MlCmsClass
    {
        public DataSet Getcmsadvertisements(string adtype)
        {
            var slcms = new SlCmsClass();
            return slcms.Getcmsadvertisements(adtype);
        }

        public DataSet Getcmshelpcat()
        {
            var slcms = new SlCmsClass();
            return slcms.Getcmshelpcat();
        }

        public DataSet Getcmshelpqs()
        {
            var slcms = new SlCmsClass();
            return slcms.Getcmshelpqs();
        }

        public DataSet GetCmsEmailTemplates()
        {
            var slcms = new SlCmsClass();
            return slcms.GetCmsEmailTemplates();
        }

        public DataSet Getcmsarticletheme()
        {
            var slcms = new SlCmsClass();
            return slcms.Getcmsarticletheme();
        }

        public DataSet Getcmssiteindex()
        {
            var slcms = new SlCmsClass();
            return slcms.Getcmssiteindex();
        }

        public DataSet Getcmssitemaps()
        {
            var slcms = new SlCmsClass();
            return slcms.Getcmssitemaps();
        }

        public DataSet Getcmshomepglinks()
        {
            var slcms = new SlCmsClass();
            return slcms.Getcmshomepglinks();
        }

        public DataSet Getcmshomepgheadlinks()
        {
            var slcms = new SlCmsClass();
            return slcms.Getcmshomepgheadlinks();
        }

        public DataSet Getcmshomepgmiddlelinks()
        {
            var slcms = new SlCmsClass();
            return slcms.Getcmshomepgmiddlelinks();
        }

        public DataSet Getcmshomepgfooterlinks()
        {
            var slcms = new SlCmsClass();
            return slcms.Getcmshomepgfootlinks();
        }

        public string Getcmsgoogletracker()
        {
            var slcms = new SlCmsClass();
            return slcms.Getcmsgoogletracker();
        }

        public string Getcmssharethistracker()
        {
            var slcms = new SlCmsClass();
            return slcms.Getcmssharethistracker();
        }

        public DataSet Getcmsvideos()
        {
            var slcms = new SlCmsClass();
            return slcms.Getcmsvideos();
        }

        public DataSet Getcmsarticles()
        {
            var slcms = new SlCmsClass();
            return slcms.Getcmsarticles();
        }

        public DataSet Getcmsusermoderations()
        {
            var slcms = new SlCmsClass();
            return slcms.Getcmsusermoderations();
        }

        public DataSet Getcmssalarycatgs()
        {
            var slcms = new SlCmsClass();
            return slcms.Getcmssalarycatgs();
        }

        public DataSet Getpagetitlebranding()
        {
            var slcms = new SlCmsClass();
            return slcms.Getpagetitlebranding();
        }

        public DataSet Getalljobs()
        {
            var clcms = new SlCmsClass();
            return clcms.Getalljobs();
        }

        public DataSet Getcmsusers(int usertype)
        {
            var clcms = new SlCmsClass();
            return clcms.Getcmsusers(usertype);
        }

        public DataSet Getcmsusers()
        {
            var clcms = new SlCmsClass();
            return clcms.Getcmsusers();
        }

        public DataSet Getactivejobs()
        {
            var clcms = new SlCmsClass();
            return clcms.Getactivejobs();
        }

        public DataSet Getarchivedjobs()
        {
            var clcms = new SlCmsClass();
            return clcms.Getarchivedjobs();
        }

        public DataSet Getactiverec()
        {
            var clcms = new SlCmsClass();
            return clcms.Getactiverec();
        }

        public DataSet Getarchivedrec()
        {
            var clcms = new SlCmsClass();
            return clcms.Getarchivedrec();
        }

        public DataSet Getallrec()
        {
            var clcms = new SlCmsClass();
            return clcms.Getallrec();
        }

        public DataSet Getsiteheaders()
        {
            var clcms = new SlCmsClass();
            return clcms.Getsiteheaders();
        }

        public DataSet Getcpaneloptions()
        {
            var clcms = new SlCmsClass();
            return clcms.Getcpaneloptions();
        }

        public void Deletecmsusermoderations(int val)
        {
            var slcm = new SlCmsClass();
            slcm.Deletecmsusermoderations(val);
        }

        public void Deletecmssalarycatgs(int val)
        {
            var slcm = new SlCmsClass();
            slcm.Deletecmssalarycatgs(val);
        }
    }
}