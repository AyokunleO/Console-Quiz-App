using System;
using System.Collections.Generic;

namespace ConsoleQuizApp
{
    public class Quiz
    {
        private List<Question> QuestionTypes = new List<Question>() {};
        private int countCorrect = 0;
        private int countWrong = 0;
        public enum ListOfAnswers
        {
            a,
            b,
            c,
            d
        }
        public void StartQuiz ()
        {
            while (true)
            {
            Console.WriteLine("What would you like to do?\n Enter any of the following\n ADD | PLAY | SCORE | QUIT");
            string userResp = Console.ReadLine();

            if (userResp.ToUpper() == "ADD")
            {
                // ADD
                Console.WriteLine("What type of question do you want to add?\na. MultipleChoice\nb. TrueFalse\nc. Checkbox");
                string questionType = Console.ReadLine();

                if(questionType.ToUpper() == "A"){
                    QuestionTypes.Add(AddMultipleChoice());
                }else if (questionType.ToUpper() == "B"){
                    QuestionTypes.Add(AddTrueFalse());
                }else if(questionType.ToUpper() == "C"){
                    QuestionTypes.Add(AddCheckbox());
                }else{
                    Console.WriteLine("Invalid question type selected");
                }
            } else if(userResp.ToUpper() == "PLAY")
            {
                // Play
                foreach (var question in QuestionTypes)
                {
                    Console.WriteLine(question);
                    Console.WriteLine("Enter the answer ");
                    string answer =Console.ReadLine();
                    if(question.CrossCheck(answer))
                    {
                        Console.WriteLine("Correct!");
                        countCorrect++;
                    }else{
                        Console.WriteLine("Wrong!");
                        countWrong++;
                    }
                }
                
            }else if(userResp.ToUpper() == "SCORE")
            {
                // Display Score
                Console.WriteLine($"You answered a total of {countCorrect + countWrong} question(s).\nYou answered {countCorrect} question(s) correctly and missed {countWrong} question(s)");
            }else if(userResp.ToUpper() == "QUIT")
            {
                // Quit Quiz
                break;
            }else{
                Console.WriteLine("Invalid input");
            }
            }

        }
        // public void AddQuestion(Question questionType)
        // {
        //     QuestionTypes.Add(questionType);
        // }

        public Question AddMultipleChoice()
        {
            Console.WriteLine("Enter a question: ");
            string question=Console.ReadLine();
            Console.WriteLine("Enter the answer ");
            string answer =Console.ReadLine();

            List<string> Options = new List<string>();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter option {(ListOfAnswers)i++}");
                string option = Console.ReadLine();
                Options.Add(option);
            }
            return new MultipleChoice(question, Options, answer);
        }

        public Question AddTrueFalse()
        {
            Console.WriteLine("Enter a question: ");
            string question=Console.ReadLine();
            Console.WriteLine("Enter the answer ");
            string answer =Console.ReadLine();
            return new TrueFalse(question, answer);
        }

        public Question AddCheckbox()
        {
            Console.WriteLine("Enter a question: ");
            string question=Console.ReadLine();
            Console.WriteLine("Enter the answer ");
            string answer =Console.ReadLine();

            List<string> Options = new List<string>();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter option {(ListOfAnswers)i++}");
                string option = Console.ReadLine();
                Options.Add(option);
            }
            return new Checkbox(question, Options, answer);
        }   
    }
}