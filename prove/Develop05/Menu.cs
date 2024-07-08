using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
class Menu
{
    int state = 2000;
    
    public static List<Goal> forTesting = new List<Goal>
    {
        new SimpleGoal("be Simple", 300),
        new EternalGoal("think eternaly", 20),
        new ChecklistGoal("check something off", 1000, 20, 3)
    };
    Manager currentManager = new Manager(200, forTesting);
    string menuList = "Load Goals : 1\nSave Goals : 2\nCheck Off Goals : 3\nCreate Goal : 4\nQuit Program : 0";
    public Menu ()
    {

    }
    public void CallMenu()
    {
        


        do 
        {
            currentManager.DisplayScore();
            Console.WriteLine(menuList);
            Console.WriteLine();
            currentManager.ListOutGoals();
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