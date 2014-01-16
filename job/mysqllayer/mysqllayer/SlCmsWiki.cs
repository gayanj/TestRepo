using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;

namespace Mysqllayer
{
    public class SlCmsWiki
    {
        public DataSet GetWiki()
        {            
            var ds = new DataSet();
            var myconstring = SlConnectionString.Makeconn;
            var mycon = new MySqlConnection { ConnectionString = myconstring };

            var myda =
                new MySqlDataAdapter(
                    "select * from tb_wikis;",
                    mycon);
            

            mycon.Open();
            myda.Fill(ds, "tb_wikis");
            mycon.Close();

            return ds;        
        }
    }
}
