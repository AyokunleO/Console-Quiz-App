using System;
using System.Collections.Generic;

namespace ConsoleQuizApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // MultipleChoice question1 = new MultipleChoice("Nigeria's president", new List<string>(){"Ayokunle", "David", "Dolapo"}, "A");
            // Console.WriteLine($"{question1}\n{question1.CrossCheck("A")}");

            // TrueFalse question2 = new TrueFalse("Nigeria's president is Ayokunle", "TRUE");
            // Console.WriteLine($"{question2}\n{question2.CrossCheck("true")}");

            // Checkbox question3 = new Checkbox("Nigeria's past presidents", new List<string>(){"Ayokunle", "David", "Dolapo"}, "BC");
            // Console.WriteLine($"{question3}\n{question3.CrossCheck("Bc")}");

            Quiz testQuiz = new Quiz();
            testQuiz.StartQuiz();
        }
    }
}
