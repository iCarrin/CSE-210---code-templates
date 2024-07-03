using System;
using System.Buffers;

class Program
{
    static void Main(string[] args)
    {
        // SimpleGoal test = new SimpleGoal("complete the program", 50);

        // // Console.WriteLine(test);
        // // test.MarkComplete();
        // // Console.WriteLine(test);

        // ChecklistGoal test2 = new ChecklistGoal("be happy for more than 2 minuets straight", 1000, 20, 0);
        // // Console.WriteLine(test2);
        // test2.MarkComplete();
        // // Console.WriteLine(test2);
        
        // EternalGoal test3 = new EternalGoal("be ok", 10);
        // // Console.WriteLine(test3);
        // // test3.MarkComplete();
        // // Console.WriteLine(test3);
        // Manager test4 = new Manager();
        // test4.AddGoal(test);
        // test4.AddGoal(test2);
        // test4.AddGoal(test3);
        //     // test4.PrintGoalList();
        


       
        // // test4.CheckGoal(2);
        // test4.ListOutGoals();
        // // test4.CreateGoal();
        // // test4.ListOutGoals();
        Menu menu = new Menu();
        menu.CallMenu();
        

        
    }
}