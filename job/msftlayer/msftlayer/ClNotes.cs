using Memorylayer;

namespace Msftlayer
{
    public class ClNotes
    {
        public void Insertanote(string idcan, string comment)
        {
            var mln = new MlNotes();
            mln.Insertanote(idcan, comment);
        }

        public void Updatenote(string idcan, string comment)
        {
            var mln = new MlNotes();
            mln.Updatenote(idcan, comment);
        }

        public string Getnote(string idcan)
        {
            var mln = new MlNotes();
            return mln.Getnote(idcan);
        }
    }
}