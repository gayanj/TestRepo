using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Mysqllayer
{
    public class SlSalaryCalc
    {
        public DataTable Getsals()
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };
            mycon.Open();

            var selectcmd = new MySqlCommand("select * from vw_getsalforcalc;", mycon) { CommandType = CommandType.Text };

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("vw_getsalforcalc");
            selectdataadp.Fill(dt);
            mycon.Clone();

            return dt;
        }

        public DataTable GetSalarys()
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd = new MySqlCommand("SELECT occupationname from salaryoccupations where isdeleted = 0;", mycon) { CommandType = CommandType.Text };

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("salaryoccupations");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        public void Addsal(string q1, int q2, double q3, int q4, string q5, string q6, string ips, string q7, string q8)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "INSERT INTO SalaryCalc(Question1, Question2, Question3, Question4, Question5, Question6, dtEntered, dtEnteredByIp, Question7, Question8) values ( @Q1, @Q2, @Q3, @Q4, @Q5, @Q6, @dtentered, @enteredbyip, @Q7, @Q8);";

                    com.Parameters.Add("@Q1", MySqlDbType.VarChar).Value = q1;
                    com.Parameters.Add("@Q2", MySqlDbType.Int32).Value = q2;
                    com.Parameters.Add("@Q3", MySqlDbType.Double).Value = q3;
                    com.Parameters.Add("@Q4", MySqlDbType.Int32).Value = q4;
                    com.Parameters.Add("@Q5", MySqlDbType.VarChar).Value = q5;
                    com.Parameters.Add("@Q6", MySqlDbType.VarChar).Value = q6;
                    com.Parameters.Add("@Q7", MySqlDbType.VarChar).Value = q7;
                    com.Parameters.Add("@Q8", MySqlDbType.VarChar).Value = q8;
                    com.Parameters.Add("@dtentered", MySqlDbType.DateTime).Value = DateTime.Now;
                    com.Parameters.Add("@enteredbyip", MySqlDbType.VarChar).Value = ips;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }
    }
}