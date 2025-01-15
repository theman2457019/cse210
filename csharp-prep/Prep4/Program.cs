using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter numbers, Enter '0' when done:");

        int input;
        do
        {
            Console.Write("Enter Number: ");
            input = int.Parse(Console.ReadLine());

            if (input != 0) // Don't add 0 to the list
            {
                numbers.Add(input);
            }
        }
        while (input != 0);

        if (numbers.Count > 0)
        {
            int sum = 0;
            int smallestPostive = 1000000000;
            numbers.Sort();
            System.Console.WriteLine("The List Sorted:");
            foreach (int number in numbers)
            {
                sum += number;
                System.Console.WriteLine(number);
                if (number > 0)
                {
                    if (number < smallestPostive)
                    {
                        smallestPostive = number;
                    }
                }
                
            }
            double average = (double)sum / numbers.Count;
            

            Console.WriteLine($"The Sum is {sum}");
            Console.WriteLine($"The Average is {average}");
            System.Console.WriteLine($"The Smallest Positive number is {smallestPostive}");
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}