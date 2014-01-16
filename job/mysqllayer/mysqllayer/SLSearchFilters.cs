using System.Data;
using MySql.Data.MySqlClient;

namespace Mysqllayer
{
    public class SlSearchfilters
    {
        //this part handles query when all of the text is blank
        //this is for showing everything in browse control

        /// <summary>
        /// one eye search
        /// </summary>
        /// <returns></returns>
        ///

        public int CaseBrowseGridAll()
        {
            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var ct = 0;

            using (connreader)
            {
                var command = new MySqlCommand(@"select count(idjobs) as ct from vw_aggregatedmulti;",
                    connreader);
                connreader.Open();

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ct = reader.GetInt32(0);
                    }
                }
                reader.Close();
            }

            return ct;
        }

        public int Casebrowsergrid(string criterion)
        {
            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var ct = 0;

            using (connreader)
            {
                var command = new MySqlCommand("SELECT count(*) as ct,  " + criterion + " ; ",
                    connreader);
                connreader.Open();

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ct = reader.GetInt32(0);
                    }
                }
                reader.Close();
            }

            return ct;
        }

        public DataTable Casebrowsergrid(string criterion, int _low, int _high)
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd = new MySqlCommand("SELECT " + criterion + " limit " + _low + "," + _high + " ;", mycon) { CommandType = CommandType.Text };

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("vw_aggregatedmulti");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        public DataTable Casebrowserfilter(string criterion)
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd = new MySqlCommand("SELECT " + criterion + " ;", mycon) { CommandType = CommandType.Text };

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("vw_brfilter");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        public int CaseallCount()
        {
            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var ct = 0;

            using (connreader)
            {
                var command = new MySqlCommand(@"select count(idjobs) as ct from vw_applytitlefilter;",
                    connreader);
                connreader.Open();

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ct = reader.GetInt32(0);
                    }
                }
                reader.Close();
            }

            return ct;
        }

        public DataTable Caseall(int _lowlimit, int _highlimit)
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd = new MySqlCommand(
                "select * from vw_applytitlefilter order by dtentereddate desc limit " + _lowlimit + "," + _highlimit + ";", mycon) { CommandType = CommandType.Text };

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("vw_applytitlefilter");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        public DataTable CaseWithCheckBoxes(string criterion, int low, int high)
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            /*" group by applicationvolume, spostcode, idjobs, stitle, video, company, slocation, srecruitername, sshortdescription, sfreetext, dtentereddate, ssalarytext, employeeid 
                     */
            var selectcmd =
                new MySqlCommand(
                    @"SELECT applicationvolume, spostcode, idjobs, stitle, video, company, slocation, srecruitername, sshortdescription, sfreetext, dtentereddate,ssalarytext, employeeid FROM vw_aggregatedmulti " +
                    criterion + " group by idjobs order by dtentereddate desc limit " + low + "," + high + " ;",
                    mycon) { CommandType = CommandType.Text };

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("vw_aggregatedmulti");

            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        public int CaseWithCheckBoxes(string criterion)
        {
            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var ct = 0;

            using (connreader)
            {
                var command = new MySqlCommand(
                     @"SELECT count(idjobs) as ct FROM vw_aggregatedmulti " +
                    criterion + " group by idjobs" + " ; ",
                    connreader);
                connreader.Open();

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ct = reader.GetInt32(0);
                    }
                }
                reader.Close();
            }

            return ct;
        }

        public int Casewochkbox(string criterion)
        {
            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var ct = 0;

            using (connreader)
            {
                var command = new MySqlCommand("select count(idjobs) as ct from vw_applytitlefilter " + criterion + " ; ",
                    connreader);
                connreader.Open();

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ct = reader.GetInt32(0);
                    }
                }
                reader.Close();
            }

            return ct;
        }

        public DataTable Casewochkbox(string criterion, int _lowlimit, int _highlimit)
        {  
                var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

                var selectcmd =
                    new MySqlCommand("select * from vw_applytitlefilter " + criterion + " order by dtentereddate desc limit " + _lowlimit + "," + _highlimit + ";", mycon) { CommandType = CommandType.Text };

                var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

                var dt = new DataTable("vw_applytitlefilter");
                selectdataadp.Fill(dt);

                mycon.Close();

                return dt;         
        }

        public DataTable Getdefaultbrall()
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd = new MySqlCommand("SELECT catid as viewcatid, '' as subcatid, sum(ctotals) as ctotals, cdefinition as sdefinition from vw_brfilter group by catid;", mycon) { CommandType = CommandType.Text };

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("vw_brfilter");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        public DataSet Dpbrowse(string valuein)
        {
            var ds = new DataSet();

            var myconstring = SlConnectionString.Makeconn;

            var mycon = new MySqlConnection { ConnectionString = myconstring };

            var myda = new MySqlDataAdapter("Select subcatid, sdefinition, ctotals from " + valuein + " ;", mycon);

            mycon.Open();

            myda.Fill(ds, valuein);

            mycon.Close();

            return ds;
        }

        //count children for cat browsing
        public int BrowseCheck(int catid, string qry)
        {
            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var ct = 0;

            using (connreader)
            {
                var command = new MySqlCommand(@"select lichildren from vw_brfilter where catid =" + catid + " and sdefinition = '" + qry + "';",
                    connreader);
                connreader.Open();

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ct = reader.GetInt32(0);
                    }
                }
                reader.Close();
            }

            return ct;
        }

        //count children for subcat browsing
        public string BrowseCheck(int listid)
        {
            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };
            var ct = "";

            using (connreader)
            {
                var command = new MySqlCommand(@"select subcatlevel from subcatslist where subcatid = " + listid + ";",
                            connreader);
                connreader.Open();

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ct += " subcatid = " + reader.GetInt32(0) + " OR";
                    }
                }
                reader.Close();
            }

            if (ct.Length > 0)
            {
                return ct.Substring(0, ct.Length - 2);
            }

            else
            {
                return "";
            }
        }

        //this is for subcats
        public DataTable CategoryBrowser()
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd = new MySqlCommand("SELECT catid as viewcatid, subcatid, catid, sdefinition, cdefinition, ctotals, liparent, lichildren FROM vw_brfilter ;",
                                             mycon) { CommandType = CommandType.Text };

            //            var selectcmd = new MySqlCommand(@"SELECT catid as viewcatid, f.subcatid, catid, sdefinition, cdefinition, ctotals, liparent, lichildren,s.subcatlevel as
            //                                    newcat FROM  vw_brfilter f left join subcatslist s on  s.subcatid = f.subcatid;",
            //                                             mycon) { CommandType = CommandType.Text };

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("vw_brfilter");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        //New Paging: Grid items for WAP
        public DataTable GetWapTextWBars(int itemid, int _lowlimit, int _highlimit)
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd = new MySqlCommand("SELECT * from vw_aggregatedmulti where subcatid = @param1 limit " + _lowlimit + "," + _highlimit + ";",
                                             mycon) { CommandType = CommandType.Text };

            selectcmd.Parameters.Add("@param1", MySqlDbType.Int32).Value = itemid;

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("vw_aggregatedmulti");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        public int GetWapTextWBars(int itemid)
        {
            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var ct = 0;

            using (connreader)
            {
                var command = new MySqlCommand("SELECT count(idjobs) as ct from vw_aggregatedmulti where subcatid = " + itemid + "; ",
                    connreader);
                connreader.Open();

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ct = reader.GetInt32(0);
                    }
                }
                reader.Close();
            }

            return ct;
        }

        //get grid items lev2
        public DataTable Getgriditeml2(int itemid)
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd = new MySqlCommand("SELECT * from vw_aggregatedmulti where subcatid = @param1 limit 500;",
                                             mycon) { CommandType = CommandType.Text };

            selectcmd.Parameters.Add("@param1", MySqlDbType.Int32).Value = itemid;

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("vw_aggregatedmulti");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        //get grid items lev1
        public DataTable Getgridsetitems(int itemid)
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd =
                new MySqlCommand(
                    "select max(idjobs)as idjobs,catid,sLocation,dtEnteredDate,sSalaryText,applicationvolume,stitle,company,video, sshortdescription from  vw_aggregatedmulti group by idjobs having catid = @param1 ;",
                    mycon) { CommandType = CommandType.Text };

            selectcmd.Parameters.Add("@param1", MySqlDbType.Int32).Value = itemid;

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("vw_aggregatedmulti");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        public DataTable WapLevel2(int itemid, int _level, int low, int high)
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd =
                new MySqlCommand(
                    @"select j.idjobs as idjobs, stitle, ssalarytext, dtentereddate, srecruitername, sshortdescription 
                        from jobs j, jobtable jt where j.idjobs = jt.idjobs and j.sjobenddate >= curdate() and jt.catid = " + itemid + " group by idjobs limit "
                            + low + "," + high + ";",
                    mycon) { CommandType = CommandType.Text };

            selectcmd.Parameters.Add("@param1", MySqlDbType.VarChar).Value = itemid;

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("jobs");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        public int WapLevel2(int itemid, int _level)
        {
            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var ct = 0;

            using (connreader)
            {
                var command = new MySqlCommand(
                            @"select j.idjobs as idjobs, stitle, ssalarytext, dtentereddate, srecruitername, sshortdescription 
                        from jobs j, jobtable jt where j.idjobs = jt.idjobs and j.sjobenddate >= curdate() and jt.catid = " + itemid + " group by idjobs",
                   connreader);
                connreader.Open();

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ct += 1;
                    }
                }
                reader.Close();
            }

            return ct;
        }

        public DataTable WapLevelItems(int itemid, int _level, int low, int high)
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd =
                new MySqlCommand(
                    @"select j.idjobs as idjobs, stitle, ssalarytext, dtentereddate, srecruitername, sshortdescription , sisvideoenabled as video ,slocation, srecruitername as company
                        from jobs j, jobtable jt where j.idjobs = jt.idjobs and j.sjobenddate >= curdate() and jt.subcatid = " + itemid +
                            " group by j.idjobs limit " + low + "," + high + ";",
                    mycon) { CommandType = CommandType.Text };

            // selectcmd.Parameters.Add("@param1", MySqlDbType.VarChar).Value = itemid;

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("jobs");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        public int WapLevelItems(int itemid, int _level)
        {
            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var ct = 0;

            using (connreader)
            {
                var command = new MySqlCommand(
                            @"select j.idjobs as idjobs, stitle, ssalarytext, dtentereddate, srecruitername, sshortdescription 
                                from jobs j, jobtable jt where j.idjobs = jt.idjobs and j.sjobenddate >= curdate() and jt.subcatid = " + itemid +
                                    " group by j.idjobs;",
                   connreader);
                connreader.Open();

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ct += 1;
                    }
                }
                reader.Close();
            }

            return ct;
        }

        public DataTable WapLevelCat(int itemid, int low, int high)
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd =
                new MySqlCommand(
                    @"select j.idjobs as idjobs, j.sisvideoenabled as video, stitle, ssalarytext, dtentereddate, srecruitername, srecruitername as company, sshortdescription , slocation
                        from jobs j, jobtable jt, categories c where j.idjobs = jt.idjobs and jt.catid = c.catid and j.sjobenddate >= curdate() 
                            and c.catid = " + itemid + " group by idjobs limit " + low + "," + high + ";",
                    mycon) { CommandType = CommandType.Text };

            selectcmd.Parameters.Add("@param1", MySqlDbType.VarChar).Value = itemid;

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("jobs");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        public int WapLevelCat(int itemid)
        {
            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var ct = 0;

            using (connreader)
            {
                var command = new MySqlCommand(@"select j.idjobs as idjobs
                        from jobs j, jobtable jt, categories c where j.idjobs = jt.idjobs and jt.catid = c.catid and j.sjobenddate >= curdate() 
                            and c.catid = " + itemid + " group by idjobs;",
                   connreader);
                connreader.Open();

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ct += 1;
                    }
                }
                reader.Close();
            }

            return ct;
        }

        //get categories for text page
        public DataTable Getdefaulttxtcat(string ftsearch)
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd =
                new MySqlCommand(
                    "select sum(vwdft.counts) as ctotals, max(vwdft.sdefinition) as sdefinition, max(vwdft.subcatid) as subcatid from vw_defaulttextsub vwdft, jobs j where vwdft.idjobs = j.idjobs and match(j.sfreetext) against (@param1) group by vwdft.sdefinition;",
                    mycon) { CommandType = CommandType.Text };

            selectcmd.Parameters.Add("@param1", MySqlDbType.VarChar).Value = ftsearch;

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("vw_defaulttextsub");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        //New Paging: get all job count
        public int GetAllWapJobs()
        {
            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var ct = 0;

            using (connreader)
            {
                var command = new MySqlCommand("select count(idjobs) from jobs;",
                    connreader);
                connreader.Open();

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ct = reader.GetInt32(0);
                    }
                }
                reader.Close();
            }

            return ct;
        }

        //New Paging: for all jobs wap
        public DataTable GetAllWapJobs(int _lowlimit, int _highlimit)
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd = new MySqlCommand("select idjobs, stitle, dtentereddate, sshortdescription, ssalarytext, srecruitername, sisvideoenabled as video from jobs order by dtentereddate desc limit " + _lowlimit + "," + _highlimit + ";",
                                             mycon) { CommandType = CommandType.Text };

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("jobs");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        //case : simple search retreive all results
        public DataTable Gettballsrchval()
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd = new MySqlCommand("select * from vw_aggregatedmpage order by dtentereddate desc limit 500;",
                                             mycon) { CommandType = CommandType.Text };

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("vw_aggregatedmpage");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        //New Paging: single search match
        //single search match
        public DataTable WapSearchByText(string ftsearch, int _lowlimit, int _highlimit)
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd =
                new MySqlCommand("select idjobs, stitle, dtentereddate, sshortdescription, ssalarytext, srecruitername, sfreetext from jobs where match(sfreetext) against (@param1) limit " + _lowlimit + "," + _highlimit + ";", mycon) { CommandType = CommandType.Text };

            selectcmd.Parameters.Add("@param1", MySqlDbType.VarChar).Value = ftsearch;

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("jobs");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        public int WapSearchByText(string ftsearch)
        {
            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var ct = 0;

            using (connreader)
            {
                var command = new MySqlCommand("select count(idjobs) as ct from jobs where match(sfreetext) against ('" + ftsearch + "') ;",
                    connreader);
                connreader.Open();

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ct = reader.GetInt32(0);
                    }
                }
                reader.Close();
            }

            return ct;
        }

        //single search match
        public DataTable Singlesearchsmatch(string ftsearch)
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd =
                new MySqlCommand(
                    "select * from vw_applytitlefilter where match(sfreetext) against (@param1) limit 500;", mycon) { CommandType = CommandType.Text };

            selectcmd.Parameters.Add("@param1", MySqlDbType.VarChar).Value = ftsearch;

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("jobs");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        //get filtered / searched values
        public DataSet Applytitlefilter(string titles, string addedcrit)
        {
            var ds = new DataSet();
            var myconstring = SlConnectionString.Makeconn;
            var mycon = new MySqlConnection { ConnectionString = myconstring };

            var myda = new MySqlDataAdapter("select * from vw_applytitlefilter " + addedcrit + " limit 500;", mycon);

            mycon.Open();
            myda.Fill(ds, "jobs");
            mycon.Close();

            return ds;
        }

        public DataSet Applygridfilter(string addedcrit)
        {
            var ds = new DataSet();

            var myconstring = SlConnectionString.Makeconn;

            var mycon = new MySqlConnection { ConnectionString = myconstring };

            var myda =
                new MySqlDataAdapter(
                    "SELECT idjobs,stitle,sshortdescription,sfreetext, sdescription,dtentereddate,ssalarytext,sminsal,employeeid, smaxsal, applicationvolume from vw_aggregatedmulti where cdefinition = '" +
                    addedcrit + "' ;", mycon);

            mycon.Open();

            myda.Fill(ds, "vw_aggregatedmulti");

            mycon.Close();

            return ds;
        }

        //get results returned by the Query
        public int Getsearchcounts(string titles, string addedcrit)
        {
            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var ct = 0;

            using (connreader)
            {
                var command = new MySqlCommand(
                    "SELECT count(idjobs)as idjobs from vw_aggregatedmulti where match(sfreetext) against('" + titles +
                    "') " + addedcrit + " ",
                    connreader);
                connreader.Open();

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ct = reader.GetInt32(0);
                    }
                }
                reader.Close();
            }

            return ct;
        }

        public DataSet Getsearchbypostcode(string titles, string postcode, string addedcrit)
        {
            var ds = new DataSet();
            var myconstring = SlConnectionString.Makeconn;
            var mycon = new MySqlConnection { ConnectionString = myconstring };

            var myda =
                new MySqlDataAdapter(
                    "select * from vw_applytitlefilter where match (sfreetext) against ('" + titles +
                    "' IN NATURAL LANGUAGE MODE ) and spostcode like '%" + postcode + "%'" + addedcrit +
                    " limit 500;", mycon);

            mycon.Open();
            myda.Fill(ds, "jobs");
            mycon.Close();

            return ds;
        }

        public DataSet Getsearchbypostcode(string postcode, string addedcrit)
        {
            var ds = new DataSet();
            var myconstring = SlConnectionString.Makeconn;
            var mycon = new MySqlConnection { ConnectionString = myconstring };

            var myda =
                new MySqlDataAdapter(
                    "select * from vw_applytitlefilter where spostcode like '%" + postcode + "%' and " + addedcrit +
                    " limit 500;", mycon);

            mycon.Open();
            myda.Fill(ds, "jobs");
            mycon.Close();

            return ds;
        }

        public DataSet Getsearchbypostcode(string postcode)
        {
            var ds = new DataSet();
            var myconstring = SlConnectionString.Makeconn;
            var mycon = new MySqlConnection { ConnectionString = myconstring };

            var myda =
                new MySqlDataAdapter(
                    "select * from vw_applytitlefilter where spostcode like '%" + postcode + "%' limit 500;", mycon);

            mycon.Open();
            myda.Fill(ds, "jobs");
            mycon.Close();

            return ds;
        }

        //get results by company
        public DataSet Getsearchbycompany(string titles, string postcode, string addedcrit, string company, string qry)
        {
            var ds = new DataSet();
            var myconstring = SlConnectionString.Makeconn;
            var mycon = new MySqlConnection { ConnectionString = myconstring };

            var myda = new MySqlDataAdapter(qry, mycon);

            mycon.Open();
            myda.Fill(ds, "jobs");
            mycon.Close();

            return ds;
        }

        //get results by date
        public DataSet Getsearchbydate(string titles, string postcode, string addedcrit, string company,
                                       string dt, string qry)
        {
            var ds = new DataSet();
            var myconstring = SlConnectionString.Makeconn;
            var mycon = new MySqlConnection { ConnectionString = myconstring };

            var myda = new MySqlDataAdapter(qry, mycon);

            mycon.Open();
            myda.Fill(ds, "jobs");
            mycon.Close();

            return ds;
        }
    }
}