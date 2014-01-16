using System;
using System.Collections;
using System.Data;
using MySql.Data.MySqlClient;

namespace Mysqllayer
{
    public class SlGeoCoder
    {
        public ArrayList Getmaincoordinates()
        {
            var tempst = new ArrayList();
            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command = new MySqlCommand("select idcoordinate, postcode, latitude, longitude from tb_postcodes;",
                                               connreader);
                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        tempst.Add(reader.GetString(0));
                        tempst.Add(reader.GetString(1));
                        tempst.Add(reader.GetString(2));
                        tempst.Add(reader.GetString(3));
                    }
                }

                else
                {
                    reader.Close();
                    return null;
                }

                reader.Close();
            }

            tempst.TrimToSize();

            connreader.Close();
            return tempst;
        }

        public void Insertsubcord(int idcoordinate, string latitude, string longitude, double miles)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "INSERT INTO tb_postcodesubcord (idcoordinate, latitude , longitude , dtstampupdate, miles) VALUES ( @idcoordinate, @latitude, @longitude, @dtstampupdate, @miles);";

                    com.Parameters.Add("@idcoordinate", MySqlDbType.Int32).Value = idcoordinate;
                    com.Parameters.Add("@latitude", MySqlDbType.VarChar).Value = latitude;
                    com.Parameters.Add("@longitude", MySqlDbType.VarChar).Value = longitude;
                    com.Parameters.Add("@dtstampupdate", MySqlDbType.DateTime).Value = DateTime.Now;
                    com.Parameters.Add("@miles", MySqlDbType.Double).Value = miles;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public DataTable Getgeomiles()
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };
            mycon.Open();

            var selectcmd = new MySqlCommand("select Miles from tb_geomiles;", mycon) { CommandType = CommandType.Text };

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("tb_geomiles");
            selectdataadp.Fill(dt);

            mycon.Clone();

            return dt;
        }
    }
}