class Circle : Shape
{
    private double radius;

    public Circle(double radius, string color) : base(color)
    {
        this.radius = radius;
    }

    public override double GetArea()
    {
        return 3.14 * radius * radius;
    }
}