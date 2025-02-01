using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

public class Entry
{
      public string _date;
      public string _prompt;
      public string _text; 
   
   
   public string GetDate()
   {
      return DateTime.Now.ToString("dd/MM/yy");
   }

   public void Display()
   {
        System.Console.WriteLine(_date);
        System.Console.WriteLine(_prompt);
        System.Console.WriteLine(_text);
   }

    

}