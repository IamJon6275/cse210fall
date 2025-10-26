using System;
using System.Dynamic;

public class Reference
{
    // Initialize variable
    private string _refer;

    // Constructor for single verse scriptures
    public Reference(string _book, int _chapter, int _startVerse)
    {
        _refer = $"{_book} {_chapter}:{_startVerse} ";
    }

    // Constructor for multiple verse scriptures
    public Reference(string _book, int _chapter, int _startVerse, int _endVerse)
    {
        _refer = $"{_book} {_chapter}:{_startVerse}-{_endVerse} ";
    }

    // Displays the reference seperate from the verse(s), the reference is never hidden
    public void DisplayReference()
    {
        Console.Write(_refer);
    }
    
}