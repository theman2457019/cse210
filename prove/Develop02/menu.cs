class Menu
{
    public static void Display() 
    {
        System.Console.WriteLine("Welcome to your Journal! Select an option");
        System.Console.WriteLine($"1. Add an Entry \n2.Display Journal \n3.Load Journal \n4.Save to Journal \n5.Quit ");
    }
    public static int getChoice()
    {
        int choice = Int16.Parse(Console.ReadLine());
        return choice;
        
    }
}
