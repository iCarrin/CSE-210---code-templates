using System;

class Program
{
    static void Main(string[] args)
    {

        int guess;

        Console.WriteLine("Welcome to the magic guessing game!\n\nThe computer will think of a number and then you will try to guess it. With each guess the computer will tell you if it's higher or lower until you guess correctly\n\n");
      //   Console.WriteLine("For the first part of this assignment you will give the number yourself\nWhat is the magic number? ");
      //   string magicWord = Console.ReadLine();
      //   int magicNumber = int.Parse(magicWord);
        Random randoNumbo = new Random();
        int magicNumber = randoNumbo.Next(1, 101);

        Console.WriteLine("Guess a number!");
         
        do
        {
         
         guess = int.Parse(Console.ReadLine());

         if (guess < magicNumber)
         {
            Console.WriteLine("Higher you fool!");
         }

         else if (guess > magicNumber)
         {
            Console.WriteLine("Lower you fool");
         }

         else if (guess == magicNumber)
         {
            Console.WriteLine("You freaking got it! Let's go Baby!!!");
         }

         else 
         {
            Console.WriteLine("How did you get here?");
         }


        } while (guess != magicNumber);






    }
}