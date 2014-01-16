using System;
using System.Globalization;
using System.Web.UI.WebControls;
using Msftlayer;

namespace JB
{
    public partial class Jbwebsitewidget : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.IsSecureConnection)
            {
                Response.Redirect(System.Configuration.ConfigurationManager.AppSettings["httppaths"].ToString(CultureInfo.InvariantCulture) + "/websitewidget");
            }
        }

        private int RequestCheck()
        {
            if (TextBox2.Text == "")
            {
                LabelNotify.Text = "Company name is required!";
                return 1;
            }

            else if (TextBox3.Text == "")
            {
                LabelNotify.Text = "Company's core business is required!";
                return 1;
            }

            else if (TextBox4.Text == "")
            {
                LabelNotify.Text = "FirstName is required!";
                return 1;
            }

            else if (TextBox5.Text == "")
            {
                LabelNotify.Text = "LastName is required!";
                return 1;
            }

            else if (TextBox6.Text == "")
            {
                LabelNotify.Text = "Telephone is required!";
                return 1;
            }

            else if (TextBox7.Text == "")
            {
                LabelNotify.Text = "Your website URL is required!";
                return 1;
            }

            else
            {
                LabelNotify.Text = "";
                return 0;
            }

        }

        protected void Button1Click(object sender, EventArgs e)
        {
            //check entries
            var rq = RequestCheck();

            if (rq == 0)
            {
                //log entry to db
                var clw = new ClWidgetLog();
                clw.Insertcompwbj(Server.HtmlEncode(TextBox2.Text), Server.HtmlEncode(TextBox3.Text), Server.HtmlEncode(TextBox4.Text), Server.HtmlEncode(TextBox5.Text), Server.HtmlEncode(TextBox6.Text), Server.HtmlEncode(TextBox7.Text));

                //get the widget
                Paneljbdtpreview.Controls.Clear();
                var li = new Literal
                             {
                                 Text =
                                     "<div class=\"jbwebsiteleftbar\"></div><div class=\"dvleft\"><div class=\"ft_black\">Preview of Job widget</div><br /><iframe src=\"/v1/jobx?theme=" +
                                     DropDownList1.SelectedValue +
                                     "\" frameborder=\"0\" width=\"300px\" height=\"280px\"></iframe><hr/>Widget Code:<br /><br /><div class=\"ft_black\">"
                             };
                Paneljbdtpreview.Controls.Add(li);

                var tb = new Label
                             {
                                 ID = "tbox1",
                                 Width = 300,
                                 Text =
                                     Server.HtmlEncode(
                                         "<!-- begin copy --> <iframe src=\"/v1/jobx?theme=" +
                                         DropDownList1.SelectedValue +
                                         "\" frameborder=\"0\" width=\"200px\" height=\"300px\"></iframe> <!-- end copy -->") +
                                     "</div></div>"
                             };
                Paneljbdtpreview.Controls.Add(tb);

                Paneljbdtpreview.Visible = true;
            }
        }
    }
}