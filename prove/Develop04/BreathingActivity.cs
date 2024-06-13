class BreathingActivity : Activity
{
    private int durration;
    public BreathingActivity() : base()
    {
        
    }

    private void Explain()
    {
        Console.WriteLine("Hi welcome to breathing activity.");
        Console.WriteLine("This activity will take you through a breathing exercise to help relax you.");

    }
    private void Pause(string inOut, int time)
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Clear();
            Console.WriteLine(inOut.PadRight(inOut.Length+i-2, '.'));
            Thread.Sleep(time);
            

        }   
    }
    private void Breath()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(durration);
        DateTime currentTime = DateTime.Now;
        while(currentTime < futureTime)
        {
            Pause("Breath in", 800);
            Pause("Hold", 1000);
            Pause("Breath out", 1100);
            Pause("Hold", 1000);
            currentTime = DateTime.Now;
        }

    }
    public override void Run()
    {
        Explain();
        durration = GetDurration();
        // TimeActivity(durration, Breath());
        Breath();
        DisplayBye(durration);
        
    }
    // private delegate void Breath()
    // {
    //         Pause("Breath in", 800);
    //         Pause("Hold", 1000);
    //         Pause("Breath out", 1100);
    //         Pause("Hold", 1000);

    // }
    
}