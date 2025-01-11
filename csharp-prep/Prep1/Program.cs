using System;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("What is your First name?");
        string First = Console.ReadLine();
        System.Console.Write("What is yout Last name?");
        string Last = Console.ReadLine();
        System.Console.WriteLine("");
        System.Console.WriteLine($"Your name is {Last}, {First} {Last}.");
    }
}