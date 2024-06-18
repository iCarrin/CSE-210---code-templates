using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> steve = new List<Shape>
        {
            new Square(12.3, "Blue"),
            new Rectangle(14.2, 18, "Pink"),
            new Circle(15.4, "Yellow")
        };
        
        foreach (Shape s in steve)
        {
            
            Console.WriteLine($"The {s.GetColor()} shape is {s.GetArea()} big, or that's it's area");

        }

    }
}