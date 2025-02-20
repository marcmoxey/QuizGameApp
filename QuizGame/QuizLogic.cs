using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGame
{
    public  class QuizLogic
    {
        
        public static Dictionary<string, string> CreateQuiz()
        {
            Dictionary<string, string> questions = new Dictionary<string, string>();
            questions["What is the capital of France? "] = "pairs";
            questions["What planet is known as the Red Planet? "] = "mars";
            questions["What is he largest mammal in the world? "] = "blue whale";
            questions["Who wrote 'To Kill a Mockingbird'? "] = "harper lee";
            questions["How many continents are there on Earth? "] = "7";

            return questions;

        }


        public static List<string> AskQuestions(Dictionary<string, string> questions)
        {
            List<string> userAnswers = new List<string>();

            foreach (KeyValuePair<string, string> question in questions)
            {
                Console.Write($"{question.Key}: ");
                string userAnswer = Console.ReadLine()?.ToLower().Trim();
                userAnswers.Add(userAnswer);
            }

            return userAnswers;
        }


        public static void CheckAnswers(List<string> userAnswers, Dictionary<string, string> questions)
        {
            char checkMark = '\u2713';
            int userScore = 0;
            int index = 0;
            Console.WriteLine("\nResults");
            foreach (var question in questions)
            {
                string correctAnswer = question.Value;
                string userAnswer = userAnswers[index];

                if (userAnswer == correctAnswer)
                {
                    Console.WriteLine($"{checkMark} Correct! {question.Key} Answer: {correctAnswer}");
                    userScore++;
                }
                else
                {
                    Console.WriteLine($"X Incorrect. {question.Key} Correct Answer: {correctAnswer}");
                }

                index++; // Move to the next user answer
            }

            Console.WriteLine($"\nFinal Score: {userScore}/{questions.Count}");
        }
    }
}
