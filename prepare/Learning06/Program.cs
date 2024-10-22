using System;

class Program
{
    static void Main(string[] args)
    {

        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square ("Square","Blue", 56);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle ("Rectangle", "Gold",109, 203);
        shapes.Add(s2);

        Circle s3 = new Circle ("Circle", "Pink", 768);
        shapes.Add(s3);

        foreach (Shape s in shapes)
        {
            string shape = s.GetShape();
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"The {color} {shape} has an area of {area:F2} square meters.");
        }
    }
}