using System;
using System.Collections;
using System.Globalization;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;
using Msftlayer;
using System.Configuration;

namespace JB
{
    public partial class Jbsubscribe : System.Web.UI.Page
    {
        private int RequestCheck()
        {
            if (Emailsubs.Text == "")
            {
                LabelNotify.Text = "Email address is required!";
                return 1;
            }

            else if (Emailsubs.Text.Contains("@") == false && Emailsubs.Text.Contains(".") == false)
            {
                LabelNotify.Text = "Not a valid Email!";
                return 1;
            }

            else
            {
                return 0;
            }

        }

        private void Multiblock()
        {
            var mloads = new ClMemLoad();

            //get locations
            var alistloc = (ArrayList)mloads.Mcgetloc();
            for (var alisti5 = 0; alisti5 < alistloc.Count; alisti5 += 3)
            {
                var tn = new CheckBox { Text = alistloc[alisti5 + 1].ToString(), ID = alistloc[alisti5].ToString() };

                switch (Convert.ToInt16(alistloc[alisti5 + 2]))
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
            for (var alisti6 = 0; alisti6 < alistloc.Count; alisti6 += 3)
            {
                var tn = new CheckBox { Text = alistloc[alisti6 + 1].ToString(), ID = alistloc[alisti6].ToString() };

                switch (Convert.ToInt16(alistloc[alisti6 + 2]))
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

            //get sectors
            for (var alisti4 = 0; alisti4 < alistloc.Count; alisti4 += 3)
            {
                var tn = new CheckBox
                             {
                                 Text = alistloc[alisti4 + 1].ToString(),
                                 ID = alistloc[alisti4].ToString(),
                                 CssClass = "usr_checkleft10"
                             };
                CheckBoxList7.Controls.Add(tn);

                var slit1 = new Literal { Text = "<br />" };
                CheckBoxList7.Controls.Add(slit1);
            }

            alistloc.Clear();
            //newthe();
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            Multiblock();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.IsSecureConnection)
            {
                Response.Redirect(System.Configuration.ConfigurationManager.AppSettings["httppaths"].ToString(CultureInfo.InvariantCulture) + "/subscribe");
            }

            if (Session["isrecruiter"] != null)
            {
                if ((Boolean)Session["isrecruiter"] != true)
                { }

                else
                {
                    Session["reasons"] = "You cannot subscribe to emails recruiter, please logout and then try again!";
                    Response.Redirect("/confirm");
                }
            }

            if (!IsPostBack)
            {
                //constructor
                //CLMainpagepopulator mp = new CLMainpagepopulator();
                var mload = new ClMemLoad();

                //populate left
                //get salaries
                CheckBoxList6.DataSource = mload.Mcgetsalary();
                CheckBoxList6.DataTextField = "sdefinition";
                CheckBoxList6.DataValueField = "subcatid";
                CheckBoxList6.DataBind();

                //get experience
                CheckBoxList5.DataSource = mload.Mcgetexp();
                CheckBoxList5.DataTextField = "sdefinition";
                CheckBoxList5.DataValueField = "subcatid";
                CheckBoxList5.DataBind();

                //get education
                CheckBoxList9.DataSource = mload.Mcgeteducation();
                CheckBoxList9.DataTextField = "sdefinition";
                CheckBoxList9.DataValueField = "subcatid";
                CheckBoxList9.DataBind();

                //get career
                CheckBoxList10.DataSource = mload.Mcgetcareer();
                CheckBoxList10.DataTextField = "sdefinition";
                CheckBoxList10.DataValueField = "subcatid";
                CheckBoxList10.DataBind();


                //get hrs
                CheckBoxList4.DataSource = mload.Mcgethrs();
                CheckBoxList4.DataTextField = "sdefinition";
                CheckBoxList4.DataValueField = "subcatid";
                CheckBoxList4.DataBind();


                //get contract
                CheckBoxList3.DataSource = mload.Mcgetcontract();
                CheckBoxList3.DataTextField = "sdefinition";
                CheckBoxList3.DataValueField = "subcatid";
                CheckBoxList3.DataBind();


            }
            else
            {
                //rebind controls
                if (ViewState["panctrlc1"] == null)
                {
                }

                else
                {
                    //first match with existing postcode list

                    CheckBoxList8.Controls.Clear();
                    var st = ViewState["panctrlc1"].ToString();
                    char[] tmpar = { ',' };
                    var starr = st.Split(tmpar, StringSplitOptions.RemoveEmptyEntries);
                    var sbtr = new StringBuilder();
                    var i = 1;

                    foreach (var itm in starr)
                    {
                        if (itm != ",")
                        {
                            i++;
                            var litm = new Button
                                           {
                                               ID = "dynamic" + i.ToString(CultureInfo.InvariantCulture),
                                               Text = itm,
                                               CssClass = "dynabuttoncss",
                                               CausesValidation = false
                                           };
                            litm.Click += new EventHandler(this.Evrem1);
                            CheckBoxList8.Controls.Add(litm);
                            sbtr.Append(litm.Text + ",");
                        }
                    }

                    ViewState["panctrlc1"] = sbtr.ToString();
                }
            }
        }

        protected void Button1Click(object sender, EventArgs e)
        {
            var clsubs = new ClSubscriptions();
            var emailsubstr = Emailsubs.Text;

            var sbil = new StringBuilder();

            var rq = RequestCheck();

            if (rq == 0)
            {

                //sbil.Append("<div style=\"padding: 10px 0px 0px 10px;\"><div style=\"width: 500px; background-color: #fff; border-width: 1px; border-collapse: collapse; border-style: solid;\"><div style=\"color: #FFFFFF; min-height: 50px; background-color: #000; display: inline-block; width: 500px; vertical-align: middle;\"><img alt=\"fashionquadrant\" src=\"" + ConfigurationManager.AppSettings["httppaths"].ToString() + "/brandimages/brand_mail.png\"/></div><div style=\"border-color: #999; border-bottom-style: solid; border-width: 2px; border-top-style: solid; background-color: #666; padding: 10px 10px 10px 10px; color: #E6E6E6; font-family: Lucida Grande, Helvetica, Arial, Verdana, sans-serif; font-size: 12px; min-height:300px;\"><br/>Hi there,<br/><br/><br/><b>You have new job alerts!</b><br/>");
                sbil.Append("<br/><b>Criteria set for Location:</b><br/>");

                //insert location
                foreach (Control listite1 in CheckBoxList2.Controls)
                {
                    var cb = listite1 as CheckBox;
                    if (cb != null)
                    {
                        if (cb.Checked == true)
                        {
                            sbil.Append(cb.Text + "<br/>");
                            //insert categories
                            clsubs.Addsubscriptions(emailsubstr, 1000, Convert.ToInt16(cb.ID));
                        }
                    }
                }

                //categories
                sbil.Append("<br/><b>Criteria set for Categories:</b><br/>");
                foreach (Control listite3 in CheckBoxList1.Controls)
                {
                    var cb1 = listite3 as CheckBox;
                    if (cb1 != null)
                    {
                        if (cb1.Checked == true)
                        {
                            sbil.Append(cb1.Text + "<br/>");
                            //insert categories
                            clsubs.Addsubscriptions(emailsubstr, 1001, Convert.ToInt16(cb1.ID));
                        }
                    }
                }

                sbil.Append("<br/><b>Criteria set for Contract Type:</b><br/>");
                //insert contract
                foreach (ListItem listitems2 in CheckBoxList3.Items)
                {
                    if (listitems2.Selected == true)
                    {
                        sbil.Append(listitems2.Text + "<br/>");
                        //insert cats
                        clsubs.Addsubscriptions(emailsubstr, 1002, Convert.ToInt16(listitems2.Value));
                    }
                }

                sbil.Append("<br/><b>Criteria set for Hours:</b><br/>");
                //insert hours
                foreach (ListItem listitems4 in CheckBoxList4.Items)
                {
                    if (listitems4.Selected == true)
                    {
                        sbil.Append(listitems4.Text + "<br/>");
                        clsubs.Addsubscriptions(emailsubstr, 1003, Convert.ToInt16(listitems4.Value));
                    }
                }

                //experience
                sbil.Append("<br/><b>Criteria set for Years of Experience:</b><br/>");
                foreach (ListItem listitems5 in CheckBoxList5.Items)
                {
                    if (listitems5.Selected == true)
                    {
                        sbil.Append(listitems5.Text + "<br/>");
                        clsubs.Addsubscriptions(emailsubstr, 1004, Convert.ToInt16(listitems5.Value));
                    }
                }

                sbil.Append("<br/><b>Criteria set for Salary:</b><br/>");
                //insert salary
                foreach (ListItem listitems6 in CheckBoxList6.Items)
                {
                    if (listitems6.Selected == true)
                    {
                        sbil.Append(listitems6.Text + "<br/>");
                        clsubs.Addsubscriptions(emailsubstr, 1005, Convert.ToInt16(listitems6.Value));
                    }
                }

                sbil.Append("<br/><b>Criteria set for PostCodes:</b><br/>");
                //insert postcodes
                var clm = new ClMemLoad();
                var alisi = (ArrayList)clm.Mcgetpostcodes();
                foreach (Control lipostcode in CheckBoxList8.Controls)
                {
                    var cxbxxbox = lipostcode as Button;
                    if (cxbxxbox != null)
                    {
                        var ixi = 1;
                        foreach (string si in alisi)
                        {
                            ixi++;
                            if (cxbxxbox.Text == si)
                            {
                                sbil.Append(cxbxxbox.Text + "<br/>");
                                clsubs.Addsubscriptions(emailsubstr, 1009, Convert.ToInt32(alisi[ixi - 1]));
                            }
                        }
                    }
                }

                sbil.Append("<br/><b>Criteria set for Sectors:</b><br/>");
                //insert postcodes
                foreach (Control lipostcode7 in CheckBoxList7.Controls)
                {
                    var cxbxxbox = lipostcode7 as CheckBox;
                    if (cxbxxbox != null)
                    {
                        if (cxbxxbox.Checked == true)
                        {
                            sbil.Append(cxbxxbox.Text + "<br/>");
                            clsubs.Addsubscriptions(emailsubstr, 1006, Convert.ToInt16(cxbxxbox.ID));
                        }
                    }
                }

                sbil.Append("<br/><b>Criteria set for Education:</b><br/>");
                //insert education
                foreach (ListItem lieducation in CheckBoxList9.Items)
                {
                    if (lieducation.Selected == true)
                    {
                        sbil.Append(lieducation.Text + "<br/>");
                        clsubs.Addsubscriptions(emailsubstr, 1008, Convert.ToInt16(lieducation.Value));
                    }
                }

                sbil.Append("<br/><b>Criteria set for CareerLevel:</b><br/>");
                //insert career level
                foreach (ListItem licareer in CheckBoxList10.Items)
                {
                    if (licareer.Selected == true)
                    {
                        sbil.Append(licareer.Text + "<br/>");
                        clsubs.Addsubscriptions(emailsubstr, 1007, Convert.ToInt16(licareer.Value));
                    }
                }

                //end adding jobs
                //sbil.Append("<br/><br/>Sincerely,<br/><br/>The fashionquadrant Team<br/><b></div><div style=\"color: #ccc; background-color: #333; padding: 2px 4px 2px 4px; border-color: GrayText; font-family: Lucida Grande, Helvetica, Arial, Verdana, sans-serif; font-size: 11px;\">Copyrights 2013 fashionquadrant</b>&nbsp;|&nbsp;Branding by a hr cloud<br/>Please do not reply to this auto generated message.We respect your privacy, to review our privacy policy visit <a style=\"color: #ccc; text-decoration: underline\" href=\"http://fashionquadrant.com/privacy\" >www.fashionquadrant.com/privacy</a>.If you need to contact us send us an email at:<a href=\"mailto:info@fashionquadrant.com\" style=\"color: #ccc; text-decoration: underline\">info@fashionquadrant.com</a>.If you don&#39;t want to receive these emails from fashionquadrant in the future or have your email address re-used, you can unsubscribe by sending an email with subject unsubscribe to:<a href=\"mailto:info@fashionquadrant.com\" style=\"color: #ccc; text-decoration: underline\">info@fashionquadrant.com</a></div></div></div>");
                //add the final list of email types

                int stype = Convert.ToInt16(RadioButtonList1.SelectedItem.Value);
                int spref = Convert.ToInt16(RadioButtonList2.SelectedItem.Value);

                clsubs.Addsubscriptionpref(emailsubstr, stype, spref);
                string _Ehead = "<div style=\"width:500px\"><div style=\"-moz-box-shadow: 3px 3px 4px #ccc; -webkit-box-shadow: 3px 3px 4px #ccc; box-shadow: 3px 3px 4px #ccc;-ms-filter: \"progid:DXImageTransform.Microsoft.Shadow(Strength=4, Direction=135, Color=\"#cccccc\")\";filter: progid:DXImageTransform.Microsoft.Shadow(Strength=4,Direction=135,Color=\"#cccccc\"); font-family: Helvetica, Verdana, sans-serif; margin: 10px 0px 0px 10px;\"><div style=\"background-color: #000; border-width: 1px; border-collapse: collapse; border-style: solid;\"><div style=\"color: #FFFFFF; min-height: 48px; background-color: #000; display: inline-block; vertical-align: middle;\"><img alt=\"fashion quadrant\" src=\"" + ConfigurationManager.AppSettings["httppaths"].ToString() + "/brandimages/brand_mail.png\"/></div><div style=\"border-color: #999; border-bottom-style: solid; border-width: 2px; border-top-style: solid; background-color: #666; padding: 10px 10px 10px 10px; color: #E6E6E6; font-size: 14px; min-height:300px;\"><span style=\"font-size:20px;\">";
                string _Ebody = "Dear User,</span><br/><br/>Thankyou for registering for job alerts!<br/><br/>";
                string _ECrit = sbil.ToString();
                string _Ebodyc = "<br/> You will be notified when a matching vacancy comes up. Best of luck!<br /><br />Sincerely,<br/><br/><b>Fashion Quadrant</b><br/><br/><br/><br/>";
                string _Ebodyd = "<span style=\"line-height:12px;font-size:11px;\"> NOTE: We will never ask you for any payment neither your credit or debit card numbers or any relating financial information via Email.</span> </div><div style=\"color:#ccc; background-color: #333; padding: 2px 4px 2px 4px; border-color: GrayText; line-height:12px; font-size: 11px;\">Copyrights 2013 Fashion Quadrant</b><br/>Please do not reply to this auto generated message. We respect your privacy, to review our privacy policy visit <a style=\"color: #ccc; text-decoration: none;\" href=\"http://fashionquadrant.com/privacy\" >www.fashionquadrant.com/privacy</a>. If you need to contact us send us an email at: <a href=\"mailto:info@fashionquadrant.com\" style=\"color: #ccc; text-decoration: underline\">info@fashionquadrant.com</a>.If you don&#39;t want to receive these emails from fashionquadrant in the future or have your email address re-used, you can unsubscribe by sending an email with subject unsubscribe to: <a href=\"mailto:info@fashionquadrant.com\" style=\"color: #ccc; text-decoration: underline\">info@fashionquadrant.com</a></div></div></div></div>";

                var clmail = new ClEmailProcessor();
                clmail.Sendmailproc(Emailsubs.Text, "Fashion Quadrant: Job Alert Signup!", _Ehead + _Ebody + _ECrit + _Ebodyc + _Ebodyd, 9);

                Session["reasons"] = "Thank you for registering for job alerts!";

                Response.Redirect("/confirm");
            }
        }

        protected void Evrem1(object sender, EventArgs e)
        {
            var bi = (Button)sender;
            CheckBoxList8.Controls.Remove(bi);
            var sview = ViewState["panctrlc1"].ToString();
            ViewState["panctrlc1"] = sview.Replace(bi.Text + ",", "");
        }

        protected void Dybtnclickb2(object sender, EventArgs e)
        {
            if (TextBoxAutopop.Text.Length > 0)
            {
                //clean textbox input
                var txinput = TextBoxAutopop.Text.Replace(",", "").ToUpper();

                //check in db
                var clm = new ClMemLoad();

                if (ViewState["panctrlc1"] == null)
                {
                    var li = new Button { ID = "dynamic1", Text = txinput, CssClass = "dynabuttoncss" };
                    li.Click += new EventHandler(Evrem1);
                    li.CausesValidation = false;
                    CheckBoxList8.Controls.Add(li);

                    var sb = new StringBuilder();
                    sb.Append(li.Text + ",");
                    ViewState["panctrlc1"] = sb.ToString();
                }

                else
                {
                    //first match with existing postcode list

                    CheckBoxList8.Controls.Clear();
                    var st = ViewState["panctrlc1"].ToString();
                    char[] tmpar = { ',' };
                    var starr = st.Split(tmpar, StringSplitOptions.RemoveEmptyEntries);
                    var sbtr = new StringBuilder();
                    var i = 1;

                    foreach (var itm in starr)
                    {
                        if (itm != ",")
                        {
                            i++;
                            var litm = new Button
                            {
                                ID = "dynamic" + i.ToString(CultureInfo.InvariantCulture),
                                Text = itm,
                                CssClass = "dynabuttoncss",
                                CausesValidation = false
                            };
                            litm.Click += new EventHandler(this.Evrem1);
                            CheckBoxList8.Controls.Add(litm);
                            sbtr.Append(litm.Text + ",");
                        }
                    }

                    var litm2 = new Button
                    {
                        ID = "dynamic" + (i + 1).ToString(CultureInfo.InvariantCulture),
                        Text = txinput,
                        CssClass = "dynabuttoncss",
                        CausesValidation = false
                    };
                    litm2.Click += new EventHandler(this.Evrem1);
                    CheckBoxList8.Controls.Add(litm2);
                    sbtr.Append(litm2.Text);

                    ViewState["panctrlc1"] = sbtr.ToString();
                }

                TextBoxAutopop.Text = "";
            }
        }
    }
}