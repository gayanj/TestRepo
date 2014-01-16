using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Msftlayer;
using minGuid;

namespace JB.UserControls
{
    public partial class Captcha : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Random _r = new Random();
            Minimumguid _p = new Minimumguid();

            // get 1st random string
            int Rand1 = _r.Next(4, 9);

            string Rand2 = _p.MinGuid();

            string Rand3 = Rand2.Substring(0, Rand1 + 1);

            // create full rand string
            string Texter = "/captcha.aspx?ranstr=" + Rand3;

            ImageCap.ImageUrl = Texter.Trim().ToUpperInvariant();
        }
    }
}