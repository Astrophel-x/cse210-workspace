public class Prompts
{
    public List<string> _prompts = new List<string>
    {
        "What is your favourite season?",
        "Would you rather be too hot or too cold?",
        "What is a compliment that has always stuck with you?",
        "What is a quote that is meaningful to you? Explain why.",
        "What is your hidden talent/What hidden talent would you like to have?",
        "What are five things you want to do before you die?",
        "What is something that happened today that made you smile?"

        
    };
    


    public string GetRandomPrompt()
    {
    //List<string> prompts = _prompts;
    int promptCount = _prompts.Count;

    Random r = new Random();

    int index = r.Next(promptCount);

    string randomPrompt = _prompts[index];

    return randomPrompt;



    
    
    }
}