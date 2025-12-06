using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Rectangle s1 = new Rectangle("Brown", 44, 32);
        shapes.Add(s1);
        
        Square s2 = new Square("Green", 52);
        shapes.Add(s2);

        Circle s3 = new Circle("White", 54);
        shapes.Add(s3);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"the {color} shape has an area of {area}.");
        }

    }
}