
using System;
using System.Threading;

public class Activity
{
    protected string _activityType;
    protected string _activityDescription;

    protected string _endingMessage;

    protected int _durationTotal;


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




    public void DisplayEndingMessage(string activityType, int duration)
    {

        _activityType = activityType;
        _durationTotal = duration;

        _endingMessage = $"You have completed {_durationTotal} minutes of the {_activityType}.";

        Thread.Sleep(3000);

    }
    
        


    public void StatusSpinner(int time)
    {   

        Console.Write("");
        int elapsedTime = 0;

        int timeModified = time * 1000;

        while (elapsedTime < timeModified)
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
        }

    }
    


}