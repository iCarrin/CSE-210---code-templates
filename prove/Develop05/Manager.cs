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
    private static int AskMenu()
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
    public void CreateGoal()
    {
        while (true)
        {
            int state = AskMenu();
            switch (state)
            {
                case 1:
                    Console.Clear();
                    allGoals.Add(new SimpleGoal());
                    break;
                case 2:
                    Console.Clear();
                    allGoals.Add(new EternalGoal());
                    break;
                case 3:
                    Console.Clear();
                    allGoals.Add(new ChecklistGoal());
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            } 
        }
    }
    public void CheckGoal(int goalNumber)
    {
       allGoals[goalNumber].MarkComplete();
    }

    public void ListOutGoals()
    {
        Console.Clear();
        for (int i = 1; i < allGoals.Count+2; i++)
        {
            Console.WriteLine($"{i} {allGoals[i]}");
        } 
    }


}

