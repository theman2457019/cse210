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
    static double SquareNumber(double number)
    {
        double squared = number * number; 
        return squared;
    }
    static void DisplayResults(string name, double Squared)
    {
        System.Console.WriteLine($"{name}, the sqare of your number is {Squared}");
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        double number = PromptUserNumber();
        double squared = SquareNumber(number);
        DisplayResults(userName, squared);
        
    }
}