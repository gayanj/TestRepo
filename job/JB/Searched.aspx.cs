using System;
using System.Collections;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Msftlayer;
using Msftlayer.IpLookup;
using System.Text.RegularExpressions;

namespace JB
{
    public partial class Searched : ClPager
    {
        // <summary>
        // this page stays as it is! don't touch!
        // </summary>

        private void DoSearch(int __ispaged)
        {
            var cpfilt = new ClSearchFilters();

            //paging
            int lowlimit = 0;
            int pagesize = 10;

            pagesize = _PageSize();

            if (Request.QueryString["page"] != null)
            {
                lowlimit = (Convert.ToInt16(Request.QueryString["page"]) - 1);
                if (lowlimit != 0)
                {
                    lowlimit = lowlimit * pagesize;
                }
            }

            //get pager 
            //int lowlimit = 0;
            //int pagesize = 10;

            //if (__ispaged == 1)
            //{
            //    var _currcount = JobsList.Rows.Count;
            //    pagesize = 10 + _currcount;
            //}

            var _count = cpfilt.GetAllWapJobs();

            var __list = 0;

            string _url = MakeQuery();

            if (Request.QueryString["list"] != null)
            {
                __list = Convert.ToInt16(Request.QueryString["list"]);
            }

            switch (Request.QueryString["lev"])
            {
                case "1":
                    {
                        var _qry = Server.HtmlEncode(Request.QueryString["qry"]);
                        var __items = Convert.ToInt32(Server.HtmlEncode(Request.QueryString["item"]));
                        BrowsingList.DataSource = cpfilt.CategoryBrowser(__items, 0, _qry, __list);
                        BrowsingList.DataBind();

                        JobsList.DataSource = cpfilt.WapLevelCat(__items, lowlimit, pagesize);
                        JobsList.DataBind();
                        int _tempcount = cpfilt.WapLevelCat(__items);
                        CustomPaging.Text = CreatePageLinks(_tempcount, pagesize, _url);

                        /*if (_tempcount == JobsList.Rows.Count)
                        {
                            PageMore.Visible = false;
                        }

                        else { PageMore.Visible = true; }
                         */
                    }
                    break;
                case "2":
                    {
                        var _qry = Server.HtmlEncode(Request.QueryString["qry"]);
                        var __items = Convert.ToInt32(Server.HtmlEncode(Request.QueryString["item"]));
                        BrowsingList.DataSource = cpfilt.CategoryBrowser(__items, 1, _qry, __list);
                        BrowsingList.DataBind();

                        var _lev = Convert.ToInt16(Request.QueryString["lev"]);


                        JobsList.DataSource = cpfilt.WapLevelItems(__list, _lev, lowlimit, pagesize);
                        JobsList.DataBind();
                        int _tempcount = cpfilt.WapLevelItems(__list, _lev);
                        CustomPaging.Text = CreatePageLinks(_tempcount, pagesize, _url);


                        //if (_tempcount == JobsList.Rows.Count)
                        //{
                        //    PageMore.Visible = false;
                        //}

                        //else { PageMore.Visible = true; }
                    }
                    break;
                case "3":
                    {
                        var _qry = Server.HtmlEncode(Request.QueryString["qry"]);
                        var __items = Convert.ToInt32(Server.HtmlEncode(Request.QueryString["item"]));
                        BrowsingList.DataSource = cpfilt.CategoryBrowser(__items, 2, _qry, __list);
                        BrowsingList.DataBind();

                        var _lev = Convert.ToInt16(Request.QueryString["lev"]);

                        JobsList.DataSource = cpfilt.WapLevelItems(__list, _lev, lowlimit, pagesize);
                        JobsList.DataBind();
                        int _tempcount = cpfilt.WapLevelItems(__list, _lev);
                        CustomPaging.Text = CreatePageLinks(_tempcount, pagesize, _url);


                        //if (_tempcount == JobsList.Rows.Count)
                        //{
                        //    PageMore.Visible = false;
                        //}

                        //else { PageMore.Visible = true; }
                    }
                    break;
                case "4":
                    {
                        var _qry = Server.HtmlEncode(Request.QueryString["qry"]);
                        var __items = Convert.ToInt32(Server.HtmlEncode(Request.QueryString["item"]));
                        BrowsingList.DataSource = cpfilt.CategoryBrowser(__items, 3, _qry, __list);
                        BrowsingList.DataBind();

                        var _lev = Convert.ToInt16(Request.QueryString["lev"]);

                        JobsList.DataSource = cpfilt.WapLevelItems(__list, _lev, lowlimit, pagesize);
                        JobsList.DataBind();
                        int _tempcount = cpfilt.WapLevelItems(__list, _lev);
                        CustomPaging.Text = CreatePageLinks(_tempcount, pagesize, _url);

                        //if (_tempcount == JobsList.Rows.Count)
                        //{
                        //    PageMore.Visible = false;
                        //}

                        //else { PageMore.Visible = true; }
                    }
                    break;
                default:
                    BrowsingList.DataSource = cpfilt.Getdefaultbrall();
                    BrowsingList.DataBind();
                    JobsList.DataSource = cpfilt.GetAllWapJobs(lowlimit, pagesize);
                    JobsList.DataBind();
                    int _maxrows = cpfilt.GetAllWapJobs();
                    CustomPaging.Text = CreatePageLinks(_maxrows, pagesize, _url);

                    //if (_maxrows == JobsList.Rows.Count)
                    //{
                    //    PageMore.Visible = false;
                    //}
                    //else { PageMore.Visible = true; }
                    break;
            }
        }

        private void SetPageItems()
        {
            if (Request.QueryString["q"] != null)
            {
                if (Request.QueryString["q"] != "ALL")
                {
                    TextBox2.Text = Request.QueryString["q"];
                }
            }

            if (Request.QueryString["i"] != null)
            {
                CheckBoxInternet.Checked = true;
            }

            if (Request.QueryString["area"] != null)
            {
                TextBox1.Text = Request.QueryString["area"];
            }

            if (Request.QueryString["c"] != null)
            {
                TextBoxCompany.Text = Request.QueryString["c"];
            }

            if (Request.QueryString["d"] != null)
            {
                DropDowndate.SelectedValue = Request.QueryString["d"];
            }

            if (Request.QueryString["m"] != null)
            {
                DropDownListmiles.SelectedValue = Request.QueryString["m"];
            }

            if (Request.QueryString["v"] != null)
            {
                CheckBoxVideo.Checked = true;
            }

            // currency region
            #region currency
            if (Request.QueryString["curr"] != null)
            {
                Currency.SelectedValue = Request.QueryString["curr"];
            }

            #endregion


        }

