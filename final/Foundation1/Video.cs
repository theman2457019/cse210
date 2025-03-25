using System.ComponentModel;

class Video
{
    public string _title;
    public string _author;
    public int _duration;
    private List<Comment> comments = new List<Comment>();
    

    public Video(string _title
    , string _author, int _duration, List<Comment> _comments)
    {
        this._title = _title;
        this._author = _author;
        this._duration = _duration;
        this.comments = _comments;
    }

    public void Display()
    {
        Console.WriteLine($"{_title}|{_author}|{_duration}");
        Console.WriteLine("Comments:");
        foreach (Comment comment in comments)
        {
            Console.WriteLine($"{comment.commentor}| {comment.text}");
        }
        System.Console.WriteLine();
    }

    public void AddComment(string commentor, string text)
    {
        Comment comment = new Comment(commentor, text);
        comments.Add(comment);
    }
 
}