

using System.Diagnostics;

public class ReflectionActivity : Activity
{
    public ReflectionActivity() : base("Reflection Activity", "This activity will help you identify times in your life you have shown strength or resilience. This reflection will help you recognize the power you already have as well as how you can apply it to other areas in your life.")
    {  
        Console.Clear();
        DisplayStartingMessage();

        string reflectionPrompt = GetRandomPrompt(_reflectionPrompts);

        Console.WriteLine(reflectionPrompt);

        Console.WriteLine();

        Console.WriteLine("Please take some time to reflect on the following questions that relate to the experience.");

        Console.WriteLine();

        var timerActivityTotal = Stopwatch.StartNew();

        while (timerActivityTotal.Elapsed.TotalSeconds < _userSpecifiedDuration)
        {    
            string reflectionQuestion = GetRandomPrompt(_reflectionQuestions);
            Console.WriteLine();
            Console.WriteLine(reflectionQuestion);
            
            StatusSpinner(5);

        }
        timerActivityTotal.Stop();
        _durationTotal = (int)timerActivityTotal.Elapsed.TotalSeconds;

        DisplayEndingMessage();

        
    }
    

    

    private List<string> _reflectionPrompts = new List<string>
    {
        "Think of a time you stood up for someone else.",
        "Think of a time you did something really difficult.",
        "Think of a time you helped someone in need.",
        "Think of a time you did something truly selfless.",
        "Think of a time you had to make a hard decision that no one else knew about, or looked small from an outside perspective but took a lot of courage."
    };

    

    private List<string> _reflectionQuestions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"


    };





}

