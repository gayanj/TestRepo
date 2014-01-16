using Mysqllayer;

namespace Memorylayer
{
    public class MlWidgetLog
    {
        public void Insertcompwbj(string companyname, string companydescription, string firstname, string lastname,
                                  string telephone, string website)
        {
            var slw = new SlWidgetLog();
            slw.Insertcompwbj(companyname, companydescription, firstname, lastname, telephone, website);
        }
    }
}