using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;


public class BreathingActivity : Activity
{
    //public BreathingActivity(string activityType, string activityDescription) : base(activityType, activityDescription)
    // private void breathing()
    // {
    //     time += 0.1;
    //     double sin = (Math.Sin(time) + 1) / 2 ;
    //     int spacing = (int)(sin * 5);

    //     Console.Clear();
    //     Console.WriteLine(new string(' ', spacing) + wave);
    //     Thread.Sleep(100);
    // }
    public BreathingActivity() : base("Breathing Activity", "This activity will focus on your breathing. Clear your mind and relax.")
    {
        DisplayStartingMessage();

        var timerActivityTotal = Stopwatch.StartNew();


        //bool breathing = true;
        double time = -1.5;
        string wave = ".";

        while (timerActivityTotal.Elapsed.TotalSeconds < _userSpecifiedDuration)
        {
            var inhale = Stopwatch.StartNew();
                
                //while ()
                //{//int breathe = 4;
            while (inhale.Elapsed.TotalSeconds < 4 && timerActivityTotal.Elapsed.TotalSeconds < _userSpecifiedDuration)
            {   
                Console.WriteLine("Breathe in...");
                time += 0.08;
                double sin = (Math.Sin(time) + 1) / 2 ;
                int spacing = (int)(sin * 15);

                //Console.Clear();
                Console.WriteLine(new string(' ', spacing) + wave);
                Thread.Sleep(100);
            }
            inhale.Stop();
            //Console.Clear();

            var exhale = Stopwatch.StartNew();
            //time = -1.5;

            while (exhale.Elapsed.TotalSeconds < 4 && timerActivityTotal.Elapsed.TotalSeconds < _userSpecifiedDuration)
            {
                Console.WriteLine("Breathe out...");
                time += 0.08;
                double sin = (Math.Sin(time) + 1) / 2 ;
                int spacing = (int)(sin * 15);

                //Console.Clear();
                Console.WriteLine(new string(' ', spacing) + wave);
                Thread.Sleep(100);
            }
            exhale.Stop();

        }
        timerActivityTotal.Stop();
        _durationTotal = _userSpecifiedDuration;
        DisplayEndingMessage();
        
    }


}