using System.Collections.ObjectModel;

public class JournalEntry
{
    public string _date;
    public string _prompt;
    //public string _saveEntry;

    public string _entry;

    //public List<Prompt> _prompts;


    public string GetDate()
    {
        
        _date = DateTime.Now.ToString("dd-MMM-yyyy, HH:mm:ss");

        return _date;

    }

    public string GetPrompt()
    {
        Prompts newRandomPrompt = new Prompts();
        
        _prompt = newRandomPrompt.GetRandomPrompt();

        return _prompt;
    }

    public void GetNewEntry(string fileName)
    {
        string date = GetDate();
        string prompt = GetPrompt();

        
        Console.WriteLine(date);
        Console.WriteLine();
        Console.WriteLine(prompt);
        Console.WriteLine();

        Console.WriteLine("Write 'DONE' on its own line when you are finished writing.");

        _entry = "";
        string newLine = "";

        using StreamWriter write = new StreamWriter(fileName, append: true);
        {
            write.WriteLine(date);
            write.WriteLine();
            write.WriteLine(prompt);
            write.WriteLine();


            

            while (newLine != "DONE")
            {
                
                Console.Write("> ");
                newLine = Console.ReadLine();

                

                // check if the line is "DONE" and only add the line if that is not the case
                if (newLine != "DONE")
                {
                    write.WriteLine(newLine);
                    _entry += newLine + "\n";
                }
            }
        
        // write the divider at the end of the entry into the file
        write.WriteLine();
        write.WriteLine("x-x-x-x-x-x-x-x-x-x");
        write.WriteLine();
        
            
        
        

        Console.WriteLine("x-x-x-x-x-x-x-x-x-x");
        Console.WriteLine();
        Console.WriteLine("Your entry has been saved.");

        }
    }


   // public v


    // public string GetPrompt()
    // {
    //     Prompts randomPrompt = new Prompts();

    //     _prompt = randomPrompt.GetRandomPrompt();

    //     return _prompt;
    // }



}


/* ###    [Journal Entry]



        Attributes: 
            date int
            content String
            prompts (list of prompts)
            

        Behaviors/Responsibility
            - Collect {date} 
                prompt the user for the day they are writing for OR auto collect from device - TBD
            - Display /random/ prompt from list
                prompt the user with one of our promts list to help them write a new entry

                */