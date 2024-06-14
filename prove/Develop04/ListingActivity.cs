class ListingActivity : Activity
{
    int durration;
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this Week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private int answerCount = 0;

    public ListingActivity()
    {
        
    }
    public void ExplainActivity()
    {
        Console.WriteLine("Welcome to the Enumeration activity.");
        Thread.Sleep(2000);
        Console.WriteLine("This activity will help you reflect on the things in your life by having you list them all out. We'll give you a prompt and then the activity will start.");
        Thread.Sleep(5000);
    }

    private void List()
    {
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(durration);
        DateTime currentTime = DateTime.Now;
        while(currentTime < futureTime)
        {
            Console.ReadLine();
            answerCount ++;
            Console.Clear();
            currentTime = DateTime.Now;
        }

    }
    
    public void ShowHowMany()
    {
        Console.WriteLine($"You listed {answerCount} things");
    }
    
    public override void Run()
    {
        ExplainActivity();
        durration = GetDurration();
        DisplayPrompt(prompts, 5);
        List();
        ShowHowMany();
        DisplayBye(durration);


    }
}