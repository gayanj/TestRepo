using System.Collections;
using System.Data;
using Mysqllayer;

namespace Memorylayer
{
    public class MlGeoCoder
    {
        public ArrayList Getmaincoordinates()
        {
            var slgeo = new SlGeoCoder();
            return slgeo.Getmaincoordinates();
        }

        public void Insertsubcord(int idcoordinate, string latitude, string longitude, double miles)
        {
            var slgeo = new SlGeoCoder();
            slgeo.Insertsubcord(idcoordinate, latitude, longitude, miles);
        }

        public DataTable Getgeomiles()
        {
            var slgeo = new SlGeoCoder();
            return slgeo.Getgeomiles();
        }
    }
}