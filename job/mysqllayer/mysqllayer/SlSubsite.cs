using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections;

namespace Mysqllayer
{
    public class SlSubsite
    {
        public void Insertcandata(string username, string pwd, string firstname, string lastname, string telephone,
                                  string website, string gender, string address1, string address2, string address3,
                                  string town, string county, string postcode, string country, string city,
                                  string employername, string employerlocation, string employerposition,
                                  string employerjobdescription, string educationschoolname, string educationtype,
                                  string educationdegree, string educationyear, string educationconcentration,
                                  string spokenlang1, string spokenlang2, string spokenlang3, string hobbies)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "INSERT INTO `tb_webserviceusr` ( `username`, `pwd`, `firstname`, `lastname`, `telephone`, `website`, `gender`, `address1`, `address2`,  `address3`, `town`, `county`, `postcode`, `country`, `city`, `employername`, `employerlocation`, `employerposition`, `employerjobdescription`, `educationschoolname`, `educationtype`, `educationdegree`, `educationyear`, `educationconcentration`, `spokenlang1`, `spokenlang2`,`spokenlang3`, `dtentered`, `hobbies`) VALUES ( @username,@pwd,@firstname,@lastname,@telephone,@website,@gender,@address1,@address2,@address3,@town,@county,@postcode,@country, @city,@employername,@employerlocation,@employerposition,@employerjobdescription,@educationschoolname,@educationtype,@educationdegree,@educationyear,@educationconcentration,@spokenlang1,@spokenlang2,@spokenlang3,@dtentered,@hobbies);";

                    com.Parameters.Add("@username", MySqlDbType.VarString).Value = username;
                    com.Parameters.Add("@pwd", MySqlDbType.VarString).Value = pwd;
                    com.Parameters.Add("@firstname", MySqlDbType.VarString).Value = firstname;
                    com.Parameters.Add("@lastname", MySqlDbType.VarString).Value = lastname;
                    com.Parameters.Add("@telephone", MySqlDbType.VarString).Value = telephone;
                    com.Parameters.Add("@website", MySqlDbType.VarString).Value = website;
                    com.Parameters.Add("@gender", MySqlDbType.VarString).Value = gender;
                    com.Parameters.Add("@address1", MySqlDbType.VarString).Value = address1;
                    com.Parameters.Add("@address2", MySqlDbType.VarString).Value = address2;
                    com.Parameters.Add("@address3", MySqlDbType.VarString).Value = address3;
                    com.Parameters.Add("@town", MySqlDbType.VarString).Value = town;
                    com.Parameters.Add("@county", MySqlDbType.VarString).Value = county;
                    com.Parameters.Add("@postcode", MySqlDbType.VarString).Value = postcode;
                    com.Parameters.Add("@country", MySqlDbType.VarString).Value = country;
                    com.Parameters.Add("@city", MySqlDbType.VarString).Value = city;
                    com.Parameters.Add("@employername", MySqlDbType.VarString).Value = employername;
                    com.Parameters.Add("@employerlocation", MySqlDbType.VarString).Value = employerlocation;
                    com.Parameters.Add("@employerposition", MySqlDbType.VarString).Value = employerposition;
                    com.Parameters.Add("@employerjobdescription", MySqlDbType.VarString).Value = employerjobdescription;
                    com.Parameters.Add("@educationschoolname", MySqlDbType.VarString).Value = educationschoolname;
                    com.Parameters.Add("@educationtype", MySqlDbType.VarString).Value = educationtype;
                    com.Parameters.Add("@educationdegree", MySqlDbType.VarString).Value = educationdegree;
                    com.Parameters.Add("@educationyear", MySqlDbType.VarString).Value = educationyear;
                    com.Parameters.Add("@educationconcentration", MySqlDbType.VarString).Value = educationconcentration;
                    com.Parameters.Add("@spokenlang1", MySqlDbType.VarString).Value = spokenlang1;
                    com.Parameters.Add("@spokenlang2", MySqlDbType.VarString).Value = spokenlang2;
                    com.Parameters.Add("@spokenlang3", MySqlDbType.VarString).Value = spokenlang3;
                    com.Parameters.Add("@dtentered", MySqlDbType.Date).Value = DateTime.Now;
                    com.Parameters.Add("@hobbies", MySqlDbType.VarString).Value = hobbies;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public string Getuserexitid(string webuserid)
        {
            //store rec details
            var val = string.Empty;

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command =
                    new MySqlCommand("select id_webserviceusr from tb_webserviceusr where id_webserviceusr = @param1;",
                                     connreader);
                command.Parameters.Add("@param1", MySqlDbType.String).Value = webuserid;

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

        //subsite
        /*
        public string GetSubsiteMax()
        {
            var mg = new minGuid.Minimumguid();

            return mg.MinGuid();
        }
        */

        public int GetSubsiteId(string sitename)
        {
            //store rec details
            var val = 0;

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command =
                    new MySqlCommand("select idsubsite from tb_subsite where subsitename = @param1;",
                                     connreader);
                command.Parameters.Add("@param1", MySqlDbType.String).Value = sitename;

                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        val = reader.GetInt32(0);
                    }
                }

