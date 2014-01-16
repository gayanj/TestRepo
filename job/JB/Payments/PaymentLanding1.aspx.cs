using System;
using Msftlayer;

namespace JB.Payments
{
    public partial class Paymentlanding1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["xempid"] != null || Session["xactkey"] != null)
                {
                    //check employee id
                    var clcre = new ClCredits();
                    var qryempid = Session["xempid"].ToString();
                    var qryactkey = Session["xactkey"].ToString();
                    var confirmemid = clcre.Getcresessionkey(qryempid, qryactkey);
                    var cstartdt = DateTime.Now;
                    var cenddt = DateTime.Now.AddMonths(1);

                    Session.Remove("xempid");
                    Session.Remove("xactkey");

                    if (confirmemid != null)
                    {
                        var qrytempid = clcre.Getcrejobposting(qryempid);

                        switch (qrytempid)
                        {
                            case 0:
                                clcre.Insertcreditjobposting(qryempid, 10, cstartdt, cenddt);
                                Label1.Text = "Payment completed sucessfully!";
                                break;
                            default:
                                clcre.Updatecreditjobposting(qryempid, cstartdt, cenddt);
                                Label1.Text = "Payment completed sucessfully!";
                                break;
                        }
                    }
                }
            }
        }
    }
}