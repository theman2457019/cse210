class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.LoadGoals();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Eternal Quest - Main Menu");
            Console.WriteLine($"Current Score: {manager.TotalScore}");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save & Exit");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Clear();
                    CreateGoal(manager);
                    break;
                case "2":
                    Console.Clear();
                    manager.DisplayGoals();
                    Console.WriteLine("\nPress any key to return to the menu...");
                    Console.ReadKey();
                    break;
                case "3":
                    Console.Clear();
                    RecordEvent(manager);
                    break;
                case "4":
                    Console.Clear();
                    manager.SaveGoals();
                    return;
            }
        }
    }

    static void CreateGoal(GoalManager manager)
    {
        Console.WriteLine("Select Goal Type:");
        Console.WriteLine("1. Simple");
        Console.WriteLine("2. Eternal");
        Console.WriteLine("3. Checklist");
        string type = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string desc = Console.ReadLine();
        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "1":
                manager.AddGoal(new SimpleGoal(name, desc, points));
                break;
            case "2":
                manager.AddGoal(new EternalGoal(name, desc, points));
                break;
            case "3":
                Console.Write("Target Count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Bonus Points: ");
                int bonus = int.Parse(Console.ReadLine());
                manager.AddGoal(new ChecklistGoal(name, desc, points, target, bonus));
                break;
        }
    }

    static void RecordEvent(GoalManager manager)
    {
        Console.Clear();
        Console.WriteLine("Select a goal to record:");
        for (int i = 0; i < manager.Goals.Count; i++)
            Console.WriteLine($"{i + 1}. {manager.Goals[i].Name}");
        int index = int.Parse(Console.ReadLine()) - 1;
        manager.RecordEvent(index);
    }
}