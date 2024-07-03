using System.Text.Json;
class Manager
{

    /*private*/ public int additionalScore;
    /*private*/ public List<Goal> allGoals = new List<Goal>();

    public Manager ()
    {

    }
    public void DisplayScore()
    {
        Console.WriteLine($" current score: {additionalScore}");
    }
    /*private*/ public static int AskMenu()//works
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
    public int ListOutGoals()//works as intended
    {
        for (int i = 0; i < allGoals.Count; i++)
        {
            Console.WriteLine($"{i+1} : {allGoals[i]}");
        } 
        return allGoals.Count();
    }
    public void PrintGoal(int i)//works
    {
        Console.WriteLine(allGoals[i]);
    }
    public void LoadGoalFile()
    {
        if (allGoals.Count() > 0)
        {
            Console.WriteLine("Do you wish to save the current goals before loading new ones? (Y/N)");
            string answer = Console.ReadLine().ToUpper();
            while (answer != "Y" && answer != "N")
            {
                Console.WriteLine("I'm sorry that was not a valid option ");
                answer = Console.ReadLine().ToUpper();
            }
            if (answer == "Y")
            {
                SaveGoalFile();
                allGoals = ReadJsonFileIntoListOfGoals();
            }
            else
            {
                allGoals = ReadJsonFileIntoListOfGoals();
            }            
        } 
        else
        {
            allGoals = ReadJsonFileIntoListOfGoals();
        }
    }
    /*private*/ public List<Goal> ReadJsonFileIntoListOfGoals()
    {
        Console.WriteLine("What file would you like to load from?");
        string location = Console.ReadLine();
        additionalScore = int.Parse(File.ReadAllText(location+"-toteScore"));
        string jsonString = File.ReadAllText(location);
        
        return JsonSerializer.Deserialize<List<Goal>>(jsonString);
        
    }
    public void SaveGoalFile()
    {
        Console.WriteLine("What file would you like to save to?");
        string location = Console.ReadLine();
        string jsonGoalList = JsonSerializer.Serialize(allGoals);
        string score = JsonSerializer.Serialize(additionalScore);
        File.WriteAllText(location+"-toteScore", jsonGoalList); 
        File.WriteAllText(location, jsonGoalList);  

    }
}

