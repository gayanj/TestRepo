using System;
using Msftlayer;

namespace JB.Recruiters
{
    public partial class Recconfirm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ir"] != null)
            {
                //update jobs here
                var chome = new ClHome();
                chome.Reloadgethpindustry();
                chome.Reloadgethplocation();
                chome.Reloadgethpsalary();

                //update browse control
                var csrch = new ClSearchFilters();
                csrch.Reloadsearchbrall();

                //update recuiters
                var crecs = new ClRecruiters();
                crecs.Reloadallrecwithjobs();

                //update all results for jobgrid
                //just add a key in case there is  a problem
                //don't need to push all data
                csrch.Reloadgettballsrchval();

                //reload jobstable
                var cscls = new ClSearchMain();
                cscls.Reloadmcjobstable();

                //reload autocomplete
                var clauto = new CLAutoComplete();
                clauto.Reloadgetsearchjobcp();

                Session["ir"] = null;
            }
            //

            if (Session["rx"] != null)
            {
                //reload autocomplete
                var clauto = new CLAutoComplete();
                clauto.Reloadgetsearchreccp();

                //update recuiters
                var crecs = new ClRecruiters();
                crecs.Reloadallrecwithjobs();

                Session["rx"] = null;
            }

            try
            {
                textreason.Text = Session["reasons"].ToString();
            }
            catch (Exception er)
            {
                Console.Write(er.Message);
            }
        }
    }
}