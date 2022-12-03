

using static System.Console;
// using static imports a type rather than a namespace
// WriteLine("Hello");
// using static System.Windows.Visibility;
// var textBox = new TextBox { Visibility = Hidden }; // XAML-style

namespace N
{
    class A
    {
        static void Main()
        {
            System.Console.WriteLine(new A.B());
            System.Console.WriteLine(new global::A.B());    // this specifies to use the alias in the namespace A
        }
        public class B { }
    }
}
namespace A
{
    class B { }
}


// extern aliasing with ::
// extern alias W1;
// extern alias W2;
// W1::Widgets.Widget w1 = new W1::Widgets.Widget();
// W2::Widgets.Widget w2 = new W2::Widgets.Widget();



namespace N
{
    class A3
    {
        static void Main() => new A3.B1(); // Instantiate class B because of preference and ordering
        public class B1 { } // Nested type
    }
}
namespace A3
{
    class B1 { }
}











// ambiguity with namespaces is a problem so keep your names unique and short and identifiable



namespace Widgets   // compiles to lib1
{
    public class Widget { }
}

namespace Widgets   // problem, if it compiles to lib2.dll then how do you know which dll to do?
{
    public class Widget2 { } // need to rename OR
    // go into csproj file and specifially point out your aliases of Widget with lib1/lib2 .dll
}

// we can use extern for aliasing as well
// extern alias W1;
// extern alias W2;
// W1.Widgets.Widget w1 = new W1.Widgets.Widget();
// W2.Widgets.Widget w2 = new W2.Widgets.Widget();


namespace N1
{
    // al;iassing
    using PropertyInfo2 = System.Reflection.PropertyInfo;
    class Program { PropertyInfo2 p; }




    class Class1 { }
}
namespace N2
{
    using N1;

    using Rzzz = System.Reflection;
    class Programz { Rzzz.PropertyInfo p; } // aliassing

    class Class2 : Class1 { }
}
namespace N2
{
    // class Class3 : Class1 { } // Compile-time error, because it needs N1 using
}




namespace MyNamespace
{
    class Class1 { }
    class Class2 { }
}

// is equivalent to
// namespace MyNamespace; // Applies to everything that follows in the file.
// class Class1 {} // inside MyNamespace
// class Class2 {} // inside MyNamespac

namespace MyTradingCompany
{
    namespace Common
    {
        class ReportBase { }
    }
    namespace ManagementReporting
    {
        class SalesReport : Common.ReportBase { }
    }
}


namespace Outer
{
    class Class1 { }
    namespace Inner
    {
        class Class2 : Class1 { }
    }
}

namespace Outer.Middle.Inner
{
    class Class1 { }
    class Class2 { }
}
// is equivalent to
namespace Outer
{
    namespace Middle
    {
        namespace Inner
        {
            class Class11 { }
            class Class22 { }
        }
    }
}

public class NamespaceExamples
{




    public void Examples()
    {
        Console.WriteLine("NamespaceExamples Examples Called");

        System.Security.Cryptography.RSA rsa = System.Security.Cryptography.RSA.Create();


    }




}