using System;
using System.Collections.Generic;

namespace ConsoleQuizApp
{
    public class MultipleChoice : Question
    {
        private List<string> options;
        
        public MultipleChoice(string questions, List<string> options, string answer): base(questions, answer)
        {
            Options = options;
        }
        public List<string> Options
        {
            get { return options; }
            set { options = value; }
        }
        public override bool CrossCheck(string userAns)
        {
            return userAns == Answer;
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