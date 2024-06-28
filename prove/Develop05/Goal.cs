abstract class Goal
{
    private bool isChecked = false;
    public string check = " ";
    private string goalName;
    protected int pointsGiven;
    // private string timesCheckedOff;


    public Goal(string goalName, int pointsGiven)
    {
        this.goalName = goalName;
        this.pointsGiven = pointsGiven;
        // timesCheckedOff = "";
        
    }
    public Goal()
    {
        Console.WriteLine("What would you like your goal to be called? ");
        goalName = Console.ReadLine();
        Console.WriteLine("How many points should you get once it's copleted? ");
        pointsGiven = int.Parse(Console.ReadLine());

    }
    // public Goal(string goalName, int pointsGiven, int timesChecked, int timesToCheck)
    // {
    //     this.goalName = goalName;
    //     this.pointsGiven = pointsGiven;
    //     timesCheckedOff = $" {timesChecked}/{timesToCheck}";
    // }

    public virtual bool TickBox()
    {
        isChecked = !isChecked;
        
        
        return isChecked;
    }
    public string GiveBoxValue()
    {
        check = isChecked ? "X" : " ";
        //isItTure ? YES : NO;
        return check;
    }
    protected virtual int GivePoints()
    {
        //Console.WriteLine(pointsGiven);
        //this needs new stuf
        //Its going to immiediatly pull the old score from the file, add this amount, and rewrtie it to the file.
        return 12;
    }
       public virtual void MarkComplete()
    {
        TickBox();
        GivePoints();
    }
    public override string ToString()
    {
        
        return $"[{GiveBoxValue()}] {goalName} for {pointsGiven} points";
    }
     public abstract void WriteToFile();

}