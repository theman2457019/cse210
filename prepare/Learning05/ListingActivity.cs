class ListingActivity : Activity
{
    private List<string> prompts;
    private List<string> responses;

    public ListingActivity(string name, string description, int duration) 
        : base(name, description, duration)
    {
        prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        responses = new List<string>();
    }

    public void StartListingActivity(int duration)
    {
        Random random = new Random();
        int index = random.Next(prompts.Count); // Get a random index
        
        string randomPrompt = prompts[index]; // Get the random string
        Console.WriteLine(randomPrompt); // Display the random string
        ShowGetReady();
        Console.WriteLine(randomPrompt);
        Console.WriteLine("Go!");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            string response = Console.ReadLine();
            responses.Add(response);
        }   
        Console.WriteLine($"Time is up! Nice Work! You did {responses.Count} responses!");
        System.Console.WriteLine("Press any key to return to the main menu");
        Console.ReadKey();
    }
}