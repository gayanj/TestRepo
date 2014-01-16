using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Mysqllayer
{
    public class SlWordApp
    {
        //add to database
        public void Addwordtext(string idapps, string rwdata)
        {
            //change encoding
            //rwdata = chgencode(rwdata);
            //checkcode

            //
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;

                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "INSERT INTO tb_cvsearchdata(idapplications, rawdata, dtentered, dtstamp) values ( @idapps, @rwwdata, @dateent, @datestamp);";

                    com.Parameters.Add("@idapps", MySqlDbType.VarChar).Value = idapps;
                    com.Parameters.Add("@rwwdata", MySqlDbType.LongText).Value = rwdata;
                    com.Parameters.Add("@dateent", MySqlDbType.Date).Value = DateTime.Now;
                    com.Parameters.Add("@datestamp", MySqlDbType.DateTime).Value = DateTime.Now;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        //get cvs
        public DataTable Getcvsearczhdoc(string qrysearch)
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            mycon.Open();

            var selectcmd =
                new MySqlCommand(
                    "select dtdocpath from tb_cvsearchdata where MATCH(rawdata) AGAINST (@param1 IN NATURAL LANGUAGE MODE);",
                    mycon) { CommandType = CommandType.Text };

            selectcmd.Parameters.Add("@param1", MySqlDbType.VarString).Value = qrysearch;

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("tb_cvsearchdata");
            selectdataadp.Fill(dt);

            mycon.Clone();

            return dt;
        }
    }
}