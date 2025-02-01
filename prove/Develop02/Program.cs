using System;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        Menu newmenu = new Menu();
        bool choiceGood = false;
        Journal newJournal = new Journal();
        System.Console.WriteLine("");
        System.Console.WriteLine("Welcome to your Journal! Select an option:");
        System.Console.WriteLine("");

        while (!choiceGood)
        {
            newmenu.Display();
            int chosen = newmenu.getChoice();
            // System.Console.WriteLine($"Chosen option: {chosen}");

            if (chosen == 1)
            {
                Entry newEntry = new Entry();
                PromptGen prompter = new PromptGen();

                string date = newEntry.GetDate();
                newEntry._date = date;
                string prompt = prompter.GetPrompt();
                newEntry._prompt = prompt;
                System.Console.WriteLine("");
                System.Console.WriteLine($"Date: {date}");
                System.Console.WriteLine($"Prompt: {prompt}");
                System.Console.Write("Enter your journal entry: ");
                newEntry._text = Console.ReadLine();

                //newEntry.Display();
                newJournal.AddEntry(newEntry);
                System.Console.WriteLine("Entry Received");
            }
            else if (chosen == 2)
            {
                //System.Console.WriteLine("Display Journal");
                System.Console.WriteLine("");
                newJournal.Display();
                
            }
            else if (chosen == 3)
            {
                newJournal.Load();
                System.Console.WriteLine("Journal loaded.");
            }
            else if (chosen == 4)
            {
                newJournal.Save();
                System.Console.WriteLine("Saved to Journal");
            }
            else if (chosen == 5)
            {
                newJournal.Delete();
                System.Console.WriteLine("Entries Deleted");
            }
            else if (chosen == 6)
            {
                System.Console.WriteLine("Quit");
                choiceGood = true;
            }
            else
            {
                System.Console.WriteLine("Invalid choice, please try again.");
            }
        }
    }
}