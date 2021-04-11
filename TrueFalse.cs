namespace ConsoleQuizApp
{
    public class TrueFalse:Question
    {
        // private List<string> options;
        
        public TrueFalse(string questions, string answer): base(questions, answer)
        {
            // Options = options;
        }

        public override bool CrossCheck(string userAns)
        {
            return userAns.ToUpper() == Answer;
        }
        // public List<string> Options
        // {
        //     get { return options; }
        //     set { options = value; }
        // }

        public override string ToString()
        {
            // int i = 0;
            // string stringified="";
            // foreach (var element in Options)
            // {
            //     stringified += $"{(ListOfAnswers)i++}. {element}\n";
            // }
            // return $"{Questions}\n{stringified}";
            return $"Enter true or false for this Question\n{Questions}";
        }
    }
}