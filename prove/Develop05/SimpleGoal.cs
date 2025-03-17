class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points, bool isCompleted = false)
        : base(name, description, points)
    {
        this.isCompleted = isCompleted;
    }

    public override void Complete()
    {
        isCompleted = true;
    }

    public override void Display()
    {
        Console.WriteLine($"[{(isCompleted ? "X" : " ")}] {name} - {description}");
    }

    public override void GetRep(out string type, out string name, out string description, out int points, out int target, out int bonus)
{
    type = "SimpleGoal";
    name = this.name;
    description = this.description;
    points = Points;
    target = 0;
    bonus = 0;
    // ADD THIS LINE TO SAVE COMPLETION STATUS
    File.AppendAllText("goals.txt", $"{type}|{name}|{description}|{points}|{isCompleted}\n");
}
}