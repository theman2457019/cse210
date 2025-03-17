abstract class Goal
{
    protected string name;
    protected string description;
    protected int points;
    protected bool isCompleted;
    public string Name => name;

    public Goal(string name, string description, int points)
    {
        this.name = name;
        this.description = description;
        this.points = points;
        this.isCompleted = false;
    }
    public abstract void Complete();
    public abstract void Display();
    public abstract void GetRep(out string type, out string name, out string description, out int points, out int target, out int bonus);

    protected void AddPoints(int points)
    {
        this.points += points;
    }

    public bool IsCompleted => isCompleted;
    public int Points => points;
}