using System;
using System.Data;
using Memorylayer;

namespace Msftlayer
{
    public class ClGeoCoder
    {
        private double Clattomiles(double centlat, double centlong, double lat1, double lon1, int measureby)
        {
            //measureby 0 is for miles
            double r = 0;

            r = measureby == 0 ? 3963 : 6378.7;

            var milescount = r *
                                Math.Acos(Math.Sin(lat1) * Math.Sin(centlat) +
                                          Math.Cos(lat1) * Math.Cos(centlat) * Math.Cos(centlong - lon1));

            return milescount;
        }

        public void Calculatemiles()
        {
            var mlgeo = new MlGeoCoder();
            var al = mlgeo.Getmaincoordinates();
            var torunlp = al.Count / 4;

            for (var i = 0; i < torunlp; i += 4)
            {
                //get coordinates

                for (int j = 0; j < torunlp; j += 4)
                {
                    var milesout = Clattomiles(Convert.ToDouble(al[i + 2]), Convert.ToDouble(al[i + 3]),
                                                     Convert.ToDouble(al[j + 2]), Convert.ToDouble(al[j + 3]), 0);

                    mlgeo.Insertsubcord(Convert.ToInt16(al[i]), al[j + 2].ToString(), al[j + 3].ToString(), milesout);
                }

                GC.Collect();
            }
        }

        public DataTable Getgeomiles()
        {
            var slgeo = new MlGeoCoder();
            return slgeo.Getgeomiles();
        }
    }
}