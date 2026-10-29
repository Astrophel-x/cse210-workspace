# Inheritance

## Meaning

Inheritance is when a class is able to get the attributes and methods of a different class without explicitly typing them out. Just as a son is a male just like his father, the son may have specific details that differ. The son has "inherited" this quality, and then also has things added to it. 

## Benefit

It can save a lot of time. It allows you to "inherit" from one class to another, eliminated the need for typing the same thing over and over. 

## Application

Let us pretend we have a base class of "Animal". We know we are going to be working with animals that make a sound. We could have some sort of generic animal sound method, and then our individual animals would either utilize this method, or implement it and override it to make it specific to the sub class. 

## Example

public class ListingActivity : Activity
{
    private List<string> _listingPrompts = new List<string>
    {
        "Who are the people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
        "What are things that you are grateful for?",
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life. Please ponder the following question, then list as many answers as you can.")
    {      
        DisplayStartingMessage();

        string prompt = GetRandomPrompt(_listingPrompts);

        Console.WriteLine(prompt);
        Console.WriteLine();
        Console.WriteLine("Please take a few seconds to ponder.");
        Console.WriteLine();
        SetCountdown(5);
        Console.WriteLine();

        int i = 0;
        var timer = Stopwatch.StartNew();
        while (timer.Elapsed.TotalSeconds < _userSpecifiedDuration)
        {
            Console.Write("> ");
            Console.ReadLine();
            i ++;
        };
        timer.Stop();

        Console.WriteLine();
        Console.WriteLine($"You listed {i} items.");

        DisplayEndingMessage();

    }
}