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
            questionsCorrect += QuestionThree();
            Console.WriteLine($"You got {questionsCorrect} out of 3 correct");
            Console.ReadLine();
        }
        static int QuestionOne()
        {
            try
            {

                Console.WriteLine("My favorite number? Hint beween 1-10");
                var userInput = Convert.ToInt32(Console.ReadLine());
                int guesses = 0;
                while (guesses < 4 && userInput != 7)
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
            catch (FormatException fe)

            {
                Console.WriteLine("Enter a Number silly");
                QuestionOne();
                return 0;
            }
            finally
            {
                Console.WriteLine("Profit!!");
            }

        }
        static int QuestionTwo()
        {
            try
            {
                Console.WriteLine("Have I been to Alaska before? yes or no!");
                string userAnswer = Console.ReadLine().ToLower();

                if (userAnswer == "yes" || userAnswer == "y")
                {
                    Console.WriteLine("Yes I have its awesome up there!!");
                    return 1;
                }
                if (userAnswer == "no" || userAnswer == "n")
                {
                    Console.WriteLine("Actually I have");
                    return 0;
                }
                else if (userAnswer != "yes" || userAnswer != "y" || userAnswer != "no" || userAnswer != "n")
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("its a yes or no question geez...", ex);
                QuestionTwo();

            }
            return 0;
        }


        static int QuestionThree()
        {
            Console.WriteLine("What is my Name??");
            string userGuess = Console.ReadLine().ToUpper();

            if (string.IsNullOrEmpty(userGuess.Trim()))
            {
                Console.WriteLine("Enter in a Name");
                QuestionThree();
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

