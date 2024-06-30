class Manager
{
    private int additionalScore;
    private List<Goal> allGoals = new List<Goal>();

    public Manager ()
    {

    }
    public void DisplayScore()
    {
        Console.WriteLine(additionalScore);
    }
    private static int AskMenu()//works
    {
        Console.WriteLine("Simple Goal : 1");
        Console.WriteLine("Eternal Goal : 2");
        Console.WriteLine("Check List Goal : 3");
        int state = int.Parse(Console.ReadLine() );
        return state; 
    }
    // public Goal CreateGoal()
    // {
    //     while (true)
    //     {
    //         int state = AskMenu();
    //         switch (state)
    //         {
    //             case 1:
    //                 Console.Clear();
    //                 return new SimpleGoal();
    //             case 2:
    //                 Console.Clear();
    //                 return new EternalGoal();
    //             case 3:
    //                 Console.Clear();
    //                 return new ChecklistGoal();
    //             default:
    //                 Console.WriteLine("Invalid choice. Please try again.");
    //                 break;
    //         } 
    //     }
    // }
    public void AddGoal(Goal passIn)
    {
        allGoals.Add(passIn);
    }
    public void CreateGoal()//works as intended
    {
        while (true)
        {
            int state = AskMenu();
            switch (state)
            {
                case 1:
                    Console.Clear();
                    allGoals.Add(new SimpleGoal());
                    return;
                case 2:
                    Console.Clear();
                    allGoals.Add(new EternalGoal());
                    return;
                case 3:
                    Console.Clear();
                    allGoals.Add(new ChecklistGoal());
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            } 
        }
    }
    public void CheckGoal(int goalNumber)//works as intended
    {
       additionalScore += allGoals[goalNumber-1].MarkComplete();

    }
    public void ListOutGoals()//works as intended
    {
        // Console.Clear();
        for (int i = 0; i < allGoals.Count; i++)
        {
            Console.WriteLine($"{i+1} : {allGoals[i]}");
        } 
    }
    public void PrintGoal(int i)//works
    {
        Console.WriteLine(allGoals[i]);
    }
    // public void LoadGoalFile()
    // {
    //     Console.WriteLine("What file would you like to load from?");
    //     string location = Console.ReadLine();
    //     string[] oldJGoalList = System.IO.File.ReadAllLines(location);
    //     List<Goals> overwrite = new List<Goals>();
    //     foreach (string j in oldJGoalList)
    //         {
    //             overwrite.Add(j);
                
    //             //string[] eachEntry = j.Split("\", \"");
    //         }
    //         allGoals = overwrite;
    //    return allGoals;
    // }
}

