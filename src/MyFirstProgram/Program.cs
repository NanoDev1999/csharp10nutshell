global using System;    // you can use global to effect all files in a project or compile unit
// there are implicit globals such as System and some others, no need to name them global
using System.Text;
using Animals;





Console.WriteLine("Hello, World!");

int x = 12 * 30;
Console.WriteLine(x);


Console.WriteLine(FeetToInches(30));
Console.WriteLine(FeetToInches(100));

int FeetToInches(int feet)
{
    int inches = feet * 12;
    return inches;
}


SayHello();

void SayHello()
{
    Console.WriteLine("Hello, world");
}



const int y = 360;
Console.WriteLine("y:", y);

string message = "Hello world";
string upperMessage = message.ToUpper();
Console.WriteLine(upperMessage);

int xYear = 2022;
message = message + xYear.ToString();
Console.WriteLine(message);


bool isSimpleVar = false;
if (isSimpleVar)
{
    Console.WriteLine("This will not print");
}

int xFeet = 5000;
bool isLessThanAMile = (xFeet < 5280);
if (isLessThanAMile)
{
    Console.WriteLine("This will print");
}

// create our own types
// moved the type class into UnitConverter.cs
UnitConverter feetToInchesConverter = new UnitConverter(12);
UnitConverter milesToFeetConverter = new UnitConverter(5280);

Console.WriteLine(feetToInchesConverter.Convert(30));
Console.WriteLine(feetToInchesConverter.Convert(100));

Console.WriteLine(feetToInchesConverter.Convert(milesToFeetConverter.Convert(1)));





// created the panda class in its own cs

Panda p1 = new Panda("Pan Dee");
Panda p2 = new Panda("Pan Dah");
Console.WriteLine(p1.Name); // Pan Dee
Console.WriteLine(p2.Name); // Pan Dah
Console.WriteLine(Panda.Population); // 2



// we can move Panda class into the Animals namespace
// although we still have the Panda as its own class too, we need to reference the animals namespace
Animals.Panda p = new Animals.Panda("Pan Dee in Animals");
Console.WriteLine(p.Name);
Console.WriteLine(Animals.Panda.Population); // 1


ConversionExamples conversionExamples = new ConversionExamples();
conversionExamples.Examples();


ValueTypeExamples valueTypeExamples = new ValueTypeExamples();
valueTypeExamples.Examples();

ReferenceTypeExamples referenceTypeExamples = new ReferenceTypeExamples();
referenceTypeExamples.Examples();


int itest = 5;
System.Int32 itest2 = 5;


// Underlying hexadecimal representation
int iHexTest = 7; // 0x7
bool bHexTest = true; // 0x1
char cHexTest = 'A'; // 0x41
float fHexTest = 0.5f; // uses IEEE floating-point encoding


int xLiteralTest = 127;
long yLiteralTest = 0x7F;

int millionUnderscore = 1_000_000; // use underscores to make it more readable

// number in binary with the 0b prefix
var bBinary = 0b1010_1011_1100_1101_1110_1111;


double dDecimalLiteral = 1.5;
double millionExponenitalNotation = 1E06;


Console.WriteLine(1.0.GetType()); // Double (double)
Console.WriteLine(1E06.GetType()); // Double (double)
Console.WriteLine(1.GetType()); // Int32 (int)
Console.WriteLine(0xF0000000.GetType()); // UInt32 (uint)
Console.WriteLine(0x100000000.GetType()); // Int64 (long)

long iImplcitConversion = 5; // Implicit lossless conversion from int literal to long


double xNoDSuffix = 4.0;

// good suffix F usage
float fWithF = 4.5F;
decimal dWithM = -1.23M; // Will not compile without the M suffix.


int xConversion = 12345; // int is a 32-bit integer
long yConversion = xConversion; // Implicit conversion to 64-bit integral type
short zConversion = (short)xConversion; // Explicit conversion to 16-bit integral type



int iConvertFloat = 1;
float fConvertFloat = iConvertFloat;
int i2ConvertFloat = (int)fConvertFloat;


int i1PrecisionLost = 100000001;
float fPrecisionLost = i1PrecisionLost; // Magnitude preserved, precision lost
int i2PrecisionLost = (int)fPrecisionLost; // 100000000






int xIncre = 0, yIncre = 0;
Console.WriteLine(xIncre++); // Outputs 0; x is now 1
Console.WriteLine(++yIncre); // Outputs 1; y is now 1

