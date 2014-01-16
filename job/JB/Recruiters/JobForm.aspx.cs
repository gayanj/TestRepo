using System;
using System.Collections;
using System.Globalization;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;
using Msftlayer;
using minGuid;

namespace JB.Recruiters
{
    public partial class JobForm : ClCookie
    {
        private string[] Splitdate(string _input)
        {
            char[] splitter = { '/', ' ' };
            string[] _output = _input.Split(splitter);
            return _output;
        }

        private bool datecrc(string input, int type)
        {
            var output = false;
            int innumber = 0;

            try
            {
                innumber = Convert.ToInt16(input);
            }

            catch (Exception e)
            {
                output = true;
                return output;
            }

            if (type == 1)
            {
                //days
                var today = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
                if (innumber < 0 && innumber > today)
                {
                    output = true;
                }
            }

            if (type == 2)
            {
                if (innumber < 0 && innumber > 12)
                {
                    output = true;
                }
            }

            return output;
        }

        private void Multiblock()
        {
            var mloads = new ClMemLoad();
            var alistloc = (ArrayList)mloads.Mcgetloc();

            //get locations
            for (int alisti = 0; alisti < alistloc.Count; alisti += 3)
            {
                var tn = new CheckBox { Text = alistloc[alisti + 1].ToString(), ID = alistloc[alisti].ToString() };

                switch (Convert.ToInt16(alistloc[alisti + 2]))
                {
                    case 1:
                        tn.CssClass = "usr_checkleft20";
                        break;
                    case 2:
                        tn.CssClass = "usr_checkleft30";
                        break;
                    default:
                        tn.CssClass = "usr_checkleft10";
                        break;
                }

                CheckBoxList2.Controls.Add(tn);

                var slit1 = new Literal { Text = "<br />" };

                CheckBoxList2.Controls.Add(slit1);
            }

            alistloc.Clear();
            alistloc = (ArrayList)mloads.Mcgetind();

            //get industry
            for (int alisti = 0; alisti < alistloc.Count; alisti += 3)
            {
                var tn = new CheckBox { Text = alistloc[alisti + 1].ToString(), ID = alistloc[alisti].ToString() };

                switch (Convert.ToInt16(alistloc[alisti + 2]))
                {
                    case 1:
                        tn.CssClass = "usr_checkleft20";
                        break;
                    case 2:
                        tn.CssClass = "usr_checkleft30";
                        break;
                    default:
                        tn.CssClass = "usr_checkleft10";
                        break;
                }

                CheckBoxList1.Controls.Add(tn);

                var slit1 = new Literal { Text = "<br />" };

                CheckBoxList1.Controls.Add(slit1);
            }

            alistloc.Clear();
            alistloc = (ArrayList)mloads.Mcgetpostcodes();

            //get postcodes
            for (var alisti = 0; alisti < alistloc.Count; alisti += 2)
            {
                var tn = new CheckBox
                             {
                                 Text = alistloc[alisti + 1].ToString(),
                                 ID = alistloc[alisti].ToString(),
                                 CssClass = "usr_checkleft10"
                             };
                CheckBoxList5.Controls.Add(tn);

                var slit1 = new Literal { Text = "<br />" };
                CheckBoxList5.Controls.Add(slit1);
            }

            alistloc.Clear();
            alistloc = (ArrayList)mloads.Mcgetsectors();

            //get sector
            for (int alisti = 0; alisti < alistloc.Count; alisti += 3)
            {
                var tn = new CheckBox { Text = alistloc[alisti + 1].ToString(), ID = alistloc[alisti].ToString() };

                switch (Convert.ToInt16(alistloc[alisti + 2]))
                {
                    case 1:
                        tn.CssClass = "usr_checkleft20";
                        break;
                    case 2:
                        tn.CssClass = "usr_checkleft30";
                        break;
                    default:
                        tn.CssClass = "usr_checkleft10";
                        break;
                }

                CheckBoxList4.Controls.Add(tn);
                var slit1 = new Literal { Text = "<br />" };
                CheckBoxList4.Controls.Add(slit1);
            }

            alistloc.Clear();
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            Multiblock();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //read and validate login

            Isuserloginvalid();

            //if (Session["cuserval"] != null)
            //{
            //    if (Session["cuserval"].ToString() == Readjobcookie())
            //    {
            //    }
            //    else
            //    {
            //        Response.Redirect("/Login");
            //    }
            //}

            //else
            //{
            //    Response.Redirect("/Login");
            //}

            var mp = new ClMainPagePopulator();

            if (!IsPostBack)
            {
                //get locations
                var mloads = new ClMemLoad();

                //get salary
                CheckBoxList6.DataSource = mloads.Mcgetsalary();
                CheckBoxList6.DataTextField = "sdefinition";
                CheckBoxList6.DataValueField = "subcatid";
                CheckBoxList6.DataBind();

                //get experience
                CheckBoxList8.DataSource = mloads.Mcgetexp();
                CheckBoxList8.DataTextField = "sdefinition";
                CheckBoxList8.DataValueField = "subcatid";
                CheckBoxList8.DataBind();

                //get education
                CheckBoxList9.DataSource = mloads.Mcgeteducation();
                CheckBoxList9.DataTextField = "sdefinition";
                CheckBoxList9.DataValueField = "subcatid";
                CheckBoxList9.DataBind();

                //get career level
                CheckBoxList10.DataSource = mloads.Mcgetcareer();
                CheckBoxList10.DataTextField = "sdefinition";
                CheckBoxList10.DataValueField = "subcatid";
                CheckBoxList10.DataBind();

                //

                #region update jobs

                if (Request.QueryString["jobid"] != null)
                {
                    //check if this job belongs to current rec
                    var cljjbs = new ClJobs();
                    string checkrecassignment = cljjbs.Getrecjobassignment(Request.QueryString["jobid"]);

                    if (checkrecassignment == Session["pusername"].ToString())
                    {

                        //get currency $$$
                        var ijob = new ClJobs();

                        //get dropdown currency
                        Currency.SelectedValue = ijob.Getcurrencyjobform(Server.HtmlEncode(Request.QueryString["jobid"]));

                        string editjobid = Request.QueryString["jobid"];

                        //fill in form.
                        var arrfil = mp.Filljobform(editjobid);

                        //populate job data
                        TextBox1.Text = arrfil[0];
                        TextBox2.Text = arrfil[1];

                        //var cinf = new CultureInfo("pt-BR");
                        string cult = System.Configuration.ConfigurationManager.AppSettings["localization"].ToString();
                        var cinf = new CultureInfo(cult);
                        if (Request.QueryString["jobid"] != null)
                        {
                            var ResStartDate = Splitdate(arrfil[2]);

                            StartDate1.Text = ResStartDate[1];
                            StartDate2.Text = ResStartDate[0];
                            StartDate3.Text = ResStartDate[2];

                            var ResEndDate = Splitdate(arrfil[3]);

                            EndDate1.Text = ResEndDate[1];
                            EndDate2.Text = ResEndDate[0];
                            EndDate3.Text = ResEndDate[2];

                            //TextBox3.Text = Convert.ToDateTime(arrfil[2]).ToString("d", cinf);
                            //TextBox4.Text = Convert.ToDateTime(arrfil[3]).ToString("d", cinf);
                        }
                        TextBox5.Text = arrfil[4];
                        TextBox6.Text = arrfil[5];
                        Editor.Text = arrfil[6];
                        TextBoxloc.Text = arrfil[7];

                        #region populatemultitexts

                        PopulateMultitext(Request.QueryString["jobid"]);

                        #endregion populatemultitexts
                    }

                    else
                    {
                        Response.Redirect("/recruiters/home");
                    }
                }

                #endregion update jobs
            }

            //set default inputs
            TextBox1.Focus();
            Page.Form.DefaultButton = Button1.UniqueID;
        }

