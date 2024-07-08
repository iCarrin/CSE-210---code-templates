using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
[JsonConverter(typeof(GoalConverter))]
abstract class Goal
{
    private bool isChecked = false;
    public string check = " ";
    [JsonProperty]
    private string goalName = "sauce";
    [JsonProperty]
    protected int pointsGiven;

    public Goal(string goalName, int pointsGiven)
    {
        this.goalName = goalName;
        this.pointsGiven = pointsGiven;
    }

    public Goal()
    {
        Console.WriteLine("What would you like your goal to be called? ");
        goalName = Console.ReadLine();
        Console.WriteLine("How many points should you get once it's copleted? ");
        pointsGiven = int.Parse(Console.ReadLine());

    }
    public virtual bool TickBox()
    {
        isChecked = !isChecked;
        return isChecked;
    }
    public string GiveBoxValue()
    {
        check = isChecked ? "X" : " "; //isItTure ? YES : NO;
        return check;
    }
       public virtual int MarkComplete()
    {
        TickBox();
        return pointsGiven;
    }
    public override string ToString()
    {
        
        return $"[{GiveBoxValue()}] {goalName} for {pointsGiven} points";
    }


}