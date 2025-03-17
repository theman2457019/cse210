class GoalManager
{
    private List<Goal> goals; // Private list of goals
    public int TotalScore { get; private set; }

    // Public property to expose the list of goals
    public List<Goal> Goals => goals;

    public GoalManager()
    {
        this.goals = new List<Goal>();
        TotalScore = 0;
    }

    public void RecordEvent(int index)
    {
        if (index >= 0 && index < goals.Count)
        {
            Goal goal = goals[index];
            goal.Complete();
            TotalScore += goal.Points;
            if (goal is ChecklistGoal && goal.IsCompleted)
                TotalScore += ((ChecklistGoal)goal).BonusPoints;
        }
    }

     public void AddGoal(Goal goal)
    {
        goals.Add(goal); // Add the goal to the list
    }
    public void DisplayGoals()
    {
        Console.WriteLine("Your Goals:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            goals[i].Display();
        }
    }


    public void SaveGoals()
    {
        using StreamWriter file = new StreamWriter("goals.txt");
        foreach (Goal goal in goals)
        {
            goal.GetRep(out string type, out string name, out string desc, out int points, out int target, out int bonus);
            file.WriteLine($"{type}|{name}|{desc}|{points}|{target}|{bonus}");
        }
        File.WriteAllText("score.txt", TotalScore.ToString());
    }
    public void LoadGoals()
    {
    if (File.Exists("goals.txt"))
    {
        string[] lines = File.ReadAllLines("goals.txt");
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length < 4) continue; // Skip invalid lines

            string type = parts[0];
            string name = parts[1];
            string desc = parts[2];
            int points = int.Parse(parts[3]);

            switch (type)
            {
                case "SimpleGoal":
                bool isCompleted = parts.Length > 4 && int.Parse(parts[4]) != 0;
                goals.Add(new SimpleGoal(name, desc, points, isCompleted));
                break;
                case "EternalGoal":
                    goals.Add(new EternalGoal(name, desc, points));
                    break;
                case "ChecklistGoal":
                    int target = parts.Length > 4 ? int.Parse(parts[4]) : 0;
                    int bonus = parts.Length > 5 ? int.Parse(parts[5]) : 0;
                    goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
                    break;
            }
    }
    if (File.Exists("score.txt"))
    {
        TotalScore = int.Parse(File.ReadAllText("score.txt"));
    }
}
}
}