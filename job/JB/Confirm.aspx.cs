using System;

namespace JB
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
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
        }
    }
}