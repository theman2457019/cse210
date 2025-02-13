 using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading;

class Program
{
    static void Main()
    {
        // Example scripture
        List<Scripture> scriptures = new List<Scripture>();
        Scripture scripture1 = new Scripture(new 
        Reference("Proverbs", 3, 5,6), 
            "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.");
        Scripture scripture2 = new Scripture(new
        Reference("John", 3, 16),
            "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
        Scripture scripture3 = new Scripture(new
        Reference("Philippians", 4, 13),
            "I can do all this through him who gives me strength.");
        Scripture scripture4 = new Scripture(new
        Reference("Jeremiah", 29, 11),
            "For I know the plans I have for you, declares the Lord, plans to prosper you and not to harm you, plans to give you hope and a future.");
        scriptures.Add(scripture1);
        scriptures.Add(scripture2);
        scriptures.Add(scripture3);
        scriptures.Add(scripture4);

        // Randomly select a scripture and hide words until all are hidden
        
        Random random = new Random();
        int index = random.Next(scriptures.Count);
        Scripture randScripture = scriptures[index];

        while (!randScripture.IsFullyHidden())
        {
            Console.Clear();
            Console.WriteLine(randScripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            
            string input = Console.ReadLine();
            if (input.ToLower() == "quit") break;

            randScripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine(randScripture.GetDisplayText());
        Console.WriteLine("\nAll words are hidden. Memorization complete!");
    }
}