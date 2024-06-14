class ReflectionActivity : Activity
{
    private List<string> postulations = new List<string>
    {
        "Think of a time when you overcame a significant challenge.", 
        "Think of a time when you learned something new about yourself.", 
        "Think of a time when you made a positive impact on someone's life.", 
        "Think of a time when you had to make a tough decision.", 
        "Think of a time when you forgave someone who hurt you.", 
        "Think of a time when you showed kindness to a stranger.", 
        "Think of a time when you took a risk and it paid off.", 
        "Think of a time when you stood by your values despite opposition.", 
        "Think of a time when you received unexpected help or support.", 
        "Think of a time when you failed but learned an important lesson.", 
        "Think of a time when you collaborated with others to achieve a goal.", 
        "Think of a time when you had to adapt to a new situation.", 
        "Think of a time when you felt truly grateful.", 
        "Think of a time when you had to apologize and make amends.", 
        "Think of a time when you inspired someone else.", 
        "Think of a time when you were patient in a difficult situation.", 
        "Think of a time when you achieved something you once thought impossible.", 
        "Think of a time when you stood up for your beliefs.", 
        "Think of a time when you discovered a new passion or interest.", 
        "Think of a time when you experienced a moment of pure joy."
    };
    private List<string> reflections = new List<string>
    {
        "How did this experience change you?",
        "What challenges did you face and how did you overcome them?",
        "What were your initial thoughts and feelings going into this experience?",
        "What did you discover about others through this experience?",
        "What role did others play in your experience?",
        "How did this experience impact your perspective?",
        "What skills or qualities did you develop during this experience?",
        "How did you stay motivated throughout the experience?",
        "What was the most difficult part of this experience?",
        "What surprised you about this experience?",
        "What would you do differently if you had to do it again?",
        "What advice would you give someone going through a similar experience?",
        "How did this experience align with your values?",
        "What was the most rewarding part of this experience?",
        "What feedback did you receive from others about this experience?",
        "How did this experience influence your goals?",
        "What resources or support helped you during this experience?",
        "What emotions did you feel during different stages of this experience?",
        "What would you like to remember about this experience in the future?",
        "How has this experience shaped your future actions or decisions?"
    };  
    Random random= new Random(); 
    int durration;

    public ReflectionActivity()
    {

    }
    private void ExplainReflection()
    {
        Console.WriteLine("Welcome to the reflection activity.");
        Thread.Sleep(1000);
        Console.WriteLine("We will give you a prompt to reflect upon, and, once you've had time to ponder it, we will give you a seires of questions to help you reflect on that prompt. The time will start after you have reflected on the prompt a little.");
        Thread.Sleep(5000);
    }

    // private void DisplayPrompt(List<string> which, int waitTime)
    // {
    //     int pos = random.Next(0, which.Count);
    //     Console.WriteLine(which[pos]);
    //     Wait(waitTime);
        
    // }
    private void Reflect()
    {
        Console.Clear();
        DisplayPrompt(postulations, 10);
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(durration);
        DateTime currentTime = DateTime.Now;
        while(currentTime < futureTime)
        {
            DisplayPrompt(reflections, 5);
            currentTime = DateTime.Now;
        }

    }
    public override void Run()
    {
        ExplainReflection();
        durration = GetDurration();
        Reflect();
        DisplayBye(durration);

    }
}