        private void SetCheckboxOnLoad(ArrayList _al)
        {
            foreach (string s in _al)
            {
                foreach (var cbx3 in CheckBoxList1.Controls.OfType<CheckBox>().Where(cbx3 => cbx3.ID == s))
                {
                    cbx3.Checked = true;
                }

                foreach (var cbx3 in CheckBoxList2.Controls.OfType<CheckBox>().Where(cbx3 => cbx3.ID == s))
                {
                    cbx3.Checked = true;
                }

                foreach (var cbx3 in CheckBoxList3.Items.OfType<ListItem>().Where(cbx3 => cbx3.Value == s))
                {
                    cbx3.Selected = true;
                }

                foreach (var cbx3 in CheckBoxList4.Items.OfType<ListItem>().Where(cbx3 => cbx3.Value == s))
                {
                    cbx3.Selected = true;
                }

                foreach (var cbx3 in CheckBoxList5.Items.OfType<ListItem>().Where(cbx3 => cbx3.Value == s))
                {
                    cbx3.Selected = true;
                }

                foreach (var cbx3 in CheckBoxList6.Items.OfType<ListItem>().Where(cbx3 => cbx3.Value == s))
                {
                    cbx3.Selected = true;
                }

                foreach (var cbx3 in CheckBoxList7.Controls.OfType<CheckBox>().Where(cbx3 => cbx3.ID == s))
                {
                    cbx3.Checked = true;
                }

                foreach (var cbx3 in CheckBoxList8.Items.OfType<ListItem>().Where(cbx3 => cbx3.Value == s))
                {
                    cbx3.Selected = true;
                }

                foreach (var cbx3 in CheckBoxList9.Items.OfType<ListItem>().Where(cbx3 => cbx3.Value == s))
                {
                    cbx3.Selected = true;
                }
            }
        }

        protected void Page_PreRenderComplete(object sender, EventArgs e)
        {
            #region sponsradd

            var cadds = new ClAdverts();
            var arlist = cadds.Getjobtextadverts();

            if (arlist != null)
            {
                sponsrhlink1.Text = arlist[1].ToString();
                sponsrhlink1.NavigateUrl = "/jobdetails?jobid=" + arlist[0] + "&jobtitle=" +
                                           arlist[1].ToString().ToLower();
                sponsrdesc.Text = arlist[2].ToString();
                sponsrhlink2.NavigateUrl = "/jobdetails?jobid=" + arlist[0] + "&jobtitle=" +
                                           arlist[1].ToString().ToLower();
                arlist.Clear();
            }

            #endregion sponsradd

            //featured Recruiters
            var frec = new ClFeaturedRecruiters();
            SponsoredLists.DataSource = frec.GetFRecs();
            SponsoredLists.DataBind();

            ClMainPagePopulator mp = new ClMainPagePopulator();

            //totals
            Label13.Text = mp.Getcountjobs() + " jobs online...";

            //setpageitems
            SetPageItems();


            if (Session["cbxid"] != null)
            {
                SetCheckboxOnLoad((ArrayList)Session["cbxid"]);
            }
        }

        protected string GetUrl(object idjob, object titles)
        {
            var urls = string.Empty;

            if (Request.QueryString["sign"] != null)
            {
                switch (Request.QueryString["sign"])
                {
                    case "1":
                        urls =
                            "/jobdetails?jobid=" +
                            idjob + "&jobtitle=" + titles.ToString().Replace(" ", "-").Replace("--", "-").ToLower() +
                            "&sign=" + Request.QueryString["sign"].ToString(CultureInfo.InvariantCulture);
                        return urls;
                    default:
                        urls =
                            "/jobdetails?jobid=" +
                            idjob + "&jobtitle=" + titles.ToString().Replace(" ", "-").Replace("--", "-").ToLower();
                        return urls;
                }
            }

            else
            {
                urls = "/jobdetails?jobid=" + idjob +
                       "&jobtitle=" + titles.ToString().Replace(" ", "-").Replace("--", "-").ToLower();
                return urls;
            }
        }

        private string OneEyeSearch(string city)
        {
            var sb = new StringBuilder();

            if (Request.QueryString["q"] != null)
            {
                if (Request.QueryString["q"] != "ALL")
                {
                    sb.Append(" and match(sfreetext) against ('" + Server.HtmlEncode(Request.QueryString["q"]) +
                              "'  IN NATURAL LANGUAGE MODE) ");
                }
            }

            if (Request.QueryString["i"] != null)
            {
                sb.Append(" and slocation = '" + city + "' ");
            }

            if (Request.QueryString["area"] != null)
            {
                sb.Append(" and spostcode like '%" + Server.HtmlEncode(Request.QueryString["area"]) + "%' ");
            }

            if (Request.QueryString["c"] != null)
            {
                sb.Append(" and srecruitername like '%" + Server.HtmlEncode(Request.QueryString["c"]) + "%' ");
            }

            if (Request.QueryString["d"] != null)
            {
                if (Request.QueryString["d"] == "12000")
                {
                    //nothing
                }
            }

            if (Request.QueryString["d"] != null)
            {
                if (Request.QueryString["d"] == "12001")
                {
                    sb.Append(" and dtentereddate = curdate()");
                }

                else if (Request.QueryString["d"] == "12002")
                {
                    sb.Append(" and dtentereddate >= DATE_SUB( curdate(), INTERVAL 1 DAY)");
                }

                else if (Request.QueryString["d"] == "12003")
                {
                    sb.Append(" and dtentereddate >= DATE_SUB( curdate(), INTERVAL 3 DAY)");
                }

                else if (Request.QueryString["d"] == "12004")
                {
                    sb.Append(" and dtentereddate >= DATE_SUB( curdate(), INTERVAL 7 DAY)");
                }

                else if (Request.QueryString["d"] == "12005")
                {
                    sb.Append(" and dtentereddate >= DATE_SUB( curdate(), INTERVAL 30 DAY)");
                }

                else { }
            }

            if (Request.QueryString["m"] != null)
            {
                if (Request.QueryString["m"] != "0")
                {
                    if (Request.QueryString["m"] == "10")
                    {
                        sb.Append(" and smiles > 0 and smiles < 10");
                    }

                    else if (Request.QueryString["m"] == "20")
                    {
                        sb.Append(" and smiles > 0 and smiles < 20");
                    }

                    else if (Request.QueryString["m"] == "30")
                    {
                        sb.Append(" and smiles > 0 and smiles < 30");
                    }

                    else if (Request.QueryString["m"] == "40")
                    {
                        sb.Append(" and smiles > 0 and smiles < 40");
                    }

                    else
                    {
                        sb.Append(" and smiles > 0 and smiles < 50");
                    }
                }
            }

            if (Request.QueryString["v"] != null)
            {
                sb.Append(" and sisvideoenabled = 1 ");
            }

            // currency region

            #region currency
            if (Request.QueryString["curr"] != null)
            {
                if (Request.QueryString["curr"] == "16001")
                {
                    //this is dollar
                    sb.Append(" and currency = 'USD' ");
                }

                else if (Request.QueryString["curr"] == "16002")
                {
                    //this is dollar
                    sb.Append(" and currency = 'GBP' ");
                }

                else if (Request.QueryString["curr"] == "16003")
                {
                    //this is dollar
                    sb.Append(" and currency = 'EUR' ");
                }

                else if (Request.QueryString["curr"] == "16004")
                {
                    //this is dollar
                    sb.Append(" and currency = 'CHF' ");
                }

                else
                {
                }
            }

            #endregion

            return sb.ToString();
        }

