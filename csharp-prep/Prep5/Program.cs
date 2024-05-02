using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int userSquare = SquareNumber(userNumber);
        DisplayResult(userName, userSquare);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number");
        int favNumb = int.Parse(Console.ReadLine());
        return favNumb;

    }
    static int SquareNumber(int num)
    {
       int sqNumb = num * num;
       return sqNumb;
    }
    static void DisplayResult(string name, int num)
    {
        Console.WriteLine($"{name} your favorite number squared in {num}");
    }
}