class ListingActivity : Activity
{
    private List<string> prompts = new List<string>();
    private int answerCount = 0;

    public ListingActivity()
    {
        
    }
    public void ExplainActivity()
    {
        Console.WriteLine("Welcome to the Enumeration activity. This activity will help you reflect on the things in your life by having you list them all out. We'll give you a prompt and then the activity will start.");
    }
    public void ShowHowMany()
    {
        Console.WriteLine(answerCount);
    }
    public override void Run()
    {
        ExplainActivity();

    }
}