// ABOVE AND BEYOND: Allows User to create a new journal (txt file) and swap freely between all the ones that they have created. Allows user to see active journal and swap which journal is active/that they want to write in. 


using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hello Develop02 World!");

        //Menu test = new Menu();
        //test.DisplayAllJournals();

        // set path so it works in dotnet run OR debugger
        
        while (!File.Exists("Program.cs"))
        {
            Directory.SetCurrentDirectory("..");
        }


        





        Menu menu = new Menu();
        menu.DisplayMenu();

        /* 
        
# Potential Classes:

## [Menu]
    Attributes:
        - Pass responsibility to proper place


    Behaviors/Responsibilities:

    - || NEW ENTRY       ||
        if the user wants a new entry call the entry new method
    - || DISPLAY ALL     ||
        if the user wants to see the journal call the journal display method
    - || SAVE COLLECTION ||
        if the user wants to save their journal prompt them for a file name an save
    - || LOAD COLLECTION || 
        if the user wants to load their journal prompt them for a file name an load

## [JOURNAL] 
    Attributes
    - Collection of [Journal Entries]


    Behaviors/Responsibilities   
        - Display all entries
        prints the contents and date of all entries
        *** potential place for extra mile requirement, provide additional sorting options ***


###    [Journal Entry]

        Attributes: 
            date int
            content String
            prompts (list of prompts)
            

        Behaviors/Responsibility
            - Collect {date} 
                prompt the user for the day they are writing for OR auto collect from device - TBD
            - Display /random/ prompt from list
                prompt the user with one of our promts list to help them write a new entry
            - 





            | NEW ENTRY |
                > asks for OR collects date 
                > Displays prompt
                
    */










    }
}