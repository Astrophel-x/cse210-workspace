

using System.Diagnostics;

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

    // private string GetRandomPrompt()
    // {
    //     int promptCount = _listingPrompts.Count;
    //     Random r = new Random();
    //     int index = r.Next(promptCount);
    //     string randomPrompt = _listingPrompts[index];

    //     return randomPrompt;
    // }


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
        //Console.WriteLine("List as many answers as you can until time is up.");
        //Console.WriteLine();

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

        // SetCountdown(10);

    }

}