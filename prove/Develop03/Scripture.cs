

/*
### Scripture
    * _contents (<list> of Words)?
    * _reference (a Reference)
    * determine 
>Display
>HideWords

> SetReference
    * would need to communication with Words class 
    * 
*/

public class Scripture
{
    private List<Word> _words;
    private Reference _reference;

    public Scripture(Reference reference, string verseText)
    {
        _words = new List<Word>();
        _reference = reference;

        string[] wordSplit = verseText.Split(" ");
        foreach (string word in wordSplit)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }


    public void hideWords()
    {
        Random random = new Random();
        int amountHiddenThisRound = 0;
        int wordCount = _words.Count;

        while (amountHiddenThisRound < 3 && !AllHidden())
        {
            
            int index = random.Next(wordCount);

            bool status = _words[index].GetIsHidden();

            if (status == false)
            {
               _words[index].Hide();
                amountHiddenThisRound++;
            }
            

        }
    }

    public string GetDisplayText()
    {
        List<string> notHiddenWords = new List<string>();
        foreach (Word word in _words)
        {
            notHiddenWords.Add(word.GetDisplayText());
        }
        string verseText = string.Join(" ", notHiddenWords);
        return $"{_reference.GetReference()} \"{verseText}\"";
        
    }

    public bool AllHidden()
    {
        foreach (Word word in _words)
        {
            if (word.GetIsHidden() == false)
            {
                return false;
            }
        }
        return true;
    }


    

    
}