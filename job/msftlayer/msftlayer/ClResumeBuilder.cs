using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Memorylayer;
using System.Data;
using System.Collections;
using System.Text.RegularExpressions;

namespace Msftlayer
{
    public class ClResumeBuilder
    {
        //education
        public void InsertEducation(string licandidateid, string school_name, string degree_earned, string start_date, string end_date, string description)
        {
            MlResumeBuilder clb = new MlResumeBuilder();
            clb.InsertEducation(licandidateid, school_name, degree_earned, start_date, end_date, description);
        }

        public void UpdateEducation(int educationid, string school_name, string degree_earned, string start_date, string end_date, string description)
        {
            MlResumeBuilder mlb = new MlResumeBuilder();
            mlb.UpdateEducation(educationid, school_name, degree_earned, start_date, end_date, description);
        }

        public void DeleteEducation(string licandidateid)
        {
            MlResumeBuilder mlb = new MlResumeBuilder();
            mlb.DeleteEducation(licandidateid);
        }

        public DataTable GetEducation(string licandidateid)
        {
            MlResumeBuilder mlb = new MlResumeBuilder();
            return mlb.GetEducation(licandidateid);
        }

        public string[] GetEducationbyId(int educationid)
        {
            MlResumeBuilder mlb = new MlResumeBuilder();
            return mlb.GetEducationbyId(educationid);
        }

        //experience
        public void InsertExperience(string licandidateid, string school_name, string degree_earned, string start_date, string end_date, string description)
        {
            MlResumeBuilder clb = new MlResumeBuilder();
            clb.InsertExperience(licandidateid, school_name, degree_earned, start_date, end_date, description);
        }

        public void UpdateExperience(int Experienceid, string school_name, string degree_earned, string start_date, string end_date, string description)
        {
            MlResumeBuilder mlb = new MlResumeBuilder();
            mlb.UpdateExperience(Experienceid, school_name, degree_earned, start_date, end_date, description);
        }

        public void DeleteExperience(string licandidateid)
        {
            MlResumeBuilder mlb = new MlResumeBuilder();
            mlb.DeleteExperience(licandidateid);
        }

        public DataTable GetExperience(string licandidateid)
        {
            MlResumeBuilder mlb = new MlResumeBuilder();
            return mlb.GetExperience(licandidateid);
        }

        public string[] GetExperiencebyId(int Experienceid)
        {
            MlResumeBuilder mlb = new MlResumeBuilder();
            return mlb.GetExperiencebyId(Experienceid);
        }

        //get edits
        public int GetStatusProfile(string licandidateid)
        {
            var qry = "select count(*) as rset from tb_Res_profile where licandidateid = ";
            MlResumeBuilder mlb = new MlResumeBuilder();
            return mlb.GetSections(licandidateid, qry);
        }

        public int GetStatusEducation(string licandidateid)
        {
            var qry = "select count(*) as rset from tb_Res_education where licandidateid = ";
            MlResumeBuilder mlb = new MlResumeBuilder();
            return mlb.GetSections(licandidateid, qry);
        }

        public int GetStatusReferences(string licandidateid)
        {
            var qry = "select count(*) as rset from tb_Res_references where licandidateid = ";
            MlResumeBuilder mlb = new MlResumeBuilder();
            return mlb.GetSections(licandidateid, qry);
        }

        public int GetStatusExperience(string licandidateid)
        {
            var qry = "select count(*) as rset from tb_Res_experience where licandidateid = ";
            MlResumeBuilder mlb = new MlResumeBuilder();
            return mlb.GetSections(licandidateid, qry);
        }

        public int GetStatusSkills(string licandidateid)
        {
            var qry = "select count(*) as rset from tb_Res_skills where licandidateid = ";
            MlResumeBuilder mlb = new MlResumeBuilder();
            return mlb.GetSections(licandidateid, qry);
        }

        //profile
        public string GetProfile(string licandidateid)
        {
            MlResumeBuilder clb = new MlResumeBuilder();
            return clb.GetProfile(licandidateid);
        }

        public void InsertProfile(string profile, string licandidateid)
        {
            MlResumeBuilder clb = new MlResumeBuilder();
            clb.InsertProfile(profile, licandidateid);
        }

        public void UpdateProfile(string profile, string licandidateid)
        {
            MlResumeBuilder mlr = new MlResumeBuilder();
            mlr.UpdateProfile(profile, licandidateid);
        }

        //skills handler
        public void InsertSkills(string skillname, int level, string licandidateid)
        {
            MlResumeBuilder mlb = new MlResumeBuilder();
            mlb.InsertSkills(skillname, level, licandidateid);
        }

        public ArrayList GetSkills(string licandidateid)
        {
            MlResumeBuilder mlb = new MlResumeBuilder();
            return mlb.GetSkills(licandidateid);
        }

