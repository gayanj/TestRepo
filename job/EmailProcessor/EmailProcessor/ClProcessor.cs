using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using MySql.Data.MySqlClient;
using System.Data;
using System.Net.Mail;
using System.Globalization;
using System.Net;

namespace EmailProcessor
{
    class ClProcessor
    {
        //this is the number of jobs sent per person
        //private int HtmlIterations = 50;
        //ClVariables cl = new ClVariables();
        //private static readonly string constring = cl.emailfrom;
        //private string emfrom = cl.emailfrom;
        //private string emuser = cl;
        //private string empwd = "";
        //private int emport = 25;
        //private string emserver = "";
        
        //application setup

        public bool connectionset(string username, string pwd)
        {
            string sb = "Server=localhost; Database=fashionquadrant;UserId=Genre;Password=!1IamBackTo;";
            
            MySqlConnection mycon = new MySqlConnection(sb);
            
            try
            {
                mycon.Open();
                mycon.Ping();
                mycon.Clone();
                //everthing seems to be ok.
                //set constring in app

                ClVariables clv = new ClVariables();
                clv.constring = sb;

                return true;
            }

            catch { return false; }
        }

        //get email to send to
        public ArrayList GetEmailAddresses()
        {
            ArrayList al = new ArrayList();
            ClVariables clv = new ClVariables();
            var connreader = new MySqlConnection { ConnectionString = clv.constring };

            using (connreader)
            {
                var command = new MySqlCommand("select distinct emailaddress from tb_subscriptions; ", connreader);

                connreader.Open();
                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        al.Add(reader.GetString(0));
                    }
                }

                reader.Close();
            }
            return al;
        }

        //add to db
        public void LogEmails(string email, int status)
        {
            ClVariables clv = new ClVariables();

            using (var con = new MySqlConnection())
            {
                con.ConnectionString = clv.constring;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "Insert into tb_email_user(rstatus, rdtsent, remailtype, remailaddress) VALUES(@status, @datestamp, 4, @emailaddress); ";

                    com.Parameters.Add("@emailaddress", MySqlDbType.Int32).Value = email;
                    com.Parameters.Add("@datestamp", MySqlDbType.DateTime).Value = DateTime.Now;
                    com.Parameters.Add("@status", MySqlDbType.Int32).Value = status;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        //check if email unsubscribed
        public bool GetUnsubscriberId(string emailadress)
        {
            ClVariables clv = new ClVariables();

            var connreader = new MySqlConnection { ConnectionString = clv.constring };

            using (connreader)
            {
                var command = new MySqlCommand("select id_email from tb_emailunsubscribe where eemailaddress = @param1;", connreader);
                command.Parameters.Add("@param1", MySqlDbType.String).Value = emailadress;

                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        return true;
                    }
                }

                reader.Close();
            }

            return false;
        }

        //fetch html templates
        public string[] GetTemplate()
        {
            //store rec details
            string[] val = new string[2];
            ClVariables clv = new ClVariables();

            var connreader = new MySqlConnection { ConnectionString = clv.constring };

            using (connreader)
            {
                var command =
                    new MySqlCommand(@"select eheader, efooter from tb_emailtemplates where etemplatechkid = 4;",
                                     connreader);

                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        val[0] = reader.GetString(0);
                        val[1] = reader.GetString(1);
                    }
                }

                reader.Close();
            }
            return val;
        }

        //this is the job ids
        public ArrayList GetEmailData(string emailaddress)
        {
            ArrayList val = new ArrayList();
            ClVariables clv = new ClVariables();
            var connreader = new MySqlConnection { ConnectionString = clv.constring };
            int i = 0;

            using (connreader)
            {
                var command = new MySqlCommand(@"select stitle, sshortdescription, sjobenddate, slocation, ssalarytext from vw_emailtosend where emailaddress = @param1 limit 10;", connreader);
                command.Parameters.Add("@param1", MySqlDbType.String).Value = emailaddress;

                connreader.Open();
                var reader = command.ExecuteReader();


                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        val.Add(reader.GetString(0));
                        val.Add(reader.GetString(1));
                        val.Add(reader.GetString(2));
                        val.Add(reader.GetString(3));
                        val.Add(reader.GetString(4));
                        i++;

                        if (i == clv.HtmlIterations)
                        {
                            break;
                        }
                    }
                }

                reader.Close();
            }
            return val;
        }

        //this sent out actual email
        public void Sendmail(string toaddr, string tosubject, string tobody)
        {
            ClVariables clv = new ClVariables();

            //checkcode
            var message = new MailMessage();
            message.To.Add(toaddr);
            message.Subject = tosubject;
            message.From = new MailAddress(clv.emailfrom);
            message.IsBodyHtml = true;
            message.Body = tobody;

            var smtp = new SmtpClient(clv.emserver, clv.emport)
            {
                Credentials = new NetworkCredential(clv.emuser, clv.empwd)
            };

            smtp.Send(message);
        }

        //get emails not sent
        public ArrayList GetNotSentEmail()
        {
            ArrayList al = new ArrayList();
            ClVariables clv = new ClVariables();
            var connreader = new MySqlConnection { ConnectionString = clv.constring };

            using (connreader)
            {
                var command = new MySqlCommand("select distinct remailaddress from tb_email_user where rEmailtype = 4 and rStatus = 1; ", connreader);

                connreader.Open();
                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        al.Add(reader.GetString(0));
                    }
                }

                reader.Close();
            }
            return al;
        }


    }
}
