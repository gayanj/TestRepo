using System.Data;
using MySql.Data.MySqlClient;

namespace Mysqllayer
{
    public class SlCmsClass
    {
        //handle advertisements
        public DataSet Getcmsadvertisements(string adtype)
        {
            var ds = new DataSet();
            var myconstring = SlConnectionString.Makeconn;
            var mycon = new MySqlConnection { ConnectionString = myconstring };

            var myda =
                new MySqlDataAdapter(
                    "select d.*,l.adsection,l.adtype from  tb_advertdetail d,tb_adverts l where d.adkey = l.adkey and l.adkey= " + adtype + " ;",
                    mycon);
            

            mycon.Open();
            myda.Fill(ds, "tb_advertdetail");
            mycon.Close();

            return ds;
        }

        //handle help center q and a
        public DataSet Getcmshelpqs()
        {
            var ds = new DataSet();
            var myconstring = SlConnectionString.Makeconn;
            var mycon = new MySqlConnection { ConnectionString = myconstring };

            var myda =
                new MySqlDataAdapter(
                    "select * from tb_helpcenterqs;",
                    mycon);

            mycon.Open();
            myda.Fill(ds, "tb_helpcenterqs");
            mycon.Close();

            return ds;
        }

        //handle help center categories
        public DataSet Getcmshelpcat()
        {
            var ds = new DataSet();
            var myconstring = SlConnectionString.Makeconn;
            var mycon = new MySqlConnection { ConnectionString = myconstring };

            var myda =
                new MySqlDataAdapter(
                    "select * from tb_helpcentercat;",
                    mycon);

            mycon.Open();
            myda.Fill(ds, "tb_helpcentercat");
            mycon.Close();

            return ds;
        }

        //handle email templates
        public DataSet GetCmsEmailTemplates()
        {
            var ds = new DataSet();
            var myconstring = SlConnectionString.Makeconn;
            var mycon = new MySqlConnection { ConnectionString = myconstring };

            var myda =
                new MySqlDataAdapter(
                    "select * from vw_emailtemplatesshow;",
                    mycon);

            mycon.Open();
            myda.Fill(ds, "vw_emailtemplatesshow");
            mycon.Close();

            return ds;
        }

        //handling drop down for articles themes
        public DataSet Getcmsarticletheme()
        {
            var ds = new DataSet();
            var myconstring = SlConnectionString.Makeconn;
            var mycon = new MySqlConnection { ConnectionString = myconstring };

            var myda =
                new MySqlDataAdapter(
                    "select idthemes, Name from tb_themes;",
                    mycon);

            mycon.Open();
            myda.Fill(ds, "tb_themes");
            mycon.Close();

            return ds;
        }

        //handling site indexing/insite search
        public DataSet Getcmssiteindex()
        {
            var ds = new DataSet();

            var myconstring = SlConnectionString.Makeconn;

            var mycon = new MySqlConnection { ConnectionString = myconstring };

            var myda =
                new MySqlDataAdapter(
                    "select * from tb_sitesearch;",
                    mycon);

            mycon.Open();

            myda.Fill(ds, "tb_sitesearch");

            mycon.Close();

            return ds;
        }

        //handling site maps
        public DataSet Getcmssitemaps()
        {
            var ds = new DataSet();

            var myconstring = SlConnectionString.Makeconn;

            var mycon = new MySqlConnection { ConnectionString = myconstring };

            var myda =
                new MySqlDataAdapter(
                    "select * from tb_sitemaps;",
                    mycon);

            mycon.Open();

            myda.Fill(ds, "tb_sitemaps");

            mycon.Close();

            return ds;
        }

        //video handling for cms
        public DataSet Getcmsvideos()
        {
            var ds = new DataSet();

            var myconstring = SlConnectionString.Makeconn;

            var mycon = new MySqlConnection { ConnectionString = myconstring };

            var myda =
                new MySqlDataAdapter(
                    "select tb_videos.*, jobs.stitle from tb_videos, jobs where tb_videos.idjobs = jobs.idjobs;",
                    mycon);

            mycon.Open();

            myda.Fill(ds, "tb_videos");

            mycon.Close();

            return ds;
        }

        //script handling for the CMS
        public string Getcmsgoogletracker()
        {
            //store rec details
            string val = string.Empty;

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command = new MySqlCommand("select sdescription from tb_pluginanalytics limit 1;", connreader);
                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        val = reader.GetString(0);
                    }
                }

