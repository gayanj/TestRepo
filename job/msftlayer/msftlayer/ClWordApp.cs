using System.Data;
using Memorylayer;

namespace Msftlayer
{
    public class ClWordApp
    {
        //add to database
        public void Addwordtext(string idapps, string rwdata)
        {
            var mlword = new MlWordApp();
            mlword.Addwordtext(idapps, rwdata);
        }

        public DataTable Getcvsearchdoc(string qrysearch)
        {
            var mlword = new MlWordApp();
            return mlword.Getcvsearchdoc(qrysearch);
        }
    }
}