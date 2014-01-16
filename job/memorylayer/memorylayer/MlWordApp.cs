using System.Data;
using Mysqllayer;

namespace Memorylayer
{
    public class MlWordApp
    {
        //add to database
        public void Addwordtext(string idapps, string rwdata)
        {
            var clword = new SlWordApp();
            clword.Addwordtext(idapps, rwdata);
        }

        public DataTable Getcvsearchdoc(string qrysearch)
        {
            var clword = new SlWordApp();
            return clword.Getcvsearczhdoc(qrysearch);
        }
    }
}