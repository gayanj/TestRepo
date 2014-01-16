using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Mysqllayer
{
    public class SlCcPay
    {
        public void Insertcarddata(string empid, string ptransactionid, string pFirstname, string pLastname,
                                   string pAddress1, string pAddress2, string pAddress3, string pTown, string pCounty,
                                   string pPostcode, string pCountry, string pCardtype, int pservicecode)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "insert into tb_paypal(`tb_paypal`.`empid`, `tb_paypal`.`ptransactionid`, `tb_paypal`.`pFirstname`, `tb_paypal`.`pLastname`, `tb_paypal`.`pAddress1`, `tb_paypal`.`pAddress2`, `tb_paypal`.`pAddress3`, `tb_paypal`.`pTown`, `tb_paypal`.`pCounty`, `tb_paypal`.`pPostcode`, `tb_paypal`.`pCountry`, `tb_paypal`.`pCardtype`, `tb_paypal`.`pservicecode`, `tb_paypal`.`dtentered`) values( @empid, @ptransactionid, @pFirstname, @pLastname, @pAddress1, @pAddress2, @pAddress3, @pTown, @pCounty, @pPostcode, @pCountry, @pCardtype, @pservicecode, @dtentered)";

                    com.Parameters.Add("@empid", MySqlDbType.VarChar).Value = empid;
                    com.Parameters.Add("@ptransactionid", MySqlDbType.String).Value = ptransactionid;
                    com.Parameters.Add("@pFirstname", MySqlDbType.String).Value = pFirstname;
                    com.Parameters.Add("@pLastname", MySqlDbType.String).Value = pLastname;
                    com.Parameters.Add("@pAddress1", MySqlDbType.String).Value = pAddress1;
                    com.Parameters.Add("@pAddress2", MySqlDbType.String).Value = pAddress2;
                    com.Parameters.Add("@pAddress3", MySqlDbType.String).Value = pAddress3;
                    com.Parameters.Add("@pTown", MySqlDbType.String).Value = pTown;
                    com.Parameters.Add("@pCounty", MySqlDbType.String).Value = pCounty;
                    com.Parameters.Add("@pCountry", MySqlDbType.String).Value = pCountry;
                    com.Parameters.Add("@pPostcode", MySqlDbType.String).Value = pPostcode;
                    com.Parameters.Add("@pCardtype", MySqlDbType.String).Value = pCardtype;
                    com.Parameters.Add("@pservicecode", MySqlDbType.Int16).Value = pservicecode;
                    com.Parameters.Add("@dtentered", MySqlDbType.DateTime).Value = DateTime.Now;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }
    }
}