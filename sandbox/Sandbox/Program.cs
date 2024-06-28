using System;

class Program
{
    static void Main(string[] args)
    {
        string[] animationList = {"𐤕", "𐤈", "𐤏", " "};


        void Wait(int timeToWait)
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
                //Console.CursorVisible = false;
                Console.SetCursorPosition(1,Console.CursorTop);
               //Console.CursorVisible = false;
                //Console.Write(timeWait.Seconds);
                //Console.CursorVisible = false;
                //Console.SetCursorPosition(0,Console.CursorTop-1);
                //Console.CursorVisible = false;
                currentTime = DateTime.Now;
               }
        }
        
        Console.CursorVisible = true;
        Console.Clear();
    }
    Wait(50);

    }
}