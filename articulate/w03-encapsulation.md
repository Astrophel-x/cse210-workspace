# Encapsulation

## Encapsulation - Meaning

Encapsulation is the idea of closing off certain parts of the program - "encapsulating" those parts so that they cannot be accessed or manipulated by other code that does not need to do so. Ideas (objects/instances) are abstracted, so that a class encompasses the things that are relevant to itself, and those classes are then *encapsulated* so that other parts of the program are blocked off from those things. If necessary, other parts of the program will interact with that class, and then *that class* will access *its own* data as necessary. 

## Encapsulation - Benefit

It simplifies debugging, especially as your programs get more and more complex. If any code has access to absolutely everything, and then something goes wrong, there are a million places to look. And, conversely, if you have something that needs to change, or if you add something new to your code, any code that has access to that code or variable that was changed needs to then be updated. This would be very time consuming, pedantic, and lead to "shotgun surgery" which is basically a thing that happens when you want to change one little thing but then you have to change a bunch of other little things all over the place. This increases the liklihood of bugs. It makes your code harder to maintain. Encapsulation eliminates or at least reduces this need. 

## Encapsulation - Application

C# uses "access modifiers" to set attributes and methods to public or private, using "public" or "private" as the keyword itself. Attributes or methods, in general, should be kept private, and only made public as needed. Even then, oftentimes you do not need to make the variable public, but can make a public method that can get and set the variable. From there, other classes/parts of the code are able to utilize the public method instead of interact with the variable directly.

## Example

public class ScriptureLibrary
{
    private List<Scripture> _scriptures = new List<Scripture>();
    public void LoadScripture(string filepath)
    {
        string[] lines = File.ReadAllLines(filepath);
        foreach (string line in lines)
        {
            string[] section = line.Split("|");
            string bookName = section[0];
            int chapter = int.Parse(section[1]);
            int verse = int.Parse(section[2]);  
            int verse2 = int.Parse(section[3]);
            string verseText = section[4];
            Reference scripRef;
            if (verse2 == 0)
            {
                scripRef = new Reference(bookName, chapter, verse);
            }
            else
            {
                scripRef = new Reference(bookName, chapter, verse, verse2);
            }
            Scripture scripture = new Scripture(scripRef, verseText);
            _scriptures.Add(scripture);
        }      
    }

    public Scripture GetRandomScripture()
        {
            Random random = new Random();
            int index = random.Next(_scriptures.Count);
            return _scriptures[index];
        }
    public ScriptureLibrary(string filepath)
    {
        LoadScripture(filepath);
    }
}