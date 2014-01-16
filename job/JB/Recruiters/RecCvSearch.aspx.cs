using System;
using Msftlayer;

namespace JB.Recruiters
{
    public partial class Reccvsearch : ClCookie
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //read and validate login

            Isuserloginvalid();
          
        }

        protected void ButtonsearchClick(object sender, EventArgs e)
        {
            var clword = new ClWordApp();
            GridViewResults1.DataSource = clword.Getcvsearchdoc(Server.HtmlEncode(TextBoxsearch.Text));
            GridViewResults1.DataBind();

            if (GridViewResults1.Rows.Count == 0)
            {
                LabelOutput.Text = "Sorry no results match that criteria, try again!";
            }

            else
            {
                LabelOutput.Text = "";
            }
        }
    }
}