                reader.Close();
            }
            return val;
        }

        public string Getcmssharethistracker()
        {
            //store rec details
            string val = string.Empty;

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command = new MySqlCommand("select sdefinition from tb_pluginsharethis limit 1;", connreader);
                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        val = reader.GetString(0);
                    }
                }

                reader.Close();
            }
            return val;
        }

        //end trackers

        //home page links
        public DataSet Getcmshomepglinks()
        {
            var ds = new DataSet();

            var myconstring = SlConnectionString.Makeconn;

            var mycon = new MySqlConnection { ConnectionString = myconstring };

            var myda =
                new MySqlDataAdapter(
                    "SELECT * from vw_cmslinks;",
                    mycon);

            mycon.Open();

            myda.Fill(ds, "vw_cmslinks");

            mycon.Close();

            return ds;
        }

        public DataSet Getcmshomepgheadlinks()
        {
            var ds = new DataSet();

            var myconstring = SlConnectionString.Makeconn;

            var mycon = new MySqlConnection { ConnectionString = myconstring };

            var myda =
                new MySqlDataAdapter(
                    "SELECT * from tb_headerlinks;",
                    mycon);

            mycon.Open();

            myda.Fill(ds, "tb_headerlinks");

            mycon.Close();

            return ds;
        }

        public DataSet Getcmshomepgmiddlelinks()
        {
            var ds = new DataSet();

            var myconstring = SlConnectionString.Makeconn;

            var mycon = new MySqlConnection { ConnectionString = myconstring };

            var myda =
                new MySqlDataAdapter(
                    "SELECT id_middlelinks as id_headerlinks,tb_middlelinks.* from tb_middlelinks;",
                    mycon);

            mycon.Open();

            myda.Fill(ds, "tb_middlelinks");

            mycon.Close();

            return ds;
        }

        public DataSet Getcmshomepgfootlinks()
        {
            var ds = new DataSet();

            var myconstring = SlConnectionString.Makeconn;

            var mycon = new MySqlConnection { ConnectionString = myconstring };

            var myda =
                new MySqlDataAdapter(
                    "SELECT id_footerlinks as id_headerlinks,tb_footerlinks.* from tb_footerlinks;",
                    mycon);

            mycon.Open();

            myda.Fill(ds, "tb_footerlinks");

            mycon.Close();

            return ds;
        }

        //end home page links

        public DataSet Getcmsarticles()
        {
            var ds = new DataSet();

            var myconstring = SlConnectionString.Makeconn;

            var mycon = new MySqlConnection { ConnectionString = myconstring };

            var myda =
                new MySqlDataAdapter(
                    "SELECT * from tb_articles;",
                    mycon);

            mycon.Open();

            myda.Fill(ds, "tb_articles");

            mycon.Close();

            return ds;
        }

        public DataSet Getcmsusers(int usertype)
        {
            var ds = new DataSet();

            var myconstring = SlConnectionString.Makeconn;

            var mycon = new MySqlConnection { ConnectionString = myconstring };

            var myda =
                new MySqlDataAdapter(
                    "SELECT idusers,ufirstname,ulastname,uusername from users where uUserType= '" + usertype + "'; ",
                    mycon);

            mycon.Open();

            myda.Fill(ds, "Users");

            mycon.Close();

            return ds;
        }

        public DataSet Getcmsusermoderations()
        {
            var ds = new DataSet();
            var myconstring = SlConnectionString.Makeconn;
            var mycon = new MySqlConnection { ConnectionString = myconstring };

            var myda = new MySqlDataAdapter("select * from vw_cmsusermoderation;", mycon);

            mycon.Open();

            myda.Fill(ds, "vw_cmsusermoderation");

            mycon.Close();

            return ds;
        }

        public DataSet Getcmssalarycatgs()
        {
            var ds = new DataSet();

            var myconstring = SlConnectionString.Makeconn;

            var mycon = new MySqlConnection { ConnectionString = myconstring };

            var myda = new MySqlDataAdapter("SELECT * from salaryoccupations where isdeleted=0; ", mycon);

            mycon.Open();

            myda.Fill(ds, "salaryoccupations");

            mycon.Close();

            return ds;
        }

        public DataSet Getcmsusers()
        {
            var ds = new DataSet();

            var myconstring = SlConnectionString.Makeconn;

            var mycon = new MySqlConnection { ConnectionString = myconstring };

            var myda = new MySqlDataAdapter("SELECT idusers,ufirstname,ulastname,uusername from users; ", mycon);

            mycon.Open();

            myda.Fill(ds, "users");

            mycon.Close();

            return ds;
        }

        public DataSet Getactivejobs()
        {
            var ds = new DataSet();

            var myconstring = SlConnectionString.Makeconn;

            var mycon = new MySqlConnection { ConnectionString = myconstring };

            var myda =
                new MySqlDataAdapter(
                    "SELECT 1 as actives,idjobs,stitle,dtEnteredDate,sRef from jobs where sjobenddate >= curdate(); ",
                    mycon);

            mycon.Open();

            myda.Fill(ds, "jobs");

            mycon.Close();

            return ds;
        }

        public DataSet Getalljobs()
        {
            var ds = new DataSet();

            var myconstring = SlConnectionString.Makeconn;

            var mycon = new MySqlConnection { ConnectionString = myconstring };

            var myda = new MySqlDataAdapter("SELECT 1 as actives,idjobs,stitle,dtEnteredDate,sRef from jobs; ", mycon);

            mycon.Open();

            myda.Fill(ds, "jobs");

            mycon.Close();

            return ds;
        }

        public DataSet Getarchivedjobs()
        {
            var ds = new DataSet();

            var myconstring = SlConnectionString.Makeconn;

            var mycon = new MySqlConnection { ConnectionString = myconstring };

            var myda =
                new MySqlDataAdapter(
                    "SELECT 0 as actives, idjobs,stitle,dtEnteredDate,sRef from jobs where sjobenddate < curdate(); ",
                    mycon);

            mycon.Open();

            myda.Fill(ds, "jobs");

            mycon.Close();

            return ds;
        }

        public DataSet Getactiverec()
        {
            var ds = new DataSet();

            var myconstring = SlConnectionString.Makeconn;

            var mycon = new MySqlConnection { ConnectionString = myconstring };

            var myda =
                new MySqlDataAdapter(
                    "SELECT  empid, sRecruitername, sEmailaddress, sWebsite, sisactive from recruiters where sisactive=1; ",
                    mycon);

            mycon.Open();

            myda.Fill(ds, "recruiters");

            mycon.Close();

            return ds;
        }

        public DataSet Getallrec()
        {
            var ds = new DataSet();

            var myconstring = SlConnectionString.Makeconn;

            var mycon = new MySqlConnection { ConnectionString = myconstring };

            var myda =
                new MySqlDataAdapter(
                    "SELECT  empid, sRecruitername, sEmailaddress, sWebsite, sisactive from recruiters; ", mycon);

            mycon.Open();

            myda.Fill(ds, "recruiters");

            mycon.Close();

            return ds;
        }

        public DataSet Getarchivedrec()
        {
            var ds = new DataSet();

            var myconstring = SlConnectionString.Makeconn;

            var mycon = new MySqlConnection { ConnectionString = myconstring };

            var myda =
                new MySqlDataAdapter(
                    "SELECT  empid, sRecruitername, sEmailaddress, sWebsite, sisactive from recruiters where sisactive=0; ",
                    mycon);

            mycon.Open();

            myda.Fill(ds, "recruiters");

            mycon.Close();

            return ds;
        }

        public DataSet Getsiteheaders()
        {
            var ds = new DataSet();
            var myconstring = SlConnectionString.Makeconn;

            var mycon = new MySqlConnection { ConnectionString = myconstring };

            var myda = new MySqlDataAdapter("SELECT * from tb_siteheader; ", mycon);

            mycon.Open();

            myda.Fill(ds, "tb_siteheader");

            mycon.Close();

            return ds;
        }

        public DataSet Getpagetitlebranding()
        {
            var ds = new DataSet();
            var myconstring = SlConnectionString.Makeconn;

            var mycon = new MySqlConnection { ConnectionString = myconstring };

            var myda = new MySqlDataAdapter("SELECT * from tb_branding;", mycon);

            mycon.Open();

            myda.Fill(ds, "tb_branding");

            mycon.Close();

            return ds;
        }

        public DataSet Getcpaneloptions()
        {
            var ds = new DataSet();
            var myconstring = SlConnectionString.Makeconn;
            var mycon = new MySqlConnection { ConnectionString = myconstring };

            var myda = new MySqlDataAdapter("select * from tb_cpanel;", mycon);

            mycon.Open();

            myda.Fill(ds, "tb_cpanel");

            mycon.Close();

            return ds;
        }

        public void Deletecmsusermoderations(int val)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "UPDATE tb_usermoderation set requesttype = -1 where idtb_usermoderation = @idmod;";

                    com.Parameters.Add("@idmod", MySqlDbType.Int32).Value = val;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public void Deletecmssalarycatgs(int val)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText = "UPDATE salaryoccupations set isdeleted = 1 where idsalaryoccupations = @idmod;";

                    com.Parameters.Add("@idmod", MySqlDbType.Int32).Value = val;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }
    }
}