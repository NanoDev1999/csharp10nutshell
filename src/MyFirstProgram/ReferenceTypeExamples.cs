public class ReferenceTypeExamples
{

    // custom value type with keyword 
    public class Point { public int X; public int Y; }
    // or
    public class PointSmaller { public int X, Y; }


    public void Examples()
    {
        Console.WriteLine("ReferenceTypeExamples Examples Called");

        Point p1 = new Point();
        p1.X = 7;
        Point p2 = p1; // Copies p1 reference
        Console.WriteLine(p1.X); // 7
        Console.WriteLine(p2.X); // 7
        p1.X = 9; // Change p1.X
        Console.WriteLine(p1.X); // 9
        Console.WriteLine(p2.X); // 9


        Point p = null;
        Console.WriteLine (p == null); // True
        // The following line generates a runtime error

        // (a NullReferenceException is thrown):
        // Console.WriteLine (p.X);

        // Point p = null; // Compile-time error
        // int x = null; // Compile-time error


    }


}