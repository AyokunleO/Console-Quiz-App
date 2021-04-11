using System.Collections.Generic;
namespace ConsoleQuizApp
{
    public class Checkbox: Question
    {
        private List<string> options;

        public Checkbox(string questions, List<string> options, string answer):base(questions,answer)
        {
            Options = options;
        }

        public override bool CrossCheck(string userAns)
        {
            if(userAns.Length == Answer.Length)
            {
                foreach (var item in Answer)
                {
                    if((userAns.ToUpper()).Contains(item))
                    {
                        continue;
                    }else{
                        return false;
                    }
                }
                    return true;
            }else{
                return false;
            }
        }
        public List<string> Options
        {
            get { return options; }
            set { options = value; }
        }

        public override string ToString()
        {
            int i = 0;
            string stringified="";
            foreach (var element in Options)
            {
                stringified += $"{(ListOfAnswers)i++}. {element}\n";
            }
            return $"{Questions}\n{stringified}";
        }
    }
}