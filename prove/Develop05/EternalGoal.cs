using Newtonsoft.Json;

class EternalGoal : Goal
{
     public EternalGoal() : base()
    {
    
    }
    public EternalGoal(string goalName, int pointsGiven) : base(goalName,  pointsGiven)
    {
    
    }

    
    // public override void WriteToFile()
    // {
    //     TickBox();
    //     //Json file crap here
    //     //also call mark complete here
    // }
}