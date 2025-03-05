using System.ComponentModel.DataAnnotations;

class Activity
{
    private string _name;
    private string _description;
    private int duration;

    public Activity()
    {
        _name = "";
        _description = "";
        duration = 0;
    }
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        this.duration = duration;
    }
    public void DisplayMenu()
    {
        Console.Clear();
        System.Console.WriteLine(" Welcome to the Mindfulness Program");
        System.Console.WriteLine("Please Select an Activity");
        System.Console.WriteLine("1. Breathing Activity");
        System.Console.WriteLine("2. Listing Activity");
        System.Console.WriteLine("3. Reflection Activity");
        System.Console.WriteLine("4. Quit");
    }

    public int PromptDuration()
    {
        System.Console.Write("Please enter how long (in seconds) you would like to do this activity:");
        duration = Convert.ToInt32(Console.ReadLine());
        return duration;
    }

     public void ShowGetReady()
    {
        Console.Write("Get Ready... ");
        Spinner spinner = new Spinner(3);
        spinner.ShowAnimation();
        Console.Clear();
    }

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}");
        System.Console.WriteLine(_description);
        Console.WriteLine("");
        ShowGetReady();
    }   
    }

   

