using System.Text;

public class VarParamExamples
{


    public void Examples()
    {
        Console.WriteLine("VarParamExamples Examples Called");

        StringBuilder ref1 = new StringBuilder("object1");
        Console.WriteLine(ref1);
        // The StringBuilder referenced by ref1 is now eligible for GC.
        StringBuilder ref2 = new StringBuilder("object2");
        StringBuilder ref3 = ref2;
        // The StringBuilder referenced by ref2 is NOT yet eligible for GC.
        Console.WriteLine(ref3); // object2






    }

    static int Factorial(int x)     // recursive, each time it calls a new int is put on the stack
    {
        if (x == 0)
        {
            return 1;
        }
        return x * Factorial(x - 1);
    }


}