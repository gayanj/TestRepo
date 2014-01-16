using System.Collections;
using System.Data;
using MySql.Data.MySqlClient;
using System;
using minGuid;

namespace Mysqllayer
{
    public class SlQuestions
    {
        //rewrite the above
        public string GetMaxQuestionId()
        {
            var mg = new Minimumguid();

            return mg.MinGuid();
        }

        public string GetMaxAnswerId()
        {
            var mg = new Minimumguid();

            return mg.MinGuid();
        }

        //insert questions
        public void InsertQuestion(string idjob, string idquestion, string question)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "Insert into tb_questions(idquestion, idjobs, qQuestion, dtentered) VALUES(@idqs, @idjobs, @qquestion, @datestamp);  ";

                    com.Parameters.Add("@idqs", MySqlDbType.VarChar).Value = idquestion;
                    com.Parameters.Add("@idjobs", MySqlDbType.VarChar).Value = idjob;
                    com.Parameters.Add("@qquestion", MySqlDbType.String).Value = question;
                    com.Parameters.Add("@datestamp", MySqlDbType.DateTime).Value = DateTime.Now;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public void InsertQuestionLink(string idquestion, string idans)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText = "Insert into tb_question_link( idquestion, idans, dtentered) VALUES( @idqs, @idans ,@datestamp);";

                    com.Parameters.Add("@idqs", MySqlDbType.VarChar).Value = idquestion;
                    com.Parameters.Add("@idans", MySqlDbType.VarChar).Value = idans;
                    com.Parameters.Add("@datestamp", MySqlDbType.DateTime).Value = DateTime.Now;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public void InsertAnswer(string idans, string answer)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "Insert into tb_answers(idans, answer, dtentered) VALUES(@idans, @answer, @datestamp); ";

