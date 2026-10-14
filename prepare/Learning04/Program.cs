using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");




        Assignment a1 = new Assignment("Michael Gannon", "Organic Chemistry");
        Console.WriteLine(a1.GetSummary());
        Console.WriteLine("");

        MathAssignment m1 = new MathAssignment("Michael Gannon", "O chem", "6", "Hw 6a");
        Console.WriteLine(m1.GetSummary());
        Console.WriteLine(m1.GetHwList());

        WritingAssignment w1 = new WritingAssignment("Michael Gannon", "Human Anatomy", "Post Dissection Writeup");
        Console.WriteLine(w1.GetSummary());
        Console.WriteLine(w1.GetWritingInfo());

    }
}