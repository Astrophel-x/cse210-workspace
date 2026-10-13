using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");



        



        // the make sure everything works code
        Square squareTest = new Square("blue", 3);

        Console.WriteLine(squareTest.GetArea());
        Console.WriteLine(squareTest.GetColor());

        Rectangle rectangleTest = new Rectangle("lavender", 3, 5);
        Console.WriteLine(rectangleTest.GetArea());
        Console.WriteLine(rectangleTest.GetColor());

        Circle circleTest = new Circle("firebrick", 3);
        Console.WriteLine(circleTest.GetArea());
        Console.WriteLine(circleTest.GetColor());


        // the actual list

        List<Shape> shapes = new List<Shape>();

        shapes.Add(squareTest);
        shapes.Add(rectangleTest);
        shapes.Add(circleTest);

        foreach (Shape s in shapes)
        {
            //Console.WriteLine($"Shape: ")
            Console.WriteLine($"Area: {s.GetArea()}");
            Console.WriteLine($"Color: {s.GetColor()}");

            
        }




    }
}