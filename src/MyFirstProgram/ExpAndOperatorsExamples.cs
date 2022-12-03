public class ExpAndOperatorsExamples
{


    public void Examples()
    {
        Console.WriteLine("ExpAndOperatorsExamples Examples Called");

        Math.Log (1);

        Console.WriteLine (1);

        // 1 + Console.WriteLine (1); // Compile-time error

        int x = 2;
        x = x * 5;

        int y = 5 * (x = 2);


        int a, b, c, d;
        a = b = c = d = 0;


        x *= 2; // equivalent to x = x * 2
        x <<= 1; // equivalent to x = x << 1


        // 1 + 2 * 3
        // is equivalent to
        // 1 + (2 * 3)


        // 8 / 4 / 2   // 1
        // binary operators are left associative, left evaluates first
        // ( 8 / 4 ) / 2 // 1

        // use paranethese to change order
        // 8 / ( 4 / 2 ) // 4


        x = y = 3;  // right associative


        string s1 = null;
        string s2 = s1 ?? "nothing"; // s2 evaluates to "nothing"
        // myVariable ??= someDefault;
        // is equivalent to
        // if (myVariable == null) myVariable = someDefault;


        System.Text.StringBuilder sb = null;
        string s = sb?.ToString(); // No error; s instead evaluates to null
        // is equivalent to
        string sTest = (sb == null ? null : sb.ToString());

        string foo = null;
        char? cAg = foo?[1]; // c is null

        System.Text.StringBuilder sbaga = null;
        string sAga = sbaga?.ToString().ToUpper();

        // x?.y?.z; // causes x 
        // equals
        // x == null ? null: (x.y == null ? null : x.y.z)


        System.Text.StringBuilder sbAgain = null;
        // int length = sb?.ToString().Length; // Illegal : int cannot be null

        int? length = sbAgain?.ToString().Length; // OK: int? can be null






        // someObject?.SomeVoidMethod();   // check void method



        System.Text.StringBuilder sb3 = null;
        string s4 = sb3?.ToString() ?? "nothing"; // s evaluates to "nothing"


        





    }


}