class BreathingActivity : Activity
{
    public BreathingActivity(string _name, string _description, int _duration):base(_name, _description, _duration)
    {
        string name = _name;
        string description = _description; 
        int duration = _duration;
    }

    public void countdown()
    {
    List <string> countdown = new List<string> {"4","3","2","1"};
        foreach (string s in countdown)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    

    public void DoBreathingActivity(int duration)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        //DateTime currentTime = DateTime.Now;
        while (DateTime.Now < endTime){
            Console.Write("Breathe in... ");
            countdown();
            System.Console.WriteLine("");
            Console.Write("Hold... ");
            countdown();
            System.Console.WriteLine("");
            Console.Write("Breathe out... ");
            countdown();
            System.Console.WriteLine("");
            Console.Write("Hold... ");
            countdown();
            System.Console.WriteLine("");
        }

        Console.WriteLine("Time is up! Thank you for participating in the Breathing Activity");
        System.Console.WriteLine("Press any key to return to the main menu");
        Console.ReadKey();
    }
}