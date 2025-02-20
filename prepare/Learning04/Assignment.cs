using System.Dynamic;

public class Assignment{

    protected private string _studentName;
    private string _topic;

    public Assignment(string studentName, string topic){
        _studentName = studentName;
        _topic = topic;
    }

    public string GetName(){
        return _studentName;
    }

    public string GetTopic(){
        return _topic;
    }

    public string GetSummary(){
        return _studentName + "-" + _topic;
    }
}