        private string OneEyeCriteria()
        {
            var sb = new StringBuilder();

            if (TextBox1.Text != "")
            {
                sb.Append("&area=" + Server.HtmlEncode(TextBox1.Text.Trim()));
            }

            if (TextBox2.Text != "")
            {
                sb.Append("&q=" + Server.HtmlEncode(TextBox2.Text.Trim()));
            }

            if (TextBox2.Text == "")
            {
                sb.Append("&q=ALL");
            }

            if (CheckBoxInternet.Checked == true)
            {
                sb.Append("&i=" + _GetCities());
            }

            if (TextBoxCompany.Text != "")
            {
                sb.Append("&c=" + TextBoxCompany.Text.Trim());
            }

            if (DropDowndate.SelectedValue == "12000")
            {
                sb.Append("&d=12000");
            }

            if (DropDowndate.SelectedValue == "12001")
            {
                sb.Append("&d=12001");
            }

            if (DropDowndate.SelectedValue == "12002")
            {
                sb.Append("&d=12002");
            }

            if (DropDowndate.SelectedValue == "12003")
            {
                sb.Append("&d=12003");
            }

            if (DropDowndate.SelectedValue == "12004")
            {
                sb.Append("&d=12004");
            }

            if (DropDowndate.SelectedValue == "12005")
            {
                sb.Append("&d=12005");
            }

            if (DropDownListmiles.SelectedValue != "0")
            {
                if (DropDownListmiles.SelectedValue == "10")
                {
                    sb.Append("&m=10");
                }

                else if (DropDownListmiles.SelectedValue == "20")
                {
                    sb.Append("&m=20");
                }

                else if (DropDownListmiles.SelectedValue == "30")
                {
                    sb.Append("&m=30");
                }

                else if (DropDownListmiles.SelectedValue == "40")
                {
                    sb.Append("&m=40");
                }

                else
                {
                    sb.Append("&m=50");
                }
            }

            if (CheckBoxVideo.Checked)
            {
                sb.Append("&v=1");
            }

            // currency region

            #region currency
            if (Currency.SelectedValue == "16001")
            {
                //this is dollar
                sb.Append("&curr=USD");
            }

            else if (Currency.SelectedValue == "16002")
            {
                //this is pound
                sb.Append("&curr=GBP");
            }

            else if (Currency.SelectedValue == "16003")
            {
                //this is euro
                sb.Append("&curr=EUR");
            }

            else if (Currency.SelectedValue == "16004")
            {
                //this is euro
                sb.Append("&curr=CHF");
            }

            else
            {
                //this is swiss
                // sb.Append("&curr=CHF");
            }

            #endregion

            return sb.ToString();
        }

        private void GenDynamiclItem(string selectiontype, string labelid, string labelvalue)
        {
            //create a panel to add style
            Panelsrdynas.CssClass = "scroll-pane";
            var nli = new Literal { Text = "<div class=\"dvvlistpop\">" };

            Panelsrdynas.Controls.Add(nli);

            var lb = new Label { Text = labelid, ID = "dylb" + labelvalue, CssClass = "ft_silver" };
            var bt = new ImageButton { ImageUrl = "/images/img_dynamicfade.gif", ID = "dybt" + labelvalue, CausesValidation = false };
            bt.Click += DynamicButtonClick;

            //define string litral
            var lit = new Literal { Text = "<br />", ID = "dylit" + labelvalue };

            Panelsrdynas.Controls.Add(bt);
            Panelsrdynas.Controls.Add(lb);
            Panelsrdynas.Controls.Add(lit);

            var nliclose = new Literal { Text = "</div>" };
            Panelsrdynas.Controls.Add(nliclose);
        }

        //remove controls
        private void RemoveControl(string ctrlid)
        {
            //as we are using both custom populated checkboxes ctrls and microsoft populated chekboxctrls so
            //the below will have checked properties and selected properties
            foreach (var cbx3 in CheckBoxList7.Controls.OfType<CheckBox>().Where(cbx3 => cbx3.ID == ctrlid))
            {
                //search
                cbx3.Checked = false;
            }

            //check salaries
            foreach (var listsal in CheckBoxList6.Items.Cast<ListItem>().Where(listsal => listsal.Value == ctrlid))
            {
                listsal.Selected = false;
            }

            //check location
            foreach (var cb3 in CheckBoxList2.Controls.OfType<CheckBox>().Where(cb3 => cb3.ID == ctrlid))
            {
                //search
                cb3.Checked = false;
            }

            //industry
            foreach (var cb4 in CheckBoxList1.Controls.OfType<CheckBox>().Where(cb4 => cb4.ID == ctrlid))
            {
                //search
                cb4.Checked = false;
            }

            //insert contract
            foreach (var listit3 in CheckBoxList3.Items.Cast<ListItem>().Where(listit3 => listit3.Value == ctrlid))
            {
                //search
                listit3.Selected = false;
            }

            //add hours
            foreach (var listit4 in CheckBoxList4.Items.Cast<ListItem>().Where(listit4 => listit4.Value == ctrlid))
            {
                //search
                listit4.Selected = false;
            }

            //add employer type
            foreach (var listit5 in CheckBoxList5.Items.Cast<ListItem>().Where(listit5 => listit5.Value == ctrlid))
            {
                //search
                listit5.Selected = false;
            }

            //add education
            foreach (
                var lieducation in
                    CheckBoxList8.Items.Cast<ListItem>().Where(lieducation => lieducation.Value == ctrlid))
            {
                //search
                lieducation.Selected = false;
            }

            //add employer type
            foreach (
                var licareer in CheckBoxList9.Items.Cast<ListItem>().Where(licareer => licareer.Value == ctrlid))
            {
                //search
                licareer.Selected = false;
            }

            if (Panelsrdynas.Controls.Count == 3)
            {
                Panelsrdynas.Visible = false;
            }
        }

