class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    // Add a public property to expose bonus points
    public int BonusPoints => _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _currentCount = 0;
    }

    public override void Complete()
    {
        _currentCount++;
        if (_currentCount >= _targetCount)
        {
            isCompleted = true;
            AddPoints(_bonusPoints); // Add bonus points upon completion
        }
    }

    public override void Display()
    {
        string status = isCompleted ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {name} - {description} (Completed {_currentCount}/{_targetCount} times)");
    }

    public override void GetRep(out string type, out string name, out string description, out int points, out int target, out int bonus)
{
    type = "ChecklistGoal";
    name = this.name;
    description = this.description;
    points = Points;
    target = _targetCount;
    bonus = _bonusPoints;
    File.AppendAllText("goals.txt", $"{type}|{name}|{description}|{points}|{target}|{bonus}\n");
}
}