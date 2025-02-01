class Menu
{
    public void Display() 
    {
        System.Console.WriteLine("");
        System.Console.WriteLine($"1. Add an Entry \n2.Display Journal \n3.Load Journal \n4.Save to Journal \n5.Delete Entries \n6.Quit ");
    }
    public int getChoice()
    {
        System.Console.Write("Enter your choice: ");
        int choice = Int16.Parse(Console.ReadLine());
        return choice;
        
    }
}
