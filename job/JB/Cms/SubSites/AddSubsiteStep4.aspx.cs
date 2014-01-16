using System;
using System.Web.UI.WebControls;
using Msftlayer;
using System.Collections;
using minGuid;

namespace JB.Cms.Subsites
{
    public partial class AddSubsiteStep4 : System.Web.UI.Page
    {
        private void GetCategoryTabs()
        {
            PanelParentCategories.Controls.Clear();

            var sid = new ClSubsite();
            var siteid = 0;

            if (Request.QueryString["siteid"] != null)
            {
               siteid = Convert.ToInt32(Server.HtmlEncode(Request.QueryString["siteid"]));
            }

            ArrayList al = sid.GetSubsiteCatListView(siteid);

            if (al != null)
            {
                for (int s = 0; s < al.Count; s += 2)
                {
                    Button b1 = new Button();
                    b1.Text = al[s + 1].ToString();
                    b1.ID = al[s + 1].ToString() + al[s];
                    b1.CssClass = "dynabuttoncss";
                    b1.Click += new EventHandler(RemoveCategoryTabs);
                    PanelParentCategories.Controls.Add(b1);
                }
            }
        }

        private void GetSubCategoryTabs(int catid)
        {
            PanelSubCategories.Controls.Clear();

            var sid = new ClSubsite();
            var siteid = 0;

            if (Request.QueryString["siteid"] != null)
            {
                siteid = Convert.ToInt32(Server.HtmlEncode(Request.QueryString["siteid"]));
            }

            ArrayList al = sid.GetSubsiteSubCatListView(siteid, catid);

            if (al != null)
            {
                for (int s = 0; s < al.Count; s += 2)
                {
                    Button b2 = new Button();
                    b2.Text = al[s + 1].ToString();
                    b2.ID = al[s + 1].ToString() + al[s];
                    b2.CssClass = "dynabuttoncss";
                    b2.Click += new EventHandler(RemoveSubCategoryTabs);
                    PanelSubCategories.Controls.Add(b2);
                }
            }
        }

        protected void RemoveCategoryTabs(object sender, EventArgs e)
        {
            Button b1 = (Button)sender;
            var catid = Convert.ToInt32(b1.ID.Replace(b1.Text, ""));
            var siteid = 0;

            if (Request.QueryString["siteid"] != null)
            {
               siteid =  Convert.ToInt32(Server.HtmlEncode(Request.QueryString["siteid"]));
            }

            //check if subcat exists if yes prompt for deleting that first.

            var sid = new ClSubsite();
            sid.DeleteSubsiteCat(siteid, catid);

            GetCategoryTabs();
        }

        protected void RemoveSubCategoryTabs(object sender, EventArgs e)
        {
            Button b2 = (Button)sender;
            var subcatid = Convert.ToInt32(b2.ID.Replace(b2.Text, ""));
            var siteid = 0;

            if (Request.QueryString["siteid"] != null)
            {
               siteid = Convert.ToInt32(Server.HtmlEncode(Request.QueryString["siteid"]));
            }

            var catid = Convert.ToInt32(DropDownListPreview.SelectedValue);

            var sid = new ClSubsite();
            sid.DeleteSubsiteSubCat(siteid, subcatid, catid);

            GetCategoryTabs();
            GetSubCategoryTabs(catid);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClSubsite sid = new ClSubsite();
                var siteid = 0;

                if (Request.QueryString["siteid"] != null)
                {
                   siteid = Convert.ToInt32(Server.HtmlEncode(Request.QueryString["siteid"]));
                }

                DropDownCategory.DataSource = sid.GetSubsiteCat(siteid);
                DropDownCategory.DataTextField = "scategoryname";
                DropDownCategory.DataValueField = "scatid";
                DropDownCategory.DataBind();

                //get data for preview panel
                DropDownListPreview.DataSource = sid.GetSubsiteCat(siteid);
                DropDownListPreview.DataTextField = "scategoryname";
                DropDownListPreview.DataValueField = "scatid";
                DropDownListPreview.DataBind();

                GetCategoryTabs();

                //handle empyty values to make list look good.
                if (DropDownListPreview.SelectedValue.Length > 0)
                {
                    int catid = Convert.ToInt32(DropDownListPreview.SelectedValue);
                    GetSubCategoryTabs(catid);
                }

                else
                {
                    ListItem li = new ListItem();
                    li.Text = "None";
                    li.Value = "-1";
                    DropDownListPreview.Items.Add(li);
                }

                if (DropDownCategory.SelectedValue.Length <= 0)
                {
                    ListItem lit = new ListItem();
                    lit.Text = "None";
                    lit.Value = "-1";
                    DropDownCategory.Items.Add(lit);
                }

            }
        }

        protected void SaveAction_Click(object sender, EventArgs e)
        {
            var siteid = 0;

            if (Request.QueryString["siteid"] != null)
            {
              siteid =  Convert.ToInt32(Server.HtmlEncode(Request.QueryString["siteid"]));
            }

            Response.Redirect("AddSubsiteStep5.aspx?siteid=" + siteid);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //add category
            ClSubsite sid = new ClSubsite();
            var siteid = 0;

            if (Request.QueryString["siteid"] != null)
            {
            siteid =  Convert.ToInt32(Server.HtmlEncode(Request.QueryString["siteid"]));
            }

            sid.InsertSubsiteCat(Server.HtmlEncode(TextCategory.Text), siteid);

            //update list
            DropDownCategory.DataSource = sid.GetSubsiteCat(siteid);
            DropDownCategory.DataTextField = "scategoryname";
            DropDownCategory.DataValueField = "scatid";
            DropDownCategory.DataBind();

            //get data for preview panel
            DropDownListPreview.DataSource = sid.GetSubsiteCat(siteid);
            DropDownListPreview.DataTextField = "scategoryname";
            DropDownListPreview.DataValueField = "scatid";
            DropDownListPreview.DataBind();

            //refresh previews
            GetCategoryTabs();

            //clear text
            TextCategory.Text = "";

        }

        protected void ButtonSubcat_Click(object sender, EventArgs e)
        {
            var sid = new ClSubsite();

            //add sub categories
            var catid = Convert.ToInt32(DropDownCategory.SelectedValue);
            var subcatname = Server.HtmlEncode(TextSubCategory.Text);

            var mgui = new Minimumguid();

            var subcatid = mgui.MinGuid();

            //insert into linked table
            sid.InsertSubsiteCatLinks(catid, subcatid);

            //insert subcategory table
            sid.InsertSubsiteSubcat(subcatid, subcatname);

            //refresh previews
            GetCategoryTabs();
            GetSubCategoryTabs(catid);

            //clear text
            TextSubCategory.Text = "";
        }

        protected void DropDownListPreview_SelectedIndexChanged(object sender, EventArgs e)
        {
            int catid = Convert.ToInt32(DropDownListPreview.SelectedValue);

            GetCategoryTabs();
            GetSubCategoryTabs(catid);
        }

    }
}