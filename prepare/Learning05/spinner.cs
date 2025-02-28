class Spinner
{
    private List<string> animation;
    private int duration;

    public Spinner(int duration)
    {
        animation = new List<string> { "|", "/", "-", "\\" };
        this.duration = duration;
    }

    public void ShowAnimation()
    {
        DateTime starttime = DateTime.Now;
        DateTime endtime = starttime.AddSeconds(duration);

        while (DateTime.Now < endtime)
        {
            foreach (string s in animation)
            {
                Console.Write(s);
                System.Threading.Thread.Sleep(300);
                Console.Write("\b \b");
            }
        }
    }
}