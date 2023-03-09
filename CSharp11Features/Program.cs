// See https://aka.ms/new-console-template for more information
using CSharp11Features;

//Generic Math
var genericMath = new GenericMath();
var allNumbers = new[] { 1, 2, 3, 4.5 };
var result = genericMath.AddAll(allNumbers);
Console.WriteLine("----Generic Math----");
Console.WriteLine($"Sum of the array elements {result}");

//Pattern Matching on Span
var patternSpan = new PatternMatchingOnSpan();
patternSpan.PatternMatchonSpan();