                reader.Close();
            }
            return val;
        }

        public string[] GetSubsiteName(int siteid)
        {
            //store rec details
            string[] val = new string[3];
            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command =
                    new MySqlCommand(@"select subsitename, ifnull(sURL,0) as surl, sIsCname from tb_subsite where idsubsite = @param1;",
                                     connreader);
                command.Parameters.Add("@param1", MySqlDbType.Int32).Value = siteid;

                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        val[0] = reader.GetString(0);
                        val[1] = reader.GetString(1);
                        val[2] = reader.GetString(2);
                    }
                }

                reader.Close();
            }
            return val;
        }

        public void InsertSubsite(string sitename, string siteurl, int iscname, string siteid)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "Insert into tb_subsite(idsubsite, SubsiteName, sURL, siscname, dtentered) VALUES(@siteid, @param1, @siteurl, @iscname, @datestamp);  ";

                    com.Parameters.Add("@param1", MySqlDbType.String).Value = sitename;
                    com.Parameters.Add("@siteid", MySqlDbType.VarChar).Value = siteid;
                    com.Parameters.Add("@siteurl", MySqlDbType.String).Value = siteurl;
                    com.Parameters.Add("@iscname", MySqlDbType.Int32).Value = iscname;
                    com.Parameters.Add("@datestamp", MySqlDbType.DateTime).Value = DateTime.Now;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public void UpdateSubsite(string sitename, string siteurl, int iscname, int siteid)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "UPDATE tb_subsite SET SubsiteName = @param1, sURL = @siteurl, siscname = @iscname, dtupdated = @datestamp where idsubsite = @siteid ;  ";

                    com.Parameters.Add("@param1", MySqlDbType.String).Value = sitename;
                    com.Parameters.Add("@siteid", MySqlDbType.Int32).Value = siteid;
                    com.Parameters.Add("@siteurl", MySqlDbType.String).Value = siteurl;
                    com.Parameters.Add("@iscname", MySqlDbType.Int32).Value = iscname;
                    com.Parameters.Add("@datestamp", MySqlDbType.DateTime).Value = DateTime.Now;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public void UpdateMainPageTemplate(int templateid, int siteid)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "Update tb_subsite set sMainPageTemplate = @param1, dtupdated=@datestamp where idsubsite = @param2;  ";

                    com.Parameters.Add("@param1", MySqlDbType.Int32).Value = templateid;
                    com.Parameters.Add("@datestamp", MySqlDbType.DateTime).Value = DateTime.Now;
                    com.Parameters.Add("@param2", MySqlDbType.Int32).Value = siteid;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public int GetMainPageTemplate(int siteid)
        {
            //store rec details
            var val = 0;

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command =
                    new MySqlCommand("select sMainPageTemplate from tb_subsite where idsubsite = @param1;",
                                     connreader);
                command.Parameters.Add("@param1", MySqlDbType.Int32).Value = siteid;

                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        val = reader.GetInt16(0);
                    }
                }

                reader.Close();
            }
            return val;
        }

        public int GetSearchPageTemplate(int siteid)
        {
            //store rec details
            var val = 0;

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command =
                    new MySqlCommand("select sSearchPageTemplate from tb_subsite where idsubsite = @param1;",
                                     connreader);
                command.Parameters.Add("@param1", MySqlDbType.Int32).Value = siteid;

                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        val = reader.GetInt16(0);
                    }
                }

                reader.Close();
            }
            return val;
        }

        public void UpdateSearchPageTemplate(int templateid, int siteid)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "Update tb_subsite set sSearchPageTemplate = @param1, dtupdated=@datestamp where idsubsite = @param2;  ";

                    com.Parameters.Add("@param1", MySqlDbType.Int32).Value = templateid;
                    com.Parameters.Add("@datestamp", MySqlDbType.DateTime).Value = DateTime.Now;
                    com.Parameters.Add("@param2", MySqlDbType.Int32).Value = siteid;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public void InsertSubsiteCat(string category, int siteid)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "Insert into tb_subsite_category(scategoryname, dtentered ,idsubsite) VALUES(@param1, @datestamp, @param2);  ";

                    com.Parameters.Add("@param1", MySqlDbType.String).Value = category;
                    com.Parameters.Add("@datestamp", MySqlDbType.DateTime).Value = DateTime.Now;
                    com.Parameters.Add("@param2", MySqlDbType.Int32).Value = siteid;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public DataTable GetSubsiteCat(int siteid)
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };
            var selectcmd = new MySqlCommand("select scatid, scategoryname from tb_subsite_category where idsubsite = @param1 ;", mycon) { CommandType = CommandType.Text };

            selectcmd.Parameters.Add("@param1", MySqlDbType.Int32).Value = siteid;

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };
            var dt = new DataTable("tb_subsite_category");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        public ArrayList GetSubsiteCatListView(int siteid)
        {
            var al = new ArrayList();
            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command =
                    new MySqlCommand("select scatid, scategoryname from tb_subsite_category where idsubsite = @param1 ;", connreader);
                command.Parameters.Add("@param1", MySqlDbType.Int32).Value = siteid;

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

        public ArrayList GetSubsiteSubCatListView(int siteid, int catid)
        {
            var al = new ArrayList();
            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command =
                    new MySqlCommand("select subcatid, subcatname from vw_subsite_cats where idsubsite = @param1 and catid = @param2;", connreader);
                command.Parameters.Add("@param1", MySqlDbType.Int32).Value = siteid;
                command.Parameters.Add("@param2", MySqlDbType.Int32).Value = catid;

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

        public void DeleteSubsiteCat(int siteid, int catid)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "DELETE FROM tb_subsite_category where scatid = @param1 and idsubsite = @param2 ; ";

                    com.Parameters.Add("@param1", MySqlDbType.Int32).Value = catid;
                    com.Parameters.Add("@param2", MySqlDbType.Int32).Value = siteid;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public void DeleteSubsiteCatLookup(int catid, int subcatid)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "DELETE FROM tb_subsite_link_cat where scatid = @param1 and ssubcatid = @param2 ; ";

                    com.Parameters.Add("@param1", MySqlDbType.Int32).Value = catid;
                    com.Parameters.Add("@param2", MySqlDbType.Int32).Value = subcatid;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public void DeleteSubsiteSubCat(int siteid, int subcatid)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "DELETE FROM tb_subsite_link_cat where ssubcatid = @param1 and idsubsite = @param2 ; ";

                    com.Parameters.Add("@param1", MySqlDbType.Int32).Value = subcatid;
                    com.Parameters.Add("@param2", MySqlDbType.Int32).Value = siteid;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        /*
        public string GetSubsiteSubcatsId()
        {
            var mg = new minGuid.Minimumguid();

            return mg.MinGuid();
        }
         */

        public void InsertSubsiteCatLinks(int catid, string subcatid)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "Insert into tb_subsite_link_cat(scatid, ssubcatid, dtentered) VALUES(@category, @subcategory , @datestamp); ";

                    com.Parameters.Add("@category", MySqlDbType.Int32).Value = catid;
                    com.Parameters.Add("@datestamp", MySqlDbType.DateTime).Value = DateTime.Now;
                    com.Parameters.Add("@subcategory", MySqlDbType.VarChar).Value = subcatid;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public void InsertSubsiteSubcat(string subcatid, string subcatname)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText = "Insert into tb_subsite_subcats(ssubcatid, scategoryname, dtentered ) VALUES (@param1, @param2, @datestamp); ";

                    com.Parameters.Add("@param1", MySqlDbType.VarChar).Value = subcatid;
                    com.Parameters.Add("@datestamp", MySqlDbType.DateTime).Value = DateTime.Now;
                    com.Parameters.Add("@param2", MySqlDbType.String).Value = subcatname;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public void InsertSubsiteBrandColor(string tColor1, string tColor2, string tColor3, string tColor4, string tColor5, string tColor6, string tColor7, string tColor8, int siteid)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText = " INSERT INTO tb_subsite_themes (tColor1, tColor2, tColor3, tColor4, tColor5, tColor6, tColor7, tColor8,`idsubsite`,`dtEntered`)VALUES(@tColor1 , @tColor2, @tColor3, @tColor4, @tColor5, @tColor6, @tColor7, @tColor8, @idsubsite, @dtEntered); ";

                    com.Parameters.Add("@tColor1", MySqlDbType.String).Value = tColor1;
                    com.Parameters.Add("@tColor2", MySqlDbType.String).Value = tColor2;
                    com.Parameters.Add("@tColor3", MySqlDbType.String).Value = tColor3;
                    com.Parameters.Add("@tColor4", MySqlDbType.String).Value = tColor4;
                    com.Parameters.Add("@tColor5", MySqlDbType.String).Value = tColor5;
                    com.Parameters.Add("@tColor6", MySqlDbType.String).Value = tColor6;
                    com.Parameters.Add("@tColor7", MySqlDbType.String).Value = tColor7;
                    com.Parameters.Add("@tColor8", MySqlDbType.String).Value = tColor8;
                    com.Parameters.Add("@idsubsite", MySqlDbType.Int32).Value = siteid;
                    com.Parameters.Add("@dtEntered", MySqlDbType.DateTime).Value = DateTime.Now;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        //set ads for the subsite
        public void InsertSubsiteAds(string mainpagescript, string searchpagescript, string applicationpagescript, int isonheader, int isonrightpanel, int isonsearchcat, int isonsearchtop, int isonsearchbottom, int idsubsite)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText = " INSERT INTO tb_subsite_adverts ( sMainPageScript , sSearchPageScript , sApplicationPageScript , sIsOnHeader , sIsOnRightPanel , sIsOnSearchCat , sIsOnSearchTop , sIsOnSearchBottom, dtEntered , idsubsite )VALUES( @sMainPageScript , @sSearchPageScript, @sApplicationPageScript , @sIsOnHeader, @sIsOnRightPanel , @sIsOnSearchCat, @sIsOnSearchTop , @sIsOnSearchBottom , @dtEntered , @idsubsite );  ";

                    com.Parameters.Add("@sMainPageScript", MySqlDbType.String).Value = mainpagescript;
                    com.Parameters.Add("@sSearchPageScript", MySqlDbType.String).Value = searchpagescript;
                    com.Parameters.Add("@sApplicationPageScript", MySqlDbType.String).Value = applicationpagescript;
                    com.Parameters.Add("@sIsOnHeader", MySqlDbType.Bit).Value = isonheader;
                    com.Parameters.Add("@sIsOnRightPanel", MySqlDbType.Bit).Value = isonrightpanel;
                    com.Parameters.Add("@sIsOnSearchCat", MySqlDbType.Bit).Value = isonsearchcat;
                    com.Parameters.Add("@sIsOnSearchTop", MySqlDbType.Bit).Value = isonsearchtop;
                    com.Parameters.Add("@sIsOnSearchBottom", MySqlDbType.Bit).Value = isonsearchbottom;
                    com.Parameters.Add("@dtEntered", MySqlDbType.DateTime).Value = DateTime.Now;
                    com.Parameters.Add("@idsubsite", MySqlDbType.Int32).Value = idsubsite;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public void UpdateSubsiteAds(string mainpagescript, string searchpagescript, string applicationpagescript, int isonheader, int isonrightpanel, int isonsearchcat, int isonsearchtop, int isonsearchbottom, int idsubsite)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText = " UPDATE  tb_subsite_adverts  SET sMainPageScript = @sMainPageScript, sSearchPageScript  = @sSearchPageScript,  sApplicationPageScript  = @sApplicationPageScript,  sIsOnHeader  =  @sIsOnHeader,  sIsOnRightPanel  =  @sIsOnRightPanel,  sIsOnSearchCat  =  @sIsOnSearchCat,  sIsOnSearchTop  = @sIsOnSearchTop,  sIsOnSearchBottom  = @sIsOnSearchBottom,  dtUpdated  =  @dtUpdated  WHERE idsubsite = @idsubsite ;";

                    com.Parameters.Add("@sMainPageScript", MySqlDbType.String).Value = mainpagescript;
                    com.Parameters.Add("@sSearchPageScript", MySqlDbType.String).Value = searchpagescript;
                    com.Parameters.Add("@sApplicationPageScript", MySqlDbType.String).Value = applicationpagescript;
                    com.Parameters.Add("@sIsOnHeader", MySqlDbType.Bit).Value = isonheader;
                    com.Parameters.Add("@sIsOnRightPanel", MySqlDbType.Bit).Value = isonrightpanel;
                    com.Parameters.Add("@sIsOnSearchCat", MySqlDbType.Bit).Value = isonsearchcat;
                    com.Parameters.Add("@sIsOnSearchTop", MySqlDbType.Bit).Value = isonsearchtop;
                    com.Parameters.Add("@sIsOnSearchBottom", MySqlDbType.Bit).Value = isonsearchbottom;
                    com.Parameters.Add("@dtUpdated", MySqlDbType.DateTime).Value = DateTime.Now;
                    com.Parameters.Add("@idsubsite", MySqlDbType.Int32).Value = idsubsite;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        //get fonts
        public DataTable GetSubsiteFonts()
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };
            var selectcmd = new MySqlCommand(" select id_font, fFontName from tb_subsite_font; ", mycon) { CommandType = CommandType.Text };

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };
            var dt = new DataTable("tb_subsite_font");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        /*Insert Statement*/
        public void InsertSubsiteImages(string iURL, string iImageName, int idsubsite)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText = "Insert into tb_subsite_images( iURL, iImageName, idsubsite, dtEntered ) VALUES(  @iURL, @iImageName, @idsubsite, @dtEntered); ";

                    com.Parameters.Add("@iURL", MySqlDbType.VarChar).Value = iURL;
                    com.Parameters.Add("@iImageName", MySqlDbType.VarChar).Value = iImageName;
                    com.Parameters.Add("@idsubsite", MySqlDbType.Int32).Value = idsubsite;
                    com.Parameters.Add("@dtEntered", MySqlDbType.DateTime).Value = DateTime.Now;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        //get images
        public string[] GetSubsiteImages(int subsiteid) { return null; }

        /*Update Statement*/
        public void UpdatetbSubsiteImages(string iURL, string iImageName, int idsubsite)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText = "Update tb_subsite_images SET iURL = @iURL, iImageName = @iImageName, idsubsite = @idsubsite, dtEntered = @dtEntered where idsubsite = @idsubsite ; ";

                    com.Parameters.Add("@iURL", MySqlDbType.VarChar).Value = iURL;
                    com.Parameters.Add("@iImageName", MySqlDbType.VarChar).Value = iImageName;
                    com.Parameters.Add("@idsubsite", MySqlDbType.Int32).Value = idsubsite;
                    com.Parameters.Add("@dtEntered", MySqlDbType.DateTime).Value = DateTime.Now;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }
    }
}