using System;

// To show creativity and exceed requirements: 
// I used a "try-catch" code block in my FileStuff class when reading a file
// just in case the user enters in a file name that doesn't exist.
class Program
{
    static void Main(string[] args)
    {
        // _continue is set to true so the while loop can run once
        bool _continue = true;
        Journal j = new Journal();
        
        // Greet the user
        Console.WriteLine("Welcome to the Journal Program!");

        // While loop to call the different classes and loop the program until the user decides to quit
        while (_continue)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            
            int _selector = int.Parse(Console.ReadLine());

            
            _continue = j.HandleJournal(_selector);
        }
    }
}