        private void PopulateMultitext(string jobid)
        {
            //set constructor
            var cljbs = new ClJobs();

            //store jobid for reuse
            var sjobids = jobid;

            /*set locations*/
            var arr = cljbs.Getmutitexts(sjobids);

            //arr = arr.Where(val => val != 0).ToArray();
            //splitter for postcodes
            var sarrc = cljbs.Getpostcodesarr(sjobids);
            var sbar = new StringBuilder();

            foreach (string sitems1 in sarrc)
            {
                sbar.Append(sitems1);
            }

            var splituppostcode = sbar.ToString();
            string[] spliton = { "," };
            var tempsli = splituppostcode.Split(spliton, StringSplitOptions.RemoveEmptyEntries);
            sarrc.Clear();

            foreach (var starrc in tempsli)
            {
                if (starrc != null || starrc != "")
                {
                    foreach (Control ctrls in CheckBoxList5.Controls)
                    {
                        var cbxxa1 = ctrls as CheckBox;
                        if (cbxxa1 != null)
                        {
                            if (cbxxa1.Text == starrc)
                            {
                                cbxxa1.Checked = true;
                            }
                        }
                    }
                    //CheckBoxList5.Items.FindByText(starrc.ToString()).Selected = true;
                }
            }

            foreach (var arritem in arr)
            {
                if (arritem >= 5000 && arritem < 6000)
                {
                    foreach (Control ct in CheckBoxList1.Controls)
                    {
                        if (ct is CheckBox)
                        {
                            var cbxx = (CheckBox)ct;
                            if (cbxx.ID == arritem.ToString(CultureInfo.InvariantCulture))
                            {
                                cbxx.Checked = true;
                            }
                        }
                    }

                    //industry
                    //CheckBoxList1.Controls.(arritem.ToString()).Selected = true;
                }

                if (arritem >= 4000 && arritem < 5000)
                {
                    foreach (Control ct1 in CheckBoxList2.Controls)
                    {
                        if (ct1 is CheckBox)
                        {
                            var cbxx1 = (CheckBox)ct1;
                            if (cbxx1.ID == arritem.ToString(CultureInfo.InvariantCulture))
                            {
                                cbxx1.Checked = true;
                            }
                        }
                    }

                    //location
                    //CheckBoxList2.Items.FindByValue(arritem.ToString()).Selected = true;
                }

                if (arritem >= 3000 && arritem <= 3002)
                {
                    //contract
                    CheckBoxList3.Items.FindByValue(arritem.ToString(CultureInfo.InvariantCulture)).Selected = true;
                }

                if (arritem >= 6000 && arritem < 7000)
                {
                    //salary
                    CheckBoxList6.Items.FindByValue(arritem.ToString(CultureInfo.InvariantCulture)).Selected = true;
                }

                if (arritem >= 3003 && arritem <= 3004)
                {
                    //hours
                    CheckBoxList7.Items.FindByValue(arritem.ToString(CultureInfo.InvariantCulture)).Selected = true;
                }

                if (arritem >= 7000 && arritem <= 7001)
                {
                    //employement type
                    CheckBoxList8.Items.FindByValue(arritem.ToString(CultureInfo.InvariantCulture)).Selected = true;
                }

                if (arritem >= 9000 && arritem <= 10000)
                {
                    foreach (Control ct1 in CheckBoxList4.Controls)
                    {
                        if (ct1 is CheckBox)
                        {
                            var cbxx1 = (CheckBox)ct1;
                            if (cbxx1.ID == arritem.ToString(CultureInfo.InvariantCulture))
                            {
                                cbxx1.Checked = true;
                            }
                        }
                    }

                    //location
                    //CheckBoxList2.Items.FindByValue(arritem.ToString()).Selected = true;
                }

                if (arritem >= 14000 && arritem < 15000)
                {
                    //education
                    CheckBoxList9.Items.FindByValue(arritem.ToString(CultureInfo.InvariantCulture)).Selected = true;
                }

                if (arritem >= 15000 && arritem < 16000)
                {
                    //career level
                    CheckBoxList10.Items.FindByValue(arritem.ToString(CultureInfo.InvariantCulture)).Selected = true;
                }
            }
        }

