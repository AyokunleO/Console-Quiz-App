namespace ConsoleQuizApp
{
    public abstract class Question
    {
        public string Questions { get; private set; }
        public string Answer { get; private set; }
        // private string questions;

        public Question(string questions, string answer)
        {
            Questions = questions;
            Answer = answer;
            
        }

        public enum ListOfAnswers
        {
            a,
            b,
            c,
            d
        }

        public abstract bool CrossCheck(string userAns);

        
        // public string Questions
        // {
        //     get { return questions; }
        //     set { questions = value; }
        // }
        
    }
}