        //add event for dynabuttonlist
        protected void DynamicButtonClick(object sender, EventArgs e)
        {
            var buttonrem = (ImageButton)sender;
            var valuetorem = buttonrem.ID.ToString(CultureInfo.InvariantCulture).Replace("dybt", "");
            var lb = (Label)Panelsrdynas.FindControl("dylb" + valuetorem);
            var li = (Literal)Panelsrdynas.FindControl("dylit" + valuetorem);

            Panelsrdynas.Controls.Remove(buttonrem);
            Panelsrdynas.Controls.Remove(lb);
            Panelsrdynas.Controls.Remove(li);

            RemoveControl(valuetorem);

            switch (Panelsrdynas.Controls.Count)
            {
                case 0:
                    Panelsrdynas.CssClass = "";
                    break;
            }

            OneEyeControl(0);
        }

        //dynamic control populator
        private void DynamicPopulator()
        {
            #region dynapopulator

            //you may not want to use the linq expressions as they have an overhead on perfromance.
            //set dyna populate
            //check salaries
            foreach (var listsal in CheckBoxList6.Items.Cast<ListItem>().Where(listsal => listsal.Selected))
            {
                GenDynamiclItem("Salary", listsal.Text, listsal.Value);
            }

            //check location
            foreach (var cb5 in CheckBoxList2.Controls.OfType<CheckBox>().Where(cb5 => cb5.Checked))
            {
                //search
                GenDynamiclItem("Location", cb5.Text, cb5.ID);
            }

            //industry
            foreach (var cb6 in CheckBoxList1.Controls.OfType<CheckBox>().Where(cb6 => cb6.Checked))
            {
                //search
                GenDynamiclItem("Industry", cb6.Text, cb6.ID);
            }

            //insert contract
            foreach (var listit3 in CheckBoxList3.Items.Cast<ListItem>().Where(listit3 => listit3.Selected))
            {
                //search
                GenDynamiclItem("Contract", listit3.Text, listit3.Value);
            }

            //add hours
            foreach (var listit4 in CheckBoxList4.Items.Cast<ListItem>().Where(listit4 => listit4.Selected))
            {
                //search
                GenDynamiclItem("Hours", listit4.Text, listit4.Value);
            }

            //add employer type
            foreach (var listit5 in CheckBoxList5.Items.Cast<ListItem>().Where(listit5 => listit5.Selected))
            {
                //search
                GenDynamiclItem("Experience", listit5.Text, listit5.Value);
            }

            foreach (var cbx6 in CheckBoxList7.Controls.OfType<CheckBox>().Where(cbx6 => cbx6.Checked))
            {
                //search
                GenDynamiclItem("Sectors", cbx6.Text, cbx6.ID);
            }

            //education level
            foreach (
                var lieducation in CheckBoxList8.Items.Cast<ListItem>().Where(lieducation => lieducation.Selected))
            {
                //search
                GenDynamiclItem("Education", lieducation.Text, lieducation.Value);
            }

            //career level
            foreach (var licareer in CheckBoxList9.Items.Cast<ListItem>().Where(licareer => licareer.Selected))
            {
                //search
                GenDynamiclItem("career", licareer.Text, licareer.Value);
            }

            #endregion dynapopulator
        }

        //showhide job carts()
        /*
        private void Cartprocess()
        {
            #region jobcartsearched

            //proess show hide job cart
            var jobcart = ReadCookies("fq_jobcart");
            if (jobcart != null)
            {
                string[] splitonchar = { "," };
                var jobcartsplitter = jobcart.Split(splitonchar, StringSplitOptions.None);
                ViewState["fq_cookiesplit"] = jobcartsplitter;
            }

            //set default inputs
            TextBox2.Focus();
            Page.Form.DefaultButton = Button1.UniqueID;

            //clear panel
            //Panelsrdynas.Attributes.Clear();

            #endregion jobcartsearched
        }
         */

        //this selects checkboxes
        private void Multiblock()
        {
            var mloads = new ClMemLoad();
            //get locations
            var alistloc = (ArrayList)mloads.Mcgetloc();

            for (var alisti = 0; alisti < alistloc.Count; alisti += 3)
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
            for (var alisti = 0; alisti < alistloc.Count; alisti += 3)
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
            alistloc = (ArrayList)mloads.Mcgetsectors();

            //get industry
            for (var alisti = 0; alisti < alistloc.Count; alisti += 3)
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

                CheckBoxList7.Controls.Add(tn);
                var slit1 = new Literal { Text = "<br />" };
                CheckBoxList7.Controls.Add(slit1);
            }



            alistloc.Clear();


            //var cpfilt = new Clsearchfilters();
            //var mloads = new ClMemLoad();

            #region checkboxpop



            //get salaries
            CheckBoxList6.DataSource = mloads.Mcgetsalary();
            CheckBoxList6.DataTextField = "sdefinition";
            CheckBoxList6.DataValueField = "subcatid";
            CheckBoxList6.DataBind();

            //get experience
            CheckBoxList5.DataSource = mloads.Mcgetexp();
            CheckBoxList5.DataTextField = "sdefinition";
            CheckBoxList5.DataValueField = "subcatid";
            CheckBoxList5.DataBind();

            //education level
            CheckBoxList8.DataSource = mloads.Mcgeteducation();
            CheckBoxList8.DataTextField = "sdefinition";
            CheckBoxList8.DataValueField = "subcatid";
            CheckBoxList8.DataBind();

            //career level
            CheckBoxList9.DataSource = mloads.Mcgetcareer();
            CheckBoxList9.DataTextField = "sdefinition";
            CheckBoxList9.DataValueField = "subcatid";
            CheckBoxList9.DataBind();

            //hours 
            CheckBoxList4.DataSource = mloads.Mcgethrs();
            CheckBoxList4.DataTextField = "sdefinition";
            CheckBoxList4.DataValueField = "subcatid";
            CheckBoxList4.DataBind();

            //Contract Tpye
            CheckBoxList3.DataSource = mloads.Mcgetcontract();
            CheckBoxList3.DataTextField = "sdefinition";
            CheckBoxList3.DataValueField = "subcatid";
            CheckBoxList3.DataBind();

            #endregion checkboxpop
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            Multiblock();
        }

