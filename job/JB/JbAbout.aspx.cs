﻿using System;
using System.Globalization;

namespace JB
{
    public partial class Jbabout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.IsSecureConnection)
            {
                Response.Redirect(System.Configuration.ConfigurationManager.AppSettings["httppaths"].ToString(CultureInfo.InvariantCulture) + "/about");
            }
        }
    }
}