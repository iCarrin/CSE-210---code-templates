class MathAssignment : Assignment
{
    private string textbookSection;
    private string problems;

    public MathAssignment(string name, string topic, string section, string problems) : base(name, topic)
    {
        textbookSection = section;
        this.problems = problems;   
    }

    public string GetHomeworkList()
    {
        return ($"{textbookSection} {problems}");
    }

}
