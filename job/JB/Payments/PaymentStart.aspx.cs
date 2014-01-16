using System;
using System.Globalization;
using System.Web.UI;
using Msftlayer;

namespace JB.Payments
{
    public partial class Paymentstart : System.Web.UI.Page
    {
        private void Parsepayment()
        {
            var tmpempid = Server.HtmlEncode(Request.QueryString["empid"]);
            var tmpactkey = Session["xactkey"].ToString();
            //DateTime tmpstartdate = DateTime.Now;
            //DateTime tmpenddate = DateTime.Now.AddDays(-1);

            Session["xempid"] = tmpempid;
            Session["payment_amt"] = 10;

            var clcre = new ClCredits();
            clcre.Insertcresessionkey(tmpempid, tmpactkey);
        }

        private bool ProcessNotification()
        {
            bool __flag = false;

            if (Textfirstname.Text == "")
            {
                LabelNotify.Text = "First Name is required"; __flag = true; return __flag;
            }

            else if (Textlastname.Text == "")
            {
                LabelNotify.Text = "Last Name is required"; __flag = true; return __flag;
            }

            else if (Textaddress1.Text == "")
            {
                LabelNotify.Text = "Address1 is required"; __flag = true; return __flag;
            }

            else if (Textaddress2.Text == "")
            {
                LabelNotify.Text = "Address2 is required"; __flag = true; return __flag;
            }

            else if (Textaddress3.Text == "")
            {
                LabelNotify.Text = "Address3 is required"; __flag = true; return __flag;
            }

            else if (Textcity.Text == "")
            {
                LabelNotify.Text = "City is required"; __flag = true; return __flag;
            }

            else if (Textcounty.Text == "")
            {
                LabelNotify.Text = "County is required"; __flag = true; return __flag;
            }

            else if (Textpostcode.Text == "")
            {
                LabelNotify.Text = "Postcode is required"; __flag = true; return __flag;
            }

            else if (TextBoxcnumber.Text == "")
            {
                LabelNotify.Text = "Credit Card Number is required!"; __flag = true; return __flag;
            }

            else if (TextBoxcvv.Text == "")
            {
                LabelNotify.Text = "Please enter credit card security code"; __flag = true; return __flag;
            }

            else
            {
                return false;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //parsepayment();
            //Response.Redirect("Paymentlanding1.aspx");

            if (!Request.IsSecureConnection)
            {
                Response.Redirect(System.Configuration.ConfigurationManager.AppSettings["httpspaths"].ToString(CultureInfo.InvariantCulture));
            }

            else
            {
                switch (Request.QueryString["empid"])
                {
                    case null:
                        Session["reasons"] = "Sorry, you must have an account to use this service!";
                        Response.Redirect("/confirm.aspx");
                        break;
                }
            }
        }

        protected void ImageButton1Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Paymentlanding1.aspx");
        }

        protected void Button1Click(object sender, EventArgs e)
        {

            if (ProcessNotification() == false)
            {

                //add to db
                var clc = new ClCcPay();
                clc.Insertcarddata(Request.QueryString["empid"], string.Empty, Server.HtmlEncode(Textfirstname.Text).Trim(), Server.HtmlEncode(Textlastname.Text).Trim(), Server.HtmlEncode(Textaddress1.Text).Trim(), Server.HtmlEncode(Textaddress2.Text).Trim(), Server.HtmlEncode(Textaddress3.Text).Trim(), Server.HtmlEncode(Textcity.Text).Trim(), Server.HtmlEncode(Textcounty.Text).Trim(), Server.HtmlEncode(Textpostcode.Text).Trim(), DropDownCountry.SelectedValue, DropDownctype.SelectedValue, Convert.ToInt16(DropDownOrders.SelectedValue));

                switch (DropDownCountry.SelectedValue)
                {
                    case "US":
                    case "GB":
                    case "DE":
                        {
                            //set amt
                            string payamt;

                            switch (DropDownOrders.SelectedValue)
                            {
                                case "100":
                                    payamt = "399";
                                    break;
                                case "101":
                                    payamt = "499";
                                    break;
                                case "102":
                                    payamt = "599";
                                    break;
                                case "103":
                                    payamt = "299";
                                    break;
                                case "104":
                                    payamt = "199";
                                    break;
                                default:
                                    {
                                        //promo
                                        string promo = TextBoxPromo.Text;
                                        promo = promo.Replace("MK202", "");
                                        payamt = promo;
                                    }
                                    break;
                            }

                            const string merchantsessionid = "KUUQP28SBQF2W";
                            const string ausername = "moeen.khurshid_api1.data-it.co.uk";
                            const string auserpwd = "CFCALHPQUZ2ATBHC";
                            const string ausersign = "AFcWxV21C7fd0v3bYYYRCpSSRl31Ag1g.I18qakpt9ozztu1Qg0sJ1Hs";
                            const string auserenv = "live";

                            var ddop = new ClDoDirectPayment();
                            var responses = ddop.DoDirectPaymentCode(payamt, Server.HtmlEncode(Textfirstname.Text.Trim()), Server.HtmlEncode(Textlastname.Text.Trim()), Server.HtmlEncode(Textaddress1.Text.Trim()), Server.HtmlEncode(Textaddress2.Text.Trim()), Server.HtmlEncode(Textcity.Text.Trim()), Server.HtmlEncode(Textcounty.Text.Trim()), Server.HtmlEncode(Textpostcode.Text.Trim()), DropDownctype.SelectedValue, Server.HtmlEncode(TextBoxcnumber.Text.Trim()), Server.HtmlEncode(TextBoxcvv.Text.Trim()), Convert.ToInt16(DropDownMonth.SelectedValue), Convert.ToInt16(DropDownYear.SelectedValue), ausername, auserpwd, ausersign, auserenv, Request.ServerVariables["REMOTE_ADDR"].ToString(CultureInfo.InvariantCulture), merchantsessionid, DropDownCountry.SelectedValue);

                            switch (responses)
                            {
                                case "Success":
                                    Parsepayment();
                                    Response.Redirect("Paymentlanding1.aspx");
                                    break;
                                default:
                                    Session.Remove("xactkey");
                                    Session.Remove("xempid");
                                    Session["reasons"] = "We cannot authorize your payment please contact us by phone on +92 335 0772714!";
                                    Response.Redirect("/confirm.aspx");
                                    break;
                            }
                        }
                        break;
                    default:
                        Session["reasons"] = "We cannot authorize your payment please contact us by phone on +92 307 8756455!";
                        Response.Redirect("/confirm.aspx");
                        break;
                }
            }
        }
    }
}