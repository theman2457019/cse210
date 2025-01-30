using System.Security.Cryptography.X509Certificates;

public class Entry
{
   public static string Prompt = PromptGen.Prompter();
   public DateTime now = DateTime.Now;
   public static string text = 
   

   public static void Display()
   {
        System.Console.WriteLine($"{DateTime.Now}");
        System.Console.WriteLine($"{Prompt}");
        string text = Console.ReadLine();
   }

    

}