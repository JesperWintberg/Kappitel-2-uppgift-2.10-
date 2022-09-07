using System;
namespace Uppgift2_10
{
    class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Vilken är din favorit bok?");
        Console.WriteLine("Skriv din bok här"); string bok = Console.ReadLine();
        Console.WriteLine("Din favorit bok är" + bok);
    }
}
}