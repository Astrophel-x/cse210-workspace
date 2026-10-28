using System.IO;
using System.Runtime.CompilerServices;
public class Journal
{

    //public string _newFile;
    public string _newPage;
    //public string _saveEntry;

    //public string _collection = "collection.txt";

    //public string _saveAllEntries;

    public string _displayAll;

    public string _currentFile = "collection.txt";



    public void CreateNewFile(string newFile)
    {
        _currentFile = newFile;

        File.Create(_currentFile).Close();

    }
    public void GetNewPage()
    {
        JournalEntry newPage = new JournalEntry();
        newPage.GetNewEntry(_currentFile);
    }


    public void DisplayAll()
    {

        using StreamReader read = new StreamReader(_currentFile);
        {
            string line;

            while ((line = read.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }



    


}





/* 


## [JOURNAL] 
    Attributes
    - Collection of [Journal Entries]


    Behaviors/Responsibilities   
        - Display all entries
        prints the contents and date of all entries
        *** potential place for extra mile requirement, provide additional sorting options ***

*/