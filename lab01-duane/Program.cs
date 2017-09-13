using System;

namespace lab01_duane
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int questionsCorrect = 0;
            questionsCorrect += QuestionOne();
            questionsCorrect += QuestionTwo();
            Console.WriteLine($"You got {questionsCorrect} out of 2 correct");
            Console.ReadLine();
        }
        static int QuestionOne()
        {
            Console.WriteLine("My favorite number? Hint beween 1-10");
            var userInput = Convert.ToInt32(Console.ReadLine());
            int guesses = 0;
            while(guesses < 4 && userInput !=7)
            {
                Console.WriteLine("Guess again???");
                userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput == 7)
                {
                    Console.WriteLine("Correct");
                    return 1;
                    
                }
                if (guesses < 4 && userInput != 7)
                {
                    
                    guesses++;
                    
                  
                 
                }
                if (guesses == 4)
                {
                    Console.WriteLine("Out of Guesses");
                    return 0;
                }
            }
            Console.WriteLine("Actually Correct");
            return 1;
        }
         
        static int QuestionTwo()
        {
            Console.WriteLine("What is my Name??");
            string userGuess = Console.ReadLine().ToUpper();

            if (string.IsNullOrEmpty(userGuess.Trim()))
            {
                Console.WriteLine("Enter in a Name");
                QuestionTwo();
                return 0;
            }
            if (userGuess == "DUANE")
            {
                Console.WriteLine($"Correct my name is {userGuess}");
                return 1;
            }
            else
            {
                Console.WriteLine($"{userGuess} is incorrect");
                return 0;
            }
        }

    }
}
