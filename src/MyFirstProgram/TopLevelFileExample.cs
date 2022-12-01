// using System; // Part 1
// Console.WriteLine ("Hello, world"); // Part 2
// void SomeMethod1() { ... } // Part 2
// Console.WriteLine ("Hello again!"); // Part 2
// void SomeMethod2() { ... } // Part 2
// class SomeClass { ... } // Part 3
// namespace SomeNamespace { ... } // Part 3

// this is an example above

// below is how the compiler would see it

// using System; // Part 1
// static class Program$ // Special compiler-generated name
// {
// static void Main$ (string[] args) // Compiler-generated name
// {
// Console.WriteLine ("Hello, world"); // Part 2
// void SomeMethod1() { ... } // Part 2
// Console.WriteLine ("Hello again!"); // Part 2
// void SomeMethod2() { ... } // Part 2
// }
// }
// class SomeClass { ... } // Part 3
// namespace SomeNamespace { ... } // Part 3

// so you are still doing it, but the compiler fixes that for you.




