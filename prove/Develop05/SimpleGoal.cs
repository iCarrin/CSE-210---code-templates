
using Newtonsoft.Json;

class SimpleGoal : Goal
{
    public SimpleGoal() : base()
    {
    
    }
    public SimpleGoal(string goalName, int pointsGiven) : base(goalName,  pointsGiven)
    {
    
    }
    
    // public override void WriteToFile()
    // {
    //     //Json file crap here
    // }
    
}