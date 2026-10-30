




public class ScriptureLibrary
{
    private List<Scripture> _scriptures = new List<Scripture>();

    string filename = "doctrinalMasteryDAndC.txt";
    string filepathRelative;
    
    public void LoadScripture(string filename)
    {

        //hopeful pathing fix
        
        if (!File.Exists(filename))
        {
            filepathRelative = Path.Combine(AppContext.BaseDirectory, "..", "..", "..", filename);
        }
        else if (File.Exists(filename))
        {
            filepathRelative = "doctrinalMasteryDAndC.txt";
        }




        string[] lines = File.ReadAllLines(filepathRelative);
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