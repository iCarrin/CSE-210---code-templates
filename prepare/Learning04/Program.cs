using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment oompa_loompa = new Assignment("Kayapo Parrot", "Mixology");
        
            Console.WriteLine(oompa_loompa.GetSummery());
            Console.WriteLine();
        
        WritingAssignment Christopher = new WritingAssignment("Christopher Robin", "Crocheting", "The Art of War - Sun Tzu");

            Console.WriteLine(Christopher.GetSummery());
            Console.WriteLine(Christopher.GetWritingInformation());
            Console.WriteLine();

        MathAssignment jonnyBoy = new MathAssignment("Johnny Lingo", "AP Calculus", "Section 2", "Problems 100-313");

            Console.WriteLine(jonnyBoy.GetSummery());
            Console.WriteLine(jonnyBoy.GetHomeworkList());
            Console.WriteLine();
    }
}