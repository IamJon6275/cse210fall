using System;

public class Scripture
{

    // Reference object
    Reference _ref;
    // Initialize variables
    private List<Word> _words;

    // Create a constructor that turns a string into a list of class objects
    public Scripture(Reference objRef, string text)
    {
        // Privatize the reference object
        _ref = objRef;
        
        // Create new instance of _words list of class objects
        _words = new List<Word>();

        // Split the passed scripture string into multiple objects by spaces
        string[] strings = text.Split(' ');

        // Add each string from the scripture into the _words list each as a class object
        foreach (string w in strings)
        {
            Word newWord = new Word(w);
            _words.Add(newWord);
        }
    }

    // Display each word object in sequence seemlessly on a single line, hiding words as it goes
    public void DisplayScripture()
    {
        // Display the reference
        _ref.DisplayReference();
        // Randomly hides a word
        Random randomGenerator = new Random();
        int hidden = randomGenerator.Next(0, _words.Count());

        // Keeps track of the status of all words in the list
        bool status = _words[hidden].GetHiddenStatus();

        // Checks for hidden words to not hide the same word twice, this exceeds the requirements
        while (status == true)
        {
            int hiddenStatus = 0;
            hidden = randomGenerator.Next(0, _words.Count());
            status = _words[hidden].GetHiddenStatus();

            // If all words are hidden then the program terminates after the user presses enter
            foreach (Word word in _words)
            {
                word.GetHiddenStatus();
                if (word.GetHiddenStatus() == true)
                {
                    hiddenStatus++;
                }
                if (hiddenStatus == _words.Count())
                {
                    status = false;
                    Console.WriteLine("All words hidden, game over.");

                    // Forces the program to terminate
                    Environment.Exit(0);
                }
            }
        }

        // Sets the status of a word to hidden
        _words[hidden].HideWord();
        
        // Displays each word in line
        foreach (Word w in _words)
        {
            Console.Write($"{w.GetWord()} ");
        }
    }



}