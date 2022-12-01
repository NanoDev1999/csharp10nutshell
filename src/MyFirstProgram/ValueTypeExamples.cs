public class ValueTypeExamples
{

    // custom value type with keyword 
    public struct Point { public int X; public int Y; }
    // or
    public struct PointSmaller { public int X, Y; }


    public void Examples()
    {
        Console.WriteLine("ValueTypeExamples Examples Called");

        Point p1 = new Point();
        p1.X = 7;
        Point p2 = p1; // Assignment causes copy
        Console.WriteLine(p1.X); // 7
        Console.WriteLine(p2.X); // 7
        p1.X = 9; // Change p1.X
        Console.WriteLine(p1.X); // 9
        Console.WriteLine(p2.X); // 7
    }


}