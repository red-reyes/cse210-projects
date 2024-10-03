public class Word
{
    //attributes for Word
    private string _text;
    private bool _isHidden;

    //constructor
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    //hide the word
    public void Hide()
    {
        _isHidden = true;
    }

    //show the word
    public void Show()
    {
        _isHidden = false;
    }

    //check if word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    //get the didsplay text, hide the word if it's hidden
    public string GetDisplayText()
    {
        if (_isHidden)
            return "_____"; // replace the words with underscores
        else
            return _text;
    }
}