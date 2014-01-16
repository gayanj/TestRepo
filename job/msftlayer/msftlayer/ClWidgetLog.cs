using Memorylayer;

namespace Msftlayer
{
    public class ClWidgetLog
    {
        public void Insertcompwbj(string companyname, string companydescription, string firstname, string lastname,
                                  string telephone, string website)
        {
            var slw = new MlWidgetLog();
            slw.Insertcompwbj(companyname, companydescription, firstname, lastname, telephone, website);
        }
    }
}