using System.Data;
using Memorylayer;

namespace Msftlayer
{
    public class ClApps
    {
        public string Getcanjobapptotal(string canid)
        {
            var mlap = new MlApps();
            return mlap.Getcanjobapptotal(canid);
        }

        public void Insertrecview(string empid, string candidateid, string appid)
        {
            var mlap = new MlApps();
            mlap.Insertrecview(empid, candidateid, appid);
        }

        //default candidate documents
        public void Insertmyresumes(string docname, string docurls, string idcan)
        {
            var slap = new MlApps();
            slap.Insertmyresumes(docname, docurls, idcan);
        }

        public void Updatemyresumes(string docname, string docurls, string idcan)
        {
            var slap = new MlApps();
            slap.Updatemyresumes(docname, docurls, idcan);
        }

        public string[] Getmyresumes(string canid)
        {
            var slap = new MlApps();
            return slap.Getmyresumes(canid);
        }

        //must add this proc.
        public void Insertapplication(string firstname, string lastname, string profilesummary, string mxdocid,
                                      string aAppEmail)
        {
            var mlapp = new MlApps();
            mlapp.Insertapplication(firstname, lastname, profilesummary, mxdocid, aAppEmail);
        }

        public void Insertapplicationcan(string idapplications, string licandidateid, string firstname, string lastname, string profilesummary,
                                         string mxdocid, string aAppEmail)
        {
            var mlapp = new MlApps();
            mlapp.Insertapplicationcan(idapplications, licandidateid, firstname, lastname, profilesummary, mxdocid, aAppEmail);
        }

        //must add this proc.
        public void Insertapplicationmapping(string jobid, string applicationid)
        {
            var mlapp = new MlApps();
            mlapp.Insertapplicationmapping(jobid, applicationid);
        }

        //add document
        public void Insertdocuments(string documentname, string docUrl)
        {
            var mlapp = new MlApps();
            mlapp.Insertdocuments(documentname, docUrl);
        }

        public DataTable Getapplication(string applicationname)
        {
            var mlapp = new MlApps();
            return mlapp.Getapplication(applicationname);
        }

        //get get application details for JS
        public string[] Getapplicationdetails(string applyid)
        {
            var mlapp = new MlApps();
            return mlapp.Getapplicationdetails(applyid);
        }

        public void UpdateAppStatuses(string idapp, int statusid)
        {
            var mlapp = new MlApps();
            mlapp.UpdateAppStatuses(idapp, statusid);
        }
    }
}