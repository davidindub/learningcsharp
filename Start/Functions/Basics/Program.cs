using System;

// Functions are used to group re-usable code together in a single
// unit that can be customized with parameters.

// TODO: Functions have a return type, name, and optional parameters

float MilesToKm(float miles) {
  float result = miles * 1.6f;
  return result;
}

// TODO: A function with no return value has a 'void' type

void PrintWithPrefix(string theStr) {
  Console.WriteLine($"::> {theStr}");
}

// TODO: Call first function

Console.WriteLine($"8 Miles is {MilesToKm(8.0f)}km");
Console.WriteLine($"3 Miles is {MilesToKm(3.0f)}km");
Console.WriteLine($"10 Miles is {MilesToKm(10.0f)}km");

// TODO: Call second function

PrintWithPrefix("Test String");
PrintWithPrefix("Another Test String");
PrintWithPrefix("Finished!!");

