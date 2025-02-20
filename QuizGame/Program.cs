
using QuizGame;


Dictionary<string, string> quiz = QuizLogic.CreateQuiz();
List<string> userResponses = QuizLogic.AskQuestions(quiz);
QuizLogic.CheckAnswers(userResponses, quiz);


