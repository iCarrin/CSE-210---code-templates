using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        Journal current = new Journal();
        int state = 20;
        do 
        {
            state = current.Menu();
            switch (state)
            {
                case 1:
                    current.AddEntry();
                    break;
                case 2:
                    current.DisplayAll();
                    break;
                case 3:
                    current.SaveJournal();
                    break;
                case 4:
                    current.LoadJournal();
                    break;
                default:
                    break;
            }
        } while (state != 0);

    }
    
}


        // Console.WriteLine("Write new entry : 1");
        // Console.WriteLine("Display current journal : 2");
        // Console.WriteLine("Save current jornal : 3");
        // Console.WriteLine("Load current jornal : 4");
        // Console.WriteLine("Quit : 0");
        // int state = int.Parse(Console.ReadLine());
  