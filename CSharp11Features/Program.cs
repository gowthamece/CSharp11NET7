// See https://aka.ms/new-console-template for more information
using CSharp11Features;

Console.WriteLine("Hello, World!");
var genericMath = new GenericMath();

var allNumbers = new[] { 1, 2, 3, 4.5 };
var result = genericMath.AddAll(allNumbers);
Console.WriteLine(result);