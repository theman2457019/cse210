using System;
using System.Collections.Concurrent;

Random randomGenerator = new Random();
int number = randomGenerator.Next(1, 101);
//System.Console.WriteLine(number);

bool Correct = false;
System.Console.WriteLine("Guess a number between 1 and 100");
while (!Correct)

{
    int Guess = 0;
    System.Console.Write("What is your Guess? :");
    Guess = Convert.ToInt32(Console.ReadLine());
    if (Guess > number)
    {
        System.Console.WriteLine("Your guess is too high!");
    }
    else if (Guess < number)
    {
        System.Console.WriteLine("Your Guess is too low!");
    }
    else
    {
        System.Console.WriteLine("Congratulations! You guessed the number!");
        Correct = true;

        System.Console.Write("Play Again?y/n:");
        string Again = Console.ReadLine().ToLower();

        if (Again == "y")
        {
            Correct = false;
            number = randomGenerator.Next(1, 101); // Generate a new random number
                Console.WriteLine("A new number between 1 and 100 has been chosen!");
            
            
        }
        else if (Again == "n")
        {
            System.Console.WriteLine("Thanks for playing!");
        }
        else
        {
            System.Console.WriteLine("Invalid Input, Exiting game.");
        }

    }

}
