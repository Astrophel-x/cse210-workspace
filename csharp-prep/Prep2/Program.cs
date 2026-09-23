using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
    
        Console.Write("Please input your grade percentage: ");
        string userGrade = Console.ReadLine();
        int userGradePercent = int.Parse(userGrade);

        string letter = "";
        if (userGradePercent >= 90)
        {
            letter = "A";
            Console.WriteLine($"Your grade is: {letter}.");
        }
        else if (userGradePercent >= 80)
        {
            letter = "B";
            Console.WriteLine($"Your grade is: {letter}.");
        }
        else if (userGradePercent >= 70)
        {
            letter = "C";
            Console.WriteLine($"Your grade is: {letter}.");
        }
        else if (userGradePercent >= 60)
        {
            letter = "D";
            Console.WriteLine($"Your grade is: {letter}.");
        }
        else
        {
            letter = "F";
            Console.WriteLine($"Your grade is: {letter}.");
        }

        if (userGradePercent >= 70)
        {
            Console.WriteLine("You have achieved the requisite grade to pass this course. Congratulations!");
        }
        else
        {
            Console.WriteLine("Unfortunately, you did not achieve the grade needed to pass this course. Feel free to retake this course to achieve a higher grade.");
        }
        
    
    
    
    }
}