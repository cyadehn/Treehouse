class Program
{
    static void Main(string[] args)
    {
	    System.Console.WriteLine(1.GetType());
	    System.Console.WriteLine("hello".GetType());
	    System.Console.WriteLine('h'.GetType());
	    System.Int32 number = 10;
	    System.String greeting = "Hello. How are you?";
	    System.Console.WriteLine(number + 548);
	    System.Console.WriteLine(greeting + " (I hope they feel well...! Whoops, there's concatenation again showing my thoughts!!)");
	    System.Double keysmash = 3231298376.1209587;
	    System.Console.WriteLine(keysmash.GetType());
	    
	    int number2 = 2;
	    double pi = 3.14;
	    bool what = true;
	    string farewell = "seeya";
	    char first = 'a';
    }
}
