class ReflectionActiity
{
    private List<string> prompts = new List<string>();
    private List<string> postPrompts = new List<string>();  

    public ReflectionActiity()
    {

    }
    public void ExplainReflection()
    {
        Console.WriteLine("Here's how you reflect");
    }
    public void DisplayPrompt(int pos)
    {
        Console.WriteLine(prompts[pos]);
        Console.ReadLine();
        Console.WriteLine(postPrompts[pos]);
        Console.ReadLine();
        
    }


}