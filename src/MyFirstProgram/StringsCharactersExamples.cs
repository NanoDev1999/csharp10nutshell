public class StringsCharactersExamples
{


    public void Examples()
    {
        Console.WriteLine("StringsCharactersExamples Examples Called");

        char c = 'A'; // Simple character
        char newLine = '\n';
        char backSlash = '\\';

        // unicode example
        char copyrightSymbol = '\u00A9';
        char omegaSymbol = '\u03A9';
        char newLineTestChar = '\u000A';

        string a = "Heat";
        string aTest = "test";
        string b = "test";
        Console.Write(aTest == b); // True

        // strings are reference types


        string aTab = "Here's a tab:\t";

        string a1 = "\\\\server\\fileshare\\helloworld.cs";

        // verbatim string literals
        string a2 = @"\\server\fileshare\helloworld.cs";

        string escaped = "First Line\r\nSecond Line";
        string verbatim = @"First Line
        Second Line";

        // True if your text editor uses CR-LF line separators:
        Console.WriteLine(escaped == verbatim);

        string xml = @"<customer id=""123""></customer>";
        string s = "a" + "b";
        string sAgain = "a" + 5; // a5

        int x = 4;
        Console.Write($"A square has {x} sides"); // Prints: A square has 4 sides

        string sThree = $"255 in hex is {byte.MaxValue:X2}"; // X2 = 2-digit hexadecimal
        // Evaluates to "255 in hex is FF"

        bool bAgain = true;
        Console.WriteLine($"The answer in binary is {(bAgain ? 1 : 0)}");

        int xThree = 2;
        // Note that $ must appear before @ prior to C# 8:
        string sAgainrew = $@"this interpolation spans {
        xThree} lines";

        const string greeting = "Hello";
        const string message = $"{greeting}, world";









    }


}