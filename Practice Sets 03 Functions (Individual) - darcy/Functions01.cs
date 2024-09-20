using System;

class Program
{
    static void Main()
    {
        double d = 3, j = 4, c = 5;
        Console.WriteLine("Area of the triangle: " + TriangleArea(d, j, c));
    }

    static double TriangleArea(double d, double j, double c)
    {
        double s = (d + j + c) / 2;
        return Math.Sqrt(s * (s - d) * (s - j) * (s - c));
    }
}
