class ReflectionActivity : Activity
{
     private List<string> prompts;
    private List<string> questions;

   public ReflectionActivity(string name, string description, int duration) 
        : base(name, description, duration)
        {
            prompts = new List<string>
            {
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless."
            };

            questions = new List<string>
            { 
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?"
            };
        }

   public void StartReflectionActivity(int duration)
{
    Random random = new Random();  // Create Random instance once
    int promptIndex = random.Next(prompts.Count); // Get a random index for prompts
    
    string randomPrompt = prompts[promptIndex]; // Get the random prompt
    Console.WriteLine(randomPrompt); // Display the random prompt
    ShowGetReady();
    Console.WriteLine(randomPrompt);

    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(duration);
    Spinner spinner = new Spinner(5);

    while (DateTime.Now < endTime)
    {
        spinner.ShowAnimation();
        
        int questionIndex = random.Next(questions.Count); // Get a new random question index
        string randomQuestion = questions[questionIndex]; // Get the random question
        Console.WriteLine(randomQuestion); // Display the new random question
    }   

    System.Console.WriteLine("Time is up! Nice Work!");
    System.Console.WriteLine("Press any key to return to the main menu");
    Console.ReadKey();
}
}