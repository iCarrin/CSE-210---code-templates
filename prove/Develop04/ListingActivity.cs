class ListingActivity : Activity
{
    private List<string> prompts = new List<string>();
    private int answerCount = 0;

    public ListingActivity()
    {
        
    }
    public void ExplainActivity()
    {
        Console.WriteLine("sub bru. Here's the activity");
    }
    public void ShowHowMany()
    {
        Console.WriteLine(answerCount);
    }
}