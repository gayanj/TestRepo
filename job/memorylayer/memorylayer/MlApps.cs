using System.Data;
using Mysqllayer;

namespace Memorylayer
{
    public class MlApps
    {
        public string Getcanjobapptotal(string canid)
        {
            var slap = new SlApps();
            return slap.Getcanjobapptotal(canid);
        }

        public void Insertrecview(string empid, string candidateid, string appid)
        {
            var slap = new SlApps();
            slap.Insertrecview(empid, candidateid, appid);
        }

        //default candidate documents
        public void Insertmyresumes(string docname, string docurls, string idcan)
        {
            var slap = new SlApps();
            slap.Insertmyresumes(docname, docurls, idcan);
        }

        public void Updatemyresumes(string docname, string docurls, string idcan)
        {
            var slap = new SlApps();
            slap.Updatemyresumes(docname, docurls, idcan);
        }

        public string[] Getmyresumes(string canid)
        {
            var slap = new SlApps();
            return slap.Getmyresumes(canid);
        }

        //must add this proc.
        public void Insertapplication(string firstname, string lastname, string profilesummary, string mxdocid,
                                      string aAppEmail)
        {
            var mlapp = new SlApps();
            mlapp.Insertapplication(firstname, lastname, profilesummary, mxdocid, aAppEmail);
        }

        public void Insertapplicationcan(string idapplications, string licandidateid, string firstname, string lastname, string profilesummary,
                                         string mxdocid, string aAppEmail)
        {
            var mlapp = new SlApps();
            mlapp.Insertapplicationcan(idapplications, licandidateid, firstname, lastname, profilesummary, mxdocid, aAppEmail);
        }

        //must add this proc.
        public void Insertapplicationmapping(string jobid, string applicationid)
        {
            var mlapp = new SlApps();
            mlapp.Insertapplicationmapping(jobid, applicationid);
        }



        //add document
        public void Insertdocuments(string documentname, string docUrl)
        {
            var mlapp = new SlApps();
            mlapp.Insertdocuments(documentname, docUrl);
        }

        public DataTable Getapplication(string applicationname)
        {
            var mlapp = new SlApps();
            return mlapp.Getapplication(applicationname);
        }

        //get get application details for JS
        public string[] Getapplicationdetails(string applyid)
        {
            var mlapp = new SlApps();
            return mlapp.Getapplicationdetails(applyid);
        }

        public void UpdateAppStatuses(string idapp, int statusid)
        {
            var mlapp = new SlApps();
            mlapp.UpdateAppStatuses(idapp, statusid);
        }
    }
}