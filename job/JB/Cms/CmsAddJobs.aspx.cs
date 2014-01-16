using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Msftlayer;
using minGuid;
using System.Collections;
using System.Text;

namespace JB.Cms
{
    public partial class CmsAddJobs : System.Web.UI.Page
    {
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

                //get recruiter names list
                var _C = new ClRecruiters();
                DropDownListRecruiters.DataSource = _C.GetAllRecs();

                DropDownListRecruiters.DataTextField = "srecruitername";
                DropDownListRecruiters.DataValueField = "empid";
                DropDownListRecruiters.DataBind();
            }

            //get currency list
        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            const string scripts = "scroll(0,0);";
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "scripter", scripts, true);

            //combine dates
            string _SDate = StartDate3.Text + "-" + StartDate2.Text + "-" + StartDate1.Text;
            string _EDate = EndDate3.Text + "-" + EndDate2.Text + "-" + EndDate1.Text;
            string _RecName = DropDownListRecruiters.SelectedItem.Text;
            string _RedId = DropDownListRecruiters.SelectedItem.Value;
            string _Currency = Currency.SelectedItem.Value;

            //save job
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

            ClMainPagePopulator cm = new ClMainPagePopulator();

            cm.Insertjobs(mxjobsid, TextBoxTitle.Text, TextBoxShortDesc.Text, TextBoxDesc.Text, TextBoxSal.Text, 0, 0, TextBoxRefno.Text, _SDate, _EDate, false, null, null, _RecName, _Currency);

            //cm.Insertrecusermapping(_RedId, _RecName);
            //remove this method

            cm.Insertjobmapping(mxjobsid, 10000, 10000, _RedId);

            //insert sectors
            foreach (Control listite1 in CheckBoxList4.Controls)
            {
                var cbox = listite1 as CheckBox;
                if (cbox != null)
                {
                    if (cbox.Checked == true)
                    {
                        //insert
                        cm.Insertjobmapping(mxjobsid, 1006, Convert.ToInt16(cbox.ID), _RedId);
                        //debugme.Append(mxjobsid + "1006"+ Convert.ToInt16(cbox.ID)+ _RedId + "--");
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
                        cm.Insertjobmapping(mxjobsid, 1000, Convert.ToInt16(cbox.ID), _RedId);
                        //debugme.Append(mxjobsid + "1000" + Convert.ToInt16(cbox.ID) + _RedId + "--");
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
                        cm.Insertjobmapping(mxjobsid, 1001, Convert.ToInt16(cbox23.ID), _RedId);
                        //debugme.Append(mxjobsid + "1001" + Convert.ToInt16(cbox23.ID) + _RedId + "--");
                    }
                }
            }

            //insert contract ok
            foreach (ListItem listitems2 in CheckBoxList3.Items)
            {
                if (listitems2.Selected == true)
                {
                    //insert cats
                    cm.Insertjobmapping(mxjobsid, 1002, Convert.ToInt16(listitems2.Value), _RedId);
                    //debugme.Append(mxjobsid + "1002" + Convert.ToInt16(listitems2.Value) + _RedId + "--");
                }
            }

            //insert hours ok
            foreach (ListItem listitems4 in CheckBoxList7.Items)
            {
                if (listitems4.Selected == true)
                {
                    cm.Insertjobmapping(mxjobsid, 1003, Convert.ToInt16(listitems4.Value), _RedId);
                    //debugme.Append(mxjobsid + "1003" + Convert.ToInt16(listitems4.Value) + _RedId + "--");
                }
            }

            //experience ok
            foreach (ListItem listitems5 in CheckBoxList8.Items)
            {
                if (listitems5.Selected == true)
                {
                    cm.Insertjobmapping(mxjobsid, 1004, Convert.ToInt16(listitems5.Value), _RedId);
                    //debugme.Append(mxjobsid + "1004" + Convert.ToInt16(listitems5.Value) + _RedId + "--");
                }
            }

            //insert salary ok
            foreach (ListItem listitems6 in CheckBoxList6.Items)
            {
                if (listitems6.Selected == true)
                {
                    cm.Insertjobmapping(mxjobsid, 1005, Convert.ToInt16(listitems6.Value), _RedId);
                    //debugme.Append(mxjobsid + "1005" + Convert.ToInt16(listitems6.Value) + _RedId + "--");
                }
            }

            //education ok
            foreach (ListItem education in CheckBoxList9.Items)
            {
                if (education.Selected == true)
                {
                    cm.Insertjobmapping(mxjobsid, 1008, Convert.ToInt16(education.Value), _RedId);
                    //debugme.Append(mxjobsid + "1008" + Convert.ToInt16(__education.Value) + _RedId + "--");
                }
            }

            //career level ok
            foreach (ListItem careerlevel in CheckBoxList10.Items)
            {
                if (careerlevel.Selected == true)
                {
                    cm.Insertjobmapping(mxjobsid, 1007, Convert.ToInt16(careerlevel.Value), _RedId);
                    //debugme.Append(mxjobsid + "1007" + Convert.ToInt16(_careerlevel.Value) + _RedId + "--");
                }
            }

            Session["ir"] = "Job Added!";

            Response.Redirect("/cms/Confirmation.aspx");
        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("/cms/cmshome.aspx");
        }
    }
}