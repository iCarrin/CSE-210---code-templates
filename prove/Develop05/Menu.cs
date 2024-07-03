class Menu
{
    int state = 2000;
    Manager currentManager = new Manager();
    string menuList = "Load Goals : 1\nSave Goals : 2\nCheck Off Goals : 3\nCreate Goal : 4\nQuit Program : 0";
    public Menu ()
    {

    }
    // public Manager PreMenu ()
    // {
    //     Console.WriteLine("Would you like to load an old goal list or start a new one? (Old/New) ");
    //     string answer = Console.ReadLine().ToUpper();
    //     while (answer != "OLD" && answer != "NEW")
    //     {  
    //             Console.WriteLine("I'm sorry that was not a valid option "); 
    //     }
    //     if (answer.ToUpper() == "OLD")
    //     {
    //         Manager currentManager = new Manager();
    //         currentManager.LoadGoalFile();
    //         return currentManager;
    //     }
    //     else
    //     {
    //         Manager currentManager = new Manager();
    //         return currentManager;
    //     }
    // }
    // private Manager CreateManager()
    // {
    //     return new Manager();
    // }
    public void CallMenu()
    {
        


        do 
        {
            // preMenu();
            Console.Clear();
            currentManager.DisplayScore();
            Console.WriteLine(menuList);
            Console.WriteLine();
            int goalAmount = currentManager.ListOutGoals();
            state = int.Parse(Console.ReadLine());

            switch (state)
            {
                case 1://load goalasdf
                    Console.Clear();
                    Console.WriteLine(menuList);
                    currentManager.LoadGoalFile();
                    break;
                case 2://save goal stuff
                    Console.Clear();
                    Console.WriteLine(menuList);
                    currentManager.SaveGoalFile();
                    break;
                case 3://check off stuff
                    Console.Clear();
                    currentManager.ListOutGoals();//shows just your goals
                    Console.WriteLine("Which goal are you checking off?");
                    int checkedOff = int.Parse(Console.ReadLine())-1; // gets the number and addjusts for coding
                    Console.Clear();
                    Thread.Sleep(800);
                    currentManager.PrintGoal(checkedOff);//cool dramatic clearing, waiting, showing, waiting, checking, showing, waiting, clearing, and returning back to normal by breaking
                    Thread.Sleep(2000);
                    currentManager.CheckGoal(checkedOff);
                    currentManager.PrintGoal(checkedOff);
                    Thread.Sleep(1000);
                    Console.Clear();                   
                    break;
                case 4://create goal
                    Console.Clear();
                    currentManager.CreateGoal();
                    break;
                case 0:
                Console.Clear();// breaks out of while loop which end the method which is the last method in the program
                
                break;
                default:
                    break;
            }
        } while (state != 0);
    }


}