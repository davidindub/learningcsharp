using System;

// TODO: Functions can provide default values for their parameters
void PrintWithPrefix(string thestr, string prefix="Hello")
{
    Console.WriteLine($"{prefix} {thestr}");
}

// TODO: Test the default parameters

PrintWithPrefix("David", "Good Afternoon");


// TODO: Call with named params

PrintWithPrefix("Hello");

PrintWithPrefix(thestr: "World", prefix: "Hello");