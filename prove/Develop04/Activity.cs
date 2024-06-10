class Activity
{
    private int durration;
    private int pause = 1000;
    public Activity()
    {
        
    }
    public int GetDurration()
    {
        Console.WriteLine("How long do you want to do this acticity for?");
        int durration = int.Parse(Console.ReadLine());
        return durration;
    }
    public int SetPause(int pause)
    {
        return pause;
    }
    public void Pause()
    {
        Thread.Sleep(pause);
    }
    public void DisplayBye()
    {
        Console.WriteLine($"You did this for {durration}. Have a peaceful day");
    }


}