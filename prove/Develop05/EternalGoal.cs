class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override void Complete()
    {
        // Eternal goals are never marked complete
    }

    public override void Display()
    {
        Console.WriteLine($"[ ] {name} - {description}");
    }

 public override void GetRep(out string type, out string name, out string description, out int points, out int target, out int bonus)
{
    type = "EternalGoal";
    name = this.name;
    description = this.description;
    points = Points;
    target = 0;
    bonus = 0;
    File.AppendAllText("goals.txt", $"{type}|{name}|{description}|{points}\n");
}
}