using System;

namespace TrueOrFalse
{
  class Program
  {
		static void Main(string[] args)
    {
      // Do not edit these lines
      Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
      string entry = Console.ReadLine();
      Tools.SetUpInputStream(entry);

      // Type your code below
      string[] questions = {"The Sun is a star.", "13/50% a fallacy?", "Muh heckin gender inequality something something..", "There are 50 states in the U.S.A.", "The affect of the AIDS virus is seen distributed equally across all demographics."};
      bool[] answers = {true, false, false, true, false};
      bool[] responses = new bool[questions.Length];
      
      
    }

    static void RunQuiz(string[] questions, bool[] answers)
    {
      if (questions.Length != answers.Length)
      {
        Console.WriteLine($"Warning!! {questions.Length} does NOT equal {answers.Length}!!");
      }
      int askingIndex = 0;
      foreach (string question in questions)
      {
        string input;
        bool isBool;
        bool inputBool;
        Console.WriteLine($"True or False?: {question}");
        input = Console.ReadLine();
        input = input.ToLower();
        isBool = Boolean.TryParse(input, out inputBool);

        while (isBool != true || false)
        {
          Console.WriteLine("Please respond with 'true' or 'false', NO SPACES!!");
          input = Console.ReadLine();
          input = input.ToLower();
          isBool = Boolean.TryParse(input, out inputBool);
        }

        responses[askingIndex] = inputBool;
        askingIndex++;
       }
      
        int scoringIndex = 0;
        int score = 0;

        foreach (bool answer in answers)
        {
          bool aresponse = responses[scoringIndex];
          Console.WriteLine($"{scoringIndex + 1}. Input: {aresponse} | Answer: {answer}");
          scoringIndex++;
          if (aresponse == answer) {
            score++;
          }
          Console.WriteLine($"You got {score} out of {answers.Length} correct!");
        }
    }



  }
}