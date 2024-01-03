namespace Task1;

public abstract class Shape
{

    protected string Color = "red";
    protected bool Filled = true;
    public Shape() { }
    public Shape(string color, bool filled)
    {
        Color = color;
        Filled = filled;
    }
    public string getColor()
    {
        return Color;
    }
    public void setColor(string color)
    {
        Color = color;
    }
    public Boolean isFilled()
    {
        return Filled;
    }
    public void setFilled(bool filled)
    {
        Filled = filled;
    }

    public abstract double GetArea();
    public abstract double GetPerimeter();
    public override string ToString()
    {
        return $" Shape {Color} {Filled}";
    }


}