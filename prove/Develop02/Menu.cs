
public class Menu
{
    public string _newJournal;

    public Journal _activeJournal = new Journal();
    public string _displayAll;
    public string _saveCollection;
    public string _loadCollection;


    public void DisplayMenu()
    {   

        string userInput = "";
        while (userInput != "7")
        {
            Console.WriteLine();
            Console.WriteLine("---------------------------------");
            Console.WriteLine();
            Console.WriteLine("Welcome to your Journal Bookshelf!");
            Console.WriteLine("Please select one of the following options:");
            Console.WriteLine("1 - Create a new journal");
            Console.WriteLine("2 - Write a new entry in your active journal");
            Console.WriteLine("3 - Display all entries in your active journal");
            Console.WriteLine("4 - View your active journal");
            Console.WriteLine("5 - Display all journals in your bookshelf (current directory)");
            Console.WriteLine("6 - Load a journal from your bookshelf (current directory)");
            Console.WriteLine("7 - Exit the program");
            Console.WriteLine();
            
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("> ");
            userInput = Console.ReadLine();
            Console.WriteLine();

            if (userInput == "1")
            {
                NewJournal();
            }
            else if (userInput == "2")
            {
                WriteNewEntry();
            }
            else if (userInput == "3")
            {
                _activeJournal.DisplayAll();
            }
            else if (userInput == "4")
            {
                Console.WriteLine($"Your active journal is currently {_activeJournal._currentFile}.");
            }
            else if (userInput == "5")
            {
                DisplayAllJournals();
            }
            else if (userInput == "6")
            {
                Console.WriteLine("You have chosen to load a journal from your bookshelf.");
                Console.WriteLine("What is the name of the journal you would like to load? Be sure to include '.txt' at the end!");
                Console.Write("> ");
                string loadName = Console.ReadLine();

                _loadCollection = loadName;
                _activeJournal._currentFile = _loadCollection;
                Console.WriteLine($"Your active journal has been loaded as {_loadCollection}.");
            }

            else if (userInput == "7")
            {
                Console.WriteLine("Thank you! Goodbye!");
            }

            else
            {
                Console.WriteLine("Input not recognized. Please double check your input and try again.");
            }
        }

    }





    public void DisplayAllJournals()
    {
        string[] bookshelf = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.txt");
        Console.WriteLine("Here are all of your journals in the current directory:");
        foreach (string journal in bookshelf)
        {
            Console.WriteLine(Path.GetFileName(journal));
        }
    }

    public void NewJournal()
    {
        Console.WriteLine("You have chosen to create a new journal.");
        Console.WriteLine("What would you like to name your new journal? Be sure to include '.txt' at the end!");
        Console.Write("> ");
        string newJournalName = Console.ReadLine();

        _newJournal = newJournalName;
        //Journal journal = new Journal();
        _activeJournal.CreateNewFile(_newJournal);
    }

    public void WriteNewEntry()
    {
        _activeJournal.GetNewPage();
    }

    
}





/* ## [Menu]
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
*/