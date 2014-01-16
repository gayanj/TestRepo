using System;

namespace JB.Payments
{
    public partial class Confirm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            reasonforwarded.Text = "Confirmation";
            try
            {
                textreason.Text = Session["reasons"].ToString();
            }
            catch (Exception ed)
            {
                Console.Write(ed.Message);
            }
        }
    }
}