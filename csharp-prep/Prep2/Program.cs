using System;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
    string LetterGrade = "";
    bool passed = false;
    
    Console.Write("Enter Grade:");
    Double Grade = Convert.ToDouble(Console.ReadLine());
    
            if (Grade >= 90.0)
            {
                LetterGrade = "A";
                passed = true;
            }
            else if (Grade >= 80.0)
            {
                LetterGrade = "B";
                passed = true;
            }
            else if (Grade >= 70.0)
            {
                LetterGrade = "C";
                passed = true;
            }
            else if (Grade >= 60.0)
            {
                LetterGrade = "D";
            }
            else
            {
                LetterGrade = "F";
            }
           
            System.Console.WriteLine($"Your Grade of {Grade}% is a {LetterGrade}.");
            if (passed)
            {
                System.Console.WriteLine("Congradulations! You Passed!");
            }
            else
            {
                System.Console.WriteLine("Sorry, you Failed. Better luck next time!");
            }
            
        }
}