// Division
int aDivision = 2 / 3; // 0
int bDivision = 0;
// int cDivision = 5 / bDivision; // throws DivideByZeroException


// overflow because going below min value
int aOverflow = int.MinValue;
aOverflow--;
Console.WriteLine(aOverflow == int.MaxValue); // True



int aCheck = 1000000;
int bCheck = 1000000;
// checks 
// int c = checked(a * b); // Checks just the expression.
// checked // Checks all expressions
// { // in statement block.
//     c = a * b;
// }


int xMaxUnchecked = int.MaxValue;
int yMaxUnchecked = unchecked(xMaxUnchecked + 1);
unchecked { int zMaxUnchecked = xMaxUnchecked + 1; }



short xShortConversion = 1, yShortConversion = 1;
// short zShortConversion = xShortConversion + yShortConversion; // Compile-time error because of implicit conversions to int
short zShortConversion = (short)(xShortConversion + yShortConversion); // OK 


// special values
Console.WriteLine(double.NegativeInfinity); // -Infinity
Console.WriteLine(1.0 / 0.0); // Infinity
Console.WriteLine(-1.0 / 0.0); // -Infinity
Console.WriteLine(1.0 / -0.0); // -Infinity
Console.WriteLine(-1.0 / -0.0); // Infinity
Console.WriteLine(0.0 / 0.0); // NaN
Console.WriteLine((1.0 / 0.0) - (1.0 / 0.0)); // NaN
Console.WriteLine(0.0 / 0.0 == double.NaN); // False
Console.WriteLine(double.IsNaN(0.0 / 0.0)); // True
Console.WriteLine(object.Equals(0.0 / 0.0, double.NaN)); // True


// real number rounding errors
float xFloat = 0.1f; // Not quite 0.1
Console.WriteLine(xFloat + xFloat + xFloat + xFloat + xFloat + xFloat + xFloat + xFloat + xFloat + xFloat); // 1.0000001

// use decimals instead
decimal mDecimalNoError = 1M / 6M; // 0.1666666666666666666666666667M
double dDoublError = 1.0 / 6.0; // 0.16666666666666666

decimal notQuiteWholeM = mDecimalNoError + mDecimalNoError + mDecimalNoError + mDecimalNoError + mDecimalNoError + mDecimalNoError; // 1.0000000000000000000000000002M
double notQuiteWholeD = dDoublError + dDoublError + dDoublError + dDoublError + dDoublError + dDoublError; // 0.99999999999999989

Console.WriteLine(notQuiteWholeM == 1M); // False
Console.WriteLine(notQuiteWholeD < 1.0); // True


BooleanTypeOperators booleanTypeOperators = new BooleanTypeOperators();
booleanTypeOperators.Examples();

StringsCharactersExamples stringsCharactersExamples = new StringsCharactersExamples();
stringsCharactersExamples.Examples();

ArrayExamples arrayExamples = new ArrayExamples();
arrayExamples.Examples();

VarParamExamples varParamExamples = new VarParamExamples();
varParamExamples.Examples();




ExpAndOperatorsExamples expAndOperatorsExamples = new ExpAndOperatorsExamples();
expAndOperatorsExamples.Examples();



string someWord = "rosebud";
int someNumber = 42;
bool rich = true, famous = false;



const double cAgain = 2.99792458E08;
// c += 10; // Compile-time Error



// basic scoping
int x4;
{
    int y5;
    // int x4; // Error - x already defined
}
{
    int y5; // OK - y not in scope
}
// Console.Write(y5); // Error - y is out of scope
// Declare variables with declaration statements:
string s88;
int x88, y88;
StringBuilder sb88;
// Expression statements
x = 1 + 2; // Assignment expression
x++; // Increment expression
int yTest = Math.Max(x, 5); // Assignment expression
Console.WriteLine(yTest); // Method call expression
sb88 = new StringBuilder(); // Assignment expression
new StringBuilder(); // Object instantiation expression

new StringBuilder(); // Legal, but useless
new string('c', 3); // Legal, but useless
x.Equals(y); // Legal, but useless


if (5 < 2 * 3)
{

    Console.WriteLine("true"); // true
}

if (5 < 2 * 3)
{
    Console.WriteLine("true");
    Console.WriteLine("Let’s move on!");
}