        private string MakeQuery()
        {
            var _url = new StringBuilder();

            if (Request.QueryString["list"] != null)
            {
                _url.Append("&list=" + Request.QueryString["list"]);
            }

            if (Request.QueryString["qry"] != null)
            {
                _url.Append("&qry=" + Request.QueryString["qry"]);
            }

            if (Request.QueryString["q"] != null)
            {
                _url.Append("&q=" + Request.QueryString["q"]);
            }

            if (Request.QueryString["group"] != null)
            {
                _url.Append("&group=" + Request.QueryString["group"]);
            }

            if (Request.QueryString["lev"] != null)
            {
                _url.Append("&lev=" + Request.QueryString["lev"]);
            }

            if (Request.QueryString["item"] != null)
            {
                _url.Append("&item=" + Request.QueryString["item"]);
            }

            if (Request.QueryString["b"] != null)
            {
                _url.Append("&b=" + Request.QueryString["b"]);
            }

            if (Request.QueryString["i"] != null)
            {
                _url.Append("&i=" + Request.QueryString["i"]);
            }

            if (Request.QueryString["c"] != null)
            {
                _url.Append("&c=" + Request.QueryString["c"]);
            }

            if (Request.QueryString["r"] != null)
            {
                _url.Append("&r=" + Request.QueryString["r"]);
            }

            if (Request.QueryString["m"] != null)
            {
                _url.Append("&m=" + Request.QueryString["m"]);
            }

            if (Request.QueryString["v"] != null)
            {
                _url.Append("&v=" + Request.QueryString["v"]);
            }

            if (Request.QueryString["curr"] != null)
            {
                _url.Append("&curr=" + Request.QueryString["curr"]);
            }

            return _url.ToString();
        }

        private string _GetCities()
        {
            var _usercity = string.Empty;
            CheckBoxInternet.Checked = true;
            var __ipfile = ConfigurationManager.AppSettings["geolocation"].ToString(CultureInfo.InvariantCulture);
            var ls = new LookupService(__ipfile, LookupService.GEOIP_STANDARD);
            var useripaddr = Request.ServerVariables["REMOTE_ADDR"];
            var l = ls.getLocation(useripaddr);
            _usercity = l != null ? l.city : "0";
            return _usercity;
        }

