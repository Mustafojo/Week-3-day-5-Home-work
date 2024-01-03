namespace Task1;

public class Rectangle : Shape
{
    protected double Width = 1.0;
    protected double Length = 1.0;
    public Rectangle() { }
    public Rectangle(double width, double length)
    {
        Width = width;
        Length = length;
    }
    public Rectangle(double width, double length, string Color, bool filled) : base(Color, filled)
    {
        Width = width;
        Length = length;
    }
    public virtual double GetWidth()
    {
        return Width;
    }
    public virtual void SetWitdh(double width)
    {
        Width = width;
    }

    public virtual double GetLength()
    {
        return Length;
    }
    public virtual void SetLength(double length)
    {
        Length = length;
    }
    public override double GetArea()
    {
        return Width * Length;
    }
    public override double GetPerimeter()
    {
        return 2 * (Width + Length);
    }
    public override string ToString()
    {
        return $"[{base.ToString()}] ,width = {Width} ,lenght = {Length}";
    }

}
