using System;

namespace BetterDecorador
{
    public class Program
    {
        private static void Main(string[] args)
        {
            char symbol = char.Parse(args[1]);
            int times = int.Parse(args[2]);
            Console.WriteLine(Decor(args[0], symbol, times));
        }  
        private static string Decor(string s, char dec, int num)
        {
            return $"{num*dec} {s} {num*dec}";
        } 
    }
}
