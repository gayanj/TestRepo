using System;
using System.Web.UI.WebControls;
using Msftlayer;
using System.Collections;

namespace JB.Jobseekers.ResumeBuilder
{
    public partial class ResSkills : ClCookie
    {
        private void RefreshSkillCloud()
        {
            var priv = new ClPrivacy();
            var canid = priv.Getcandidattesid(Session["pusername"].ToString());

            var clb = new ClResumeBuilder();
            ArrayList al = clb.GetSkills(canid);

            if (al != null)
            {
                for (int i = 0; i < al.Count; i += 2)
                {
                    Button bt = new Button();
                    bt.ID = al[i].ToString();
                    bt.Text = al[i + 1].ToString();
                    bt.CausesValidation = false;
                    bt.CssClass = "dynabuttoncss";
                    bt.Click += new EventHandler(RemoveButton);
                    PanelSkills.Controls.Add(bt);
                }
            }
        }

        protected void RemoveButton(object sender, EventArgs e)
        {
            //get can id
            var priv = new ClPrivacy();
            var canid = priv.Getcandidattesid(Session["pusername"].ToString());

            //remove from the database
            ClResumeBuilder clb = new ClResumeBuilder();

            Button btn = (Button)sender;
            var skillid = Convert.ToInt32(btn.ID.Replace(btn.Text, ""));
            clb.DeleteSkills(Server.HtmlEncode(btn.Text), skillid, canid);

            //remove from ui
            PanelSkills.Controls.Remove(btn);
            //PanelSkills.Controls.Clear();
            //RefreshSkillCloud();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Isuserloginvalid();

            ResSkill.Focus();
            Page.Form.DefaultButton = ButtonAdd.UniqueID;

            RefreshSkillCloud();
        }

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            //add to the skill cloud and db
            var priv = new ClPrivacy();
            var canid = priv.Getcandidattesid(Session["pusername"].ToString());

            ClResumeBuilder clb = new ClResumeBuilder();
            //check if skill exits in db

            bool skillexist = clb.SearchSkills(Server.HtmlEncode(ResSkill.Text), canid);

            if (skillexist != true)
            {
                clb.InsertSkills(Server.HtmlEncode(ResSkill.Text), Convert.ToInt16(RadioButtonList1.SelectedValue), canid);

                //refresh cloud     
                PanelSkills.Controls.Clear();
                RefreshSkillCloud();
            }
        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            Response.Redirect("Resreference.aspx");
        }
    }
}