        private int _PageSize()
        {
            var _NewPageSize = ReadCookies("fq_pagesize");
            if (_NewPageSize != null)
            {
                switch (_NewPageSize)
                {
                    case "10":
                        return 10;
                    case "20":
                        return 20;
                    default:
                        return 50;
                }
            }

            else
            {
                return 10;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //set default buttons
            TextBox2.Focus();
            Page.Form.DefaultButton = Button1.UniqueID;

            var _url = MakeQuery();
            //var queryString = string.Join(string.Empty, _url.Split('?').Skip(1));

            if (Request.IsSecureConnection)
            {
                Response.Redirect(ConfigurationManager.AppSettings["httppaths"].ToString(CultureInfo.InvariantCulture) +
                                  "/searched.aspx");
            }

            //if (Request.QueryString["group"] != null)
            //{
                //groupoutput.Text = Request.QueryString["group"];
            //}

            //save button
            if (Session["isjobseeker"] != null)
            {
                ButtonSaveSrch.Visible = true;
            }

            /////////////////////////////////////
            //Cartprocess();
            DynamicPopulator();

            var mp = new ClMainPagePopulator();
            //get count of all jobs

            /////////////////////////////////////
            if (!IsPostBack)
            {
                //query textbox
                if (Request.QueryString["q"] != null && Request.QueryString["q"] != "ALL")
                {
                    TextBox2.Text = Request.QueryString["q"];
                }

                if (Request.QueryString["i"] != null)
                {
                    var _usercity = _GetCities();
                }

                var ccs = new ClSearchFilters();

                //paging
                int lowlimit = 0;
                int maxpages = 0;

                int pagesize = 10;

                pagesize = _PageSize();

                if (Request.QueryString["page"] != null)
                {
                    lowlimit = (Convert.ToInt16(Request.QueryString["page"]) - 1);
                    if (lowlimit != 0)
                    {
                        lowlimit = lowlimit * pagesize;
                    }
                }

                //saved searches
                if (Request.QueryString["csc"] != null)
                {
                    //use saved search
                    switch (Request.QueryString["csc"])
                    {
                        case "ALL":
                            /*BrowsingList.DataSource =
                                ccs.Casebrowserfilter(
                                    " max(subcatid) as subcatid, catid, cdefinition as sdefinition, ctotals FROM vw_brfilter where liparent = 0 group by cdefinition ");
                            BrowsingList.DataBind();*/
                            var cpfilt = new ClSearchFilters();
                            BrowsingList.DataSource = cpfilt.Getdefaultbrall();
                            BrowsingList.DataBind();
                            JobsList.DataSource = ccs.Caseall(lowlimit, pagesize);
                            JobsList.DataBind();
                            maxpages = ccs.CaseallCount();
                            CustomPaging.Text = CreatePageLinks(maxpages, pagesize, _url);
                            break;
                        default:
                            {
                                var clh = new ClHistory();
                                var tsearhes = Session["ssr"].ToString();
                                //clh.Getsavedsearchout(Session["ssr"].ToString());
                                //get search
                                /*
                                 * BrowsingList.DataSource =
                                    ccs.Casebrowserfilter(
                                        " max(subcatid) as subcatid, catid, cdefinition as sdefinition, ctotals FROM vw_brfilter where liparent = 0 group by cdefinition ");
                                BrowsingList.DataBind();*/
                                ClSearchFilters cpfilter = new ClSearchFilters();
                                BrowsingList.DataSource = cpfilter.Getdefaultbrall();
                                BrowsingList.DataBind();
                                JobsList.DataSource = ccs.Casewochkbox(tsearhes, lowlimit, pagesize);
                                JobsList.DataBind();

                                maxpages = ccs.Casewochkbox(tsearhes);
                                CustomPaging.Text = CreatePageLinks(maxpages, pagesize, _url);
                            }
                            break;
                    }
                }

                else
                {
                    if (Request.QueryString["lev"] != null)
                    {
                        DoSearch(0);

                        //  switch (Request.QueryString["lev"])
                        //  {                           

                        //case "0":
                        //    BrowsingList.DataSource =
                        //        ccs.Casebrowserfilter(
                        //            " max(subcatid) as subcatid, catid, cdefinition as sdefinition, ctotals FROM vw_brfilter where liparent = 0 group by cdefinition ");
                        //    BrowsingList.DataBind();
                        //    JobsList.DataSource = ccs.Caseall(lowlimit, pagesize);
                        //    JobsList.DataBind();
                        //    maxpages = ccs.CaseallCount();
                        //    CustomPaging.Text = CreatePageLinks(maxpages, pagesize, _url);
                        //    break;
                        //case "1":
                        //    BrowsingList.DataSource =
                        //        ccs.Casebrowserfilter(
                        //            " liparent, catid, subcatid, sdefinition, ctotals FROM vw_brfilter where cdefinition = '" +
                        //            Server.HtmlEncode(Request.QueryString["group"]) + "' and liparent = 0 ");
                        //    BrowsingList.DataBind();
                        //    JobsList.DataSource =
                        //        ccs.Casebrowsergrid(
                        //            @" applicationvolume, spostcode, idjobs, stitle, video, company, slocation, srecruitername, sshortdescription, sfreetext, dtentereddate,ssalarytext, employeeid from vw_aggregatedmulti where cdefinition = '" +
                        //            Request.QueryString["group"] +
                        //            "' group by applicationvolume, spostcode, idjobs, stitle, video, company, slocation, srecruitername, sshortdescription, sfreetext, dtentereddate,ssalarytext, employeeid ", lowlimit, pagesize);
                        //    JobsList.DataBind();
                        //    maxpages = ccs.Casebrowsergrid(@" applicationvolume, spostcode, idjobs, stitle, video, company, slocation, srecruitername, sshortdescription, sfreetext, dtentereddate,ssalarytext, employeeid from vw_aggregatedmulti where cdefinition = '" +
                        //            Request.QueryString["group"] +
                        //            "' group by applicationvolume, spostcode, idjobs, stitle, video, company, slocation, srecruitername, sshortdescription, sfreetext, dtentereddate,ssalarytext, employeeid ");
                        //    CustomPaging.Text = CreatePageLinks(maxpages, pagesize, _url);
                        //    break;
                        //default:
                        //    switch ((Request.QueryString["lev"]))
                        //    {
                        //        case "2":
                        //            BrowsingList.DataSource =
                        //                ccs.Casebrowserfilter(
                        //                    @" s.sdefinition, b.catid as catid, b.subcatid as subcatid, b.ctotals as ctotals from vw_brfilter b, tb_microcat m, subcats s where m.subcatid = b.subcatid and m.microcatid = s.subcatid and b.sdefinition = '" +
                        //                    Server.HtmlEncode(Request.QueryString["group"]) +
                        //                    "' and s.liparent = 1 ");
                        //            BrowsingList.DataBind();
                        //            JobsList.DataSource =
                        //                ccs.Casebrowsergrid(
                        //                    @" applicationvolume, spostcode, idjobs, stitle, video, company, slocation, srecruitername, sshortdescription, sfreetext, dtentereddate,ssalarytext, employeeid from vw_aggregatedmulti where subcatid = '" +
                        //                    Request.QueryString["item"] +
                        //                    "' group by applicationvolume, spostcode, idjobs, stitle, video, company, slocation, srecruitername, sshortdescription, sfreetext, dtentereddate,ssalarytext, employeeid ", lowlimit, pagesize);
                        //            JobsList.DataBind();
                        //            maxpages = ccs.Casebrowsergrid(@" applicationvolume, spostcode, idjobs, stitle, video, company, slocation, srecruitername, sshortdescription, sfreetext, dtentereddate,ssalarytext, employeeid from vw_aggregatedmulti where subcatid = '" +
                        //                    Request.QueryString["item"] +
                        //                    "' group by applicationvolume, spostcode, idjobs, stitle, video, company, slocation, srecruitername, sshortdescription, sfreetext, dtentereddate,ssalarytext, employeeid "
                        //        );
                        //            CustomPaging.Text = CreatePageLinks(maxpages, pagesize, _url);
                        //            break;
                        //        case "3":
                        //            BrowsingList.DataSource =
                        //                ccs.Casebrowserfilter(
                        //                    @" s.sdefinition, b.subcatid as catid, b.subcatid as subcatid, b.ctotals as ctotals from vw_brfilter b, tb_microcat m, subcats s where m.subcatid = b.subcatid and m.microcatid = s.subcatid and b.sdefinition = '" +
                        //                    Server.HtmlEncode(Request.QueryString["group"]) +
                        //                    "' and s.liparent = 2 ");
                        //            BrowsingList.DataBind();
                        //            JobsList.DataSource =
                        //                ccs.Casebrowsergrid(
                        //                    @" applicationvolume, spostcode, idjobs, stitle, video, company, slocation, srecruitername, sshortdescription, sfreetext, dtentereddate,ssalarytext, employeeid from vw_aggregatedmulti where subcatid = '" +
                        //                    Request.QueryString["item"] +
                        //                    "' group by applicationvolume, spostcode, idjobs, stitle, video, company, slocation, srecruitername, sshortdescription, sfreetext, dtentereddate,ssalarytext, employeeid ", lowlimit, pagesize);
                        //            JobsList.DataBind();
                        //            maxpages = ccs.Casebrowsergrid(@" applicationvolume, spostcode, idjobs, stitle, video, company, slocation, srecruitername, sshortdescription, sfreetext, dtentereddate,ssalarytext, employeeid from vw_aggregatedmulti where subcatid = '" +
                        //                    Request.QueryString["item"] +
                        //                    "' group by applicationvolume, spostcode, idjobs, stitle, video, company, slocation, srecruitername, sshortdescription, sfreetext, dtentereddate,ssalarytext, employeeid ");                          
                        //            CustomPaging.Text = CreatePageLinks(maxpages, pagesize, _url);
                        //            break;
                        //        default:
                        //            break;
                        //    }
                        //    break;

                        // }
                    }

                        //get the search
                    else
                    {
                        OneEyeControl(0);

                        //add browsing items
                        var cpfilt = new ClSearchFilters();
                        BrowsingList.DataSource = cpfilt.Getdefaultbrall();
                        BrowsingList.DataBind();
                        //JobsList.DataSource = cpfilt.GetAllWapJobs(lowlimit, pagesize);
                        //JobsList.DataBind();

                        //int _maxrows = cpfilt.GetAllWapJobs();

                        /*
                        if (Request.QueryString["q"] != null)
                        {
                            var titles = Server.HtmlEncode(Request.QueryString["q"]);

                            switch (titles)
                            {
                                case "ALL":
                                    //JobsList.DataSource = ccs.Caseall(lowlimit, pagesize);
                                    //JobsList.DataBind();
                                    //maxpages = ccs.CaseallCount();
                                    //CustomPaging.Text = CreatePageLinks(maxpages, pagesize, _url);
                                    //BrowsingList.DataSource =
                                    //    ccs.Casebrowserfilter(
                                    //        " max(subcatid) as subcatid, catid, cdefinition as sdefinition, sum(ctotals) as ctotals FROM vw_brfilter where liparent = 0 group by cdefinition ");
                                    //BrowsingList.DataBind();
                                    break;
                                default:
                                    //JobsList.DataSource =
                                    //     ccs.Casewochkbox(" where match(sfreetext) against ('" +
                                    //                     Server.HtmlEncode(Request.QueryString["q"].Trim()) +
                                    //                     "' IN NATURAL LANGUAGE MODE)", lowlimit, pagesize);
                                    //JobsList.DataBind();
                                    //maxpages = ccs.CaseBrowseGridAll();
                                    //CustomPaging.Text = CreatePageLinks(maxpages, pagesize, _url);
                                    //BrowsingList.DataSource = ccs.Getdefaulttxtcat(titles);
                                    //BrowsingList.DataBind();

                                    break;
                            }
                        }
                         */

                    }
                }
            }
        }

        private void DispNoJob()
        {
            //display no results
            if (JobsList.Rows.Count == 0)
            {
                LabelNoResult.Visible = true;
            }

            else
            {
                LabelNoResult.Visible = false;
            }
        }

        private void AddStartupScripts(string scrname)
        {
            String cqry1 = " loader(); ";
            ScriptManager.RegisterStartupScript(this, this.GetType(), scrname, cqry1, true);
        }

        private ArrayList CheckSelectionCriterion()
        {
            var al = new ArrayList();
            //bool ix = false;

            //insert salaries
            for (var index = 0; index < CheckBoxList6.Items.Count; index++)
            {
                var listsal = CheckBoxList6.Items[index];
                switch (listsal.Selected)
                {
                    case true:
                        al.Add(listsal.Value);
                        break;
                }
            }

            //insert location
            foreach (var cb1 in CheckBoxList2.Controls.OfType<CheckBox>())
            {
                switch (cb1.Checked)
                {
                    case true:
                        al.Add(cb1.ID);
                        break;
                }
            }

            //industry
            foreach (var cb in CheckBoxList1.Controls.OfType<CheckBox>())
            {
                switch (cb.Checked)
                {
                    case true:
                        al.Add(cb.ID);
                        break;
                }
                //ix = true;
            }

            //insert contract
            for (var index = 0; index < CheckBoxList3.Items.Count; index++)
            {
                var listit3 = CheckBoxList3.Items[index];
                switch (listit3.Selected)
                {
                    case true:
                        al.Add(listit3.Value);
                        break;
                }
            }

            //add hours
            foreach (var listit4 in CheckBoxList4.Items.Cast<ListItem>().Where(listit4 => listit4.Selected))
            {
                //search
                al.Add(listit4.Value);
                //ix = true;
            }

            //add employer type
            for (var index = 0; index < CheckBoxList5.Items.Count; index++)
            {
                var listit5 = CheckBoxList5.Items[index];
                switch (listit5.Selected)
                {
                    case true:
                        al.Add(listit5.Value);
                        break;
                }
            }

            foreach (var cbt1 in CheckBoxList7.Controls.OfType<CheckBox>())
            {
                switch (cbt1.Checked)
                {
                    case true:
                        al.Add(cbt1.ID);
                        break;
                }
            }

            foreach (var listit4 in CheckBoxList8.Items.Cast<ListItem>().Where(listit4 => listit4.Selected))
            {
                //search
                al.Add(listit4.Value);
                //ix = true;
            }

            //add hours
            foreach (var listit4 in CheckBoxList9.Items.Cast<ListItem>().Where(listit4 => listit4.Selected))
            {
                //search
                al.Add(listit4.Value);
                //ix = true;
            }

            al.TrimToSize();
            return al;
        }

        private string DetailSelection()
        {
            //call inmemory keys
            var clcc = new ClSearchMain();
            var al = (ArrayList)clcc.Mcjobtable();
            var tmp = new ArrayList();
            var criterion = CheckSelectionCriterion();

            //loop through memory
            var sbd = new StringBuilder();

            //only text box
            var mp = new ClMainPagePopulator();

            var titlian = string.Empty;
            var uflag = false;

            sbd.Append("and idjobs IN (");

            for (var i = 0; i < al.Count; i++)
            {
                if (criterion.BinarySearch(al[i]) > -1 && tmp.BinarySearch(al[i - 1]) < 0)
                {
                    tmp.Add(al[i - 1]);
                    sbd.Append(al[i - 1] + ",");
                    uflag = true;
                }
            }

            var toparse = string.Empty;

            switch (uflag)
            {
                case true:
                    toparse = sbd.ToString().Substring(0, sbd.Length - 1) + ")";
                    break;
                default:
                    sbd.Clear();
                    break;
            }

            al.Clear();
            tmp.Clear();
            criterion.Clear();

            return toparse;
        }

        protected void Button1Click(object sender, EventArgs e)
        {
            //do post processing of checkboxes before passing to one eye
            var _selectdetail = "";
            _selectdetail = DetailSelection();
            var _b = false;

            //get cbxids
            ArrayList _cbxid = CheckSelectionCriterion();

            if (_cbxid.Count > 0)
            {
                Session["cbxid"] = _cbxid;
                _b = true;
            }

            if (_selectdetail != "")
            {
                //add to session
                Session["detailselection"] = _selectdetail;
            }

            var _redirect = "/searched.aspx?b=" + _b + OneEyeCriteria();
            Response.Redirect(_redirect);
            //OneEyeControl(0);

            //register startup
            //AddStartupScripts("Scripter3");
        }

        protected void JobsListRowDataBound(object sender, GridViewRowEventArgs e)
        {
            //if user is logged in then proceed.
            if (Session["isjobseeker"] != null)
            {
                var clh = new ClHistory();
                var splitted = new ArrayList();
                splitted = clh.Getarraysavedjobs(Session["canloginid"].ToString());

                switch (e.Row.RowType)
                {
                    case DataControlRowType.DataRow:

                        #region jobcart

                        var hl = ((LinkButton)e.Row.FindControl("LinkButton1"));
                        var s1 = DataBinder.Eval(e.Row.DataItem, "idjobs").ToString();
                        hl.ID = "Saveids" + s1;
                        hl.CausesValidation = false;
                        hl.Click += SaveSearchButtonClick;
                        //get the saved jobs in db

                        //set default visibilty = true for all saves when user logged in.
                        hl.Visible = true;

                        if (splitted != null)
                        {
                            foreach (var si in splitted.Cast<string>().Where(si => si == s1))
                            {
                                hl.Visible = false;
                            }
                        }

                        #endregion jobcart

                        break;
                    default:
                        break;
                }
            }

            //set hover styles
            switch (e.Row.RowType)
            {
                case DataControlRowType.DataRow:
                    e.Row.Attributes.Add("onmouseover", "this.className='dv_shadowa1'");
                    e.Row.Attributes.Add("onmouseout", "this.className=''");
                    break;
            }
        }

        protected void Button2Click(object sender, EventArgs e)
        {
            //process notifications
            string tmpmail = Server.HtmlEncode(TextBox3.Text).Trim();
            var _tmpdescription = Server.HtmlEncode(TextBox4.Text).Trim();

            if (_tmpdescription == "")
            {
                LabelNotify.Text = "Description Required";
            }

            else if (tmpmail == "" || tmpmail.Contains("@") == false || tmpmail.Contains(".") == false || tmpmail.Length < 3)
            {
                LabelNotify.Text = "Invalid Email!";
            }

            else
            {
                //get client ip
                var csip = "";
                csip = Request.ServerVariables["REMOTE_ADDR"].ToString(CultureInfo.InvariantCulture);

                //add comment to db here
                var cmppgpop = new ClMainPagePopulator();
                cmppgpop.Insertsitecomment(tmpmail, _tmpdescription, csip);

                Label10.Visible = true;
                suggestmainpan.Visible = false;
                Panelsuggresult.Visible = true;

                //animate and disappear
                String cqry1 = " $('#suggestion').delay(3000).effect(\"fade\",\"easeInOutQuad\",\"600\", loader()); ";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Scripter1", cqry1, true);
            }
        }

        protected void LinkButton5Click(object sender, EventArgs e)
        {
            #region browsecontrolactions

            if (Convert.ToInt16(Request.QueryString["lev"]) < 4)
            {
                //work around for leveling subcats
                var lb = (LinkButton)sender;

                int _templev = Convert.ToInt16(Request.QueryString["lev"]) + 1;
                Response.Redirect("/searched.aspx?qry=" + lb.Text + "&lev=" + _templev + "&item=" + lb.CommandArgument);
            }

            #endregion browsecontrolactions
        }

        private string ReadCookies(string _CookieName)
        {
            HttpCookie myCookie = Request.Cookies[_CookieName];

            // Read the cookie information and return it.
            if (myCookie != null)
                return myCookie.Value;
            else
                return null;
        }

        private void OneEyeControl(int savesearch)
        {
            //JobsList.PageIndex = 0;

            //paging
            int lowlimit = 0;
            int maxpages = 0;

            int pagesize = _PageSize();

            if (Request.QueryString["page"] != null)
            {
                lowlimit = (Convert.ToInt16(Request.QueryString["page"]) - 1);
                if (lowlimit != 0)
                {
                    lowlimit = lowlimit * pagesize;
                }
            }

            string _url = MakeQuery();

            //ViewState["viewblock"] = "1";
            var cpfilt = new ClSearchFilters();

            var usercity = string.Empty;
            var useripaddr = Request.ServerVariables["REMOTE_ADDR"].ToString(CultureInfo.InvariantCulture);

            if (Request.QueryString["i"] != null)
            {
                usercity = _GetCities();
            }

            var tempsearch = "";

            if (Session["detailselection"] != null)
            {
                tempsearch = Session["detailselection"].ToString();
            }

            var tempsearch2 = OneEyeSearch(usercity);
            var finsearch = string.Empty;

            var ccs = new ClSearchFilters();
            var clhis = new ClHistory();

            if (tempsearch == "" && tempsearch2 == "")
            {
                switch (savesearch)
                {
                    case 1:
                        {
                            //save to db
                            var tempcanid = Session["canloginid"].ToString();
                            clhis.Insertsavedsearch(tempcanid, "ALL",
                                                   useripaddr, TextBoxSavedSearchName.Text);
                        }
                        break;
                    default:
                        /*BrowsingList.DataSource =
                            ccs.Casebrowserfilter(
                                " max(subcatid) as subcatid, catid, cdefinition as sdefinition, ctotals FROM vw_brfilter where liparent = 0 group by cdefinition ");
                        BrowsingList.DataBind();
                         */
                        var cpfilt1 = new ClSearchFilters();
                        BrowsingList.DataSource = cpfilt1.Getdefaultbrall();
                        BrowsingList.DataBind();
                        JobsList.DataSource = ccs.Caseall(lowlimit, pagesize);
                        JobsList.DataBind();
                        maxpages = ccs.CaseallCount();
                        CustomPaging.Text = CreatePageLinks(maxpages, pagesize, _url);
                        break;
                }
            }

            if (tempsearch == "")
            {
                switch (savesearch)
                {
                    case 1:
                        {
                            //save to db
                            var tempcanid = Session["canloginid"].ToString();
                            clhis.Insertsavedsearch(tempcanid, " where stitle is not null " + tempsearch2,
                                                    useripaddr, TextBoxSavedSearchName.Text);
                        }
                        break;
                    default:
                        /*BrowsingList.DataSource =
                            ccs.Casebrowserfilter(
                                " max(subcatid) as subcatid, catid, cdefinition as sdefinition, ctotals FROM vw_brfilter where liparent = 0 group by cdefinition ");
                        BrowsingList.DataBind();
                         */
                        var cpfilters = new ClSearchFilters();
                        BrowsingList.DataSource = cpfilters.Getdefaultbrall();
                        BrowsingList.DataBind();
                        finsearch = tempsearch2;
                        JobsList.DataSource = ccs.Casewochkbox(" where stitle is not null " + finsearch, lowlimit, pagesize);
                        JobsList.DataBind();
                        maxpages = ccs.Casewochkbox(" where stitle is not null " + finsearch);
                        CustomPaging.Text = CreatePageLinks(maxpages, pagesize, _url);
                        break;
                }
            }

            else
            {
                switch (savesearch)
                {
                    case 1:
                        {
                            //save to db
                            var tempcanid = Session["canloginid"].ToString();
                            clhis.Insertsavedsearch(tempcanid, " where stitle is not null " + tempsearch + tempsearch2,
                                                    useripaddr, TextBoxSavedSearchName.Text);
                        }
                        break;
                    default:
                        /*BrowsingList.DataSource =
                            ccs.Casebrowserfilter(
                                " max(subcatid) as subcatid, catid, cdefinition as sdefinition, ctotals FROM vw_brfilter where liparent = 0 group by cdefinition ");
                        BrowsingList.DataBind();
                         */
                        var cpfilter = new ClSearchFilters();
                        BrowsingList.DataSource = cpfilter.Getdefaultbrall();
                        BrowsingList.DataBind();
                        finsearch = tempsearch + tempsearch2;
                        JobsList.DataSource = ccs.CaseWithCheckBoxes(" where stitle is not null " + finsearch, lowlimit, pagesize);
                        JobsList.DataBind();
                        maxpages = ccs.Casewochkbox(" where stitle is not null " + finsearch);
                        CustomPaging.Text = CreatePageLinks(maxpages, pagesize, _url);
                        break;
                }
            }

            DispNoJob();
        }

        protected void SaveSearchButtonClick(object sender, EventArgs e)
        {
            //add the current id to the database
            var l1 = (LinkButton)sender;
            var tempjid = l1.ID.Replace("Saveids", "");

            //save the job
            var clh = new ClHistory();
            var tempcanlogin = Session["canloginid"].ToString();
            clh.Insertsavedjobs(tempcanlogin, tempjid);
            l1.Visible = false;
        }

        protected void ButtonSaveSearchClick(object sender, EventArgs e)
        {
            OneEyeControl(1);
        }

        protected string CreateUrl(object cat, object subcat)
        {
            if (subcat.ToString() != "")
            {
                return cat.ToString() + "&list=" + subcat.ToString();
            }

            else
            {
                return cat.ToString();
            }

        }
    }
}