using System;

class Program
{
    static void Main(string[] args)
    {
        Entry time = new Entry();
        Console.WriteLine($"{time.GetTime()}");



        Journal test = new Journal();
        test.AddEntry();
        test.AddEntry();
        test.DisplayAll();

    }
}