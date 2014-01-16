using Mysqllayer;

namespace Memorylayer
{
    public class MlNotes
    {
        public void Insertanote(string idcan, string comment)
        {
            var sln = new SlNotes();
            sln.Insertanote(idcan, comment);
        }

        public void Updatenote(string idcan, string comment)
        {
            var sln = new SlNotes();
            sln.Updatenote(idcan, comment);
        }

        public string Getnote(string idcan)
        {
            var sln = new SlNotes();
            return sln.Getnote(idcan);
        }
    }
}