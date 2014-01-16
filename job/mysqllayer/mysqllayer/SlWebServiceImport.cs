using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Mysqllayer
{
    public class SlWebServiceImport
    {
        public void Insertwebrecruiter(string recruiterName, string address1, string address2, string address3,
                                       string town, string county, string country, string postcode, string emailAddress,
                                       string website, string description, string completeDesc, string pwds)
        {
            //
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "INSERT INTO tb_webservicerec( RecruiterName, Address1, Address2, Address3, Town, County, Country , Postcode, EmailAddress, Website, Description, CompleteDesc, pwds) values ( @RecruiterName, @Address1, @Address2, @Address3, @Town, @County, @Country , @Postcode, @EmailAddress, @Website, @Description, @CompleteDesc, @pwds);";

                    com.Parameters.Add("@RecruiterName", MySqlDbType.VarChar).Value = recruiterName;
                    com.Parameters.Add("@Address1", MySqlDbType.VarChar).Value = address1;
                    com.Parameters.Add("@Address2", MySqlDbType.VarChar).Value = address2;
                    com.Parameters.Add("@Address3", MySqlDbType.VarChar).Value = address3;
                    com.Parameters.Add("@Town", MySqlDbType.VarChar).Value = town;
                    com.Parameters.Add("@County", MySqlDbType.VarChar).Value = county;
                    com.Parameters.Add("@Country", MySqlDbType.VarChar).Value = country;
                    com.Parameters.Add("@Postcode", MySqlDbType.VarChar).Value = postcode;
                    com.Parameters.Add("@EmailAddress", MySqlDbType.VarChar).Value = emailAddress;
                    com.Parameters.Add("@Website", MySqlDbType.VarChar).Value = website;
                    com.Parameters.Add("@Description", MySqlDbType.VarChar).Value = description;
                    com.Parameters.Add("@CompleteDesc", MySqlDbType.LongText).Value = completeDesc;
                    com.Parameters.Add("@pwds", MySqlDbType.VarChar).Value = pwds;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public void Insertwebjobs(string title, string shortDescription, string description, string salaryText,
                                  string minSal, string maxSal, string Ref, string freeText, DateTime jobstartdate,
                                  DateTime jobenddate, string location, string recruitername)
        {
            //
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "INSERT INTO tb_webservicejobs(Title, ShortDescription, Description, SalaryText, MinSal, MaxSal, Ref, FreeText, Jobstartdate, Jobenddate, Location, recruitername) VALUES (@Title, @ShortDescription, @Description, @SalaryText, @MinSal, @MaxSal, @Ref, @FreeText, @Jobstartdate, @Jobenddate, @Location, @recruitername);";

                    com.Parameters.Add("@Title", MySqlDbType.VarChar).Value = title;
                    com.Parameters.Add("@ShortDescription", MySqlDbType.VarChar).Value = shortDescription;
                    com.Parameters.Add("@Description", MySqlDbType.LongText).Value = description;
                    com.Parameters.Add("@SalaryText", MySqlDbType.VarChar).Value = salaryText;
                    com.Parameters.Add("@MinSal", MySqlDbType.Int32).Value = minSal;
                    com.Parameters.Add("@MaxSal", MySqlDbType.Int32).Value = maxSal;
                    com.Parameters.Add("@Ref", MySqlDbType.VarChar).Value = Ref;
                    com.Parameters.Add("@FreeText", MySqlDbType.VarChar).Value = freeText;
                    com.Parameters.Add("@Jobstartdate", MySqlDbType.Date).Value = jobstartdate;
                    com.Parameters.Add("@Jobenddate", MySqlDbType.Date).Value = jobenddate;
                    com.Parameters.Add("@Location", MySqlDbType.VarChar).Value = location;
                    com.Parameters.Add("@recruitername", MySqlDbType.VarChar).Value = recruitername;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }
    }
}