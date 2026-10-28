
/*

### Reference
    * _contents (string)
    * would keep track of the book, chapter, and verse(s)

>Display
>GetReference

#### constructors
    

    public Reference(string bookName, int chapter, int verse)
        would return $"{bookName} {chapter}: {verse}"

    public Reference(string bookName, int chapter, int verse, int verse2)
        would return $"{bookName} {chapter}: {verse} - {verse2}"

*/

public class Reference
{
    private string _bookName;
    private int _chapter;
    private int _verse;
    private int _verse2; 


// if only 1 verse
    public Reference(string bookName, int chapter, int verse)
    {
        _bookName = bookName;
        _chapter = chapter;
        _verse = verse;
        _verse2 = 0;
    }

// if a range of verses
    public Reference(string bookName, int chapter, int verse, int verse2)
    {
        _bookName = bookName;
        _chapter = chapter;
        _verse = verse;
        _verse2 = verse2;
    }
    

// getter for ref, return as stringDoctrine and Covenants |
    public string GetReference()
    {
        if (_verse2 == 0)
        {
            return $"{_bookName} {_chapter}:{_verse}\n";
        }
        else
        {
            return $"{_bookName} {_chapter}:{_verse}-{_verse2}\n";
        }
    }

}