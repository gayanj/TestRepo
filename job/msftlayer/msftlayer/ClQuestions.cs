using System.Collections;
using Memorylayer;

namespace Msftlayer
{
    public class ClQuestions
    {
        public string GetMaxQuestionId()
        {
            var qs = new MlQuestions();
            return qs.GetMaxQuestionId();
        }

        public string GetMaxAnswerId()
        {
            var qs = new MlQuestions();
            return qs.GetMaxAnswerId();
        }

        public void InsertQuestion(string idjob, string idquestion, string question)
        {
            var qs = new MlQuestions();
            qs.InsertQuestion(idjob, idquestion, question);
        }

        public void InsertQuestionLink(string idquestion, string idans)
        {
            var qs = new MlQuestions();
            qs.InsertQuestionLink(idquestion, idans);
        }

        public void InsertAnswer(string idans, string answer)
        {
            var qs = new MlQuestions();
            qs.InsertAnswer(idans, answer);
        }

        public void InsertAnswerByUser(int idans, int idquestion, string idjobs, string idapplication, string answer)
        {
            var qs = new MlQuestions();
            qs.InsertAnswerByUser(idans, idquestion, idjobs, idapplication, answer);
        }

        public void DeleteQuestion(string idquestion)
        {
            var qs = new MlQuestions();
            qs.DeleteQuestion(idquestion);
        }

        public void DeleteQuestionLinkQ(string idquestion)
        {
            var qs = new MlQuestions();
            qs.DeleteQuestionLinkQ(idquestion);
        }

        public void DeleteQuestionLinkA(string idans)
        {
            var qs = new MlQuestions();
            qs.DeleteQuestionLinkA(idans);
        }

        public void DeleteAnswer(string idans)
        {
            var qs = new MlQuestions();
            qs.DeleteAnswer(idans);
        }

        public void UpdateQuestion(int idjob, int idquestion, string question)
        {
            var qs = new MlQuestions();
            qs.UpdateQuestion(idjob, idquestion, question);
        }

        public void UpdateAnswers(int idans, int idquestion)
        {
            var qs = new MlQuestions();
            qs.UpdateAnswers(idans, idquestion);
        }

        public ArrayList GetQuestion(string idjobs)
        {
            var qs = new MlQuestions();
            return qs.GetQuestion(idjobs);
        }

        public ArrayList GetAnswers(string idquestion)
        {
            var qs = new MlQuestions();
            return qs.GetAnswers(idquestion);
        }

        public ArrayList GetAnswerUser(string idapp)
        {
            var qs = new MlQuestions();
            return qs.GetAnswerUser(idapp);
        }

        //temporary ans
        public void InsertTempAns(string idqs, string session, string idjobs)
        {
            var iqs = new MlQuestions();
            iqs.InsertTempAns(idqs, session, idjobs);
        }

        public void DeleteTempAns(string idqs)
        {
            var iqs = new MlQuestions();
            iqs.DeleteTempAns(idqs);
        }

        public string GetTempAns(string idqs)
        {
            var iqs = new MlQuestions();
            return iqs.GetTempAns(idqs);
        }

        public void DeleteTempAnsByJob(string idjobs)
        {
            var iqs = new MlQuestions();
            iqs.DeleteTempAnsByJob(idjobs);
        }
    }
}