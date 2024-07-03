class ChecklistGoal : Goal
{
    /*
    still need to send the points some where and save goal to a file.
    */
    /*private*/ public  int timesToCheck;
    /*private*/ public  int actuallPointsGiven;
    /*private*/ public  int smallPoints;
    /*private*/ public  int bigPoints;
    /*private*/ public  int timesChecked;
    // /*private*/ public string goalName;
    // /*private*/ public  int pointsGiven;
    // /*private*/ public  int pointsGiven;
    //string timesCheckedOff ;


    public ChecklistGoal() : base()//This is for when a user creates a new goal.
    {
        Console.WriteLine("How may times should this goal be checked off before it's totaly complete? ");
        timesToCheck = int.Parse(Console.ReadLine());
        timesChecked = 0;


        smallPoints = pointsGiven/2/timesToCheck; //take points divde in half take that half and divid by total time
        bigPoints = pointsGiven-(smallPoints*timesToCheck); //total minus whats subtracted (this avoids the odd points)

    }
    public ChecklistGoal(string goalName, int pointsGiven, int timesToCheck, int timesChecked) : base(goalName,  pointsGiven) //This is for testing and to rebuild
    {
        // this.goalName = goalName;
        this.timesToCheck = timesToCheck;
        this.timesChecked = timesChecked;


        smallPoints = pointsGiven/2/timesToCheck; //take points divde in half take that half and divid by total time
        bigPoints = pointsGiven-(smallPoints*timesToCheck); //total minus whats subtracted (this avoids the odd points)

    }
    public override int MarkComplete()//works as intended
    {
        
        if (timesToCheck > timesChecked)
        {
            actuallPointsGiven = smallPoints;
        }
        else if (timesChecked == timesToCheck)
        {
            
            actuallPointsGiven = smallPoints+bigPoints;
        }
        // else 
        // {
        //     actuallPointsGiven = 0; //shouldn't be needed
        // }
        TickBox();
        timesChecked ++;
        return actuallPointsGiven;
    }
    // public override void MarkComplete()
    // {
    //     TickBox();
    //     GivePoints();
    //     timesChecked ++;
    // }
    public override string ToString()
    {
        return $"[{GiveBoxValue()}] {goalName} for {actuallPointsGiven} points {timesChecked}/{timesToCheck}";
    }
    // public void TestText()
    // {
    //     Console.WriteLine(goalName);
    //     Console.WriteLine(timesChecked);
    
    //}

    public override void WriteToFile()
    {
        if (timesToCheck != timesChecked)  // this is here to undo your checklist goal if it's already completed we can leave it

        {
            TickBox();
        } 
        //Json file crap here
        //also call the mark complete here
    }
    
}