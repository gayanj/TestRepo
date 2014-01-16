using System;
using System.Data;
using Mysqllayer;

namespace Memorylayer
{
    public class MlJobViewData
    {
        public void Insertjobview(string empid, DateTime dtentered)
        {
            var cjobview = new SlJobViewData();
            cjobview.Insertjobview(empid, dtentered);
        }

        public DataTable Getjobviewdata(string sEmpID)
        {
            var cjobview = new SlJobViewData();
            return cjobview.Getjobviewdata(sEmpID);
        }

        public DataTable Getappviewdata(string sEmpID)
        {
            var cjobview = new SlJobViewData();
            return cjobview.Getappviewdata(sEmpID);
        }

        public DataTable Getpjjobviewdata(string sEmpID)
        {
            var cjobview = new SlJobViewData();
            return cjobview.Getpjjobviewdata(sEmpID);
        }
    }
}