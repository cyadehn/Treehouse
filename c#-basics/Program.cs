class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine(1.GetType());       // Prints "System.Int32"
        System.Console.WriteLine(2.GetType());       // Prints "System.Int32"
        System.Console.WriteLine(3.GetType());       // Prints "System.Int32"
        System.Console.WriteLine("hello".GetType()); // Prints "System.String"
        System.Console.WriteLine("hi".GetType());    // Prints "System.String"
        System.Console.WriteLine(4.GetType());       // Prints "System.Int32"
        System.Console.WriteLine(3.1415.GetType());  // Prints "System.Double"
        System.Console.WriteLine(true.GetType());    // Prints "System.Boolean"
        System.Console.WriteLine("hello".GetType()); // Prints "System.String"
        System.Console.WriteLine('z'.GetType());     // Prints "System.Char"
    }
}
