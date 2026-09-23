using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        Console.WriteLine("Guess the magic number!");
        
        // string userNumberInput = Console.ReadLine();
        // int magicNumber = int.Parse(userNumberInput);





        string numberCorrect = "";
        do
        {
            Console.Write("What is your guess? ");
            string userGuess = Console.ReadLine();
            int userGuessNumber = int.Parse(userGuess);           
        

            if (userGuessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
                numberCorrect = "no";
            }

            else if (userGuessNumber < magicNumber)
            {
                Console.WriteLine("Higher");
                numberCorrect = "no";
            }

            else
            {
                Console.WriteLine("You guessed it!");
                numberCorrect = "yes";
            }

        } while (numberCorrect != "yes");








    }
}