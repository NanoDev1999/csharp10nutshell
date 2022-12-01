using System;
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

Panda p1 = new Panda ("Pan Dee");
Panda p2 = new Panda ("Pan Dah");
Console.WriteLine (p1.Name); // Pan Dee
Console.WriteLine (p2.Name); // Pan Dah
Console.WriteLine (Panda.Population); // 2



// we can move Panda class into the Animals namespace
// although we still have the Panda as its own class too, we need to reference the animals namespace
Animals.Panda p = new Animals.Panda ("Pan Dee in Animals");
Console.WriteLine (p.Name); 
Console.WriteLine (Animals.Panda.Population); // 1


ConversionExamples conversionExamples = new ConversionExamples();
conversionExamples.Examples();


ValueTypeExamples valueTypeExamples = new ValueTypeExamples();
valueTypeExamples.Examples();

ReferenceTypeExamples referenceTypeExamples = new ReferenceTypeExamples();
referenceTypeExamples.Examples();


