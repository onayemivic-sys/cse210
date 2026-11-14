using System.Data;

public class Reference
{
    //private field to protect reference info
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerseNumber;

    // A missing end verse indicates a single verse.
    public Reference(string book, int chapter, int startVerse, int? endVerse = null)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerseNumber = endVerse ?? startVerse;
    }

    // return the complete scripture reference.
    public string GetDisplayText()
    {
        if (_startVerse == _endVerseNumber)
        {
            return $"{_book} {_chapter}:{_startVerse}";
        }
        return $"{_book} {_chapter}:{_startVerse}-{_endVerseNumber}";
    }
}