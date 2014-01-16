using System;
using System.Globalization;
using System.Web.UI;
using Msftlayer;

namespace JB.SalaryCalc
{
    public partial class SalaryQuestions : System.Web.UI.Page
    {

        private int RequestCheck()
        {
            if (TextBox1.Text == "")
            {
                LabelNotify.Text = "Please fill your previous company in question 7 or put <b> Newbie </b> if you are making a fresh start in industry!";
                return 1;
            }

            else if (TextBox4.Text == "")
            {
                LabelNotify.Text = "Please fill in your prefered employer in question 8";
                return 1;
            }

            else
            {
                return 0;
            }
        }

        protected void Button1Click(object sender, EventArgs e)
        {
            var rq = RequestCheck();


            if (rq == 0)
            {
                //add this to db.
                var salc = new ClSalaryCalc();
                var selectedoccupation = string.Empty;
                var educountry = string.Empty;

                //set occupation list
                selectedoccupation = Occupationlist.SelectedValue != "" ? Occupationlist.SelectedItem.Text : TextBox3.Text;

                //set the eu option
                educountry = Educationcountry.SelectedValue != "" ? Educationcountry.SelectedItem.Value : TextBox2.Text;

                //set client ips
                var csip = Request.ServerVariables["REMOTE_ADDR"].ToString(CultureInfo.InvariantCulture);

                //now add to db
                salc.Addsal(selectedoccupation, Convert.ToInt16(positionoffer.SelectedItem.Value), Convert.ToDouble(SalaryRange.SelectedItem.Value), Convert.ToInt16(Experienceyears.SelectedItem.Value), HighestEducation.SelectedItem.Value, educountry, csip, TextBox1.Text, TextBox4.Text);

                //refresh memory
                salc.Refreshsalaries();

                Response.Redirect("/salarycalc/salaryresult.aspx");
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //set default inputs
            Page.Form.DefaultButton = Button1.UniqueID;

            if (!IsPostBack)
            {
                var scalc = new ClSalaryCalc();
                Occupationlist.DataSource = scalc.GetSalarys();
                Occupationlist.DataTextField = "occupationname";
                Occupationlist.DataValueField = "occupationname";
                Occupationlist.DataBind();
            }
        }
    }
}