using System;
using System.Text;
using System.Web.UI;
using Msftlayer;

namespace JB.Jobseekers
{
    public partial class Userapplication : ClCookie
    {
        private bool performchecks()
        {
            StringBuilder _sbr = new StringBuilder();

            bool flag = false;

            if (TextBox2.Text == "")
            {
                _sbr.Append("<b>First Name</b> is required!<br/>");
                flag = true;
            }

            if (TextBox3.Text == "")
            {
                _sbr.Append("<b>Last Name</b> is required!<br/>");
                flag = true;
            }

            if (TextBox4.Text == "")
            {
                _sbr.Append("<b>Address1</b> is required!<br/>");
                flag = true;
            }

            if (TextBox5.Text == "")
            {
                _sbr.Append("<b>Address2</b> is required!<br/>");
                flag = true;
            }

            if (TextBox6.Text == "")
            {
                _sbr.Append("<b>Address3</b> is required!<br/>");
                flag = true;
            }

            if (TextBox7.Text == "")
            {
                _sbr.Append("<b>Town Name</b> is required!<br/>");
                flag = true;
            }

            if (TextBox9.Text == "")
            {
                _sbr.Append("<b>Zipcode/Postcode</b> is required!<br/>");
                flag = true;
            }

            if (TextBox14.Text == "")
            {
                _sbr.Append("<b>Home phone number </b> is required!<br/>");
                flag = true;
            }

            if (TextBox15.Text == "")
            {
                _sbr.Append("<b>Mobile phone number </b> is required!<br/>");
                flag = true;
            }

            var _outstring = _sbr.ToString().TrimEnd('<', 'b', 'r', '/', '>');

            LabelNotify.Text = _outstring;

            return flag;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //set default inputs
            TextBox2.Focus();
            Page.Form.DefaultButton = Button2.UniqueID;

            if (!IsPostBack)
            {
                //request for login
                //read and validate login

                Isuserloginvalid();

                //load array for user details
                var clmpages = new ClMainPagePopulator();
                string[] arrs = clmpages.Getcandidatedetails(Session["pusername"].ToString());

                TextBox2.Text = arrs[0];
                TextBox3.Text = arrs[1];
                TextBox4.Text = arrs[2];
                TextBox5.Text = arrs[3];
                TextBox6.Text = arrs[4];
                TextBox7.Text = arrs[5];
                TextBox8.Text = arrs[6];
                CountrySelect.SelectedValue = arrs[7];
                TextBox9.Text = arrs[8];
                TextBox15.Text = arrs[10];
                TextBox14.Text = arrs[9];
            }
        }

        protected void Button2Click(object sender, EventArgs e)
        {
            if (performchecks() == false)
            {

                //update users table
                var ccan = new ClCandidates();

                //update candidates table
                ccan.Updatecandidatetable(TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text,
                                          TextBox7.Text, TextBox8.Text, CountrySelect.SelectedValue, TextBox9.Text,
                                          TextBox14.Text, TextBox15.Text, Session["pusername"].ToString());

                Session["reasons"] = "You have sucessfully updated your details";

                Response.Redirect("Canconfirm.aspx");
            }

        }

        protected void Button3Click(object sender, EventArgs e)
        {
            Response.Redirect("/jobseekers/home");
        }
    }
}