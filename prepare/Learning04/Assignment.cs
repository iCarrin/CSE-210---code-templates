class Assignment
{
    private string studentName;
    private string topic;
    public Assignment( string name, string topic )
    {
        studentName = name;
        this.topic = topic;
    }

    public string GetSummery()
    {
        return ($"{studentName} - {topic}");
    }
}