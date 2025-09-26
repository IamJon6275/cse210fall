using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        bool game = true;
        while (game == true)
        {
            // Console.WriteLine("Hello Prep3 World!");
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 101);

            // Console.WriteLine($"Your random number is {number}");
            bool guessed = false;
            int turns = 1;
            while (guessed == false)
            {
                Console.Write("Please enter your guess: ");
                int guess = int.Parse(Console.ReadLine());
                if (guess > number)
                {
                    Console.WriteLine("Lower");
                    turns += 1;
                }
                else if (guess < number)
                {
                    Console.WriteLine("Higher");
                    turns += 1;
                }
                else
                {
                    Console.WriteLine("Correct!");
                    guessed = true;
                }
            }
            
            Console.WriteLine($"it took you {turns} turns to guess the number");
            // Console.WriteLine($"They guessed {answer}");

            Console.Write($"Play Again?(yes/no) ");
            string answer = Console.ReadLine();
            if (answer != "yes")
            {
                game = false;
            }
        }
    }
}