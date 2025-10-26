using System;

public class Word
{

    // Initialize variables
    private string _word;
    private bool _scriptureHidden;

    // Create a constructor that allows private variable _word to be manipulated
    public Word(string word)
    {
        _word = word;
    }

    // Get and return either the word from the scripture or the equivalent number of dashes depending on the _scriptureHidden boolean variable
    public string GetWord()
    {
        return _scriptureHidden ? new('_', _word.Length) : _word;
        // above code is the below code, taught by a tutor at the drop in lab
        // if (_scriptureHidden)
        // {
        //     return new('_', _word.Length);
        // }
        // else
        // {
        //     return _word;
        // }
    }

    // Getter for the status of a word that sends the status to the Scripture class
    public bool GetHiddenStatus()
    {
        return _scriptureHidden;
    }

    // Flips the _scriptureHidden variable to true
    public void HideWord()
    {
        _scriptureHidden = true;
    }
}