                    com.Parameters.Add("@idans", MySqlDbType.VarChar).Value = idans;
                    com.Parameters.Add("@answer", MySqlDbType.String).Value = answer;
                    com.Parameters.Add("@datestamp", MySqlDbType.DateTime).Value = DateTime.Now;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }

        }

        //insert answers
        public void InsertAnswerByUser(int idans, int idquestion, string idjobs, string idapplication, string answer)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "Insert into tb_answers_user(idans, idquestion, idjobs, idapplication,  aAnswer, dtentered) VALUES(@idans, @idquestion, @idjobs, @idapp, @answer, @datestamp); ";

                    com.Parameters.Add("@idans", MySqlDbType.Int32).Value = idans;
                    com.Parameters.Add("@idquestion", MySqlDbType.Int32).Value = idquestion;
                    com.Parameters.Add("@idjobs", MySqlDbType.VarChar).Value = idjobs;
                    com.Parameters.Add("@idapp", MySqlDbType.VarChar).Value = idapplication;
                    com.Parameters.Add("@answer", MySqlDbType.String).Value = answer;
                    com.Parameters.Add("@datestamp", MySqlDbType.DateTime).Value = DateTime.Now;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        //delete questions
        public void DeleteQuestion(string idquestion)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "DELETE from tb_questions where idquestion = @param1;  ";

                    com.Parameters.Add("@param1", MySqlDbType.String).Value = idquestion;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public void DeleteQuestionLinkQ(string idquestion)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "DELETE from tb_question_link where idquestion = @idquestion; ";

                    com.Parameters.Add("@idquestion", MySqlDbType.String).Value = idquestion;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public void DeleteQuestionLinkA(string idans)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "DELETE from tb_question_link where idans = @idans; ";

                    com.Parameters.Add("@idans", MySqlDbType.String).Value = idans;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        //delete question answers
        public void DeleteAnswer(string idans)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "DELETE from tb_answers where idans = @param1;  ";

                    com.Parameters.Add("@param1", MySqlDbType.String).Value = idans;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        //update questions
        public void UpdateQuestion(int idjob, int idquestion, string question)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "Update tb_questions SET question = @question , dtupdated = @datestamp where idjobs = @idqs and idquestion = @idjobs ;  ";

                    com.Parameters.Add("@idqs", MySqlDbType.Int32).Value = idquestion;
                    com.Parameters.Add("@idjobs", MySqlDbType.Int32).Value = idjob;
                    com.Parameters.Add("@qquestion", MySqlDbType.String).Value = question;
                    com.Parameters.Add("@datestamp", MySqlDbType.DateTime).Value = DateTime.Now;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public void UpdateAnswers(int idans, int idquestion)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "Update tb_answers a, tb_question_link ql, tb_questions q SET a.dtupdated = @datestamp where a.idans = @idans and a.idans = ql.idans and ql.idquestion = q.idquestion and q.idquestion = @idquestion;  ";

                    com.Parameters.Add("@idans", MySqlDbType.Int32).Value = idans;
                    com.Parameters.Add("@idquestion", MySqlDbType.Int32).Value = idquestion;
                    com.Parameters.Add("@datestamp", MySqlDbType.DateTime).Value = DateTime.Now;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        //get question
        public ArrayList GetQuestion(string idjobs)
        {
            var al = new ArrayList();
            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command =
                    new MySqlCommand("select idquestion, qquestion from tb_questions where idjobs = @param1 order by idquestion;", connreader);
                command.Parameters.Add("@param1", MySqlDbType.VarChar).Value = idjobs;

                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        al.Add(reader.GetString(0));
                        al.Add(reader.GetString(1));
                    }
                }

                reader.Close();
            }
            return al;
        }

        public ArrayList GetAnswers(string idquestion)
        {
            var al = new ArrayList();
            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command = new MySqlCommand("select  a.idans, a.answer, q.idquestion  from tb_answers a, tb_question_link ql, tb_questions q where a.idans = ql.idans and ql.idquestion = q.idquestion and q.idquestion = @param1 order by idans;", connreader);
                command.Parameters.Add("@param1", MySqlDbType.String).Value = idquestion;

                connreader.Open();
                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        al.Add(reader.GetString(2));
                        al.Add(reader.GetString(0));
                        al.Add(reader.GetString(1));
                    }
                }

                reader.Close();
            }
            return al;
        }

        public ArrayList GetAnswerUser(string idapp)
        {
            ArrayList al = new ArrayList();
            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command = new MySqlCommand(" SELECT idans, answer, idquestion, qquestion, idapplication from vw_get_userans where idapplication = @param1 order by idquestion ; ", connreader);
                command.Parameters.Add("@param1", MySqlDbType.Int32).Value = idapp;

                connreader.Open();
                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        al.Add(reader.GetString(0));
                        al.Add(reader.GetString(1));
                        al.Add(reader.GetString(2));
                        al.Add(reader.GetString(3));
                    }
                }

                reader.Close();
            }
            return al;
        }

        //temporary processing of answers
        public void InsertTempAns(string idqs, string session, string idjobs)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "Insert into tb_question_holder(idquestion, qsessionid , idjobs, dtentered) VALUES(@idans, @session, @idjobs, @datestamp); ";

                    com.Parameters.Add("@idans", MySqlDbType.String).Value = idqs;
                    com.Parameters.Add("@idjobs", MySqlDbType.VarChar).Value = idjobs;
                    com.Parameters.Add("@session", MySqlDbType.String).Value = session;
                    com.Parameters.Add("@datestamp", MySqlDbType.DateTime).Value = DateTime.Now;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public void DeleteTempAns(string idqs)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "update tb_question_holder set qDeleted = 1, dtupdated = @datestamp where idquestion = @idqs; ";

                    com.Parameters.Add("@idqs", MySqlDbType.String).Value = idqs;
                    com.Parameters.Add("@datestamp", MySqlDbType.DateTime).Value = DateTime.Now;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public string GetTempAns(string idqs)
        {
            string ans = "";
            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command =
                    new MySqlCommand("select idquestion from tb_question_holder where qdeleted = 0 and idquestion = @param1;", connreader);
                command.Parameters.Add("@param1", MySqlDbType.String).Value = idqs;

                connreader.Open();
                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ans = reader.GetString(0);
                    }
                }

                reader.Close();
            }
            return ans;
        }

        public void DeleteTempAnsByJob(string idjobs)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "update tb_question_holder set qDeleted = 1, dtupdated = @datestamp where idjobs = @idjobs; ";

                    com.Parameters.Add("@idjobs", MySqlDbType.VarChar).Value = idjobs;
                    com.Parameters.Add("@datestamp", MySqlDbType.DateTime).Value = DateTime.Now;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }
    }
}