if (2 + 2 == 5)
{
    Console.WriteLine("Does not compute");
}
else
{
    Console.WriteLine("False"); // False
}




if (2 + 2 == 5)
{
    Console.WriteLine("Does not compute");
}

else
{
    if (2 + 2 == 4)
    {
        Console.WriteLine("Computes"); // Computes
    }
}





if (true)
{
    if (false)
    {
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine("executes");
    }
}





if (true)
{
    if (false)
        Console.WriteLine();
}
else
    Console.WriteLine("does not execute");


void TellMeWhatICanDo(int age)
{
    if (age >= 35)
        Console.WriteLine("You can be president!");
    else if (age >= 21)
        Console.WriteLine("You can drink!");
    else if (age >= 18)
        Console.WriteLine("You can vote!");
    else
        Console.WriteLine("You can wait!");
}



void ShowCard(int cardNumber)
{
    switch (cardNumber)
    {
        case 13:
            Console.WriteLine("King");
            break;
        case 12:
            Console.WriteLine("Queen");
            break;
        case 11:
            Console.WriteLine("Jack");
            break;
        case -1: // Joker is -1
            goto case 12; // In this game joker counts as queen
        default: // Executes for any other cardNumber
            Console.WriteLine(cardNumber);
            break;
    }


    switch (cardNumber)
    {
        case 13:
        case 12:
        case 11:
            Console.WriteLine("Face card");
            break;
        default:
            Console.WriteLine("Plain card");
            break;
    }

    // interesting way to type a switch
    string cardName = cardNumber switch
    {
        13 => "King",
        12 => "Queen",
        11 => "Jack",
        _ => "Pip card" // equivalent to 'default'
    };



    int cardNumberd = 12;
    string suite = "spades";

    // multi value switch
    string cardNumberdz = (cardNumberd, suite) switch
    {
        (13, "spades") => "King of spades",
        (13, "clubs") => "King of clubs",

    };
}


TellMeTheType(12);
TellMeTheType("hello");
TellMeTheType(true);

void TellMeTheType(object x) // object allows any type.
{
    switch (x)
    {
        case int i5:
            Console.WriteLine("It's an int!");
            Console.WriteLine($"The square of {i5} is {i5 * i5}");
            break;
        case string s:
            Console.WriteLine("It's a string");
            Console.WriteLine($"The length of {s} is {s.Length}");
            break;
        case DateTime _:
            Console.WriteLine("It's a DateTime");
            break;
        case null:
            Console.WriteLine("Nothing here");
            break;
        default:
            Console.WriteLine("I don't know what x is");
            break;
    }


    switch (x)
    {
        case float f when f > 1000:
        case double d when d > 1000:
        case decimal m when m > 1000:
            Console.WriteLine("We can refer to x here but not f or d or m");
            break;
    }

    int i = 0;
    while (i < 3)
    {
        Console.Write(i);
        i++;
    }

    int i2 = 0;
    do
    {
        Console.WriteLine(i2);
        i2++;
    }
    while (i2 < 3);



}


for (int i44 = 0; i44 < 3; i44++)
{
    Console.WriteLine(i44);
}

for (int i55 = 0, prevFib = 1, curFib = 1; i55 < 10; i55++)
{
    Console.WriteLine(prevFib);
    int newFib = prevFib + curFib;
    prevFib = curFib; curFib = newFib;
}

// infinite loop
// for (;;){
// Console.WriteLine ("interrupt me");
// }


foreach (char c3 in "beer")
{// c is the iteration variable
    Console.WriteLine(c3);
}




int x987 = 0;
while (true)
{
    if (x987++ > 5)
    {
        break; // break from the loop
    }
}
// execution continues here after break




for (int i53 = 0; i53 < 10; i53++)
{
    if ((i53 % 2) == 0)
    {// If i is even,
        continue; // continue with next iteration
    }
    Console.Write(i53 + " ");
}



int i555 = 1;
startLoop:
if (i555 <= 5)
{
    Console.Write(i555 + " ");
    i555++;
    goto startLoop;
}


decimal AsPercentage(decimal d)
{
    decimal p = d * 100m;
    return p; // Return to the calling method with value
}


int w = 0;
if (w == null){
    throw new ArgumentNullException ();
}


NamespaceExamples namespaceExamples = new NamespaceExamples();
namespaceExamples.Examples();