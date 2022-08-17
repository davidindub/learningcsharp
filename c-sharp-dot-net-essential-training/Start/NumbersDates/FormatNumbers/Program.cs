﻿// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for formatting numerical data in .NET

int[] quarters = { 1, 2, 3, 4 };
int[] sales = { 100000, 150000, 200000, 225000 };
double[] intlMixPct = { .386, .413, .421, .457 };
int val1 = 1234;
decimal val2 = 1234.5678m;

// TODO: Specifying Numerical formatting
// General format is {index[,alignment]:[format]}
// Common types are N (Number), G (General), F (Fixed-point), 
// E (Exponential), D (Decimal), P (Percent), X (Hexadecimal),
// C (Currency in local format)

// Console.WriteLine($"Decimal: {val1:D}, Number: {val1:N}, Fixed-point: {val1:F}, General: {val1:G}");
// Console.WriteLine($"Exponential: {val2:E}, Number: {val2:N}, Fixed-point: {val2:F}, General: {val2:G}");

// TODO: Add a number after the format to specify precision

// Console.WriteLine($"Decimal 6 digits: {val1:D6}, Number 2 digits: {val1:N2}, Fixed-point 1 digit: {val1:F1}, General 3 digits: {val1:G3}");



// TODO: Formatting with alignment and spacing
Console.WriteLine("Sales by Quarter:");
Console.WriteLine($"{quarters[0],12} {quarters[1],12} {quarters[2],12} {quarters[3],12}");
Console.WriteLine($"{sales[0],12:C0} {sales[1],12:C0} {sales[2],12:C0} {sales[3],12:C0}");
Console.WriteLine();
Console.WriteLine("International Sales:");
Console.WriteLine($"{intlMixPct[0],12:P0} {intlMixPct[1],12:P0} {intlMixPct[2],12:P1} {intlMixPct[3],12:P2}");
