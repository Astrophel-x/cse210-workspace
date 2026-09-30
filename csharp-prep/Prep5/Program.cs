using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName(string userName)
        {
            Console.Write("Please enter your name: ");
            userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favourite number: ");
            return int.Parse(Console.ReadLine());
            // return userNumber;
        }

        static void PromptUserBirthYear(out int userBirthYear)
        {
            Console.Write("Please enter the year you were born: ");
            userBirthYear = int.Parse(Console.ReadLine());


        }

        static int SquareNumber(int num)
        {
            int square = num * num;
            return square;
        }

        static void DisplayResult(string userName, int square, int userBirthYear)
        {
            Console.WriteLine($"{userName}, the square of your number is {square}.");
            int age = 2026 - userBirthYear;
            Console.WriteLine($"{userName}, you will turn {age} this year.");
        }






        DisplayWelcome();

        PromptUserName(string userName);


    }
}


// returnType FunctionName(dataType parameter1, dataType parameter2)
// {
//     // function_body
// }

// > void smth()
//   {
        //no parameter or return type
//   }

// > static void smth()
    //{ standalone function}