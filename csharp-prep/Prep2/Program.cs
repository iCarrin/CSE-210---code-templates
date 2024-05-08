using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string gradeInput = Console.ReadLine();
        int grade = int.Parse(gradeInput);
        string letter = "";


        if (grade < 60)
        {
            // Console.WriteLine("F");
            letter = " F";
        }
        else if (grade <= 69)
        {
            // Console.WriteLine("D");
            letter = " D";
        }
        else if (grade <= 79)
        {
            // Console.WriteLine("C");
            letter = " C";
        }
        else if (grade <= 89)
        {
            // Console.WriteLine("B");
            letter = " B";
        }
        else if (grade <= 100)
        {
            // Console.WriteLine("A");
            letter = "n A";
        }
        else 
        {
            // Console.WriteLine("You've broken my machine");
            letter = "n Error";
        }



        if (grade <= 100 && grade >= 70)
        {
            //Console.WriteLine("Congradulations! You passed with a ");
            Console.WriteLine($"Congrats! You got a{letter}!. You passed the class.");
        }
        else if (grade < 70)
        {
            //Console.WriteLine("Sorry, you failed. Better luck next time. You got a ");
            Console.WriteLine($"Sorry, You got a{letter} which is a failing grade. I know you can do better next time.");
        }
        else
        {
            Console.WriteLine($"You got a{letter} which somehow broke the code.");
        }
    }
}