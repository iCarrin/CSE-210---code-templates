using System;

class Program
{
    static void Main(string[] args)
    {
        Job test1 = new Job();
        test1.jobTitle = "Pooper scooper";
        test1.company = "Carrin inc";
        test1.startYear = 1977;
        test1.endYear = 2021;
        test1.DisplayJob();

        Job test2 = new Job();
        test2.jobTitle = "Crime fighter";
        test2.company = "Michelangelo Mojo Dojo Casa House Studios ";
        test2.startYear = 2023;
        test2.endYear = 0;
        test2.DisplayJob();



    }
}