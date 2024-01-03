namespace Task1;

public class Circle : Shape
{
    protected double Radius = 1.0;
    public Circle() { }
    public Circle(double radius)
    {
        Radius = radius;
    }
    public Circle(double radius, string Color, bool filled) : base(Color, filled)
    {
        Radius = radius;

    }
    public double GetRadius()
    {
        return Radius;
    }
    public void SetRadius(double radius)
    {
        Radius = radius;
    }
    public override double GetArea()
    {
        return Radius * Radius * 3.14;
    }
    public override double GetPerimeter()
    {
        return 2 * 3.14 * Radius;
    }
    public override string ToString()
    {
        return $"[{base.ToString()}] , radius {Radius}";
    }



}