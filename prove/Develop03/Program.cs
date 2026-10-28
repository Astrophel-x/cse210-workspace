using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        Directory.SetCurrentDirectory("C:/Users/asher/Desktop/CSE 210/cse210-workspace/prove/Develop03");

        bool playing = true;

        while (playing)
        {
            ScriptureLibrary library = new ScriptureLibrary("doctrinalMasteryDAndC.txt");
            
            Scripture randomScrip = library.GetRandomScripture();

            while (true)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Welcome. Here is a random scripture from the D&C Doctrinal Mastery list:");
                Console.WriteLine();

                Console.WriteLine(randomScrip.GetDisplayText());

                if (randomScrip.AllHidden())
                {
                    break;
                }

                Console.WriteLine();
                Console.WriteLine("Press enter to hide three more words. Type 'quit' to end the round.");

                string userInput = Console.ReadLine();
                if (userInput == "quit")
                {
                    break;
                }

                randomScrip.hideWords();

            }

            Console.WriteLine();
            Console.WriteLine("Would you like to study another scripture? Type 'N' to quit or any other key to continue. \n");
            Console.Write("> ");
            string userInputPlaying = Console.ReadLine();

            if (userInputPlaying.ToUpper() == "N")
            {
                playing = false;
                break;
            }
        }
        
    }
}