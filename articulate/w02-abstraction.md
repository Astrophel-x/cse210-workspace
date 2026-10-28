# Abstraction

### Abstraction Meaning

Abstraction is a way of reducing complexity for the programmer and the user. One way of doing this is by using objects and classes - basically grouping like things together. Abstraction is the first step when it comes to using classes.

An object is something with a specific responsibility in the program. It "behaves" in a way that allows them to fulfill said responsiblity, and exists in "states". From there, we can turn our object into a class.

A class is essentially a template, or a blueprint. You must then use the blueprint to build, or rather, "construct" an "instance" that you then most likely assign to a variable. In other words, your class is a way to create a custom data type tailored to whatever it is you need it for. It's an empty box, that you then fill with things you "construct". An instance is pretty much another word for an object. 


### Abstraction Benefit

It keeps things organized. This is especially useful as your program increases in complexity - you can define some common behaviors or create reusable code. You can create something that a method can access without it having to know or have all the details. It also allows more flexibility - it creates a division between a component and its action. You're kind of future-proofing your code. 

In my project this week, I created the public Prompts class, where I could store my journal Prompts as well as the code needed to randomly select one of them. This made it very easy to call in my other classes/methods. 


### Code Example

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
    int promptCount = _prompts.Count;
    Random r = new Random();
    int index = r.Next(promptCount);
    string randomPrompt = _prompts[index];
    return randomPrompt;
    }
}