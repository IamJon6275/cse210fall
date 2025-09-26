using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");
        List<int> numbers = new List<int>();

        string input;
        int number;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter number: ");
            input = Console.ReadLine();
            number = int.Parse(input);

            numbers.Add(number);
        } while(number != 0);

        int total = 0;

        foreach (int integer in numbers)
        {
            total += integer;
        }

        Console.WriteLine($"The sum is: {total}");

        float average = ((float)total) / (numbers.Count-1);
        Console.WriteLine($"The average is: {average}");

        int max = 0;

        foreach (int integer in numbers)
        {
            if (integer > max)
            {
                max = integer;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}