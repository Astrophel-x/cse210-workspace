

public class Menu
{
    public void DisplayMenu()
    {
        string userMenuInput = "";

        Console.WriteLine("Welcome to the mindfulness program.");
        Console.WriteLine("Please choose a menu option from the following: ");
        while (userMenuInput != "4")
        {
            Console.WriteLine("\n1. Breathing Exercise\n");
            Console.WriteLine("2. Listing Exercise\n");
            Console.WriteLine("3. Reflection Exercise\n");
            Console.WriteLine("4. Quit\n");

            Console.Write("> ");
            userMenuInput = Console.ReadLine();

            if (userMenuInput == "1")
            {    
                Activity breathing = new BreathingActivity();
                //Console.WriteLine(breathing);
            }

            else if (userMenuInput == "2")
            {
                Activity listing = new ListingActivity();
            }

            else if (userMenuInput == "3")
            {
                Activity reflect = new ReflectionActivity();
            }

            else if (userMenuInput != "4")
            {
                Console.WriteLine("Invalid Input. Try Again.");
                continue;

            }

            Console.WriteLine("Thank you!");
            


        }
    }
}