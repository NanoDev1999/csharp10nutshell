public class ArrayExamples
{

    public struct Point { public int X, Y; }
    public class PointAsClass { public int X, Y; }


    public void Examples()
    {
        Console.WriteLine("ArrayExamples Examples Called");
        char[] vowels = new char[5]; // Declare an array of 5 characters

        vowels[0] = 'a';
        vowels[1] = 'e';
        vowels[2] = 'i';
        vowels[3] = 'o';
        vowels[4] = 'u';
        Console.WriteLine(vowels[1]); // e

        for (int i = 0; i < vowels.Length; i++)
        {
            Console.Write(vowels[i]); // aeiou
        }

        char[] vowelsTrue = new char[] { 'a', 'e', 'i', 'o', 'u' };

        char[] vowelsAgain = { 'a', 'e', 'i', 'o', 'u' };

        int[] a = new int[1000];
        Console.Write(a[123]); // 0

        Point[] aAgain = new Point[1000];
        int x = aAgain[500].X; // 0


        PointAsClass[] aClass = new PointAsClass[1000];
        // int xClass = aClass[500].X; // Runtime error, NullReferenceException
        PointAsClass[] aClassAgain = new PointAsClass[1000];
        for (int i = 0; i < aClassAgain.Length; i++)
        { // Iterate i from 0 to 999
            aClassAgain[i] = new PointAsClass(); // Set array element i with new point
        }


        int[] aAgain6 = null; // it's legal


        char[] vowels5 = new char[] { 'a', 'e', 'i', 'o', 'u' };
        char lastElement = vowels5[^1]; // 'u'
        char secondToLast = vowels5[^2]; // 'o'

        Index first = 0;
        Index last = ^1;
        char firstElement = vowels[first]; // 'a'
        char lastElementTwo = vowels[last]; // 'u'


        char[] firstTwo = vowels[..2]; // 'a', 'e'
        char[] lastThree = vowels[2..]; // 'i', 'o', 'u'
        char[] middleOne = vowels[2..3]; // 'i'


        char[] lastTwo = vowels[^2..]; // 'o', 'u'

        Range firstTwoRange = 0..2;
        char[] firstTwoAgain = vowels[firstTwoRange]; // 'a', 'e'

        int[,] matrix = new int[3, 3];


        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = i * 3 + j;
            }
        }

        int[,] matrixAgain = new int[,]
        {
        {0,1,2},
        {3,4,5},
        {6,7,8}
        };


        int[][] matrixJagged = new int[3][];

        for (int i = 0; i < matrixJagged.Length; i++)
        {
            matrixJagged[i] = new int[3]; // Create inner array
            for (int j = 0; j < matrixJagged[i].Length; j++)
            {
                matrixJagged[i][j] = i * 3 + j;
            }

        }


        int[][] matrixJagInit = new int[][]
        {
            new int[] {0,1,2},
            new int[] {3,4,5},
            new int[] {6,7,8,9}
        };


        // simplifications
        char[] vowelsSimple = { 'a', 'e', 'i', 'o', 'u' };
        int[,] rectangularMatrix =
        {
{0,1,2},
{3,4,5},
{6,7,8}
};
        int[][] jaggedMatrix =
        {
new int[] {0,1,2},
new int[] {3,4,5},
new int[] {6,7,8,9}
};



        var iSimple = 3; // i is implicitly of type int
        var sSimple = "sausage"; // s is implicitly of type string
                                 // Therefore:
        var rectMatrix = new int[,] // rectMatrix is implicitly of type int[,]
        {
{0,1,2},
{3,4,5},
{6,7,8}
        };
        var jaggedMat = new int[][] // jaggedMat is implicitly of type int[][]
        {
new int[] {0,1,2},
new int[] {3,4,5},
new int[] {6,7,8,9}
        };



        var vowelsInfers = new[] { 'a', 'e', 'i', 'o', 'u' }; // Compiler infers char[]




        var xComparibleToLong = new[] { 1, 10000000000 }; // all convertible to long





        int[] arr = new int[3];
        // arr[3] = 1; // IndexOutOfRangeException thrown






    }



}