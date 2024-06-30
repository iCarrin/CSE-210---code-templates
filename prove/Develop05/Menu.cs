class Menu
{
    int state = 2000;
    string menuList = "Load Goals : 1\nSave Goals : 2\nCheck Off Goals : 3\nCreate Goal : 4\nQuit Program : 0";
    public Menu ()
    {

    }
    // private int AskMenu() ///I wanted to display the menu, then the goals, and then ask what they wanted to do. so i ended up nixing this whole method in favor of a string and a int.parse statment
    // {
    //     Console.WriteLine(menuList);//I have it as a list here to help with writing the console. This way I can write the menue else where without having to call the AskMenu method
    //     int state = int.Parse(Console.ReadLine() );
    //     return state;
    // }
    public void CallMenu(Goal test1, Goal test2, Goal test3)
    {
        Manager theManager = new Manager();


        theManager.AddGoal(test1);
        theManager.AddGoal(test2);
        theManager.AddGoal(test3);
        do 
        {
            theManager.DisplayScore();
            Console.WriteLine(menuList);
            Console.WriteLine();
            theManager.ListOutGoals();
            state = int.Parse(Console.ReadLine());

            switch (state)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine(menuList);
                    //load all the goals and list them
                    break;
                case 2:
                    Console.Clear();

                    break;
                case 3:
                    Console.Clear();
                    theManager.ListOutGoals();
                    Console.WriteLine("Which goal are you checking off?");
                    int checkedOff = int.Parse(Console.ReadLine())-1;
                    Console.Clear();
                    Thread.Sleep(800);
                    theManager.PrintGoal(checkedOff);
                    Thread.Sleep(2000);
                    theManager.CheckGoal(checkedOff);
                    theManager.PrintGoal(checkedOff);
                    Thread.Sleep(1000);
                    Console.Clear();                   
                    break;
                case 4:
                    Console.Clear();
                    theManager.CreateGoal();
                    break;
                case 0:
                Console.Clear();
                
                break;
                default:
                    break;
            }
        } while (state != 0);
    }


}