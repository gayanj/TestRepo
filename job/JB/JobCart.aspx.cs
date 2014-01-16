using System;
using System.Text;
using System.Web;
using System.Web.UI.WebControls;
using Msftlayer;

namespace JB
{
    public partial class Jobcart : System.Web.UI.Page
    {
        //you can use this page to apply to multiple jobs
        //try setting a url link and then if request.querystring = 1
        //loop through jobs on applications page.
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["isrecruiter"] != null)
            {
                if ((Boolean)Session["isrecruiter"] != true)
                {
                }

                else
                {
                    Session["reasons"] = "You cannot apply to a job as recruiter, please logout and then try again!";
                    Response.Redirect("confirm.aspx");
                }
            }

            Loadcart();
        }

        private void Loadcart()
        {
            var jobcart = Readcookies("jobcart");

            //chxbxlist1.Items.Clear();

            if (jobcart != null)
            {
                try
                {
                    string[] splitonchar = { "," };
                    var jobcartsplitter = jobcart.Split(splitonchar, StringSplitOptions.RemoveEmptyEntries);

                    //get jobs from db
                    var clcart = new ClJobCart();

                    foreach (var si in jobcartsplitter)
                    {
                        var li = new HyperLink
                                     {
                                         ID = "chk" + si,
                                         Text = clcart.Getjobscart(si),
                                         NavigateUrl = "#"
                                     };
                        jbdynapanel.CssClass = "ft_black";
                        jbdynapanel.Controls.Add(li);

                        var btn1 = new Button { ID = "btn" + si, Text = "Apply", CssClass = "button" };
                        btn1.Click += new EventHandler(BtnapplyClick);

                        var btn2 = new Button { ID = "btnremv" + si, Text = "Remove", CssClass = "button" };
                        btn2.Click += new EventHandler(Btnremove1Click);

                        var lit = new Literal { Text = "<br />", ID = "Elit" + si };

                        jbdynapanel.Controls.Add(li);
                        jbdynapanel.Controls.Add(btn1);
                        jbdynapanel.Controls.Add(btn2);
                        jbdynapanel.Controls.Add(lit);
                    }

                    Panelmessage.Visible = false;
                    jbcartpanel.Visible = true;
                }
                catch { }
            }

            //empty cart
            else
            {
                Panelmessage.Visible = true;
                jbcartpanel.Visible = false;
            }
        }

        private string Readcookies(string cookieName)
        {
            var myCookie = new HttpCookie(cookieName);
            myCookie = Request.Cookies[cookieName];

            // Read the cookie information and return it.
            if (myCookie != null)
                return myCookie.Value;
            else
                return null;
        }

        protected void JbClearClick(object sender, EventArgs e)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "scriptrg4", "<script type=\"text/javascript\">clearjobbasket();</script>");
            jbdynapanel.Controls.Clear();
            jbcartpanel.Visible = false;
            Panelmessage.Visible = true;
        }

        //update cookie
        private void Updatecookies(string cval)
        {
            //remove item from cookie
            var jobcart = Readcookies("jobcart");

            var sb = new StringBuilder();

            if (jobcart != null)
            {
                string[] splitonchar = { "," };
                var jobcartsplitter = jobcart.Split(splitonchar, StringSplitOptions.RemoveEmptyEntries);

                //get jobs from db
                //Cljobcart clcart = new Cljobcart();

                for (var index = 0; index < jobcartsplitter.Length; index++)
                {
                    var si = jobcartsplitter[index];
                    if (si != cval)
                    {
                        sb.Append(si + ",");
                    }
                }
            }

            //rewrite cookie

            switch (sb.ToString())
            {
                case "":
                    ClientScript.RegisterStartupScript(this.GetType(), "scriptrg6", "<script type=\"text/javascript\">clearjobbasket();</script>");
                    break;
                default:
                    string cleansb = sb.ToString().TrimEnd(',');
                    ClientScript.RegisterStartupScript(this.GetType(), "scriptrg5", "<script type=\"text/javascript\">createCookie('jobcart','" + cleansb + "',10);</script>");
                    break;
            }
        }

        protected void BtnapplyClick(object sender, EventArgs e)
        {
            var bt = (Button)sender;
            var jid = bt.ID.Replace("btn", "");

            Updatecookies(jid);

            Response.Redirect("Applications.aspx?jobid=" + jid);
        }

        protected void Btnremove1Click(object sender, EventArgs e)
        {
            //remove item from list.
            var bt = (Button)sender;
            var jid = bt.ID.Replace("btnremv", "");

            var hl = (HyperLink)jbdynapanel.FindControl("chk" + jid);
            var bt1 = (Button)jbdynapanel.FindControl("btn" + jid);
            var lit = (Literal)jbdynapanel.FindControl("Elit" + jid);

            jbdynapanel.Controls.Remove(hl);
            jbdynapanel.Controls.Remove(bt1);
            jbdynapanel.Controls.Remove(bt);
            jbdynapanel.Controls.Remove(lit);

            Updatecookies(jid);

            //remove from cookie
        }
    }
}