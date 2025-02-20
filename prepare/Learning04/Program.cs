using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment mathAssignment = new MathAssignment("John Doe", "Algebra", "7.1", "1-10");
        Console.WriteLine(mathAssignment.GetSummary());
        System.Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("Jane Smith", "Narrative", "Write a short story");
        Console.WriteLine(writingAssignment.GetSummary());
        System.Console.WriteLine(writingAssignment.GetWritingInfo());
    }
}