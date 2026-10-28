

public class ListingActivity : Activity
{
    
    private List<string> _reflectionPrompts = new List<string>
    {
        "Who are the people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
        "What are things that you are grateful for?",



    };

    private string GetRandomPrompt()
    {
        int promptCount = _reflectionPrompts.Count;
        Random r = new Random();
        int index = r.Next(promptCount);
        string randomPrompt = _reflectionPrompts[index];

        return randomPrompt;
    }


    public ListingActivity(string activityType, string activityDescription) : base(activityType, activityDescription)
    {
        
        
        










    }







}