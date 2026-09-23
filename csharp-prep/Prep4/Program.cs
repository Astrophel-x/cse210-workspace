using System;
using System.Collections.Generic;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");



        // List<string> userInputWords = new List<string>();

        // userInputWords.Add("somethingsomething");

        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers. Type 0 when you are finished.");
        

        int newNumber = -1;

        while (newNumber != 0)
        {
            Console.Write("Enter number: ");
            newNumber = int.Parse(Console.ReadLine());
            
            numbers.Add(newNumber);


        }

        // Compute the avg
        int total = 0;
        int i = -1;
        foreach (int number in numbers)
        {
            total += number;
            i += 1;
        }

        decimal avg = (decimal)total / i;

        // find the max

        int max = 0;
        // ^^ should prolly actually do numbers[0] if trying to be more robust

        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }

        

        Console.WriteLine($"The sum is: {total}.");
        Console.WriteLine($"The average is: {avg}.");
        Console.WriteLine($"The largest number is: {max}.");








    }
}