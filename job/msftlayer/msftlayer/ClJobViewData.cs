using System;
using System.Data;
using Memorylayer;

namespace Msftlayer
{
    public class ClJobViewData
    {
        public void Insertjobview(string empid, DateTime dtentered)
        {
            var mjobview = new MlJobViewData();
            mjobview.Insertjobview(empid, dtentered);
        }

        public DataTable Getjobviewdata(string sEmpId)
        {
            var mjobview = new MlJobViewData();
            return mjobview.Getjobviewdata(sEmpId);
        }

        public DataTable Getappviewdata(string sEmpId)
        {
            var mjobview = new MlJobViewData();
            return mjobview.Getappviewdata(sEmpId);
        }

        public DataTable Getpjjobviewdata(string sEmpId)
        {
            var mjobview = new MlJobViewData();
            return mjobview.Getpjjobviewdata(sEmpId);
        }
    }
}