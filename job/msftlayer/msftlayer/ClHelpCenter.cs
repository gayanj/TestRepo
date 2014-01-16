using System.Data;
using Memorylayer;

namespace Msftlayer
{
    public class ClHelpCenter
    {
        public DataTable Gethelpcategories()
        {
            var shelp = new MlHelpCenter();
            return shelp.Gethelpcategories();
        }

        public DataTable Gethelpquestions()
        {
            var shelp = new MlHelpCenter();
            return shelp.Gethelpquestions();
        }

        public DataTable Gethelpquestions(string question)
        {
            var shelp = new MlHelpCenter();
            return shelp.Gethelpquestions(question);
        }

        public DataTable Gethelpquestions(int question)
        {
            var shelp = new MlHelpCenter();
            return shelp.Gethelpquestions(question);
        }

        public string[] Gethelpanswer(int questionid)
        {
            var shelp = new MlHelpCenter();
            return shelp.Gethelpanswer(questionid);
        }
    }
}