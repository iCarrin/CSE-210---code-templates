class BreathingActivity : Activity
{
    private int durration;
    public BreathingActivity() : base()
    {
        
    }

    private void Explain()
    {
        Console.WriteLine("Hi welcome to breathing activity.");
        Thread.Sleep(2000);
        Console.WriteLine("This activity will take you through a breathing exercise to help relax you.");
        Thread.Sleep(4000);
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
            Pause("Hold", 900);
            Pause("Breath out", 1100);
            Pause("Hold", 900);
            currentTime = DateTime.Now;
        }

    }
    public override void Run()
    {
        Explain();
        durration = GetDurration();
        Breath();
        DisplayBye(durration);
        
    }
 
}