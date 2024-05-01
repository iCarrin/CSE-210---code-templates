using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> ();
        Console.WriteLine("This computer will ask you for a series of numbers.\n keep typing them in until you're satisfied. At which point you can hit \"0\" to end the program");
        Console.WriteLine("*BEEP BOOP* GIVE ME A NUMBER *BUZZ BOP*");
        int newNum = int.Parse(Console.ReadLine());

        while (newNum != 0)
        {
            numbers.Add(newNum);
            Console.WriteLine("*BEEP* GIVE ME ANOTHER *BEEP*");
            newNum = int.Parse(Console.ReadLine());
        }
        
        int sum = 0; 
        //int count = 0;
        int largest = -999999999;
        foreach (int number in numbers)
        {
            sum = sum + number;

           // count ++;

            if (number > largest)
            {
                largest = number;
            }            

        }
        Console.WriteLine($"THE SUM OF ALL NUMBERS IS *BUZZ BEEP* \n{sum}!");
        float denominator = (float)numbers.Count;   //(float)count;
        float average = sum/denominator;

        Console.WriteLine ($"*HMMMM* THE MEAN IS \n{average}!");
        Console.WriteLine ($"THE LARGEST NUMBER IN THE LIST IS *BEEP BEEP BEEP* \n{largest}!");

    }
}