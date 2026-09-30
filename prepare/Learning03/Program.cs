using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");


        
        Fraction loopF = new Fraction();

        Random r = new Random();
        // int randomNumber = r.Next(1,100);

        // loopF.SetNumerator(randomNumber);
        // loopF.SetDenom(randomNumber);

        for (int i = 1; i < 25; i++)

        {
            int randomNum = r.Next(1, 100);
            int randomDenom = r.Next(1,100);
            loopF.SetNumerator(randomNum);
            loopF.SetDenom(randomDenom);

            Console.WriteLine($"Fraction {i}: string: {loopF.GetFractionString()} Number: {loopF.GetDecimalValue()}");


            

        }




    }
}