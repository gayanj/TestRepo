using System;
using Msftlayer;

namespace JB.Jobseekers
{
    public partial class Candidateaudit : ClCookie
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            Isuserloginvalid();
            

            if (Session["pusername"] != null)
            {
                var clarch = new ClArchive();
                GridView1.DataSource = clarch.Getacsecuritycan(Session["pusername"].ToString());
                GridView1.DataBind();
            }
        }
    }
}