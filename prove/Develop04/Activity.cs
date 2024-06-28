abstract class Activity
{
    Random random= new Random();   
    private string[] animationList = 
        {
        "╔══╗\n║  ║\n╚══╝",
        "╔═ ╗\n║  ║\n╚══╝",
        "╔═  \n║  ║\n╚══╝",
        "╔═  \n║   \n╚══╝",
        "╔═  \n║  \n╚══ ",
        "╔═  \n║  \n╚═  ",
        "╔═  \n║   \n╚   ",
        "╔═  \n║   \n    ",
        "╔═ \n    \n    ",
        " ═ \n    \n    ",
        "   \n   \n    ",
        "  ═ \n    \n    ",
        "  ═╗\n    \n    ",
        "  ═╗\n   ║\n    ",
        "  ═╗\n   ║\n   ╝",
        "  ═╗\n   ║\n  ═╝",
        "  ═╗\n   ║\n ══╝",
        "  ═╗\n   ║\n╚══╝",
        "  ═╗\n║  ║\n╚══╝",
        "╔ ═╗\n║  ║\n╚══╝",
        "╔══╗\n║  ║\n╚══╝"
        }; 
    public Activity()
    {
        
    }
    
    public int GetDurration()
    {
        
        Console.WriteLine("How long do you want to do this acticity for? (in seconds)");
        int durration = int.Parse(Console.ReadLine());
        //Console.WriteLine("the value give was {}")
        return durration;
    }

    public void Wait(int timeToWait)
    {
        
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(timeToWait);
        DateTime currentTime = DateTime.Now;
        while(currentTime < futureTime)
        {   
            Console.CursorVisible = false;
            TimeSpan timeWait = futureTime-currentTime;
            for (int i = 0; i < animationList.Length; i++)
               {

                Thread.Sleep(50);
                Console.CursorVisible = false;
                Console.Write(animationList[i]);
                Console.CursorVisible = false;
                Console.SetCursorPosition(1,Console.CursorTop-1);
                Console.CursorVisible = false;
                Console.Write(timeWait.Seconds);
                Console.CursorVisible = false;
                Console.SetCursorPosition(0,Console.CursorTop-1);
                Console.CursorVisible = false;
                currentTime = DateTime.Now;
               }
        }
        
        Console.CursorVisible = true;
        Console.Clear();
    }
    public void DisplayPrompt(List<string> which, int waitTime)
    {
        int pos = random.Next(0, which.Count);
        Console.WriteLine(which[pos]);
        Wait(waitTime);
        
    }
    public void DisplayBye(int time)
    {
        Console.WriteLine($"You did this for {time} seconds. Have a peaceful day");
        Thread.Sleep(4000);
        Console.Clear();
    }

     public abstract void Run();
    
    
}