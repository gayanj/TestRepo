using Mysqllayer;
using System.Data;
using System.Collections;

namespace Memorylayer
{
    public class MlResumeBuilder
    {
        //education
        public void InsertEducation(string licandidateid, string school_name, string degree_earned, string start_date, string end_date, string description)
        {
            SlResumeBuilder slb = new SlResumeBuilder();
            slb.InsertEducation(licandidateid, school_name, degree_earned, start_date, end_date, description);
        }

        public void UpdateEducation(int educationid, string school_name, string degree_earned, string start_date, string end_date, string description)
        {
            SlResumeBuilder slb = new SlResumeBuilder();
            slb.UpdateEducation(educationid, school_name, degree_earned, start_date, end_date, description);
        }

        public void DeleteEducation(string licandidateid)
        {
            SlResumeBuilder slb = new SlResumeBuilder();
            slb.DeleteEducation(licandidateid);
        }

        public DataTable GetEducation(string licandidateid)
        {
            SlResumeBuilder slb = new SlResumeBuilder();
            return slb.GetEducation(licandidateid);
        }

        public string[] GetEducationbyId(int educationid)
        {
            SlResumeBuilder slb = new SlResumeBuilder();
            return slb.GetEducationbyId(educationid);
        }

        //experience
        public void InsertExperience(string licandidateid, string school_name, string degree_earned, string start_date, string end_date, string description)
        {
            SlResumeBuilder slb = new SlResumeBuilder();
            slb.InsertExperience(licandidateid, school_name, degree_earned, start_date, end_date, description);
        }

        public void UpdateExperience(int Experienceid, string school_name, string degree_earned, string start_date, string end_date, string description)
        {
            SlResumeBuilder slb = new SlResumeBuilder();
            slb.UpdateExperience(Experienceid, school_name, degree_earned, start_date, end_date, description);
        }

        public void DeleteExperience(string licandidateid)
        {
            SlResumeBuilder slb = new SlResumeBuilder();
            slb.DeleteExperience(licandidateid);
        }

        public DataTable GetExperience(string licandidateid)
        {
            SlResumeBuilder slb = new SlResumeBuilder();
            return slb.GetExperience(licandidateid);
        }

        public string[] GetExperiencebyId(int Experienceid)
        {
            SlResumeBuilder slb = new SlResumeBuilder();
            return slb.GetExperiencebyId(Experienceid);
        }

        //get section edits
        public int GetSections(string licandidateid, string qry)
        {
            SlResumeBuilder slr = new SlResumeBuilder();
            return slr.GetSections(licandidateid, qry);
        }

        //profile
        public string GetProfile(string licandidateid)
        {
            SlResumeBuilder slb = new SlResumeBuilder();
            return slb.GetProfile(licandidateid);
        }

        public void InsertProfile(string profile, string licandidateid)
        {
            SlResumeBuilder slb = new SlResumeBuilder();
            slb.InsertProfile(profile, licandidateid);
        }

        public void UpdateProfile(string profile, string licandidateid)
        {
            SlResumeBuilder slr = new SlResumeBuilder();
            slr.UpdateProfile(profile, licandidateid);
        }

        //skills handler
        public void InsertSkills(string skillname, int level, string licandidateid)
        {
            SlResumeBuilder slb = new SlResumeBuilder();
            slb.InsertSkills(skillname, level, licandidateid);
        }

        public ArrayList GetSkills(string licandidateid)
        {
            SlResumeBuilder slb = new SlResumeBuilder();
            return slb.GetSkills(licandidateid);
        }

        public void DeleteSkills(string skillname, int skillid, string licandidateid)
        {
            SlResumeBuilder slb = new SlResumeBuilder();
            slb.DeleteSkills(skillname, skillid, licandidateid);
        }

        public bool SearchSkills(string skillname, string licandidateid)
        {
            SlResumeBuilder slb = new SlResumeBuilder();
            return slb.SearchSkills(skillname, licandidateid);
        }

        //handle reference
        public void InsertReference(string licandidateid, string Firstname, string LastName, int referencetype, string email, string localphone, string mobile, string address)
        {
            SlResumeBuilder slb = new SlResumeBuilder();
            slb.InsertReference(licandidateid, Firstname, LastName, referencetype, email, localphone, mobile, address);
        }

        public void UpdateReference(int referenceid, string Firstname, string LastName, int referencetype, string email, string localphone, string mobile, string address)
        {
            SlResumeBuilder slb = new SlResumeBuilder();
            slb.UpdateReference(referenceid, Firstname, LastName, referencetype, email, localphone, mobile, address);
        }

        public DataTable GetReference(string licandidateid)
        {
            SlResumeBuilder slb = new SlResumeBuilder();
            return slb.GetReference(licandidateid);
        }

        public string[] GetReferencebyId(int referenceid)
        {
            SlResumeBuilder slb = new SlResumeBuilder();
            return slb.GetReferencebyId(referenceid);
        }

        public void DeleteReference(string licandidateid)
        {
            SlResumeBuilder slb = new SlResumeBuilder();
            slb.DeleteReference(licandidateid);
        }



    }
}
