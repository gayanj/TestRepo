using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Mysqllayer
{
    public class SlJobViewData
    {
        public void Insertjobview(string empid, DateTime dtentered)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (MySqlCommand com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText = "INSERT INTO jobviews(Empid, dtentered) values (@empid , @dtentered)";

                    com.Parameters.Add("@empid", MySqlDbType.VarChar).Value = empid;
                    com.Parameters.Add("@dtentered", MySqlDbType.Date).Value = dtentered.Date;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public DataTable Getjobviewdata(string sEmpID)
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd =
                new MySqlCommand(
                    "select count(empid) as jobviews, dtentered as dateviewed from jobviews group by empid, dtentered having empid =@param1;",
                    mycon) { CommandType = CommandType.Text };

            selectcmd.Parameters.Add("@param1", MySqlDbType.VarChar).Value = sEmpID;

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("jobviews");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        public DataTable Getappviewdata(string sEmpID)
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd =
                new MySqlCommand(
                    "select idjobs as jobviews, dtentered as dateviewed from vw_jobapplicationview where empid = @param1;",
                    mycon) { CommandType = CommandType.Text };

            selectcmd.Parameters.Add("@param1", MySqlDbType.VarChar).Value = sEmpID;

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("vw_jobapplicationview");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        public DataTable Getpjjobviewdata(string sEmpID)
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd =
                new MySqlCommand(
                    "select idjobs as jobviews, dtentered as dateviewed from vw_jobpostedview where empid = @param1;",
                    mycon) { CommandType = CommandType.Text };

            selectcmd.Parameters.Add("@param1", MySqlDbType.VarChar).Value = sEmpID;

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("vw_jobpostedview");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }
    }
}