        public void DeleteSkills(string skillname, int skillid, string licandidateid)
        {
            MlResumeBuilder mlb = new MlResumeBuilder();
            mlb.DeleteSkills(skillname, skillid, licandidateid);
        }

        public bool SearchSkills(string skillname, string licandidateid)
        {
            MlResumeBuilder slb = new MlResumeBuilder();
            return slb.SearchSkills(skillname, licandidateid);
        }

        //handle reference
        public void InsertReference(string licandidateid, string Firstname, string LastName, int referencetype, string email, string localphone, string mobile, string address)
        {
            MlResumeBuilder mlb = new MlResumeBuilder();
            mlb.InsertReference(licandidateid, Firstname, LastName, referencetype, email, localphone, mobile, address);
        }

        public void UpdateReference(int referenceid, string Firstname, string LastName, int referencetype, string email, string localphone, string mobile, string address)
        {
            MlResumeBuilder mlb = new MlResumeBuilder();
            mlb.UpdateReference(referenceid, Firstname, LastName, referencetype, email, localphone, mobile, address);
        }

        public DataTable GetReference(string licandidateid)
        {
            MlResumeBuilder mlb = new MlResumeBuilder();
            return mlb.GetReference(licandidateid);
        }

        public string[] GetReferencebyId(int referenceid)
        {
            MlResumeBuilder mlb = new MlResumeBuilder();
            return mlb.GetReferencebyId(referenceid);
        }

        public void DeleteReference(string licandidateid)
        {
            MlResumeBuilder mlb = new MlResumeBuilder();
            mlb.DeleteReference(licandidateid);
        }

        //build resume from url.
        private string GetCleanNumbers(string astr)
        {
            var atemp = astr;
            atemp = atemp.Replace("0", "");
            atemp = atemp.Replace("1", "");
            atemp = atemp.Replace("2", "");
            atemp = atemp.Replace("3", "");
            atemp = atemp.Replace("4", "");
            atemp = atemp.Replace("5", "");
            atemp = atemp.Replace("6", "");
            atemp = atemp.Replace("7", "");
            atemp = atemp.Replace("8", "");
            atemp = atemp.Replace("9", "");
            return atemp;
        }

        private string GetCleanHtml(string astr)
        {
            var atemp = astr.Replace("'", "");
            atemp = atemp.Replace("\"", "");
            atemp = atemp.Replace(",", "");
            atemp = atemp.Replace(".", "");
            atemp = atemp.Replace("@", "");
            atemp = atemp.Replace("+", "");
            atemp = atemp.Replace("$", "");
            atemp = atemp.Replace("-", "");
            atemp = atemp.Replace("\'", "");
            atemp = atemp.Replace("*", "");
            atemp = atemp.Replace("'", "");
            atemp = atemp.Replace("(", "");
            atemp = atemp.Replace("\r\n", "");
            atemp = atemp.Replace("^", "");
            atemp = atemp.Replace("%", "");
            atemp = atemp.Replace("!", "");
            atemp = atemp.Replace(")", "");
            atemp = atemp.Replace("[", "");
            atemp = atemp.Replace("]", "");
            atemp = atemp.Replace("~", "");
            atemp = atemp.Replace("+", "");
            atemp = atemp.Replace("_", "");
            atemp = atemp.Replace("/", "");
            atemp = atemp.Replace("?", "");
            atemp = atemp.Replace("|", "");
            atemp = atemp.Replace("&", " and ");
            atemp = atemp.Replace("<", "");
            atemp = atemp.Replace(">", "");
            atemp = atemp.Replace(":", "");
            atemp = atemp.Replace(";", "");
            atemp = atemp.Replace("—", "");
            atemp = Regex.Replace(atemp, @"<[^>]*>", "");

            return atemp;
        }

        public void InsertUrlProfile(string prof, string canid)
        {
            prof = prof.ToLowerInvariant();
            string[] splitat = { "objective", "profile", "goal", "education", "educational", "work", "experience", "competences", "competency", "\r" };
            string[] arr = prof.Split(splitat, StringSplitOptions.RemoveEmptyEntries);

            string tempprofile = arr[1].ToLowerInvariant();

            //clean profile
            tempprofile = GetCleanNumbers(tempprofile);
            tempprofile = GetCleanHtml(tempprofile);

            //insert into profile
            InsertProfile(tempprofile, canid);
        }

        public void InsertUrlEducation(string edu, int canid)
        {
            edu = edu.ToLowerInvariant();
            string[] splitat = { "education", "educational", "\r" };
            string[] arr = edu.Split(splitat, StringSplitOptions.RemoveEmptyEntries);

            //insert education

        }

        public void InsertUrlExperience() { }

        public void InsertUrlSkills() { }

        public void InsertUrlReferences() { }



    }
}
