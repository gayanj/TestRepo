using System.Data;
using Memorylayer;

namespace Msftlayer
{
    public class ClSalaryCalc
    {
        public object Getsals()
        {
            var clsal = new MlSalaryCalc();
            return clsal.Getsals();
        }

        public void Refreshsalaries()
        {
            var clsal = new MlSalaryCalc();
            clsal.Refreshsalaries();
        }

        public DataTable GetSalarys()
        {
            var clsal = new MlSalaryCalc();
            return clsal.GetSalarys();
        }

        public void Addsal(string q1, int q2, double q3, int q4, string q5, string q6, string ips, string q7, string q8)
        {
            var clsal = new MlSalaryCalc();
            clsal.Addsal(q1, q2, q3, q4, q5, q6, ips, q7, q8);
        }
    }
}