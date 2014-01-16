using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Mysqllayer
{
    public class SlDebug
    {
        public void Insertdebuggcode(string rawvalues, string pagename, string ex_data, string ex_type, string ex_innerexception, string ex_messege, string ex_source, string ex_stack, string ex_targetsite, string ex_url)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (MySqlCommand com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "insert into tb_debugger (rawvalues , pagename , dtlogged , ex_data , ex_type , ex_innerexeption , ex_messege , ex_source , ex_stack , ex_targetsite , ex_url ) VALUES  (@rawvalues , @pagename ,@dtlogged ,@ex_data , @ex_type ,@ex_innerexception ,@ex_messege ,@ex_source ,@ex_stack ,@ex_targetsite ,@ex_url);";

                    com.Parameters.Add("@rawvalues", MySqlDbType.VarChar).Value = rawvalues;
                    com.Parameters.Add("@pagename", MySqlDbType.VarChar).Value = pagename;
                    com.Parameters.Add("@dtlogged", MySqlDbType.DateTime).Value = DateTime.Now;
                    com.Parameters.Add("@ex_data", MySqlDbType.LongText).Value = ex_data;
                    com.Parameters.Add("@ex_type", MySqlDbType.LongText).Value = ex_type;
                    com.Parameters.Add("@ex_innerexception", MySqlDbType.LongText).Value = ex_innerexception;
                    com.Parameters.Add("@ex_messege", MySqlDbType.LongText).Value = ex_messege;
                    com.Parameters.Add("@ex_source", MySqlDbType.LongText).Value = ex_source;
                    com.Parameters.Add("@ex_stack", MySqlDbType.LongText).Value = ex_stack;
                    com.Parameters.Add("@ex_targetsite", MySqlDbType.LongText).Value = ex_targetsite;
                    com.Parameters.Add("@ex_url", MySqlDbType.VarChar).Value = ex_url;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }
    }
}