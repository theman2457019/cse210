class PromptGen
{
     

    public static string Prompter ()
    {
        List<string> Prompts = new List<string>
        {"What was the best and worst part of your day?",
        "What is one thing you learned about yourself today?",
        "How have you seen the hand of God in your life today?",
        "Write about today from the perspective of someone else (a stranger, pet, or even an object).",
        "If you could redo today, what would you change?",
        "What is a moment from today you want to remember?",
        "What is the funniest thing that happened to you today?",
        "What is something you did today that you are proud of?"};

       Random rand = new Random();
       int index = rand.Next(Prompts.Count);
       string randomPrompt = Prompts[index];
       return randomPrompt;
    }
}