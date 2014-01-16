using System;
using System.Web.UI.WebControls;
using Msftlayer;

namespace JB.Sitemaps
{
    public partial class Jbsitemap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var clsite = new ClSiteMap();
            var al = clsite.Getsitemapitems();

            for (var i = 0; i < al.Count; i += 3)
            {
                var p = new Panel();

                switch (al[i + 2].ToString())
                {
                    case "1":
                        {
                            var lit21 = new Literal { Text = "<br />" };
                            p.Controls.Add(lit21);

                            var hl = new HyperLink { Text = al[i + 1].ToString(), NavigateUrl = al[i].ToString(), CssClass = "smap_lefts" };
                            p.Controls.Add(hl);

                            var lit = new Literal
                                          {
                                              Text =
                                                  "<div class=\"dv_fix\"></div><div class=\"tb_headone\"></div><div class=\"dv_fix\"></div><div class=\"ln_444\"></div><div class=\"dv_fix\"></div>"
                                          };
                            p.Controls.Add(lit);
                        }
                        break;
                }

                switch (al[i + 2].ToString())
                {
                    case "2":
                        {
                            var hl1 = new HyperLink
                                          {
                                              Text = al[i + 1].ToString(),
                                              NavigateUrl = al[i].ToString(),
                                              CssClass = "smap_left20"
                                          };
                            hl1.Attributes.Add("onmouseover", "this.className='smap_leftnu20'");
                            hl1.Attributes.Add("onmouseout", "this.className='smap_left20'");
                            p.Controls.Add(hl1);
                        }
                        break;
                }

                switch (al[i + 2].ToString())
                {
                    case "3":
                        {
                            var hl2 = new HyperLink
                                          {
                                              Text = al[i + 1].ToString(),
                                              NavigateUrl = al[i].ToString(),
                                              CssClass = "smap_left30"
                                          };
                            hl2.Attributes.Add("onmouseover", "this.className='smap_leftnu30'");
                            hl2.Attributes.Add("onmouseout", "this.className='smap_left30'");
                            p.Controls.Add(hl2);
                        }
                        break;
                }

                PlaceHolder1.Controls.Add(p);
            }
        }
    }
}