using System.Text;

public class VarParamExamples
{

    class Test { public static int X; } // field


    class TestAgain
    {
        static int x;
        static void Main() { Foo(out x); }
        static void Foo(out int y)
        {
            Console.WriteLine(x); // x is 0
            y = 1; // Mutate y
            Console.WriteLine(x); // x is 1     // x and y are the same here.
        }
    }


    static void Foo(int p)
    {   // p is a parameter
        p = p + 1; // Increment p by 1
        Console.WriteLine(p); // Write p to screen

    }


    static void Foo(StringBuilder fooSB)
    {
        fooSB.Append("test");
        fooSB = null;
    }


    static void Foo(ref int p)
    {
        p = p + 1; // Increment p by 1
        Console.WriteLine(p); // Write p to screen
    }


    static void Swap(ref string a, ref string b)
    {
        string temp = a;
        a = b;
        b = temp;
    }



    void Split(string name, out string firstNames, out string lastName)
    {
        int i = name.LastIndexOf(' ');
        firstNames = name.Substring(0, i);
        lastName = name.Substring(i + 1);
    }


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

        int x;
        // Console.WriteLine (x); // Compile-time error

        int[] ints = new int[2];
        Console.WriteLine(ints[0]); // 0

        Console.WriteLine(Test.X); // 0

        Console.WriteLine(default(decimal)); // 0

        decimal d = default;


        Foo(8); // 8 is an argument

        int xAgain = 8;
        Foo(xAgain); // Make a copy of x
        Console.WriteLine(xAgain); // x will still be 8


        StringBuilder sb = new StringBuilder();
        Foo(sb);
        Console.WriteLine(sb.ToString()); // test


        int xAgain2 = 8;
        Foo(ref xAgain2); // Ask Foo to deal directly with x
        Console.WriteLine(xAgain2); // x is now 9



        string x5 = "Penn";
        string y = "Teller";
        Swap(ref x5, ref y);
        Console.WriteLine(x5); // Teller
        Console.WriteLine(y); // Penn



        string a, b;
        Split("Stevie Ray Vaughn", out a, out b);
        Console.WriteLine(a); // Stevie Ray
        Console.WriteLine(b); // Vaughn


        Split("Stevie Ray Vaughan", out string a2, out string b2);

        Split("Stevie Ray Vaughan", out string a3, out _); // Discard 2nd param
        Console.WriteLine(a3);


        // discards all but the 4th variable, the int
        // SomeBigMethod (out _, out _, out _, out int x7, out _, out _, out _);


        // the underscore acts as a string, for backwards compatability so dont be fooled
        // string _;
        // Split("Stevie Ray Vaughan", out string acx, out _);
        // Console.WriteLine(_); // Vaughan  



        // in acts as the reverse for out.



        int total = Sum(1, 2, 3, 4);
        // int total = Sum (new int[] { 1, 2, 3, 4 } );
        Console.WriteLine(total); // 10
        // The call to Sum above is equivalent to:
        int total2 = Sum(new int[] { 1, 2, 3, 4 });


        Foo2(); // 23   // compiles to Foo (23);

        Foo3(1); // 1, 0   // mandatory comes first, so this goes into x



        Foo(x: 1, y: 2); // 1, 2

        Foo(y: 2, x: 1); // 1, 2

        int a11 = 0;
        Foo(y: ++a11, x: --a11); // ++a is evaluated first

        Foo(1, y: 2);

        Foo(x: 1, 2); // OK. Arguments in the declared positions

        // you need to use positions and names to stop the confusion
        // or it will compile
        // see y can't come first because x is not named
        // Foo (y:2, 1); // Compile-time error. y isn't in the first position


        Bar(d: 3);


        int[] numbers = { 0, 1, 2, 3, 4 };
        ref int numRef = ref numbers[2];   // force numRef to be a ref to numbers

        numRef *= 10;
        Console.WriteLine(numRef); // 20
        Console.WriteLine(numbers[2]); // 20
                                       // when numRef is modified, so is numbers



        refLocalEx.Main();


        // implicitly typed variables
        var xImplict = "hello";
        var yImplict = new System.Text.StringBuilder();
        var zImplict = (float)Math.PI;

        string xSameAsAbove = "hello";
        System.Text.StringBuilder ySameAsAbove = new System.Text.StringBuilder();
        float zSameAsAbove = (float)Math.PI;

        var xAgainNoType = 5;
        // x = "hello"; // Compile-time error; x is of type int

        Random r = new Random();
        var xRandom = r.Next();     // example of why we should not use implicit types


        System.Text.StringBuilder sb1TargetTyped = new();
        System.Text.StringBuilder sb2TargetTyped = new("Test");

        System.Text.StringBuilder sb1 = new System.Text.StringBuilder();
        System.Text.StringBuilder sb2 = new System.Text.StringBuilder("Test");


        MyMethod (new ("test"));    // test is newly constructed Stringbuilder


    }

    void MyMethod (System.Text.StringBuilder sb) {  }


    class Foo3245
    {
        System.Text.StringBuilder sb;
        public Foo3245(string initialValue)
        {

            sb = new(initialValue);     // creates a new Stringbuilder object here
        }
    }



    public class refLocalEx
    {
        static string x = "Old Value";
        static ref string GetX() => ref x; // This method returns a ref

        string localX = GetX(); // Legal: localX is an ordinary non-ref variable.

        static ref string Prop => ref x;
        static ref readonly string PropReadOnly => ref x;

        public static void Main()
        {
            ref string xRef = ref GetX(); // Assign result to a ref local
            xRef = "New Value";
            Console.WriteLine(x); // New Value


            Prop = "New Value"; // this can also change x, but maybe you don't want that
            // use read only as shown above for prop

        }
    }

    void Bar(int a = 0, int b = 0, int c = 0, int d = 0) { }

    void Foo(int x, int y) { Console.WriteLine(x + ", " + y); }

    void Foo3(int x = 0, int y = 0) { Console.WriteLine(x + ", " + y); }

    void Foo2(int x = 23) { Console.WriteLine(x); }


    int Sum(params int[] ints)
    {
        int sum = 0;
        for (int i = 0; i < ints.Length; i++)
        {
            sum += ints[i]; // Increase sum by ints[i]
        }

        return sum;
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