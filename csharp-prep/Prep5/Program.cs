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

        static string PromptUserName(/*string userName*/)
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favourite number: ");
            // Parse() converts a string to a diff format, assuming the string is properly formated
            int PromptUserNumber = int.Parse(Console.ReadLine());
            return PromptUserNumber;
            // return userNumber;
        }

        static int PromptUserBirthYear()
        {
            Console.Write("Please enter the year you were born: ");
            int userBirthYear = int.Parse(Console.ReadLine());
            return userBirthYear;


        }

        static int SquareNumber(int num)
        {
            int squareNumber = num * num;
            return squareNumber;
        }

        static void DisplayResult(string userName, int squareNumber, int userBirthYear)
        {
            Console.WriteLine($"{userName}, the square of your number is {squareNumber}.");
            int age = 2026 - userBirthYear;
            Console.WriteLine($"{userName}, you will turn {age} this year.");
        }






        DisplayWelcome();

        string displayUserName = PromptUserName();

        //Console.WriteLine(displayUserName);

        int favNumber = PromptUserNumber();

        int year = PromptUserBirthYear();
        

        DisplayResult(displayUserName, SquareNumber(favNumber), year);




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