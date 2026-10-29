
using System;
using System.Runtime.InteropServices;
using System.Threading;
using static Sleep;

public class Activity
{
    protected string _activityType;
    protected string _activityDescription;

    //protected string _endingMessage;

    protected int _durationTotal;

    protected int _userSpecifiedDuration;

    protected string _prompts;
    private Random _random = new Random();


    public Activity(string activityType, string activityDescription)
    {
        _activityType = activityType;
        _activityDescription = activityDescription;
    }

    // public string GetActivityType()
    // {
    //     return _activityType;
    // }

    // public string GetActivityDescription()
    // {
    //     return _activityDescription;
    // }

    public int GetDurationTotal()
    {
        return _durationTotal;
    }

    public int GetUserDuration()
    {
        Console.WriteLine("How long in seconds would you like this activity to last? ");
        Console.WriteLine();
        Console.Write("> ");
        _userSpecifiedDuration = int.Parse(Console.ReadLine());
        
        return _userSpecifiedDuration;
    }


    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityType}.");
        Console.WriteLine();
        Console.WriteLine($"{_activityDescription}");
        GetUserDuration();
        Console.WriteLine();

        Console.Clear();
        Console.WriteLine("Ready?\n");
        Console.Write("3");
        half();
        Console.Write("\b \b");
        half();
        Console.Write("2");
        half();
        Console.Write("\b \b");
        half();  
        Console.Write("1");      
        half();
        Console.Write("\b \b");
        half();
        Console.Write("Begin\n");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done.\n");
        StatusSpinner(2);
        if (_durationTotal == 0)
        {
            _durationTotal = _userSpecifiedDuration;
        };
        Console.WriteLine($"You have completed {_durationTotal} seconds of the {_activityType}.");
        StatusSpinner(4);


    }
    
        


    public void StatusSpinner(int time)
    {   

        Console.Write("");
        int elapsedTime = 0;

        int timeModified = time * 1000;

        while (elapsedTime <= timeModified)
        {
            Console.Write("\b|\b");
            Thread.Sleep(500);
            elapsedTime += 500;
            Console.Write("\b/\b");
            Thread.Sleep(500);
            elapsedTime += 500;
            Console.Write("\b—\b");
            Thread.Sleep(500);
            elapsedTime += 500;
            Console.Write("\b\\\b");
            Thread.Sleep(500);
            elapsedTime += 500;

            if (elapsedTime == timeModified)
            {
                Console.Write("\b ");
            }
        }

    }


    protected void SetCountdown(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime countdown = startTime.AddSeconds(seconds);
        Console.Write(". . . ");
        while (startTime < countdown && seconds > 0)
        {
            Console.Write($"{seconds}. . .");
            half();
            Console.Write("\b\b\b\b\b\b\b ");
            half();
            seconds--;

        };
        
        Console.WriteLine();
        //Console.Clear();
    }

    



    protected string GetRandomPrompt(List<string> prompts)
    {
        int promptCount = prompts.Count;

        int index = _random.Next(promptCount);

        string usedPrompt = prompts[index];

        prompts.RemoveAt(index);

        return usedPrompt;
    }
    


}