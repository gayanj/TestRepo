using System.Data;
using Mysqllayer;

namespace Memorylayer
{
    public class MlHelpCenter
    {
        public DataTable Gethelpcategories()
        {
            var shelp = new SlHelpCenter();
            return shelp.Gethelpcategories();
        }

        public DataTable Gethelpquestions()
        {
            var shelp = new SlHelpCenter();
            return shelp.Gethelpquestions();
        }

        public DataTable Gethelpquestions(string question)
        {
            var shelp = new SlHelpCenter();
            return shelp.Gethelpquestions(question);
        }

        public DataTable Gethelpquestions(int question)
        {
            var shelp = new SlHelpCenter();
            return shelp.Gethelpquestions(question);
        }

        public string[] Gethelpanswer(int questionid)
        {
            var shelp = new SlHelpCenter();
            return shelp.Gethelpanswer(questionid);
        }
    }
}