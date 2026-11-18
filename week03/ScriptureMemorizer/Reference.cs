using System;

class Reference
{
    //atributes
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    // constructor
    public Reference(string book, int chapter, int verse)
    {
        _endVerse = 0;
        _book = book;
        _chapter = chapter;
        _verse = verse;

    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {

        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;

    }
    //methods

    public string GetDisplayText()
    {
        string reference;
        string verse;
        if (_endVerse != 0)
        {
            verse = _verse.ToString() + "-" + _endVerse.ToString();
        }
        else
        {
            verse = _verse.ToString();
        }
        reference = _book + " " + _chapter.ToString() + ":" + verse;
        return reference;
    }



}