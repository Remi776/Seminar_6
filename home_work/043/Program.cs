void IntersectionCooordinates(double k1, double b1, double k2, double b2)
{
    if (k1 == k2) Console.WriteLine("\nLines are parallel and don't intersect");
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"\nIntersection coordinates: ({x}; {y})");
    }
}

Console.WriteLine("y = k1 * x + b1");
Console.Write("k1 = ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("b1 = ");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("\ny = k2 * x + b2");
Console.Write("k2 = ");
double c = Convert.ToDouble(Console.ReadLine());
Console.Write("b2 = ");
double d = Convert.ToDouble(Console.ReadLine());
IntersectionCooordinates(a, b, c, d);