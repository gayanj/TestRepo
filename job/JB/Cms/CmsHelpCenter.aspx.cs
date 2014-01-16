using System;

namespace JB.Cms
{
    public partial class Cmshelpcenter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.QueryString["type"]!=null)
            {
               
                    if (Request.QueryString["type"] == "q")
                    {
                        Labelheaddetail.Text = "Help Questions";
                    }

                    else if (Request.QueryString["type"] == "a")
                    {
                        Labelheaddetail.Text = "Help Answers";
                    }

                    else
                    {
                        Labelheaddetail.Text = "Help Categories";
                    }
                
            }
        }
    }
}