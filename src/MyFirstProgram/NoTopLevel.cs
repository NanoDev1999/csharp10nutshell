using System;
class ProgramNoTopLevel
{
    static void Main() // Program entry point
    {
        Console.WriteLine("Main Called");
        int x = 12 * 30;
        Console.WriteLine(x);
    }
}

// without top level statement we would have something look like this

// it looks for Main as the entry point, it should be fairly standard in older programs before C# 9.
