using System;

class Program
{
    static void DisplayWelcome()
    {
        System.Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        System.Console.Write("Please Enter your name:");
        string Name = Console.ReadLine();
        return Name;
    }
    static double PromptUserNumber()
    {
        Console.Write("Please enter your Favorite number:");
        double number = Double.Parse(Console.ReadLine());
        return number;
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        double number = PromptUserNumber();
        double numberSquared = number * number;
        System.Console.WriteLine($"{userName}, the sqare of your number is {numberSquared}");
    }
}