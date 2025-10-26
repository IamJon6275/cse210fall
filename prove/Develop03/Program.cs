using System;

class Program
{
    static void Main(string[] args)
    {
        // _continue is set to true so the while loop can run once
        bool _continue = true;
        
        // Greet the user
        Console.WriteLine("Welcome to the Scripture Memorizer Program!");

        // While loop to call the different classes and loop the program until the user decides to quit
        while (_continue)
        {
            // Display selection menu
            Console.WriteLine("Please select one of the following choices (1-4 for a scripture, q to quit):");
            Console.WriteLine("1. John 14:6 Jesus saith unto him, I am the way, the truth, and the life: no man cometh unto the Father, but by me.");
            Console.WriteLine("2. 1 Nephi 3:7-9 And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord" +
            "hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may" +
            "accomplish the thing which he commandeth them. And it came to pass that when my father had heard these words he was exceedingly glad, for he" +
            "knew that I had been blessed of the Lord. And I, Nephi, and my brethren took our journey in the wilderness, with our tents, to go up to the land of Jerusalem.");
            Console.WriteLine("3. Proverbs 16:3 Commit to the Lord whatever you do, and your plans will succeed");
            Console.WriteLine("4. Random scripture");
            Console.WriteLine("5. to quit");
            Console.Write("What would you like to do? ");
            int _selector = int.Parse(Console.ReadLine());

            switch (_selector)
            {
                // Pass the reference and scripture for John 14:6 to the Reference and Scripture class
                case 1:
                    Reference john = new("John", 14, 6);
                    Scripture johnScript = new(john, "Jesus saith unto him, I am the way, the truth, and the life: no man cometh unto the Father, but by me.");
                    
                    // While loop to loop through the hiding process
                    while (_continue)
                    {
                        // john.DisplayReference();
                        johnScript.DisplayScripture();
                        Console.WriteLine("\nPlease press enter to continue, press 'q' to quit:");

                        string response = Console.ReadLine();
                        if (response == "q")
                        {
                            _continue = false;
                        }
                        Console.Clear();
                    }
                    break;

                // Pass the reference and scripture for 1 Nephi 3:7-9 to the Reference and Scripture class
                case 2:
                    Reference nephi = new("1 Nephi", 3, 7, 9);
                    Scripture nephiScript = new(nephi, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord " +
                    "hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may " +
                    "accomplish the thing which he commandeth them. And it came to pass that when my father had heard these words he was exceedingly glad, for he " +
                    "knew that I had been blessed of the Lord. And I, Nephi, and my brethren took our journey in the wilderness, with our tents, to go up to the land of " +
                    "Jerusalem.");
                    
                    // While loop to loop through the hiding process
                    while (_continue)
                    {
                        // nephi.DisplayReference();
                        nephiScript.DisplayScripture();
                        Console.WriteLine("\nPlease press enter to continue, press 'q' to quit:");

                        string response = Console.ReadLine();
                        if (response == "q")
                        {
                            _continue = false;
                        }
                        Console.Clear();
                    }
                    break;

                // Pass the reference and scripture for Proverbs 16:3 to the Reference and Scripture class
                case 3:
                    Reference proverbs = new("Proverbs", 16, 3);
                    Scripture proverbsSript = new(proverbs, "Commit to the Lord whatever you do, and your plans will succeed");
                    
                    // While loop to loop through the hiding process
                    while (_continue)
                    {
                        // proverbs.DisplayReference();
                        proverbsSript.DisplayScripture();
                        Console.WriteLine("\nPlease press enter to continue, press 'q' to quit:");

                        string response = Console.ReadLine();
                        if (response == "q")
                        {
                            _continue = false;
                        }
                        Console.Clear();
                    }
                    break;

                // Select a random scripture
                case 4:
                    Random randomGenerator = new Random();
                    int number = randomGenerator.Next(1, 3);
                    switch (number)
                    {
                        // Pass the reference and scripture for John 14:6 to the Reference and Scripture class
                        case 1:
                            Reference johnRand = new("John", 14, 6);
                            Scripture johnScriptRand = new(johnRand, "Jesus saith unto him, I am the way, the truth, and the life: no man cometh unto the Father, but by me.");
                            
                            // While loop to loop through the hiding process
                            while (_continue)
                            {
                                // johnRand.DisplayReference();
                                johnScriptRand.DisplayScripture();
                                Console.WriteLine("\nPlease press enter to continue, press 'q' to quit:");

                                string response = Console.ReadLine();
                                if (response == "q")
                                {
                                    _continue = false;
                                }
                                Console.Clear();
                            }
                            break;

                        // Pass the reference and scripture for 1 Nephi 3:7-9 to the Reference and Scripture class
                        case 2:
                            Reference nephiRand = new("1 Nephi", 3, 7, 9);
                            Scripture nephiScriptRand = new(nephiRand, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord " +
                            "hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may " +
                            "accomplish the thing which he commandeth them. And it came to pass that when my father had heard these words he was exceedingly glad, for he " +
                            "knew that I had been blessed of the Lord. And I, Nephi, and my brethren took our journey in the wilderness, with our tents, to go up to the land of " +
                            "Jerusalem.");
                            
                            // While loop to loop through the hiding process
                            while (_continue)
                            {
                                // nephiRand.DisplayReference();
                                nephiScriptRand.DisplayScripture();
                                Console.WriteLine("\nPlease press enter to continue, press 'q' to quit:");

                                string response = Console.ReadLine();
                                if (response == "q")
                                {
                                    _continue = false;
                                }
                                Console.Clear();
                            }

                            break;

                        // Pass the reference and scripture for Proverbs 16:3 to the Reference and Scripture class
                        case 3:
                            Reference proverbsRand = new("Proverbs", 16, 3);
                            Scripture proverbsSriptRand = new(proverbsRand, "Commit to the Lord whatever you do, and your plans will succeed");
                            
                            // While loop to loop through the hiding process
                            while (_continue)
                            {
                                // proverbsRand.DisplayReference();
                                proverbsSriptRand.DisplayScripture();
                                Console.WriteLine("\nPlease press enter to continue, press 'q' to quit:");

                                string response = Console.ReadLine();
                                if (response == "q")
                                {
                                    _continue = false;
                                }
                                Console.Clear();
                            }
                            break;
                    }
                    break;

                // End the program
                case 5:
                    _continue = false;
                    break;
            }
        }
    }
}