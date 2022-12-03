public class BooleanTypeOperators
{

    public class Dude
    {
        public string Name;
        public Dude(string n) { Name = n; }
    }




    public void Examples()
    {
        Console.WriteLine("BooleanTypeOperators Examples Called");

        int x = 1;
        int y = 2;
        int z = 1;
        Console.WriteLine(x == y); // False
        Console.WriteLine(x == z); // True

        Dude d1 = new Dude("John");
        Dude d2 = new Dude("John");
        Console.WriteLine(d1 == d2); // False
        Dude d3 = d1;

        Console.WriteLine(d1 == d3); // True




    }


    static bool UseUmbrella(bool rainy, bool sunny, bool windy)
    {
        return !windy && (rainy || sunny);

        // return !windy & (rainy | sunny); // same thing but no short circuiting

        // Short Circuiting, no need to use
        // if (sb != null && sb.Length > 0)
    }


    static int Max (int a, int b)
    {
        return (a > b) ? a : b;     // if true then return a, if false return b
    }
}