class  Shape
{
    private string color;
    public Shape (string color)
    {
        this.color = color;
    }
    public string GetColor()
    {
        return color;
    }
    // public string SetColor(string color)
    // {
    //     return color;
    // }

    public virtual double GetArea()
    {
        double area = 0;
        return area;
    }
    }