        protected void Button1Click(object sender, EventArgs e)
        {
            var clonrec = new ClRecruiters();
            //set culture to british
            //modify here in future if this needs to be set to us formats

            //var cinf = new CultureInfo("en-GB");
            string cult = System.Configuration.ConfigurationManager.AppSettings["localization"].ToString();
            var cinf = new CultureInfo(cult);
            var sdate = StartDate3.Text + "-" + StartDate2.Text + "-" + StartDate1.Text;
            var edate = EndDate3.Text + "-" + EndDate2.Text + "-" + EndDate1.Text;

            //add video
            var videoset = false;
            var _tempshortdess = string.Empty;

            _tempshortdess = Server.HtmlEncode(TextBox2.Text);
            string strcurr = Currency.SelectedValue;

            if (Request.QueryString["jobid"] != null)
            {
                #region updatejobs

                var mpage = new ClMainPagePopulator();
                string recid = mpage.Getrecname(Session["pusername"].ToString());
                string mxjobsid = Request.QueryString["jobid"];

                //get postcodes
                var spostcode = new StringBuilder();
                foreach (Control listpostcode in CheckBoxList5.Controls)
                {
                    if (listpostcode is CheckBox)
                    {
                        var cbnx = (CheckBox)listpostcode;
                        if (cbnx.Checked == true)
                        {
                            spostcode.Append(cbnx.Text + ",");
                        }
                    }
                    //if (_listpostcode.Selected == true)
                    //{
                    //    //insert categories
                    //    __spostcode.Append(_listpostcode.Text + ",");
                    //}
                }

                string rcnames = clonrec.Getcompanybyrec(recid);

                //update job
                mpage.Updatejobs(mxjobsid, Server.HtmlEncode(TextBox1.Text), _tempshortdess, Editor.Text, Server.HtmlEncode(TextBox5.Text), 0, 0, Server.HtmlEncode(TextBox6.Text), sdate, edate, spostcode.ToString(), Server.HtmlEncode(TextBoxloc.Text), rcnames, strcurr);
                mpage.Deletejobs(mxjobsid);

                //insert sectors
                foreach (Control listite1 in CheckBoxList4.Controls)
                {
                    if (listite1 is CheckBox)
                    {
                        var cbox = (CheckBox)listite1;
                        if (cbox.Checked == true)
                        {
                            //insert
                            mpage.Insertjobmapping(mxjobsid, 1006, Convert.ToInt16(cbox.ID), recid);
                        }
                    }
                }

                //insert location
                foreach (Control listite1 in CheckBoxList2.Controls)
                {
                    if (listite1 is CheckBox)
                    {
                        var cbox = (CheckBox)listite1;
                        if (cbox.Checked == true)
                        {
                            //insert
                            mpage.Insertjobmapping(mxjobsid, 1000, Convert.ToInt16(cbox.ID), recid);
                        }
                    }
                }

                //category
                foreach (Control listite23 in CheckBoxList1.Controls)
                {
                    if (listite23 is CheckBox)
                    {
                        var cbox23 = (CheckBox)listite23;
                        if (cbox23.Checked == true)
                        {
                            //insert
                            mpage.Insertjobmapping(mxjobsid, 1001, Convert.ToInt16(cbox23.ID), recid);
                        }
                    }
                }

                //insert contract ok
                foreach (ListItem listitems2 in CheckBoxList3.Items)
                {
                    if (listitems2.Selected == true)
                    {
                        //insert cats
                        mpage.Insertjobmapping(mxjobsid, 1002, Convert.ToInt16(listitems2.Value), recid);
                    }
                }

                //insert hours ok
                foreach (ListItem listitems4 in CheckBoxList7.Items)
                {
                    if (listitems4.Selected == true)
                    {
                        mpage.Insertjobmapping(mxjobsid, 1003, Convert.ToInt16(listitems4.Value), recid);
                    }
                }

                //experience ok
                foreach (ListItem listitems5 in CheckBoxList8.Items)
                {
                    if (listitems5.Selected == true)
                    {
                        mpage.Insertjobmapping(mxjobsid, 1004, Convert.ToInt16(listitems5.Value), recid);
                    }
                }

                //insert salary ok
                foreach (ListItem listitems6 in CheckBoxList6.Items)
                {
                    if (listitems6.Selected == true)
                    {
                        mpage.Insertjobmapping(mxjobsid, 1005, Convert.ToInt16(listitems6.Value), recid);
                    }
                }

                //education ok
                foreach (ListItem education in CheckBoxList9.Items)
                {
                    if (education.Selected == true)
                    {
                        mpage.Insertjobmapping(mxjobsid, 1008, Convert.ToInt16(education.Value), recid);
                    }
                }

                //career level ok
                foreach (ListItem careerlevel in CheckBoxList10.Items)
                {
                    if (careerlevel.Selected == true)
                    {
                        mpage.Insertjobmapping(mxjobsid, 1007, Convert.ToInt16(careerlevel.Value), recid);
                    }
                }

                //end update

                #endregion updatejobs

                //Cldebug cld = new Cldebug();
                //cld.insertdebuggcode("update:::" + recid.ToString(), "jobform");
                //cld.insertdebuggcode("update:::" + mxjobsid.ToString(), "jobform");

                Session["reasons"] = "Job Updated Sucessfully!";
                Session["ir"] = "1";
                Response.Redirect("/recruiters/jobvideos.aspx?jobid=" + Server.HtmlEncode(Request.QueryString["jobid"]));
            }

            else
            {
                #region addjobs

                //add jobs
                var mpage = new ClMainPagePopulator();
                string recid = mpage.Getrecname(Session["pusername"].ToString());
                var mgui = new Minimumguid();
                string mxjobsid = mgui.MinGuid();

                //get postcodes
                var spostcode = new StringBuilder();
                foreach (Control listpostcode in CheckBoxList5.Controls)
                {
                    if (listpostcode is CheckBox)
                    {
                        var cbnxar = (CheckBox)listpostcode;
                        if (cbnxar.Checked == true)
                        {
                            //insert categories
                            spostcode.Append(cbnxar.Text + " ");
                        }
                    }
                }

                //get recruiter name
                var recnames = clonrec.Getcompanybyrec(recid);

                //insert job
                mpage.Insertjobs(mxjobsid, Server.HtmlEncode(TextBox1.Text), _tempshortdess, Editor.Text, Server.HtmlEncode(TextBox5.Text), 0, 0, Server.HtmlEncode(TextBox6.Text), sdate, edate, videoset, spostcode.ToString(), Server.HtmlEncode(TextBoxloc.Text), recnames, strcurr);

                //insert default job
                mpage.Insertjobmapping(mxjobsid, 10000, 10000, recid);

                //StringBuilder debugme = new StringBuilder();

                //insert sectors
                foreach (Control listite1 in CheckBoxList4.Controls)
                {
                    var cbox = listite1 as CheckBox;
                    if (cbox != null)
                    {
                        if (cbox.Checked == true)
                        {
                            //insert
                            mpage.Insertjobmapping(mxjobsid, 1006, Convert.ToInt16(cbox.ID), recid);
                            //debugme.Append(mxjobsid + "1006"+ Convert.ToInt16(cbox.ID)+ recid + "--");
                        }
                    }
                }

                //insert location
                foreach (Control listite1 in CheckBoxList2.Controls)
                {
                    if (listite1 is CheckBox)
                    {
                        var cbox = (CheckBox)listite1;
                        if (cbox.Checked == true)
                        {
                            //insert
                            mpage.Insertjobmapping(mxjobsid, 1000, Convert.ToInt16(cbox.ID), recid);
                            //debugme.Append(mxjobsid + "1000" + Convert.ToInt16(cbox.ID) + recid + "--");
                        }
                    }
                }

                //category
                foreach (Control listite23 in CheckBoxList1.Controls)
                {
                    if (listite23 is CheckBox)
                    {
                        var cbox23 = (CheckBox)listite23;
                        if (cbox23.Checked == true)
                        {
                            //insert
                            mpage.Insertjobmapping(mxjobsid, 1001, Convert.ToInt16(cbox23.ID), recid);
                            //debugme.Append(mxjobsid + "1001" + Convert.ToInt16(cbox23.ID) + recid + "--");
                        }
                    }
                }

                //insert contract ok
                foreach (ListItem listitems2 in CheckBoxList3.Items)
                {
                    if (listitems2.Selected == true)
                    {
                        //insert cats
                        mpage.Insertjobmapping(mxjobsid, 1002, Convert.ToInt16(listitems2.Value), recid);
                        //debugme.Append(mxjobsid + "1002" + Convert.ToInt16(listitems2.Value) + recid + "--");
                    }
                }

                //insert hours ok
                foreach (ListItem listitems4 in CheckBoxList7.Items)
                {
                    if (listitems4.Selected == true)
                    {
                        mpage.Insertjobmapping(mxjobsid, 1003, Convert.ToInt16(listitems4.Value), recid);
                        //debugme.Append(mxjobsid + "1003" + Convert.ToInt16(listitems4.Value) + recid + "--");
                    }
                }

                //experience ok
                foreach (ListItem listitems5 in CheckBoxList8.Items)
                {
                    if (listitems5.Selected == true)
                    {
                        mpage.Insertjobmapping(mxjobsid, 1004, Convert.ToInt16(listitems5.Value), recid);
                        //debugme.Append(mxjobsid + "1004" + Convert.ToInt16(listitems5.Value) + recid + "--");
                    }
                }

                //insert salary ok
                foreach (ListItem listitems6 in CheckBoxList6.Items)
                {
                    if (listitems6.Selected == true)
                    {
                        mpage.Insertjobmapping(mxjobsid, 1005, Convert.ToInt16(listitems6.Value), recid);
                        //debugme.Append(mxjobsid + "1005" + Convert.ToInt16(listitems6.Value) + recid + "--");
                    }
                }

                //education ok
                foreach (ListItem education in CheckBoxList9.Items)
                {
                    if (education.Selected == true)
                    {
                        mpage.Insertjobmapping(mxjobsid, 1008, Convert.ToInt16(education.Value), recid);
                        //debugme.Append(mxjobsid + "1008" + Convert.ToInt16(__education.Value) + recid + "--");
                    }
                }

                //career level ok
                foreach (ListItem careerlevel in CheckBoxList10.Items)
                {
                    if (careerlevel.Selected == true)
                    {
                        mpage.Insertjobmapping(mxjobsid, 1007, Convert.ToInt16(careerlevel.Value), recid);
                        //debugme.Append(mxjobsid + "1007" + Convert.ToInt16(_careerlevel.Value) + recid + "--");
                    }
                }

                #endregion addjobs

                Session["reasons"] = "Job Added Sucessfully!";
                Session["ir"] = "1";
                Response.Redirect("/recruiters/jobvideos.aspx?jobid=" + mxjobsid);
            }
        }

        protected void Bclicked(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                Button btn = (Button)sender;
                PopulateMultitext(btn.ID);
                Suggestionpanel.Controls.Clear();
            }
        }

        protected void Button2Click(object sender, EventArgs e)
        {
            //get suggestions
            var clj = new ClJobs();
            var al1 = clj.Getjobidbyname(Server.HtmlEncode(TextBox1.Text));

            for (var i = 0; i < al1.Count; i += 2)
            {
                var b = new Button { ID = al1[i].ToString() };
                if (al1[i + 1].ToString().Length > 20) { b.Text = al1[i + 1].ToString().Substring(0, 20) + "..."; }
                else
                {
                    b.Text = al1[i + 1].ToString();
                }
                b.Click += new EventHandler(Bclicked);
                b.CssClass = "button";
                b.CausesValidation = false;

                Suggestionpanel.Controls.Add(b);
            }
        }
    }
}