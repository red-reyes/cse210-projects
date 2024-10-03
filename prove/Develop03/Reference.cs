public class Reference
{
    /*attributes
    _book:string
    _chapter:int
    _verse:int
    _endVerse:int*/
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    //constructor for single verse
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse; // endVerse is same for a single verse
    }

    //constructor for multiple verses
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    //method to return the formatted reference
    public string GetDisplayText()
    {
        if (_verse == _endVerse)
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }
}
