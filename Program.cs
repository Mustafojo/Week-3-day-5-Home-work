using Task1;

Circle circle = new Circle();

System.Console.WriteLine("Circle: ");
System.Console.WriteLine(circle.GetRadius());
System.Console.WriteLine(circle.GetArea());
System.Console.WriteLine(circle.GetPerimeter());
System.Console.WriteLine(circle.ToString());
System.Console.WriteLine("-------------------------");


Rectangle rectangle = new Rectangle();

System.Console.WriteLine("Rectangle: ");
System.Console.WriteLine(rectangle.GetWidth());
System.Console.WriteLine(rectangle.GetLength());
System.Console.WriteLine(rectangle.GetArea());
System.Console.WriteLine(rectangle.GetPerimeter());
System.Console.WriteLine(rectangle.ToString());
System.Console.WriteLine("-------------------------");


Square square = new Square();

System.Console.WriteLine("Square: ");
System.Console.WriteLine(square.GetSide());
System.Console.WriteLine(square.ToString());
System.Console.WriteLine("-------------------------");
