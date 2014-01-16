using System;
using Msftlayer;

namespace JB.Recruiters
{
    public partial class Rechome : ClCookie
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //read and validate login

            Isuserloginvalid();

            //if (Session["cuserval"] != null)
            //{
            //    if (Session["cuserval"].ToString() == Readjobcookie())
            //    {
            //    }
            //    else
            //    {
            //        Response.Redirect("/recruiters/Login");
            //    }
            //}

            //else
            //{
            //    Response.Redirect("/recruiters/Login");
            //}
            ////////////////////////////////////

            //set zoom levels for all charts
            int xzoom = Convert.ToInt32(zoomer.SelectedItem.Value);

            Chart1.Width = xzoom;
            jobapps.Width = xzoom;
            jobpostedview.Width = xzoom;

            //get recruiter id
            var clmpop = new ClMainPagePopulator();
            string rectempid = clmpop.Getrecname(Session["pusername"].ToString());

            //get jobviews
            var cljview = new ClJobViewData();

            Chart1.DataSource = cljview.Getjobviewdata(rectempid);
            Chart1.Series["Series1"].YValueMembers = "jobviews";
            Chart1.Series["Series1"].XValueMember = "dateviewed";
            Chart1.DataBind();

            if (Chart1.Series[0].Points.Count == 0)
            {
                var annotation = new System.Web.UI.DataVisualization.Charting.TextAnnotation
                                     {
                                         Text = "No data for this period",
                                         X = 5,
                                         Y = 5,
                                         Font = new System.Drawing.Font("Arial", 12),
                                         ForeColor = System.Drawing.Color.Crimson
                                     };
                Chart1.Annotations.Add(annotation);
            }

            //get applications made
            jobapps.DataSource = cljview.Getappviewdata(rectempid);
            jobapps.Series["Series1"].YValueMembers = "jobviews";
            jobapps.Series["Series1"].XValueMember = "dateviewed";
            jobapps.DataBind();

            if (jobapps.Series[0].Points.Count == 0)
            {
                var annotation = new System.Web.UI.DataVisualization.Charting.TextAnnotation
                                     {
                                         Text = "No data for this period",
                                         X = 5,
                                         Y = 5,
                                         Font = new System.Drawing.Font("Arial", 12),
                                         ForeColor = System.Drawing.Color.Crimson
                                     };
                jobapps.Annotations.Add(annotation);
            }

            //get posted jobs
            jobpostedview.DataSource = cljview.Getpjjobviewdata(rectempid);
            jobpostedview.Series["Series1"].YValueMembers = "jobviews";
            jobpostedview.Series["Series1"].XValueMember = "dateviewed";
            jobpostedview.DataBind();

            if (jobpostedview.Series[0].Points.Count == 0)
            {
                var annotation = new System.Web.UI.DataVisualization.Charting.TextAnnotation
                                     {
                                         Text = "No data for this period",
                                         X = 5,
                                         Y = 5,
                                         Font = new System.Drawing.Font("Arial", 12),
                                         ForeColor = System.Drawing.Color.Crimson
                                     };
                jobpostedview.Annotations.Add(annotation);
            }
        }
    }
}