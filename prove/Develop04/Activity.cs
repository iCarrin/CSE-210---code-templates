abstract class Activity
{
    // private int pause = 1000;
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
    // public int SetPause(int pause)
    // {
    //     return pause;
    // }
    public void Wait(int durration)
    {
        string[] animationList = {"╔═╗\n╚═╝"," ═╗\n╚═╝","  ╗\n╚═╝","   \n╚═╝","   \n╚═ ","   \n╚  ","╔  \n   ","╔═ \n   ","╔═╗\n   ","╔═╗\n  ╝","╔═╗\n ═╝","╔═╗\n╚═╝"};
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(durration);
        DateTime currentTime = DateTime.Now;
        while(currentTime < futureTime)
        {   
            Console.CursorVisible = false;
            // Thread.Sleep(100);
            for (int i = 0; i < animationList.Length; i++)
               {
                Thread.Sleep(100);
                Console.Write(animationList[i]);
                Console.SetCursorPosition(0,Console.CursorTop-1);
                Console.Write("\0");
                currentTime = DateTime.Now;
               }
        }
        Console.CursorVisible = true;
    }
    public void DisplayBye(int time)
    {
        Console.WriteLine($"You did this for {time} seconds. Have a peaceful day");
    }

     public abstract void Run();
    
    
}