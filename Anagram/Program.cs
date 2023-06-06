// See https://aka.ms/new-console-template for more information
using Anagram;

Console.WriteLine("Hello, World!");

foreach(var item in await FileReader.ReadFile())
    Console.WriteLine(item);