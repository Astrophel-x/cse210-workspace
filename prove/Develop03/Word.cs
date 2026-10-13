/* 
### Word
    *_word string
    * Status (hidden = T/F) - boolean?
    
> Display if word is hidded write underscores otherwise write the string
> Hide updates hidden attribute to true
*/
public class Word
{
    private string _txt;
    private bool _isHidden;

    // keeps track of the status of
    public Word(string txt)
    {
        _txt = txt;
        _isHidden = false;
    }

    public string GetDisplayText()
    {
        if (_isHidden == true)
        {
            // char needs single quotes
            return new string('_', _txt.Length);
        }
        else
        {
            return _txt;
        }
    }

// Scripture needs a way to flip the bool
    // void because it just wants to change the bool, does not return anything
    public void Hide()
    {
        _isHidden = true;
    }

    // would probably be just IsHidden, conventionally
    public bool GetIsHidden()
    {
        return _isHidden;
    }








}